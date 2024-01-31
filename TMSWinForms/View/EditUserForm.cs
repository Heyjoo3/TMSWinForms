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
    public partial class EditUserForm : Form
    {
        public EditUserForm()
        {
            InitializeComponent();
        }

        private void changePasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void saveAccountEditButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
