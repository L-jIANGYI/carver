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
            btnSearchProspect = new Button();
            lblSearchProspect = new Label();
            lstProspects = new ListBox();
            txtSearchProspect = new TextBox();
            btnTestDriveNewProspect = new Button();
            lblProspectInfo = new Label();
            tpProspect = new TabPage();
            lstFilteredProspects = new ListBox();
            btnNewProspect = new Button();
            txtSearchProspects = new TextBox();
            tpScheduled = new TabPage();
            tpCompleted = new TabPage();
            tpStatistics = new TabPage();
            tpEmployeeManagement = new TabPage();
            lblWelcome = new Label();
            lblTitle = new Label();
            btnLogOut = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProspects).BeginInit();
            tabMain.SuspendLayout();
            tpNewTestDrive.SuspendLayout();
            grpTestDriveDetails.SuspendLayout();
            grpProspect.SuspendLayout();
            tpProspect.SuspendLayout();
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
            grpProspect.Controls.Add(btnSearchProspect);
            grpProspect.Controls.Add(lblSearchProspect);
            grpProspect.Controls.Add(lstProspects);
            grpProspect.Controls.Add(txtSearchProspect);
            grpProspect.Controls.Add(btnTestDriveNewProspect);
            grpProspect.Controls.Add(lblProspectInfo);
            grpProspect.Location = new Point(347, 3);
            grpProspect.Name = "grpProspect";
            grpProspect.Size = new Size(418, 421);
            grpProspect.TabIndex = 25;
            grpProspect.TabStop = false;
            // 
            // btnSearchProspect
            // 
            btnSearchProspect.Location = new Point(219, 72);
            btnSearchProspect.Name = "btnSearchProspect";
            btnSearchProspect.Size = new Size(98, 27);
            btnSearchProspect.TabIndex = 31;
            btnSearchProspect.Text = "Zoeken";
            btnSearchProspect.UseVisualStyleBackColor = true;
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
            // lstProspects
            // 
            lstProspects.FormattingEnabled = true;
            lstProspects.Location = new Point(6, 99);
            lstProspects.Name = "lstProspects";
            lstProspects.Size = new Size(205, 124);
            lstProspects.TabIndex = 29;
            lstProspects.Visible = false;
            // 
            // txtSearchProspect
            // 
            txtSearchProspect.Location = new Point(6, 72);
            txtSearchProspect.Name = "txtSearchProspect";
            txtSearchProspect.Size = new Size(205, 27);
            txtSearchProspect.TabIndex = 28;
            // 
            // btnTestDriveNewProspect
            // 
            btnTestDriveNewProspect.Location = new Point(255, 14);
            btnTestDriveNewProspect.Name = "btnTestDriveNewProspect";
            btnTestDriveNewProspect.Size = new Size(160, 34);
            btnTestDriveNewProspect.TabIndex = 27;
            btnTestDriveNewProspect.Text = "Niuwe prospect";
            btnTestDriveNewProspect.UseVisualStyleBackColor = true;
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
            txtSearchProspects.Size = new Size(201, 27);
            txtSearchProspects.TabIndex = 0;
            txtSearchProspects.TextChanged += txtSearchProspects_TextChanged;
            txtSearchProspects.KeyDown += txtSearchProspects_KeyDown;
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
        private Button btnSearchProspect;
        private TextBox txtSearchProspects;
        private Button btnNewProspect;
        private DataGridView dgvProspects;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewButtonColumn colEdit;
        private DataGridViewButtonColumn colDelete;
        private ListBox lstFilteredProspects;
    }
}
