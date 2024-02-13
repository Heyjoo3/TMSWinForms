namespace TMSWinForms.View
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using TMSWinForms.Model.Enumerations;
    using TMSLibrary;
    using DevExpress.XtraPrinting.Native;

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
            assignedUserComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            dateTimePicker.Value = DateTime.Parse(tempTicket.DueDate);
            descriptionTextBox.Text = tempTicket.Description;
            statusComboBox.Text = tempTicket.Status;
            statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            PriorityEnum priorityEnum = (PriorityEnum)tempTicket.Priority;
            string priorityString = priorityEnum.ToString();
            priorityComboBox.Text = priorityString;

            this.priorityComboBox.DataSource = Enum.GetValues(typeof(PriorityEnum));
            this.priorityComboBox.SelectedItem = priorityEnum;
            this.priorityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;


            List<UserModel> allUsers = Program.manageStates.AllUsers;

            this.assignedUserComboBox.DataSource = allUsers;
            this.assignedUserComboBox.DisplayMember = "Name";

            if (!string.IsNullOrEmpty(tempTicket.AssignedUserName))
            {
                this.assignedUserComboBox.Text = tempTicket.AssignedUserName;
            }
            else
            {
                this.assignedUserComboBox.SelectedItem = null;
            }
        }
        
        //methods
        private async void deleteButton_Click(object sender, EventArgs e)
        {
            await SqliteDataAccess.DeleteTicket(TicketID);
            Program.ticketForm.RefreshPanels();
            this.Close();
        }

        private async void editButton_Click(object sender, EventArgs e)
        {
            this.TicketID = ticketID;

            string title =  titleTextBox.Text.Trim();
            string assignedUser = assignedUserComboBox.Text.Trim();
            string date = dateTimePicker.Value.ToString("dd/MM/yyyy").Trim();
            int priority = (int)priorityComboBox.SelectedItem;
            string description = descriptionTextBox.Text.Trim();
            string status = statusComboBox.Text.Trim();

            if (status == "Unassigned" && assignedUser != "") 
            {                 
                status = "Assigned";
            }

            UserModel user = await SqliteDataAccess.GetUserByName(assignedUser);

            await SqliteDataAccess.UpdateTicket(new TicketModel(ticketID, title, description, status, priority, date, user.Id, assignedUser));

            await Program.manageStates.UpdateAll();

            Program.ticketForm.RefreshPanels();
            Program.ticketForm.RefreshUserList();

            this.Close();
        }
    }
}
