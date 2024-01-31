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
    public partial class EditTicketForm : Form
    {
        public EditTicketForm()
        {
            InitializeComponent();
        }

        private void saveNewTicketButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
