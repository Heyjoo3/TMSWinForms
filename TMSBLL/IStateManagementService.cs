using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMSLibrary;

namespace TMSBLL
{
    public interface IStateManagementService
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

    
