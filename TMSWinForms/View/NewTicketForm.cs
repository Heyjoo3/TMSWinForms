namespace TMSWinForms.View
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using TMSWinForms.Model.Enumerations;
    using TMSLibrary;

    public partial class NewTicketForm : Form
    {
        public NewTicketForm()
        {
            InitializeComponent();

            List<UserModel> users = SqliteDataAccess.LoadUsers();

            this.assignedUserComboBox.DataSource =users;
            this.assignedUserComboBox.DisplayMember = "Name";
            this.assignedUserComboBox.ValueMember = "Name";

            this.priorityComboBox.DataSource = Enum.GetValues(typeof(PriorityEnum));
            this.priorityComboBox.SelectedItem = PriorityEnum.Low ;

        }

        private void saveNewTicketButton_Click(object sender, EventArgs e)
        {

            string title = this.titleTextBox.Text.Trim();
            string description = this.descriptionTextBox.Text.Trim();
            string assignedUserName = this.assignedUserComboBox.Text.Trim();
            string date = this.dateTimePicker.Value.ToString("dd/MM/yyyy");
            string priority = this.priorityComboBox.SelectedItem.ToString();
 

                if (title == "")
                {
                    MessageBox.Show("Every ticket needs a title.");
                }
                else
                {
                    TicketModel newTicket = new TicketModel(title, description, priority,date,  assignedUserName);
                    SqliteDataAccess.SaveTicket(newTicket);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
        }
    }
}
