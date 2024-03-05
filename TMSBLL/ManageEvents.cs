using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMSLibrary;
using TMSBLL.Interfaces;

namespace TMSBLL
{
    public class ManageEvents
    {
        private readonly IDataAccess dataAccess;
        private readonly ILoginRegisterGUI loginRegisterView;

        public ManageEvents(IDataAccess dataAccess, ILoginRegisterGUI loginRegisterView)
        {
            this.dataAccess = dataAccess;
            this.loginRegisterView = loginRegisterView;

            this.loginRegisterView.LoginRequested += HandleLoginRequested;
            this.loginRegisterView.RegisterRequested += HandleRegisterRequested;
        }

        private async void HandleLoginRequested(string email, string password)
        {
            if (email == "" || email == "")
            {
                loginRegisterView.ShowErrorMessage("Please fill out all fields");
            }
            else
            {
                if (await dataAccess.CheckUser(email, password))
                {
                    Program.manageStates.LoggedUser = await dataAccess.GetUser(email, password);
                    this.DialogResult = DialogResult.OK;
                    loginRegisterView.CloseView();
                }
                else
                {
                    loginRegisterView.ShowErrorMessage("Invalid Login! Please try again");
                }
            }
        }

        private async void HandleRegisterRequested(string name, string email, string password, string passwordRepeat, bool isAdmin)
        {
            if (name == "" || email == "" || password) == "" || passwordRepeat == "")
            {
                MessageBox.Show("Please fill out all fields");
            }
            else if (password != passwordRepeat)
            {
                MessageBox.Show("Passwords do not match");
            }
            else if (IsValidPassword(password)) == false)
            {
                MessageBox.Show("Password must contain at least 8 characters, a number, a capital letter, a small letter and a special sign");
            }
            else
            {
                UserModel user = new UserModel();
                user.Name = registerNameTextBox.Text.Trim();
                user.Email = registerEmailTextBox.Text.Trim();
                user.Password = registerPasswordTextBox.Text.Trim();
                user.Roll = adminRollCheckBox.Checked ? "Admin" : "User";


                if (await dataAccess.SaveUser(user))
                {
                    Program.manageStates.LoggedUser = user;
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }

                else
                {
                    MessageBox.Show("Email already exists");
                }
            }
        }
    }
}
