using System;
using TMSBLL.Interfaces;
using TMSLibrary;

namespace TMSBLL.Services
{
    public class ManageLoginEvents
    {
        private IDataAccess dataAccess;
        private ILoginRegisterGUI loginRegisterView;
        private IStateManagementService manageStates;

        public ManageLoginEvents(IDataAccess dataAccess, ILoginRegisterGUI loginRegisterView, IStateManagementService manageStates)
        {
            this.dataAccess = dataAccess;
            this.loginRegisterView = loginRegisterView;
            this.manageStates = manageStates;

            this.loginRegisterView.LoginRequested += HandleLoginRequested;
            this.loginRegisterView.RegistrationRequested += HandleRegisterRequested;
          
        }

        private async void HandleLoginRequested(string email, string password)
        {
            Console.WriteLine("Login requested");

            if (email == "" || email == "")
            {
                loginRegisterView.ShowErrorMessage("Please fill out all fields");
            }
            else
            {
                if (await dataAccess.CheckUser(email, password))
                {
                    
                    manageStates.LoggedUser = await dataAccess.GetUser(email, password);
                    loginRegisterView.DialogResult();
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
            Console.WriteLine("Register requested");

            if (name == "" || email == "" || password == "" || passwordRepeat == "")
            {
                loginRegisterView.ShowErrorMessage("Please fill out all fields");
            }
            else if (password != passwordRepeat)
            {
                loginRegisterView.ShowErrorMessage("Passwords do not match");
            }
            else if (IsValidPassword(password) == false)
            {
                loginRegisterView.ShowErrorMessage("Password must contain at least 8 characters, a number, a capital letter, a small letter and a special sign");
            }
            else
            {
                UserModel user = new UserModel();
                user.Name = name;
                user.Email = email;
                user.Password = password;
                user.Roll = isAdmin ? "Admin" : "User";


                if (await dataAccess.SaveUser(user))
                {
                    manageStates.LoggedUser = user;
                    loginRegisterView.DialogResult();
                    //loginRegisterView.DialogResult = DialogResult.OK;
                  
                    loginRegisterView.CloseView();

                }

                else
                {
                    loginRegisterView.ShowErrorMessage("Email already exists");
                }
            }
        }

        public static bool IsValidPassword(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }

            bool hasNumber = false;
            bool hasCapitalLetter = false;
            bool hasSmallLetter = false;
            bool hasSpecialSign = false;

            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    hasNumber = true;
                }
                else if (char.IsUpper(c))
                {
                    hasCapitalLetter = true;
                }
                else if (char.IsLower(c))
                {
                    hasSmallLetter = true;
                }
                else if (!char.IsLetterOrDigit(c))
                {
                    hasSpecialSign = true;
                }
            }

            return hasNumber && hasCapitalLetter && hasSmallLetter && hasSpecialSign;
        }
    }
}
