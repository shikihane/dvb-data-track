﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;
using System.Reflection;
using System.Threading;
using System.Collections;
using Chart = System.Windows.Forms.DataVisualization.Charting.Chart;

namespace 数据分析软件
{
    public partial class Form1 : Form
    {
        Chart[] charts;
        Form2 LockForm;
        CarrForm Carr;
        Form3 AgcForm;
        IqForm IqForm;

        public Form1()
        {
            InitializeComponent();
            charts = new Chart[]{ chartFreq,chartSymbol,chartLevel,chartCN };
            LockForm = new Form2(this);
            LockForm.Hide();
            Carr = new CarrForm();
            Carr.Hide();
            AgcForm = new Form3();
            AgcForm.Hide();
            IqForm = new IqForm();
            IqForm.Hide();

        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            listSerialPort.Items.Clear();
            foreach (var item in SerialPort.GetPortNames())
            {
                listSerialPort.Items.Add(item);
            }
        }
        SerialPort port;
        private void btConnert_Click(object sender, EventArgs e)
        {
            try
            {
                if (btConnert.Text == "连接")
                {
                    port = new SerialPort(listSerialPort.SelectedItem as string)
                    {
                        BaudRate = 115200,
                        DataBits = 8,
                        Encoding = Encoding.Default,
                        Parity = Parity.None,
                        NewLine = "\n",
                        ReadTimeout = 1000,
                        StopBits = StopBits.One,
                    };
                    port.Open();
                    btConnert.Text = "断开";
                }
                else
                {
                    port.Close();
                    btConnert.Text = "连接";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"出错！消息为：{ex.Message}. 堆栈为:{ex.StackTrace}");
            }

        }

        private void btStart_Click(object sender, EventArgs e)
        {
            if (btStart.Text == "开始")
            {
                port.DataReceived += Port_DataReceived;
                btStart.Text = "停止";
            }
            else
            {
                port.DataReceived -= Port_DataReceived;
                btStart.Text = "开始";
            }
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                var buff = port.ReadLine();
                var digit = new double[6];
                var match = Regex.Match(buff, @"frequery=(\d+)	 symbol=(\d+) 	 level = (-?\d+),C_N=(-?\d+\.\d+)db demodlock=(\d) carlock=(\d)");
                var time = DateTime.Now;
                if (match.Success)
                {
                    for (int i = 0; i < match.Groups.Count; i++)
                    {
                        if (i != 0)
                        {
                            digit[i - 1] = Convert.ToDouble(match.Groups[i].Value);
                        }
                    }           
                    ApandData(time, digit);
                }
                else
                {
                    if (buff.Contains("reset"))
                    {
                        Log("板子复位！");
                    }
                    match = Regex.Match(buff, @"tmglock=(-?\d+)\tlock quality=(\d+)");
                    if (match.Success)
                    {
                        var result = Filter(match.Groups)                          
                            .Select(m => Convert.ToInt32(m))
                            .ToArray();
                        LockForm.AppendData(result);
                    }
                    match = Regex.Match(buff, @"ldi=(-?\d+)\tcarlock=(\d+)");
                    if (match.Success)
                    {
                        var result = Filter(match.Groups)
                            .Select(m => Convert.ToInt32(m))
                            .ToArray();
                        Carr.AppendData(result);
                    }

                    match = Regex.Match(buff, @"agc=(\d+)\tagc_ref=(\d+)");
                    if (match.Success)
                    {
                        var result = Filter(match.Groups)
                            .Select(m => Convert.ToInt32(m))
                            .ToArray();
                        AgcForm.AppendData(result);
                    }

                    match = Regex.Match(buff, @"power i=(\d+) power q=(\d+)");
                    if (match.Success)
                    {
                        var result = Filter(match.Groups)
                            .Select(m => Convert.ToInt32(m))
                            .ToArray();
                        IqForm.AppendData(result);
                    }
                }
            }
            catch (TimeoutException)
            {
                Log("读取超时!");
            }



        }

