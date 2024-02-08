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
using TMSWinForms;
using TMSLibrary;

namespace TMSWinForms.View
{
    public partial class NewTicketForm : Form
    {
        public NewTicketForm()
        {
            InitializeComponent();
            //this.assignedUserComboBox.DataSource = Program.userManager.Users;
            //this.assignedUserComboBox.DisplayMember = "UserName";
            //this.assignedUserComboBox.ValueMember = "UserName";
            //this.assignedUserComboBox.SelectedItem = null;
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
 
            //PriorityEnum priority = (PriorityEnum)this.priorityComboBox.SelectedItem;

                if (title == "")
                {
                    MessageBox.Show("Every ticket needs a title.");
                }
                else
                {
                    //Ticket newTicket = new Ticket(assignedUser, title, description, priority, date);
                    //Program.ticketManager.AddTicket(newTicket);
                    //this.DialogResult = DialogResult.OK;
                    //this.Close();

                TicketModel newTicket = new TicketModel(title, description, priority,date,  assignedUserName);
                SqliteDataAccess.SaveTicket(newTicket);
                this.DialogResult = DialogResult.OK;
                this.Close();
                }

        }
    }
}
