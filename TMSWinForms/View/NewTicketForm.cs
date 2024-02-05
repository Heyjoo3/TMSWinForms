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
        }

        private void saveNewTicketButton_Click(object sender, EventArgs e)
        {

            string title = this.titleTextBox.Text;
            string description = this.descriptionTextBox.Text;
            string assignedUser = this.assignedUserTextBox.Text;
            string date = this.dateTextBox.Text;
            string priorityString = this.priorityComboBox.Text.Substring(0,1);
  
            
            StatusEnum status = StatusEnum.Unassigned;
            

            if (!(priorityString == "1" || priorityString == "2" || priorityString == "3"))
            {
                MessageBox.Show("Please enter a valid priority. \n 1 = High \n 2 = Medium \n 3 = Low");
            }
            else
            {
                if (title == "" || description == "" || date == "")
                {
                    MessageBox.Show("Please fill in all fields correctly");
                }
                else
                {
                    int priority = int.Parse(priorityString);

                    Ticket newTicket = new Ticket(assignedUser, title, description, status, priority, date);
                    Program.ticketManager.AddTicket(newTicket);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
