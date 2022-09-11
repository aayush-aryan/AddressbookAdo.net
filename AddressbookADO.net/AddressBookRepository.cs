using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AddressbookADO.net
{
    public class AddressBookRepository
    {
        //Specifying the connection string from the sql server connection.
        private static string connectionString = @"Data Source=DESKTOP-EPUK1PJ;Initial Catalog=addressbookDB;Integrated Security=True;";
        // Establishing the connection using the Sqlconnection.
        SqlConnection connection = new SqlConnection(connectionString);
        /// <summary>
        /// Method for established connections
        /// </summary>
        public void DataBaseConnection()
        {
            try
            {
                DateTime now = DateTime.Now; //create object DateTime class //DateTime.Now class access system date and time 
                connection.Open(); // open connection
                using (connection)  //using SqlConnection
                {
                    Console.WriteLine($"Connection is created Successful {now}"); //print msg
                }
                //connection.Close(); //close connection
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        /// <summary>
        /// UC16
        /// method for Retriveing all Enteries from database;
        /// return no of row in records
        /// </summary>
        public int GetAllContact()
        {
            int rowCount = 0;
            AddressBookModel model = new AddressBookModel();
            try
            {
                using (connection)
                {
                    string query = @"select * from dbo.AddressBook"; // Query to get all the data from the table

                    // Impementing the command on the connection fetched database table
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();  //Open the connection.
                    SqlDataReader reader = command.ExecuteReader();  // executing the sql data reader to fetch the records
                    if (reader.HasRows)
                    {
                        //count = reader.;
                        while (reader.Read())  // Mapping the data to the AddressBookModel class object
                        {
                            rowCount++;
                            model.ContactId = reader.GetInt32(0); //ToInt32(sqlDataReader["ContactId"]);
                            model.FirstName = reader.GetString(1);
                            model.LastName = reader.GetString(2);
                            model.Address = reader.GetString(3);
                            model.City = reader.GetString(4);
                            model.State = reader.GetString(5);
                            model.ZipCode = reader.GetString(6);
                            model.PhoneNumber = reader.GetString(7);
                            model.EmailId = reader.GetString(8);
                            model.AddressBookType = reader.GetString(9);
                            model.AddressBookName = reader.GetString(10);
                            model.AddedDate = reader.GetDateTime(11);
                            Console.WriteLine("ContactId:{0}\nFirstName:{1}\nLastName:{2}\nAddress:{3}\nCity:{4}\nState:{5}\nZipCode:{6}\nPhoneNumber:{7}\nEmailId:{8}\nAddressBookType:{9}\nAddressBookName:{10}\nAddedDate:{11}",
                               model.ContactId, model.FirstName, model.LastName, model.Address, model.City, model.State, model.ZipCode, model.PhoneNumber,
                               model.EmailId, model.AddressBookType, model.AddressBookName, model.AddedDate);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Records Found in Address Book System Table");
                    }
                    reader.Close();
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            finally
            {
                connection.Close();
            }
            return rowCount;
        }
        /// <summary>
        /// UC17
        /// Method For Updating Record on the basis of ContactId
        /// </summary>
        /// <param name="contactid"></param>
        /// <returns></returns>

        public int UpdateAddreessBookRecordsByContactId(int ContactId)
        {
            int result = 0;
            AddressBookModel model = new AddressBookModel();
            try
            {
                using (connection)
                {
                    string query = string.Format("update AddressBook set Address ='Laxmi Nagar',City='Delhi' where ContactId={0}", ContactId); // Query to update particular records in table;

                    // Impementing the command on the connection fetched database table
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();  //Open the connection.
                    result = command.ExecuteNonQuery();// returns no of affected rows
                    if (result != 1)
                    {
                        Console.WriteLine("record not updtaed succuessfully");
                    }
                    else
                    {
                        Console.WriteLine("Record updtaed succuessfully");
                    }

                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            finally
            {
                connection.Close();
            }
            return result;
        }
        /// <summary>
        /// UC18
        /// Method for retrving contacts details join between Paticular date;
        /// return no of records bwteen particular date;
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>

        public int GetContactDetailsAddedInParticularPeriod(string startDate,string endDate)
        {
            int rowCount = 0;
            AddressBookModel model = new AddressBookModel();
            try
            {
                using (connection)
                {
                    string query = string.Format("select * from AddressBook where AddedDate between '{0}' and '{1}';", startDate,endDate); // Query to update particular records in table;


                    // Impementing the command on the connection fetched database table
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();  //Open the connection.
                    SqlDataReader reader = command.ExecuteReader();  // executing the sql data reader to fetch the records
                    if (reader.HasRows)
                    {
                        //count = reader.;
                        while (reader.Read())  // Mapping the data to the AddressBookModel class object
                        {
                            rowCount++;
                            model.ContactId = reader.GetInt32(0); //ToInt32(sqlDataReader["ContactId"]);
                            model.FirstName = reader.GetString(1);
                            model.LastName = reader.GetString(2);
                            model.Address = reader.GetString(3);
                            model.City = reader.GetString(4);
                            model.State = reader.GetString(5);
                            model.ZipCode = reader.GetString(6);
                            model.PhoneNumber = reader.GetString(7);
                            model.EmailId = reader.GetString(8);
                            model.AddressBookType = reader.GetString(9);
                            model.AddressBookName = reader.GetString(10);
                            model.AddedDate = reader.GetDateTime(11);
                            Console.WriteLine("ContactId:{0}\nFirstName:{1}\nLastName:{2}\nAddress:{3}\nCity:{4}\nState:{5}\nZipCode:{6}\nPhoneNumber:{7}\nEmailId:{8}\nAddressBookType:{9}\nAddressBookName:{10}\nAddedDate:{11}",
                               model.ContactId, model.FirstName, model.LastName, model.Address, model.City, model.State, model.ZipCode, model.PhoneNumber,
                               model.EmailId, model.AddressBookType, model.AddressBookName, model.AddedDate);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Records Found in Address Book System Table");
                    }
                    reader.Close();
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            finally
            {
                connection.Close();
            }
            return rowCount;
        }


        /// <summary>
        /// UC19 
        /// Retrieving the contacts for a given state or city.
        /// </summary>
        /// <param name="state"></param>
        /// <param name="city"></param>
        public int RetrieveContactFromCityOrStateName(string City,string State)
        {
            int rowCount = 0;
            AddressBookModel model = new AddressBookModel();
            try
            {
                using (connection)
                {
                    string query = string.Format("select * from dbo.AddressBook where City = '{0}' or State = '{1}';", City, State); // Query to update particular records in table;
                    // Impementing the command on the connection fetched database table
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();  //Open the connection.
                    SqlDataReader reader = command.ExecuteReader();  // executing the sql data reader to fetch the records
                    if (reader.HasRows)
                    {
                        while (reader.Read())  // Mapping the data to the AddressBookModel class object
                        {
                            rowCount++;
                            model.ContactId = reader.GetInt32(0); //ToInt32(sqlDataReader["ContactId"]);
                            model.FirstName = reader.GetString(1);
                            model.LastName = reader.GetString(2);
                            model.Address = reader.GetString(3);
                            model.City = reader.GetString(4);
                            model.State = reader.GetString(5);
                            model.ZipCode = reader.GetString(6);
                            model.PhoneNumber = reader.GetString(7);
                            model.EmailId = reader.GetString(8);
                            model.AddressBookType = reader.GetString(9);
                            model.AddressBookName = reader.GetString(10);
                            model.AddedDate = reader.GetDateTime(11);
                            Console.WriteLine("ContactId:{0}\nFirstName:{1}\nLastName:{2}\nAddress:{3}\nCity:{4}\nState:{5}\nZipCode:{6}\nPhoneNumber:{7}\nEmailId:{8}\nAddressBookType:{9}\nAddressBookName:{10}\nAddedDate:{11}",
                               model.ContactId, model.FirstName, model.LastName, model.Address, model.City, model.State, model.ZipCode, model.PhoneNumber,
                               model.EmailId, model.AddressBookType, model.AddressBookName, model.AddedDate);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Records Found in Address Book System Table");
                    }
                    reader.Close();
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            finally
            {
                connection.Close();
            }
            return rowCount;

        }
    }
}

