﻿namespace TMSWinForms.View
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using TMSLibrary;
    using TMSWinForms.Model.Enumerations;

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

        public TicketTile(string taskName, string assignedPerson, string date, int priority, int ticketID, string status)
        {
            InitializeComponent();
            this.ticketTitleLabel.Text = taskName;
            this.dateLabel.Text = date;

            PriorityEnum priorityEnum = (PriorityEnum)priority;
            string priorityString = priorityEnum.ToString();
            this.priorityLabel.Text = priorityString;

            this.TicketID = ticketID;
            this.ticketIDLabel.Text = ticketID.ToString();

            this.StatusComboBox.Text = status;
            this.StatusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            List<UserModel> users = Program.manageStates.AllUsers;
            this.assignedUserComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.assignedUserComboBox.DataSource = users;
            this.assignedUserComboBox.DisplayMember = "Name";

            if (!string.IsNullOrEmpty(assignedPerson))
            {
                this.assignedUserComboBox.Text = assignedPerson;
                this.assignedUserComboBox.SelectedItem = assignedPerson;
            }
            else
            {
                this.assignedUserComboBox.SelectedItem = null;
            }
        }


        private async void changeStatusButton_Click(object sender, EventArgs e)
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
                        await SqliteDataAccess.ChangeTicketStatus(TicketID, "Finished");
                    break;
            }
            Program.ticketForm.RefreshPanels();
        }


        private void detailsButton_Click(object sender, EventArgs e)
        {
            TicketDetailsForm ticketDetailsForm = new TicketDetailsForm(TicketID);  
            ticketDetailsForm.ShowDialog();
        }

        private async void ChangeStatusAndAssignedUser(string status, string assignedUserName)
        {
            //List<UserModel> allUsers= await SqliteDataAccess.LoadUsers();
            List<UserModel> allUsers = Program.manageStates.AllUsers;
            
            foreach (UserModel user in allUsers)
            {
                if (user.Name == assignedUserName)
                {
                    await SqliteDataAccess.ChangeTicketStatus(TicketID, status);
                    await SqliteDataAccess.ChangeAssignedUser(TicketID, user.Id, assignedUserName);
                    return;
                }
                else
                {
                    await SqliteDataAccess.ChangeTicketStatus(TicketID, status);
                    await SqliteDataAccess.ChangeAssignedUser(TicketID, 0, "");
                }
            }
        }
    }
}
