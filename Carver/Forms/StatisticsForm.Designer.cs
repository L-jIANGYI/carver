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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            cmbModel = new ComboBox();
            chartPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            lblTitle = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)chartPie).BeginInit();
            SuspendLayout();
            // 
            // cmbModel
            // 
            cmbModel.FormattingEnabled = true;
            cmbModel.Location = new Point(586, 114);
            cmbModel.Name = "cmbModel";
            cmbModel.Size = new Size(216, 28);
            cmbModel.TabIndex = 5;
            cmbModel.SelectedIndexChanged += cmbModel_SelectedIndexChanged;
            // 
            // chartPie
            // 
            chartArea1.Name = "ChartArea1";
            chartPie.ChartAreas.Add(chartArea1);
            legend1.MaximumAutoSize = 100F;
            legend1.Name = "Legend1";
            chartPie.Legends.Add(legend1);
            chartPie.Location = new Point(12, 114);
            chartPie.Name = "chartPie";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartPie.Series.Add(series1);
            chartPie.Size = new Size(381, 429);
            chartPie.TabIndex = 3;
            chartPie.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Proefritten per model";
            chartPie.Titles.Add(title1);
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
            label1.Location = new Point(421, 114);
            label1.Name = "label1";
            label1.Size = new Size(158, 27);
            label1.TabIndex = 7;
            label1.Text = "Ervaring model";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(421, 157);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(842, 386);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // StatisticsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1275, 559);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(cmbModel);
            Controls.Add(chartPie);
            Name = "StatisticsForm";
            Text = "Carver Statistieken ";
            ((System.ComponentModel.ISupportInitialize)chartPie).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbModel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPie;
        private Label lblTitle;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}