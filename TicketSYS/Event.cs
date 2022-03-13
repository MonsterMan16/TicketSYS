﻿using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace TicketSYS
{
    class Event
    {
        private Venue _venue;
        private int _eventID;
        private string _eventTitle;
        private string _eventDescription;
        private DateTime _startDate;
        private DateTime _startTime;
        private int _maxTickets;
        private decimal _adultTicketPrice;
        private decimal _childTicketPrice;

        public Event(int EventID)
        {
            this.EventID = EventID;
        }

        public int EventID { get => _eventID; set => _eventID = value; }
        public string EventTitle { get => _eventTitle; set => _eventTitle = value; }
        public string EventDescription { get => _eventDescription; set => _eventDescription = value; }
        public decimal AdultTicketPrice { get => _adultTicketPrice; set => _adultTicketPrice = value; }
        public decimal ChildTicketPrice { get => _childTicketPrice; set => _childTicketPrice = value; }
        internal Venue Venue { get => _venue; set => _venue = value; }
        public DateTime StartDate { get => _startDate; set => _startDate = value; }
        public DateTime StartTime { get => _startTime; set => _startTime = value; }
        public int MaxTickets { get => _maxTickets; set => _maxTickets = value; }

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

        public void AddDetails(TextBox txtTitle, TextBox txtDesc, DateTimePicker dtpDate, DateTimePicker dtpTime, NumericUpDown nudMaxTix, NumericUpDown nudChildTktPrice, NumericUpDown nudAdultTKtPrice)
        {
            EventTitle = txtTitle.Text;
            EventDescription = txtDesc.Text;
            StartDate = new DateTime(dtpDate.Value.Date.Ticks);
            StartTime = new DateTime(dtpTime.Value.Date.Ticks);
            MaxTickets = Convert.ToInt32(nudMaxTix.Value);
            ChildTicketPrice = nudChildTktPrice.Value;
            AdultTicketPrice = nudAdultTKtPrice.Value;
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
                    String sqlInsert = "INSERT INTO EVENTS(EVENT_ID,VENUE_ID,TITLE,DESCRIPTION,START_TIME,END_TIME,MAX_TICKETS,ADULT_PRICE,CHILD_PRICE) VALUES(:EVENT_ID, :VENUE_ID, :TITLE, :DESCRIPTION, :START_TIME, :END_TIME, :MAX_TICKETS, :ADULT_PRICE, :CHILD_PRICE)";

                    // PREPARE SQL STATEMENT
                    OracleCommand command = new OracleCommand(sqlInsert, conn);

                    command.Parameters.Add("EVENT_ID", EventID);
                    command.Parameters.Add("VENUE_ID", Venue.Id);
                    command.Parameters.Add("TITLE", EventTitle);
                    command.Parameters.Add("DESCRIPTION", EventDescription);
                    command.Parameters.Add("EVENT_DATE", StartDate);
                    command.Parameters.Add("SCHEDULE_TIME", StartTime);
                    command.Parameters.Add("MAX_TICKETS", MaxTickets);
                    command.Parameters.Add("ADULT_PRICE", AdultTicketPrice);
                    command.Parameters.Add("CHILD_PRICE", ChildTicketPrice);
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
                        EventID = Convert.ToInt32(reader.GetString("EVENT_ID"));
                        Venue = new Venue(Convert.ToInt32(reader.GetString("EVENT_ID")));
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
                    Venue.GetVenueDetails();
                }
            }
        }

        public void FillEventDetails(TextBox txtEventID, TextBox txtDescription, DateTimePicker dtpStartDate, DateTimePicker dtpStartTime, NumericUpDown nudAvailableTickets, NumericUpDown nudChildTktPrice, NumericUpDown nudAdultTicketPrice)
        {
            txtEventID.Text = EventID.ToString();
            txtDescription.Text = EventDescription;
            dtpStartDate.Value = dtpStartDate.Value;
            dtpStartTime.Value = dtpStartTime.Value;
            nudAvailableTickets.Value = MaxTickets;
            nudChildTktPrice.Value = ChildTicketPrice;
            nudAdultTicketPrice.Value = AdultTicketPrice;
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

        public static void Event_DateTimePickerProperies(DateTimePicker dtpTime)
        {
            dtpTime.Format = DateTimePickerFormat.Custom;
            dtpTime.CustomFormat = "HH:mm tt";
            dtpTime.ShowUpDown = false;
        }
    }
}