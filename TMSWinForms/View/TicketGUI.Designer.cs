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
            this.panel4 = new System.Windows.Forms.Panel();
            this.pageTitle = new System.Windows.Forms.Label();
            this.footer = new System.Windows.Forms.Panel();
            this.refreshButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.allUserLabel = new System.Windows.Forms.Label();
            this.userListBox = new System.Windows.Forms.ListBox();
            this.editAccountButton = new System.Windows.Forms.Button();
            this.newTicketButton = new System.Windows.Forms.Button();
            this.showOnlyMyCheckBox = new System.Windows.Forms.CheckBox();
            this.sortingComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.assignedflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.assingedLabel = new System.Windows.Forms.Label();
            this.finishedLabel = new System.Windows.Forms.Label();
            this.unassingedflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.finishedflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.unassingedLabel = new System.Windows.Forms.Label();
            this.header.SuspendLayout();
            this.panel1.SuspendLayout();
            this.footer.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.header.Size = new System.Drawing.Size(939, 88);
            this.header.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(72)))), ((int)(((byte)(98)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 10);
            this.panel1.TabIndex = 41;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(939, 10);
            this.panel4.TabIndex = 7;
            // 
            // pageTitle
            // 
            this.pageTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pageTitle.AutoSize = true;
            this.pageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.pageTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pageTitle.Location = new System.Drawing.Point(492, 18);
            this.pageTitle.Name = "pageTitle";
            this.pageTitle.Size = new System.Drawing.Size(435, 37);
            this.pageTitle.TabIndex = 0;
            this.pageTitle.Text = "Ticket Management System";
            this.pageTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.footer.Controls.Add(this.refreshButton);
            this.footer.Controls.Add(this.panel3);
            this.footer.Controls.Add(this.logoutButton);
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(0, 697);
            this.footer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(939, 72);
            this.footer.TabIndex = 1;
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.refreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(72)))), ((int)(((byte)(98)))));
            this.refreshButton.FlatAppearance.BorderSize = 0;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.refreshButton.Location = new System.Drawing.Point(773, 28);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(74, 32);
            this.refreshButton.TabIndex = 43;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(72)))), ((int)(((byte)(98)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(939, 10);
            this.panel3.TabIndex = 42;
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(72)))), ((int)(((byte)(98)))));
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logoutButton.Location = new System.Drawing.Point(853, 28);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(74, 32);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel1.Controls.Add(this.allUserLabel);
            this.flowLayoutPanel1.Controls.Add(this.userListBox);
            this.flowLayoutPanel1.Controls.Add(this.editAccountButton);
            this.flowLayoutPanel1.Controls.Add(this.newTicketButton);
            this.flowLayoutPanel1.Controls.Add(this.showOnlyMyCheckBox);
            this.flowLayoutPanel1.Controls.Add(this.sortingComboBox);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(203, 609);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // allUserLabel
            // 
            this.allUserLabel.AutoSize = true;
            this.allUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.allUserLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.allUserLabel.Location = new System.Drawing.Point(3, 0);
            this.allUserLabel.Name = "allUserLabel";
            this.allUserLabel.Size = new System.Drawing.Size(84, 24);
            this.allUserLabel.TabIndex = 4;
            this.allUserLabel.Text = "All Users";
            // 
            // userListBox
            // 
            this.userListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.userListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userListBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userListBox.FormattingEnabled = true;
            this.userListBox.ItemHeight = 20;
            this.userListBox.Location = new System.Drawing.Point(3, 27);
            this.userListBox.Name = "userListBox";
            this.userListBox.Size = new System.Drawing.Size(197, 360);
            this.userListBox.TabIndex = 2;
            this.userListBox.SelectedIndexChanged += new System.EventHandler(this.userListBox_SelectedIndexChanged);
            // 
            // editAccountButton
            // 
            this.editAccountButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.editAccountButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editAccountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(72)))), ((int)(((byte)(98)))));
            this.editAccountButton.FlatAppearance.BorderSize = 0;
            this.editAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editAccountButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.editAccountButton.Location = new System.Drawing.Point(6, 393);
            this.editAccountButton.Name = "editAccountButton";
            this.editAccountButton.Size = new System.Drawing.Size(191, 42);
            this.editAccountButton.TabIndex = 1;
            this.editAccountButton.Text = "Edit Account";
            this.editAccountButton.UseVisualStyleBackColor = false;
            this.editAccountButton.Click += new System.EventHandler(this.newUserButton_Click);
            // 
            // newTicketButton
            // 
            this.newTicketButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.newTicketButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.newTicketButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(72)))), ((int)(((byte)(98)))));
            this.newTicketButton.FlatAppearance.BorderSize = 0;
            this.newTicketButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newTicketButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.newTicketButton.Location = new System.Drawing.Point(6, 441);
            this.newTicketButton.Name = "newTicketButton";
            this.newTicketButton.Size = new System.Drawing.Size(191, 42);
            this.newTicketButton.TabIndex = 0;
            this.newTicketButton.Text = "New Ticket";
            this.newTicketButton.UseVisualStyleBackColor = false;
            this.newTicketButton.Click += new System.EventHandler(this.newTicketButton_Click);
            // 
            // showOnlyMyCheckBox
            // 
            this.showOnlyMyCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.showOnlyMyCheckBox.AutoSize = true;
            this.showOnlyMyCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.showOnlyMyCheckBox.Location = new System.Drawing.Point(12, 489);
            this.showOnlyMyCheckBox.Name = "showOnlyMyCheckBox";
            this.showOnlyMyCheckBox.Size = new System.Drawing.Size(178, 24);
            this.showOnlyMyCheckBox.TabIndex = 5;
            this.showOnlyMyCheckBox.Text = "Only show my Tickets";
            this.showOnlyMyCheckBox.UseVisualStyleBackColor = true;
            this.showOnlyMyCheckBox.CheckedChanged += new System.EventHandler(this.showOnlyMyCheckBox_CheckedChanged);
            // 
            // sortingComboBox
            // 
            this.sortingComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortingComboBox.FormattingEnabled = true;
            this.sortingComboBox.Location = new System.Drawing.Point(3, 519);
            this.sortingComboBox.Name = "sortingComboBox";
            this.sortingComboBox.Size = new System.Drawing.Size(194, 28);
            this.sortingComboBox.TabIndex = 6;
            this.sortingComboBox.SelectedIndexChanged += new System.EventHandler(this.sortingComboBox_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(939, 609);
            this.panel2.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tableLayoutPanel1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(203, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(736, 609);
            this.panel5.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.assignedflowLayoutPanel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.assingedLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.finishedLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.unassingedflowLayoutPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.finishedflowLayoutPanel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.unassingedLabel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.070796F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.92921F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(736, 609);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // assignedflowLayoutPanel
            // 
            this.assignedflowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.assignedflowLayoutPanel.AutoScroll = true;
            this.assignedflowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.assignedflowLayoutPanel.BackColor = System.Drawing.Color.Lavender;
            this.assignedflowLayoutPanel.Location = new System.Drawing.Point(248, 27);
            this.assignedflowLayoutPanel.Name = "assignedflowLayoutPanel";
            this.assignedflowLayoutPanel.Size = new System.Drawing.Size(239, 579);
            this.assignedflowLayoutPanel.TabIndex = 4;
            // 
            // assingedLabel
            // 
            this.assingedLabel.AutoSize = true;
            this.assingedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.assingedLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.assingedLabel.Location = new System.Drawing.Point(248, 0);
            this.assingedLabel.Name = "assingedLabel";
            this.assingedLabel.Size = new System.Drawing.Size(102, 20);
            this.assingedLabel.TabIndex = 6;
            this.assingedLabel.Text = "ASSIGNED";
            // 
            // finishedLabel
            // 
            this.finishedLabel.AutoSize = true;
            this.finishedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.finishedLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.finishedLabel.Location = new System.Drawing.Point(493, 0);
            this.finishedLabel.Name = "finishedLabel";
            this.finishedLabel.Size = new System.Drawing.Size(94, 20);
            this.finishedLabel.TabIndex = 0;
            this.finishedLabel.Text = "FINSIHED";
            // 
            // unassingedflowLayoutPanel
            // 
            this.unassingedflowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unassingedflowLayoutPanel.AutoScroll = true;
            this.unassingedflowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.unassingedflowLayoutPanel.BackColor = System.Drawing.Color.Lavender;
            this.unassingedflowLayoutPanel.Location = new System.Drawing.Point(3, 27);
            this.unassingedflowLayoutPanel.Name = "unassingedflowLayoutPanel";
            this.unassingedflowLayoutPanel.Size = new System.Drawing.Size(239, 579);
            this.unassingedflowLayoutPanel.TabIndex = 3;
            // 
            // finishedflowLayoutPanel
            // 
            this.finishedflowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.finishedflowLayoutPanel.AutoScroll = true;
            this.finishedflowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.finishedflowLayoutPanel.BackColor = System.Drawing.Color.Lavender;
            this.finishedflowLayoutPanel.Location = new System.Drawing.Point(493, 27);
            this.finishedflowLayoutPanel.Name = "finishedflowLayoutPanel";
            this.finishedflowLayoutPanel.Size = new System.Drawing.Size(240, 579);
            this.finishedflowLayoutPanel.TabIndex = 4;
            // 
            // unassingedLabel
            // 
            this.unassingedLabel.AutoSize = true;
            this.unassingedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.unassingedLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.unassingedLabel.Location = new System.Drawing.Point(3, 0);
            this.unassingedLabel.Name = "unassingedLabel";
            this.unassingedLabel.Size = new System.Drawing.Size(127, 20);
            this.unassingedLabel.TabIndex = 5;
            this.unassingedLabel.Text = "UNASSIGNED";
            this.unassingedLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TicketGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 769);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.header);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(950, 808);
            this.Name = "TicketGUI";
            this.Text = "MainPage";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.footer.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel footer;
        private System.Windows.Forms.Label pageTitle;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label allUserLabel;
        private System.Windows.Forms.ListBox userListBox;
        private System.Windows.Forms.Button editAccountButton;
        private System.Windows.Forms.Button newTicketButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label finishedLabel;
        private System.Windows.Forms.Label assingedLabel;
        private System.Windows.Forms.Label unassingedLabel;
        public System.Windows.Forms.FlowLayoutPanel finishedflowLayoutPanel;
        public System.Windows.Forms.FlowLayoutPanel assignedflowLayoutPanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.FlowLayoutPanel unassingedflowLayoutPanel;
        private System.Windows.Forms.CheckBox showOnlyMyCheckBox;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ComboBox sortingComboBox;
    }
}