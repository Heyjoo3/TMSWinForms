namespace TMSWinForms.View
{
    partial class TicketTile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ticketTitleLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.changeStatusButton = new System.Windows.Forms.Button();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.detailsButton = new System.Windows.Forms.Button();
            this.ticketIDLabel = new System.Windows.Forms.Label();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.assignedUserComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketTitleLabel
            // 
            this.ticketTitleLabel.AutoSize = true;
            this.ticketTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ticketTitleLabel.Location = new System.Drawing.Point(13, 15);
            this.ticketTitleLabel.Name = "ticketTitleLabel";
            this.ticketTitleLabel.Size = new System.Drawing.Size(80, 20);
            this.ticketTitleLabel.TabIndex = 0;
            this.ticketTitleLabel.Text = "TicketTitle";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(14, 90);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(38, 17);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "Date";
            // 
            // priorityLabel
            // 
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.Location = new System.Drawing.Point(14, 108);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(52, 17);
            this.priorityLabel.TabIndex = 3;
            this.priorityLabel.Text = "Priority";
            // 
            // changeStatusButton
            // 
            this.changeStatusButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.changeStatusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(72)))), ((int)(((byte)(98)))));
            this.changeStatusButton.FlatAppearance.BorderSize = 0;
            this.changeStatusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeStatusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.changeStatusButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.changeStatusButton.Location = new System.Drawing.Point(140, 63);
            this.changeStatusButton.Name = "changeStatusButton";
            this.changeStatusButton.Size = new System.Drawing.Size(75, 23);
            this.changeStatusButton.TabIndex = 6;
            this.changeStatusButton.Text = "Save";
            this.changeStatusButton.UseVisualStyleBackColor = false;
            this.changeStatusButton.Click += new System.EventHandler(this.changeStatusButton_Click);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Location = new System.Drawing.Point(111, 108);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(8, 8);
            this.dataLayoutControl1.TabIndex = 7;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(20, 20);
            this.Root.TextVisible = false;
            // 
            // detailsButton
            // 
            this.detailsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.detailsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(72)))), ((int)(((byte)(98)))));
            this.detailsButton.FlatAppearance.BorderSize = 0;
            this.detailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detailsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.detailsButton.Location = new System.Drawing.Point(140, 93);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(75, 23);
            this.detailsButton.TabIndex = 8;
            this.detailsButton.Text = "Details";
            this.detailsButton.UseVisualStyleBackColor = false;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // ticketIDLabel
            // 
            this.ticketIDLabel.AutoSize = true;
            this.ticketIDLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ticketIDLabel.Location = new System.Drawing.Point(194, 18);
            this.ticketIDLabel.Name = "ticketIDLabel";
            this.ticketIDLabel.Size = new System.Drawing.Size(21, 17);
            this.ticketIDLabel.TabIndex = 9;
            this.ticketIDLabel.Text = "ID";
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Items.AddRange(new object[] {
            "Unassigned",
            "Assigned",
            "Finished"});
            this.StatusComboBox.Location = new System.Drawing.Point(17, 38);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(121, 24);
            this.StatusComboBox.TabIndex = 10;
            // 
            // assignedUserComboBox
            // 
            this.assignedUserComboBox.FormattingEnabled = true;
            this.assignedUserComboBox.Items.AddRange(new object[] {
            "Unassigned",
            "Assigned",
            "Finished"});
            this.assignedUserComboBox.Location = new System.Drawing.Point(17, 63);
            this.assignedUserComboBox.Name = "assignedUserComboBox";
            this.assignedUserComboBox.Size = new System.Drawing.Size(121, 24);
            this.assignedUserComboBox.TabIndex = 11;
            // 
            // TicketTile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.assignedUserComboBox);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.ticketIDLabel);
            this.Controls.Add(this.detailsButton);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.changeStatusButton);
            this.Controls.Add(this.priorityLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.ticketTitleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TicketTile";
            this.Size = new System.Drawing.Size(230, 134);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ticketTitleLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label priorityLabel;
        private System.Windows.Forms.Button changeStatusButton;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.Button detailsButton;
        private System.Windows.Forms.Label ticketIDLabel;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.ComboBox assignedUserComboBox;
    }
}
