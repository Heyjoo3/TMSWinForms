namespace TMSWinForms.View
{
    using System;
    using System.Windows.Forms;
    using TMSLibrary;
    public partial class EditUserForm : Form
    {
        public EditUserForm()
        {
            InitializeComponent();

            emailTextBox.Text = Program.manageStates.LoggedUser.Email;
            nameTextBox.Text = Program.manageStates.LoggedUser.Name;
        }

        private void saveAccountEditButton_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "" && repeatPasswordTextBox.Text == "")
            {
                Program.manageStates.LoggedUser.Email = emailTextBox.Text;
                Program.manageStates.LoggedUser.Name = nameTextBox.Text;

                SqliteDataAccess.UpdateUser(Program.manageStates.LoggedUser);

                this.Close();
            }
            else if (passwordTextBox.Text == repeatPasswordTextBox.Text && oldPasswordTextBox.Text == Program.manageStates.LoggedUser.Password)
            {
                if (LoginReigsterGUI.IsValidPassword(passwordTextBox.Text))
                {
                    Program.manageStates.LoggedUser.Email = emailTextBox.Text;
                    Program.manageStates.LoggedUser.Name = nameTextBox.Text;
                    Program.manageStates.LoggedUser.Password = passwordTextBox.Text;

                    SqliteDataAccess.UpdateUser(Program.manageStates.LoggedUser);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, one number and one special character");
                }
                
            }
            else if (oldPasswordTextBox.Text != Program.manageStates.LoggedUser.Password)
            {
                MessageBox.Show("Old password is incorrect");
            }
            else
            {
                MessageBox.Show("Passwords do not match");
            } 
        }
        private void deleteAccountButton_Click(object sender, EventArgs e)
        {
            SqliteDataAccess.DeleteUser(Program.manageStates.LoggedUser.Id);
            this.Close();
            Application.Exit();

        }
    }
}
