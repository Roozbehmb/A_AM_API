using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;
using System.Web.Script.Serialization;



namespace ASP.NETWebServiceUsingJQuery
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]


    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public Empolyee indexEmployee()
        {
            Empolyee empolyee = new Empolyee();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;


            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand("indexEmployee", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                connection.Open();

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    empolyee.FirstName = rdr["FirstName"].ToString();
                    empolyee.LastName = rdr["LastName"].ToString();
                  //  empolyee.Salaery = Convert.ToInt32(rdr["Salaery"]);

                }


                return empolyee;
            }

        }

        [WebMethod]
        public void SaveData(string FirstName, string LastName)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Replace YourTableName with the actual table name
                string query = "INSERT INTO Employee (FirstName, LastName) VALUES (@FirstName, @LastName)";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@FirstName", FirstName);
                    cmd.Parameters.AddWithValue("@LastName", LastName);

                    cmd.ExecuteNonQuery();
                }
            }

        }

        [WebMethod]
        public Empolyee GetEmployeeById(int employeedId)
        {
            Empolyee empolyee = new Empolyee();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;


            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand("spGetEmployeeById", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@id";
                parameter.Value = employeedId;
                cmd.Parameters.Add(parameter);


                connection.Open();

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    empolyee.FirstName = rdr["FirstName"].ToString();
                    empolyee.LastName = rdr["LastName"].ToString();
                  //  empolyee.Salaery = Convert.ToInt32(rdr["Salaery"]);
                }


                return empolyee;
            }

        }

        [WebMethod]
        public string index()
        {
            // Establish a connection to the database
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Perform a SQL query to retrieve data
                string query = "SELECT * FROM Shop.dbo.Employee";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Execute the query and retrieve a SqlDataReader
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Iterate through the result set and display data
                        try
                        {
                            while (reader.Read())
                            {

                                // Assuming you have columns named "ID", "Name", and "OtherColumn" in your database
                                string id = reader["ID"] is DBNull ? "NULL" : reader["ID"].ToString();
                                string FirstName = reader["FirstName"] is DBNull ? "NULL" : reader["FirstName"].ToString();
                                string LastName = reader["LastName"] is DBNull ? "NULL" : reader["LastName"].ToString();
                                string[] Result = new string[3] { id, FirstName, LastName };
                                JavaScriptSerializer serializer = new JavaScriptSerializer();
                                return serializer.Serialize(Result);
                            }
                        }
                        catch (Exception e)
                        {
                            return e.Message;
                        }

                        return "False";
                    }
                }
            }
        }



    }

}
















