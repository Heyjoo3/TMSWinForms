namespace TMSWinForms.View
{
    partial class LoginGUI
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
            this.header = new System.Windows.Forms.Panel();
            this.footer = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.emailLoginInput = new System.Windows.Forms.Label();
            this.passwordLoginInput = new System.Windows.Forms.Label();
            this.switchToRegister = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.header.BackColor = System.Drawing.Color.SlateBlue;
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(984, 88);
            this.header.TabIndex = 1;
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(0, 589);
            this.footer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(984, 72);
            this.footer.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(300, 202);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(349, 26);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(300, 275);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(349, 26);
            this.textBox2.TabIndex = 4;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(385, 333);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(188, 61);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // emailLoginInput
            // 
            this.emailLoginInput.AutoSize = true;
            this.emailLoginInput.Location = new System.Drawing.Point(300, 181);
            this.emailLoginInput.Name = "emailLoginInput";
            this.emailLoginInput.Size = new System.Drawing.Size(48, 20);
            this.emailLoginInput.TabIndex = 6;
            this.emailLoginInput.Text = "Email";
            // 
            // passwordLoginInput
            // 
            this.passwordLoginInput.AutoSize = true;
            this.passwordLoginInput.Location = new System.Drawing.Point(300, 254);
            this.passwordLoginInput.Name = "passwordLoginInput";
            this.passwordLoginInput.Size = new System.Drawing.Size(78, 20);
            this.passwordLoginInput.TabIndex = 7;
            this.passwordLoginInput.Text = "Password";
            // 
            // switchToRegister
            // 
            this.switchToRegister.AutoSize = true;
            this.switchToRegister.Location = new System.Drawing.Point(371, 440);
            this.switchToRegister.Name = "switchToRegister";
            this.switchToRegister.Size = new System.Drawing.Size(211, 20);
            this.switchToRegister.TabIndex = 18;
            this.switchToRegister.TabStop = true;
            this.switchToRegister.Text = "Not registerd yet? Click here!";
            this.switchToRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.switchToLogin_LinkClicked);
            // 
            // LoginGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.switchToRegister);
            this.Controls.Add(this.passwordLoginInput);
            this.Controls.Add(this.emailLoginInput);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.header);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginGUI";
            this.Text = "LoginGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel footer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label emailLoginInput;
        private System.Windows.Forms.Label passwordLoginInput;
        private System.Windows.Forms.LinkLabel switchToRegister;
    }
}