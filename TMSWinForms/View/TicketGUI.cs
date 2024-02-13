namespace TMSWinForms.View
{
    using DevExpress.Utils.MVVM;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using TMSLibrary;
    using TMSWinForms.Model.Enumerations;

    public partial class TicketGUI : Form
    {
        //fields
        private bool showOnlyMyTickets = false;
        private string sortBy = "";

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
        public TicketGUI()
        {
            InitializeComponent();
            InitializeTaskTiles();
            RefreshUserList();

            this.sortingComboBox.DataSource = Enum.GetValues(typeof(SortEnum));
            this.sortingComboBox.SelectedItem = SortEnum.Default; 
            this.sortingComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //methods
        public async void InitializeTaskTiles()
        {   
            await UpdateBySort();

            foreach (TicketModel ticket in Program.manageStates.AllTickets)
            {
                TicketTile ticketTile = new TicketTile(ticket.Title, ticket.AssignedUserName, ticket.DueDate, ticket.Priority, ticket.Id, ticket.Status.ToString());

                if (ticket.Status == StatusEnum.Unassigned.ToString())
                {
                    unassingedflowLayoutPanel.Controls.Add(ticketTile);
                }
                else if (ShowOnlyMyTickets && ticket.AssignedUserId != Program.manageStates.LoggedUser.Id)
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

        public void RefreshUserList()
        {
            userListBox.Items.Clear();
            List<UserModel> users = Program.manageStates.AllUsers;
            foreach (UserModel user in users)
            {
                userListBox.Items.Add(user.Name);
            }
        }

        private async void newUserButton_Click(object sender, EventArgs e)
        {
            EditUserForm editUserForm = new EditUserForm();
            editUserForm.ShowDialog();

            if (editUserForm.DialogResult == DialogResult.OK)
            {
                this.userListBox.Items.Clear();
                await Program.manageStates.UpdateAll();
                RefreshUserList();
                RefreshPanels();
            }
        }

        private void newTicketButton_Click(object sender, EventArgs e)
        {
            NewTicketForm newTicketForm = new NewTicketForm();
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
            await Program.manageStates.UpdateAll();
            RefreshPanels();
            RefreshUserList();
        }

        public void RefreshPanels()
        {
            unassingedflowLayoutPanel.Controls.Clear();
            assignedflowLayoutPanel.Controls.Clear();
            finishedflowLayoutPanel.Controls.Clear();
            InitializeTaskTiles();
        }

        private void sortingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.sortBy = sortingComboBox.SelectedItem.ToString();
            RefreshPanels(); 
        }

        private async Task UpdateBySort()
        {
            if (SortBy == SortEnum.Date.ToString())
            {
                await Program.manageStates.SortByDate();
            }
            else if (SortBy == SortEnum.Priority.ToString())
            {
                await Program.manageStates.SortByPriority();
            }
            else if (SortBy == SortEnum.Name.ToString())
            {
                await Program.manageStates.SortByName();
            }
            else if (SortBy == SortEnum.Title.ToString())
            {
                await Program.manageStates.SortByTitle();
            }
            else
            {
                await Program.manageStates.UpdateAllTickets();
            }
        }

        private void userListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Find user by name
            UserModel selectedUser = Program.manageStates.AllUsers.Find(user => user.Name == userListBox.SelectedItem.ToString());

            //Find tickets by user
            List<TicketModel> ticketsByUser = Program.manageStates.AllTickets.FindAll(ticket => ticket.AssignedUserId == selectedUser.Id);

            //Open UserDetailForm
            UserDetailsForm userDetailForm = new UserDetailsForm(selectedUser, ticketsByUser);
            userDetailForm.ShowDialog();

            if (userDetailForm.DialogResult == DialogResult.OK)
            {
                RefreshPanels();
                RefreshUserList();
            }
        }
    }
} 
