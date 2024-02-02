using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMSWinForms.Model;
using TMSWinForms.Model.Enumerations;

namespace TMSWinForms.View
{
    public partial class NewTicketForm : Form
    {
        public NewTicketForm()
        {
            InitializeComponent();
        }

        private void saveNewTicketButton_Click(object sender, EventArgs e)
        {

            string title = this.titleTextBox.Text;
            string description = this.descriptionTextBox.Text;
            string assignedUser = this.assignedUserTextBox.Text;
            string date = this.dateTextBox.Text;
            int priority = int.Parse(this.priorityTextBox.Text);
            StatusEnum status = StatusEnum.Unassigned;
            bool  isAssigned = false;
            int ticketID = 0;
    

            if (title == "" || description == "" || assignedUser == "" || date == "" || !(priority == 1 || priority == 2 || priority == 3))
            {
                MessageBox.Show("Please fill in all fields correctly");
            }
            else
            {
                Ticket newTicket = new Ticket(ticketID, assignedUser, title, description, status, priority, date, isAssigned);

                ticketManger.AddTicket(newTicket);
                MessageBox.Show("New Ticket created");
            }

            

 

             
            
        }
    }
}
