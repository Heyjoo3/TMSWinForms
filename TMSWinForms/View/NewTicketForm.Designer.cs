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
            this.components = new System.ComponentModel.Container();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.assignedUserLabel = new System.Windows.Forms.Label();
            this.ticketTitleLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.dialogTitleLabel = new System.Windows.Forms.Label();
            this.saveNewTicketButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.priorityComboBox = new System.Windows.Forms.ComboBox();
            this.usersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.assignedUserComboBox = new System.Windows.Forms.ComboBox();
            this.userManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketTileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userManagerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketTileBindingSource)).BeginInit();
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
            this.dateLabel.Location = new System.Drawing.Point(14, 106);
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
            this.ticketTitleLabel.Size = new System.Drawing.Size(40, 17);
            this.ticketTitleLabel.TabIndex = 4;
            this.ticketTitleLabel.Text = "Title*";
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
            // dialogTitleLabel
            // 
            this.dialogTitleLabel.AutoSize = true;
            this.dialogTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dialogTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.dialogTitleLabel.Name = "dialogTitleLabel";
            this.dialogTitleLabel.Size = new System.Drawing.Size(100, 24);
            this.dialogTitleLabel.TabIndex = 15;
            this.dialogTitleLabel.Text = "Add Ticket";
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
            // descriptionTextBox
            // 
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionTextBox.Location = new System.Drawing.Point(17, 182);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(419, 96);
            this.descriptionTextBox.TabIndex = 17;
            this.descriptionTextBox.Text = "";
            // 
            // priorityComboBox
            // 
            this.priorityComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.priorityComboBox.FormattingEnabled = true;
            this.priorityComboBox.Items.AddRange(new object[] {
            "1 = High",
            "2 = Medium",
            "3 = Low"});
            this.priorityComboBox.Location = new System.Drawing.Point(196, 130);
            this.priorityComboBox.Name = "priorityComboBox";
            this.priorityComboBox.Size = new System.Drawing.Size(240, 24);
            this.priorityComboBox.TabIndex = 18;
            this.priorityComboBox.Text = "1 = High";
            // 
            // usersBindingSource2
            // 
            this.usersBindingSource2.DataMember = "Users";
            this.usersBindingSource2.DataSource = this.userManagerBindingSource;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.userManagerBindingSource;
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "Users";
            this.usersBindingSource1.DataSource = this.userManagerBindingSource;
            // 
            // assignedUserComboBox
            // 
            this.assignedUserComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assignedUserComboBox.FormattingEnabled = true;
            this.assignedUserComboBox.Location = new System.Drawing.Point(196, 72);
            this.assignedUserComboBox.Name = "assignedUserComboBox";
            this.assignedUserComboBox.Size = new System.Drawing.Size(240, 24);
            this.assignedUserComboBox.TabIndex = 20;
            //
            // 
            // ticketTileBindingSource
            // 
            this.ticketTileBindingSource.DataSource = typeof(TMSWinForms.View.TicketTile);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(196, 101);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(240, 23);
            this.dateTimePicker.TabIndex = 21;
            // 
            // NewTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 328);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.assignedUserComboBox);
            this.Controls.Add(this.priorityComboBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.saveNewTicketButton);
            this.Controls.Add(this.dialogTitleLabel);
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
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userManagerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketTileBindingSource)).EndInit();
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
        private System.Windows.Forms.Label dialogTitleLabel;
        private System.Windows.Forms.Button saveNewTicketButton;
        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.ComboBox priorityComboBox;
        private System.Windows.Forms.BindingSource ticketTileBindingSource;
        private System.Windows.Forms.BindingSource userManagerBindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private System.Windows.Forms.BindingSource usersBindingSource2;
        private System.Windows.Forms.ComboBox assignedUserComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}