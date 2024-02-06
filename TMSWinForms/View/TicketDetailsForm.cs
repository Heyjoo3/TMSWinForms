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
using TMSWinForms.Model.Enumerations;



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
            assignedUserComboBox.Text = tempTicket.AssignedUser;
            dateTimePicker.Value = DateTime.Parse(tempTicket.TicketDueDate);
            descriptionTextBox.Text = tempTicket.TicketDescription;


            statusComboBox.Text = tempTicket.TicketStatus.ToString();
            priorityComboBox.Text = tempTicket.TicketPriority.ToString();

            this.priorityComboBox.DataSource = Enum.GetValues(typeof(PriorityEnum));
            this.priorityComboBox.SelectedItem = tempTicket.TicketPriority;

            this.assignedUserComboBox.DataSource = Program.userManager.Users;
            this.assignedUserComboBox.DisplayMember = "UserName";
            this.assignedUserComboBox.ValueMember = "UserName";

            if (tempTicket.AssignedUser != "")
            {
                this.assignedUserComboBox.SelectedItem = tempTicket.AssignedUser;
            }
            else
            {
                this.assignedUserComboBox.SelectedItem = null;
            }
            

        }
        
        //methods
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
            this.TicketID = ticketID;

            string title =  titleTextBox.Text;
            string assignedUser = assignedUserComboBox.Text;
            string date = dateTimePicker.Value.ToString("dd/MM/yyyy");
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
