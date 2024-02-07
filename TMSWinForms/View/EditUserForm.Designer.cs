namespace TMSWinForms.View
{
    partial class EditUserForm
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
            this.editAccountLabel = new System.Windows.Forms.Label();
            this.editEmailLabel = new System.Windows.Forms.Label();
            this.editNameLabel = new System.Windows.Forms.Label();
            this.changePasswordLabel = new System.Windows.Forms.Label();
            this.oldPasswordLabel = new System.Windows.Forms.Label();
            this.saveAccountEditButton = new System.Windows.Forms.Button();
            this.deleteAccountButton = new System.Windows.Forms.Button();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.oldPasswordTextBox = new System.Windows.Forms.TextBox();
            this.repeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.repeatPasswordLabel = new System.Windows.Forms.Label();
            this.editPasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // editAccountLabel
            // 
            this.editAccountLabel.AutoSize = true;
            this.editAccountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.editAccountLabel.Location = new System.Drawing.Point(21, 9);
            this.editAccountLabel.Name = "editAccountLabel";
            this.editAccountLabel.Size = new System.Drawing.Size(117, 24);
            this.editAccountLabel.TabIndex = 0;
            this.editAccountLabel.Text = "Edit Account";
            // 
            // editEmailLabel
            // 
            this.editEmailLabel.AutoSize = true;
            this.editEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.editEmailLabel.Location = new System.Drawing.Point(21, 44);
            this.editEmailLabel.Name = "editEmailLabel";
            this.editEmailLabel.Size = new System.Drawing.Size(42, 17);
            this.editEmailLabel.TabIndex = 1;
            this.editEmailLabel.Text = "Email";
            // 
            // editNameLabel
            // 
            this.editNameLabel.AutoSize = true;
            this.editNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.editNameLabel.Location = new System.Drawing.Point(21, 70);
            this.editNameLabel.Name = "editNameLabel";
            this.editNameLabel.Size = new System.Drawing.Size(71, 17);
            this.editNameLabel.TabIndex = 2;
            this.editNameLabel.Text = "Full Name";
            // 
            // changePasswordLabel
            // 
            this.changePasswordLabel.AutoSize = true;
            this.changePasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.changePasswordLabel.Location = new System.Drawing.Point(21, 152);
            this.changePasswordLabel.Name = "changePasswordLabel";
            this.changePasswordLabel.Size = new System.Drawing.Size(69, 17);
            this.changePasswordLabel.TabIndex = 3;
            this.changePasswordLabel.Text = "Password";
            this.changePasswordLabel.Click += new System.EventHandler(this.changePasswordLabel_Click);
            // 
            // oldPasswordLabel
            // 
            this.oldPasswordLabel.AutoSize = true;
            this.oldPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.oldPasswordLabel.Location = new System.Drawing.Point(21, 198);
            this.oldPasswordLabel.Name = "oldPasswordLabel";
            this.oldPasswordLabel.Size = new System.Drawing.Size(95, 17);
            this.oldPasswordLabel.TabIndex = 4;
            this.oldPasswordLabel.Text = "Old Password";
            // 
            // saveAccountEditButton
            // 
            this.saveAccountEditButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveAccountEditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.saveAccountEditButton.FlatAppearance.BorderSize = 0;
            this.saveAccountEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveAccountEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.saveAccountEditButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveAccountEditButton.Location = new System.Drawing.Point(25, 248);
            this.saveAccountEditButton.Name = "saveAccountEditButton";
            this.saveAccountEditButton.Size = new System.Drawing.Size(368, 23);
            this.saveAccountEditButton.TabIndex = 5;
            this.saveAccountEditButton.Text = "Save Changes";
            this.saveAccountEditButton.UseVisualStyleBackColor = false;
            this.saveAccountEditButton.Click += new System.EventHandler(this.saveAccountEditButton_Click);
            // 
            // deleteAccountButton
            // 
            this.deleteAccountButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteAccountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(72)))), ((int)(((byte)(98)))));
            this.deleteAccountButton.FlatAppearance.BorderSize = 0;
            this.deleteAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.deleteAccountButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteAccountButton.Location = new System.Drawing.Point(25, 277);
            this.deleteAccountButton.Name = "deleteAccountButton";
            this.deleteAccountButton.Size = new System.Drawing.Size(368, 23);
            this.deleteAccountButton.TabIndex = 6;
            this.deleteAccountButton.Text = "Delete Account";
            this.deleteAccountButton.UseVisualStyleBackColor = false;
            this.deleteAccountButton.Click += new System.EventHandler(this.deleteAccountButton_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextBox.Location = new System.Drawing.Point(151, 43);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(241, 13);
            this.emailTextBox.TabIndex = 7;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Location = new System.Drawing.Point(151, 69);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(241, 13);
            this.nameTextBox.TabIndex = 8;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Location = new System.Drawing.Point(151, 151);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(241, 13);
            this.passwordTextBox.TabIndex = 9;
            // 
            // oldPasswordTextBox
            // 
            this.oldPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.oldPasswordTextBox.Location = new System.Drawing.Point(151, 197);
            this.oldPasswordTextBox.Name = "oldPasswordTextBox";
            this.oldPasswordTextBox.Size = new System.Drawing.Size(241, 13);
            this.oldPasswordTextBox.TabIndex = 10;
            // 
            // repeatPasswordTextBox
            // 
            this.repeatPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.repeatPasswordTextBox.Location = new System.Drawing.Point(151, 174);
            this.repeatPasswordTextBox.Name = "repeatPasswordTextBox";
            this.repeatPasswordTextBox.Size = new System.Drawing.Size(241, 13);
            this.repeatPasswordTextBox.TabIndex = 12;
            // 
            // repeatPasswordLabel
            // 
            this.repeatPasswordLabel.AutoSize = true;
            this.repeatPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.repeatPasswordLabel.Location = new System.Drawing.Point(21, 175);
            this.repeatPasswordLabel.Name = "repeatPasswordLabel";
            this.repeatPasswordLabel.Size = new System.Drawing.Size(119, 17);
            this.repeatPasswordLabel.TabIndex = 11;
            this.repeatPasswordLabel.Text = "Repeat Password";
            // 
            // editPasswordLabel
            // 
            this.editPasswordLabel.AutoSize = true;
            this.editPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.editPasswordLabel.Location = new System.Drawing.Point(21, 128);
            this.editPasswordLabel.Name = "editPasswordLabel";
            this.editPasswordLabel.Size = new System.Drawing.Size(138, 20);
            this.editPasswordLabel.TabIndex = 13;
            this.editPasswordLabel.Text = "Change Password";
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 326);
            this.Controls.Add(this.editPasswordLabel);
            this.Controls.Add(this.repeatPasswordTextBox);
            this.Controls.Add(this.repeatPasswordLabel);
            this.Controls.Add(this.oldPasswordTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.deleteAccountButton);
            this.Controls.Add(this.saveAccountEditButton);
            this.Controls.Add(this.oldPasswordLabel);
            this.Controls.Add(this.changePasswordLabel);
            this.Controls.Add(this.editNameLabel);
            this.Controls.Add(this.editEmailLabel);
            this.Controls.Add(this.editAccountLabel);
            this.Name = "EditUserForm";
            this.Text = "EditUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label editAccountLabel;
        private System.Windows.Forms.Label editEmailLabel;
        private System.Windows.Forms.Label editNameLabel;
        private System.Windows.Forms.Label changePasswordLabel;
        private System.Windows.Forms.Label oldPasswordLabel;
        private System.Windows.Forms.Button saveAccountEditButton;
        private System.Windows.Forms.Button deleteAccountButton;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox oldPasswordTextBox;
        private System.Windows.Forms.TextBox repeatPasswordTextBox;
        private System.Windows.Forms.Label repeatPasswordLabel;
        private System.Windows.Forms.Label editPasswordLabel;
    }
}