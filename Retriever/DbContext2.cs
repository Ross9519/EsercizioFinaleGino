using System.Data;
using Microsoft.Data.SqlClient;

namespace Retriever;

public class DbContext2 
{
    private readonly string _connectionString;
   

    public DbContext2(string connectionString)
    {
        _connectionString = connectionString;
    }


    public void Delete(Item item)
    {
        var query = "DELETE Items WHERE Mobile = @mobile";
        using var connection = new SqlConnection(_connectionString);
        using SqlCommand cmd = new(query, connection);
        cmd.Parameters.AddWithValue("@mobile", item.Mobile);

        cmd.ExecuteNonQuery();
    }


    public IEnumerable<Item> GetAll()
    {
        var query = "SELECT * FROM Items";
        using var connection = new SqlConnection(_connectionString);
        using SqlCommand cmd = new(query, connection);

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

    public Item? GetOne(int mobile)
    {
        string query = "SELECT * FROM Items Where mobile = @mobile";
        using var connection = new SqlConnection(_connectionString);
        using SqlCommand cmd = new(query, connection);
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

    public void Save(Item item)
    {
        var query = "INSERT INTO Items(name, surname, address, city, mobile, email) VALUES(@name, @surname, @address, @city, @mobile, @email)";
        using var connection = new SqlConnection(_connectionString);
        using SqlCommand cmd = new(query, connection);
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