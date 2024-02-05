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
using TMSWinForms;



namespace TMSWinForms.View
{
    public partial class TicketDetailsForm : Form
    {   
        //fields
        private int ticketID = 0;


        //properties
        public int TicketID
        {
            get { return ticketID; }
            set { ticketID = value; }
        }   

        //constructor
        public TicketDetailsForm(int ticketID)
        {
            InitializeComponent();
            this.TicketID = ticketID;
            Ticket tempTicket = Program.ticketManager.GetTicketByID(ticketID);
            titleTextBox.Text = tempTicket.TicketName;
            assignedUserTextBox.Text = tempTicket.AssignedUser;
            dateTextBox.Text = tempTicket.TicketCreateDate;
            //priorityTextBox.Text = tempTicket.TicketPriority.ToString();
            descriptionTextBox.Text = tempTicket.TicketDescription;
            //statusTextBox.Text = tempTicket.TicketStatus.ToString();

            statusComboBox.Text = tempTicket.TicketStatus.ToString();
            priorityComboBox.Text = tempTicket.TicketPriority.ToString();

            this.assignedUserComboBox.DataSource = Program.userManager.Users;
            this.assignedUserComboBox.DisplayMember = "UserName";
            this.assignedUserComboBox.ValueMember = "UserName";

        }
        
        //methods
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GetTicketByID (int ticketID)
        {
            Ticket ticket = Program.ticketManager.GetTicketByID(ticketID);
            titleTextBox.Text = ticket.TicketName;
            assignedUserTextBox.Text = ticket.AssignedUser;
            dateTextBox.Text = ticket.TicketCreateDate;
            priorityComboBox.Text = ticket.TicketPriority.ToString();
            descriptionTextBox.Text = ticket.TicketDescription;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Program.ticketManager.DeleteTicket(ticketID);
            Program.ticketForm.unassingedflowLayoutPanel.Controls.Clear();
            Program.ticketForm.assignedflowLayoutPanel.Controls.Clear();
            Program.ticketForm.finishedflowLayoutPanel.Controls.Clear();
            Program.ticketForm.InitializeTaskTiles();
            this.Close();

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            //EditTicketForm editTicketForm = new EditTicketForm();
            //editTicketForm.ShowDialog();

            this.TicketID = ticketID;



            string title =  titleTextBox.Text;
            string assignedUser = assignedUserComboBox.Text;
            string date = dateTextBox.Text;
            string priority = priorityComboBox.Text;
            string description = descriptionTextBox.Text;
            string status = statusComboBox.Text;

            if (status == "Unassigned" && assignedUser != "") 
            {                 
                status = "Assigned";
            }
           
           

            Program.ticketManager.EditTicket(ticketID,title, description, status, priority, date, assignedUser);

           
            Program.ticketForm.unassingedflowLayoutPanel.Controls.Clear();
            Program.ticketForm.assignedflowLayoutPanel.Controls.Clear();
            Program.ticketForm.finishedflowLayoutPanel.Controls.Clear();
            Program.ticketForm.InitializeTaskTiles();

            

            this.Close();


        }

        
    }
}
