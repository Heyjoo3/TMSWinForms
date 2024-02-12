namespace TMSWinForms.View
{
    using DevExpress.Utils.MVVM;
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using TMSLibrary;
    using TMSWinForms.Model.Enumerations;
    using static DevExpress.Utils.Svg.CommonSvgImages;
    using static DevExpress.XtraEditors.Mask.MaskSettings;

    public partial class TicketGUI : Form
    {

        private bool showOnlyMyTickets = false;
        private string sortBy = "";

        public TicketGUI()
        {
            InitializeComponent();
            InitializeTaskTiles();
            RefreshUserList();

            this.sortingComboBox.DataSource = Enum.GetValues(typeof(SortEnum));
            this.sortingComboBox.DisplayMember = SortEnum.Default.ToString();
            this.sortingComboBox.SelectedItem = SortEnum.Default; 
        }

        public async void InitializeTaskTiles()
        { 
            if (sortBy == SortEnum.Date.ToString())
            {
                await Program.manageStates.SortByDate(); 
            }
            else if (sortBy == SortEnum.Priority.ToString())
            {
                await Program.manageStates.SortByPriority(); 
            }
            else if (sortBy == SortEnum.Name.ToString())
            {
                await Program.manageStates.SortByName(); 
            }
            else if (sortBy == SortEnum.Title.ToString())
            {
                await Program.manageStates.SortByTitle(); 
            }
            else
            {
                await Program.manageStates.UpdateAllTickets();
            }
            

            foreach (TicketModel ticket in Program.manageStates.AllTickets)
            {
                TicketTile ticketTile = new TicketTile(ticket.Title, ticket.AssignedUserName, ticket.DueDate, ticket.Priority.ToString(), ticket.Id, ticket.Status.ToString());

                if (ticket.Status == StatusEnum.Unassigned.ToString())
                {
                    unassingedflowLayoutPanel.Controls.Add(ticketTile);
                }
                else if (showOnlyMyTickets && ticket.AssignedUserId != Program.manageStates.LoggedUser.Id)
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
            this.userListBox.Items.Clear();
            await Program.manageStates.UpdateAll();
            RefreshUserList();
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
            this.showOnlyMyTickets = showOnlyMyCheckBox.Checked;
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
    }
} 
