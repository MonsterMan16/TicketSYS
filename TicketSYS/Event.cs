using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace TicketSYS
{
    class Event
    {
        private Venue _aVenue;
        private int _id;
        private string _title;
        private string _description;
        private DateTime _date;
        private DateTime _time;
        private int _maxTix;
        private decimal _adultPrice;
        private decimal _childPrice;
        private char _status;

        public Event()
        {
            _aVenue = new Venue();
            _id = 0;
            _title = "";
            _description = "";
            _date = DateTime.Now;
            _time = DateTime.Now;
            _maxTix = 0;
            _adultPrice = 0;
            _childPrice = 0;
            _status = 'P';
        }

        public Event(int EventID)
        {
            this._id = EventID;
        }

        public int EventID { get => _id; set => _id = value; }

        public Venue aVenue { get => _aVenue; set => _aVenue = value; }
        public decimal AdultPrice { get => _adultPrice; set => _adultPrice = value; }
        public decimal ChildPrice { get => _childPrice; set => _childPrice = value; }

        public void AddEventDetails(TextBox txtEventID, TextBox txtTitle, TextBox txtDescription, DateTimePicker dtpDate, DateTimePicker dtpTime, NumericUpDown nudAvailTix, NumericUpDown nudChildPrice, NumericUpDown nudAdultPrice)
        {
            _id = Convert.ToInt32(txtEventID.Text);
            _title = txtTitle.Text;
            _description = txtDescription.Text;
            _date = dtpDate.Value;
            _time = dtpTime.Value;
            _maxTix = Convert.ToInt32(nudAvailTix.Value);
            _adultPrice = nudAdultPrice.Value;
            _childPrice = nudChildPrice.Value;
        }

        public static int GetNextEventID()
        {
            // OPEN DB CONNECTION
            OracleConnection conn = new OracleConnection(DBConnect.getOradb());
            conn.Open();
            //DEFINE THE SQL QUERY TO BE EXECUTED
            String sqlQuery = "SELECT NVL(MAX(EVENT_ID),0) FROM EVENTS";
            OracleCommand command = new OracleCommand(sqlQuery, conn);
            // EXECUTE THE SQL QUERY
            int count = Convert.ToInt32(command.ExecuteScalar());
            return ++count;
        }

        public void AddEvent()
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.getOradb()))
            {
                try
                {
                    // OPEN DB CONNECTION
                    conn.Open();


                    // DEFINE THE SQL STATEMENT
                    String sqlInsert = "INSERT INTO EVENTS(EVENT_ID,VENUE_ID,TITLE,DESCRIPTION,EVENT_DATE,SCHEDULE_TIME,MAX_TICKETS,ADULT_PRICE,CHILD_PRICE,STATUS) VALUES(:EVENT_ID, :VENUE_ID, :TITLE, :DESCRIPTION, :EVENT_DATE, :SCHEDULE_TIME, :MAX_TICKETS, :ADULT_PRICE, :CHILD_PRICE, :STATUS)";

                    // PREPARE SQL STATEMENT
                    OracleCommand command = new OracleCommand(sqlInsert, conn);

                    command.Parameters.Add("EVENT_ID", _id);
                    command.Parameters.Add("VENUE_ID", _aVenue.Id);
                    command.Parameters.Add("TITLE", _title);
                    command.Parameters.Add("DESCRIPTION", _description);
                    command.Parameters.Add("EVENT_DATE", _date.ToString("dd-MMM-yy"));
                    command.Parameters.Add("SCHEDULE_TIME", _time.ToString("HH:mm"));
                    command.Parameters.Add("MAX_TICKETS", _maxTix);
                    command.Parameters.Add("ADULT_PRICE", _adultPrice);
                    command.Parameters.Add("CHILD_PRICE", _childPrice);
                    command.Parameters.Add("STATUS", _status);
                    command.Prepare();
                    // EXECUTE SQL STATEMENT

                    command.ExecuteNonQuery();


                } catch(Exception e) {
                    Debug.WriteLine(e.ToString());
                }
                finally
                {
                    // CLOSE CONNECTION
                    conn.Close();
                }
            }
        }

        public void UpdateEvent(char status = 'P')
        {
            String sqlInsert;
            using (OracleConnection conn = new OracleConnection(DBConnect.getOradb()))
            {
                try
                {
                    // OPEN DB CONNECTION
                    conn.Open();



                    // PREPARE SQL STATEMENT
                    OracleCommand command;


                    if (status == 'P')
                    {
                        sqlInsert = "UPDATE EVENTS SET TITLE = :TITLE,DESCRIPTION = :DESCRIPTION,EVENT_DATE = :EVENT_DATE,SCHEDULE_TIME = :SCHEDULE_TIME,MAX_TICKETS = :AVAIL_TIX,ADULT_PRICE = :ADULT_PRICE,CHILD_PRICE = :CHILD_PRICE";

                        command = new OracleCommand(sqlInsert, conn);

                        command.Parameters.Add("TITLE", _title);
                        command.Parameters.Add("DESCRIPTION", _description);
                        command.Parameters.Add("EVENT_DATE", _date.ToString("dd-MMM-yy"));
                        command.Parameters.Add("SCHEDULE_TIME", _time.ToString("HH:mm"));
                        command.Parameters.Add("MAX_TICKETS", _maxTix);
                        command.Parameters.Add("ADULT_PRICE", _adultPrice);
                        command.Parameters.Add("CHILD_PRICE", _childPrice);
                    }
                    else
                    {
                        sqlInsert = "UPDATE EVENTS SET STATUS = :STATUS WHERE EVENT_ID = :EVENT_ID";

                        command = new OracleCommand(sqlInsert, conn);

                        command.Parameters.Add("STATUS", status);
                        command.Parameters.Add("EVENT_ID", _id);
                    }

                    command.Connection = conn;

                    command.Prepare();
                    // EXECUTE SQL STATEMENT
                    command.ExecuteNonQuery();
                }
                catch (OracleException e)
                {
                }
                finally
                {
                    // CLOSE CONNECTION
                    conn.Close();
                }

            }
        }


        public static DataSet GetEvents()
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.getOradb()))
            {
                // DEFINE SQL QUERY
                String sqlQuery = "SELECT EVENT_ID, TITLE FROM EVENTS";

                // CREATE ADAPTER OBJECT
                OracleDataAdapter adapter = new OracleDataAdapter(sqlQuery, conn);

                // CREATE DATASET OBJECT
                DataSet dataSet = new DataSet();

                // CREATE COMMAND OBJECT
                OracleCommand command = new OracleCommand(sqlQuery, conn);
                adapter.SelectCommand = command;
                try
                {
                    // OPEN CONNECTION
                    conn.Open();
                }
                catch (OracleException e)
                {
                }
                finally
                {
                    adapter.Fill(dataSet, "Events");
                    conn.Close();
                }
                return dataSet;
            }
        }

        public void GetEventDetails()
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.getOradb()))
            {
                // DEFINE SQL STATEMENT
                String sqlQuery = "SELECT EVENT_ID, VENUE_ID, TITLE, DESCRIPTION , EVENT_DATE, SCHEDULE_TIME, MAX_TICKETS, ADULT_PRICE, CHILD_PRICE FROM EVENTS WHERE EVENT_ID = :EVENT_ID";
                // PREPARE SQL STATEMENT
                OracleCommand command = new OracleCommand(sqlQuery, conn);
                // OPEN DB CONNECTION
                conn.Open();
                command.Parameters.Add("EVENT_ID", _id);
                command.Prepare();

                OracleDataReader reader = command.ExecuteReader();


                try
                {
                    while (reader.Read())
                    {
                        _id = reader.GetInt32("EVENT_ID");
                        _aVenue = new Venue();
                        _aVenue.GetVenueDetails(reader.GetInt32("VENUE_ID"));
                        _title = reader.GetString("TITLE");
                        _description = reader.GetString("DESCRIPTION");
                        _date = reader.GetDateTime("EVENT_DATE");
                        _time = DateTime.ParseExact(reader.GetString("SCHEDULE_TIME"), "HH:mm", System.Globalization.CultureInfo.InvariantCulture);
                        _maxTix = reader.GetInt32("MAX_TICKETS");
                        _adultPrice = reader.GetDecimal("ADULT_PRICE");
                        _childPrice = reader.GetDecimal("CHILD_PRICE");
                    }
                }
                finally
                {
                    reader.Close();
                }
            }
        }

        public void FillEventDetails(TextBox txtEventID, TextBox txtEventTitle, TextBox txtDescription, ComboBox cboVenue, DateTimePicker dtpStartDate, DateTimePicker dtpStartTime, NumericUpDown nudAvailableTickets, NumericUpDown nudChildTktPrice, NumericUpDown nudAdultTicketPrice)
        {
            txtEventID.Text = _id.ToString("000");
            txtEventTitle.Text = _title;
            txtDescription.Text = _description;
            cboVenue.SelectedIndex = cboVenue.Items.IndexOf(_aVenue.Id.ToString("000") + " " + (_aVenue.Name));
            dtpStartDate.Value = _date;
            dtpStartTime.Value = _time;
            nudAvailableTickets.Value = _maxTix;
            nudChildTktPrice.Value = _childPrice;
            nudAdultTicketPrice.Value = _adultPrice;
        }

        public void FillEventDetails(TextBox txtEventID, TextBox txtEventTitle, TextBox txtDescription, TextBox txtDate, TextBox txtTime, TextBox txtAvailableTickets, TextBox txtChildPrice, TextBox txtAdultPrice)
        {
            txtEventID.Text = _id.ToString("000");
            txtEventTitle.Text = _title;
            txtDescription.Text = _description;
            txtDate.Text = _date.ToString("dd/MM/yy");
            txtTime.Text = _time.ToString("HH:mm");
            txtAvailableTickets.Text = _maxTix.ToString();
            txtChildPrice.Text = Utilities.CURRENCY + _childPrice.ToString();
            txtAdultPrice.Text = Utilities.CURRENCY + _adultPrice.ToString();
        }

        public static void CboEvent_LoadEvents(ComboBox combo)
        {
            DataSet ds = GetEvents();
            combo.Items.Clear();
            combo.Items.Add("");

            for (int i = 0; i < ds.Tables["Events"].Rows.Count; i++)
                combo.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') + " " +
                ds.Tables[0].Rows[i][1].ToString());
            combo.SelectedIndex = 0;
        }
    }
}
