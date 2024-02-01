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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pageTitle = new System.Windows.Forms.Label();
            this.footer = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.finishedLabel = new System.Windows.Forms.Label();
            this.assingedLabel = new System.Windows.Forms.Label();
            this.unassingedLabel = new System.Windows.Forms.Label();
            this.finishedflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.assingedflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.userListBox = new System.Windows.Forms.ListBox();
            this.editAccountButton = new System.Windows.Forms.Button();
            this.newTicketButton = new System.Windows.Forms.Button();
            this.unassingedflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.header.SuspendLayout();
            this.footer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.header.Controls.Add(this.panel1);
            this.header.Controls.Add(this.pageTitle);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(984, 88);
            this.header.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(72)))), ((int)(((byte)(98)))));
            this.panel1.Location = new System.Drawing.Point(3, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 10);
            this.panel1.TabIndex = 41;
            // 
            // pageTitle
            // 
            this.pageTitle.AutoSize = true;
            this.pageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.pageTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pageTitle.Location = new System.Drawing.Point(537, 24);
            this.pageTitle.Name = "pageTitle";
            this.pageTitle.Size = new System.Drawing.Size(435, 37);
            this.pageTitle.TabIndex = 0;
            this.pageTitle.Text = "Ticket Management System";
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.footer.Controls.Add(this.panel3);
            this.footer.Controls.Add(this.logoutButton);
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(0, 589);
            this.footer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(984, 72);
            this.footer.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(72)))), ((int)(((byte)(98)))));
            this.panel3.Location = new System.Drawing.Point(2, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(985, 10);
            this.panel3.TabIndex = 42;
            // 
            // logoutButton
            // 
            this.logoutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(72)))), ((int)(((byte)(98)))));
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logoutButton.Location = new System.Drawing.Point(898, 28);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(74, 32);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
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
            // finishedLabel
            // 
            this.finishedLabel.AutoSize = true;
            this.finishedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.finishedLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.finishedLabel.Location = new System.Drawing.Point(886, 9);
            this.finishedLabel.Name = "finishedLabel";
            this.finishedLabel.Size = new System.Drawing.Size(94, 20);
            this.finishedLabel.TabIndex = 0;
            this.finishedLabel.Text = "FINSIHED";
            // 
            // assingedLabel
            // 
            this.assingedLabel.AutoSize = true;
            this.assingedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.assingedLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.assingedLabel.Location = new System.Drawing.Point(618, 9);
            this.assingedLabel.Name = "assingedLabel";
            this.assingedLabel.Size = new System.Drawing.Size(102, 20);
            this.assingedLabel.TabIndex = 6;
            this.assingedLabel.Text = "ASSIGNED";
            // 
            // unassingedLabel
            // 
            this.unassingedLabel.AutoSize = true;
            this.unassingedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.unassingedLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.unassingedLabel.Location = new System.Drawing.Point(333, 9);
            this.unassingedLabel.Name = "unassingedLabel";
            this.unassingedLabel.Size = new System.Drawing.Size(127, 20);
            this.unassingedLabel.TabIndex = 5;
            this.unassingedLabel.Text = "UNASSIGNED";
            // 
            // finishedflowLayoutPanel
            // 
            this.finishedflowLayoutPanel.AutoScroll = true;
            this.finishedflowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.finishedflowLayoutPanel.BackColor = System.Drawing.Color.Lavender;
            this.finishedflowLayoutPanel.Location = new System.Drawing.Point(726, 32);
            this.finishedflowLayoutPanel.Name = "finishedflowLayoutPanel";
            this.finishedflowLayoutPanel.Size = new System.Drawing.Size(254, 461);
            this.finishedflowLayoutPanel.TabIndex = 4;
            // 
            // assingedflowLayoutPanel
            // 
            this.assingedflowLayoutPanel.AutoScroll = true;
            this.assingedflowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.assingedflowLayoutPanel.BackColor = System.Drawing.Color.Lavender;
            this.assingedflowLayoutPanel.Location = new System.Drawing.Point(466, 32);
            this.assingedflowLayoutPanel.Name = "assingedflowLayoutPanel";
            this.assingedflowLayoutPanel.Size = new System.Drawing.Size(254, 461);
            this.assingedflowLayoutPanel.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel1.Controls.Add(this.userListBox);
            this.flowLayoutPanel1.Controls.Add(this.editAccountButton);
            this.flowLayoutPanel1.Controls.Add(this.newTicketButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(203, 501);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // userListBox
            // 
            this.userListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.userListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userListBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userListBox.FormattingEnabled = true;
            this.userListBox.ItemHeight = 20;
            this.userListBox.Location = new System.Drawing.Point(3, 3);
            this.userListBox.Name = "userListBox";
            this.userListBox.Size = new System.Drawing.Size(197, 300);
            this.userListBox.TabIndex = 2;
            // 
            // editAccountButton
            // 
            this.editAccountButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editAccountButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editAccountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(72)))), ((int)(((byte)(98)))));
            this.editAccountButton.FlatAppearance.BorderSize = 0;
            this.editAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editAccountButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.editAccountButton.Location = new System.Drawing.Point(3, 309);
            this.editAccountButton.Name = "editAccountButton";
            this.editAccountButton.Size = new System.Drawing.Size(191, 42);
            this.editAccountButton.TabIndex = 1;
            this.editAccountButton.Text = "Edit Account";
            this.editAccountButton.UseVisualStyleBackColor = false;
            this.editAccountButton.Click += new System.EventHandler(this.newUserButton_Click);
            // 
            // newTicketButton
            // 
            this.newTicketButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newTicketButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.newTicketButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(72)))), ((int)(((byte)(98)))));
            this.newTicketButton.FlatAppearance.BorderSize = 0;
            this.newTicketButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newTicketButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.newTicketButton.Location = new System.Drawing.Point(3, 357);
            this.newTicketButton.Name = "newTicketButton";
            this.newTicketButton.Size = new System.Drawing.Size(191, 42);
            this.newTicketButton.TabIndex = 0;
            this.newTicketButton.Text = "New Ticket";
            this.newTicketButton.UseVisualStyleBackColor = false;
            this.newTicketButton.Click += new System.EventHandler(this.newTicketButton_Click);
            // 
            // unassingedflowLayoutPanel
            // 
            this.unassingedflowLayoutPanel.AutoScroll = true;
            this.unassingedflowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.unassingedflowLayoutPanel.BackColor = System.Drawing.Color.Lavender;
            this.unassingedflowLayoutPanel.Location = new System.Drawing.Point(206, 32);
            this.unassingedflowLayoutPanel.Name = "unassingedflowLayoutPanel";
            this.unassingedflowLayoutPanel.Size = new System.Drawing.Size(254, 461);
            this.unassingedflowLayoutPanel.TabIndex = 3;
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
            this.footer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel footer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button editAccountButton;
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
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
    }
}