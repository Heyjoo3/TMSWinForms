namespace TMSWinForms.View
{
    partial class TicketDetailsForm
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
            this.dialogTitleLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.assignedUserLabel = new System.Windows.Forms.Label();
            this.ticketTitleLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.assignedUserTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.priorityComboBox = new System.Windows.Forms.ComboBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.assignedUserComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dialogTitleLabel
            // 
            this.dialogTitleLabel.AutoSize = true;
            this.dialogTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dialogTitleLabel.Location = new System.Drawing.Point(55, 36);
            this.dialogTitleLabel.Name = "dialogTitleLabel";
            this.dialogTitleLabel.Size = new System.Drawing.Size(79, 26);
            this.dialogTitleLabel.TabIndex = 33;
            this.dialogTitleLabel.Text = "Details";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.descriptionLabel.Location = new System.Drawing.Point(57, 231);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(79, 17);
            this.descriptionLabel.TabIndex = 32;
            this.descriptionLabel.Text = "Description";
            // 
            // priorityLabel
            // 
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.priorityLabel.Location = new System.Drawing.Point(57, 193);
            this.priorityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(52, 17);
            this.priorityLabel.TabIndex = 31;
            this.priorityLabel.Text = "Priority";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateLabel.Location = new System.Drawing.Point(57, 158);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(38, 17);
            this.dateLabel.TabIndex = 30;
            this.dateLabel.Text = "Date";
            // 
            // assignedUserLabel
            // 
            this.assignedUserLabel.AutoSize = true;
            this.assignedUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.assignedUserLabel.Location = new System.Drawing.Point(57, 127);
            this.assignedUserLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.assignedUserLabel.Name = "assignedUserLabel";
            this.assignedUserLabel.Size = new System.Drawing.Size(100, 17);
            this.assignedUserLabel.TabIndex = 29;
            this.assignedUserLabel.Text = "Assigned User";
            // 
            // ticketTitleLabel
            // 
            this.ticketTitleLabel.AutoSize = true;
            this.ticketTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ticketTitleLabel.Location = new System.Drawing.Point(57, 93);
            this.ticketTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ticketTitleLabel.Name = "ticketTitleLabel";
            this.ticketTitleLabel.Size = new System.Drawing.Size(35, 17);
            this.ticketTitleLabel.TabIndex = 28;
            this.ticketTitleLabel.Text = "Title";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.statusLabel.Location = new System.Drawing.Point(251, 43);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(48, 17);
            this.statusLabel.TabIndex = 34;
            this.statusLabel.Text = "Status";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.Color.Lavender;
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionTextBox.Location = new System.Drawing.Point(60, 251);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(239, 96);
            this.descriptionTextBox.TabIndex = 35;
            this.descriptionTextBox.Text = "";
            // 
            // dateTextBox
            // 
            this.dateTextBox.BackColor = System.Drawing.Color.Lavender;
            this.dateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateTextBox.Location = new System.Drawing.Point(161, 160);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(138, 13);
            this.dateTextBox.TabIndex = 37;
            // 
            // assignedUserTextBox
            // 
            this.assignedUserTextBox.BackColor = System.Drawing.Color.Lavender;
            this.assignedUserTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.assignedUserTextBox.Location = new System.Drawing.Point(161, 129);
            this.assignedUserTextBox.Name = "assignedUserTextBox";
            this.assignedUserTextBox.Size = new System.Drawing.Size(138, 13);
            this.assignedUserTextBox.TabIndex = 38;
            // 
            // titleTextBox
            // 
            this.titleTextBox.BackColor = System.Drawing.Color.Lavender;
            this.titleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleTextBox.Location = new System.Drawing.Point(161, 97);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(138, 13);
            this.titleTextBox.TabIndex = 39;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(72)))), ((int)(((byte)(98)))));
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteButton.Location = new System.Drawing.Point(183, 353);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(116, 23);
            this.deleteButton.TabIndex = 41;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.editButton.Location = new System.Drawing.Point(59, 353);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(118, 23);
            this.editButton.TabIndex = 42;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // priorityComboBox
            // 
            this.priorityComboBox.BackColor = System.Drawing.Color.Lavender;
            this.priorityComboBox.FormattingEnabled = true;
            this.priorityComboBox.Items.AddRange(new object[] {
            "1 = High",
            "2 = Medium",
            "3 = Low"});
            this.priorityComboBox.Location = new System.Drawing.Point(161, 193);
            this.priorityComboBox.Name = "priorityComboBox";
            this.priorityComboBox.Size = new System.Drawing.Size(138, 21);
            this.priorityComboBox.TabIndex = 43;
            // 
            // statusComboBox
            // 
            this.statusComboBox.BackColor = System.Drawing.Color.Lavender;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Unassigned",
            "Assigned",
            "Finished"});
            this.statusComboBox.Location = new System.Drawing.Point(161, 63);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(138, 21);
            this.statusComboBox.TabIndex = 44;
            // 
            // assignedUserComboBox
            // 
            this.assignedUserComboBox.BackColor = System.Drawing.Color.Lavender;
            this.assignedUserComboBox.FormattingEnabled = true;
            this.assignedUserComboBox.Location = new System.Drawing.Point(161, 208);
            this.assignedUserComboBox.Name = "assignedUserComboBox";
            this.assignedUserComboBox.Size = new System.Drawing.Size(138, 21);
            this.assignedUserComboBox.TabIndex = 45;
            // 
            // TicketDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(375, 436);
            this.Controls.Add(this.assignedUserComboBox);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.priorityComboBox);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.assignedUserTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.dialogTitleLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.priorityLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.assignedUserLabel);
            this.Controls.Add(this.ticketTitleLabel);
            this.Name = "TicketDetailsForm";
            this.Text = "TicketDetailsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dialogTitleLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label priorityLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label assignedUserLabel;
        private System.Windows.Forms.Label ticketTitleLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox assignedUserTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.ComboBox priorityComboBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.ComboBox assignedUserComboBox;
    }
}