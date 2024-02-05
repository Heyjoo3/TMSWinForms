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
        public TicketGUI()
        {
            InitializeComponent();
            InitializeTaskTiles();
            AddUser();
        }

   

        private void InitializeTaskTiles()
        {
            // Beispiel-Aufgaben hinzufügen
            AddTicketTile(unassingedflowLayoutPanel, "Task 1", "Person A", "21.12.12", "urgent");
   
        }

        private void AddTicketTile(FlowLayoutPanel panel, string taskName, string assignedPerson, string date, string priority)
        {
            //TicketTile ticketTile = new TicketTile(taskName, assignedPerson, date, priority );
            //panel.Controls.Add(ticketTile);


            foreach (Ticket ticket in Program.ticketManager.Tickets)
            {
               TicketTile ticketTile = new TicketTile(ticket.TicketName, ticket.AssignedUser, ticket.TicketCreateDate, ticket.TicketPriority.ToString(), ticket.TicketID);
                panel.Controls.Add(ticketTile);
            }

           
        }

        private void AddUser()
        {
            userListBox.Items.Add("Lisa");
            userListBox.Items.Add("Lisa");
            userListBox.Items.Add("Lisa");
            userListBox.Items.Add("Lisa");
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
                InitializeTaskTiles();
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
