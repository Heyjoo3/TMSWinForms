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

namespace TMSWinForms.View
{
    public partial class NewTicketForm : Form
    {
        public NewTicketForm()
        {
            InitializeComponent();
            this.assignedUserComboBox.DataSource = Program.userManager.Users;
            this.assignedUserComboBox.DisplayMember = "UserName";
            this.assignedUserComboBox.ValueMember = "UserName";
            this.assignedUserComboBox.SelectedItem = null;

            this.priorityComboBox.DataSource = Enum.GetValues(typeof(PriorityEnum));
            this.priorityComboBox.SelectedItem = PriorityEnum.Low ;

        }

        private void saveNewTicketButton_Click(object sender, EventArgs e)
        {

            string title = this.titleTextBox.Text.Trim();
            string description = this.descriptionTextBox.Text.Trim();
            string assignedUser = this.assignedUserComboBox.Text.Trim();
            string date = this.dateTimePicker.Value.ToString("dd/MM/yyyy");
 
            PriorityEnum priority = (PriorityEnum)this.priorityComboBox.SelectedItem;

                if (title == "")
                {
                    MessageBox.Show("Every ticket needs a title.");
                }
                else
                {
                    Ticket newTicket = new Ticket(assignedUser, title, description, priority, date);
                    Program.ticketManager.AddTicket(newTicket);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

        }
    }
}
