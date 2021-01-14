using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 数据分析软件
{
    public partial class Form3 : Form
    {
        public int MaxCount = 100;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }


        private void ChangeAxisY()
        {
            chart1.ChartAreas[0].AxisY.Minimum = chart1.Series[0].Points.Min(i => i.YValues[0]) - 1000;
            chart1.ChartAreas[0].AxisY.Maximum = chart1.Series[0].Points.Max(i => i.YValues[0]) + 1000;
        }

        int count = 0;
        public void AppendData(Int32[] data)
        {
            if (this.Visible)
            {
                this.Invoke(new System.Action(() =>
                {
                    chart1.Series[0].Points.AddXY(count, data[0]);
                    chart1.Series[1].Points.AddXY(count, data[1]);
                    count++;
                    if (count > 10)
                    {
                        lbIQ_Pk_Pk.Text = $"IQ Pk-Pk: {chart1.Series[0].Points.Max(i => i.YValues[0]) - chart1.Series[0].Points.Min(i => i.YValues[0])}";
                        lbIQMax.Text = $"IQ Max:{chart1.Series[0].Points.Max(i => i.YValues[0])}";
                        lbIQMin.Text = $"IQ Min:{chart1.Series[0].Points.Min(i => i.YValues[0])}";

                        lbRefPk.Text = "Ref Pk-Pk:" + (chart1.Series[1].Points.Max(i => i.YValues[0]) - chart1.Series[1].Points.Min(i => i.YValues[0])).ToString();
                        lbRefMax.Text = $"Ref Max:{chart1.Series[1].Points.Max(i => i.YValues[0])}";
                        lbRefMin.Text = $"Ref Min:{chart1.Series[1].Points.Min(i => i.YValues[0])}";
                        ChangeAxisY();
                    }

                    if (chart1.Series[0].Points.Count > MaxCount)
                    {
                        chart1.Series[0].Points.RemoveAt(0);
                        chart1.Series[0].Points.RemoveAt(1);
                        chart1.ChartAreas[0].AxisX.Minimum = chart1.Series[0].Points.First().XValue;
                        chart1.ChartAreas[0].AxisX.Maximum = chart1.Series[0].Points.Last().XValue;


                        chart1.Series[1].Points.RemoveAt(0);
                        chart1.Series[1].Points.RemoveAt(1);
                    }
                }));
            }
        }
        public void Clear()
        {
            count = 0;
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = MaxCount;
        }
    }
}
