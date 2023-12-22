
namespace Tyuiu.KornilovKA.Sprint7.Project.V12
{
    partial class FormStatistic
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelStatistic_KKA = new System.Windows.Forms.Panel();
            this.textBoxAvgPrice_KKA = new System.Windows.Forms.TextBox();
            this.labelAvgPrice_KKA = new System.Windows.Forms.Label();
            this.textBoxMaxPrice_KKA = new System.Windows.Forms.TextBox();
            this.labelMaxPrice_KKA = new System.Windows.Forms.Label();
            this.textBoxMinPrice_KKA = new System.Windows.Forms.TextBox();
            this.labelMin_KKA = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControlGraph_KKA = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelStatistic_KKA.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControlGraph_KKA.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelStatistic_KKA
            // 
            this.panelStatistic_KKA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.panelStatistic_KKA.Controls.Add(this.textBoxAvgPrice_KKA);
            this.panelStatistic_KKA.Controls.Add(this.labelAvgPrice_KKA);
            this.panelStatistic_KKA.Controls.Add(this.textBoxMaxPrice_KKA);
            this.panelStatistic_KKA.Controls.Add(this.labelMaxPrice_KKA);
            this.panelStatistic_KKA.Controls.Add(this.textBoxMinPrice_KKA);
            this.panelStatistic_KKA.Controls.Add(this.labelMin_KKA);
            this.panelStatistic_KKA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelStatistic_KKA.Location = new System.Drawing.Point(0, 0);
            this.panelStatistic_KKA.Name = "panelStatistic_KKA";
            this.panelStatistic_KKA.Size = new System.Drawing.Size(235, 396);
            this.panelStatistic_KKA.TabIndex = 0;
            // 
            // textBoxAvgPrice_KKA
            // 
            this.textBoxAvgPrice_KKA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.textBoxAvgPrice_KKA.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAvgPrice_KKA.ForeColor = System.Drawing.Color.White;
            this.textBoxAvgPrice_KKA.Location = new System.Drawing.Point(18, 190);
            this.textBoxAvgPrice_KKA.Name = "textBoxAvgPrice_KKA";
            this.textBoxAvgPrice_KKA.ReadOnly = true;
            this.textBoxAvgPrice_KKA.Size = new System.Drawing.Size(200, 35);
            this.textBoxAvgPrice_KKA.TabIndex = 5;
            this.textBoxAvgPrice_KKA.TabStop = false;
            // 
            // labelAvgPrice_KKA
            // 
            this.labelAvgPrice_KKA.AutoSize = true;
            this.labelAvgPrice_KKA.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAvgPrice_KKA.ForeColor = System.Drawing.Color.White;
            this.labelAvgPrice_KKA.Location = new System.Drawing.Point(13, 156);
            this.labelAvgPrice_KKA.Name = "labelAvgPrice_KKA";
            this.labelAvgPrice_KKA.Size = new System.Drawing.Size(205, 30);
            this.labelAvgPrice_KKA.TabIndex = 4;
            this.labelAvgPrice_KKA.Text = "Средняя стоимость:";
            // 
            // textBoxMaxPrice_KKA
            // 
            this.textBoxMaxPrice_KKA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.textBoxMaxPrice_KKA.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMaxPrice_KKA.ForeColor = System.Drawing.Color.White;
            this.textBoxMaxPrice_KKA.Location = new System.Drawing.Point(18, 118);
            this.textBoxMaxPrice_KKA.Name = "textBoxMaxPrice_KKA";
            this.textBoxMaxPrice_KKA.ReadOnly = true;
            this.textBoxMaxPrice_KKA.Size = new System.Drawing.Size(200, 35);
            this.textBoxMaxPrice_KKA.TabIndex = 3;
            this.textBoxMaxPrice_KKA.TabStop = false;
            // 
            // labelMaxPrice_KKA
            // 
            this.labelMaxPrice_KKA.AutoSize = true;
            this.labelMaxPrice_KKA.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaxPrice_KKA.ForeColor = System.Drawing.Color.White;
            this.labelMaxPrice_KKA.Location = new System.Drawing.Point(13, 85);
            this.labelMaxPrice_KKA.Name = "labelMaxPrice_KKA";
            this.labelMaxPrice_KKA.Size = new System.Drawing.Size(179, 30);
            this.labelMaxPrice_KKA.TabIndex = 2;
            this.labelMaxPrice_KKA.Text = "Макс. стоимость:";
            // 
            // textBoxMinPrice_KKA
            // 
            this.textBoxMinPrice_KKA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.textBoxMinPrice_KKA.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMinPrice_KKA.ForeColor = System.Drawing.Color.White;
            this.textBoxMinPrice_KKA.Location = new System.Drawing.Point(18, 47);
            this.textBoxMinPrice_KKA.Name = "textBoxMinPrice_KKA";
            this.textBoxMinPrice_KKA.ReadOnly = true;
            this.textBoxMinPrice_KKA.Size = new System.Drawing.Size(200, 35);
            this.textBoxMinPrice_KKA.TabIndex = 1;
            this.textBoxMinPrice_KKA.TabStop = false;
            // 
            // labelMin_KKA
            // 
            this.labelMin_KKA.AutoSize = true;
            this.labelMin_KKA.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMin_KKA.ForeColor = System.Drawing.Color.White;
            this.labelMin_KKA.Location = new System.Drawing.Point(13, 13);
            this.labelMin_KKA.Name = "labelMin_KKA";
            this.labelMin_KKA.Size = new System.Drawing.Size(172, 30);
            this.labelMin_KKA.TabIndex = 0;
            this.labelMin_KKA.Text = "Мин. стоимость:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControlGraph_KKA);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(235, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 396);
            this.panel1.TabIndex = 1;
            // 
            // tabControlGraph_KKA
            // 
            this.tabControlGraph_KKA.Controls.Add(this.tabPage1);
            this.tabControlGraph_KKA.Controls.Add(this.tabPage2);
            this.tabControlGraph_KKA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlGraph_KKA.Location = new System.Drawing.Point(0, 0);
            this.tabControlGraph_KKA.Name = "tabControlGraph_KKA";
            this.tabControlGraph_KKA.SelectedIndex = 0;
            this.tabControlGraph_KKA.Size = new System.Drawing.Size(606, 396);
            this.tabControlGraph_KKA.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(598, 370);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Круговая";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(592, 364);
            this.chart1.TabIndex = 0;
            title1.Name = "График";
            this.chart1.Titles.Add(title1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(598, 370);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Столбчатая";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(3, 3);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(592, 364);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart2";
            // 
            // FormStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 396);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelStatistic_KKA);
            this.MinimumSize = new System.Drawing.Size(857, 435);
            this.Name = "FormStatistic";
            this.Text = "Статистика ЭВМ";
            this.Load += new System.EventHandler(this.FormStatistic_Load);
            this.panelStatistic_KKA.ResumeLayout(false);
            this.panelStatistic_KKA.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControlGraph_KKA.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStatistic_KKA;
        private System.Windows.Forms.TextBox textBoxAvgPrice_KKA;
        private System.Windows.Forms.Label labelAvgPrice_KKA;
        private System.Windows.Forms.TextBox textBoxMaxPrice_KKA;
        private System.Windows.Forms.Label labelMaxPrice_KKA;
        private System.Windows.Forms.TextBox textBoxMinPrice_KKA;
        private System.Windows.Forms.Label labelMin_KKA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControlGraph_KKA;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}