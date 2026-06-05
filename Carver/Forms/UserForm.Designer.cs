namespace Carver.Forms
{
    partial class UserForm
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
            lblRegisterUser = new Label();
            txtName = new TextBox();
            lblName = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnCreateNewUser = new Button();
            lblEmail = new Label();
            lblPassword = new Label();
            lblRole = new Label();
            rbEmployee = new RadioButton();
            rbAdministrator = new RadioButton();
            SuspendLayout();
            // 
            // lblRegisterUser
            // 
            lblRegisterUser.AutoSize = true;
            lblRegisterUser.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblRegisterUser.Location = new Point(154, 56);
            lblRegisterUser.Name = "lblRegisterUser";
            lblRegisterUser.Size = new Size(339, 40);
            lblRegisterUser.TabIndex = 6;
            lblRegisterUser.Text = "Gebruiker aanmelden";
            // 
            // txtName
            // 
            txtName.Location = new Point(220, 141);
            txtName.Name = "txtName";
            txtName.Size = new Size(267, 27);
            txtName.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(150, 144);
            lblName.Name = "lblName";
            lblName.Size = new Size(55, 20);
            lblName.TabIndex = 7;
            lblName.Text = "Naam:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(220, 182);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(267, 27);
            txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(220, 220);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(267, 27);
            txtPassword.TabIndex = 2;
            // 
            // btnCreateNewUser
            // 
            btnCreateNewUser.Location = new Point(249, 329);
            btnCreateNewUser.Name = "btnCreateNewUser";
            btnCreateNewUser.Size = new Size(182, 40);
            btnCreateNewUser.TabIndex = 5;
            btnCreateNewUser.Text = "Aanmaken";
            btnCreateNewUser.UseVisualStyleBackColor = true;
            btnCreateNewUser.Click += btnCreateNewUser_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(154, 185);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 20);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(98, 223);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(107, 20);
            lblPassword.TabIndex = 9;
            lblPassword.Text = "Wachtwoord:";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(168, 272);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(37, 20);
            lblRole.TabIndex = 10;
            lblRole.Text = "Rol:";
            // 
            // rbEmployee
            // 
            rbEmployee.AutoSize = true;
            rbEmployee.Location = new Point(220, 272);
            rbEmployee.Name = "rbEmployee";
            rbEmployee.Size = new Size(123, 24);
            rbEmployee.TabIndex = 3;
            rbEmployee.TabStop = true;
            rbEmployee.Text = "Medewerker";
            rbEmployee.UseVisualStyleBackColor = true;
            // 
            // rbAdministrator
            // 
            rbAdministrator.AutoSize = true;
            rbAdministrator.Location = new Point(356, 272);
            rbAdministrator.Name = "rbAdministrator";
            rbAdministrator.Size = new Size(131, 24);
            rbAdministrator.TabIndex = 4;
            rbAdministrator.TabStop = true;
            rbAdministrator.Text = "Administrator";
            rbAdministrator.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 450);
            Controls.Add(rbAdministrator);
            Controls.Add(rbEmployee);
            Controls.Add(lblRole);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(btnCreateNewUser);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblRegisterUser);
            Name = "UserForm";
            Text = "UserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegisterUser;
        private TextBox txtName;
        private Label lblName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnCreateNewUser;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblRole;
        private RadioButton rbEmployee;
        private RadioButton rbAdministrator;
    }
}