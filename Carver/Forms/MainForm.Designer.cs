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
            grpTestDriveDetails = new GroupBox();
            rtbInterestReason = new RichTextBox();
            lblInterestReason = new Label();
            cmbInterestedModel = new ComboBox();
            lblInterestedModel = new Label();
            lblDateTime = new Label();
            dtpTestDriveDateTime = new DateTimePicker();
            lblTestDriveDetail = new Label();
            grpProspect = new GroupBox();
            lblProspectInfo = new Label();
            lblDrivingLicense = new Label();
            txtAddress = new TextBox();
            txtFirstname = new TextBox();
            chkDisabledVehicle = new CheckBox();
            txtLastname = new TextBox();
            chkScooterLicense = new CheckBox();
            txtEmail = new TextBox();
            chkDrivingLicense = new CheckBox();
            txtPhone = new TextBox();
            txtCity = new TextBox();
            lblFirstname = new Label();
            lblProspectEmail = new Label();
            lblPhone = new Label();
            lblAddress = new Label();
            lblLastname = new Label();
            lblCity = new Label();
            btnTestDriveSubmit = new Button();
            tpScheduled = new TabPage();
            tpCompleted = new TabPage();
            tpStatistics = new TabPage();
            tpEmployeeManagement = new TabPage();
            lblWelcome = new Label();
            lblTitle = new Label();
            btnLogOut = new Button();
            tabMain.SuspendLayout();
            tpNewTestDrive.SuspendLayout();
            grpTestDriveDetails.SuspendLayout();
            grpProspect.SuspendLayout();
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
            tabMain.Size = new Size(776, 463);
            tabMain.TabIndex = 0;
            // 
            // tpDashboard
            // 
            tpDashboard.Location = new Point(4, 29);
            tpDashboard.Name = "tpDashboard";
            tpDashboard.Padding = new Padding(3);
            tpDashboard.Size = new Size(768, 430);
            tpDashboard.TabIndex = 0;
            tpDashboard.Text = "Dashboard";
            tpDashboard.UseVisualStyleBackColor = true;
            // 
            // tpNewTestDrive
            // 
            tpNewTestDrive.Controls.Add(grpTestDriveDetails);
            tpNewTestDrive.Controls.Add(grpProspect);
            tpNewTestDrive.Controls.Add(btnTestDriveSubmit);
            tpNewTestDrive.Location = new Point(4, 29);
            tpNewTestDrive.Name = "tpNewTestDrive";
            tpNewTestDrive.Padding = new Padding(3);
            tpNewTestDrive.Size = new Size(768, 430);
            tpNewTestDrive.TabIndex = 1;
            tpNewTestDrive.Text = "Nieuwe proefrit";
            tpNewTestDrive.UseVisualStyleBackColor = true;
            // 
            // grpTestDriveDetails
            // 
            grpTestDriveDetails.Controls.Add(rtbInterestReason);
            grpTestDriveDetails.Controls.Add(lblInterestReason);
            grpTestDriveDetails.Controls.Add(cmbInterestedModel);
            grpTestDriveDetails.Controls.Add(lblInterestedModel);
            grpTestDriveDetails.Controls.Add(lblDateTime);
            grpTestDriveDetails.Controls.Add(dtpTestDriveDateTime);
            grpTestDriveDetails.Controls.Add(lblTestDriveDetail);
            grpTestDriveDetails.Location = new Point(463, 0);
            grpTestDriveDetails.Name = "grpTestDriveDetails";
            grpTestDriveDetails.Size = new Size(299, 373);
            grpTestDriveDetails.TabIndex = 26;
            grpTestDriveDetails.TabStop = false;
            // 
            // rtbInterestReason
            // 
            rtbInterestReason.Location = new Point(6, 199);
            rtbInterestReason.Name = "rtbInterestReason";
            rtbInterestReason.Size = new Size(287, 168);
            rtbInterestReason.TabIndex = 26;
            rtbInterestReason.Text = "";
            // 
            // lblInterestReason
            // 
            lblInterestReason.AutoSize = true;
            lblInterestReason.Location = new Point(6, 176);
            lblInterestReason.Name = "lblInterestReason";
            lblInterestReason.Size = new Size(126, 20);
            lblInterestReason.TabIndex = 25;
            lblInterestReason.Text = "Reden interesse";
            // 
            // cmbInterestedModel
            // 
            cmbInterestedModel.FormattingEnabled = true;
            cmbInterestedModel.Items.AddRange(new object[] { "Carver Base", "Carver R+", "Carver Range", "Carver S+", "Carver Sport" });
            cmbInterestedModel.Location = new Point(6, 134);
            cmbInterestedModel.Name = "cmbInterestedModel";
            cmbInterestedModel.Size = new Size(210, 28);
            cmbInterestedModel.TabIndex = 24;
            cmbInterestedModel.Text = "Carver Base";
            // 
            // lblInterestedModel
            // 
            lblInterestedModel.AutoSize = true;
            lblInterestedModel.Location = new Point(6, 111);
            lblInterestedModel.Name = "lblInterestedModel";
            lblInterestedModel.Size = new Size(127, 20);
            lblInterestedModel.TabIndex = 23;
            lblInterestedModel.Text = "Model interesse";
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Location = new Point(6, 49);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(107, 20);
            lblDateTime.TabIndex = 22;
            lblDateTime.Text = "Datum en tijd";
            // 
            // dtpTestDriveDateTime
            // 
            dtpTestDriveDateTime.Cursor = Cursors.Hand;
            dtpTestDriveDateTime.CustomFormat = "dd-MM-yyyy HH:mm";
            dtpTestDriveDateTime.Format = DateTimePickerFormat.Custom;
            dtpTestDriveDateTime.Location = new Point(6, 72);
            dtpTestDriveDateTime.Name = "dtpTestDriveDateTime";
            dtpTestDriveDateTime.Size = new Size(210, 27);
            dtpTestDriveDateTime.TabIndex = 21;
            // 
            // lblTestDriveDetail
            // 
            lblTestDriveDetail.AutoSize = true;
            lblTestDriveDetail.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblTestDriveDetail.Location = new Point(6, 12);
            lblTestDriveDetail.Name = "lblTestDriveDetail";
            lblTestDriveDetail.Size = new Size(189, 31);
            lblTestDriveDetail.TabIndex = 20;
            lblTestDriveDetail.Text = "Proefrit Details";
            // 
            // grpProspect
            // 
            grpProspect.Controls.Add(lblProspectInfo);
            grpProspect.Controls.Add(lblDrivingLicense);
            grpProspect.Controls.Add(txtAddress);
            grpProspect.Controls.Add(txtFirstname);
            grpProspect.Controls.Add(chkDisabledVehicle);
            grpProspect.Controls.Add(txtLastname);
            grpProspect.Controls.Add(chkScooterLicense);
            grpProspect.Controls.Add(txtEmail);
            grpProspect.Controls.Add(chkDrivingLicense);
            grpProspect.Controls.Add(txtPhone);
            grpProspect.Controls.Add(txtCity);
            grpProspect.Controls.Add(lblFirstname);
            grpProspect.Controls.Add(lblProspectEmail);
            grpProspect.Controls.Add(lblPhone);
            grpProspect.Controls.Add(lblAddress);
            grpProspect.Controls.Add(lblLastname);
            grpProspect.Controls.Add(lblCity);
            grpProspect.Location = new Point(6, 0);
            grpProspect.Name = "grpProspect";
            grpProspect.Size = new Size(451, 373);
            grpProspect.TabIndex = 25;
            grpProspect.TabStop = false;
            // 
            // lblProspectInfo
            // 
            lblProspectInfo.AutoSize = true;
            lblProspectInfo.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblProspectInfo.Location = new Point(4, 12);
            lblProspectInfo.Name = "lblProspectInfo";
            lblProspectInfo.Size = new Size(230, 31);
            lblProspectInfo.TabIndex = 25;
            lblProspectInfo.Text = "Prospect gegevens";
            // 
            // lblDrivingLicense
            // 
            lblDrivingLicense.AutoSize = true;
            lblDrivingLicense.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblDrivingLicense.Location = new Point(5, 246);
            lblDrivingLicense.Name = "lblDrivingLicense";
            lblDrivingLicense.Size = new Size(203, 27);
            lblDrivingLicense.TabIndex = 24;
            lblDrivingLicense.Text = "Rijbewijs en overig";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(6, 199);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(236, 27);
            txtAddress.TabIndex = 1;
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(6, 72);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(204, 27);
            txtFirstname.TabIndex = 2;
            // 
            // chkDisabledVehicle
            // 
            chkDisabledVehicle.AutoSize = true;
            chkDisabledVehicle.Location = new Point(6, 336);
            chkDisabledVehicle.Name = "chkDisabledVehicle";
            chkDisabledVehicle.Size = new Size(158, 24);
            chkDisabledVehicle.TabIndex = 22;
            chkDisabledVehicle.Text = "Invalidenvoertuig";
            chkDisabledVehicle.UseVisualStyleBackColor = true;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(233, 72);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(148, 27);
            txtLastname.TabIndex = 3;
            // 
            // chkScooterLicense
            // 
            chkScooterLicense.AutoSize = true;
            chkScooterLicense.Location = new Point(6, 306);
            chkScooterLicense.Name = "chkScooterLicense";
            chkScooterLicense.Size = new Size(189, 24);
            chkScooterLicense.TabIndex = 21;
            chkScooterLicense.Text = "Scooterrijbewijs (AM)";
            chkScooterLicense.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(6, 134);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(241, 27);
            txtEmail.TabIndex = 4;
            // 
            // chkDrivingLicense
            // 
            chkDrivingLicense.AutoSize = true;
            chkDrivingLicense.Location = new Point(6, 276);
            chkDrivingLicense.Name = "chkDrivingLicense";
            chkDrivingLicense.Size = new Size(133, 24);
            chkDrivingLicense.TabIndex = 20;
            chkDrivingLicense.Text = "Rijbewijs A / B";
            chkDrivingLicense.UseVisualStyleBackColor = true;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(279, 135);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(148, 27);
            txtPhone.TabIndex = 5;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(279, 199);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(155, 27);
            txtCity.TabIndex = 6;
            // 
            // lblFirstname
            // 
            lblFirstname.AutoSize = true;
            lblFirstname.Location = new Point(6, 49);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(84, 20);
            lblFirstname.TabIndex = 7;
            lblFirstname.Text = "Voornaam";
            // 
            // lblProspectEmail
            // 
            lblProspectEmail.AutoSize = true;
            lblProspectEmail.Location = new Point(6, 111);
            lblProspectEmail.Name = "lblProspectEmail";
            lblProspectEmail.Size = new Size(47, 20);
            lblProspectEmail.TabIndex = 8;
            lblProspectEmail.Text = "Email";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(279, 111);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(135, 20);
            lblPhone.TabIndex = 9;
            lblPhone.Text = "Telefoonnummer";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(6, 176);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(52, 20);
            lblAddress.TabIndex = 10;
            lblAddress.Text = "Adres";
            // 
            // lblLastname
            // 
            lblLastname.AutoSize = true;
            lblLastname.Location = new Point(233, 49);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(97, 20);
            lblLastname.TabIndex = 11;
            lblLastname.Text = "Achternaam";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(279, 176);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(42, 20);
            lblCity.TabIndex = 12;
            lblCity.Text = "Stad";
            // 
            // btnTestDriveSubmit
            // 
            btnTestDriveSubmit.Location = new Point(177, 379);
            btnTestDriveSubmit.Name = "btnTestDriveSubmit";
            btnTestDriveSubmit.Size = new Size(428, 43);
            btnTestDriveSubmit.TabIndex = 23;
            btnTestDriveSubmit.Text = "Proefrit inplannen";
            btnTestDriveSubmit.UseVisualStyleBackColor = true;
            // 
            // tpScheduled
            // 
            tpScheduled.Location = new Point(4, 29);
            tpScheduled.Name = "tpScheduled";
            tpScheduled.Size = new Size(768, 430);
            tpScheduled.TabIndex = 2;
            tpScheduled.Text = "Gepland";
            tpScheduled.UseVisualStyleBackColor = true;
            // 
            // tpCompleted
            // 
            tpCompleted.Location = new Point(4, 29);
            tpCompleted.Name = "tpCompleted";
            tpCompleted.Size = new Size(768, 430);
            tpCompleted.TabIndex = 3;
            tpCompleted.Text = "Uitgevoerd";
            tpCompleted.UseVisualStyleBackColor = true;
            // 
            // tpStatistics
            // 
            tpStatistics.Location = new Point(4, 29);
            tpStatistics.Name = "tpStatistics";
            tpStatistics.Size = new Size(768, 430);
            tpStatistics.TabIndex = 4;
            tpStatistics.Text = "Stastieken";
            tpStatistics.UseVisualStyleBackColor = true;
            // 
            // tpEmployeeManagement
            // 
            tpEmployeeManagement.Location = new Point(4, 29);
            tpEmployeeManagement.Name = "tpEmployeeManagement";
            tpEmployeeManagement.Size = new Size(768, 430);
            tpEmployeeManagement.TabIndex = 5;
            tpEmployeeManagement.Text = "Medewerkers";
            tpEmployeeManagement.UseVisualStyleBackColor = true;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(561, 18);
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
            // btnLogOut
            // 
            btnLogOut.Location = new Point(686, 12);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(102, 32);
            btnLogOut.TabIndex = 3;
            btnLogOut.Text = "Uitloggen";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 541);
            Controls.Add(btnLogOut);
            Controls.Add(lblTitle);
            Controls.Add(lblWelcome);
            Controls.Add(tabMain);
            Name = "MainForm";
            Text = "MainForm";
            tabMain.ResumeLayout(false);
            tpNewTestDrive.ResumeLayout(false);
            grpTestDriveDetails.ResumeLayout(false);
            grpTestDriveDetails.PerformLayout();
            grpProspect.ResumeLayout(false);
            grpProspect.PerformLayout();
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
        private Button btnLogOut;
        private Button btnTestDriveSubmit;
        private GroupBox grpProspect;
        private Label lblDrivingLicense;
        private TextBox txtAddress;
        private TextBox txtFirstname;
        private CheckBox chkDisabledVehicle;
        private TextBox txtLastname;
        private CheckBox chkScooterLicense;
        private TextBox txtEmail;
        private CheckBox chkDrivingLicense;
        private TextBox txtPhone;
        private TextBox txtCity;
        private Label lblFirstname;
        private Label lblProspectEmail;
        private Label lblPhone;
        private Label lblAddress;
        private Label lblLastname;
        private Label lblCity;
        private GroupBox grpTestDriveDetails;
        private RichTextBox rtbInterestReason;
        private Label lblInterestReason;
        private ComboBox cmbInterestedModel;
        private Label lblInterestedModel;
        private Label lblDateTime;
        private DateTimePicker dtpTestDriveDateTime;
        private Label lblTestDriveDetail;
        private Label lblProspectInfo;
    }
}
