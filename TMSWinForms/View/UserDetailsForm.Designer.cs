namespace TMSWinForms.View
{
    partial class UserDetailsForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.ticketAmountLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.assignedTicketsflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.resetPasswordButton = new System.Windows.Forms.Button();
            this.roleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.nameLabel.Location = new System.Drawing.Point(50, 60);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(61, 24);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.idLabel.Location = new System.Drawing.Point(236, 32);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(57, 20);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "UserId";
            this.idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(50, 84);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(48, 20);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Email";
            // 
            // ticketAmountLabel
            // 
            this.ticketAmountLabel.AutoSize = true;
            this.ticketAmountLabel.Location = new System.Drawing.Point(225, 131);
            this.ticketAmountLabel.Name = "ticketAmountLabel";
            this.ticketAmountLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ticketAmountLabel.Size = new System.Drawing.Size(68, 20);
            this.ticketAmountLabel.TabIndex = 3;
            this.ticketAmountLabel.Text = "#Tickets";
            this.ticketAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Assigned Tickets";
            // 
            // assignedTicketsflowLayoutPanel
            // 
            this.assignedTicketsflowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.assignedTicketsflowLayoutPanel.AutoScroll = true;
            this.assignedTicketsflowLayoutPanel.BackColor = System.Drawing.Color.Lavender;
            this.assignedTicketsflowLayoutPanel.Location = new System.Drawing.Point(54, 154);
            this.assignedTicketsflowLayoutPanel.Name = "assignedTicketsflowLayoutPanel";
            this.assignedTicketsflowLayoutPanel.Size = new System.Drawing.Size(239, 295);
            this.assignedTicketsflowLayoutPanel.TabIndex = 5;
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(72)))), ((int)(((byte)(98)))));
            this.deleteUserButton.FlatAppearance.BorderSize = 0;
            this.deleteUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteUserButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteUserButton.Location = new System.Drawing.Point(54, 455);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(107, 31);
            this.deleteUserButton.TabIndex = 6;
            this.deleteUserButton.Text = "Delete";
            this.deleteUserButton.UseVisualStyleBackColor = false;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // resetPasswordButton
            // 
            this.resetPasswordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.resetPasswordButton.FlatAppearance.BorderSize = 0;
            this.resetPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetPasswordButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.resetPasswordButton.Location = new System.Drawing.Point(186, 455);
            this.resetPasswordButton.Name = "resetPasswordButton";
            this.resetPasswordButton.Size = new System.Drawing.Size(107, 31);
            this.resetPasswordButton.TabIndex = 7;
            this.resetPasswordButton.Text = "Reset Password";
            this.resetPasswordButton.UseVisualStyleBackColor = false;
            this.resetPasswordButton.Click += new System.EventHandler(this.resetPasswordButton_Click);
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Location = new System.Drawing.Point(50, 104);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(36, 20);
            this.roleLabel.TabIndex = 8;
            this.roleLabel.Text = "Roll";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 489);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Delete user or reset password to \"12345678\"";
            // 
            // UserDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 555);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.resetPasswordButton);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.assignedTicketsflowLayoutPanel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ticketAmountLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.nameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserDetailsForm";
            this.Text = "UserDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label ticketAmountLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel assignedTicketsflowLayoutPanel;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Button resetPasswordButton;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Label label1;
    }
}