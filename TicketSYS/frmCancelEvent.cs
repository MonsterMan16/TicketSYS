using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TicketSYS
{
    public partial class frmCancelEvent : Form
    {

        frmMainMenu parent;
        private Event _event;
        public frmCancelEvent(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void exitToolStripMnuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }


        private void frmDeleteEvent_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (parent.Visible == false)
            {
                parent.Show();
            }
        }


        private void chkDetail_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDetails.Checked == true)
            {
                Size = new Size(1611, 1246);
                grpCancelEvent.Size = new Size(1521, 1079);
                grpVenueDetails.Visible = true;
            }
            else if (chkDetails.Checked == false)
            {
                Size = new Size(856, 1246);
                grpCancelEvent.Size = new Size(770, 1079);
                grpVenueDetails.Visible = false;
            }
        }

        private void frmCancelEvent_Load(object sender, EventArgs e)
        {
            Event.CboEvent_LoadEvents(cboEvent);
        }

        private void cboEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEvent.SelectedItem.ToString().Length > 0)
            {
                _event = new Event(Convert.ToInt32(cboEvent.SelectedItem.ToString().Substring(0, 3)));
                // GET VENUE DETAILS FROM DATABASE
                _event.GetEventDetails();
                // FILL FORM DETAILS & MAKING DETAILS VISIBLE
                _event.FillEventDetails(txtEventID, txtTitle, txtDescription, txtDate, txtTime, txtMaxTix, txtChildPrice, txtAdultPrice);
                _event.aVenue.FillVenueDetails(txtVenueID, txtVdVenue, txtStreet1, txtStreet2, txtCity, txtEircode, txtCounty, txtMaxCap, txtContact, txtPhone, txtFee);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _event.UpdateEvent('C');

        }
    }
}
