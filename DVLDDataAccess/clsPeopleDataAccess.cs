using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccess
{
    public class clsPeopleDataAccess
    {
        public static bool GetPersonInfoByID(int PersonID, ref string NationalNo, ref string FirstName, ref string SecondName,
                ref string ThirdName, ref string LastName, ref sbyte Gender, ref string Email, ref string Phone,
                ref DateTime DateOfBirth, ref int NationalityCountryID, ref string Address, ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM People WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    NationalNo = (string)reader["NationalNo"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    ThirdName = (string)reader["ThirdName"];
                    LastName = (string)reader["LastName"];
                    Gender = Convert.ToSByte(reader["Gender"]);
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    NationalityCountryID = (int)reader["NationalityCountryID"];
                    Address = (string)reader["Address"];
                    ImagePath = reader["ImagePath"] != DBNull.Value ? (string)reader["ImagePath"] : "";
                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }


        public static bool GetPersonInfoByNationalNo(ref int PersonID, string NationalNo, ref string FirstName, ref string SecondName,
        ref string ThirdName, ref string LastName, ref sbyte Gender, ref string Email, ref string Phone,
        ref DateTime DateOfBirth, ref int NationalityCountryID, ref string Address, ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM People WHERE NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    PersonID = (int)reader["PersonID"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    ThirdName = (string)reader["ThirdName"];
                    LastName = (string)reader["LastName"];
                    Gender = (sbyte)reader["Gender"];
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    NationalityCountryID = (int)reader["NationalityCountryID"];
                    Address = (string)reader["Address"];
                    ImagePath = reader["ImagePath"] != DBNull.Value ? (string)reader["ImagePath"] : "";
                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static int AddNewPerson(string NationalNo, string FirstName, string SecondName,
                string ThirdName, string LastName, sbyte Gender, string Email, string Phone,
                DateTime DateOfBirth, int NationalityCountryID, string Address, string ImagePath)
        {

            int PersonID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO People
                                VALUES (@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName, @DateOfBirth, @Gender,
                                        @Address, @Phone, @Email, @NationalityCountryID, @ImagePath);
                                SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Gender", (byte)Gender);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            command.Parameters.AddWithValue("@Address", Address);

            if (ImagePath != "")
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    PersonID = insertedID;
                }
            }
            catch
            {
                // console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return PersonID;
        }


        public static bool UpdatePerson(int PersonID, string NationalNo, string FirstName, string SecondName,
                string ThirdName, string LastName, sbyte Gender, string Email, string Phone,
                DateTime DateOfBirth, int NationalityCountryID, string Address, string ImagePath)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE People
                                SET NationalNo = @NationalNo,
                                FirstName = @FirstName,
                                SecondName = @SecondName,
                                ThirdName = @ThirdName,
                                LastName = @LastName,
                                DateOfBirth = @DateOfBirth,
                                Gender = @Gender,
                                Address = @Address,
                                Phone = @Phone,
                                Email = @Email,
                                NationalityCountryID = @NationalityCountryID,
                                ImagePath = @ImagePath
                                WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Gender", (byte)Gender);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            if (ImagePath != "")
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch
            {
                // console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }


        public static bool DeletePerson(int PersonID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "DELETE FROM People WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch
            {
                // console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }


        public static DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT People.PersonID, People.NationalNo,
              People.FirstName, People.SecondName, People.ThirdName, People.LastName,
			  People.DateOfBirth, People.Gender,  
				  CASE
                  WHEN People.Gender = 0 THEN 'Male'

                  ELSE 'Female'

                  END as GenderCaption,
			  People.Address, People.Phone, People.Email, 
              People.NationalityCountryID, Countries.CountryName, People.ImagePath
              FROM            People INNER JOIN
                         Countries ON People.NationalityCountryID = Countries.CountryID
              ORDER BY People.FirstName";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();
            }
            catch
            {
                // console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        /*
         
        public static DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM People;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();
            }
            catch
            {
                // console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }
         
         */


        public static bool IsPersonExists(int PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found = 1 FROM People WHERE PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();

            }
            catch
            {
                // console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool IsPersonExists(string NationalNo)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found = 1 FROM People WHERE NationalNo = @NationalNo;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();

            }
            catch
            {
                // console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

    }
}
