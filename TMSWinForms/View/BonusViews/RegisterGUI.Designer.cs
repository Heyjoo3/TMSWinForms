namespace TMSWinForms.View
{
    partial class RegisterGUI
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
            this.emailRegisterInput = new System.Windows.Forms.Label();
            this.nameRegisterInput = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.passwordRegisterInput = new System.Windows.Forms.Label();
            this.passwordRepeatRegisterInput = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.switchToLogin = new System.Windows.Forms.LinkLabel();
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
            this.header.TabIndex = 2;
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(0, 589);
            this.footer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(984, 72);
            this.footer.TabIndex = 3;
            // 
            // emailRegisterInput
            // 
            this.emailRegisterInput.AutoSize = true;
            this.emailRegisterInput.Location = new System.Drawing.Point(318, 221);
            this.emailRegisterInput.Name = "emailRegisterInput";
            this.emailRegisterInput.Size = new System.Drawing.Size(48, 20);
            this.emailRegisterInput.TabIndex = 12;
            this.emailRegisterInput.Text = "Email";
            // 
            // nameRegisterInput
            // 
            this.nameRegisterInput.AutoSize = true;
            this.nameRegisterInput.Location = new System.Drawing.Point(318, 157);
            this.nameRegisterInput.Name = "nameRegisterInput";
            this.nameRegisterInput.Size = new System.Drawing.Size(152, 20);
            this.nameRegisterInput.TabIndex = 11;
            this.nameRegisterInput.Text = "First and Last Name";
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(401, 397);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(188, 61);
            this.registerButton.TabIndex = 10;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(318, 242);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(349, 26);
            this.textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(318, 182);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(349, 26);
            this.textBox1.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(318, 300);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(349, 26);
            this.textBox3.TabIndex = 13;
            // 
            // passwordRegisterInput
            // 
            this.passwordRegisterInput.AutoSize = true;
            this.passwordRegisterInput.Location = new System.Drawing.Point(318, 279);
            this.passwordRegisterInput.Name = "passwordRegisterInput";
            this.passwordRegisterInput.Size = new System.Drawing.Size(78, 20);
            this.passwordRegisterInput.TabIndex = 14;
            this.passwordRegisterInput.Text = "Password";
            // 
            // passwordRepeatRegisterInput
            // 
            this.passwordRepeatRegisterInput.AutoSize = true;
            this.passwordRepeatRegisterInput.Location = new System.Drawing.Point(318, 338);
            this.passwordRepeatRegisterInput.Name = "passwordRepeatRegisterInput";
            this.passwordRepeatRegisterInput.Size = new System.Drawing.Size(135, 20);
            this.passwordRepeatRegisterInput.TabIndex = 16;
            this.passwordRepeatRegisterInput.Text = "Repeat Password";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(318, 363);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(349, 26);
            this.textBox4.TabIndex = 15;
            // 
            // switchToLogin
            // 
            this.switchToLogin.AutoSize = true;
            this.switchToLogin.Location = new System.Drawing.Point(364, 492);
            this.switchToLogin.Name = "switchToLogin";
            this.switchToLogin.Size = new System.Drawing.Size(274, 20);
            this.switchToLogin.TabIndex = 17;
            this.switchToLogin.TabStop = true;
            this.switchToLogin.Text = "Already registered? Click here to login";
            this.switchToLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // RegisterGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.switchToLogin);
            this.Controls.Add(this.passwordRepeatRegisterInput);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.passwordRegisterInput);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.emailRegisterInput);
            this.Controls.Add(this.nameRegisterInput);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.header);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegisterGUI";
            this.Text = "RegisterGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel footer;
        private System.Windows.Forms.Label emailRegisterInput;
        private System.Windows.Forms.Label nameRegisterInput;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label passwordRegisterInput;
        private System.Windows.Forms.Label passwordRepeatRegisterInput;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.LinkLabel switchToLogin;
    }
}