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
            dgvProspects = new DataGridView();
            FullName = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            colEdit = new DataGridViewButtonColumn();
            colDelete = new DataGridViewButtonColumn();
            tabMain = new TabControl();
            tpDashboard = new TabPage();
            tpNewTestDrive = new TabPage();
            grpTestDriveDetails = new GroupBox();
            rtbInterestReason = new RichTextBox();
            lblInterestReason = new Label();
            btnTestDriveSubmit = new Button();
            cmbInterestedModel = new ComboBox();
            lblInterestedModel = new Label();
            lblDateTime = new Label();
            dtpTestDriveDateTime = new DateTimePicker();
            lblTestDriveDetail = new Label();
            grpProspect = new GroupBox();
            lblCity = new Label();
            lstProspects = new ListBox();
            lblAddress = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            chkIsDisabledVehicle = new CheckBox();
            chkHasScooterLicense = new CheckBox();
            chkHasDrivingLicense = new CheckBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblSearchProspect = new Label();
            txtSearchProspect = new TextBox();
            btnTestDriveNewProspect = new Button();
            lblProspectInfo = new Label();
            tpProspect = new TabPage();
            lstFilteredProspects = new ListBox();
            btnNewProspect = new Button();
            txtSearchProspects = new TextBox();
            tpScheduled = new TabPage();
            lstFilteredScheduled = new ListBox();
            txtSearchScheduled = new TextBox();
            dgvScheduled = new DataGridView();
            colProspectName = new DataGridViewTextBoxColumn();
            colScheduledAt = new DataGridViewTextBoxColumn();
            colCarverModel = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewComboBoxColumn();
            colScheduledEdit = new DataGridViewButtonColumn();
            tpCompleted = new TabPage();
            lstFilteredCompleted = new ListBox();
            txtSearchCompleted = new TextBox();
            dgvCompleted = new DataGridView();
            tpStatistics = new TabPage();
            tpEmployeeManagement = new TabPage();
            lblWelcome = new Label();
            lblTitle = new Label();
            btnLogOut = new Button();
            colCompletedProspectName = new DataGridViewTextBoxColumn();
            colModel = new DataGridViewTextBoxColumn();
            colDateTime = new DataGridViewTextBoxColumn();
            colCompletedStatus = new DataGridViewTextBoxColumn();
            colExperience = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProspects).BeginInit();
            tabMain.SuspendLayout();
            tpNewTestDrive.SuspendLayout();
            grpTestDriveDetails.SuspendLayout();
            grpProspect.SuspendLayout();
            tpProspect.SuspendLayout();
            tpScheduled.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvScheduled).BeginInit();
            tpCompleted.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompleted).BeginInit();
            SuspendLayout();
            // 
            // dgvProspects
            // 
            dgvProspects.AllowUserToAddRows = false;
            dgvProspects.AllowUserToDeleteRows = false;
            dgvProspects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProspects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProspects.Columns.AddRange(new DataGridViewColumn[] { FullName, Email, Phone, colEdit, colDelete });
            dgvProspects.Location = new Point(18, 60);
            dgvProspects.Name = "dgvProspects";
            dgvProspects.ReadOnly = true;
            dgvProspects.RowHeadersWidth = 51;
            dgvProspects.Size = new Size(727, 358);
            dgvProspects.TabIndex = 3;
            dgvProspects.CellClick += dgvProspects_CellClick;
            // 
            // FullName
            // 
            FullName.DataPropertyName = "FullName";
            FullName.HeaderText = "Naam";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Phone
            // 
            Phone.DataPropertyName = "Phone";
            Phone.HeaderText = "Telefoon";
            Phone.MinimumWidth = 6;
            Phone.Name = "Phone";
            Phone.ReadOnly = true;
            // 
            // colEdit
            // 
            colEdit.HeaderText = "";
            colEdit.MinimumWidth = 6;
            colEdit.Name = "colEdit";
            colEdit.ReadOnly = true;
            colEdit.Text = "Bijwerken";
            colEdit.UseColumnTextForButtonValue = true;
            // 
            // colDelete
            // 
            colDelete.HeaderText = "";
            colDelete.MinimumWidth = 6;
            colDelete.Name = "colDelete";
            colDelete.ReadOnly = true;
            colDelete.Text = "Verwijderen";
            colDelete.UseColumnTextForButtonValue = true;
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tpDashboard);
            tabMain.Controls.Add(tpNewTestDrive);
            tabMain.Controls.Add(tpProspect);
            tabMain.Controls.Add(tpScheduled);
            tabMain.Controls.Add(tpCompleted);
            tabMain.Controls.Add(tpStatistics);
            tabMain.Controls.Add(tpEmployeeManagement);
            tabMain.Location = new Point(12, 70);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(776, 463);
            tabMain.TabIndex = 0;
            tabMain.SelectedIndexChanged += tabMain_SelectedIndexChanged;
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
            grpTestDriveDetails.Controls.Add(btnTestDriveSubmit);
            grpTestDriveDetails.Controls.Add(cmbInterestedModel);
            grpTestDriveDetails.Controls.Add(lblInterestedModel);
            grpTestDriveDetails.Controls.Add(lblDateTime);
            grpTestDriveDetails.Controls.Add(dtpTestDriveDateTime);
            grpTestDriveDetails.Controls.Add(lblTestDriveDetail);
            grpTestDriveDetails.Location = new Point(6, 3);
            grpTestDriveDetails.Name = "grpTestDriveDetails";
            grpTestDriveDetails.Size = new Size(333, 421);
            grpTestDriveDetails.TabIndex = 26;
            grpTestDriveDetails.TabStop = false;
            // 
            // rtbInterestReason
            // 
            rtbInterestReason.Location = new Point(6, 199);
            rtbInterestReason.Name = "rtbInterestReason";
            rtbInterestReason.Size = new Size(321, 168);
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
            // btnTestDriveSubmit
            // 
            btnTestDriveSubmit.Location = new Point(6, 372);
            btnTestDriveSubmit.Name = "btnTestDriveSubmit";
            btnTestDriveSubmit.Size = new Size(171, 43);
            btnTestDriveSubmit.TabIndex = 23;
            btnTestDriveSubmit.Text = "Proefrit inplannen";
            btnTestDriveSubmit.UseVisualStyleBackColor = true;
            btnTestDriveSubmit.Click += btnTestDriveSubmit_Click;
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
            grpProspect.Controls.Add(lblCity);
            grpProspect.Controls.Add(lstProspects);
            grpProspect.Controls.Add(lblAddress);
            grpProspect.Controls.Add(lblPhone);
            grpProspect.Controls.Add(lblEmail);
            grpProspect.Controls.Add(lblLastName);
            grpProspect.Controls.Add(lblFirstName);
            grpProspect.Controls.Add(chkIsDisabledVehicle);
            grpProspect.Controls.Add(chkHasScooterLicense);
            grpProspect.Controls.Add(chkHasDrivingLicense);
            grpProspect.Controls.Add(label9);
            grpProspect.Controls.Add(label8);
            grpProspect.Controls.Add(label7);
            grpProspect.Controls.Add(label6);
            grpProspect.Controls.Add(label5);
            grpProspect.Controls.Add(label4);
            grpProspect.Controls.Add(label3);
            grpProspect.Controls.Add(label2);
            grpProspect.Controls.Add(label1);
            grpProspect.Controls.Add(lblSearchProspect);
            grpProspect.Controls.Add(txtSearchProspect);
            grpProspect.Controls.Add(btnTestDriveNewProspect);
            grpProspect.Controls.Add(lblProspectInfo);
            grpProspect.Location = new Point(347, 3);
            grpProspect.Name = "grpProspect";
            grpProspect.Size = new Size(418, 421);
            grpProspect.TabIndex = 25;
            grpProspect.TabStop = false;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(58, 274);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(0, 20);
            lblCity.TabIndex = 47;
            // 
            // lstProspects
            // 
            lstProspects.FormattingEnabled = true;
            lstProspects.Location = new Point(6, 95);
            lstProspects.Name = "lstProspects";
            lstProspects.Size = new Size(205, 124);
            lstProspects.TabIndex = 29;
            lstProspects.Visible = false;
            lstProspects.SelectedIndexChanged += lstProspects_SelectedIndexChanged;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(68, 244);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(0, 20);
            lblAddress.TabIndex = 46;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(90, 213);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(0, 20);
            lblPhone.TabIndex = 45;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(63, 177);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(0, 20);
            lblEmail.TabIndex = 44;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(113, 146);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(0, 20);
            lblLastName.TabIndex = 43;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(100, 112);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(0, 20);
            lblFirstName.TabIndex = 42;
            // 
            // chkIsDisabledVehicle
            // 
            chkIsDisabledVehicle.AutoCheck = false;
            chkIsDisabledVehicle.AutoSize = true;
            chkIsDisabledVehicle.Location = new Point(206, 370);
            chkIsDisabledVehicle.Name = "chkIsDisabledVehicle";
            chkIsDisabledVehicle.Size = new Size(18, 17);
            chkIsDisabledVehicle.TabIndex = 41;
            chkIsDisabledVehicle.UseVisualStyleBackColor = true;
            // 
            // chkHasScooterLicense
            // 
            chkHasScooterLicense.AutoCheck = false;
            chkHasScooterLicense.AutoSize = true;
            chkHasScooterLicense.Location = new Point(206, 340);
            chkHasScooterLicense.Name = "chkHasScooterLicense";
            chkHasScooterLicense.Size = new Size(18, 17);
            chkHasScooterLicense.TabIndex = 40;
            chkHasScooterLicense.UseVisualStyleBackColor = true;
            // 
            // chkHasDrivingLicense
            // 
            chkHasDrivingLicense.AutoCheck = false;
            chkHasDrivingLicense.AutoSize = true;
            chkHasDrivingLicense.Location = new Point(206, 308);
            chkHasDrivingLicense.Name = "chkHasDrivingLicense";
            chkHasDrivingLicense.Size = new Size(18, 17);
            chkHasDrivingLicense.TabIndex = 39;
            chkHasDrivingLicense.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 274);
            label9.Name = "label9";
            label9.Size = new Size(46, 20);
            label9.TabIndex = 38;
            label9.Text = "Stad:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 367);
            label8.Name = "label8";
            label8.Size = new Size(140, 20);
            label8.TabIndex = 37;
            label8.Text = "Invalidenvoertuig:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 308);
            label7.Name = "label7";
            label7.Size = new Size(139, 20);
            label7.TabIndex = 36;
            label7.Text = "Rijbewijs B/B+/BE:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 244);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 35;
            label6.Text = "Adres:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 337);
            label5.Name = "label5";
            label5.Size = new Size(171, 20);
            label5.TabIndex = 34;
            label5.Text = "Scooterrijbewijs (AM):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 213);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 33;
            label4.Text = "Telefoon:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 177);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 32;
            label3.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 146);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 31;
            label2.Text = "Achternaam:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 112);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 30;
            label1.Text = "Voornaam:";
            // 
            // lblSearchProspect
            // 
            lblSearchProspect.AutoSize = true;
            lblSearchProspect.Location = new Point(6, 49);
            lblSearchProspect.Name = "lblSearchProspect";
            lblSearchProspect.Size = new Size(119, 20);
            lblSearchProspect.TabIndex = 30;
            lblSearchProspect.Text = "Zoek prospect:";
            // 
            // txtSearchProspect
            // 
            txtSearchProspect.Location = new Point(6, 72);
            txtSearchProspect.Name = "txtSearchProspect";
            txtSearchProspect.Size = new Size(205, 27);
            txtSearchProspect.TabIndex = 28;
            txtSearchProspect.Tag = "";
            txtSearchProspect.TextChanged += txtSearchProspect_TextChanged;
            txtSearchProspect.KeyDown += txtSearch_KeyDown;
            // 
            // btnTestDriveNewProspect
            // 
            btnTestDriveNewProspect.Location = new Point(255, 14);
            btnTestDriveNewProspect.Name = "btnTestDriveNewProspect";
            btnTestDriveNewProspect.Size = new Size(160, 34);
            btnTestDriveNewProspect.TabIndex = 27;
            btnTestDriveNewProspect.Text = "Niuwe prospect";
            btnTestDriveNewProspect.UseVisualStyleBackColor = true;
            btnTestDriveNewProspect.Click += btnTestDriveNewProspect_Click;
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
            // tpProspect
            // 
            tpProspect.Controls.Add(lstFilteredProspects);
            tpProspect.Controls.Add(dgvProspects);
            tpProspect.Controls.Add(btnNewProspect);
            tpProspect.Controls.Add(txtSearchProspects);
            tpProspect.Location = new Point(4, 29);
            tpProspect.Name = "tpProspect";
            tpProspect.Size = new Size(768, 430);
            tpProspect.TabIndex = 6;
            tpProspect.Text = "Prospects";
            tpProspect.UseVisualStyleBackColor = true;
            // 
            // lstFilteredProspects
            // 
            lstFilteredProspects.FormattingEnabled = true;
            lstFilteredProspects.Location = new Point(18, 40);
            lstFilteredProspects.Name = "lstFilteredProspects";
            lstFilteredProspects.Size = new Size(201, 104);
            lstFilteredProspects.TabIndex = 4;
            lstFilteredProspects.Visible = false;
            lstFilteredProspects.SelectedIndexChanged += lstFilteredProspects_SelectedIndexChanged;
            // 
            // btnNewProspect
            // 
            btnNewProspect.Location = new Point(588, 14);
            btnNewProspect.Name = "btnNewProspect";
            btnNewProspect.Size = new Size(157, 29);
            btnNewProspect.TabIndex = 2;
            btnNewProspect.Text = "Nieuwe prospect";
            btnNewProspect.UseVisualStyleBackColor = true;
            btnNewProspect.Click += btnNewProspect_Click;
            // 
            // txtSearchProspects
            // 
            txtSearchProspects.Location = new Point(18, 16);
            txtSearchProspects.Name = "txtSearchProspects";
            txtSearchProspects.PlaceholderText = "Zoek een prospect";
            txtSearchProspects.Size = new Size(201, 27);
            txtSearchProspects.TabIndex = 0;
            txtSearchProspects.Tag = "lstFilteredProspects";
            txtSearchProspects.TextChanged += txtSearchProspects_TextChanged;
            txtSearchProspects.KeyDown += txtSearch_KeyDown;
            // 
            // tpScheduled
            // 
            tpScheduled.Controls.Add(lstFilteredScheduled);
            tpScheduled.Controls.Add(txtSearchScheduled);
            tpScheduled.Controls.Add(dgvScheduled);
            tpScheduled.Location = new Point(4, 29);
            tpScheduled.Name = "tpScheduled";
            tpScheduled.Size = new Size(768, 430);
            tpScheduled.TabIndex = 2;
            tpScheduled.Text = "Gepland";
            tpScheduled.UseVisualStyleBackColor = true;
            // 
            // lstFilteredScheduled
            // 
            lstFilteredScheduled.FormattingEnabled = true;
            lstFilteredScheduled.Location = new Point(18, 39);
            lstFilteredScheduled.Name = "lstFilteredScheduled";
            lstFilteredScheduled.Size = new Size(201, 104);
            lstFilteredScheduled.TabIndex = 6;
            lstFilteredScheduled.Visible = false;
            // 
            // txtSearchScheduled
            // 
            txtSearchScheduled.Location = new Point(18, 15);
            txtSearchScheduled.Name = "txtSearchScheduled";
            txtSearchScheduled.PlaceholderText = "Zoek op prospect naam";
            txtSearchScheduled.Size = new Size(201, 27);
            txtSearchScheduled.TabIndex = 5;
            txtSearchScheduled.Tag = "lstFilteredProspects";
            // 
            // dgvScheduled
            // 
            dgvScheduled.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvScheduled.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvScheduled.Columns.AddRange(new DataGridViewColumn[] { colProspectName, colScheduledAt, colCarverModel, colStatus, colScheduledEdit });
            dgvScheduled.Location = new Point(18, 60);
            dgvScheduled.Name = "dgvScheduled";
            dgvScheduled.RowHeadersWidth = 51;
            dgvScheduled.Size = new Size(727, 358);
            dgvScheduled.TabIndex = 0;
            dgvScheduled.CellContentClick += dgvScheduled_CellContentClick;
            dgvScheduled.CellValueChanged += dgvScheduled_CellValueChanged;
            // 
            // colProspectName
            // 
            colProspectName.DataPropertyName = "ProspectName";
            colProspectName.HeaderText = "Naam";
            colProspectName.MinimumWidth = 6;
            colProspectName.Name = "colProspectName";
            // 
            // colScheduledAt
            // 
            colScheduledAt.DataPropertyName = "ScheduledAt";
            colScheduledAt.HeaderText = "Gepland op";
            colScheduledAt.MinimumWidth = 6;
            colScheduledAt.Name = "colScheduledAt";
            // 
            // colCarverModel
            // 
            colCarverModel.DataPropertyName = "CarverModel";
            colCarverModel.HeaderText = "Model";
            colCarverModel.MinimumWidth = 6;
            colCarverModel.Name = "colCarverModel";
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.Resizable = DataGridViewTriState.True;
            colStatus.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // colScheduledEdit
            // 
            colScheduledEdit.HeaderText = "";
            colScheduledEdit.MinimumWidth = 6;
            colScheduledEdit.Name = "colScheduledEdit";
            colScheduledEdit.Text = "Bijwerken";
            colScheduledEdit.UseColumnTextForButtonValue = true;
            // 
            // tpCompleted
            // 
            tpCompleted.Controls.Add(lstFilteredCompleted);
            tpCompleted.Controls.Add(txtSearchCompleted);
            tpCompleted.Controls.Add(dgvCompleted);
            tpCompleted.Location = new Point(4, 29);
            tpCompleted.Name = "tpCompleted";
            tpCompleted.Size = new Size(768, 430);
            tpCompleted.TabIndex = 3;
            tpCompleted.Text = "Uitgevoerd";
            tpCompleted.UseVisualStyleBackColor = true;
            // 
            // lstFilteredCompleted
            // 
            lstFilteredCompleted.FormattingEnabled = true;
            lstFilteredCompleted.Location = new Point(18, 40);
            lstFilteredCompleted.Name = "lstFilteredCompleted";
            lstFilteredCompleted.Size = new Size(201, 104);
            lstFilteredCompleted.TabIndex = 8;
            lstFilteredCompleted.Visible = false;
            // 
            // txtSearchCompleted
            // 
            txtSearchCompleted.Location = new Point(18, 16);
            txtSearchCompleted.Name = "txtSearchCompleted";
            txtSearchCompleted.PlaceholderText = "Zoek op prospect naam";
            txtSearchCompleted.Size = new Size(201, 27);
            txtSearchCompleted.TabIndex = 7;
            txtSearchCompleted.Tag = "lstFilteredProspects";
            // 
            // dgvCompleted
            // 
            dgvCompleted.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCompleted.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompleted.Columns.AddRange(new DataGridViewColumn[] { colCompletedProspectName, colModel, colDateTime, colCompletedStatus, colExperience });
            dgvCompleted.Location = new Point(18, 60);
            dgvCompleted.Name = "dgvCompleted";
            dgvCompleted.RowHeadersWidth = 51;
            dgvCompleted.Size = new Size(727, 358);
            dgvCompleted.TabIndex = 1;
            dgvCompleted.CellContentClick += dgvCompleted_CellContentClick;
            dgvCompleted.CellFormatting += dgvCompleted_CellFormatting;
            // 
            // tpStatistics
            // 
            tpStatistics.Location = new Point(4, 29);
            tpStatistics.Name = "tpStatistics";
            tpStatistics.Size = new Size(768, 430);
            tpStatistics.TabIndex = 4;
            tpStatistics.Text = "Statistieken";
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
            lblWelcome.Location = new Point(363, 18);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.RightToLeft = RightToLeft.No;
            lblWelcome.Size = new Size(317, 20);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welkom, Naam";
            lblWelcome.TextAlign = ContentAlignment.TopRight;
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
            // colCompletedProspectName
            // 
            colCompletedProspectName.DataPropertyName = "ProspectName";
            colCompletedProspectName.HeaderText = "Naam";
            colCompletedProspectName.MinimumWidth = 6;
            colCompletedProspectName.Name = "colCompletedProspectName";
            // 
            // colModel
            // 
            colModel.DataPropertyName = "CarverModel";
            colModel.HeaderText = "Model";
            colModel.MinimumWidth = 6;
            colModel.Name = "colModel";
            // 
            // colDateTime
            // 
            colDateTime.DataPropertyName = "ScheduledAt";
            colDateTime.HeaderText = "Datum";
            colDateTime.MinimumWidth = 6;
            colDateTime.Name = "colDateTime";
            // 
            // colCompletedStatus
            // 
            colCompletedStatus.DataPropertyName = "StatusDisplay";
            colCompletedStatus.HeaderText = "Status";
            colCompletedStatus.MinimumWidth = 6;
            colCompletedStatus.Name = "colCompletedStatus";
            // 
            // colExperience
            // 
            colExperience.HeaderText = "Ervaring";
            colExperience.MinimumWidth = 6;
            colExperience.Name = "colExperience";
            colExperience.Text = "";
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
            ((System.ComponentModel.ISupportInitialize)dgvProspects).EndInit();
            tabMain.ResumeLayout(false);
            tpNewTestDrive.ResumeLayout(false);
            grpTestDriveDetails.ResumeLayout(false);
            grpTestDriveDetails.PerformLayout();
            grpProspect.ResumeLayout(false);
            grpProspect.PerformLayout();
            tpProspect.ResumeLayout(false);
            tpProspect.PerformLayout();
            tpScheduled.ResumeLayout(false);
            tpScheduled.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvScheduled).EndInit();
            tpCompleted.ResumeLayout(false);
            tpCompleted.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompleted).EndInit();
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
        private GroupBox grpTestDriveDetails;
        private RichTextBox rtbInterestReason;
        private Label lblInterestReason;
        private ComboBox cmbInterestedModel;
        private Label lblInterestedModel;
        private Label lblDateTime;
        private DateTimePicker dtpTestDriveDateTime;
        private Label lblTestDriveDetail;
        private Label lblProspectInfo;
        private Button btnTestDriveNewProspect;
        private TabPage tpProspect;
        private Label lblSearchProspect;
        private ListBox lstProspects;
        private TextBox txtSearchProspect;
        private TextBox txtSearchProspects;
        private Button btnNewProspect;
        private DataGridView dgvProspects;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewButtonColumn colEdit;
        private DataGridViewButtonColumn colDelete;
        private ListBox lstFilteredProspects;
        private Label label1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private CheckBox chkHasDrivingLicense;
        private Label lblCity;
        private Label lblAddress;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblLastName;
        private Label lblFirstName;
        private CheckBox chkIsDisabledVehicle;
        private CheckBox chkHasScooterLicense;
        private DataGridView dgvScheduled;
        private DataGridView dgvCompleted;
        private ListBox lstFilteredScheduled;
        private TextBox txtSearchScheduled;
        private ListBox lstFilteredCompleted;
        private TextBox txtSearchCompleted;
        private DataGridViewTextBoxColumn colProspectName;
        private DataGridViewTextBoxColumn colScheduledAt;
        private DataGridViewTextBoxColumn colCarverModel;
        private DataGridViewComboBoxColumn colStatus;
        private DataGridViewButtonColumn colScheduledEdit;
        private DataGridViewTextBoxColumn colCompletedProspectName;
        private DataGridViewTextBoxColumn colModel;
        private DataGridViewTextBoxColumn colDateTime;
        private DataGridViewTextBoxColumn colCompletedStatus;
        private DataGridViewButtonColumn colExperience;
    }
}
