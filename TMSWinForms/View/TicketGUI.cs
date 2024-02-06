using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMSWinForms;
using TMSWinForms.Model;
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
            foreach (Ticket ticket in Program.ticketManager.Tickets)
            {
                

                TicketTile ticketTile = new TicketTile(ticket.TicketName, ticket.AssignedUser, ticket.TicketDueDate, ticket.TicketPriority.ToString(), ticket.TicketID, ticket.TicketStatus.ToString());

                if (ticket.TicketStatus == Model.Enumerations.StatusEnum.Unassigned)
                {
                    unassingedflowLayoutPanel.Controls.Add(ticketTile);
                }
                else if (showOnlyMyTickets && ticket.AssignedUser != Program.userManager.CurrentUser.UserName)
                {
                    continue; // Skips
                }
                else if (ticket.TicketStatus == Model.Enumerations.StatusEnum.Assigned)
                {
                    assignedflowLayoutPanel.Controls.Add(ticketTile);
                }
                else if (ticket.TicketStatus == Model.Enumerations.StatusEnum.Finished)
                {
                    finishedflowLayoutPanel.Controls.Add(ticketTile);
                }
                else
                {
                    throw new Exception("Invalid status");
                }
            }
        }

        private void AddUser()
        {

            foreach (User user in Program.userManager.Users)
            {
                userListBox.Items.Add(user.UserName);
            }
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
