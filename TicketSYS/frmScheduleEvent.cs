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
        private Event _Event = new Event(Event.GetNextEventID());

        internal Event Event { get => _Event; set => _Event = value; }

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
                Event.Venue = new Venue(Convert.ToInt32(cboVenue.SelectedItem.ToString().Substring(0, 3)));
                Event.Venue.FillVenueDetails(txtVenueID, txtName, txtStreet1, txtStreet2, txtCity, txtCounty, txtEircode, txtMaxCap, txtContact, txtPhone, txtFee);
            }
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            Event.AddDetails(txtTitle,txtDesc, dtpDate, dtpTime, nudMaxTix, nudChildTktPrice, nudAdultTktPrice);
            Event.AddEvent();
            MessageBox.Show("Event Successfully Added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Utilities.ResetFormControls(this);
        }

        private void frmScheduleEvent_Loader(object sender, EventArgs e)
        {
            Venue.CboVenue_LoadVenues(cboVenue);
            Event = new Event(Event.GetNextEventID());
            txtEventID.Text = Event.EventID.ToString();

            this.cboVenue.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cboVenue.AutoCompleteSource = AutoCompleteSource.ListItems;
            nudMaxTix.Controls.RemoveAt(0);
            nudChildTktPrice.Controls.RemoveAt(0);
            nudAdultTktPrice.Controls.RemoveAt(0);
        }
    }
}
