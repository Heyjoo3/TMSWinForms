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
            InitializeData();
        }

        private async void InitializeData()
        {
            allTickets = await SqliteDataAccess.GetTicketsAndUserNames();
            allUsers = await SqliteDataAccess.LoadUsers();
        }

        //methods
        public async Task UpdateAllUsers()
        {
            allUsers = await SqliteDataAccess.LoadUsers();
        }

        public async Task UpdateAllTickets()
        {
            allTickets = await SqliteDataAccess.GetTicketsAndUserNames();
        }

        public async Task SortByPriority() {
            allTickets = await SqliteDataAccess.SortTicketsAndUserByPriority();
        }

        public async Task SortByDate() {
            allTickets = await SqliteDataAccess.SortTicketsAndUserByDate();         
        }

        public async Task SortByName() {
            allTickets = await SqliteDataAccess.SortTicketsAndUserByName();
        }

        public async Task SortByTitle() {
            allTickets = await SqliteDataAccess.SortTicketsAndUserByTitle(); 
        }

        public async Task UpdateAll()
        {
            await UpdateAllUsers();
            await UpdateAllTickets();
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
