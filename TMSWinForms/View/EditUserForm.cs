namespace TMSWinForms.View
{
    using System;
    using System.Windows.Forms;
    using TMSBLL;
    using TMSBLL.Interfaces;
    using TMSBLL.Services;
    using TMSLibrary;
    public partial class EditUserForm : Form
    {
        private IDataAccess dataAccess;

        //constructor
        public EditUserForm(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
            InitializeComponent();

            emailTextBox.Text = TMSWinForms.Program.manageStates.LoggedUser.Email;
            nameTextBox.Text = TMSWinForms.Program.manageStates.LoggedUser.Name;
            
        }


        //events
        private async void saveAccountEditButton_Click(object sender, EventArgs e)
        {
            //no password change
            if (passwordTextBox.Text == "" && repeatPasswordTextBox.Text == "")
            {
                TMSWinForms.Program.manageStates.LoggedUser.Email = emailTextBox.Text;
                TMSWinForms.Program.manageStates.LoggedUser.Name = nameTextBox.Text;

                await dataAccess.UpdateUser(TMSWinForms.Program.manageStates.LoggedUser);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            //password change
            else if (passwordTextBox.Text == repeatPasswordTextBox.Text && oldPasswordTextBox.Text == TMSWinForms.Program.manageStates.LoggedUser.Password)
            {
                //password is valid
                if (ManageLoginEvents.IsValidPassword(passwordTextBox.Text))
                {
                    TMSWinForms.Program.manageStates.LoggedUser.Email = emailTextBox.Text;
                    TMSWinForms.Program.manageStates.LoggedUser.Name = nameTextBox.Text;
                    TMSWinForms.Program.manageStates.LoggedUser.Password = passwordTextBox.Text;

                    await dataAccess.UpdateUser(TMSWinForms.Program.manageStates.LoggedUser);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                //password is not valid
                else
                {
                    MessageBox.Show("Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, one number and one special character");
                }
                
            }
            //passwords do not match
            else if (oldPasswordTextBox.Text != TMSWinForms.Program.manageStates.LoggedUser.Password)
            {
                MessageBox.Show("Old password is incorrect");
            }
            else
            {
                MessageBox.Show("Passwords do not match");
            } 
        }
        private async void deleteAccountButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete your account?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                await dataAccess.UpdateUnfinishedTicketsbyUserId(TMSWinForms.Program.manageStates.LoggedUser.Id);
                await dataAccess.DeleteUser(TMSWinForms.Program.manageStates.LoggedUser.Id);
                this.Close();
                Application.Exit();
            }
        }

        private void showPasswordButton_Click(object sender, EventArgs e)
        {
            if (this.oldPasswordTextBox.PasswordChar == '*')
            {
                this.oldPasswordTextBox.PasswordChar = '\0';
                this.passwordTextBox.PasswordChar =  '\0';
                this.repeatPasswordTextBox.PasswordChar = '\0';     
            }
            else
            {
                this.oldPasswordTextBox.PasswordChar = '*';
                this.passwordTextBox.PasswordChar = '*';
                this.repeatPasswordTextBox.PasswordChar = '*';
            }
        }
    }
}
