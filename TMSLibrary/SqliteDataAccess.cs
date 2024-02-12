namespace TMSLibrary
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Configuration;
    using System.Data;
    using System.Data.SQLite;
    using Dapper;
    using System.Threading.Tasks;

    public class SqliteDataAccess
    {
        //SQLite connection string
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        //User CRUD
        public static async Task<List<UserModel>> LoadUsers()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = await cnn.QueryAsync<UserModel>("select * from UserTable", new DynamicParameters());
                return output.ToList();
            }
        }

        public static async Task<bool> CheckUser(string email, string password)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = await cnn.QueryAsync<UserModel>("select * from UserTable where Email = @Email and Password = @Password", new { Email = email, Password = password });
                if (output.Count() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static async Task<UserModel> GetUser(string email, string password)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = await cnn.QueryFirstOrDefaultAsync<UserModel>("select * from UserTable where Email = @Email and Password = @Password", new { Email = email, Password = password });
                return output;
            }
        }

        public static async Task<bool> SaveUser(UserModel user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var existingUser = await cnn.QueryFirstOrDefaultAsync<UserModel>("select * from UserTable where Email = @Email", new { Email = user.Email });
                if (existingUser != null)
                {
                    //throw new Exception("Email already exists");
                    return false;
                }

                await cnn.ExecuteAsync("insert into UserTable (Name, Email, Password, Roll) values (@Name, @Email, @Password, @Roll)", user);
                return true;
            }
        }

        public static async Task UpdateUser(UserModel user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                await cnn.ExecuteAsync("update UserTable set Name = @Name, Email = @Email, Password = @Password, Roll = @Roll where Id = @Id", user);
            }
        }

        public static async Task DeleteUser(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                await cnn.ExecuteAsync("delete from UserTable where Id = @Id", new { Id = id });
            }
        }

        public static async Task<UserModel> GetUserByName (string name)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = await cnn.QueryFirstOrDefaultAsync<UserModel>("select * from UserTable where Name = @Name", new { Name = name });
                return output;
            }
        }

        //Ticket CRUD
        public static async Task<List<TicketModel>> LoadTickets()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = await cnn.QueryAsync<TicketModel>("select * from TicketTable", new DynamicParameters());
                return output.ToList();
            }
        }

        public static async Task SaveTicket(TicketModel ticket)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                await cnn.ExecuteAsync("insert into TicketTable (Title, Description, Status, Priority, DueDate, AssignedUserId, AssignedUserName) values (@Title, @Description, @Status, @Priority, @DueDate, @AssignedUserId, @AssignedUserName)", ticket);
            }
        }

        public static async Task UpdateTicket(TicketModel ticket)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                await cnn.ExecuteAsync("update TicketTable set Title = @Title, Description = @Description, Status = @Status, Priority = @Priority, DueDate = @DueDate, AssignedUserId = @AssignedUserId, AssignedUserName = @AssignedUserName where Id = @Id", ticket);
            }
        }

        public static async Task DeleteTicket(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                await cnn.ExecuteAsync("delete from TicketTable where Id = @Id", new { Id = id });
            }
        }

        public static async Task ChangeAssignedUser(int ticketId, int userId, string userName)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                await cnn.ExecuteAsync("update TicketTable set AssignedUserId = @AssignedUserId, AssignedUserName = @AssignedUserName where Id = @Id", new { AssignedUserId = userId, AssignedUserName = userName, Id = ticketId });
            }
        }

        public static async Task ChangeTicketStatus(int ticketId, string status)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                await cnn.ExecuteAsync("update TicketTable set Status = @Status where Id = @Id", new { Status = status, Id = ticketId });
            }
        }

        public static async Task UpdateUnfinishedTicketsbyUserId(int userId)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                await cnn.ExecuteAsync("update TicketTable set AssignedUserId = null, AssignedUserName = null where AssignedUserId = @UserId", new { UserId = userId });
            }
        }

        //Filter Queries

        public static async Task<List<TicketModel>> GetTicketsByUserId(int userId)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = await cnn.QueryAsync<TicketModel>("select * from TicketTable where AssignedUserId = @AssignedUserId", new { AssignedUserId = userId });
                return output.ToList();
            }
        }

        public static async Task<List<TicketModel>> GetTicketsByStatus(string status)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = await cnn.QueryAsync<TicketModel>("select * from TicketTable where Status = @Status", new { Status = status });
                return output.ToList();
            }
        }

        public static async Task<List<TicketModel>> GetTicketsByPriority(string priority)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = await cnn.QueryAsync<TicketModel>("select * from TicketTable where Priority = @Priority", new { Priority = priority });
                return output.ToList();
            }
        }

        //Sort Queries

        public static async Task<List<TicketModel>> SortTicketByPriority()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = await cnn.QueryAsync<TicketModel>("select * from TicketTable order by Priority", new DynamicParameters());
                return output.ToList();
            }
        }

        public static async Task<List<TicketModel>> SortTicketByDueDate()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = await cnn.QueryAsync<TicketModel>("select * from TicketTable order by DueDate", new DynamicParameters());
                return output.ToList();
            }
        }

        public static async Task<List<TicketModel>> SortTicketByStatus()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = await cnn.QueryAsync<TicketModel>("select * from TicketTable order by Status", new DynamicParameters());
                return output.ToList();
            }
        }

        //Join Queries

        public static async Task<List<TicketModel>> GetTicketsAndUserNames()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = await cnn.QueryAsync<TicketModel>("select TicketTable.Id, Title, Description, Status, Priority, DueDate, AssignedUserId, UserTable.Name as AssignedUserName from TicketTable left join UserTable on TicketTable.AssignedUserId = UserTable.Id", new DynamicParameters());
                return output.ToList();
            }
        }
    }
}
