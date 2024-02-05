using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMSWinForms.View
{
    public partial class TicketTile : UserControl
    {
        public TicketTile()
        {
            InitializeComponent();
        }

        private int ticketID = 0;
        
        public int TicketID
        {
            get { return ticketID; }
            set { ticketID = value; }
        }

        public TicketTile(string taskName, string assignedPerson, string date, string priority, int ticketID)
        {
            InitializeComponent();
            this.ticketTitleLabel.Text = taskName;
            this.assignedUserLabel.Text = assignedPerson;
            this.dateLabel.Text = date;
            this.priorityLabel.Text = priority;
            this.TicketID = ticketID;
            this.ticketIDLabel.Text = ticketID.ToString();
        }

        private void deleteTicketButton_Click(object sender, EventArgs e)
        {

        }

        private void changeStatusButton_Click(object sender, EventArgs e)
        {

        }

        private void editTicketButton_Click(object sender, EventArgs e)
        {
            EditTicketForm editTicketForm = new EditTicketForm();
            editTicketForm.ShowDialog();
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            TicketDetailsForm ticketDetailsForm = new TicketDetailsForm(TicketID);  
            ticketDetailsForm.ShowDialog();
            
        }

   
    }
}
