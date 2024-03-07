using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TMSLibrary
{
public interface IDataAccess
// describes the methods that the data access layer must implement
    {
        Task<List<UserModel>> LoadUsers();
        Task<bool> CheckUser(string email, string password);
        Task<UserModel> GetUser(string email, string password);
        Task<bool> SaveUser(UserModel user);
        Task UpdateUser(UserModel user);
        Task DeleteUser(int id);
        Task<UserModel> GetUserByName(string name);
        Task<List<TicketModel>> LoadTickets();
        Task SaveTicket(TicketModel ticket);
        Task UpdateTicket(TicketModel ticket);
        Task DeleteTicket(int id);
        Task ChangeAssignedUser(int ticketId, int userId, string userName);
        Task ChangeTicketStatus(int ticketId, string status);
        Task UpdateUnfinishedTicketsbyUserId(int userId);
        Task<List<TicketModel>> GetTicketsAndUserNames();
        Task<List<TicketModel>> SortTicketsAndUserByPriority();
        Task<List<TicketModel>> SortTicketsAndUserByName();
        Task<List<TicketModel>> SortTicketsAndUserByTitle();
    }
}

