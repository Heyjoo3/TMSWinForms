namespace TMSWinForms.View
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using TMSLibrary;
    using TMSBLL;
    using TMSBLL.Enumerations;

    public partial class TicketTile : UserControl
    {
        private IDataAccess dataAccess;
        private int ticketID = 0;
       
        public int TicketID
        {
            get { return ticketID; }
            set { ticketID = value; }
        }

        //constructor
        public TicketTile(string taskName, string assignedPerson, string date, int priority, int ticketID, string status, IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
            InitializeComponent();

            //fill form with ticket data and set up comboboxes
            this.ticketTitleLabel.Text = taskName;
            this.dateLabel.Text = date;
            this.assignedUserComboBox.MouseWheel += mouseWheelEvent;
            this.StatusComboBox.MouseWheel += mouseWheelEvent;

            PriorityEnum priorityEnum = (PriorityEnum)priority;
            string priorityString = priorityEnum.ToString();
            this.priorityLabel.Text = priorityString;

            this.TicketID = ticketID;
            this.ticketIDLabel.Text = ticketID.ToString();

            this.StatusComboBox.Text = status;
            this.StatusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            List<UserModel> users = TMSWinForms.Program.manageStates.AllUsers;
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

        //events
        private async void changeStatusButton_Click(object sender, EventArgs e)
        {
            string status = this.StatusComboBox.Text;
            string currentStatus = TMSWinForms.Program.manageStates.GetTicketById(TicketID).Status;

            //change status and assigned user
            switch (status)
            {
                case "Unassigned":
                    //unassigned and user --> assigned
                    if (assignedUserComboBox.Text.Trim() != "" && currentStatus == "Unassigned")
                    {
                        ChangeStatusAndAssignedUser("Assigned", assignedUserComboBox.Text);
                    }
                    //unassinged and no user --> unassigned
                    else
                    {
                        ChangeStatusAndAssignedUser("Unassigned", "");
                    }
                    break;

                case "Assigned":
                    //assigned and user --> assigned
                    if (assignedUserComboBox.Text.Trim() != "")
                    {
                        ChangeStatusAndAssignedUser("Assigned", assignedUserComboBox.Text);
                    }
                    //assigned and no user --> unassigned
                    else
                    {
                        ChangeStatusAndAssignedUser("Unassigned", "");
                    }
                    break;

                case "Finished":
                        await dataAccess.ChangeTicketStatus(TicketID, "Finished");
                    break;
            }
            TMSWinForms.Program.ticketForm.RefreshPanels();
        }

        //opens ticket details form for editing
        private void detailsButton_Click(object sender, EventArgs e)
        {
            TicketDetailsForm ticketDetailsForm = new TicketDetailsForm(TicketID, new SqliteDataAccess());  
            ticketDetailsForm.ShowDialog();
        }

        //prevent scrolling in comboboxes
        private void mouseWheelEvent(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }

        //methods
        private async void ChangeStatusAndAssignedUser(string status, string assignedUserName)
        {
            //List<UserModel> allUsers= await SqliteDataAccess.LoadUsers();
            List<UserModel> allUsers = TMSWinForms.Program.manageStates.AllUsers;

            foreach (UserModel user in allUsers)

            {
                //if user exists it gets assigned
                if (user.Name == assignedUserName)
                {
                    await dataAccess.ChangeTicketStatus(TicketID, status);
                    await dataAccess.ChangeAssignedUser(TicketID, user.Id, assignedUserName);
                    return;
                }
                //user does not exist
                else
                {
                    await dataAccess.ChangeTicketStatus(TicketID, status);
                    await dataAccess.ChangeAssignedUser(TicketID, 0, "");
                }
            }
        }
    }
}
