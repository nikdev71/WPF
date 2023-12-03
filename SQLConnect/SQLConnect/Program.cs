// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Xml.Linq;

IConfigurationRoot config = new ConfigurationBuilder()
    .AddJsonFile("jsconfig1.json")
    .Build();

string? connectionStr = config.GetConnectionString("ConnectionString");

using(var connection = new SqlConnection(connectionStr))
{
    connection.Open();
    string query = "SELECT * FROM city";
    int id=0;
    using (var command = new SqlCommand(query, connection))
    {
       
        using (SqlDataReader reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                id = reader.GetInt32(0);
                //string name = reader.GetString(1);
                //Console.WriteLine($"ID: {id}, Name: { name}"); 
            }
        }
    }
        string query1 = "SET IDENTITY_INSERT city ON INSERT INTO city(ID,Name,CountryCode, District, Population) VALUES";
        for (int i = 1; i < 1000; i++)
        {
            Random r = new Random();
            query1 += "(" + id + i + ",";
            query1 += "\'test_" + r.Next(1, 1000).ToString() + "\',";
            query1 += "\'DZA\',";
            query1 += "\'dist_" + r.Next(1, 1000).ToString() + "\',";
            query1 += r.Next(1000, 10000) + "),";
        }
        query1 = query1.Remove(query1.Length - 1, 1);
        //Console.WriteLine(query1);

        using (var command = new SqlCommand(query1, connection))
        {
            command.ExecuteNonQuery();
            Console.WriteLine("Succes");
        }
    
}

