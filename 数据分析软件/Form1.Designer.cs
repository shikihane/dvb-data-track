﻿namespace 数据分析软件
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.listSerialPort = new System.Windows.Forms.ListBox();
            this.btConnert = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.chartFreq = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartSymbol = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartLevel = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btStart = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.tbDebug = new System.Windows.Forms.TextBox();
            this.btClear = new System.Windows.Forms.Button();
            this.tbWindow = new System.Windows.Forms.TrackBar();
            this.btFix = new System.Windows.Forms.Button();
            this.btLockForm = new System.Windows.Forms.Button();
            this.btCarr = new System.Windows.Forms.Button();
            this.btACG = new System.Windows.Forms.Button();
            this.btIQ = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSymbol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // listSerialPort
            // 
            this.listSerialPort.FormattingEnabled = true;
            this.listSerialPort.ItemHeight = 12;
            this.listSerialPort.Location = new System.Drawing.Point(45, 9);
            this.listSerialPort.Name = "listSerialPort";
            this.listSerialPort.Size = new System.Drawing.Size(146, 76);
            this.listSerialPort.TabIndex = 0;
            // 
            // btConnert
            // 
            this.btConnert.Location = new System.Drawing.Point(197, 33);
            this.btConnert.Name = "btConnert";
            this.btConnert.Size = new System.Drawing.Size(75, 23);
            this.btConnert.TabIndex = 1;
            this.btConnert.Text = "连接";
            this.btConnert.UseVisualStyleBackColor = true;
            this.btConnert.Click += new System.EventHandler(this.btConnert_Click);
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(197, 4);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 2;
            this.btSearch.Text = "搜索";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(12, 9);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(29, 12);
            this.lb1.TabIndex = 3;
            this.lb1.Text = "串口";
            // 
            // chartFreq
            // 
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisY.Title = "频率:KHz";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY2.Maximum = 3D;
            chartArea1.AxisY2.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chartFreq.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFreq.Legends.Add(legend1);
            this.chartFreq.Location = new System.Drawing.Point(14, 94);
            this.chartFreq.Name = "chartFreq";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Freqencny";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Tomato;
            series2.Legend = "Legend1";
            series2.Name = "CarLock";
            series2.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartFreq.Series.Add(series1);
            this.chartFreq.Series.Add(series2);
            this.chartFreq.Size = new System.Drawing.Size(450, 300);
            this.chartFreq.TabIndex = 4;
            this.chartFreq.Text = "chartFreq";
            this.chartFreq.Paint += new System.Windows.Forms.PaintEventHandler(this.chartFreq_Paint);
            // 
            // chartSymbol
            // 
            chartArea2.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea2.AxisY.Title = "符号率:Kbps";
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisY2.Maximum = 3D;
            chartArea2.AxisY2.Minimum = 0D;
            chartArea2.Name = "ChartArea1";
            this.chartSymbol.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartSymbol.Legends.Add(legend2);
            this.chartSymbol.Location = new System.Drawing.Point(520, 94);
            this.chartSymbol.Name = "chartSymbol";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Symbol";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.OrangeRed;
            series4.Legend = "Legend1";
            series4.Name = "DemodLock";
            series4.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series4.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartSymbol.Series.Add(series3);
            this.chartSymbol.Series.Add(series4);
            this.chartSymbol.Size = new System.Drawing.Size(450, 300);
            this.chartSymbol.TabIndex = 5;
            this.chartSymbol.Text = "chartSymbol";
            // 
            // chartLevel
            // 
            chartArea3.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea3.AxisY.Title = "电平:dBm";
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            chartArea3.Name = "ChartArea1";
            this.chartLevel.ChartAreas.Add(chartArea3);
            this.chartLevel.Location = new System.Drawing.Point(14, 425);
            this.chartLevel.Name = "chartLevel";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Name = "Level";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series5.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chartLevel.Series.Add(series5);
            this.chartLevel.Size = new System.Drawing.Size(450, 300);
            this.chartLevel.TabIndex = 6;
            this.chartLevel.Text = "chartLevel";
            // 
            // chartCN
            // 
            chartArea4.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea4.AxisY.Title = "CN:dB";
            chartArea4.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            chartArea4.Name = "ChartArea1";
            this.chartCN.ChartAreas.Add(chartArea4);
            this.chartCN.Location = new System.Drawing.Point(520, 425);
            this.chartCN.Name = "chartCN";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Name = "Series1";
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series6.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chartCN.Series.Add(series6);
            this.chartCN.Size = new System.Drawing.Size(450, 300);
            this.chartCN.TabIndex = 7;
            this.chartCN.Text = "chartCN";
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(197, 62);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 23);
            this.btStart.TabIndex = 8;
            this.btStart.Text = "开始";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(278, 4);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 8;
            this.btSave.Text = "保存";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // tbDebug
            // 
            this.tbDebug.Location = new System.Drawing.Point(520, 6);
            this.tbDebug.Multiline = true;
            this.tbDebug.Name = "tbDebug";
            this.tbDebug.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDebug.Size = new System.Drawing.Size(450, 79);
            this.tbDebug.TabIndex = 9;
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(278, 33);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 8;
            this.btClear.Text = "清空";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // tbWindow
            // 
            this.tbWindow.Location = new System.Drawing.Point(359, 6);
            this.tbWindow.Minimum = 1;
            this.tbWindow.Name = "tbWindow";
            this.tbWindow.Size = new System.Drawing.Size(155, 45);
            this.tbWindow.TabIndex = 10;
            this.tbWindow.Value = 1;
            this.tbWindow.ValueChanged += new System.EventHandler(this.tbWindow_ValueChanged);
            // 
            // btFix
            // 
            this.btFix.Location = new System.Drawing.Point(278, 65);
            this.btFix.Name = "btFix";
            this.btFix.Size = new System.Drawing.Size(75, 23);
            this.btFix.TabIndex = 8;
            this.btFix.Text = "修复";
            this.btFix.UseVisualStyleBackColor = true;
            this.btFix.Click += new System.EventHandler(this.btFix_Click);
            // 
            // btLockForm
            // 
            this.btLockForm.Location = new System.Drawing.Point(359, 65);
            this.btLockForm.Name = "btLockForm";
            this.btLockForm.Size = new System.Drawing.Size(75, 23);
            this.btLockForm.TabIndex = 11;
            this.btLockForm.Text = "符号锁定";
            this.btLockForm.UseVisualStyleBackColor = true;
            this.btLockForm.Click += new System.EventHandler(this.btLockForm_Click);
            // 
            // btCarr
            // 
            this.btCarr.Location = new System.Drawing.Point(439, 65);
            this.btCarr.Name = "btCarr";
            this.btCarr.Size = new System.Drawing.Size(75, 23);
            this.btCarr.TabIndex = 11;
            this.btCarr.Text = "载波锁定";
            this.btCarr.UseVisualStyleBackColor = true;
            this.btCarr.Click += new System.EventHandler(this.btCarr_Click);
            // 
            // btACG
            // 
            this.btACG.Location = new System.Drawing.Point(359, 36);
            this.btACG.Name = "btACG";
            this.btACG.Size = new System.Drawing.Size(75, 23);
            this.btACG.TabIndex = 11;
            this.btACG.Text = "AGC数值";
            this.btACG.UseVisualStyleBackColor = true;
            this.btACG.Click += new System.EventHandler(this.btACG_Click);
            // 
            // btIQ
            // 
            this.btIQ.Location = new System.Drawing.Point(439, 36);
            this.btIQ.Name = "btIQ";
            this.btIQ.Size = new System.Drawing.Size(75, 23);
            this.btIQ.TabIndex = 11;
            this.btIQ.Text = "IQ监测";
            this.btIQ.UseVisualStyleBackColor = true;
            this.btIQ.Click += new System.EventHandler(this.btIQ_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 762);
            this.Controls.Add(this.btCarr);
            this.Controls.Add(this.btIQ);
            this.Controls.Add(this.btACG);
            this.Controls.Add(this.btLockForm);
            this.Controls.Add(this.tbWindow);
            this.Controls.Add(this.tbDebug);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btFix);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.chartCN);
            this.Controls.Add(this.chartLevel);
            this.Controls.Add(this.chartSymbol);
            this.Controls.Add(this.chartFreq);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.btConnert);
            this.Controls.Add(this.listSerialPort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSymbol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listSerialPort;
        private System.Windows.Forms.Button btConnert;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFreq;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSymbol;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLevel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCN;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TextBox tbDebug;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.TrackBar tbWindow;
        private System.Windows.Forms.Button btFix;
        private System.Windows.Forms.Button btLockForm;
        private System.Windows.Forms.Button btCarr;
        private System.Windows.Forms.Button btACG;
        private System.Windows.Forms.Button btIQ;
    }
}

