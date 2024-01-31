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
    public partial class LoginGUI : Form
    {
        public LoginGUI()
        {
            InitializeComponent();
        }

        private bool IsValidLogin()
        {
            return true; // nur Dummy, muss noch ersetzt werden
        }

        

        private void loginButton_Click(object sender, EventArgs e)
        {   
           

            if (IsValidLogin())
            {
                // Setzt  Dialogresultat auf OK, um anzuzeigen, dass die Anmeldung erfolgreich war
                this.DialogResult = DialogResult.OK;
                // Schließe das Anmeldeformular
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Login! Please try again");
            }
        }

        private void switchToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //RegisterGUI registerForm = new RegisterGUI();
            //registerForm.ShowDialog();

            this.DialogResult = DialogResult.Cancel;
            //this.Close();

        }


    }
}
