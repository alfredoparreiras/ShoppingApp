using AtlasShopping.Models;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chevalier.Utility.Authentication;
using System.Net.Http.Headers;

namespace AtlasShopping.Repository
{
    internal class UserRepository
    {
        private readonly string connectionString;

        public UserRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["AtlasShoppingDBO"].ConnectionString;
        }

        public bool UserExists(string username)
        {
            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            using SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT COUNT(Username) " +
                                  "FROM dbo.Users " +
                                  "WHERE Username = @username";

            command.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;

            int count = (int)command.ExecuteScalar();
            return count > 0;
        }

        public User GetUser(string username)
        {
            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open(); 

            using SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT Id, Username, Name, Email, Address, PasswordSalt, PasswordHash " +
                                  "FROM dbo.Users " +
                                  "WHERE Username = @username";

            command.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;

            using SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
                return ReadNextUser(reader);
            return null;


        }

        public User AddUser(User user)
        {
            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            using SqlCommand command = connection.CreateCommand();
            command.CommandText = "INSERT INTO dbo.Users " +
                                  "(Id, Username,Name, Email, Address, PasswordSalt,PasswordHash " +
                                  "VALUES " +
                                  "(@Id, @username, @name, @email, @address, @passwordSalt, @passwordHash)";

            command.Parameters.Add("@username", SqlDbType.NVarChar).Value = user.Username;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = user.Name;
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = user.Email;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = user.Address;
            command.Parameters.Add("@passwordSalt", SqlDbType.VarBinary).Value = user.Password.Salt;
            command.Parameters.Add("@passwordHash", SqlDbType.VarBinary).Value = user.Password.Hash;

            int id = (int)command.ExecuteScalar();
            return new User(id, user);

          
        }

        private User ReadNextUser(SqlDataReader reader)
        {
            int id = reader.GetInt32(0);
            string username = reader.GetString(1);
            string name = reader.GetString(2);
            string email = reader.GetString(3);
            string address = reader.GetString(4);
            byte[] salt = (byte[])reader.GetValue(5);
            byte[] hash = (byte[])reader.GetValue(6);

            HashedPassword password = new HashedPassword(salt, hash);

            return new User(id, username, name, email, address, password);
        }
    }
}
