//----------------------------------------------------------------------------
// <copyright file="EmployeeRepository.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------------
namespace EmployeeRepositoryLayer.RepositoryService
{
    using EmployeeCommanLayer.EmployeeModel;
    using EmployeeRepositoryLayer.RepositoryInterface;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Text;
    using System.Threading.Tasks;


    /// <summary>
    /// this is class EmployeeRepository layer which implement a IEmployeeRepository.
    /// </summary>
    /// <seealso cref="EmployeeRepositoryLayer.RepositoryInterface.IEmployeeRepositoryLayer" />
    public class EmployeeRepository : IEmployeeRepositoryLayer
    {
        /// <summary>
        /// The connection path string to data base server.
        /// it having three body part ,server name, database name and security provider type.
        /// </summary>
        private static string connectionPath = ("Server = (localDB)\\Local; Initial Catalog=EmployeeDetailsTable; Integrated Security = true");

        /// <summary>
        /// Adds the employee id method which take employee employee model .
        /// </summary>
        /// <param name="employeeModels">The employee models.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool AddEmployee(EmployeeModel employeeModels)
        {
            try
            {
                //// when to use using() when we doesn't need to close the database 
                //// it will close automaticaly when work is done.
                using (SqlConnection sqlconnection = new SqlConnection(connectionPath))
                {
                    //// SqlCommand is to get the sql command that is return inside the store procedure
                    SqlCommand command = new SqlCommand("insertemployee", sqlconnection);
                    
                    //// CommandType is use to get store store procedure and perform operation
                    //// commandType has default  form is text. 
                    command.CommandType =  CommandType.StoredProcedure;
                    
                    ////Parameters.AddWithValue get the name as well as value 
                    //// means just store the user data into the database
                    command.Parameters.AddWithValue("Name", employeeModels.Name);
                    command.Parameters.AddWithValue("Email", employeeModels.Email);
                    command.Parameters.AddWithValue("Number", employeeModels.Number);
                    command.Parameters.AddWithValue("Age", employeeModels.Age);
                    sqlconnection.Open();

                    //// make conectin open to inserting the data into the database
                    //// checking if emial is allready exist in database.
                    bool flag = CheckEmail(employeeModels.Email);
                    if (flag == false)
                    {
                        ////Command.ExecuteNonQuery() it is use to store the bunch of data 
                        ///as well when we doing operations again and again with database
                        ///That time we are mostly use the Execute query
                        int result = command.ExecuteNonQuery();
                        if (result != 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    //else
                    //{
                    //    return "Entered Email is alraedy Exist";
                    //}
                }
                return false;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

        }
        /// <summary>
        /// Deletes the employee method which take ID from user to delete that employee data  from data base.
        /// </summary>
        /// <param name="ID">The identifier.</param>
        /// <returns></returns>
        public bool DeleteEmployee(int ID)
        {
            int result = 0;
            try
            {
                //// when to use using() when we doesn't need to close the database 
                //// it will close automaticaly when work is done.
                using (SqlConnection SqlConnection=new SqlConnection(connectionPath))
                {                  
                    //// SqlCommand is to get the sql command that is return inside the store procedure

                    SqlCommand sqlCommand = new SqlCommand("newdeleteemployee", SqlConnection);
                    //// CommandType is use to get store store procedure and perform operation
                    //// commandType has default  form is text.
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    ////Parameters.AddWithValue get the name as well as value 
                    //// means just store the user data into the database
                    sqlCommand.Parameters.AddWithValue("ID", ID);
                    ////opening the sqlconnection to perform the respective operation.
                    SqlConnection.Open();

                    ////Command.ExecuteNonQuery() it is use to store the bunch of data 
                    ///as well when we doing operations again and again with database
                    ///That time we are mostly use the Execute query
                    result = sqlCommand.ExecuteNonQuery();
                }
                
            }

            catch (Exception Exception)
            {
                Console.WriteLine(Exception.Message);
            }
            if (result != 0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Updates the employee method which take ID as input and data from user to update employee Employee.
        /// </summary>
        /// <param name="employeeModels">The employee models.</param>
        /// <returns></returns>
        public bool UpdateEmployee(EmployeeModel employeeModels)
        {
            int updateresult = 0;
            try
            { 
                //// when to use using() when we doesn't need to close the database 
                //// it will close automaticaly when work is done.
                using (SqlConnection SqlConnection = new SqlConnection(connectionPath))
                {
                    //// SqlCommand is to get the sql command that is return inside the store procedure

                    SqlCommand sqlCommand = new SqlCommand("updateemployee", SqlConnection);
                    //// CommandType is use to get store store procedure and perform operation
                    //// commandType has default  form is text.
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    ////Parameters.AddWithValue get the name as well as value 
                    //// means just store the user data into the database
                    sqlCommand.Parameters.AddWithValue("ID", employeeModels.Id);
                    sqlCommand.Parameters.AddWithValue("Name", employeeModels.Name);
                    sqlCommand.Parameters.AddWithValue("Email", employeeModels.Email);
                    sqlCommand.Parameters.AddWithValue("Number", employeeModels.Number);
                    sqlCommand.Parameters.AddWithValue("Age", employeeModels.Age);

                    ////opening the sqlconnection to perform the respective operation.
                    SqlConnection.Open();

                    ////Command.ExecuteNonQuery() it is use to store the bunch of data 
                    ///as well when we doing operations again and again with database
                    ///That time we are mostly use the Execute query
                    updateresult = sqlCommand.ExecuteNonQuery();
                }
            }
            catch(Exception Exception)
            {
                Console.WriteLine(Exception.Message);
            }
            if (updateresult != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Displays the employee is method which display a list of employee.
        /// It will return model of employee in IList form.
        /// IList is interface and list is concreate class.
        /// If your method just needs to iterate a collection, then an IEnumerable<> will suffice:
        /// </summary>
        /// <returns></returns>
        public IList<EmployeeModel> DisplayEmployee()
        {
            ////Employee model list is made to strore all employee data into list as par model formate
            List<EmployeeModel> employeelist = new List<EmployeeModel>();

            //// when to use using() when we doesn't need to close the database 
            //// it will close automaticaly when work is done.
            using (SqlConnection sqlConnection = new SqlConnection(connectionPath))
            {
                //// SqlCommand is to get the sql command that is return inside the store procedure.
                SqlCommand sqlCommand = new SqlCommand("getemployee", sqlConnection);

                //// CommandType is use to get store store procedure and perform operation
                //// commandType has default  form is text.
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlConnection.Open();
                ////the method ExecuteReader return sqldatareader .
                SqlDataReader Reader = sqlCommand.ExecuteReader();
                while (Reader.Read())
                {
                    EmployeeModel employee = new EmployeeModel();
                    ////here list will store all data into model 
                    ////means data comming from data base 
                    employeelist.Add(new EmployeeModel {
                    Id = Convert.ToInt32(Reader["ID"]),
                    Name = Convert.ToString(Reader["Name"]),
                    Email = Convert.ToString(Reader["Email"]),
                    Number = Convert.ToString(Reader["Number"]),
                    Age = Convert.ToString(Reader["Age"])
                    });
                }
                return employeelist;
            }
        }
        /// <summary>
        /// Displays the employeeby identifier which display a employee by it's ID.
        /// </summary>
        /// <param name="ID">The identifier.</param>
        /// <returns></returns>
        public EmployeeModel DisplayEmployeebyID(int ID)
        {
            try
            {
                //// when to use using() when we doesn't need to close the database 
                //// it will close automaticaly when work is done.
                using (SqlConnection sqlConnection = new SqlConnection(connectionPath))
                {
                    //// SqlCommand is to get the sql command that is return inside the store procedure
                    SqlCommand sqlCommand = new SqlCommand("getemployeebyId", sqlConnection);

                    //// CommandType is use to get store store procedure and perform operation
                    //// commandType has default  form is text.
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    // Use AddWithValue to assign ID.
                    // SQL Server will implicitly convert strings into XML.
                    sqlCommand.Parameters.AddWithValue("ID", ID);

                    sqlConnection.Open();
                    SqlDataReader Reader = sqlCommand.ExecuteReader();
                    if (Reader.HasRows)
                    {
                        while (Reader.Read())
                        {
                            EmployeeModel employee = new EmployeeModel();

                            employee.Id = Convert.ToInt32(Reader["ID"]);
                            employee.Name = Convert.ToString(Reader["Name"]);
                            employee.Email = Convert.ToString(Reader["Email"]);
                            employee.Number = Convert.ToString(Reader["Number"]);
                            employee.Age = Convert.ToString(Reader["Age"]);
                            return employee;
                        }
                    }
                }
                return null;
            }catch(Exception Exception)
            { 
                throw Exception;
            }
        }
        /// <summary>
        /// Checks the email.
        /// </summary>
        /// <param name="Emailcheck">The emailcheck.</param>
        /// <returns></returns>
        public bool CheckEmail(string Emailcheck)
        {
            string Email="";
            ////To build connection between bitween database and code.
            SqlConnection connection = new SqlConnection(connectionPath);

            //// SqlCommand is to get the sql command that is return inside the store procedure
            SqlCommand checkemail = new SqlCommand("getemployeemail", connection);

            //// CommandType is use to get store store procedure and perform operation
            //// commandType has default  form is text.
            checkemail.CommandType = CommandType.StoredProcedure;
            //checkemail.Parameters.AddWithValue("@Email", employeeModels.Email);
            connection.Open();
            SqlDataReader reader = checkemail.ExecuteReader();
            while (reader.Read())
            {
                Email = Convert.ToString(reader["Email"]);

               if (Email == Emailcheck)
               {
                    return true;
               }
            }
            return false;
        }
    }
}
