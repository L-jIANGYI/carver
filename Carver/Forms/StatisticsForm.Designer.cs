namespace Carver.Forms
{
    partial class StatisticsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            cmbModel = new ComboBox();
            chartBar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            lblTitle = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)chartBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartPie).BeginInit();
            SuspendLayout();
            // 
            // cmbModel
            // 
            cmbModel.FormattingEnabled = true;
            cmbModel.Location = new Point(628, 114);
            cmbModel.Name = "cmbModel";
            cmbModel.Size = new Size(216, 28);
            cmbModel.TabIndex = 5;
            // 
            // chartBar
            // 
            chartArea3.Name = "ChartArea1";
            chartBar.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chartBar.Legends.Add(legend3);
            chartBar.Location = new Point(463, 152);
            chartBar.Name = "chartBar";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartBar.Series.Add(series3);
            chartBar.Size = new Size(560, 495);
            chartBar.TabIndex = 4;
            chartBar.Text = "chart2";
            // 
            // chartPie
            // 
            chartArea4.Name = "ChartArea1";
            chartPie.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            chartPie.Legends.Add(legend4);
            chartPie.Location = new Point(12, 114);
            chartPie.Name = "chartPie";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            chartPie.Series.Add(series4);
            chartPie.Size = new Size(423, 533);
            chartPie.TabIndex = 3;
            chartPie.Text = "chart1";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblTitle.Location = new Point(12, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(525, 40);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "Carvers en Ervaringen statistieken";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(463, 114);
            label1.Name = "label1";
            label1.Size = new Size(158, 27);
            label1.TabIndex = 7;
            label1.Text = "Ervaring model";
            // 
            // StatisticsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 659);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(cmbModel);
            Controls.Add(chartBar);
            Controls.Add(chartPie);
            Name = "StatisticsForm";
            Text = "Carver Statistieken ";
            ((System.ComponentModel.ISupportInitialize)chartBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartPie).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbModel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPie;
        private Label lblTitle;
        private Label label1;
    }
}