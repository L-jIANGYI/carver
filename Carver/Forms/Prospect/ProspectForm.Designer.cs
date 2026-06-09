namespace Carver.Forms
{
    partial class ProspectForm
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
            lblProspect = new Label();
            lblDrivingLicense = new Label();
            txtAddress = new TextBox();
            txtFirstName = new TextBox();
            chkIsDisabledVehicle = new CheckBox();
            txtLastName = new TextBox();
            chkHasScooterLicense = new CheckBox();
            txtEmail = new TextBox();
            chkHasDrivingLicense = new CheckBox();
            txtPhone = new TextBox();
            txtCity = new TextBox();
            lblFirstname = new Label();
            lblProspectEmail = new Label();
            lblPhone = new Label();
            lblAddress = new Label();
            lblLastname = new Label();
            lblCity = new Label();
            btnSubmit = new Button();
            btnExportProspectCard = new Button();
            SuspendLayout();
            // 
            // lblProspect
            // 
            lblProspect.AutoSize = true;
            lblProspect.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblProspect.Location = new Point(12, 19);
            lblProspect.Name = "lblProspect";
            lblProspect.Size = new Size(210, 31);
            lblProspect.TabIndex = 42;
            lblProspect.Text = "Nieuwe prospect";
            // 
            // lblDrivingLicense
            // 
            lblDrivingLicense.AutoSize = true;
            lblDrivingLicense.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblDrivingLicense.Location = new Point(12, 258);
            lblDrivingLicense.Name = "lblDrivingLicense";
            lblDrivingLicense.Size = new Size(203, 27);
            lblDrivingLicense.TabIndex = 41;
            lblDrivingLicense.Text = "Rijbewijs en overig";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(14, 215);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(236, 27);
            txtAddress.TabIndex = 4;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(14, 88);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(204, 27);
            txtFirstName.TabIndex = 0;
            // 
            // chkIsDisabledVehicle
            // 
            chkIsDisabledVehicle.AutoSize = true;
            chkIsDisabledVehicle.Location = new Point(13, 348);
            chkIsDisabledVehicle.Name = "chkIsDisabledVehicle";
            chkIsDisabledVehicle.Size = new Size(158, 24);
            chkIsDisabledVehicle.TabIndex = 8;
            chkIsDisabledVehicle.Text = "Invalidenvoertuig";
            chkIsDisabledVehicle.UseVisualStyleBackColor = true;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(241, 88);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(148, 27);
            txtLastName.TabIndex = 1;
            // 
            // chkHasScooterLicense
            // 
            chkHasScooterLicense.AutoSize = true;
            chkHasScooterLicense.Location = new Point(13, 318);
            chkHasScooterLicense.Name = "chkHasScooterLicense";
            chkHasScooterLicense.Size = new Size(189, 24);
            chkHasScooterLicense.TabIndex = 7;
            chkHasScooterLicense.Text = "Scooterrijbewijs (AM)";
            chkHasScooterLicense.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(14, 150);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(241, 27);
            txtEmail.TabIndex = 2;
            // 
            // chkHasDrivingLicense
            // 
            chkHasDrivingLicense.AutoSize = true;
            chkHasDrivingLicense.Location = new Point(13, 288);
            chkHasDrivingLicense.Name = "chkHasDrivingLicense";
            chkHasDrivingLicense.Size = new Size(133, 24);
            chkHasDrivingLicense.TabIndex = 6;
            chkHasDrivingLicense.Text = "Rijbewijs A / B";
            chkHasDrivingLicense.UseVisualStyleBackColor = true;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(287, 151);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(156, 27);
            txtPhone.TabIndex = 3;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(287, 215);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(155, 27);
            txtCity.TabIndex = 5;
            // 
            // lblFirstname
            // 
            lblFirstname.AutoSize = true;
            lblFirstname.Location = new Point(14, 65);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(84, 20);
            lblFirstname.TabIndex = 32;
            lblFirstname.Text = "Voornaam";
            // 
            // lblProspectEmail
            // 
            lblProspectEmail.AutoSize = true;
            lblProspectEmail.Location = new Point(14, 127);
            lblProspectEmail.Name = "lblProspectEmail";
            lblProspectEmail.Size = new Size(47, 20);
            lblProspectEmail.TabIndex = 33;
            lblProspectEmail.Text = "Email";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(287, 127);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(135, 20);
            lblPhone.TabIndex = 34;
            lblPhone.Text = "Telefoonnummer";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(14, 192);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(52, 20);
            lblAddress.TabIndex = 35;
            lblAddress.Text = "Adres";
            // 
            // lblLastname
            // 
            lblLastname.AutoSize = true;
            lblLastname.Location = new Point(241, 65);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(97, 20);
            lblLastname.TabIndex = 36;
            lblLastname.Text = "Achternaam";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(287, 192);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(42, 20);
            lblCity.TabIndex = 37;
            lblCity.Text = "Stad";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(168, 394);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(113, 37);
            btnSubmit.TabIndex = 9;
            btnSubmit.Text = "Aanmaken";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnExportProspectCard
            // 
            btnExportProspectCard.Location = new Point(319, 24);
            btnExportProspectCard.Name = "btnExportProspectCard";
            btnExportProspectCard.Size = new Size(123, 29);
            btnExportProspectCard.TabIndex = 43;
            btnExportProspectCard.Text = "Export in PDF";
            btnExportProspectCard.UseVisualStyleBackColor = true;
            // 
            // ProspectForm
            // 
            AcceptButton = btnSubmit;
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 450);
            Controls.Add(btnExportProspectCard);
            Controls.Add(btnSubmit);
            Controls.Add(lblProspect);
            Controls.Add(lblDrivingLicense);
            Controls.Add(txtAddress);
            Controls.Add(txtFirstName);
            Controls.Add(chkIsDisabledVehicle);
            Controls.Add(txtLastName);
            Controls.Add(chkHasScooterLicense);
            Controls.Add(txtEmail);
            Controls.Add(chkHasDrivingLicense);
            Controls.Add(txtPhone);
            Controls.Add(txtCity);
            Controls.Add(lblFirstname);
            Controls.Add(lblProspectEmail);
            Controls.Add(lblPhone);
            Controls.Add(lblAddress);
            Controls.Add(lblLastname);
            Controls.Add(lblCity);
            Name = "ProspectForm";
            Text = "1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblDrivingLicense;
        protected TextBox txtAddress;
        protected TextBox txtFirstName;
        protected CheckBox chkIsDisabledVehicle;
        protected TextBox txtLastName;
        protected CheckBox chkHasScooterLicense;
        protected TextBox txtEmail;
        protected CheckBox chkHasDrivingLicense;
        protected TextBox txtPhone;
        protected TextBox txtCity;
        private Label lblFirstname;
        private Label lblProspectEmail;
        private Label lblPhone;
        private Label lblAddress;
        private Label lblLastname;
        private Label lblCity;
        protected Button btnSubmit;
        protected Label lblProspect;
        private Button btnExportProspectCard;
    }
}