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
    public partial class TicketGUI : Form
    {
        public TicketGUI()
        {
            InitializeComponent();
            InitializeTaskTiles();
            AddUser();
        }

   

        private void InitializeTaskTiles()
        {
            // Beispiel-Aufgaben hinzufügen
            AddTicketTile(unassingedflowLayoutPanel, "Task 1", "Person A", "21.12.12", "urgent");
            AddTicketTile(unassingedflowLayoutPanel, "Task 2", "Person B", "21.12.12", "urgent");
            AddTicketTile(unassingedflowLayoutPanel, "Task 3", "Person C", "21.12.12", "urgent");
            AddTicketTile(unassingedflowLayoutPanel, "Task 1", "Person A", "21.12.12", "urgent");
            AddTicketTile(unassingedflowLayoutPanel, "Task 2", "Person B", "21.12.12", "urgent");
            AddTicketTile(unassingedflowLayoutPanel, "Task 3", "Person C", "21.12.12", "urgent");

            AddTicketTile(assingedflowLayoutPanel, "Task 1", "Person A", "21.12.12", "urgent");
            AddTicketTile(assingedflowLayoutPanel, "Task 2", "Person B", "21.12.12", "urgent");
            AddTicketTile(assingedflowLayoutPanel, "Task 3", "Person C", "21.12.12", "urgent");

            AddTicketTile(finishedflowLayoutPanel, "Task 1", "Person A", "21.12.12", "urgent");
            AddTicketTile(finishedflowLayoutPanel, "Task 2", "Person B", "21.12.12", "urgent");
            AddTicketTile(finishedflowLayoutPanel, "Task 3", "Person C", "21.12.12", "urgent");
        }

        private void AddTicketTile(FlowLayoutPanel panel, string taskName, string assignedPerson, string date, string priority)
        {
            TicketTile ticketTile = new TicketTile(taskName, assignedPerson, date, priority );
            panel.Controls.Add(ticketTile);
        }

        private void AddUser()
        {
            userListBox.Items.Add("Lisa");
            userListBox.Items.Add("Lisa");
            userListBox.Items.Add("Lisa");
            userListBox.Items.Add("Lisa");

            userListBox.Items.Add("Lisa");
            userListBox.Items.Add("Lisa");
            userListBox.Items.Add("Lisa");
            userListBox.Items.Add("Lisa");
            userListBox.Items.Add("Lisa");
            userListBox.Items.Add("Lisa");
            userListBox.Items.Add("Lisa");
        }

        private void newUserButton_Click(object sender, EventArgs e)
        {
            EditUserForm editUserForm = new EditUserForm();
            editUserForm.ShowDialog();
        }

        private void newTicketButton_Click(object sender, EventArgs e)
        {
            NewTicketForm newTicketForm = new NewTicketForm();
            newTicketForm.ShowDialog();
        }
    }
}
