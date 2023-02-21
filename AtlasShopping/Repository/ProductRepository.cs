using AtlasShopping.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AtlasShopping.Repository
{
    class ProductRepository
    {
        private readonly string connectionString;

        public ProductRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["AtlasShoppingDBO"].ConnectionString;
        }

        private Product ReadNextProduct(SqlDataReader reader)
        {
            int id = reader.GetInt32(0);
            string name = reader.GetString(1);
            decimal price = reader.GetDecimal(2); // We can have type error here.
            string description = reader.GetString(3);
            string url = reader.GetString(4);
            string category = reader.GetString(5);

            return new Product(id, price, name, url, description, category);
        }

        public Product GetProduct(int id)
        {
            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            using SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT Id, Name, Price, Description, Url, Category " +
                                  "FROM Products " +
                                  "WHERE Id = @id;";

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            using SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
                return ReadNextProduct(reader);
            return null;
        }

        public List<Product> GetProducts()
        {
            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            using SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT Id, Name, Price, Description, Url, Category " +
                                  "FROM Products;";

            using SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();
            while (reader.Read())
                products.Add(ReadNextProduct(reader));

            return products;
        }
    }
}
