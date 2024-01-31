namespace TMSWinForms.View
{
    partial class EditTicketForm
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
            this.saveNewTicketButton = new System.Windows.Forms.Button();
            this.dialogTitleLabel = new System.Windows.Forms.Label();
            this.priorityTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.assingedUserTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.assignedUserLabel = new System.Windows.Forms.Label();
            this.ticketTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveNewTicketButton
            // 
            this.saveNewTicketButton.Location = new System.Drawing.Point(16, 191);
            this.saveNewTicketButton.Name = "saveNewTicketButton";
            this.saveNewTicketButton.Size = new System.Drawing.Size(280, 23);
            this.saveNewTicketButton.TabIndex = 28;
            this.saveNewTicketButton.Text = "Save";
            this.saveNewTicketButton.UseVisualStyleBackColor = true;
            this.saveNewTicketButton.Click += new System.EventHandler(this.saveNewTicketButton_Click);
            // 
            // dialogTitleLabel
            // 
            this.dialogTitleLabel.AutoSize = true;
            this.dialogTitleLabel.Location = new System.Drawing.Point(13, 23);
            this.dialogTitleLabel.Name = "dialogTitleLabel";
            this.dialogTitleLabel.Size = new System.Drawing.Size(74, 17);
            this.dialogTitleLabel.TabIndex = 27;
            this.dialogTitleLabel.Text = "Edit Ticket";
            // 
            // priorityTextBox
            // 
            this.priorityTextBox.Location = new System.Drawing.Point(196, 133);
            this.priorityTextBox.Name = "priorityTextBox";
            this.priorityTextBox.Size = new System.Drawing.Size(100, 23);
            this.priorityTextBox.TabIndex = 26;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(196, 104);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(100, 23);
            this.dateTextBox.TabIndex = 25;
            // 
            // assingedUserTextBox
            // 
            this.assingedUserTextBox.Location = new System.Drawing.Point(196, 75);
            this.assingedUserTextBox.Name = "assingedUserTextBox";
            this.assingedUserTextBox.Size = new System.Drawing.Size(100, 23);
            this.assingedUserTextBox.TabIndex = 24;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(196, 46);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 23);
            this.titleTextBox.TabIndex = 23;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(196, 162);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 23);
            this.descriptionTextBox.TabIndex = 22;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(13, 165);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(79, 17);
            this.descriptionLabel.TabIndex = 21;
            this.descriptionLabel.Text = "Description";
            // 
            // priorityLabel
            // 
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.Location = new System.Drawing.Point(13, 136);
            this.priorityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(52, 17);
            this.priorityLabel.TabIndex = 20;
            this.priorityLabel.Text = "Priority";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(13, 107);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(38, 17);
            this.dateLabel.TabIndex = 19;
            this.dateLabel.Text = "Date";
            // 
            // assignedUserLabel
            // 
            this.assignedUserLabel.AutoSize = true;
            this.assignedUserLabel.Location = new System.Drawing.Point(13, 78);
            this.assignedUserLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.assignedUserLabel.Name = "assignedUserLabel";
            this.assignedUserLabel.Size = new System.Drawing.Size(100, 17);
            this.assignedUserLabel.TabIndex = 18;
            this.assignedUserLabel.Text = "Assigned User";
            // 
            // ticketTitleLabel
            // 
            this.ticketTitleLabel.AutoSize = true;
            this.ticketTitleLabel.Location = new System.Drawing.Point(13, 49);
            this.ticketTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ticketTitleLabel.Name = "ticketTitleLabel";
            this.ticketTitleLabel.Size = new System.Drawing.Size(35, 17);
            this.ticketTitleLabel.TabIndex = 17;
            this.ticketTitleLabel.Text = "Title";
            // 
            // EditTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 267);
            this.Controls.Add(this.saveNewTicketButton);
            this.Controls.Add(this.dialogTitleLabel);
            this.Controls.Add(this.priorityTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.assingedUserTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.priorityLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.assignedUserLabel);
            this.Controls.Add(this.ticketTitleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditTicketForm";
            this.Text = "EditTicketForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveNewTicketButton;
        private System.Windows.Forms.Label dialogTitleLabel;
        private System.Windows.Forms.TextBox priorityTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox assingedUserTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label priorityLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label assignedUserLabel;
        private System.Windows.Forms.Label ticketTitleLabel;
    }
}