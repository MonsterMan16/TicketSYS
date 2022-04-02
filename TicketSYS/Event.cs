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
        private int _availTix;
        private decimal _adultPrice;
        private decimal _childPrice;

        public Event()
        {
            _aVenue = new Venue();
            _id = 0;
            _title = "";
            _description = "";
            _date = DateTime.Now;
            _time = DateTime.Now;
            _availTix = 0;
            _adultPrice = 0;
            _childPrice = 0;
        }

        public Event(int EventID)
        {
            this.EventID = EventID;
        }

        public int EventID { get => _id; set => _id = value; }
        public string EventTitle { get => _title; set => _title = value; }
        public string EventDescription { get => _description; set => _description = value; }
        public decimal AdultTicketPrice { get => _adultPrice; set => _adultPrice = value; }
        public decimal ChildTicketPrice { get => _childPrice; set => _childPrice = value; }
        public Venue aVenue { get => _aVenue; set => _aVenue = value; }
        public DateTime StartDate { get => _date; set => _date = value; }
        public DateTime StartTime { get => _time; set => _time = value; }
        public int MaxTickets { get => _availTix; set => _availTix = value; }

        public void AddEventDetails(TextBox txtEventID, TextBox txtTitle, TextBox txtDescription, DateTimePicker dtpDate, DateTimePicker dtpTime, NumericUpDown nudAvailTix, NumericUpDown nudChildPrice, NumericUpDown nudAdultPrice)
        {
            _id = Convert.ToInt32(txtEventID.Text);
            _title = txtTitle.Text;
            _description = txtDescription.Text;
            _date = dtpDate.Value;
            _time = dtpTime.Value;
            _availTix = Convert.ToInt32(nudAvailTix.Value);
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
                    String sqlInsert = "INSERT INTO EVENTS(EVENT_ID,VENUE_ID,TITLE,DESCRIPTION,EVENT_DATE,SCHEDULE_TIME,MAX_TICKETS,ADULT_PRICE,CHILD_PRICE) VALUES(:EVENT_ID, :VENUE_ID, :TITLE, :DESCRIPTION, :EVENT_DATE, :SCHEDULE_TIME, :MAX_TICKETS, :ADULT_PRICE, :CHILD_PRICE)";

                    // PREPARE SQL STATEMENT
                    OracleCommand command = new OracleCommand(sqlInsert, conn);

                    command.Parameters.Add("EVENT_ID", _id);
                    command.Parameters.Add("VENUE_ID", aVenue.Id);
                    command.Parameters.Add("TITLE", _title);
                    command.Parameters.Add("DESCRIPTION", _description);
                    command.Parameters.Add("EVENT_DATE", String.Format("{0:dd-MMM-yy}", _date));
                    command.Parameters.Add("SCHEDULE_TIME", String.Format("{0:HH:mm}", StartTime));
                    command.Parameters.Add("MAX_TICKETS", MaxTickets);
                    command.Parameters.Add("ADULT_PRICE", AdultTicketPrice);
                    command.Parameters.Add("CHILD_PRICE", ChildTicketPrice);
                    command.Prepare();
                    // EXECUTE SQL STATEMENT

                    command.ExecuteNonQuery();


                } catch(Exception e) {
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
                    string errorMessage = "Code: " + e.ErrorCode + "\n" +
                           "Message: " + e.Message;
                    System.Diagnostics.EventLog log = new System.Diagnostics.EventLog();
                    log.Source = "My Application";
                    log.WriteEntry(errorMessage);
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
                String sqlQuery = "SELECT EVENT_ID, VENUE_ID, TITLE, DESCRIPTION , START_TIME, END_TIME, MAX_TICKETS, ADULT_PRICE, CHILD_PRICE FROM EVENTS WHERE EVENT_ID = :EVENT_ID";
                // PREPARE SQL STATEMENT
                OracleCommand command = new OracleCommand(sqlQuery, conn);
                // OPEN DB CONNECTION
                conn.Open();
                command.Parameters.Add("EVENT_ID", EventID);
                command.Prepare();

                OracleDataReader reader = command.ExecuteReader();


                try
                {
                    while (reader.Read())
                    {
                        EventID = reader.GetInt32("EVENT_ID");
                        aVenue.GetVenueDetails(reader.GetInt32("VENUE_ID"));
                        EventTitle = reader.GetString("TITLE");
                        EventDescription = reader.GetString("DESCRIPTION");
                        StartDate = reader.GetDateTime("START_DATE");
                        StartTime = reader.GetDateTime("START_TIME");
                        MaxTickets = reader.GetInt32("MAX_TICKETS");
                        AdultTicketPrice = reader.GetDecimal("ADULT_PRICE");
                        ChildTicketPrice = reader.GetDecimal("CHILD_PRICE");
                    }
                }
                finally
                {
                    reader.Close();
                }
            }
        }

        public void FillEventDetails(TextBox txtEventID, TextBox txtEventTitle, TextBox txtDescription, DateTimePicker dtpStartDate, DateTimePicker dtpStartTime, NumericUpDown nudAvailableTickets, NumericUpDown nudChildTktPrice, NumericUpDown nudAdultTicketPrice)
        {
            txtEventID.Text = _id.ToString();
            txtEventTitle.Text = _title;
            txtDescription.Text = _description;
            dtpStartDate.Value = _date;
            dtpStartTime.Value = _time;
            nudAvailableTickets.Value = _availTix;
            nudChildTktPrice.Value = Convert.ToDecimal(ChildTicketPrice);
            nudAdultTicketPrice.Value = _adultPrice;
        }

        public void FillEventDetails(TextBox txtEventID, TextBox txtDescription, DateTimePicker dtpStartDate, DateTimePicker dtpStartTime, NumericUpDown nudAvailableTickets, NumericUpDown nudChildTktPrice, NumericUpDown nudAdultTicketPrice)
        {
            txtEventID.Text = _id.ToString();
            txtDescription.Text = _description;
            dtpStartDate.Value = _date.Date;
            dtpStartTime.Value = _time;
            nudAvailableTickets.Value = _availTix;
            nudChildTktPrice.Value = Convert.ToDecimal(ChildTicketPrice);
            nudAdultTicketPrice.Value = _adultPrice;
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

        public static void Event_DateTimePickerProperies(DateTimePicker dtpDate, DateTimePicker dtpTime)
        {
            dtpTime.Format = DateTimePickerFormat.Custom;
            dtpTime.CustomFormat = "HH:mm";
            dtpTime.ShowUpDown = false;
        }
    }
}
