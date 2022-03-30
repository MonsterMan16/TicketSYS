using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace TicketSYS
{
    class Venue
    {
        private int _id;
        private string _name;
        private string _address1;
        private string _address2;
        private string _city;
        private string _eircode;
        private string _county;
        private int _capacity;
        private string _contact;
        private string _phone;
        private decimal _fee;
        private char _status;

        public Venue()
        {
            this._id = 0;
            this._name = "";
            this._address1 = "";
            this._address2 = "";
            this._city = "";
            this._eircode = "";
            this._county = "";
            this._capacity = 0;
            this._contact = "";
            this._phone = "";
            this._fee = 0;
            this._status = '\0';
        }

        public Venue(int id, String name, String address1, String address2, String city, String eircode, String county, int capacity, String contact, String phone, decimal fee, char status)
        {
            this._id = id;
            this._name = name;
            this._address1 = address1;
            this._address2 = address2;
            this._city = city;
            this._eircode = eircode;
            this._county = county;
            this._capacity = capacity;
            this._contact = contact;
            this._phone = phone;
            this._fee = fee;
            this._status = status;
        }




        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Address1 { get => _address1; set => _address1 = value; }
        public string Address2 { get => _address2; set => _address2 = value; }
        public string City { get => _city; set => _city = value; }
        public string County { get => _county; set => _county = value; }
        public string Eircode { get => _eircode; set => _eircode = value; }
        public int Capacity { get => _capacity; set => _capacity = value; }
        public string Contact { get => _contact; set => _contact = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public decimal Fee { get => _fee; set => _fee = value; }
        public char Status { get => _status; set => _status = value; }


        public Boolean ValidateVenue()
        {
            return true;
        }

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

                        command.Parameters.Add("VENUE_ID", _id);
                        command.Parameters.Add("NAME", _name);
                        command.Parameters.Add("ADDRESS1", _address1);
                        command.Parameters.Add("ADDRESS2", _address2);
                        command.Parameters.Add("CITY", _city);
                        command.Parameters.Add("EIRCODE", _eircode);
                        command.Parameters.Add("COUNTY", _county);
                        command.Parameters.Add("CAPACITY", _capacity);
                        command.Parameters.Add("CONTACT", _contact);
                        command.Parameters.Add("PHONE", _phone);
                        command.Parameters.Add("FEE", _fee);

                        command.Prepare();
                        // EXECUTE SQL STATEMENT
                        command.ExecuteNonQuery();
                    }
                    finally
                    {
                        // CLOSE CONNECTION
                        conn.Close();
                    }
                }
        }


        public void UpdateVenue(char status = 'O')
        {
            String sqlInsert = "";
            using (OracleConnection conn = new OracleConnection(DBConnect.getOradb()))
            {
                try
                {
                    // OPEN DB CONNECTION
                    conn.Open();



                    // PREPARE SQL STATEMENT
                    OracleCommand command;


                    if(status == 'O')
                    {
                        sqlInsert = "UPDATE VENUES SET NAME = :NAME,ADDRESS1 = :ADDRESS1,ADDRESS2 = :ADDRESS2,CITY = :CITY,EIRCODE = :EIRCODE,COUNTY = :COUNTY,CAPACITY = :CAPACITY,CONTACT = :CONTACT,PHONE = :PHONE,FEE = :FEE,STATUS = :STATUS WHERE VENUE_ID = :VENUE_ID";

                        command = new OracleCommand(sqlInsert, conn);

                        command.Parameters.Add("NAME", _name);
                        command.Parameters.Add("ADDRESS1", _address1);
                        command.Parameters.Add("ADDRESS2", _address2);
                        command.Parameters.Add("CITY", _city);
                        command.Parameters.Add("EIRCODE", _eircode);
                        command.Parameters.Add("COUNTY", _county);
                        command.Parameters.Add("CAPACITY", _capacity);
                        command.Parameters.Add("CONTACT", _contact);
                        command.Parameters.Add("PHONE", _phone);
                        command.Parameters.Add("FEE", _fee);
                        command.Parameters.Add("STATUS", status);
                        command.Parameters.Add("VENUE_ID", _id);
                    } else
                    {
                        sqlInsert = "UPDATE VENUES SET STATUS = :STATUS WHERE VENUE_ID = :VENUE_ID";

                        command = new OracleCommand(sqlInsert, conn);

                        command.Parameters.Add("STATUS", status);
                        command.Parameters.Add("VENUE_ID", _id);
                    }

                    command.Connection = conn;

                    command.Prepare();
                    // EXECUTE SQL STATEMENT
                    command.ExecuteNonQuery();
                }
                catch (OracleException e)
                {
                    // Throw method
                    Debug.Write(e);
                }
                finally
                {
                    // CLOSE CONNECTION
                    conn.Close();
                }

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
                    // Write throw statement
                } finally
                {
                    adapter.Fill(dataSet, "VS");
                    conn.Close();
                }
                return dataSet;
            }
        }


        public void GetVenueDetails(int id)
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.getOradb()))
            {
                // DEFINE SQL STATEMENT
                String sqlQuery = "SELECT venue_id,name,address1,NVL(address2, 'N/A') as address2,city,eircode,county,capacity,contact,phone,fee,status FROM VENUES WHERE VENUE_ID = :VENUE_ID";
                // PREPARE SQL STATEMENT
                OracleCommand command = new OracleCommand(sqlQuery, conn);
                // OPEN DB CONNECTION
                conn.Open();
                command.Parameters.Add("VENUE_ID", id);
                command.Prepare();

                OracleDataReader reader = command.ExecuteReader();

                
                try
                {
                    while (reader.Read())
                    {
                        _id = reader.GetInt32("VENUE_ID");
                        _name = reader.GetString("name");
                        _address1 = reader.GetString("address1");
                        _address2 = reader.GetString("address2");
                        _city = reader.GetString("city");
                        _eircode = reader.GetString("eircode");
                        _county = reader.GetString("county");
                        _capacity = reader.GetInt32("capacity");
                        _phone = reader.GetString("phone");
                        _contact = reader.GetString("contact");
                        _fee = reader.GetDecimal("fee");
                        _status = Convert.ToChar(reader.GetString("status"));
                    }
                } catch (Exception e)
                {

                }
                finally
                {
                    reader.Close();
                }
            }
        }

        public void FillVenueDetails(TextBox txtVenueID, TextBox txtName, TextBox txtStreet1, TextBox txtStreet2, TextBox txtCity, TextBox txtCounty, TextBox txtEircode, TextBox txtCapacity, TextBox txtContact, TextBox txtPhone, TextBox txtFee)
        {
            txtVenueID.Text = _id.ToString();
            txtName.Text = _name;
            txtCity.Text = _city;
            txtStreet1.Text = _address1;
            txtStreet2.Text = _address2;
            txtEircode.Text = _eircode;
            txtCounty.Text = _county;
            txtCapacity.Text = _capacity.ToString();
            txtContact.Text = _contact;
            txtPhone.Text = _phone;
            txtFee.Text = _fee.ToString();
        }

        public void FillVenueDetails(TextBox txtVenueID, TextBox txtStreet1, TextBox txtStreet2, TextBox txtCity, TextBox txtCounty, TextBox txtEircode, TextBox txtCapacity, TextBox txtContact, TextBox txtPhone, TextBox txtFee)
        {
            txtVenueID.Text = _id.ToString();
            txtCity.Text = _city;
            txtStreet1.Text = _address1;
            txtStreet2.Text = _address2;
            txtEircode.Text = _eircode;
            txtCounty.Text = _county;
            txtCapacity.Text = _capacity.ToString();
            txtContact.Text = _contact;
            txtPhone.Text = _phone;
            txtFee.Text = _fee.ToString();
        }

        public void FillVenueDetails(TextBox txtVenueID, TextBox txtName,TextBox txtStreet1, TextBox txtStreet2, TextBox txtCity, ComboBox cboCounty, TextBox txtEircode, NumericUpDown nudCapacity, TextBox txtContact, TextBox txtPhone, NumericUpDown nudFee)
        {
            txtVenueID.Text = _id.ToString();
            txtName.Text = _name;
            txtCity.Text = _city;
            txtStreet1.Text = _address1;
            txtStreet2.Text = _address2;
            txtEircode.Text = _eircode;
            cboCounty.SelectedIndex = cboCounty.FindStringExact(County);    
            nudCapacity.Value = _capacity;
            txtPhone.Text = _phone;
            txtContact.Text = _contact;  
            nudFee.Value = _fee;
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

        public void SetVenueDetails(String name, String address1, String address2, String city, String county, String eircode, int capacity, String phone, String contact, decimal fee)
        {
            _name = name;
            _address1 = address1;
            _address2 = address2;
            _city = city;
            _county = county;
            _eircode = eircode;
            _capacity = capacity;
            _phone = phone;
            _contact = contact;
            _fee = fee;
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
