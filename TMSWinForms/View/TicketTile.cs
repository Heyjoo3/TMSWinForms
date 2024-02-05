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

        public TicketTile(string taskName, string assignedPerson, string date, string priority, int ticketID, string status)
        {
            InitializeComponent();
            this.ticketTitleLabel.Text = taskName;
            this.assignedUserLabel.Text = assignedPerson;
            this.dateLabel.Text = date;
            this.priorityLabel.Text = priority;
            this.TicketID = ticketID;
            this.ticketIDLabel.Text = ticketID.ToString();
            this.StatusComboBox.Text = status;
        }

        private void deleteTicketButton_Click(object sender, EventArgs e)
        {

        }

        private void changeStatusButton_Click(object sender, EventArgs e)
        {
            string status = this.StatusComboBox.Text;

            if (status == "Unassigned")
            {
                Program.ticketManager.ChangeStatus(TicketID, Model.Enumerations.StatusEnum.Unassigned);
            }
            else if (status == "Assigned")
            {
                Program.ticketManager.ChangeStatus(TicketID, Model.Enumerations.StatusEnum.Assigned);
            }
            else if (status == "Finished")
            {
                Program.ticketManager.ChangeStatus(TicketID, Model.Enumerations.StatusEnum.Finished);
            }

            Program.ticketForm.unassingedflowLayoutPanel.Controls.Clear();
            Program.ticketForm.assignedflowLayoutPanel.Controls.Clear();
            Program.ticketForm.finishedflowLayoutPanel.Controls.Clear();
            Program.ticketForm.InitializeTaskTiles();
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
