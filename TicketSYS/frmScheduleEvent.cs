using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TicketSYS
{
    public partial class frmScheduleEvent : Form
    {
        frmMainMenu parent;
        private Venue _aVenue = new Venue();
        private Event _aEvent = new Event();


        public frmScheduleEvent(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void exitToolStripMnuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }


        private void frmCreateEvent_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (parent.Visible == false)
            {
                parent.Show();
            }
        }

        private void chkVenueDetails_CheckedChanged(object sender, EventArgs e)
        {
            if(chkDetails.Checked == true)
            {
                Size = new Size(1577, 987);
                grpScheduleEvent.Size = new Size(1496, 827);
                grpVenueDetails.Visible = true;
            } else if(chkDetails.Checked == false)
            {
                Size = new Size(869, 987);
                grpScheduleEvent.Size = new Size(789, 827);
                grpVenueDetails.Visible = false;
            }
        }


        private void cboVenue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboVenue.SelectedItem.ToString().Length > 0 && cboVenue.Items.Count > 1)
            {
                _aEvent.aVenue = new Venue();
                _aEvent.aVenue.GetVenueDetails(Convert.ToInt32(cboVenue.SelectedItem.ToString().Substring(0, 3)));
                _aEvent.aVenue.FillVenueDetails(txtVenueID, txtName, txtStreet1, txtStreet2, txtCity, txtCounty, txtEircode, txtMaxCap, txtContact, txtPhone, txtFee);
            }
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            _aEvent.AddEventDetails(txtEventID, txtTitle, txtDesc, dtpDate, dtpTime, nudAvailTix, nudAdultTktPrice, nudChildTktPrice);
            _aEvent.AddEvent();
            Utilities.ResetFormControls(this);
        }

        private void frmScheduleEvent_Loader(object sender, EventArgs e)
        {
            Venue.CboVenue_LoadVenues(cboVenue);
            txtEventID.Text = Event.GetNextEventID().ToString();

            
            
        }
    }
}
