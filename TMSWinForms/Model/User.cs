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
        public string UserUserName
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
            userID = 0;
            userName = "";
            userEmail = "";
            userPassword = "";
            userRoll = "";
        }

        public User(int userID, string userName, string userEmail, string userPassword, string userRoll)
        {
            this.userID = userID;
            this.userName = userName;
            this.userEmail = userEmail;
            this.userPassword = userPassword;
            this.userRoll = userRoll;
        }


        //Methods

         public override string ToString()
        {
            return userName;
        }


    }
}
