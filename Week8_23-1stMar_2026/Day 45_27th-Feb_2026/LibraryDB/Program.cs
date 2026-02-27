using System.Data;
using Microsoft.Data.SqlClient;

namespace LibraryDB;

internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            string connectionString =
                "Data Source=LAPTOP-HI7ES7GE\\SQLEXPRESS; Initial Catalog=LibraryDB;TrustServerCertificate=True;Integrated Security=True";

            int bookId = 1;
            GetBookById(connectionString, bookId);

            CreateBook(connectionString, "C# Fundamentals", 101, 2024);

            bookId = 2;
            UpdateBook(connectionString, bookId, "Advanced C#", 102, 2025);

            bookId = 3;
            DeleteBook(connectionString, bookId);

            GetAllBooks(connectionString);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    // ===============================
    // 🔹 Get All Books (DISCONNECTED)
    // ===============================
    static void GetAllBooks(string connectionString)
    {
        Console.WriteLine("\nGetAllBooks stored procedure called");

        using SqlConnection connection = new SqlConnection(connectionString);
        using SqlDataAdapter adapter = new SqlDataAdapter("GetAllBooks", connection);

        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

        DataSet ds = new DataSet();
        adapter.Fill(ds, "Books");

        DataTable table = ds.Tables["Books"];

        foreach (DataRow row in table.Rows)
        {
            Console.WriteLine(
                $"BookId: {row["BookId"]}, Title: {row["Title"]}, AuthorId: {row["AuthorId"]}, Year: {row["PublishedYear"]}");
        }
    }

    // ===============================
    // 🔹 Get Book By Id
    // ===============================
    static void GetBookById(string connectionString, int bookId)
    {
        Console.WriteLine("\nGetBookById stored procedure called");

        using SqlConnection connection = new SqlConnection(connectionString);
        using SqlDataAdapter adapter = new SqlDataAdapter("GetBookByID", connection);

        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
        adapter.SelectCommand.Parameters.AddWithValue("@BookId", bookId);

        DataTable table = new DataTable();
        adapter.Fill(table);

        foreach (DataRow row in table.Rows)
        {
            Console.WriteLine(
                $"BookId: {row["BookId"]}, Title: {row["Title"]}, AuthorId: {row["AuthorId"]}, Year: {row["PublishedYear"]}");
        }
    }

    // ===============================
    // 🔹 Create Book
    // ===============================
    static void CreateBook(string connectionString, string title, int authorId, int year)
    {
        Console.WriteLine("\nCreateBook stored procedure called");

        using SqlConnection connection = new SqlConnection(connectionString);
        using SqlDataAdapter adapter = new SqlDataAdapter();

        adapter.InsertCommand = new SqlCommand("CreateBook", connection);
        adapter.InsertCommand.CommandType = CommandType.StoredProcedure;

        adapter.InsertCommand.Parameters.AddWithValue("@Title", title);
        adapter.InsertCommand.Parameters.AddWithValue("@AuthorId", authorId);
        adapter.InsertCommand.Parameters.AddWithValue("@PublishedYear", year);

        connection.Open();
        adapter.InsertCommand.ExecuteNonQuery();
    }

    // ===============================
    // 🔹 Update Book
    // ===============================
    static void UpdateBook(string connectionString, int bookId, string title, int authorId, int year)
    {
        Console.WriteLine("\nUpdateBook stored procedure called");

        using SqlConnection connection = new SqlConnection(connectionString);
        using SqlDataAdapter adapter = new SqlDataAdapter();

        adapter.UpdateCommand = new SqlCommand("UpdateBook", connection);
        adapter.UpdateCommand.CommandType = CommandType.StoredProcedure;

        adapter.UpdateCommand.Parameters.AddWithValue("@BookId", bookId);
        adapter.UpdateCommand.Parameters.AddWithValue("@Title", title);
        adapter.UpdateCommand.Parameters.AddWithValue("@AuthorId", authorId);
        adapter.UpdateCommand.Parameters.AddWithValue("@PublishedYear", year);

        connection.Open();
        adapter.UpdateCommand.ExecuteNonQuery();
    }

    // ===============================
    // 🔹 Delete Book
    // ===============================
    static void DeleteBook(string connectionString, int bookId)
    {
        Console.WriteLine("\nDeleteBook stored procedure called");

        using SqlConnection connection = new SqlConnection(connectionString);
        using SqlDataAdapter adapter = new SqlDataAdapter();

        adapter.DeleteCommand = new SqlCommand("DeleteBook", connection);
        adapter.DeleteCommand.CommandType = CommandType.StoredProcedure;

        adapter.DeleteCommand.Parameters.AddWithValue("@BookId", bookId);

        connection.Open();
        adapter.DeleteCommand.ExecuteNonQuery();
    }
}


