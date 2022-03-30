using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace TicketSYS
{
    public partial class frmUpdateVenue : Form
    {
        frmMainMenu parent;
        private Venue _aVenue;
        public frmUpdateVenue(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void frmUpdateVenues_Load(object sender, EventArgs e)
        {
            Venue.CboVenue_LoadVenues(cboVenue);
        }

        private void cboVenue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboVenue.SelectedItem.ToString().Length > 0)
            {
                _aVenue = new Venue();
                // GET VENUE DETAILS FROM DATABASE
                _aVenue.GetVenueDetails(Convert.ToInt32(cboVenue.SelectedItem.ToString().Substring(0, 3)));
                // FILL FORM DETAILS & MAKING DETAILS VISIBLE
                _aVenue.FillVenueDetails(txtVenueID, txtName, txtStreet1, txtStreet2, txtCity, cboCounty, txtEircode, nudCapacity, txtContact, txtPhone, nudFee);

                grpVenue.Visible = true;

            }
        }

        private void btnUpdateVenue_Click(object sender, EventArgs e)
        { 
            // SET VENUE DETAILS
            _aVenue.SetVenueDetails(txtName.Text, txtStreet1.Text, txtStreet2.Text, txtCity.Text, cboCounty.SelectedItem.ToString(), txtEircode.Text, Convert.ToInt32(nudCapacity.Value), txtPhone.Text, txtContact.Text, nudFee.Value);
            _aVenue.UpdateVenue();
            frmUpdateVenue_ResetForm();
        }


        private void frmUpdateVenue_ResetForm()
        {
            Venue.CboVenue_LoadVenues(cboVenue);

            txtVenueID.Text = String.Empty;
            txtName.Text = String.Empty;
            txtStreet1.Text = String.Empty;
            txtStreet2.Text = String.Empty;
            txtCity.Text = String.Empty;
            cboCounty.SelectedIndex = 0; 
            txtEircode.Text = String.Empty;
            nudCapacity.Value = 500;
            txtPhone.Text = String.Empty;
            txtContact.Text = String.Empty;
            nudFee.Value = (decimal)0.0;

            grpVenue.Visible = true;

        }

        private void exitToolStripMnuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void frmUpdateVenue_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (parent.Visible == false)
            {
                parent.Show();
            }
        }

    }
}
