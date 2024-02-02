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

        // properties
        public List<User> Users
        {
            get { return users; }
            set { users = value; }
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
                    u.UserUserName = user.UserUserName;
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
                if (u.UserUserName == userName && u.UserPassword == password)
                {
                    return true;
                }
            }
            return false;
        }


    }
}
