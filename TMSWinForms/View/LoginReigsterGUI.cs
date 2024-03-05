namespace TMSWinForms.View
{
    using System;
    using System.Windows.Forms;
    using TMSLibrary;
    using TMSBLL.Interfaces;
    using Microsoft.Win32;


    public partial class LoginReigsterGUI : Form, ILoginRegisterGUI
    {
        private readonly IDataAccess dataAccess;

        public LoginReigsterGUI(IDataAccess dataAccess)
        {
            InitializeComponent();
            this.dataAccess = dataAccess;
        }

        //events
        public event Action<string, string> LoginRequested;
        public event Action<string, string, string, bool> RegisterRequested;


        //methods
        private void registerButton_Click(object sender, EventArgs e)
        {
           RegisterRequested?.Invoke(registerNameTextBox.Text.Trim(), registerEmailTextBox.Text.Trim(), registerPasswordTextBox.Text.Trim(), repeatPasswordTextBox.Text.Trim(), adminRollCheckBox.Checked);

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginRequested?.Invoke(loginEmailTextBox.Text, loginPasswordTextBox.Text);
 
        }

        private async void registerNameTextBox_TextChanged(object sender, EventArgs e)
        {
           if ( await dataAccess.GetUserByName(registerNameTextBox.Text.Trim()) != null)
            {
                this.registerNameTextBox.BackColor = System.Drawing.Color.LightSalmon;
            }
           else
            {
                this.registerNameTextBox.BackColor = System.Drawing.Color.LightGreen;
            }
        }






        // methods with no effect outside of the class
        public void ShowErrorMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void CloseView()
        {
            this.Close();
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

        private void showPasswordButton_Click(object sender, EventArgs e)
        {
            if (this.registerPasswordTextBox.PasswordChar == '*')
            {
                this.registerPasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                this.registerPasswordTextBox.PasswordChar = '*';
            }
        }

        private void showPasswordRepeatButton_Click(object sender, EventArgs e)
        {
            if (this.repeatPasswordTextBox.PasswordChar == '*')
            {
                this.repeatPasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                this.repeatPasswordTextBox.PasswordChar = '*';
            }
        }

        private void showLoginPasswordButton1_Click(object sender, EventArgs e)
        {

            if (this.loginPasswordTextBox.PasswordChar == '*')
            {
                this.loginPasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                this.loginPasswordTextBox.PasswordChar = '*';
            }
        }
    }
}