        private string[] Filter(GroupCollection groups)
        {
            string[] data = new string[groups.Count - 1];
            for (int i = 1; i < groups.Count; i++)
            {
                data[i - 1] = groups[i].Value;
            }
            return data;
        }

        void ChangeXAsix(Chart chart)
        {
            int count = chart.Series[0].Points.Count;
            if (count > MaxCount)
            {
                chart.Series[0].Points.RemoveAt(0);
                chart.ChartAreas[0].AxisX.Minimum = chart.Series[0].Points.First().XValue - 1;
                chart.ChartAreas[0].AxisX.Maximum = chart.Series[0].Points.Last().XValue + 1;
            }
            else
            {
                var remain = count / 100;
                chart.ChartAreas[0].AxisX.Minimum = chart.Series[0].Points.First().XValue - 1;
                chart.ChartAreas[0].AxisX.Maximum = chart.Series[0].Points.First().XValue + remain * 100 + 100;
            }
          
            var min = chart.Series[0].Points.Select(p => p.YValues[0]).Min();
            var max = chart.Series[0].Points.Select(p => p.YValues[0]).Max();
            chart.ChartAreas[0].AxisY.Minimum = min-1;
            chart.ChartAreas[0].AxisY.Maximum = max+1;
        }

        void Change2ndAxis(Chart chart)
        {
            int count = chart.Series[1].Points.Count;
            if (count > MaxCount)
            {
                chart.Series[1].Points.RemoveAt(0);
                chart.ChartAreas[0].AxisX2.Minimum = chart.Series[1].Points.First().XValue - 1;
                chart.ChartAreas[0].AxisX2.Maximum = chart.Series[1].Points.Last().XValue + 1;
            }
            else
            {
                var remain = count / 100;
                chart.ChartAreas[0].AxisX2.Maximum = chart.Series[1].Points.First().XValue + remain * 100 + 100;
                chart.ChartAreas[0].AxisX2.Minimum = chart.Series[1].Points.First().XValue + remain * 100;
            }
        }

        int count = 1;
        int MaxCount = 100;
        private void ApandData(DateTime time, double[] data)
        {
            this.Invoke(new System.Action(() =>
            {
                chartFreq.Series[0].Points.AddXY(count, data[0]/1000);
                chartFreq.Series[1].Points.AddXY(count, data[5]);
                chartSymbol.Series[0].Points.AddXY(count, data[1]/1000);
                chartSymbol.Series[1].Points.AddXY(count, data[4]);
                chartLevel.Series[0].Points.AddXY(count, data[2]);
                chartCN.Series[0].Points.AddXY(count, data[3]);

                ChangeXAsix(chartFreq);
                ChangeXAsix(chartSymbol);
                ChangeXAsix(chartLevel);
                ChangeXAsix(chartCN);

                Change2ndAxis(chartFreq);
                Change2ndAxis(chartSymbol);
                count++;
            }));
        }

        private void Log(string msg)
        {
            tbDebug.Invoke(new System.Action(() => tbDebug.Text += msg));
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            if (btStart.Text == "停止")
            {
                btStart_Click(null,null);
            }
            var App = new Application();
            App.Visible = false;
            var Wbook = (_Workbook)(App.Workbooks.Add(Missing.Value));
            var WSheet = (_Worksheet)Wbook.ActiveSheet;
            WSheet.Cells[1, 1] = "序号";
            WSheet.Cells[1, 2] = "时间"; 
            WSheet.Cells[1, 3] = "频率:KHz"; 
            WSheet.Cells[1, 4] = "符号率:KHz"; 
            WSheet.Cells[1, 5] = "电平:dBm";
            WSheet.Cells[1, 6] = "载噪比:dB";

            for (int i = 0; i < chartFreq.Series[0].Points.Count; i++)
            {
                WSheet.Cells[i + 2, 1] = i;
                WSheet.Cells[i + 2, 2] = chartFreq.Series[0].Points[i].XValue;
                WSheet.Cells[i + 2, 3] = chartFreq.Series[0].Points[i].YValues[0];
                WSheet.Cells[i + 2, 4] = chartSymbol.Series[0].Points[i].YValues[0];
                WSheet.Cells[i + 2, 5] = chartLevel.Series[0].Points[i].YValues[0];
                WSheet.Cells[i + 2, 6] = chartCN.Series[0].Points[i].YValues[0];
            }

            App.Visible = true;
            MessageBox.Show("保存完毕");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btSearch_Click(null, null);
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            count = 1;
            btStart_Click(null, null);
            chartFreq.Series[0].Points.Clear();
            chartSymbol.Series[0].Points.Clear();
            chartFreq.Series[1].Points.Clear();
            chartSymbol.Series[1].Points.Clear();
            chartLevel.Series[0].Points.Clear();
            chartCN.Series[0].Points.Clear();
            tbDebug.Text = "";
            LockForm.Clear();
            Carr.Clear();
            AgcForm.Clear();
            IqForm.Clear();
            btStart_Click(null, null);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.DoEvents();
            port.DataReceived -= Port_DataReceived;
            port.Close();
        }

