using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TicketSYS
{
    public partial class frmAddVenue : Form
    {
        frmMainMenu parent;
        public frmAddVenue(frmMainMenu Parent)
        {
            InitializeComponent();
            this.parent = Parent;
        }

        private void frmCreateVenue_Load(object sender, EventArgs e)
        {
            txtVenueID.Text = Venue.GetNextVenueID().ToString("000");
        }

        private void btnAddVenue_Click(object sender, EventArgs e)
        {
            // Validate Data


            // ADD VENUE
            Venue aVenue = new Venue(Convert.ToInt32(txtVenueID.Text), txtName.Text, txtAddress1.Text, txtAddress2.Text, txtCity.Text, txtEircode.Text,
                cboCounty.Text, Convert.ToInt32(nudCapacity.Value), txtContact.Text, txtPhone.Text, nudFee.Value, 'O');
            aVenue.InsertVenue();
            // Display Confirmation Message

            // Reset User Interface
            frmCreateVenue_Reset();
        }

        private void exitToolStripMnuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void frmCreateVenue_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (parent.Visible == false)
            {
                parent.Show();
            }
        }

        private void frmCreateVenue_Reset()
        {
            Utilities.ResetFormControls(grpAddVenue);
            txtVenueID.Text = Venue.GetNextVenueID().ToString("000");
            txtName.Focus();
        }
    }
}
