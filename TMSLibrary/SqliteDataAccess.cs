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

        private static string LoadConnectionString(string id = "Default") 
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }


    }

}
