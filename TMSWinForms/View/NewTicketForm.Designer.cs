namespace TMSWinForms.View
{
    partial class NewTicketForm
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
            this.priorityLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.assignedUserLabel = new System.Windows.Forms.Label();
            this.ticketTitleLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.assingedUserTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.priorityTextBox = new System.Windows.Forms.TextBox();
            this.dialogTitleLabel = new System.Windows.Forms.Label();
            this.saveNewTicketButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // priorityLabel
            // 
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.Location = new System.Drawing.Point(13, 133);
            this.priorityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(52, 17);
            this.priorityLabel.TabIndex = 7;
            this.priorityLabel.Text = "Priority";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(13, 104);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(38, 17);
            this.dateLabel.TabIndex = 6;
            this.dateLabel.Text = "Date";
            // 
            // assignedUserLabel
            // 
            this.assignedUserLabel.AutoSize = true;
            this.assignedUserLabel.Location = new System.Drawing.Point(13, 75);
            this.assignedUserLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.assignedUserLabel.Name = "assignedUserLabel";
            this.assignedUserLabel.Size = new System.Drawing.Size(100, 17);
            this.assignedUserLabel.TabIndex = 5;
            this.assignedUserLabel.Text = "Assigned User";
            // 
            // ticketTitleLabel
            // 
            this.ticketTitleLabel.AutoSize = true;
            this.ticketTitleLabel.Location = new System.Drawing.Point(13, 46);
            this.ticketTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ticketTitleLabel.Name = "ticketTitleLabel";
            this.ticketTitleLabel.Size = new System.Drawing.Size(35, 17);
            this.ticketTitleLabel.TabIndex = 4;
            this.ticketTitleLabel.Text = "Title";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(13, 162);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(79, 17);
            this.descriptionLabel.TabIndex = 8;
            this.descriptionLabel.Text = "Description";
            // 
            // titleTextBox
            // 
            this.titleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleTextBox.Location = new System.Drawing.Point(196, 43);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(240, 16);
            this.titleTextBox.TabIndex = 11;
            // 
            // assingedUserTextBox
            // 
            this.assingedUserTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.assingedUserTextBox.Location = new System.Drawing.Point(196, 72);
            this.assingedUserTextBox.Name = "assingedUserTextBox";
            this.assingedUserTextBox.Size = new System.Drawing.Size(240, 16);
            this.assingedUserTextBox.TabIndex = 12;
            // 
            // dateTextBox
            // 
            this.dateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateTextBox.Location = new System.Drawing.Point(196, 104);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(240, 16);
            this.dateTextBox.TabIndex = 13;
            // 
            // priorityTextBox
            // 
            this.priorityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priorityTextBox.Location = new System.Drawing.Point(196, 133);
            this.priorityTextBox.Name = "priorityTextBox";
            this.priorityTextBox.Size = new System.Drawing.Size(240, 16);
            this.priorityTextBox.TabIndex = 14;
            // 
            // dialogTitleLabel
            // 
            this.dialogTitleLabel.AutoSize = true;
            this.dialogTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dialogTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.dialogTitleLabel.Name = "dialogTitleLabel";
            this.dialogTitleLabel.Size = new System.Drawing.Size(95, 24);
            this.dialogTitleLabel.TabIndex = 15;
            this.dialogTitleLabel.Text = "AddTicket";
            // 
            // saveNewTicketButton
            // 
            this.saveNewTicketButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(72)))), ((int)(((byte)(98)))));
            this.saveNewTicketButton.FlatAppearance.BorderSize = 0;
            this.saveNewTicketButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveNewTicketButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveNewTicketButton.Location = new System.Drawing.Point(16, 293);
            this.saveNewTicketButton.Name = "saveNewTicketButton";
            this.saveNewTicketButton.Size = new System.Drawing.Size(420, 23);
            this.saveNewTicketButton.TabIndex = 16;
            this.saveNewTicketButton.Text = "Save";
            this.saveNewTicketButton.UseVisualStyleBackColor = false;
            this.saveNewTicketButton.Click += new System.EventHandler(this.saveNewTicketButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(17, 182);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(419, 96);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            // 
            // NewTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 328);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.saveNewTicketButton);
            this.Controls.Add(this.dialogTitleLabel);
            this.Controls.Add(this.priorityTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.assingedUserTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.priorityLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.assignedUserLabel);
            this.Controls.Add(this.ticketTitleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewTicketForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label priorityLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label assignedUserLabel;
        private System.Windows.Forms.Label ticketTitleLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox assingedUserTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox priorityTextBox;
        private System.Windows.Forms.Label dialogTitleLabel;
        private System.Windows.Forms.Button saveNewTicketButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}