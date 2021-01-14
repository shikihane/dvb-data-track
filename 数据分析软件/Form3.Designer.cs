
namespace 数据分析软件
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbIQ_Pk_Pk = new System.Windows.Forms.Label();
            this.lbIQMax = new System.Windows.Forms.Label();
            this.lbIQMin = new System.Windows.Forms.Label();
            this.lbRefMin = new System.Windows.Forms.Label();
            this.lbRefMax = new System.Windows.Forms.Label();
            this.lbRefPk = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.AxisY2.Maximum = 255D;
            chartArea1.AxisY2.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "AGCIQ";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series2.Legend = "Legend1";
            series2.Name = "AGC_Ref";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(800, 458);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // lbIQ_Pk_Pk
            // 
            this.lbIQ_Pk_Pk.AutoSize = true;
            this.lbIQ_Pk_Pk.Location = new System.Drawing.Point(683, 51);
            this.lbIQ_Pk_Pk.Name = "lbIQ_Pk_Pk";
            this.lbIQ_Pk_Pk.Size = new System.Drawing.Size(41, 12);
            this.lbIQ_Pk_Pk.TabIndex = 2;
            this.lbIQ_Pk_Pk.Text = "Pk-Pk:";
            // 
            // lbIQMax
            // 
            this.lbIQMax.AutoSize = true;
            this.lbIQMax.Location = new System.Drawing.Point(683, 75);
            this.lbIQMax.Name = "lbIQMax";
            this.lbIQMax.Size = new System.Drawing.Size(29, 12);
            this.lbIQMax.TabIndex = 2;
            this.lbIQMax.Text = "Max:";
            // 
            // lbIQMin
            // 
            this.lbIQMin.AutoSize = true;
            this.lbIQMin.Location = new System.Drawing.Point(683, 96);
            this.lbIQMin.Name = "lbIQMin";
            this.lbIQMin.Size = new System.Drawing.Size(29, 12);
            this.lbIQMin.TabIndex = 2;
            this.lbIQMin.Text = "Min:";
            // 
            // lbRefMin
            // 
            this.lbRefMin.AutoSize = true;
            this.lbRefMin.Location = new System.Drawing.Point(683, 167);
            this.lbRefMin.Name = "lbRefMin";
            this.lbRefMin.Size = new System.Drawing.Size(29, 12);
            this.lbRefMin.TabIndex = 3;
            this.lbRefMin.Text = "Min:";
            // 
            // lbRefMax
            // 
            this.lbRefMax.AutoSize = true;
            this.lbRefMax.Location = new System.Drawing.Point(683, 146);
            this.lbRefMax.Name = "lbRefMax";
            this.lbRefMax.Size = new System.Drawing.Size(29, 12);
            this.lbRefMax.TabIndex = 4;
            this.lbRefMax.Text = "Max:";
            // 
            // lbRefPk
            // 
            this.lbRefPk.AutoSize = true;
            this.lbRefPk.Location = new System.Drawing.Point(683, 122);
            this.lbRefPk.Name = "lbRefPk";
            this.lbRefPk.Size = new System.Drawing.Size(41, 12);
            this.lbRefPk.TabIndex = 5;
            this.lbRefPk.Text = "Pk-Pk:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.lbRefMin);
            this.Controls.Add(this.lbRefMax);
            this.Controls.Add(this.lbRefPk);
            this.Controls.Add(this.lbIQMin);
            this.Controls.Add(this.lbIQMax);
            this.Controls.Add(this.lbIQ_Pk_Pk);
            this.Controls.Add(this.chart1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lbIQ_Pk_Pk;
        private System.Windows.Forms.Label lbIQMax;
        private System.Windows.Forms.Label lbIQMin;
        private System.Windows.Forms.Label lbRefMin;
        private System.Windows.Forms.Label lbRefMax;
        private System.Windows.Forms.Label lbRefPk;
    }
}