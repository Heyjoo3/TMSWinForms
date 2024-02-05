using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMSWinForms.Model
{
    internal class User
    {
        // fields
        private int userID;
        private string userName;
        private string userEmail;
        private string userPassword;
        private string userRoll;


        // properties
        
        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public string UserEmail
        {
            get { return userEmail; }
            set { userEmail = value; }
        }
        public string UserPassword
        {
            get { return userPassword; }
            set { userPassword = value; }
        }
        public string UserRoll
        {
            get { return userRoll; }
            set { userRoll = value; }
        }


        //Constructor

        public User()
        {
            userID = Program.userManager.UserID; ;
            userName = "";
            userEmail = "";
            userPassword = "";
            userRoll = "";
        }

        public User(string userName, string userEmail, string userPassword, string userRoll)
        {
            this.userID = Program.userManager.UserID;
            this.userName = userName;
            this.userEmail = userEmail;
            this.userPassword = userPassword;

            if (userRoll == "")
            {
                this.userRoll = "Admin";
            }
            else
            {
                this.userRoll = userRoll;
            }
            
        }


        //Methods

         public override string ToString()
        {
            return userName;
        }


    }
}
