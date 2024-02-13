using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMSLibrary;

namespace TMSWinForms.View
{
    public partial class UserDetailsForm : Form
    {
        private UserModel selectedUser;
        private List<TicketModel> selectedUserTickets;

        public UserModel SelectedUser
        {
            get { return selectedUser; }
            set { selectedUser = value; }
        }

        public List<TicketModel> SelectedUserTickets
        {
            get { return selectedUserTickets; }
            set { selectedUserTickets = value; }
        }

        public UserDetailsForm(UserModel selectedUser, List<TicketModel> selectedUserTickets)
        {
            InitializeComponent();

            this.SelectedUser = selectedUser;
            this.SelectedUserTickets = selectedUserTickets;

            this.nameLabel.Text = SelectedUser.Name;
            this.emailLabel.Text = SelectedUser.Email;
            this.roleLabel.Text = SelectedUser.Roll;
            this.idLabel.Text = SelectedUser.Id.ToString();
            this.ticketAmountLabel.Text = SelectedUserTickets.Count.ToString();

            foreach (TicketModel ticket in SelectedUserTickets)
            {
                TicketTile ticketTile = new TicketTile(ticket.Title, ticket.AssignedUserName, ticket.DueDate, ticket.Priority, ticket.Id, ticket.Status.ToString());
                this.assignedTicketsflowLayoutPanel.Controls.Add(ticketTile);
            }
        }

        private async void deleteUserButton_Click(object sender, EventArgs e)
        {
            await SqliteDataAccess.UpdateUnfinishedTicketsbyUserId(SelectedUser.Id);
            await SqliteDataAccess.DeleteUser(SelectedUser.Id);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
