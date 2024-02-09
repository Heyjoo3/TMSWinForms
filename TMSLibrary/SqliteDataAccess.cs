namespace TMSLibrary
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Configuration;
    using System.Data;
    using System.Data.SQLite;
    using Dapper;

    public class SqliteDataAccess
    {
        //SQLite connection string
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        //User CRUD
        public static List<UserModel> LoadUsers() 
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<UserModel>("select * from UserTable", new DynamicParameters());
                return output.ToList();
            }
        }

        public static bool CheckUser(string email, string password)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<UserModel>("select * from UserTable where Email = @Email and Password = @Password", new { Email = email, Password = password });
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

        public static UserModel GetUser(string email, string password)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.QueryFirstOrDefault<UserModel>("select * from UserTable where Email = @Email and Password = @Password", new { Email = email, Password = password });
                return output;
            }
        }

        public static bool SaveUser(UserModel user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
           
                var existingUser = cnn.QueryFirstOrDefault<UserModel>("select * from UserTable where Email = @Email", new { Email = user.Email });
                if (existingUser != null)
                {
                    //throw new Exception("Email already exists");
                    return false;
                }

                cnn.Execute("insert into UserTable (Name, Email, Password, Roll) values (@Name, @Email, @Password, @Roll)", user);
                return true;
            }
        }

        public static void UpdateUser(UserModel user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("update UserTable set Name = @Name, Email = @Email, Password = @Password, Roll = @Roll where Id = @Id", user);
            }
        }

        public static void DeleteUser(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("delete from UserTable where Id = @Id", new { Id = id });
            }
        }

        //Ticket CRUD
        public static List<TicketModel> LoadTickets()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<TicketModel>("select * from TicketTable", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveTicket(TicketModel ticket)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into TicketTable (Title, Description, Status, Priority, DueDate, AssignedUserId, AssignedUserName) values (@Title, @Description, @Status, @Priority, @DueDate, @AssignedUserId, @AssignedUserName)", ticket);
            }
        }

        public static void UpdateTicket(TicketModel ticket)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("update TicketTable set Title = @Title, Description = @Description, Status = @Status, Priority = @Priority, DueDate = @DueDate, AssignedUserId = @AssignedUserId, AssignedUserName = @AssignedUserName where Id = @Id", ticket);
            }
        }

        public static void DeleteTicket(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("delete from TicketTable where Id = @Id", new { Id = id });
            }
        }

        public static void ChangeAssignedUser(int ticketId, int userId, string userName)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("update TicketTable set AssignedUserId = @AssignedUserId, AssignedUserName = @AssignedUserName where Id = @Id", new { AssignedUserId = userId, AssignedUserName = userName, Id = ticketId });
            }
        }

        public static void ChangeTicketStatus(int ticketId, string status)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("update TicketTable set Status = @Status where Id = @Id", new { Status = status, Id = ticketId });
            }
        }

        //Filter Queries

        public static List<TicketModel> GetTicketsByUserId(int userId)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<TicketModel>("select * from TicketTable where AssignedUserId = @AssignedUserId", new { AssignedUserId = userId });
                return output.ToList();
            }
        }

        public static List<TicketModel> GetTicketsByStatus(string status)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<TicketModel>("select * from TicketTable where Status = @Status", new { Status = status });
                return output.ToList();
            }
        }

        public static List<TicketModel> GetTicketsByPriority(string priority)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<TicketModel>("select * from TicketTable where Priority = @Priority", new { Priority = priority });
                return output.ToList();
            }
        }

        //Sort Queries

        public static List<TicketModel> SortTicketByPriority()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<TicketModel>("select * from TicketTable order by Priority", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<TicketModel> SortTicketByDueDate()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<TicketModel>("select * from TicketTable order by DueDate", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<TicketModel> SortTicketByStatus()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<TicketModel>("select * from TicketTable order by Status", new DynamicParameters());
                return output.ToList();
            }
        }

        //Join Queries

        public static List<TicketModel> GetTicketsAndUserNames()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<TicketModel>("select TicketTable.Id, Title, Description, Status, Priority, DueDate, AssignedUserId, UserTable.Name as AssignedUserName from TicketTable left join UserTable on TicketTable.AssignedUserId = UserTable.Id", new DynamicParameters());
                return output.ToList();
            }
        }
    }
}
