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
    public partial class CarrForm : Form
    {
        public int MaxCount = 100;
        public CarrForm()
        {
            InitializeComponent();
        }

        private void CarrForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
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

                    if (chart1.Series[0].Points.Count > MaxCount)
                    {
                        chart1.Series[0].Points.RemoveAt(0);
                        chart1.Series[0].Points.RemoveAt(1);
                        chart1.ChartAreas[0].AxisX.Minimum = chart1.Series[0].Points.First().XValue;
                        chart1.ChartAreas[0].AxisX.Maximum = chart1.Series[0].Points.Last().XValue;
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
