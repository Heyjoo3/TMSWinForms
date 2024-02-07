using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using Dapper;


namespace TMSLibrary
{
    public class SqliteDataAccess
    {

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static List<UserModel> LoadUsers() 
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<UserModel>("select * from UserTable", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveUser(UserModel user) 
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into UserTable (Name, Email, Password, Roll) values (@Name, @Email, @Password, @Roll)", user);
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
                cnn.Execute("insert into TicketTable (Title, Description, Status, Priority, DueDate, AssignedUserID, AssignedUserName) values (@Title, @Description, @Status, @Priority, @DueDate, @AssignedUserID, @AssignedUserName)", ticket);
            }
        }

        public static void UpdateTicket(TicketModel ticket)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("update TicketTable set Title = @Title, Description = @Description, Status = @Status, Priority = @Priority, DueDate = @DueDate, AssignedUserID = @AssignedUserID, AssignedUserName = @AssignedUserName where Id = @Id", ticket);
            }
        }

        public static void DeleteTicket(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("delete from TicketTable where Id = @Id", new { Id = id });
            }
        }

        public static void AssignTicket(int ticketId, int userId, string userName)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("update TicketTable set AssignedUserID = @AssignedUserID, AssignedUserName = @AssignedUserName where Id = @Id", new { AssignedUserID = userId, AssignedUserName = userName, Id = ticketId });
            }
        }

        public static void ChangeTicketStatus(int ticketId, int status)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("update TicketTable set Status = @Status where Id = @Id", new { Status = status, Id = ticketId });
            }
        }
    }
}
