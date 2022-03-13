using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace TicketSYS
{
    public partial class frmUpdateVenue : Form
    {
        frmMainMenu parent;
        private Venue venue;
        public frmUpdateVenue(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void frmUpdateVenues_Load(object sender, EventArgs e)
        {
            setFormProperies();
        }

        private void cboVenue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboVenue.SelectedItem.ToString().Length > 0)
            {
                venue = new Venue(Convert.ToInt32(cboVenue.SelectedItem.ToString().Substring(0, 3)));
                // GET VENUE DETAILS FROM DATABASE
                venue.GetVenueDetails();
                // FILL FORM DETAILS & MAKING DETAILS VISIBLE
                venue.FillVenueDetails(txtVenueID, txtName, txtStreet1, txtStreet2, txtCity, cboCounty, txtEircode, nudCapacity, txtContact, txtPhone, nudFee);
            }
        }

        private void btnUpdateVenue_Click(object sender, EventArgs e)
        { 
            venue.SetVenueDetails(txtName.Text, txtStreet1.Text, txtStreet2.Text, txtCity.Text, cboCounty.SelectedItem.ToString(), txtEircode.Text, Convert.ToInt32(nudCapacity.Value), txtPhone.Text, txtContact.Text, Convert.ToDouble(nudFee.Value));
            venue.UpdateVenue();
            frmUpdateVenue_ResetForm();
        }

        private void setFormProperies()
        {
            cboVenue.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboVenue.AutoCompleteSource = AutoCompleteSource.ListItems;
            Utilities.ResetFormControls(this);
            Venue.CboVenue_LoadVenues(cboVenue);
            // Venue.CboVenue_LoadFilter(cboCounty, cboFtCity);
            nudCapacity.Controls.RemoveAt(0);
        }

        private void frmUpdateVenue_ResetForm()
        {
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

            grpVenue.Visible = false;
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
