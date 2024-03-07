using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMSLibrary
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //Used for testing the database

            SqliteDataAccess db = new SqliteDataAccess();
            List<TicketModel> tickets = await db.LoadTickets();
            foreach (TicketModel t in tickets)
            {
                Console.WriteLine(t.Title);
            }

            List<UserModel> users = await db.LoadUsers();
            foreach (UserModel u in users)
            {
                Console.WriteLine(u.Name);
                Console.WriteLine(u.Email);
                Console.WriteLine(u.Password);
                Console.WriteLine(new string('-', 40));
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
