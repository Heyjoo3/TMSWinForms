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
        private IDataAccess dataAccess;
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

        //constructor
        public UserDetailsForm(UserModel selectedUser, List<TicketModel> selectedUserTickets, IDataAccess dataAccess)
        {

            this.dataAccess = dataAccess;
            InitializeComponent();

            //fill form with user data
            this.SelectedUser = selectedUser;
            this.SelectedUserTickets = selectedUserTickets;

            this.nameLabel.Text = SelectedUser.Name;
            this.emailLabel.Text = SelectedUser.Email;
            this.roleLabel.Text = SelectedUser.Roll;
            this.idLabel.Text = SelectedUser.Id.ToString();
            this.ticketAmountLabel.Text = SelectedUserTickets.Count.ToString();

            foreach (TicketModel ticket in SelectedUserTickets)
            {
                TicketTile ticketTile = new TicketTile(ticket.Title, ticket.AssignedUserName, ticket.DueDate, ticket.Priority, ticket.Id, ticket.Status.ToString(), new SqliteDataAccess());
                this.assignedTicketsflowLayoutPanel.Controls.Add(ticketTile);
            }

            
        }

        private async void deleteUserButton_Click(object sender, EventArgs e)
        {
            await dataAccess.UpdateUnfinishedTicketsbyUserId(SelectedUser.Id);
            await dataAccess.DeleteUser(SelectedUser.Id);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private async void resetPasswordButton_Click(object sender, EventArgs e)
        {
            selectedUser.Password = "12345678";
            await dataAccess.UpdateUser(selectedUser);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
