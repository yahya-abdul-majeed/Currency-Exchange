
namespace currencyExchange
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.InitialPrice = new System.Windows.Forms.Label();
            this.Currency_1 = new System.Windows.Forms.NumericUpDown();
            this.Currency_2 = new System.Windows.Forms.NumericUpDown();
            this.startStopBtn = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Currency_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Currency_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.startStopBtn);
            this.panel1.Controls.Add(this.Currency_2);
            this.panel1.Controls.Add(this.Currency_1);
            this.panel1.Controls.Add(this.InitialPrice);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Location = new System.Drawing.Point(1, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 351);
            this.panel2.TabIndex = 1;
            // 
            // InitialPrice
            // 
            this.InitialPrice.AutoSize = true;
            this.InitialPrice.Location = new System.Drawing.Point(55, 31);
            this.InitialPrice.Name = "InitialPrice";
            this.InitialPrice.Size = new System.Drawing.Size(73, 17);
            this.InitialPrice.TabIndex = 0;
            this.InitialPrice.Text = "Inital Price";
            // 
            // Currency_1
            // 
            this.Currency_1.Location = new System.Drawing.Point(135, 31);
            this.Currency_1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Currency_1.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.Currency_1.Name = "Currency_1";
            this.Currency_1.Size = new System.Drawing.Size(120, 22);
            this.Currency_1.TabIndex = 1;
            this.Currency_1.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // Currency_2
            // 
            this.Currency_2.Location = new System.Drawing.Point(280, 31);
            this.Currency_2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Currency_2.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.Currency_2.Name = "Currency_2";
            this.Currency_2.Size = new System.Drawing.Size(120, 22);
            this.Currency_2.TabIndex = 2;
            this.Currency_2.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // startStopBtn
            // 
            this.startStopBtn.Location = new System.Drawing.Point(564, 31);
            this.startStopBtn.Name = "startStopBtn";
            this.startStopBtn.Size = new System.Drawing.Size(103, 23);
            this.startStopBtn.TabIndex = 3;
            this.startStopBtn.Text = "Start/Stop";
            this.startStopBtn.UseVisualStyleBackColor = true;
            this.startStopBtn.Click += new System.EventHandler(this.startStopBtn_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Bitcoin";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Etherium";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(799, 351);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Currency_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Currency_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button startStopBtn;
        private System.Windows.Forms.NumericUpDown Currency_2;
        private System.Windows.Forms.NumericUpDown Currency_1;
        private System.Windows.Forms.Label InitialPrice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
    }
}

