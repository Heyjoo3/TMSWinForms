namespace TMSWinForms.View
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using TMSLibrary;
    using TMSBLL;
    using TMSBLL.Enumerations;
    using TMSBLL.Interfaces;

    public partial class TicketGUI : Form
    {
        //fields
        private bool showOnlyMyTickets = false;
        private string sortBy = "";
        private IStateManagementService manageStates = TMSWinForms.Program.manageStates;
        //private ITicketGUI ticketGUIServices;


        //properties
        public bool ShowOnlyMyTickets
        {
            get { return showOnlyMyTickets; }
            set { showOnlyMyTickets = value; }
        }
        public string SortBy
        {
            get { return sortBy; }
            set { sortBy = value; }
        }

        //constructor
        //public TicketGUI(ITicketGUI ticketGUIServices)
        public TicketGUI()
        {
            //this.ticketGUIServices = ticketGUIServices;
            InitializeComponent();
            InitializeTaskTiles();
            RefreshUserList();

            this.sortingComboBox.DataSource = Enum.GetValues(typeof(SortEnum));
            this.sortingComboBox.SelectedItem = SortEnum.Default; 
            this.sortingComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //methods
        //initializes task tiles ordered by sortby and status
        public async void InitializeTaskTiles()
        {   
            await UpdateBySort();

            foreach (TicketModel ticket in manageStates.AllTickets)
            {
                TicketTile ticketTile = new TicketTile(ticket.Title, ticket.AssignedUserName, ticket.DueDate, ticket.Priority, ticket.Id, ticket.Status.ToString(), new SqliteDataAccess());

                if (ticket.Status == StatusEnum.Unassigned.ToString())
                {
                    unassingedflowLayoutPanel.Controls.Add(ticketTile);
                }
                else if (ShowOnlyMyTickets && ticket.AssignedUserId != manageStates.LoggedUser.Id)
                {
                    continue; // Skips
                }
                else if (ticket.Status == StatusEnum.Assigned.ToString())
                {
                    assignedflowLayoutPanel.Controls.Add(ticketTile);
                }
                else if (ticket.Status == StatusEnum.Finished.ToString())
                {
                    finishedflowLayoutPanel.Controls.Add(ticketTile);
                }
                else
                {
                    throw new Exception("Invalid status");
                }
            }
        }

        //Clears and refreshes panels
        public void RefreshPanels()
        {
            unassingedflowLayoutPanel.Controls.Clear();
            assignedflowLayoutPanel.Controls.Clear();
            finishedflowLayoutPanel.Controls.Clear();
            InitializeTaskTiles();
        }


        public void RefreshUserList()
        {
            userListBox.Items.Clear();
            List<UserModel> users = manageStates.AllUsers;
            foreach (UserModel user in users)
            {
                userListBox.Items.Add(user.Name);
            }
        }

        //sortes tickets by sortby property
        private async Task UpdateBySort()
        {
            if (SortBy == SortEnum.Date.ToString())
            {
                await manageStates.SortByDate();
            }
            else if (SortBy == SortEnum.Priority.ToString())
            {
                await manageStates.SortByPriority();
            }
            else if (SortBy == SortEnum.Name.ToString())
            {
                await manageStates.SortByName();
            }
            else if (SortBy == SortEnum.Title.ToString())
            {
                await manageStates.SortByTitle();
            }
            else
            {
                await manageStates.UpdateAllTickets();
            }
        }


        private async void newUserButton_Click(object sender, EventArgs e)
        {
            EditUserForm editUserForm = new EditUserForm(new SqliteDataAccess());
            editUserForm.ShowDialog();

            if (editUserForm.DialogResult == DialogResult.OK)
            {
                this.userListBox.Items.Clear();
                await manageStates.UpdateAll();
                RefreshUserList();
                RefreshPanels();
            }
        }

        private void newTicketButton_Click(object sender, EventArgs e)
        {
            NewTicketForm newTicketForm = new NewTicketForm(new SqliteDataAccess());
            newTicketForm.ShowDialog();
            if (newTicketForm.DialogResult == DialogResult.OK)
            {
                RefreshPanels();
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showOnlyMyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.ShowOnlyMyTickets = showOnlyMyCheckBox.Checked;
            RefreshPanels();
        }

        private async void refreshButton_Click(object sender, EventArgs e)
        {
            await TMSWinForms.Program.manageStates.UpdateAll();
            RefreshPanels();
            RefreshUserList();
        }

        //updates sortby property and refreshes panels
        private void sortingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SortBy = sortingComboBox.SelectedItem.ToString();
            RefreshPanels(); 
        }


        // opens user details form for admin
        private void userListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Program.manageStates.LoggedUser.Roll == "Admin")
            {
                //Find user by name
                UserModel selectedUser = manageStates.AllUsers.Find(user => user.Name == userListBox.SelectedItem.ToString());

                //Find tickets by user
                List<TicketModel> ticketsByUser = manageStates.AllTickets.FindAll(ticket => ticket.AssignedUserId == selectedUser.Id);

                //Open UserDetailForm
                UserDetailsForm userDetailForm = new UserDetailsForm(selectedUser, ticketsByUser, new SqliteDataAccess());
                userDetailForm.ShowDialog();

                if (userDetailForm.DialogResult == DialogResult.OK)
                {
                    RefreshPanels();
                    RefreshUserList();
                }
            }
           
        }
    }
} 
