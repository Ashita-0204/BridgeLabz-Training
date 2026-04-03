using System;
using Microsoft.Data.SqlClient;
class StudentConnection
{
    public static void Main()
    {
        string connectionString = "Server=localhost\\SQLExpress;Database=CollegeeDB;Trusted_Connection=True;TrustServerCertificate=True;";
        string query = "SELECT * FROM Enrollments";
        using SqlConnection connection = new SqlConnection(connectionString);
        connection.Open();
        Console.WriteLine("Connection Established");
        SqlCommand command = new SqlCommand(query, connection);
        SqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            Console.WriteLine(reader["StudentID"] + "" + reader["Semester"]);
        }
        reader.Close();
        connection.Close();
    }
}