        void TrunData(Chart chart)
        {
            while (chart.Series[0].Points.Count > MaxCount)
            {
                chart.Series[0].Points.RemoveAt(0);
            }
            if (chart.Series.Count == 2)
            {
                while (chart.Series[1].Points.Count > MaxCount)
                {
                    chart.Series[1].Points.RemoveAt(0);
                }
            }
        }

        

        private void tbWindow_ValueChanged(object sender, EventArgs e)
        {
            btStart_Click(null, null);
            MaxCount = tbWindow.Value * 100;
            LockForm.MaxCount = tbWindow.Value * 100;
            Carr.MaxCount = tbWindow.Value * 100;
            AgcForm.MaxCount = tbWindow.Value * 100;
            IqForm.MaxCount = tbWindow.Value * 100;
            Array.ForEach(charts,chart => TrunData(chart));
            TrunData(LockForm.chart1);
            TrunData(Carr.chart1);
            TrunData(AgcForm.chart1);
            TrunData(IqForm.chart1);
            btStart_Click(null, null);
        }

        private void btFix_Click(object sender, EventArgs e)
        {
            Array.ForEach(charts, chart => {
                chart.ChartAreas[0].AxisX.Minimum = double.NaN;
                chart.ChartAreas[0].AxisX.Maximum = double.NaN;
                chart.ChartAreas[0].AxisY.Minimum = double.NaN;
                chart.ChartAreas[0].AxisY.Maximum = double.NaN;
                if (chart.Series.Count == 2)
                {
                    chart.ChartAreas[0].AxisX2.Minimum = double.NaN;
                    chart.ChartAreas[0].AxisX2.Maximum = double.NaN;
                }
            });
        }

        private void btTest_Click(object sender, EventArgs e)
        {
            Array.ForEach(charts, chart => {
                Log($"X {chart.ChartAreas[0].AxisX.Minimum}:{chart.ChartAreas[0].AxisX.Maximum}:{chart.ChartAreas[0].AxisX.Interval}\r\n");
                Log($"Y {chart.ChartAreas[0].AxisY.Minimum}:{chart.ChartAreas[0].AxisY.Maximum}:{chart.ChartAreas[0].AxisY.Interval}\r\n");
                if (chart.Series.Count == 2)
                {
                    Log($"X2 {chart.ChartAreas[0].AxisX2.Minimum}:{chart.ChartAreas[0].AxisX2.Maximum}::{chart.ChartAreas[0].AxisX2.Interval}\r\n");
                }
            });
        }

        private void chartFreq_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btLockForm_Click(object sender, EventArgs e)
        {
            LockForm.Show();
        }

        private void btCarr_Click(object sender, EventArgs e)
        {
            Carr.Show();
        }

        private void btACG_Click(object sender, EventArgs e)
        {
            AgcForm.Show();
        }

        private void btIQ_Click(object sender, EventArgs e)
        {
            IqForm.Show();
        }
    }
}
