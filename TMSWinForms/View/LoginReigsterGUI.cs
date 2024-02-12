namespace TMSWinForms.View
{
    using System;
    using System.Windows.Forms;
    using TMSLibrary;
    public partial class LoginReigsterGUI : Form
    {
        public LoginReigsterGUI()
        {
            InitializeComponent();
        }

        private async void registerButton_Click(object sender, EventArgs e)
        {

            if (this.registerNameTextBox.Text.Trim() == "" || this.registerEmailTextBox.Text.Trim() == "" || this.registerPasswordTextBox.Text.Trim() == "" || this.repeatPasswordTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please fill out all fields");
            }
            else if (this.registerPasswordTextBox.Text.Trim() != this.repeatPasswordTextBox.Text.Trim())
            {
                MessageBox.Show("Passwords do not match");
            }
            else if (IsValidPassword(registerPasswordTextBox.Text.Trim()) == false)
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




                if (await SqliteDataAccess.SaveUser(user))
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


        private async void loginButton_Click(object sender, EventArgs e)
        {

            if (loginEmailTextBox.Text == "" || loginPasswordTextBox.Text == "")
            {
                MessageBox.Show("Please fill out all fields");
            }
            else
            {
                if (await SqliteDataAccess.CheckUser(loginEmailTextBox.Text, loginPasswordTextBox.Text))
                {
                    Program.manageStates.LoggedUser = await SqliteDataAccess.GetUser(loginEmailTextBox.Text, loginPasswordTextBox.Text);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Login! Please try again");
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

        private async void registerNameTextBox_TextChanged(object sender, EventArgs e)
        {
           if ( await SqliteDataAccess.GetUserByName(registerNameTextBox.Text.Trim()) != null)
            {
                this.registerNameTextBox.BackColor = System.Drawing.Color.LightSalmon;
            }
           else
            {
                this.registerNameTextBox.BackColor = System.Drawing.Color.LightGreen;
            }
        }
    }
}
