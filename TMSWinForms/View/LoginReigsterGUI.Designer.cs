namespace TMSWinForms.View
{
    partial class LoginReigsterGUI
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
            this.switchToRegister = new System.Windows.Forms.LinkLabel();
            this.passwordLoginInput = new System.Windows.Forms.Label();
            this.emailLoginInput = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.loginPasswordTextBox = new System.Windows.Forms.TextBox();
            this.loginEmailTextBox = new System.Windows.Forms.TextBox();
            this.passwordRepeatRegisterInput = new System.Windows.Forms.Label();
            this.repeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.passwordRegisterInput = new System.Windows.Forms.Label();
            this.registerPasswordTextBox = new System.Windows.Forms.TextBox();
            this.emailRegisterInput = new System.Windows.Forms.Label();
            this.nameRegisterInput = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.registerEmailTextBox = new System.Windows.Forms.TextBox();
            this.registerNameTextBox = new System.Windows.Forms.TextBox();
            this.registerTitle = new System.Windows.Forms.Label();
            this.loginTitle = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.pageTitle = new System.Windows.Forms.Label();
            this.footer = new System.Windows.Forms.Panel();
            this.registerPanel = new System.Windows.Forms.Panel();
            this.showPasswordRepeatButton = new System.Windows.Forms.Button();
            this.showPasswordButton = new System.Windows.Forms.Button();
            this.adminRollCheckBox = new System.Windows.Forms.CheckBox();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.showLoginPasswordButton1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.header.SuspendLayout();
            this.registerPanel.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // switchToRegister
            // 
            this.switchToRegister.AutoSize = true;
            this.switchToRegister.Location = new System.Drawing.Point(228, 662);
            this.switchToRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.switchToRegister.Name = "switchToRegister";
            this.switchToRegister.Size = new System.Drawing.Size(0, 20);
            this.switchToRegister.TabIndex = 24;
            // 
            // passwordLoginInput
            // 
            this.passwordLoginInput.AutoSize = true;
            this.passwordLoginInput.Location = new System.Drawing.Point(7, 131);
            this.passwordLoginInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLoginInput.Name = "passwordLoginInput";
            this.passwordLoginInput.Size = new System.Drawing.Size(78, 20);
            this.passwordLoginInput.TabIndex = 23;
            this.passwordLoginInput.Text = "Password";
            // 
            // emailLoginInput
            // 
            this.emailLoginInput.AutoSize = true;
            this.emailLoginInput.Location = new System.Drawing.Point(7, 71);
            this.emailLoginInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLoginInput.Name = "emailLoginInput";
            this.emailLoginInput.Size = new System.Drawing.Size(48, 20);
            this.emailLoginInput.TabIndex = 22;
            this.emailLoginInput.Text = "Email";
            // 
            // loginButton
            // 
            this.loginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(72)))), ((int)(((byte)(98)))));
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Location = new System.Drawing.Point(11, 201);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(313, 64);
            this.loginButton.TabIndex = 21;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginPasswordTextBox
            // 
            this.loginPasswordTextBox.Location = new System.Drawing.Point(11, 159);
            this.loginPasswordTextBox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.loginPasswordTextBox.Name = "loginPasswordTextBox";
            this.loginPasswordTextBox.PasswordChar = '*';
            this.loginPasswordTextBox.Size = new System.Drawing.Size(313, 26);
            this.loginPasswordTextBox.TabIndex = 20;
            // 
            // loginEmailTextBox
            // 
            this.loginEmailTextBox.Location = new System.Drawing.Point(11, 99);
            this.loginEmailTextBox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.loginEmailTextBox.Name = "loginEmailTextBox";
            this.loginEmailTextBox.Size = new System.Drawing.Size(313, 26);
            this.loginEmailTextBox.TabIndex = 19;
            // 
            // passwordRepeatRegisterInput
            // 
            this.passwordRepeatRegisterInput.AutoSize = true;
            this.passwordRepeatRegisterInput.Location = new System.Drawing.Point(4, 254);
            this.passwordRepeatRegisterInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordRepeatRegisterInput.Name = "passwordRepeatRegisterInput";
            this.passwordRepeatRegisterInput.Size = new System.Drawing.Size(135, 20);
            this.passwordRepeatRegisterInput.TabIndex = 33;
            this.passwordRepeatRegisterInput.Text = "Repeat Password";
            // 
            // repeatPasswordTextBox
            // 
            this.repeatPasswordTextBox.Location = new System.Drawing.Point(8, 282);
            this.repeatPasswordTextBox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.repeatPasswordTextBox.MaxLength = 20;
            this.repeatPasswordTextBox.Name = "repeatPasswordTextBox";
            this.repeatPasswordTextBox.PasswordChar = '*';
            this.repeatPasswordTextBox.Size = new System.Drawing.Size(309, 26);
            this.repeatPasswordTextBox.TabIndex = 32;
            // 
            // passwordRegisterInput
            // 
            this.passwordRegisterInput.AutoSize = true;
            this.passwordRegisterInput.Location = new System.Drawing.Point(4, 192);
            this.passwordRegisterInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordRegisterInput.Name = "passwordRegisterInput";
            this.passwordRegisterInput.Size = new System.Drawing.Size(78, 20);
            this.passwordRegisterInput.TabIndex = 31;
            this.passwordRegisterInput.Text = "Password";
            // 
            // registerPasswordTextBox
            // 
            this.registerPasswordTextBox.Location = new System.Drawing.Point(8, 220);
            this.registerPasswordTextBox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.registerPasswordTextBox.MaxLength = 20;
            this.registerPasswordTextBox.Name = "registerPasswordTextBox";
            this.registerPasswordTextBox.PasswordChar = '*';
            this.registerPasswordTextBox.Size = new System.Drawing.Size(309, 26);
            this.registerPasswordTextBox.TabIndex = 30;
            // 
            // emailRegisterInput
            // 
            this.emailRegisterInput.AutoSize = true;
            this.emailRegisterInput.Location = new System.Drawing.Point(4, 131);
            this.emailRegisterInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailRegisterInput.Name = "emailRegisterInput";
            this.emailRegisterInput.Size = new System.Drawing.Size(48, 20);
            this.emailRegisterInput.TabIndex = 29;
            this.emailRegisterInput.Text = "Email";
            // 
            // nameRegisterInput
            // 
            this.nameRegisterInput.AutoSize = true;
            this.nameRegisterInput.Location = new System.Drawing.Point(4, 71);
            this.nameRegisterInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameRegisterInput.Name = "nameRegisterInput";
            this.nameRegisterInput.Size = new System.Drawing.Size(152, 20);
            this.nameRegisterInput.TabIndex = 28;
            this.nameRegisterInput.Text = "First and Last Name";
            // 
            // registerButton
            // 
            this.registerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(72)))), ((int)(((byte)(98)))));
            this.registerButton.FlatAppearance.BorderSize = 0;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Location = new System.Drawing.Point(8, 326);
            this.registerButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(309, 64);
            this.registerButton.TabIndex = 27;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // registerEmailTextBox
            // 
            this.registerEmailTextBox.Location = new System.Drawing.Point(8, 159);
            this.registerEmailTextBox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.registerEmailTextBox.Name = "registerEmailTextBox";
            this.registerEmailTextBox.Size = new System.Drawing.Size(309, 26);
            this.registerEmailTextBox.TabIndex = 26;
            // 
            // registerNameTextBox
            // 
            this.registerNameTextBox.Location = new System.Drawing.Point(8, 99);
            this.registerNameTextBox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.registerNameTextBox.MaxLength = 25;
            this.registerNameTextBox.Name = "registerNameTextBox";
            this.registerNameTextBox.Size = new System.Drawing.Size(309, 26);
            this.registerNameTextBox.TabIndex = 25;
            this.registerNameTextBox.TextChanged += new System.EventHandler(this.registerNameTextBox_TextChanged);
            // 
            // registerTitle
            // 
            this.registerTitle.AutoSize = true;
            this.registerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.registerTitle.Location = new System.Drawing.Point(4, 17);
            this.registerTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registerTitle.Name = "registerTitle";
            this.registerTitle.Size = new System.Drawing.Size(154, 26);
            this.registerTitle.TabIndex = 34;
            this.registerTitle.Text = "Register here: ";
            // 
            // loginTitle
            // 
            this.loginTitle.AutoSize = true;
            this.loginTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.loginTitle.Location = new System.Drawing.Point(6, 17);
            this.loginTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginTitle.Name = "loginTitle";
            this.loginTitle.Size = new System.Drawing.Size(126, 26);
            this.loginTitle.TabIndex = 35;
            this.loginTitle.Text = "Login here: ";
            // 
            // header
            // 
            this.header.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.header.Controls.Add(this.pageTitle);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(984, 88);
            this.header.TabIndex = 36;
            this.header.Tag = "";
            // 
            // pageTitle
            // 
            this.pageTitle.AutoSize = true;
            this.pageTitle.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.pageTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pageTitle.Location = new System.Drawing.Point(266, 23);
            this.pageTitle.Name = "pageTitle";
            this.pageTitle.Size = new System.Drawing.Size(459, 39);
            this.pageTitle.TabIndex = 1;
            this.pageTitle.Text = "Ticket Management System";
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(0, 589);
            this.footer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(984, 72);
            this.footer.TabIndex = 37;
            // 
            // registerPanel
            // 
            this.registerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.registerPanel.Controls.Add(this.showPasswordRepeatButton);
            this.registerPanel.Controls.Add(this.showPasswordButton);
            this.registerPanel.Controls.Add(this.adminRollCheckBox);
            this.registerPanel.Controls.Add(this.registerTitle);
            this.registerPanel.Controls.Add(this.passwordRepeatRegisterInput);
            this.registerPanel.Controls.Add(this.repeatPasswordTextBox);
            this.registerPanel.Controls.Add(this.passwordRegisterInput);
            this.registerPanel.Controls.Add(this.registerPasswordTextBox);
            this.registerPanel.Controls.Add(this.emailRegisterInput);
            this.registerPanel.Controls.Add(this.nameRegisterInput);
            this.registerPanel.Controls.Add(this.registerButton);
            this.registerPanel.Controls.Add(this.registerEmailTextBox);
            this.registerPanel.Controls.Add(this.registerNameTextBox);
            this.registerPanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.registerPanel.Location = new System.Drawing.Point(533, 116);
            this.registerPanel.Name = "registerPanel";
            this.registerPanel.Size = new System.Drawing.Size(325, 416);
            this.registerPanel.TabIndex = 38;
            // 
            // showPasswordRepeatButton
            // 
            this.showPasswordRepeatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPasswordRepeatButton.Location = new System.Drawing.Point(259, 251);
            this.showPasswordRepeatButton.Name = "showPasswordRepeatButton";
            this.showPasswordRepeatButton.Size = new System.Drawing.Size(58, 27);
            this.showPasswordRepeatButton.TabIndex = 43;
            this.showPasswordRepeatButton.Text = "show";
            this.showPasswordRepeatButton.UseVisualStyleBackColor = true;
            this.showPasswordRepeatButton.Click += new System.EventHandler(this.showPasswordRepeatButton_Click);
            // 
            // showPasswordButton
            // 
            this.showPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPasswordButton.Location = new System.Drawing.Point(259, 192);
            this.showPasswordButton.Name = "showPasswordButton";
            this.showPasswordButton.Size = new System.Drawing.Size(58, 27);
            this.showPasswordButton.TabIndex = 42;
            this.showPasswordButton.Text = "show";
            this.showPasswordButton.UseVisualStyleBackColor = true;
            this.showPasswordButton.Click += new System.EventHandler(this.showPasswordButton_Click);
            // 
            // adminRollCheckBox
            // 
            this.adminRollCheckBox.AutoSize = true;
            this.adminRollCheckBox.Location = new System.Drawing.Point(244, 17);
            this.adminRollCheckBox.Name = "adminRollCheckBox";
            this.adminRollCheckBox.Size = new System.Drawing.Size(73, 24);
            this.adminRollCheckBox.TabIndex = 41;
            this.adminRollCheckBox.Text = "Admin";
            this.adminRollCheckBox.UseVisualStyleBackColor = true;
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.loginPanel.Controls.Add(this.showLoginPasswordButton1);
            this.loginPanel.Controls.Add(this.loginTitle);
            this.loginPanel.Controls.Add(this.passwordLoginInput);
            this.loginPanel.Controls.Add(this.emailLoginInput);
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Controls.Add(this.loginPasswordTextBox);
            this.loginPanel.Controls.Add(this.loginEmailTextBox);
            this.loginPanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loginPanel.Location = new System.Drawing.Point(119, 116);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(334, 414);
            this.loginPanel.TabIndex = 39;
            // 
            // showLoginPasswordButton1
            // 
            this.showLoginPasswordButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showLoginPasswordButton1.Location = new System.Drawing.Point(266, 128);
            this.showLoginPasswordButton1.Name = "showLoginPasswordButton1";
            this.showLoginPasswordButton1.Size = new System.Drawing.Size(58, 27);
            this.showLoginPasswordButton1.TabIndex = 44;
            this.showLoginPasswordButton1.Text = "show";
            this.showLoginPasswordButton1.UseVisualStyleBackColor = true;
            this.showLoginPasswordButton1.Click += new System.EventHandler(this.showLoginPasswordButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(72)))), ((int)(((byte)(98)))));
            this.panel1.Location = new System.Drawing.Point(-1, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 10);
            this.panel1.TabIndex = 40;
            // 
            // LoginReigsterGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.registerPanel);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.header);
            this.Controls.Add(this.switchToRegister);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginReigsterGUI";
            this.Text = "LoginReigsterGUI";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.registerPanel.ResumeLayout(false);
            this.registerPanel.PerformLayout();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel switchToRegister;
        private System.Windows.Forms.Label passwordLoginInput;
        private System.Windows.Forms.Label emailLoginInput;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox loginPasswordTextBox;
        private System.Windows.Forms.TextBox loginEmailTextBox;
        private System.Windows.Forms.Label passwordRepeatRegisterInput;
        private System.Windows.Forms.TextBox repeatPasswordTextBox;
        private System.Windows.Forms.Label passwordRegisterInput;
        private System.Windows.Forms.TextBox registerPasswordTextBox;
        private System.Windows.Forms.Label emailRegisterInput;
        private System.Windows.Forms.Label nameRegisterInput;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox registerEmailTextBox;
        private System.Windows.Forms.TextBox registerNameTextBox;
        private System.Windows.Forms.Label registerTitle;
        private System.Windows.Forms.Label loginTitle;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel footer;
        private System.Windows.Forms.Panel registerPanel;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label pageTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox adminRollCheckBox;
        private System.Windows.Forms.Button showPasswordButton;
        private System.Windows.Forms.Button showPasswordRepeatButton;
        private System.Windows.Forms.Button showLoginPasswordButton1;
    }
}