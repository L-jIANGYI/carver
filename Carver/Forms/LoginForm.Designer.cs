namespace Carver
{
    partial class LoginForm
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
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            lblEmail = new Label();
            lblPassword = new Label();
            label1 = new Label();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(300, 166);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(230, 27);
            txtEmail.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(300, 210);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(230, 27);
            txtPassword.TabIndex = 1;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(243, 169);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 20);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(187, 213);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(107, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Wachtwoord:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(208, 48);
            label1.Name = "label1";
            label1.Size = new Size(381, 55);
            label1.TabIndex = 4;
            label1.Text = "Inloggen Carver";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(300, 260);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(230, 46);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Inloggen";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label lblEmail;
        private Label lblPassword;
        private Label label1;
        private Button btnLogin;
    }
}