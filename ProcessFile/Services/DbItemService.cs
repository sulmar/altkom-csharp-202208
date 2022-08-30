using ProcessFile.IServices;
using Altkom.Models;
using Microsoft.Data.SqlClient;

namespace ProcessFile.Services
{
    public class DbItemService : IItemService
    {
        // snippet: ctor + 2 x Tab

        private SqlConnection sqlConnection;

        public DbItemService(SqlConnection sqlConnection)
        {
            this.sqlConnection = sqlConnection;
        }

        // https://github.com/sulmar/lazydev.pl/blob/master/content/posts/ado-net.md

        // ADO.NET / Dapper / Entity Framework (Core)

        public List<Item> Get()
        {
            // http://localhost/items?color=red;

            string color = "red";

            // SQL Injection!
            // string sql = "select * from dbo.Items WHERE Color = '" + color + "'";

            string sql = "select * from dbo.Items WHERE Color = @color";

            SqlCommand command = new SqlCommand(sql, sqlConnection);
            command.Parameters.AddWithValue("color", color);

            sqlConnection.Open();

            SqlDataReader reader = command.ExecuteReader();

            List<Item> items = new List<Item>();    

            while(reader.Read())
            {
                string name = (string) reader["Name"];
                decimal price = (decimal)reader["Price"];

                Item item = new Item(name, price);

                items.Add(item);
            }

            return items;

            
        }
    }
}
