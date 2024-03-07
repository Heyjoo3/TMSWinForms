namespace TMSWinForms.View
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using TMSBLL;
    using TMSBLL.Enumerations;
    using TMSLibrary;

    public partial class NewTicketForm : Form
    {
        private IDataAccess dataAccess;

        //constructor
        public NewTicketForm(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
            InitializeComponent();

            List<UserModel> users = TMSWinForms.Program.manageStates.AllUsers;

            //set up comboboxes
            this.assignedUserComboBox.DataSource = users;
            this.assignedUserComboBox.DisplayMember = "Name";
            this.assignedUserComboBox.ValueMember = "Name";
            this.assignedUserComboBox.SelectedItem = null;
            this.assignedUserComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            this.priorityComboBox.DataSource = Enum.GetValues(typeof(PriorityEnum));
            this.priorityComboBox.SelectedItem = PriorityEnum.Low;
            this.priorityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            
          
        }

        private async void saveNewTicketButton_Click(object sender, EventArgs e)
        {
            //get values from form and format them
            string title = this.titleTextBox.Text.Trim();
            string description = this.descriptionTextBox.Text.Trim();
            string assignedUserName = this.assignedUserComboBox.Text.Trim();
            string date = this.dateTimePicker.Value.ToString("dd/MM/yyyy");
            int priority = (int)this.priorityComboBox.SelectedItem;
 
                
                //check if title is empty
                if (title == "")
                {
                    MessageBox.Show("Every ticket needs a title.");
                }
                //new ticket
                else
                {
                    TicketModel newTicket = new TicketModel(title, description, priority,date,  assignedUserName, TMSWinForms.Program.manageStates.AllUsers);
                    await dataAccess.SaveTicket(newTicket);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
        }
    }
}
