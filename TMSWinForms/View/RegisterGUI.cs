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
    public partial class RegisterGUI : Form
    {
        public RegisterGUI()
        {
            InitializeComponent();
        }

        

        private bool IsValidRegistration()
        {
            return true; // nur Dummy
        }

        private void registerButton_Click(object sender, EventArgs e)
        {

            if (IsValidRegistration())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Inputs. Preas ttry again");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //LoginGUI loginForm = new LoginGUI();
            //loginForm.ShowDialog();

            this.DialogResult = DialogResult.Cancel;
            //this.Close();
        }
    }
}
