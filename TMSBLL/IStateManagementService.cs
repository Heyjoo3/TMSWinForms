using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMSLibrary;

namespace TMSBLL
{
    public interface IStateManagementService
    // This interface is used to manage the state of the application.
    // It is used to store the current user and all the tickets in the system.
    // It is also used to sort the tickets by different criteria.
    {
        List<TicketModel> AllTickets { get; }
        List<UserModel> AllUsers { get; }
        UserModel LoggedUser { get; }
        Task UpdateAll();
        Task SortByDate();
        Task SortByPriority();
        Task SortByName();
        Task SortByTitle();
        Task UpdateAllTickets();
    }
}

    
