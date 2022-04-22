using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace TicketSYS
{
    class Sale
    {
        private Event _aEvent;
        private int _id;
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _phone;
        private int _adultQty;
        private int _childQty;
        private decimal _total;
        private char _status;

        internal Event aEvent { get => _aEvent; set => _aEvent = value; }

        public Sale()
        {
            _aEvent = new Event();
            _id = 0;
            _firstName = "";
            _lastName = "";
            _email = "";
            _adultQty = 0;
            _childQty = 0;
            _total = 0;
            _status = 'S';
        }

        public void AddSaleDetails(TextBox txtSaleID,TextBox txtFirstName, TextBox txtLastName, TextBox txtEmail, TextBox txtPhoneNum, NumericUpDown nudAdultQty, NumericUpDown nudChildQty, TextBox txtTotal)
        {
            _id = Convert.ToInt32(txtSaleID.Text);
            _firstName = txtFirstName.Text;
            _lastName = txtLastName.Text;
            _email = txtEmail.Text;
            _phone = txtPhoneNum.Text;
            _adultQty = Convert.ToInt32(nudAdultQty.Value);
            _childQty = Convert.ToInt32(nudChildQty.Value);
            _total = CalculateTotal(nudAdultQty, nudChildQty);
        }

        public int GetNextSaleID()
        {
            // OPEN DB CONNECTION
            OracleConnection conn = new OracleConnection(DBConnect.getOradb());
            conn.Open();
            //DEFINE THE SQL QUERY TO BE EXECUTED
            String sqlQuery = "SELECT NVL(MAX(SALE_ID),0) FROM SALES WHERE EVENT_ID = :EVENT_ID";
            OracleCommand command = new OracleCommand(sqlQuery, conn);

            command.Parameters.Add("EVENT_ID", _aEvent.EventID);

            command.Prepare();
            // EXECUTE THE SQL QUERY
            int count = Convert.ToInt32(command.ExecuteScalar());
            return ++count;
        }

        public void AddSale()
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.getOradb()))
            {
                try
                {
                    // OPEN DB CONNECTION
                    conn.Open();


                    // DEFINE THE SQL STATEMENT
                    String sqlInsert = "INSERT INTO SALES(SALE_ID,EVENT_ID,FIRST_NAME,LAST_NAME,EMAIL,PHONE,ADULT_QTY,CHILD_QTY,SALE_TOTAL,SALE_DATE,STATUS) VALUES(:SALE_ID, :EVENT_ID, :FIRST_NAME, :LAST_NAME, :EMAIL, :PHONE, :ADULT_QTY, :CHILD_QTY, :SALE_TOTAL, TO_DATE(:SALE_DATE,'YYYY-MM-DD HH24:MI:SS'), :STATUS)";

                    // PREPARE SQL STATEMENT
                    OracleCommand command = new OracleCommand(sqlInsert, conn);

                    command.Parameters.Add("SALE_ID", _id);
                    command.Parameters.Add("EVENT_ID", _aEvent.EventID);
                    command.Parameters.Add("FIRST_NAME", _firstName);
                    command.Parameters.Add("LAST_NAME", _lastName);
                    command.Parameters.Add("EMAIL", _email);
                    command.Parameters.Add("PHONE", _phone);
                    command.Parameters.Add("ADULT_QTY", _adultQty);
                    command.Parameters.Add("CHILD_QTY", _childQty);
                    command.Parameters.Add("SALE_TOTAL", _total);
                    command.Parameters.Add("SALE_DATE", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                    command.Parameters.Add("STATUS", _status);
                    command.Prepare();
                    // EXECUTE SQL STATEMENT

                    command.ExecuteNonQuery();


                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.ToString());
                }
                finally
                {
                    // CLOSE CONNECTION
                    conn.Close();
                }
            }
        }


        public static DataSet GetSales()
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

        public void GetSaleDetails()
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.getOradb()))
            {
                // DEFINE SQL STATEMENT
                String sqlQuery = "SELECT SALE_ID, EVENT_ID, FIRST_NAME, LAST_NAME, EMAIL, PHONE, ADULT_QTY, CHILD_QTY, SALE_TOTAL FROM SALES WHERE SALE_ID = :SALE_ID";
                // PREPARE SQL STATEMENT
                OracleCommand command = new OracleCommand(sqlQuery, conn);
                // OPEN DB CONNECTION
                conn.Open();
                command.Parameters.Add("SALE_ID", _id);
                command.Prepare();

                OracleDataReader reader = command.ExecuteReader();


                try
                {
                    while (reader.Read())
                    {
                        _id = reader.GetInt32("SALE_ID");
                        _aEvent = new Event(reader.GetInt32("EVENT_ID"));
                        _aEvent.GetEventDetails();
                        _firstName = reader.GetString("FIRST_NAME");
                        _lastName = reader.GetString("LAST_NAME");
                        _email = reader.GetString("EMAIL");
                        _phone = reader.GetString("PHONE");
                        _adultQty = reader.GetInt32("ADULT_QTY");
                        _childQty = reader.GetInt32("CHILD_QTY");
                        _total = reader.GetDecimal("TOTAL");
                    }
                }
                finally
                {
                    reader.Close();
                }
            }
        }

        //public void FillSaleDetails(TextBox txtEventID, TextBox txtEventTitle, TextBox txtDescription, DateTimePicker dtpStartDate, DateTimePicker dtpStartTime, NumericUpDown nudAvailableTickets, NumericUpDown nudChildTktPrice, NumericUpDown nudAdultTicketPrice)
        //{
        //    txtEventID.Text = _id.ToString("000");
        //    txtEventTitle.Text = _title;
        //    txtDescription.Text = _description;
        //    dtpStartDate.Value = _date;
        //    dtpStartTime.Value = _time;
        //    nudAvailableTickets.Value = _maxTix;
        //    nudChildTktPrice.Value = _childPrice;
        //    nudAdultTicketPrice.Value = _adultPrice;
        //}

        //public void FillSaleDetails(TextBox txtEventID, TextBox txtEventTitle, TextBox txtDescription, ComboBox cboVenue, DateTimePicker dtpStartDate, DateTimePicker dtpStartTime, NumericUpDown nudAvailableTickets, NumericUpDown nudChildTktPrice, NumericUpDown nudAdultTicketPrice)
        //{
        //    txtEventID.Text = _id.ToString("000");
        //    txtEventTitle.Text = _title;
        //    txtDescription.Text = _description;
        //    cboVenue.SelectedIndex = cboVenue.Items.IndexOf(_aVenue.Id.ToString("000") + " " + (_aVenue.Name));
        //    dtpStartDate.Value = _date;
        //    dtpStartTime.Value = _time;
        //    nudAvailableTickets.Value = _maxTix;
        //    nudChildTktPrice.Value = _childPrice;
        //    nudAdultTicketPrice.Value = _adultPrice;
        //}

        //public void FillSaleDetails(TextBox txtEventID, TextBox txtEventTitle, TextBox txtDescription, TextBox txtDate, TextBox txtTime, TextBox txtAvailableTickets, TextBox txtChildPrice, TextBox txtAdultPrice)
        //{
        //    txtEventID.Text = _id.ToString("000");
        //    txtEventTitle.Text = _title;
        //    txtDescription.Text = _description;
        //    txtDate.Text = _date.ToString("dd/MM/yy");
        //    txtTime.Text = _time.ToString("HH:mm");
        //    txtAvailableTickets.Text = _maxTix.ToString();
        //    txtChildPrice.Text = _childPrice.ToString();
        //    txtAdultPrice.Text = _adultPrice.ToString();
        //}

        public static void CboSales_LoadSales(ComboBox combo)
        {
            DataSet ds = GetSales();
            combo.Items.Clear();
            combo.Items.Add("");

            for (int i = 0; i < ds.Tables["Events"].Rows.Count; i++)
                combo.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') + " " +
                ds.Tables[0].Rows[i][1].ToString());
            combo.SelectedIndex = 0;
        }

        public decimal CalculateTotal(NumericUpDown nudAdultQty, NumericUpDown nudChildQty) 
        {
            return ((nudAdultQty.Value * _aEvent.AdultPrice) + (nudChildQty.Value * _aEvent.ChildPrice));
        }
    }
}
