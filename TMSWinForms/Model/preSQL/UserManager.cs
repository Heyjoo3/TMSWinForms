using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMSWinForms.Model
{
    internal class UserManager
    {
        // fields
        List<User> users = new List<User>();
        private int userID = 0;
        User currentUser;


        // properties
        public List<User> Users
        {
            get { return users; }
            set { users = value; }
        }

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public User CurrentUser
        {
            get { return currentUser; }
            set { currentUser = value; }
        }

        // constructor
        public UserManager()
        {
            users = new List<User>();
        }

        // methods
        public void AddUser(User user)
        {
            users.Add(user);
            userID++;
        }

        public void RemoveUser(int userID)
        {
            foreach (User u in users)
            {
                if (u.UserID == userID)
                {
                    users.Remove(u);
                    break;
                }
            }
        }

        public void EditUser(int userID, string name, string email, string password, string userRoll)
        {
            foreach (User u in users)
            {
                if (u.UserID == userID)
                {
                    u.UserID = userID;
                    u.UserName = name;
                    u.UserEmail = email;
                    u.UserPassword = password;
                    u.UserRoll = userRoll;
                }
            }
        }



        public bool CheckLogin(string userEmail, string password)
        {
            foreach (User u in users)
            {
                if (u.UserEmail == userEmail && u.UserPassword == password)
                {
                    return true;
                }
            }
            return false;
        }

        public User GetUser (string userEmail)
        {
            foreach (User u in users)
            {
                if (u.UserEmail == userEmail)
                {
                    return u;
                }
            }
            return null;
        }


    }
}
