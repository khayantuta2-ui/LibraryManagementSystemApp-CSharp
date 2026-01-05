namespace LibraryManagementSystem
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.rbLibrarian = new System.Windows.Forms.RadioButton();
            this.rbMember = new System.Windows.Forms.RadioButton();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpUserType = new System.Windows.Forms.GroupBox();
            this.lblCredentials = new System.Windows.Forms.Label();
            this.grpUserType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(296, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(316, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Library Management System";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(237, 101);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(237, 159);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtUsername.Location = new System.Drawing.Point(329, 98);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(277, 20);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtPassword.Location = new System.Drawing.Point(329, 152);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(277, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // rbLibrarian
            // 
            this.rbLibrarian.AutoSize = true;
            this.rbLibrarian.Location = new System.Drawing.Point(6, 25);
            this.rbLibrarian.Name = "rbLibrarian";
            this.rbLibrarian.Size = new System.Drawing.Size(65, 17);
            this.rbLibrarian.TabIndex = 5;
            this.rbLibrarian.Text = "Librarian";
            this.rbLibrarian.UseVisualStyleBackColor = true;
            // 
            // rbMember
            // 
            this.rbMember.AutoSize = true;
            this.rbMember.Checked = true;
            this.rbMember.Location = new System.Drawing.Point(120, 25);
            this.rbMember.Name = "rbMember";
            this.rbMember.Size = new System.Drawing.Size(63, 17);
            this.rbMember.TabIndex = 6;
            this.rbMember.TabStop = true;
            this.rbMember.Text = "Member";
            this.rbMember.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LimeGreen;
            this.btnLogin.Location = new System.Drawing.Point(390, 255);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(129, 66);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(771, 336);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 49);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpUserType
            // 
            this.grpUserType.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpUserType.Controls.Add(this.rbLibrarian);
            this.grpUserType.Controls.Add(this.rbMember);
            this.grpUserType.Location = new System.Drawing.Point(355, 189);
            this.grpUserType.Name = "grpUserType";
            this.grpUserType.Size = new System.Drawing.Size(220, 60);
            this.grpUserType.TabIndex = 9;
            this.grpUserType.TabStop = false;
            this.grpUserType.Text = "User Type";
            // 
            // lblCredentials
            // 
            this.lblCredentials.AutoSize = true;
            this.lblCredentials.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredentials.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCredentials.Location = new System.Drawing.Point(307, 346);
            this.lblCredentials.Name = "lblCredentials";
            this.lblCredentials.Size = new System.Drawing.Size(299, 39);
            this.lblCredentials.TabIndex = 10;
            this.lblCredentials.Text = "Default Credentials:\r\nLibrarian - Username: Admin, Password: admin123\r\nMember - U" +
    "sername: Charlie Mayham, Password: Mayham123";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(930, 397);
            this.Controls.Add(this.lblCredentials);
            this.Controls.Add(this.grpUserType);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System - Login";
            this.grpUserType.ResumeLayout(false);
            this.grpUserType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.RadioButton rbLibrarian;
        private System.Windows.Forms.RadioButton rbMember;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpUserType;
        private System.Windows.Forms.Label lblCredentials;
    }
}