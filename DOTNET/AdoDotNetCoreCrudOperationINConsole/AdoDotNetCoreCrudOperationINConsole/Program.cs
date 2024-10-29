using System.Data;
using Microsoft.Data.SqlClient;
//using System.Data.SqlClient;
using System.IO;
using System.Runtime.InteropServices;

namespace AdoDotNetCoreCrudOperationINConsole
{
    internal class Program
    {
        private static object employeeId;

        static void Main(string[] args)
        {
            try
            {

                //string connectionString = "Server = HP\\HEMA;Database = EmployeeDB;User" +
                //    " Id = sa;Password=user123;Trusted_Connection=True;" +
                //    "TrustServerCertificate = True;";

                string connectionString = "Server = HP\\HEMA; Database = EmployeeDB ; User Id = sa; Password = user123; Trusted_Connection = True; TrustServerCertificate = True;";

                GetAllEmployees(connectionString);

                int EmployeeId = Convert.ToInt32(Console.ReadLine());

                GetEmployeeByID(connectionString, EmployeeId);

                string firstName = Console.ReadLine();
                string lastName = Console.ReadLine();
                string email = Console.ReadLine();
                string street = Console.ReadLine();
                string city = Console.ReadLine();
                string state = Console.ReadLine();
                string PostalCode = Console.ReadLine();



                CreateEmployeeWithAddress(connectionString, firstName, lastName, email, street, city, state, PostalCode);

                int employeeID = Convert.ToInt32(Console.ReadLine()); 
                firstName = Console.ReadLine();
                lastName = Console.ReadLine();
                email = Console.ReadLine();
                street = Console.ReadLine(); 
                city = Console.ReadLine();
                state = Console.ReadLine();
                PostalCode = Console.ReadLine();
                int AddressID = Convert.ToInt32(Console.ReadLine());

                UpdateEmployeeWithAddress(connectionString, employeeID, firstName, lastName, email, street, city, state, PostalCode, AddressID);

                employeeID = Convert.ToInt32(Console.ReadLine());
                DeleteEmployee(connectionString, employeeID);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong:{ex.Message}");

            }
        }

        //Console.WriteLine("Connection Successfull");

        static void GetAllEmployees(string connectionString)
        {
            Console.WriteLine("Get AllEmployees Stored Procedure called");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("GetAllEmployees", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"EmployeeId:{reader["EmployeeID"]},FirstName:{reader["FirstName"]},LastName: {reader["LastName"]}),Email: {reader["Email"]} ");

                    Console.WriteLine($"Addresses:{reader["Street"]},{reader["City"]},{reader["States"]},PostalCode:{reader["PostalCode"]}\n");
                }
                reader.Close();

            }
        }
        static void GetEmployeeByID(string connectionString, int employeeID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("GetEmployeeByID Stored Procedure Called");
                SqlCommand command = new SqlCommand("GetEmployeeByID", connection);
                command.CommandType = CommandType.StoredProcedure;

                // Add parameter for EmployeelD
                command.Parameters.AddWithValue("@EmployeeID", employeeID);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"Employee: {reader["FirstName"]}, {reader["LastName"]}, Email: {reader["Email"]}");
                    Console.WriteLine($"Address: {reader["Street"]}, {reader["City"]}, {reader["States"]}, {reader["PostalCode"]}");
                }
                reader.Close();
                connection.Close();
            }
        }
        static void CreateEmployeeWithAddress(string connectionString, string firstName, string lastName, string email, string street, string city, string state, string postalCode)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("Create EmployeeWithAddress Stored Procedure Called");
                SqlCommand command = new SqlCommand("CreateEmployeeWithAddress", connection);
                command.CommandType = CommandType.StoredProcedure;
                // Add parameters for Employee and Address

                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Street", street);
                command.Parameters.AddWithValue("@City", city);
                command.Parameters.AddWithValue("@States", state);
                command.Parameters.AddWithValue("@PostalCode", postalCode);
                connection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Employee and Address created successfully.");
                connection.Close();
            }
        }
        static void UpdateEmployeeWithAddress(string connectionString, int employeeID, string firstName, string lastName, string email, string street, string city, string state, string postalCode, int addressID)

        { 
        using (SqlConnection connection = new SqlConnection(connectionString))
         {
         Console.WriteLine("Update Employee WithAddress Stored Procedure Called");
         SqlCommand command = new SqlCommand("UpdateEmployeeWithAddress",connection);
          command.CommandType = CommandType.StoredProcedure;
        // Add parameters for Employee and Address
         command.Parameters.AddWithValue("@EmployeeID", employeeID);
         command.Parameters.AddWithValue("@FirstName", firstName);
         command.Parameters.AddWithValue("@LastName", lastName);
         command.Parameters.AddWithValue("@Email", email);
         command.Parameters.AddWithValue("@Street", street);
         command.Parameters.AddWithValue("@City", city);
         command.Parameters.AddWithValue("@States", state);
         command.Parameters.AddWithValue("@PostalCode", postalCode);
         command.Parameters.AddWithValue("@AddressID", addressID);
         connection.Open();
         command.ExecuteNonQuery();
         Console.WriteLine("Employee and Addressesiupdated successfully.");
         connection.Close();
        }
      }

        static void DeleteEmployee(string connectionString, int employeeID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Console.WriteLine(value: "Delete Employee Stored Procedure Called");
                SqlCommand command = new SqlCommand("DeleteEmployee", connection);
                command.CommandType = CommandType.StoredProcedure;
                // Add parameter for EmployeeID
                command.Parameters.AddWithValue("@EmployeeID", employeeID);
                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine(value: "Employee and their Address deleted successfully.");
                }
                else
                {
                    Console.WriteLine(value: "Employee not found.");
                }
                connection.Close();
                
            }
        }
    }
}


