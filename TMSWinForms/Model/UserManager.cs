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

        public void RemoveUser(User user)
        {
            users.Remove(user);
        }

        public void EditUser(User user)
        {
            foreach (User u in users)
            {
                if (u.UserID == user.UserID)
                {
                    u.UserName = user.UserName;
                    u.UserEmail = user.UserEmail;
                    u.UserPassword = user.UserPassword;
                    u.UserRoll = user.UserRoll;
                }
            }
        }

        public bool CheckLogin(string userName, string password)
        {
            foreach (User u in users)
            {
                if (u.UserName == userName && u.UserPassword == password)
                {
                    return true;
                }
            }
            return false;
        }


    }
}
