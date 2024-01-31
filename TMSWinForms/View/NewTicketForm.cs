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
    public partial class NewTicketForm : Form
    {
        public NewTicketForm()
        {
            InitializeComponent();
        }

        private void saveNewTicketButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
