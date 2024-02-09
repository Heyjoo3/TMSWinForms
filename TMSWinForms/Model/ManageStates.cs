using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMSLibrary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace TMSWinForms.Model
{
    public class ManageStates
    {
        //fields 
        private UserModel loggedUser;
        private List<UserModel> allUsers;
        private List<TicketModel> allTickets;

        //properties
        public UserModel LoggedUser
        {
            get { return loggedUser; }
            set { loggedUser = value; }
        }

            public List<UserModel> AllUsers
        {
            get { return allUsers; }
            set { allUsers = value; }
        }

        public List<TicketModel> AllTickets
        {
            get { return allTickets; }
            set { allTickets = value; }
        }

        //constructor
        public ManageStates()
        {
            loggedUser = new UserModel();
            //allUsers = new List<UserModel>();
            //allTickets = new List<TicketModel>();
            allTickets = SqliteDataAccess.LoadTickets();
            allUsers = SqliteDataAccess.LoadUsers();
        }

        //methods
        public void UpdateAllUsers()
        {
            allUsers = SqliteDataAccess.LoadUsers();
        }

        public void UpdateAllTickets()
        {
            allTickets = SqliteDataAccess.LoadTickets();
        }

        public void UpdateAll()
        {
            UpdateAllUsers();
            UpdateAllTickets();
        }

        public TicketModel GetTicketById(int id)
        {
            foreach (TicketModel t in allTickets)
            {
                if (t.Id == id)
                {
                    return t;
                }
            }
            return null;
        }
    }
}
