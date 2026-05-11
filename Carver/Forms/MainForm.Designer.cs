namespace Carver
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabMain = new TabControl();
            tpDashboard = new TabPage();
            tpNewTestDrive = new TabPage();
            lblWelcome = new Label();
            lblTitle = new Label();
            tpScheduled = new TabPage();
            tpCompleted = new TabPage();
            tpStatistics = new TabPage();
            tpEmployeeManagement = new TabPage();
            tabMain.SuspendLayout();
            SuspendLayout();
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tpDashboard);
            tabMain.Controls.Add(tpNewTestDrive);
            tabMain.Controls.Add(tpScheduled);
            tabMain.Controls.Add(tpCompleted);
            tabMain.Controls.Add(tpStatistics);
            tabMain.Controls.Add(tpEmployeeManagement);
            tabMain.Location = new Point(12, 70);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(776, 368);
            tabMain.TabIndex = 0;
            // 
            // tpDashboard
            // 
            tpDashboard.Location = new Point(4, 29);
            tpDashboard.Name = "tpDashboard";
            tpDashboard.Padding = new Padding(3);
            tpDashboard.Size = new Size(768, 335);
            tpDashboard.TabIndex = 0;
            tpDashboard.Text = "Dashboard";
            tpDashboard.UseVisualStyleBackColor = true;
            // 
            // tpNewTestDrive
            // 
            tpNewTestDrive.Location = new Point(4, 29);
            tpNewTestDrive.Name = "tpNewTestDrive";
            tpNewTestDrive.Padding = new Padding(3);
            tpNewTestDrive.Size = new Size(768, 335);
            tpNewTestDrive.TabIndex = 1;
            tpNewTestDrive.Text = "Nieuwe proefrit";
            tpNewTestDrive.UseVisualStyleBackColor = true;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(665, 30);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(119, 20);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welkom, Naam";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft YaHei UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblTitle.Location = new Point(12, 11);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(208, 45);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Carver B.V.";
            // 
            // tpScheduled
            // 
            tpScheduled.Location = new Point(4, 29);
            tpScheduled.Name = "tpScheduled";
            tpScheduled.Size = new Size(768, 335);
            tpScheduled.TabIndex = 2;
            tpScheduled.Text = "Gepland";
            tpScheduled.UseVisualStyleBackColor = true;
            // 
            // tpCompleted
            // 
            tpCompleted.Location = new Point(4, 29);
            tpCompleted.Name = "tpCompleted";
            tpCompleted.Size = new Size(768, 335);
            tpCompleted.TabIndex = 3;
            tpCompleted.Text = "Uitgevoerd";
            tpCompleted.UseVisualStyleBackColor = true;
            // 
            // tpStatistics
            // 
            tpStatistics.Location = new Point(4, 29);
            tpStatistics.Name = "tpStatistics";
            tpStatistics.Size = new Size(768, 335);
            tpStatistics.TabIndex = 4;
            tpStatistics.Text = "Stastieken";
            tpStatistics.UseVisualStyleBackColor = true;
            // 
            // tpEmployeeManagement
            // 
            tpEmployeeManagement.Location = new Point(4, 29);
            tpEmployeeManagement.Name = "tpEmployeeManagement";
            tpEmployeeManagement.Size = new Size(768, 335);
            tpEmployeeManagement.TabIndex = 5;
            tpEmployeeManagement.Text = "Medewerkers";
            tpEmployeeManagement.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitle);
            Controls.Add(lblWelcome);
            Controls.Add(tabMain);
            Name = "MainForm";
            Text = "MainForm";
            tabMain.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabMain;
        private TabPage tpDashboard;
        private TabPage tpNewTestDrive;
        private Label lblWelcome;
        private Label lblTitle;
        private TabPage tpScheduled;
        private TabPage tpCompleted;
        private TabPage tpStatistics;
        private TabPage tpEmployeeManagement;
    }
}
