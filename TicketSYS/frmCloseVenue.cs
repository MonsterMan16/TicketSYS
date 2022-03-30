using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TicketSYS
{
    public partial class frmCloseVenue : Form
    {
        frmMainMenu parent;
        private Venue _aVenue = new Venue();


        public frmCloseVenue(frmMainMenu Parent)
        {
            InitializeComponent();
            this.parent = Parent;
        }

        private void frmCloseVenue_Load(object sender, EventArgs e)
        {
            this.cboVenue.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cboVenue.AutoCompleteSource = AutoCompleteSource.ListItems;
            Venue.CboVenue_LoadVenues(cboVenue);
        }

        private void frmCloseVenue_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (parent.Visible == false)
            {
                parent.Show();
            }
        }

        private void exitToolStripMnuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void btnCloseVenue_Click(object sender, EventArgs e)
        {
            _aVenue.UpdateVenue('C');
            Utilities.ResetFormControls(this);
        }

        private void cboVenue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboVenue.SelectedItem.ToString().Length > 0)
            {
                _aVenue = new Venue();
                // GET VENUE DETAILS FROM DATABASE
                _aVenue.GetVenueDetails(Convert.ToInt32(cboVenue.SelectedItem.ToString().Substring(0, 3)));
                // FILL FORM DETAILS & MAKING DETAILS VISIBLE
                _aVenue.FillVenueDetails(txtVenueID, txtStreet1, txtStreet2, txtCity, txtEircode, txtCounty, txtCapacity, txtContact, txtPhone, txtFee);
            }
        }
    }
}
