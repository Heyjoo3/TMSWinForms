using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMSLibrary;
using TMSBLL.Interfaces;



namespace TMSBLL
{
    public class ManageStates: IStateManagementService
    // implementation of the IStateManagementService interface
    // manages users
    // manages tickets, espeacially sorting 
    {
        //fields 
        private UserModel loggedUser;
        private List<UserModel> allUsers;
        private List<TicketModel> allTickets;
        private IDataAccess dataAccess;

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
        public ManageStates(IDataAccess dataAccess)
        {
            loggedUser = new UserModel();
            this.dataAccess = dataAccess;
            InitializeData();
        }

        //methods
        private async void InitializeData()
        {
            allTickets = await dataAccess.GetTicketsAndUserNames();
            allUsers = await dataAccess.LoadUsers();
        }

        public async Task UpdateAll()
        {
            await UpdateAllUsers();
            await UpdateAllTickets();
        }

        public async Task UpdateAllUsers()
        {
            allUsers = await dataAccess.LoadUsers();
        }

        public async Task UpdateAllTickets()
        {
            allTickets = await dataAccess.GetTicketsAndUserNames();
        }

        public async Task SortByPriority() {
            allTickets = await dataAccess.SortTicketsAndUserByPriority();
        }

        public async Task SortByDate() {        
            allTickets = await dataAccess.GetTicketsAndUserNames();

            //bubble sort by date because sql has no option to sort by date
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
            allTickets = await dataAccess.SortTicketsAndUserByName();
        }

        public async Task SortByTitle() {
            allTickets = await dataAccess.SortTicketsAndUserByTitle(); 
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
