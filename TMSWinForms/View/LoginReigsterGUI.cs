﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMSLibrary;
using TMSWinForms.Model;

namespace TMSWinForms.View
{
    public partial class LoginReigsterGUI : Form
    {
        public LoginReigsterGUI()
        {
            InitializeComponent();
        }

        //private bool IsValidRegistration()
        //{
        //    if (registerEmailTextBox.Text == "" || registerPasswordTextBox.Text == "" || registerNameTextBox.Text == "" || repeatPasswordTextBox.Text == "")
        //    {
        //        return false;
        //    }
        //    else if (Program.userManager.Users.Exists(x => x.UserEmail == registerEmailTextBox.Text))
        //    {
        //        return false;
        //    }
        //    else if (registerPasswordTextBox.Text != repeatPasswordTextBox.Text)
        //    {
        //        return false;
        //    }
        //    else
        //    {

        //        User newUser; 
        //        if (adminRollCheckBox.Checked)
        //        {
        //             newUser = new User(registerNameTextBox.Text, registerEmailTextBox.Text, registerPasswordTextBox.Text, "Admin");
        //        } else
        //        {
        //             newUser = new User(registerNameTextBox.Text, registerEmailTextBox.Text, registerPasswordTextBox.Text, "User");
        //        }
                
        //        Program.userManager.AddUser(newUser);
        //        Program.userManager.CurrentUser = newUser;

        //        return true;
        //    }
            
        //}

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
            //if (IsValidRegistration())
            //{
            //    this.DialogResult = DialogResult.OK;
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Invalid Inputs. Please try again");
            //}
        }

        //private bool IsValidLogin()
        //{
        //    return true; // nur Dummy, muss noch ersetzt werden
        //}



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

            //if (Program.userManager.CheckLogin(loginEmailTextBox.Text,loginPasswordTextBox.Text ))
            //{   
            //    Program.userManager.CurrentUser = Program.userManager.Users.Find(x => x.UserEmail == loginEmailTextBox.Text);
            //    // Setzt  Dialogresultat auf OK, um anzuzeigen, dass die Anmeldung erfolgreich war
            //    this.DialogResult = DialogResult.OK;
            //    // Schließe das Anmeldeformular
            //    this.Close();
            //}

            //else if (IsValidLogin())
            //{
            //    this.DialogResult = DialogResult.OK;
            //    this.Close();
            //    Program.userManager.CurrentUser = Program.userManager.Users.Find(x => x.UserEmail == "email");
            //}

            //else
            //{
            //    MessageBox.Show("Invalid Login! Please try again");
            //}
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
