﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMSLibrary
{
    public class UserModel
    {
        // fields
        private int userID;
        private string userName;
        private string userEmail;
        private string userPassword;
        private string userRoll;

        // properties
        public int Id
        {
            get { return userID; }
            set { userID = value; }
        }   
        public string Name
        {
            get { return userName; }
            set { userName = value; }
        }
        public string Email
        {
            get { return userEmail; }
            set { userEmail = value; }
        }
        public string Password
        {
            get { return userPassword; }
            set { userPassword = value; }
        }

        public string Roll
        {
            get { return userRoll; }
            set { userRoll = value; }
        }
    }
}
