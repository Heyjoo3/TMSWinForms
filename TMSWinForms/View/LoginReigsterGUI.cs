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

        private void registerButton_Click(object sender, EventArgs e)
        {

            if (this.registerNameTextBox.Text == "" || this.registerEmailTextBox.Text == "" || this.registerPasswordTextBox.Text == "" || this.repeatPasswordTextBox.Text == "")
            {
                MessageBox.Show("Please fill out all fields");
            }
            else if (this.registerPasswordTextBox.Text != this.repeatPasswordTextBox.Text)
            {
                MessageBox.Show("Passwords do not match");
            }
            else if (IsValidPassword(registerPasswordTextBox.Text) == false)
            {
                MessageBox.Show("Password must contain at least 8 characters, a number, a capital letter, a small letter and a special sign");
            }
            else
            {
                UserModel user = new UserModel();
                user.Name = registerNameTextBox.Text;
                user.Email = registerEmailTextBox.Text;
                user.Password = registerPasswordTextBox.Text;
                user.Roll = adminRollCheckBox.Checked ? "Admin" : "User";


                if (SqliteDataAccess.SaveUser(user))
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


        private void loginButton_Click(object sender, EventArgs e)
        {

            if (loginEmailTextBox.Text == "" || loginPasswordTextBox.Text == "")
            {
                MessageBox.Show("Please fill out all fields");
            }
            else
            {
                if (SqliteDataAccess.CheckUser(loginEmailTextBox.Text, loginPasswordTextBox.Text))
                {
                    Program.manageStates.LoggedUser = SqliteDataAccess.GetUser(loginEmailTextBox.Text, loginPasswordTextBox.Text);
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
    }
}
