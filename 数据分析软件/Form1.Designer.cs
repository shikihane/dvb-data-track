namespace 数据分析软件
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbDemodLock = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSymbol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCN)).BeginInit();
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
            chartArea1.Name = "ChartArea1";
            this.chartFreq.ChartAreas.Add(chartArea1);
            this.chartFreq.Location = new System.Drawing.Point(14, 94);
            this.chartFreq.Name = "chartFreq";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Freqencny";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chartFreq.Series.Add(series1);
            this.chartFreq.Size = new System.Drawing.Size(450, 300);
            this.chartFreq.TabIndex = 4;
            this.chartFreq.Text = "chartFreq";
            // 
            // chartSymbol
            // 
            chartArea2.Name = "ChartArea1";
            this.chartSymbol.ChartAreas.Add(chartArea2);
            this.chartSymbol.Location = new System.Drawing.Point(520, 94);
            this.chartSymbol.Name = "chartSymbol";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Name = "Symbol";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chartSymbol.Series.Add(series2);
            this.chartSymbol.Size = new System.Drawing.Size(450, 300);
            this.chartSymbol.TabIndex = 5;
            this.chartSymbol.Text = "chartSymbol";
            // 
            // chartLevel
            // 
            chartArea3.Name = "ChartArea1";
            this.chartLevel.ChartAreas.Add(chartArea3);
            this.chartLevel.Location = new System.Drawing.Point(14, 425);
            this.chartLevel.Name = "chartLevel";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Name = "Level";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chartLevel.Series.Add(series3);
            this.chartLevel.Size = new System.Drawing.Size(450, 300);
            this.chartLevel.TabIndex = 6;
            this.chartLevel.Text = "chartLevel";
            // 
            // chartCN
            // 
            chartArea4.Name = "ChartArea1";
            this.chartCN.ChartAreas.Add(chartArea4);
            this.chartCN.Location = new System.Drawing.Point(520, 425);
            this.chartCN.Name = "chartCN";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Name = "Series1";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chartCN.Series.Add(series4);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "demod锁定:";
            // 
            // lbDemodLock
            // 
            this.lbDemodLock.AutoSize = true;
            this.lbDemodLock.Location = new System.Drawing.Point(433, 73);
            this.lbDemodLock.Name = "lbDemodLock";
            this.lbDemodLock.Size = new System.Drawing.Size(11, 12);
            this.lbDemodLock.TabIndex = 11;
            this.lbDemodLock.Text = "?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 762);
            this.Controls.Add(this.lbDemodLock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDebug);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btSave);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDemodLock;
    }
}

