using Microsoft.Data.SqlClient;
using System.Data;

namespace Retriever
{
    public class DbContext : ContextImpl
    {
        private SqlConnection _conn;

        public DbContext(string connectionString) : base(connectionString)
        {
        
        }

        public void Open()
        {
            _conn = new SqlConnection(_info);
            _conn.Open();
        }

        public void Close() 
        {
            _conn.Close();
        }

        public override void Delete(Item item)
        {
            var query = "DELETE Items WHERE Mobile = @mobile";
            using SqlCommand cmd = new(query, _conn);
            cmd.Parameters.AddWithValue("@mobile", item.Mobile);

            cmd.ExecuteNonQuery();
        }

        public override void Dispose()
        {
            _conn.Dispose();
        }

        public override IEnumerable<Item> GetAll()
        {
            var query = "SELECT * FROM Items";
            using SqlCommand cmd = new(query, _conn);

            using SqlDataReader dataReader = cmd.ExecuteReader();

            List<Item> people = [];
            while (dataReader.Read()) 
            {
                people.Add(
                    new Item()
                    {
                        Name = dataReader.GetString("name"),
                        Surname = dataReader.GetString("surname"),
                        Address = dataReader.GetString("address"),
                        City = dataReader.GetString("city"),
                        Mobile = dataReader.GetString("mobile"),
                        Email = dataReader.GetString("email")
                    });
            }

            return people;
        }

        public override Item? GetOne(int mobile)
        {
            string query = "SELECT * FROM Items Where mobile = @mobile";
            using SqlCommand cmd = new(query, _conn);
            cmd.Parameters.AddWithValue("@mobile", mobile);

            using SqlDataReader dataReader = cmd.ExecuteReader(CommandBehavior.SingleRow);

            if (dataReader.Read())
            {
                return new Item()
                {
                    Name = dataReader.GetString("name"),
                    Surname = dataReader.GetString("surname"),
                    Address = dataReader.GetString("address"),
                    City = dataReader.GetString("city"),
                    Mobile = dataReader.GetString("mobile"),
                    Email = dataReader.GetString("email")
                };
            }
            return null;
        }

        public override void Save(Item item)
        {
            var query = "INSERT INTO Items(name, surname, address, city, mobile, email) VALUES(@name, @surname, @address, @city, @mobile, @email)";
            using SqlCommand cmd = new(query, _conn);
            cmd.Parameters.AddRange([
                    new("@name", item.Name),
                    new("@surname", item.Surname),
                    new("@address", item.Address),
                    new("@city", item.City),
                    new("@mobile", item.Mobile),
                    new("@email", item.Email),
                ]);

            cmd.ExecuteNonQuery();
        }
    }
}
