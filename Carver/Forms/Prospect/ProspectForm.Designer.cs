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
            chkDisabledVehicle = new CheckBox();
            txtLastName = new TextBox();
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
            btnSubmit = new Button();
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
            lblDrivingLicense.Location = new Point(12, 249);
            lblDrivingLicense.Name = "lblDrivingLicense";
            lblDrivingLicense.Size = new Size(203, 27);
            lblDrivingLicense.TabIndex = 41;
            lblDrivingLicense.Text = "Rijbewijs en overig";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(14, 206);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(236, 27);
            txtAddress.TabIndex = 4;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(14, 79);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(204, 27);
            txtFirstName.TabIndex = 0;
            // 
            // chkDisabledVehicle
            // 
            chkDisabledVehicle.AutoSize = true;
            chkDisabledVehicle.Location = new Point(13, 339);
            chkDisabledVehicle.Name = "chkDisabledVehicle";
            chkDisabledVehicle.Size = new Size(158, 24);
            chkDisabledVehicle.TabIndex = 8;
            chkDisabledVehicle.Text = "Invalidenvoertuig";
            chkDisabledVehicle.UseVisualStyleBackColor = true;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(241, 79);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(148, 27);
            txtLastName.TabIndex = 1;
            // 
            // chkScooterLicense
            // 
            chkScooterLicense.AutoSize = true;
            chkScooterLicense.Location = new Point(13, 309);
            chkScooterLicense.Name = "chkScooterLicense";
            chkScooterLicense.Size = new Size(189, 24);
            chkScooterLicense.TabIndex = 7;
            chkScooterLicense.Text = "Scooterrijbewijs (AM)";
            chkScooterLicense.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(14, 141);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(241, 27);
            txtEmail.TabIndex = 2;
            // 
            // chkDrivingLicense
            // 
            chkDrivingLicense.AutoSize = true;
            chkDrivingLicense.Location = new Point(13, 279);
            chkDrivingLicense.Name = "chkDrivingLicense";
            chkDrivingLicense.Size = new Size(133, 24);
            chkDrivingLicense.TabIndex = 6;
            chkDrivingLicense.Text = "Rijbewijs A / B";
            chkDrivingLicense.UseVisualStyleBackColor = true;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(287, 142);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(148, 27);
            txtPhone.TabIndex = 3;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(287, 206);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(155, 27);
            txtCity.TabIndex = 5;
            // 
            // lblFirstname
            // 
            lblFirstname.AutoSize = true;
            lblFirstname.Location = new Point(14, 56);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(84, 20);
            lblFirstname.TabIndex = 32;
            lblFirstname.Text = "Voornaam";
            // 
            // lblProspectEmail
            // 
            lblProspectEmail.AutoSize = true;
            lblProspectEmail.Location = new Point(14, 118);
            lblProspectEmail.Name = "lblProspectEmail";
            lblProspectEmail.Size = new Size(47, 20);
            lblProspectEmail.TabIndex = 33;
            lblProspectEmail.Text = "Email";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(287, 118);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(135, 20);
            lblPhone.TabIndex = 34;
            lblPhone.Text = "Telefoonnummer";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(14, 183);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(52, 20);
            lblAddress.TabIndex = 35;
            lblAddress.Text = "Adres";
            // 
            // lblLastname
            // 
            lblLastname.AutoSize = true;
            lblLastname.Location = new Point(241, 56);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(97, 20);
            lblLastname.TabIndex = 36;
            lblLastname.Text = "Achternaam";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(287, 183);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(42, 20);
            lblCity.TabIndex = 37;
            lblCity.Text = "Stad";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(164, 388);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(113, 37);
            btnSubmit.TabIndex = 9;
            btnSubmit.Text = "Aanmaken";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // ProspectForm
            // 
            AcceptButton = btnSubmit;
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 450);
            Controls.Add(btnSubmit);
            Controls.Add(lblProspect);
            Controls.Add(lblDrivingLicense);
            Controls.Add(txtAddress);
            Controls.Add(txtFirstName);
            Controls.Add(chkDisabledVehicle);
            Controls.Add(txtLastName);
            Controls.Add(chkScooterLicense);
            Controls.Add(txtEmail);
            Controls.Add(chkDrivingLicense);
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
        protected CheckBox chkDisabledVehicle;
        protected TextBox txtLastName;
        protected CheckBox chkScooterLicense;
        protected TextBox txtEmail;
        protected CheckBox chkDrivingLicense;
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
    }
}