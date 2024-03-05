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

        //methods
        private async void InitializeData()
        {
            allTickets = await SqliteDataAccess.GetTicketsAndUserNames();
            allUsers = await SqliteDataAccess.LoadUsers();
        }

        public async Task UpdateAll()
        {
            await UpdateAllUsers();
            await UpdateAllTickets();
        }

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
            allTickets = await SqliteDataAccess.GetTicketsAndUserNames();

            for (int i = 0; i < allTickets.Count; i++)
            {
                for (int j = 0; j < allTickets.Count - 1; j++)
                {
                    if (DateTime.Parse(allTickets[j].DueDate) > DateTime.Parse(allTickets[j + 1].DueDate))
                    {
                        TicketModel temp = allTickets[j];
                        allTickets[j] = allTickets[j + 1];
                        allTickets[j + 1] = temp;
                    }
                }
            }

        }

        public async Task SortByName() {
            allTickets = await SqliteDataAccess.SortTicketsAndUserByName();
        }

        public async Task SortByTitle() {
            allTickets = await SqliteDataAccess.SortTicketsAndUserByTitle(); 
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
