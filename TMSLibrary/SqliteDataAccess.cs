namespace TMSLibrary
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Configuration;
    using System.Data;
    using System.Data.SQLite;
    using Dapper;
    using System.Threading.Tasks;
    using System;


    public class SqliteDataAccess : IDataAccess
    {
        //SQLite connection string
        private static string LoadConnectionString(string id = "Default")
        {
            try
            {
               
                return ConfigurationManager.ConnectionStrings[id].ConnectionString;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while loading connection string: " + ex.Message);
                return null;
            }
            
        }



        //User CRUD
        public  async Task<List<UserModel>> LoadUsers()
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    Console.WriteLine("Connection string: " + LoadConnectionString());

                    var output = await cnn.QueryAsync<UserModel>("select * from UserTable", new DynamicParameters());
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                // Handle the exception here
                Console.WriteLine("An error occurred while loading users: " + ex.Message);
                Console.WriteLine("Fuck");
                
                return new List<UserModel>(); // Return an empty list or null, depending on your requirements
            }
        }

        public  async Task<bool> CheckUser(string email, string password)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                try
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
                catch (Exception ex)
                {
                    // Handle the exception here
                    Console.WriteLine("An error occurred while checking user: " + ex.Message);
                    return false; // Return an empty list or null, depending on your requirements
                }
            }
        }

        public  async Task<UserModel> GetUser(string email, string password)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    var output = await cnn.QueryFirstOrDefaultAsync<UserModel>("select * from UserTable where Email = @Email and Password = @Password", new { Email = email, Password = password });
                    return output;
                }
            }
            catch (Exception ex)
            {
                // Handle the exception here
                Console.WriteLine("An error occurred while getting user: " + ex.Message);
                return null; // Return an empty list or null, depending on your requirements
            }
        }

        public  async Task<bool> SaveUser(UserModel user)
        {   
            try
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
            catch (Exception ex)
            {
                // Handle the exception here
                Console.WriteLine("An error occurred while saving user: " + ex.Message);
                return false; // Return an empty list or null, depending on your requirements
            }
            
        }

        public  async Task UpdateUser(UserModel user)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    await cnn.ExecuteAsync("update UserTable set Name = @Name, Email = @Email, Password = @Password, Roll = @Roll where Id = @Id", user);
                }
            }
            catch (Exception ex)
            {
                // Handle the exception here
                Console.WriteLine("An error occurred while updating user: " + ex.Message);
            }
            
        }

        public  async Task DeleteUser(int id)
        {
            try {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    await cnn.ExecuteAsync("delete from UserTable where Id = @Id", new { Id = id });
                }
            }
            catch (Exception ex)
            {
                // Handle the exception here
                Console.WriteLine("An error occurred while deleting user: " + ex.Message);
            }
            
        }

        public  async Task<UserModel> GetUserByName (string name)
        {
            try {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    var output = await cnn.QueryFirstOrDefaultAsync<UserModel>("select * from UserTable where Name = @Name", new { Name = name });
                    return output;
                }
            }
            catch (Exception ex)
            {
                // Handle the exception here
                Console.WriteLine("An error occurred while getting user by name: " + ex.Message);
                return null; // Return an empty list or null, depending on your requirements
            }
            
        }



        //Ticket CRUD
        public  async Task<List<TicketModel>> LoadTickets()
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    var output = await cnn.QueryAsync<TicketModel>("select * from TicketTable", new DynamicParameters());
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                // Handle the exception here
                Console.WriteLine("An error occurred while loading tickets: " + ex.Message);
                return new List<TicketModel>(); // Return an empty list or null, depending on your requirements
            }
            
        }

        public  async Task SaveTicket(TicketModel ticket)
        {   
            try {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    await cnn.ExecuteAsync("insert into TicketTable (Title, Description, Status, Priority, DueDate, AssignedUserId, AssignedUserName) values (@Title, @Description, @Status, @Priority, @DueDate, @AssignedUserId, @AssignedUserName)", ticket);
                }
            }
            catch (Exception ex)
            {
                // Handle the exception here
                Console.WriteLine("An error occurred while saving ticket: " + ex.Message);
            }
            
        }

        public  async Task UpdateTicket(TicketModel ticket)
        {
            try {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    await cnn.ExecuteAsync("update TicketTable set Title = @Title, Description = @Description, Status = @Status, Priority = @Priority, DueDate = @DueDate, AssignedUserId = @AssignedUserId, AssignedUserName = @AssignedUserName where Id = @Id", ticket);
                }
            }
            catch (Exception ex)
            {
                // Handle the exception here
                Console.WriteLine("An error occurred while updating ticket: " + ex.Message);
            }
            
        }

        public async Task DeleteTicket(int id)
        {
            try {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    await cnn.ExecuteAsync("delete from TicketTable where Id = @Id", new { Id = id });
                }
            }
            catch (Exception ex)
            {
                // Handle the exception here
                Console.WriteLine("An error occurred while deleting ticket: " + ex.Message);
            }
            
        }

        public async Task ChangeAssignedUser(int ticketId, int userId, string userName)
        {
            try {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    await cnn.ExecuteAsync("update TicketTable set AssignedUserId = @AssignedUserId, AssignedUserName = @AssignedUserName where Id = @Id", new { AssignedUserId = userId, AssignedUserName = userName, Id = ticketId });
                }
            }
            catch (Exception ex)
            {
                // Handle the exception here
                Console.WriteLine("An error occurred while changing assigned user: " + ex.Message);
            }
            
        }

        public async Task ChangeTicketStatus(int ticketId, string status)
        {
            try {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    await cnn.ExecuteAsync("update TicketTable set Status = @Status where Id = @Id", new { Status = status, Id = ticketId });
                }
            } 
            catch (Exception ex)
            {
                // Handle the exception here
                Console.WriteLine("An error occurred while changing ticket status: " + ex.Message);
            }
            
        }

        public async Task UpdateUnfinishedTicketsbyUserId(int userId)
        {
            try {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    await cnn.ExecuteAsync("update TicketTable set AssignedUserId = null, AssignedUserName = null, Status = 'Unassigned' where AssignedUserId = @UserId and Status != 'Finished' ", new { UserId = userId });
                }
            }
            catch (Exception ex) {
                Console.WriteLine("An error occurred while updating finsihed tickets: " + ex.Message);
            }
            
        }



        //Join Queries

        public  async Task<List<TicketModel>> GetTicketsAndUserNames()
        {
            try {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    var output = await cnn.QueryAsync<TicketModel>("select TicketTable.Id, Title, Description, Status, Priority, DueDate, AssignedUserId, UserTable.Name as AssignedUserName from TicketTable left join UserTable on TicketTable.AssignedUserId = UserTable.Id", new DynamicParameters());
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                // Handle the exception here
                Console.WriteLine("An error occurred while getting tickets and user names: " + ex.Message);
                return new List<TicketModel>(); // Return an empty list or null, depending on your requirements
            }

            
        }

        public  async Task<List<TicketModel>> SortTicketsAndUserByPriority()
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    var output = await cnn.QueryAsync<TicketModel>("select TicketTable.Id, Title, Description, Status, Priority, DueDate, AssignedUserId, UserTable.Name as AssignedUserName from TicketTable left join UserTable on TicketTable.AssignedUserId = UserTable.Id order by Priority desc", new DynamicParameters());
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                // Handle the exception here
                Console.WriteLine("An error occurred while sorting tickets and user by priority: " + ex.Message);
                return new List<TicketModel>(); // Return an empty list or null, depending on your requirements
            }
        }

        public  async Task<List<TicketModel>> SortTicketsAndUserByName()
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    var output = await cnn.QueryAsync<TicketModel>("select TicketTable.Id, Title, Description, Status, Priority, DueDate, AssignedUserId, UserTable.Name as AssignedUserName from TicketTable left join UserTable on TicketTable.AssignedUserId = UserTable.Id order by Upper(UserTable.Name)", new DynamicParameters());
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                // Handle the exception here
                Console.WriteLine("An error occurred while sorting tickets and user by name: " + ex.Message);
                return new List<TicketModel>(); // Return an empty list or null, depending on your requirements
            }
            
        }

        public  async Task<List<TicketModel>> SortTicketsAndUserByTitle()
        {
            try {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    var output = await cnn.QueryAsync<TicketModel>("select TicketTable.Id, Title, Description, Status, Priority, DueDate, AssignedUserId, UserTable.Name as AssignedUserName from TicketTable left join UserTable on TicketTable.AssignedUserId = UserTable.Id order by Upper(Title)", new DynamicParameters());
                    return output.ToList();
                }
            }
            catch (Exception ex)
            {
                // Handle the exception here
                Console.WriteLine("An error occurred while sorting tickets and user by title: " + ex.Message);
                return new List<TicketModel>(); // Return an empty list or null, depending on your requirements
            }
            
        }
    }
}
