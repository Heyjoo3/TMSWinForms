using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMSLibrary;
using TMSWinForms;
using TMSWinForms.Model;
using TMSWinForms.Model.Enumerations;
//using TMSWinForms.Model.TicketManager ;

namespace TMSWinForms.View
{
    public partial class TicketGUI : Form
    {

        private bool showOnlyMyTickets = false;

        public TicketGUI()
        {
            InitializeComponent();
            InitializeTaskTiles();
            AddUser();
        }

        public void InitializeTaskTiles()
        {
            AddTicketTile();
        }

        private void AddTicketTile()
        {
            Program.manageStates.GetAllTickets();
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
           
            //foreach (Ticket ticket in Program.ticketManager.Tickets)
            //{
            //    TicketTile ticketTile = new TicketTile(ticket.TicketName, ticket.AssignedUser, ticket.TicketDueDate, ticket.TicketPriority.ToString(), ticket.TicketID, ticket.TicketStatus.ToString());
            //    if (ticket.TicketStatus == Model.Enumerations.StatusEnum.Unassigned)
            //    {
            //        unassingedflowLayoutPanel.Controls.Add(ticketTile);
            //    }
            //    else if (showOnlyMyTickets && ticket.AssignedUser != Program.userManager.CurrentUser.UserName)
            //    {
            //        continue; // Skips
            //    }
            //    else if (ticket.TicketStatus == Model.Enumerations.StatusEnum.Assigned)
            //    {
            //        assignedflowLayoutPanel.Controls.Add(ticketTile);
            //    }
            //    else if (ticket.TicketStatus == Model.Enumerations.StatusEnum.Finished)
            //    {
            //        finishedflowLayoutPanel.Controls.Add(ticketTile);
            //    }
            //    else
            //    {
            //        throw new Exception("Invalid status");
            //    }
            //}
        }

        private void AddUser()
        {

            List <UserModel> users = new List<UserModel>();

            users = SqliteDataAccess.LoadUsers();

            foreach (UserModel user in users)
            {
                userListBox.Items.Add(user.Name);
            }



            //foreach (User user in Program.userManager.Users)
            //{
            //    userListBox.Items.Add(user.UserName);
            //}
        }

        private void newUserButton_Click(object sender, EventArgs e)
        {
            EditUserForm editUserForm = new EditUserForm();
            editUserForm.ShowDialog();
        }

        private void newTicketButton_Click(object sender, EventArgs e)
        {
            NewTicketForm newTicketForm = new NewTicketForm();
            newTicketForm.ShowDialog();
            if (newTicketForm.DialogResult == DialogResult.OK)
            {
                unassingedflowLayoutPanel.Controls.Clear();
                assignedflowLayoutPanel.Controls.Clear();
                finishedflowLayoutPanel.Controls.Clear();
                InitializeTaskTiles();
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showOnlyMyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.showOnlyMyTickets = showOnlyMyCheckBox.Checked;
            unassingedflowLayoutPanel.Controls.Clear();
            assignedflowLayoutPanel.Controls.Clear();
            finishedflowLayoutPanel.Controls.Clear();
            InitializeTaskTiles();
        }
    }
}
