namespace TMSWinForms.View
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using TMSWinForms.Model.Enumerations;
    using TMSLibrary;

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
            TicketModel tempTicket = Program.manageStates.GetTicketById(TicketID);

            titleTextBox.Text = tempTicket.Title;
            assignedUserComboBox.Text = tempTicket.AssignedUserName;
            dateTimePicker.Value = DateTime.Parse(tempTicket.DueDate);
            descriptionTextBox.Text = tempTicket.Description;
            statusComboBox.Text = tempTicket.Status;
            priorityComboBox.Text = tempTicket.Priority;

            this.priorityComboBox.DataSource = Enum.GetValues(typeof(PriorityEnum));
            this.priorityComboBox.SelectedItem = tempTicket.Priority;

            List<UserModel> allUsers = SqliteDataAccess.LoadUsers();

            this.assignedUserComboBox.DataSource = allUsers;
            this.assignedUserComboBox.DisplayMember = "Name";
            this.assignedUserComboBox.ValueMember = "Name";

            if (tempTicket.AssignedUserName != "")
            {
                this.assignedUserComboBox.SelectedItem = tempTicket.AssignedUserName;
                this.assignedUserComboBox.Text = tempTicket.AssignedUserName;
            }
            else
            {
                this.assignedUserComboBox.SelectedItem = null;
            }
        }
        
        //methods
        private void deleteButton_Click(object sender, EventArgs e)
        {
            SqliteDataAccess.DeleteTicket(TicketID);
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

            SqliteDataAccess.UpdateTicket(new TicketModel(ticketID, title, description, status, priority, date, 0, assignedUser));

            Program.ticketForm.unassingedflowLayoutPanel.Controls.Clear();
            Program.ticketForm.assignedflowLayoutPanel.Controls.Clear();
            Program.ticketForm.finishedflowLayoutPanel.Controls.Clear();
            Program.ticketForm.InitializeTaskTiles();

            this.Close();
        }
    }
}
