namespace TMSWinForms.View
{
    using System;
    using System.Windows.Forms;
    using TMSLibrary;
    using TMSBLL.Interfaces;
    using Microsoft.Win32;


    public partial class LoginReigsterGUI : Form, ILoginRegisterGUI
    {
        private IDataAccess dataAccess;

        public LoginReigsterGUI(IDataAccess dataAccess)
        {
            InitializeComponent();
            this.dataAccess = dataAccess;
        }

        //events
        public event Action<string, string> LoginRequested;
        public event Action<string, string, string, string, bool> RegistrationRequested;


        //methods to handle events
        private void registerButton_Click(object sender, EventArgs e)
        {
            RegistrationRequested?.Invoke(registerNameTextBox.Text, registerEmailTextBox.Text, registerPasswordTextBox.Text, repeatPasswordTextBox.Text, adminRollCheckBox.Checked);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginRequested?.Invoke(loginEmailTextBox.Text, loginPasswordTextBox.Text);
        }


        //TODO
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


        // other methods from interface
        public void ShowErrorMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void CloseView()
        {
            this.Close();
        }

        DialogResult ILoginRegisterGUI.DialogResult()
        {
            DialogResult = DialogResult.OK;
            return this.DialogResult;
        }


        //other methods - just for show/hide password

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
