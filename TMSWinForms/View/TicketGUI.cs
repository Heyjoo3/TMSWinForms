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
        }

   

        private void InitializeTaskTiles()
        {
            // Beispiel-Aufgaben hinzufügen
            AddTaskTile(unassingedflowLayoutPanel, "Task 1", "Person A", "21.12.12", "urgent");
            AddTaskTile(unassingedflowLayoutPanel, "Task 2", "Person B", "21.12.12", "urgent");
            AddTaskTile(unassingedflowLayoutPanel, "Task 3", "Person C", "21.12.12", "urgent");
            AddTaskTile(unassingedflowLayoutPanel, "Task 1", "Person A", "21.12.12", "urgent");
            AddTaskTile(unassingedflowLayoutPanel, "Task 2", "Person B", "21.12.12", "urgent");
            AddTaskTile(unassingedflowLayoutPanel, "Task 3", "Person C", "21.12.12", "urgent");

            AddTaskTile(assingedflowLayoutPanel, "Task 1", "Person A", "21.12.12", "urgent");
            AddTaskTile(assingedflowLayoutPanel, "Task 2", "Person B", "21.12.12", "urgent");
            AddTaskTile(assingedflowLayoutPanel, "Task 3", "Person C", "21.12.12", "urgent");

            AddTaskTile(finishedflowLayoutPanel, "Task 1", "Person A", "21.12.12", "urgent");
            AddTaskTile(finishedflowLayoutPanel, "Task 2", "Person B", "21.12.12", "urgent");
            AddTaskTile(finishedflowLayoutPanel, "Task 3", "Person C", "21.12.12", "urgent");
        }

        private void AddTaskTile(FlowLayoutPanel panel, string taskName, string assignedPerson, string date, string priority)
        {
            TicketTile ticketTile = new TicketTile(taskName, assignedPerson, date, priority );
            panel.Controls.Add(ticketTile);
        }

        private void newUserButton_Click(object sender, EventArgs e)
        {

        }
    }
}
