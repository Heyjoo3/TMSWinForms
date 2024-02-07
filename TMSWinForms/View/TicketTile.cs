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
            this.dateLabel.Text = date;
            this.priorityLabel.Text = priority;
            this.TicketID = ticketID;
            this.ticketIDLabel.Text = ticketID.ToString();
            this.StatusComboBox.Text = status;


            this.assignedUserComboBox.DataSource = Program.userManager.Users;
            //this.assignedUserComboBox.ValueMember = "UserName";
            
            if (assignedPerson != "")
            {
                this.assignedUserComboBox.Text = assignedPerson;
            }
            else
            {
                this.assignedUserComboBox.SelectedItem = null;
            }
        }


        private void changeStatusButton_Click(object sender, EventArgs e)
        {

            string status = this.StatusComboBox.Text;
            string currentStatus = Program.ticketManager.GetTicketByID(TicketID).TicketStatus.ToString();
            switch (status)
            {
                case "Unassigned":
                    if (assignedUserComboBox.Text.Trim() != "" && currentStatus == "Unassigned")
                    {
                        ChangeStatusAndAssignedUser(Model.Enumerations.StatusEnum.Assigned, assignedUserComboBox.Text);
                    }
                    else
                    {
                        ChangeStatusAndAssignedUser(Model.Enumerations.StatusEnum.Unassigned, "");
                    }
                    break;

                case "Assigned":
                    if (assignedUserComboBox.Text.Trim() != "")
                    {
                        ChangeStatusAndAssignedUser(Model.Enumerations.StatusEnum.Assigned, assignedUserComboBox.Text);
                    }
                    else
                    {
                        ChangeStatusAndAssignedUser(Model.Enumerations.StatusEnum.Unassigned, "");
                    }
                    break;

                case "Finished":
                    Program.ticketManager.ChangeStatus(TicketID, Model.Enumerations.StatusEnum.Finished);
                    break;
            }

            Program.ticketForm.unassingedflowLayoutPanel.Controls.Clear();
            Program.ticketForm.assignedflowLayoutPanel.Controls.Clear();
            Program.ticketForm.finishedflowLayoutPanel.Controls.Clear();
            Program.ticketForm.InitializeTaskTiles();
        }


        private void detailsButton_Click(object sender, EventArgs e)
        {
            TicketDetailsForm ticketDetailsForm = new TicketDetailsForm(TicketID);  
            ticketDetailsForm.ShowDialog();
            
        }
        private void ChangeStatusAndAssignedUser(Model.Enumerations.StatusEnum status, string assignedUser)
        {
            Program.ticketManager.ChangeStatus(TicketID, status);
            Program.ticketManager.ChangeAssigendUser(TicketID, assignedUser);
        }
    }
}
