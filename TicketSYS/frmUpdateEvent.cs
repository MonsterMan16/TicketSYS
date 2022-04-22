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
            Venue.CboVenue_LoadVenues(cboVenue);
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
                _event = new Event(Convert.ToInt32(cboEvent.SelectedItem.ToString().Substring(0, 3)));
                // GET VENUE DETAILS FROM DATABASE
                _event.GetEventDetails();
                // FILL FORM DETAILS & MAKING DETAILS VISIBLE
                _event.FillEventDetails(txtEventID, txtTitle, txtDescription, cboVenue, dtpDate, dtpTime, nudAvailTix, nudChildTktPrice, nudAdultTktPrice);
                _event.aVenue.FillVenueDetails(txtVenueID, txtVdVenue, txtStreet1, txtStreet2, txtCity, txtEircode, txtCounty, txtMaxCap, txtContact, txtPhone, txtFee);
            }
        }

        private void btnUpdateEvent_Click(object sender, EventArgs e)
        {
            _event.AddEventDetails(txtEventID, txtTitle, txtDescription, dtpDate, dtpTime, nudAvailTix, nudChildTktPrice, nudAdultTktPrice);
            _event.UpdateEvent();
        }
    }
}
