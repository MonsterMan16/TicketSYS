using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TicketSYS
{
    public partial class frmUpdateEvent : Form
    {
        frmMainMenu parent;
        Event _event;

        internal Event Event { get => _event; set => _event = value; }

        public frmUpdateEvent(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void exitToolStripMnuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void frmUpdateEvent_Load(object sender, EventArgs e)
        {
            Event.CboEvent_LoadEvents(cboEvent);
            Event.Event_DateTimePickerProperies(dtpDate, dtpTime);
        }

        private void frmUpdateEvent_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (parent.Visible == false)
            {
                parent.Show();
            }
        }

        private void chkDetails_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDetails.Checked == true)
            {
                Size = new Size(1577, 1217);
                grpUpdateEvent.Size = new Size(1496, 1062);
                grpVenueDetails.Visible = true;
            }
            else if (chkDetails.Checked == false)
            {
                Size = new Size(869, 1217);
                grpUpdateEvent.Size = new Size(789, 1062);
                grpVenueDetails.Visible = false;
            }
        }

        private void cboEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEvent.SelectedItem.ToString().Length > 0)
            {
                Event = new Event(Convert.ToInt32(cboEvent.SelectedItem.ToString().Substring(0, 3)));
                // GET VENUE DETAILS FROM DATABASE
                Event.GetEventDetails();
                // FILL FORM DETAILS & MAKING DETAILS VISIBLE
                _event.FillEventDetails(txtEventID, txtDescription, dtpDate, dtpTime, nudAvailTix, nudChildTktPrice, nudAdultTktPrice);
                Event.aVenue.FillVenueDetails(txtVenueID, txtVdVenue, txtStreet1, txtStreet2, txtCity, txtEircode, txtCounty, txtMaxCap, txtContact, txtPhone, txtFee);
            }
        }
    }
}
