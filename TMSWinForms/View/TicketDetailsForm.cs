﻿using System;
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
    public partial class TicketDetailsForm : Form
    {
        public TicketDetailsForm()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            EditTicketForm editTicketForm = new EditTicketForm();
            editTicketForm.ShowDialog();
        }
    }
}
