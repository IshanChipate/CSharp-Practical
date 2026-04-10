using System;
using System.Data.SqlClient;

class AdoNetCrud
{
    static string connectionString =
    "Server=localhost\\SQLEXPRESS;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True;";

    static void Insert()
    {
        Console.Write("Enter Id: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Marks: ");
        double marks = Convert.ToDouble(Console.ReadLine());

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "INSERT INTO Students VALUES (@Id,@Name,@Marks)";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Marks", marks);

            con.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("Record inserted");
        }
    }

    static void View()
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "SELECT * FROM Students";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"{reader["Id"]} | {reader["Name"]} | {reader["Marks"]}");
            }
        }
    }

    static void Update()
    {
        Console.Write("Enter Id to update: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter new Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter new Marks: ");
        double marks = Convert.ToDouble(Console.ReadLine());

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "UPDATE Students SET Name=@Name, Marks=@Marks WHERE Id=@Id";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Marks", marks);

            con.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("Record updated");
        }
    }

    static void Delete()
    {
        Console.Write("Enter Id to delete: ");
        int id = Convert.ToInt32(Console.ReadLine());

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "DELETE FROM Students WHERE Id=@Id";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Id", id);

            con.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("Record deleted");
        }
    }

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n--- ADO.NET CRUD ---");
            Console.WriteLine("1. Insert");
            Console.WriteLine("2. View");
            Console.WriteLine("3. Update");
            Console.WriteLine("4. Delete");
            Console.WriteLine("0. Exit");
            Console.Write("Enter choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: Insert(); break;
                case 2: View(); break;
                case 3: Update(); break;
                case 4: Delete(); break;
            }

        } while (choice != 0);
    }
}