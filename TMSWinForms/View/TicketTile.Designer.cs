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
            this.assignedUserLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.deleteTicketButton = new System.Windows.Forms.Button();
            this.editTicketButton = new System.Windows.Forms.Button();
            this.changeStatusButton = new System.Windows.Forms.Button();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.detailsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketTitleLabel
            // 
            this.ticketTitleLabel.AutoSize = true;
            this.ticketTitleLabel.Location = new System.Drawing.Point(15, 21);
            this.ticketTitleLabel.Name = "ticketTitleLabel";
            this.ticketTitleLabel.Size = new System.Drawing.Size(73, 17);
            this.ticketTitleLabel.TabIndex = 0;
            this.ticketTitleLabel.Text = "TicketTitle";
            // 
            // assignedUserLabel
            // 
            this.assignedUserLabel.AutoSize = true;
            this.assignedUserLabel.Location = new System.Drawing.Point(15, 47);
            this.assignedUserLabel.Name = "assignedUserLabel";
            this.assignedUserLabel.Size = new System.Drawing.Size(100, 17);
            this.assignedUserLabel.TabIndex = 1;
            this.assignedUserLabel.Text = "Assigned User";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(15, 73);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(38, 17);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "Date";
            // 
            // priorityLabel
            // 
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.Location = new System.Drawing.Point(15, 102);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(52, 17);
            this.priorityLabel.TabIndex = 3;
            this.priorityLabel.Text = "Priority";
            // 
            // deleteTicketButton
            // 
            this.deleteTicketButton.Location = new System.Drawing.Point(141, 15);
            this.deleteTicketButton.Name = "deleteTicketButton";
            this.deleteTicketButton.Size = new System.Drawing.Size(75, 23);
            this.deleteTicketButton.TabIndex = 4;
            this.deleteTicketButton.Text = "Delete";
            this.deleteTicketButton.UseVisualStyleBackColor = true;
            this.deleteTicketButton.Click += new System.EventHandler(this.deleteTicketButton_Click);
            // 
            // editTicketButton
            // 
            this.editTicketButton.Location = new System.Drawing.Point(141, 44);
            this.editTicketButton.Name = "editTicketButton";
            this.editTicketButton.Size = new System.Drawing.Size(75, 23);
            this.editTicketButton.TabIndex = 5;
            this.editTicketButton.Text = "Edit";
            this.editTicketButton.UseVisualStyleBackColor = true;
            this.editTicketButton.Click += new System.EventHandler(this.editTicketButton_Click);
            // 
            // changeStatusButton
            // 
            this.changeStatusButton.Location = new System.Drawing.Point(141, 73);
            this.changeStatusButton.Name = "changeStatusButton";
            this.changeStatusButton.Size = new System.Drawing.Size(75, 23);
            this.changeStatusButton.TabIndex = 6;
            this.changeStatusButton.Text = "Status";
            this.changeStatusButton.UseVisualStyleBackColor = true;
            this.changeStatusButton.Click += new System.EventHandler(this.changeStatusButton_Click);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Location = new System.Drawing.Point(112, 121);
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
            this.detailsButton.Location = new System.Drawing.Point(141, 102);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(75, 23);
            this.detailsButton.TabIndex = 8;
            this.detailsButton.Text = "Details";
            this.detailsButton.UseVisualStyleBackColor = true;
            // 
            // TicketTile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.detailsButton);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.changeStatusButton);
            this.Controls.Add(this.editTicketButton);
            this.Controls.Add(this.deleteTicketButton);
            this.Controls.Add(this.priorityLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.assignedUserLabel);
            this.Controls.Add(this.ticketTitleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TicketTile";
            this.Size = new System.Drawing.Size(230, 142);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ticketTitleLabel;
        private System.Windows.Forms.Label assignedUserLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label priorityLabel;
        private System.Windows.Forms.Button deleteTicketButton;
        private System.Windows.Forms.Button editTicketButton;
        private System.Windows.Forms.Button changeStatusButton;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.Button detailsButton;
    }
}
