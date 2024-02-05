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
            emailTextBox.Text = Program.userManager.CurrentUser.UserEmail;
            nameTextBox.Text = Program.userManager.CurrentUser.UserName;
        }

        private void changePasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void saveAccountEditButton_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "" && repeatPasswordTextBox.Text == "")
            {
                Program.userManager.CurrentUser.UserEmail = emailTextBox.Text;
                Program.userManager.CurrentUser.UserName = nameTextBox.Text;

                Program.userManager.RemoveUser(Program.userManager.CurrentUser.UserID);
                Program.userManager.AddUser(Program.userManager.CurrentUser);

                this.Close();
            }
            else if (passwordTextBox.Text == repeatPasswordTextBox.Text && oldPasswordTextBox.Text == Program.userManager.CurrentUser.UserPassword)
            {
                Program.userManager.CurrentUser.UserEmail = emailTextBox.Text;
                Program.userManager.CurrentUser.UserName = nameTextBox.Text;
                Program.userManager.CurrentUser.UserPassword = passwordTextBox.Text;

                Program.userManager.RemoveUser(Program.userManager.CurrentUser.UserID);
                Program.userManager.AddUser(Program.userManager.CurrentUser);
                
                this.Close();
            }
            else if (oldPasswordTextBox.Text != Program.userManager.CurrentUser.UserPassword)
            {
                MessageBox.Show("Old password is incorrect");
            }
            else
            {
                MessageBox.Show("Passwords do not match");
            }
            
            
            
        }
    }
}
