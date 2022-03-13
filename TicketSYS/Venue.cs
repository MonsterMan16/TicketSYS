using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace TicketSYS
{
    class Venue
    {
        private int id;
        private string name;
        private string address1;
        private string address2;
        private string city;
        private string eircode;
        private string county;
        private int capacity;
        private string contact;
        private string phone;
        private double fee;
        private char status;
        public const char VENUE_STATUS_OPEN = 'O';
        public const char VENUE_STATUS_CLOSED = 'C';

        public Venue(int id)
        {
            this.id = id;
            GetVenueDetails();
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address1 { get => address1; set => address1 = value; }
        public string Address2 { get => address2; set => address2 = value; }
        public string City { get => city; set => city = value; }
        public string County { get => county; set => county = value; }
        public string Eircode { get => eircode; set => eircode = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public string Contact { get => contact; set => contact = value; }
        public string Phone { get => phone; set => phone = value; }
        public double Fee { get => fee; set => fee = value; }
        public char Status { get => status; set => status = value; }

        public void AddVenue()
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.getOradb()))
            {
                try
                {
                    // OPEN DB CONNECTION
                    conn.Open();


                    // DEFINE THE SQL STATEMENT
                    String sqlInsert = "INSERT INTO VENUES(venue_id,name,address1,address2,city,eircode,county,capacity,contact,phone,fee,status) VALUES(:VENUE_ID, :NAME, :ADDRESS1, :ADDRESS2, :CITY, :EIRCODE, :COUNTY, :CAPACITY, :CONTACT, :PHONE, :FEE, 'O')";

                    // PREPARE SQL STATEMENT
                    OracleCommand command = new OracleCommand(sqlInsert, conn);

                    command.Parameters.Add("VENUE_ID", this.Id);
                    command.Parameters.Add("NAME", this.Name);
                    command.Parameters.Add("ADDRESS1", this.Address1);
                    command.Parameters.Add("ADDRESS2", this.Address2);
                    command.Parameters.Add("CITY", this.City);
                    command.Parameters.Add("EIRCODE", this.Eircode);
                    command.Parameters.Add("COUNTY", this.County);
                    command.Parameters.Add("CAPACITY", this.Capacity);
                    command.Parameters.Add("CONTACT", this.Contact);
                    command.Parameters.Add("PHONE", this.Phone);
                    command.Parameters.Add("FEE", this.Fee);

                    command.Prepare();
                    // EXECUTE SQL STATEMENT
                    command.ExecuteNonQuery();
                    // CLOSE CONNECTION
                    conn.Close();
                } catch(OracleException e)
                {
                    string errorMessage = "Code: " + e.ErrorCode + "\n" +
                           "Message: " + e.Message;
                    System.Diagnostics.EventLog log = new System.Diagnostics.EventLog();
                    log.Source = "My Application";
                    log.WriteEntry(errorMessage);
                    Console.WriteLine("AN ERROR HAS OCCURED WITH THE DATABASE CONNECTION");
                }
            }
        }

        public void UpdateVenue()
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.getOradb()))
            {
                // OPEN DB CONNECTION
                conn.Open();

                // DEFINE THE SQL STATEMENT
                String sqlInsert = "UPDATE VENUES SET NAME = :NAME,ADDRESS1 = :ADDRESS1,ADDRESS2 = :ADDRESS2,CITY = :CITY,EIRCODE = :EIRCODE,COUNTY = :COUNTY,CAPACITY = :CAPACITY,CONTACT = :CONTACT,PHONE = :PHONE,FEE = :FEE WHERE VENUE_ID = :VENUE_ID";

                // PREPARE SQL STATEMENT
                OracleCommand command = new OracleCommand(sqlInsert, conn);
                command.Connection = conn;


                command.Parameters.Add("NAME", name);
                command.Parameters.Add("ADDRESS1", address1);
                command.Parameters.Add("ADDRESS2", address2);
                command.Parameters.Add("CITY", city);
                command.Parameters.Add("EIRCODE", eircode);
                command.Parameters.Add("COUNTY", county);
                command.Parameters.Add("CAPACITY", capacity);
                command.Parameters.Add("CONTACT", contact);
                command.Parameters.Add("PHONE", phone);
                command.Parameters.Add("FEE", fee);
                command.Parameters.Add("VENUE_ID", id);

                command.Prepare();
                // EXECUTE SQL STATEMENT
                command.ExecuteNonQuery();
                // CLOSE CONNECTION
                conn.Close();
            }
        }

        public static DataSet GetVenues()
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.getOradb()))
            {
                // DEFINE SQL QUERY
                String sqlQuery = "SELECT VENUE_ID, NAME FROM VENUES WHERE STATUS = 'O'";

                // CREATE ADAPTER OBJECT
                OracleDataAdapter adapter = new OracleDataAdapter();

                // CREATE DATASET OBJECT
                DataSet dataSet = new DataSet();

                // CREATE COMMAND OBJECT
                OracleCommand command = new OracleCommand(sqlQuery, conn);
                adapter.SelectCommand = command;
                try
                {
                    // OPEN CONNECTION
                    conn.Open();
                    adapter.TableMappings.Add("Venue ID", "Name");
                    dataSet.DataSetName = "Venues";
                } catch (OracleException e)
                {
                    string errorMessage = "Code: " + e.ErrorCode + "\n" +
                           "Message: " + e.Message;
                    System.Diagnostics.EventLog log = new System.Diagnostics.EventLog();
                    log.Source = "My Application";
                    log.WriteEntry(errorMessage);
                } finally
                {
                    adapter.Fill(dataSet, "VS");
                    conn.Close();
                }
                return dataSet;
            }
        }


        public void GetVenueDetails()
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.getOradb()))
            {
                // DEFINE SQL STATEMENT
                String sqlQuery = "SELECT venue_id,name,address1,NVL(address2, 'N/A') as address2,city,eircode,county,capacity,contact,phone,fee,status FROM VENUES WHERE VENUE_ID = :VENUE_ID";
                // PREPARE SQL STATEMENT
                OracleCommand command = new OracleCommand(sqlQuery, conn);
                // OPEN DB CONNECTION
                conn.Open();
                command.Parameters.Add("VENUE_ID", Id);
                command.Prepare();

                OracleDataReader reader = command.ExecuteReader();

                
                try
                {
                    while (reader.Read())
                    {
                        Name = reader.GetString("name");
                        Address1 = reader.GetString("address1");
                        Address2 = reader.GetString("address2");
                        City = reader.GetString("city");
                        Eircode = reader.GetString("eircode");
                        County = reader.GetString("county");
                        Capacity = reader.GetInt32("capacity");
                        Phone = reader.GetString("phone");
                        Contact = reader.GetString("contact");
                        Fee = reader.GetFloat("fee");
                        Status = Convert.ToChar(reader.GetString("status"));
                    }
                }
                finally
                {
                    reader.Close();
                }
            }
        }

        public void FillVenueDetails(TextBox txtVenueID, TextBox txtName, TextBox txtStreet1, TextBox txtStreet2, TextBox txtCity, TextBox txtCounty,  TextBox txtEircode, TextBox txtCapacity, TextBox txtContact, TextBox txtPhone, TextBox txtFee)
        {
            txtVenueID.Text = Id.ToString();
            txtName.Text = Name;
            txtCity.Text = City;
            txtStreet1.Text = Address1;
            txtStreet2.Text = Address2;
            txtCounty.Text = County;
            txtEircode.Text = Eircode;
            txtCapacity.Text = Capacity.ToString();
            txtContact.Text = Contact;
            txtPhone.Text = Phone;
            txtFee.Text = Fee.ToString();
        }

        public void FillVenueDetails(TextBox txtVenueID, TextBox txtStreet1, TextBox txtStreet2, TextBox txtCity, TextBox txtEircode, TextBox txtCounty, TextBox txtCapacity, TextBox txtContact, TextBox txtPhone, TextBox txtFee)
        {
            txtVenueID.Text = Id.ToString();
            txtCity.Text = City;
            txtStreet1.Text = Address1;
            txtStreet2.Text = Address2;
            txtEircode.Text = Eircode;
            txtCounty.Text = County;
            txtCapacity.Text = Capacity.ToString();
            txtContact.Text = Contact;
            txtPhone.Text = Phone;
            txtFee.Text = Fee.ToString();
        }

        public void FillVenueDetails(TextBox txtVenueID, TextBox txtName,TextBox txtStreet1, TextBox txtStreet2, TextBox txtCity, ComboBox cboCounty, TextBox txtEircode, NumericUpDown nudCapacity, TextBox txtPhone, TextBox txtContact, NumericUpDown nudFee)
        {
            txtVenueID.Text = Id.ToString();
            txtName.Text = Name.ToString();
            txtCity.Text = City;
            txtStreet1.Text = Address1;
            txtStreet2.Text = Address2;
            txtEircode.Text = Eircode;
            cboCounty.SelectedIndex = cboCounty.FindStringExact(County);    
            nudCapacity.Value = Capacity;
            txtPhone.Text = Phone;
            txtContact.Text = Contact;  
            nudFee.Value = (decimal)Fee;
        }



        public static int GetNextVenueID()
        {
            // OPEN DB CONNECTION
            OracleConnection conn = new OracleConnection(DBConnect.getOradb());
            conn.Open();
            //DEFINE THE SQL QUERY TO BE EXECUTED
            String sqlQuery = "SELECT NVL(MAX(VENUE_ID),0) FROM VENUES";
            OracleCommand command = new OracleCommand(sqlQuery, conn);
            // EXECUTE THE SQL QUERY
            int count = Convert.ToInt32(command.ExecuteScalar());
            return ++count;
        }

        public void SetVenueDetails(String name, String address1, String address2, String city, String county, String eircode, int capacity, String phone, String contact, Double fee)
        {
            Name = name;
            Address1 = address1;
            Address2 = address2;
            City = city;
            County = county;
            Eircode = eircode;
            Capacity = capacity;
            Phone = phone;
            Contact = contact;
            Fee = fee;
        }
        public static void CboVenue_LoadVenues(ComboBox combo)
        {
            DataSet ds = Venue.GetVenues();
            combo.Items.Clear();
            combo.Items.Add("");

            for (int i = 0; i < ds.Tables["VS"].Rows.Count; i++)
                combo.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') + " " +
                ds.Tables[0].Rows[i][1].ToString());
            combo.SelectedIndex = 0;
        }

        public static void CboVenue_LoadFilter(ComboBox countys, ComboBox cities)
        {
            countys.Items.Clear();
            cities.Items.Clear();

            DataSet ds = Venue.GetVenues();

            for (int i = 0; i < ds.Tables["VS"].Rows.Count; i++)
                countys.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            countys.SelectedIndex = 0;

            ds = Venue.GetVenues();

            for (int i = 0; i < ds.Tables["VS"].Rows.Count; i++)
                cities.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            cities.SelectedIndex = 0;
        }

        public void ChangeStatus(char status)
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.getOradb()))
            {
                try
                {
                    // OPEN DB CONNECTION
                    conn.Open();

                    // DEFINE THE SQL STATEMENT
                    String sqlInsert = "UPDATE VENUES SET STATUS = :STATUS WHERE VENUE_ID = :VENUE_ID";

                    // PREPARE SQL STATEMENT
                    OracleCommand command = new OracleCommand(sqlInsert, conn);

                    command.Parameters.Add("STATUS", status);
                    command.Parameters.Add("VENUE_ID", Id);

                    command.Prepare();
                    // EXECUTE SQL STATEMENT
                    command.ExecuteNonQuery();
                    // CLOSE CONNECTION
                    conn.Close();
                }
                catch (OracleException e)
                {
                    string errorMessage = "Code: " + e.ErrorCode + "\n" +
                           "Message: " + e.Message;
                    System.Diagnostics.EventLog log = new System.Diagnostics.EventLog();
                    log.Source = "My Application";
                    log.WriteEntry(errorMessage);
                    Console.WriteLine("AN ERROR HAS OCCURED WITH THE DATABASE CONNECTION");
                }
            }
        }
    }
}
