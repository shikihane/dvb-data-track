using System;
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
        public Form1()
        {
            InitializeComponent();
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
                var digit = new double[4];
                var match = Regex.Match(buff, @"frequery=(\d+)	 symbol=(\d+) 	 level = (-?\d+),C_N=(-?\d+)");
                var time = DateTime.Now;
                if (match.Success)
                {
                    for (int i = 0; i < match.Groups.Count; i++)
                    {
                        if (i != 0)
                        {
                            //Debug.Write(match.Groups[i].Value + " ");
                            digit[i - 1] = Convert.ToDouble(match.Groups[i].Value);
                        }
                    }
                    //Debug.WriteLine(" ");
                    ApandData(time, digit);
                }
                else
                {
                    if (buff.Contains("reset"))
                    {
                        Log("板子复位！");
                    }
                }
            }
            catch (TimeoutException)
            {
                Log("读取超时!");
            }
            
           
           
        }


        void ChangeXAsix(Chart chart)
        {
            if (chart.Series[0].Points.Count > 100)
            {
                chart.Series[0].Points.RemoveAt(0);
            }
            chart.ChartAreas[0].AxisX.Minimum = chartFreq.Series[0].Points[0].XValue - 0.000001;
            chart.ChartAreas[0].AxisX.Maximum = chartFreq.Series[0].Points.Last().XValue + 0.000001;
        }

        private void ApandData(DateTime time, double[] data)
        {
            this.Invoke(new System.Action(() =>
            {
                chartFreq.Series[0].Points.AddXY(time, data[0]/1000);
                chartSymbol.Series[0].Points.AddXY(time, data[1]/1000);
                chartLevel.Series[0].Points.AddXY(time, data[2]);
                chartCN.Series[0].Points.AddXY(time, data[3]);
                ChangeXAsix(chartFreq);
                ChangeXAsix(chartSymbol);
                ChangeXAsix(chartLevel);
                ChangeXAsix(chartCN);


                if (chartFreq.ChartAreas[0].AxisY.Minimum == 0)
                {
                    chartFreq.ChartAreas[0].AxisY.Minimum = (data[0] / 1000) - 1;
                    Debug.WriteLine($"Freq Min: {chartFreq.ChartAreas[0].AxisY.Minimum}" +
                        $"Freq Max: {chartFreq.ChartAreas[0].AxisY.Maximum}");
                }

                if (chartSymbol.ChartAreas[0].AxisY.Minimum == 0)
                {
                    chartSymbol.ChartAreas[0].AxisY.Minimum = (data[1] / 1000) - 1;
                    Debug.WriteLine($"Symbol Min: {chartSymbol.ChartAreas[0].AxisY.Minimum}" +
                     $"Symbol Max: {chartSymbol.ChartAreas[0].AxisY.Maximum}");
                }

                if (chartLevel.ChartAreas[0].AxisY.Maximum == 0)
                {
                    chartLevel.ChartAreas[0].AxisY.Maximum = (data[2]) + 1;
                    Debug.WriteLine($"Level Min: {chartLevel.ChartAreas[0].AxisY.Minimum}" +
                     $"Level Max: {chartLevel.ChartAreas[0].AxisY.Maximum}");
                }

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
            WSheet.Cells[1, 1] = "时间";
            WSheet.Cells[1, 2] = "频率:KHz";
            WSheet.Cells[1, 3] = "符号率:KHz";
            WSheet.Cells[1, 4] = "电平:dBm";
            WSheet.Cells[1, 5] = "载噪比:dB";

            for (int i = 0; i < chartFreq.Series[0].Points.Count; i++)
            {
                WSheet.Cells[i + 2, 1] = chartFreq.Series[0].Points[i].XValue;
                WSheet.Cells[i + 2, 2] = chartFreq.Series[0].Points[i].YValues[0];
                WSheet.Cells[i + 2, 3] = chartSymbol.Series[0].Points[i].YValues[0];
                WSheet.Cells[i + 2, 4] = chartLevel.Series[0].Points[i].YValues[0];
                WSheet.Cells[i + 2, 5] = chartCN.Series[0].Points[i].YValues[0];
            }
            App.Visible = true;
            MessageBox.Show("保存完毕");
        }

        //Queue Time = new Queue(200);
        //Queue Freqenercy = new Queue(200);
        private void Form1_Load(object sender, EventArgs e)
        {
            btSearch_Click(null, null);
            //chartFreq.Series[0].YValueType = ChartValueType.Double;
            //chartFreq.Series[0].Points.DataBindXY(Time,Freqenercy);
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            btStart_Click(null, null);
            chartFreq.Series[0].Points.Clear();
            chartSymbol.Series[0].Points.Clear();
            chartLevel.Series[0].Points.Clear();
            chartCN.Series[0].Points.Clear();

            chartFreq.ChartAreas[0].AxisY.Minimum = 0;
            chartSymbol.ChartAreas[0].AxisY.Minimum = 0;
            chartLevel.ChartAreas[0].AxisY.Maximum = 0;

            btStart_Click(null, null);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.DoEvents();
            port.DataReceived -= Port_DataReceived;
            port.Close();
        }
    }
}
