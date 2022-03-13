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
        private Venue venue = new Venue(Venue.GetNextVenueID());
        public frmAddVenue(frmMainMenu Parent)
        {
            InitializeComponent();
            this.parent = Parent;
        }



        private void frmCreateVenue_Load(object sender, EventArgs e)
        {
            frmCreateVenue_Setup();
        }

        private void btnAddVenue_Click(object sender, EventArgs e)
        {
            // ADD VENUE DETAILS TO VENUE OBJECT
            venue.SetVenueDetails(txtName.Text, txtStreet1.Text, txtStreet2.Text, txtCity.Text, cboCounty.Text, txtEircode.Text, Convert.ToInt32(nudCapacity.Value), txtContact.Text, txtPhone.Text, Convert.ToDouble(nudFee.Value));
            // ADD VENUE
            venue.AddVenue();
            // DISPLAY CONFIRMATION MESSAGE
            MessageBox.Show("Venue successfully added..", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // RESET UI
            frmCreateVenue_Setup();
            //MessageBox.Show("Failed to add Venue", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void frmCreateVenue_Setup()
        {
            Utilities.ResetFormControls(grpAddVenue);
            venue = new Venue(Venue.GetNextVenueID());
            txtVenueID.Text = venue.Id.ToString();
        }
    }
}
