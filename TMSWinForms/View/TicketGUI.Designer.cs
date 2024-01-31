namespace TMSWinForms.View
{
    partial class TicketGUI
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
            this.pageTitle = new System.Windows.Forms.Label();
            this.footer = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.newTicketButton = new System.Windows.Forms.Button();
            this.newUserButton = new System.Windows.Forms.Button();
            this.userListBox = new System.Windows.Forms.ListBox();
            this.unassingedflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.assingedflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.finishedflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.unassingedLabel = new System.Windows.Forms.Label();
            this.assingedLabel = new System.Windows.Forms.Label();
            this.finishedLabel = new System.Windows.Forms.Label();
            this.header.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.header.BackColor = System.Drawing.Color.SlateBlue;
            this.header.Controls.Add(this.pageTitle);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(984, 88);
            this.header.TabIndex = 0;
            // 
            // pageTitle
            // 
            this.pageTitle.AutoSize = true;
            this.pageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.pageTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pageTitle.Location = new System.Drawing.Point(295, 24);
            this.pageTitle.Name = "pageTitle";
            this.pageTitle.Size = new System.Drawing.Size(411, 37);
            this.pageTitle.TabIndex = 0;
            this.pageTitle.Text = "Ticket Management System";
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(0, 589);
            this.footer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(984, 72);
            this.footer.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.finishedLabel);
            this.panel2.Controls.Add(this.assingedLabel);
            this.panel2.Controls.Add(this.unassingedLabel);
            this.panel2.Controls.Add(this.finishedflowLayoutPanel);
            this.panel2.Controls.Add(this.assingedflowLayoutPanel);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.unassingedflowLayoutPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 501);
            this.panel2.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.RosyBrown;
            this.flowLayoutPanel1.Controls.Add(this.newTicketButton);
            this.flowLayoutPanel1.Controls.Add(this.newUserButton);
            this.flowLayoutPanel1.Controls.Add(this.userListBox);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 501);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // newTicketButton
            // 
            this.newTicketButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newTicketButton.Location = new System.Drawing.Point(3, 456);
            this.newTicketButton.Name = "newTicketButton";
            this.newTicketButton.Size = new System.Drawing.Size(189, 42);
            this.newTicketButton.TabIndex = 0;
            this.newTicketButton.Text = "new Ticket";
            this.newTicketButton.UseVisualStyleBackColor = true;
            // 
            // newUserButton
            // 
            this.newUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newUserButton.Location = new System.Drawing.Point(3, 408);
            this.newUserButton.Name = "newUserButton";
            this.newUserButton.Size = new System.Drawing.Size(189, 42);
            this.newUserButton.TabIndex = 1;
            this.newUserButton.Text = "new User";
            this.newUserButton.UseVisualStyleBackColor = true;
            this.newUserButton.Click += new System.EventHandler(this.newUserButton_Click);
            // 
            // userListBox
            // 
            this.userListBox.FormattingEnabled = true;
            this.userListBox.ItemHeight = 20;
            this.userListBox.Location = new System.Drawing.Point(3, 318);
            this.userListBox.Name = "userListBox";
            this.userListBox.Size = new System.Drawing.Size(120, 84);
            this.userListBox.TabIndex = 2;
            // 
            // unassingedflowLayoutPanel
            // 
            this.unassingedflowLayoutPanel.AutoScroll = true;
            this.unassingedflowLayoutPanel.BackColor = System.Drawing.Color.MistyRose;
            this.unassingedflowLayoutPanel.Location = new System.Drawing.Point(206, 32);
            this.unassingedflowLayoutPanel.Name = "unassingedflowLayoutPanel";
            this.unassingedflowLayoutPanel.Size = new System.Drawing.Size(254, 461);
            this.unassingedflowLayoutPanel.TabIndex = 3;
            // 
            // assingedflowLayoutPanel
            // 
            this.assingedflowLayoutPanel.AutoScroll = true;
            this.assingedflowLayoutPanel.BackColor = System.Drawing.Color.MistyRose;
            this.assingedflowLayoutPanel.Location = new System.Drawing.Point(466, 32);
            this.assingedflowLayoutPanel.Name = "assingedflowLayoutPanel";
            this.assingedflowLayoutPanel.Size = new System.Drawing.Size(254, 461);
            this.assingedflowLayoutPanel.TabIndex = 4;
            // 
            // finishedflowLayoutPanel
            // 
            this.finishedflowLayoutPanel.AutoScroll = true;
            this.finishedflowLayoutPanel.BackColor = System.Drawing.Color.MistyRose;
            this.finishedflowLayoutPanel.Location = new System.Drawing.Point(726, 32);
            this.finishedflowLayoutPanel.Name = "finishedflowLayoutPanel";
            this.finishedflowLayoutPanel.Size = new System.Drawing.Size(254, 461);
            this.finishedflowLayoutPanel.TabIndex = 4;
            // 
            // unassingedLabel
            // 
            this.unassingedLabel.AutoSize = true;
            this.unassingedLabel.Location = new System.Drawing.Point(289, 9);
            this.unassingedLabel.Name = "unassingedLabel";
            this.unassingedLabel.Size = new System.Drawing.Size(94, 20);
            this.unassingedLabel.TabIndex = 5;
            this.unassingedLabel.Text = "Unassinged";
            // 
            // assingedLabel
            // 
            this.assingedLabel.AutoSize = true;
            this.assingedLabel.Location = new System.Drawing.Point(554, 9);
            this.assingedLabel.Name = "assingedLabel";
            this.assingedLabel.Size = new System.Drawing.Size(75, 20);
            this.assingedLabel.TabIndex = 6;
            this.assingedLabel.Text = "Assigned";
            // 
            // finishedLabel
            // 
            this.finishedLabel.AutoSize = true;
            this.finishedLabel.Location = new System.Drawing.Point(815, 9);
            this.finishedLabel.Name = "finishedLabel";
            this.finishedLabel.Size = new System.Drawing.Size(69, 20);
            this.finishedLabel.TabIndex = 0;
            this.finishedLabel.Text = "Finished";
            // 
            // TicketGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.header);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TicketGUI";
            this.Text = "Form1";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel footer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button newUserButton;
        private System.Windows.Forms.Button newTicketButton;
        private System.Windows.Forms.Label pageTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListBox userListBox;
        private System.Windows.Forms.Label unassingedLabel;
        private System.Windows.Forms.FlowLayoutPanel finishedflowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel assingedflowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel unassingedflowLayoutPanel;
        private System.Windows.Forms.Label assingedLabel;
        private System.Windows.Forms.Label finishedLabel;
    }
}