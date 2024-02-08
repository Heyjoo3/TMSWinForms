namespace TMSWinForms.View
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using TMSLibrary;
    public partial class TicketTile : UserControl
    {
        public TicketTile()
        {
            InitializeComponent();
        }

        private int ticketID = 0;
        
        public int TicketID
        {
            get { return ticketID; }
            set { ticketID = value; }
        }

        public TicketTile(string taskName, string assignedPerson, string date, string priority, int ticketID, string status)
        {
            InitializeComponent();
            this.ticketTitleLabel.Text = taskName;
            this.dateLabel.Text = date;
            this.priorityLabel.Text = priority;
            this.TicketID = ticketID;
            this.ticketIDLabel.Text = ticketID.ToString();
            this.StatusComboBox.Text = status;
           
            List<UserModel> users = SqliteDataAccess.LoadUsers();
            this.assignedUserComboBox.DataSource = users;
            this.assignedUserComboBox.DisplayMember = "Name";

            if (assignedPerson != "")
            {
                this.assignedUserComboBox.Text = assignedPerson;
                this.assignedUserComboBox.SelectedItem = assignedPerson;
            }
            else
            {
                this.assignedUserComboBox.SelectedItem = null;
            }
        }


        private void changeStatusButton_Click(object sender, EventArgs e)
        {

            string status = this.StatusComboBox.Text;
            string currentStatus = Program.manageStates.GetTicketById(TicketID).Status;
            switch (status)
            {
                case "Unassigned":
                    if (assignedUserComboBox.Text.Trim() != "" && currentStatus == "Unassigned")
                    {
                        ChangeStatusAndAssignedUser("Assigned", assignedUserComboBox.Text);
                    }
                    else
                    {
                        ChangeStatusAndAssignedUser("Unassigned", "");
                    }
                    break;

                case "Assigned":
                    if (assignedUserComboBox.Text.Trim() != "")
                    {
                        ChangeStatusAndAssignedUser("Assigned", assignedUserComboBox.Text);
                    }
                    else
                    {
                        ChangeStatusAndAssignedUser("Unassigned", "");
                    }
                    break;

                case "Finished":
                        SqliteDataAccess.ChangeTicketStatus(TicketID, "Finished");
                    break;
            }

            Program.ticketForm.unassingedflowLayoutPanel.Controls.Clear();
            Program.ticketForm.assignedflowLayoutPanel.Controls.Clear();
            Program.ticketForm.finishedflowLayoutPanel.Controls.Clear();
            Program.ticketForm.InitializeTaskTiles();
        }


        private void detailsButton_Click(object sender, EventArgs e)
        {
            TicketDetailsForm ticketDetailsForm = new TicketDetailsForm(TicketID);  
            ticketDetailsForm.ShowDialog();
            
        }

        private void ChangeStatusAndAssignedUser(string status, string assignedUserName)

        {
            List<UserModel> allUsers= SqliteDataAccess.LoadUsers();
            
            foreach (UserModel user in allUsers)
            {
                if (user.Name == assignedUserName)
                {
                    SqliteDataAccess.ChangeTicketStatus(TicketID, status);
                    SqliteDataAccess.ChangeAssignedUser(TicketID, user.Id, assignedUserName);
                    return;
                }
                else
                {
                    SqliteDataAccess.ChangeTicketStatus(TicketID, status);
                    SqliteDataAccess.ChangeAssignedUser(TicketID, 0, "");
                }
            }
        }
    }
}
