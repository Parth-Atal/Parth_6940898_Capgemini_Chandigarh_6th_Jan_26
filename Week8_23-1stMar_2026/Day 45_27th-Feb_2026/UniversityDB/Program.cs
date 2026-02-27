using System.Data;
using Microsoft.Data.SqlClient;

namespace ConnectToDatabase;

internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            string connectionString = "Data Source=LAPTOP-HI7ES7GE\\SQLEXPRESS; Initial Catalog=UniversityDataBase;TrustServerCertificate=True;Integrated Security=True";

            int DeptID = 1;
            GetDepartmentById(connectionString, DeptID);

            string DeptName = "Computer Science";
            CreateDepartment(connectionString, DeptName);

            DeptID = 3;
            DeptName = "Mathematics";
            UpdateDepartment(connectionString, DeptID, DeptName);

            DeptID = 3;
            DeleteDepartment(connectionString, DeptID);

            GetAllDepartments(connectionString);


        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        static void GetAllDepartments(string connectionString)
        {
            Console.WriteLine("GetAllDepartments stored procedure called");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("GetAllDepartments", connection);
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"DepartmentId: {reader["DeptId"]}, Department Name: {reader["DeptName"]}");
                }

                reader.Close();
                connection.Close();
            }
        }

        static void GetDepartmentById(string connectionString, int departmentId)
        {
            Console.WriteLine("GetDepartmentById stored procedure called");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("GetDepartmentByID", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@DeptID", departmentId);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"DeptID: {reader["DeptId"]}, DeptName: {reader["DeptName"]}");
                }

                reader.Close();
                connection.Close();
            }
        }

        static void CreateDepartment(string connectionString, string DeptName)
        {
            Console.WriteLine("CreateDepartment stored procedure called");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("CreateDepartment", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@DeptName", DeptName);
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine($"Rows affected: {rowsAffected}");
                connection.Close();
            }
        }

        static void UpdateDepartment(string connectionString, int departmentId, string departmentName)
        {
            Console.WriteLine("UpdateDepartment stored procedure called");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("UpdateDepartment", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@DeptID", departmentId);
                command.Parameters.AddWithValue("@DeptName", departmentName);
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine($"Rows affected: {rowsAffected}");
                connection.Close();
            }
        }

        static void DeleteDepartment(string connectionString, int departmentId)
        {
            Console.WriteLine("DeleteDepartment stored procedure called");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("DeleteDepartment", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@DeptID", departmentId);
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine($"Rows affected: {rowsAffected}");
                connection.Close();
            }
        }
    }
}