using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TicketSYS
{
    public partial class frmProcessTicketSale : Form
    {
        frmMainMenu parent;

        Sale _aSale = new Sale();
        public frmProcessTicketSale(frmMainMenu Parent)
        {
            InitializeComponent();
            this.parent = Parent;
        }

        private void exitToolStripMnuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void frmCreateSale_Load(object sender, EventArgs e)
        {
            Venue.CboVenue_LoadVenues(cboVenue);
            Event.CboEvent_LoadEvents(cboEvent);
        }


        private void frmCreateSale_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(parent.Visible == false)
            {
                parent.Show();
            }
        }


        private void chkVenueDetails_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVDetails.Checked == true)
            {
            }
            else if (chkVDetails.Checked == false)
            {
            }

            if (!chkEDetails.Checked & !chkVDetails.Checked)
            {
                Size = new Size(792, 1202);
            }
            else
            {
                Size = new Size(1549, 1202);
            }
        }

        private void chkEDetails_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEDetails.Checked)
            {
                grpEDetails.Visible = true;
            }
            else if (!chkEDetails.Checked)
            {
                grpEDetails.Visible = false;
            }

            if(!chkEDetails.Checked & !chkVDetails.Checked)
            {
                Size = new Size(792, 1202);
            } else
            {
                Size = new Size(1549, 1202);
            }
        }

        private void cboEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboEvent.SelectedItem.ToString() != "")
            {
                _aSale = new Sale();
                _aSale.aEvent.EventID = Convert.ToInt32(cboEvent.SelectedItem.ToString().Substring(0, 3));
                _aSale.aEvent.GetEventDetails();
                _aSale.aEvent.FillEventDetails(txtEventID, txtTitle, txtDescription, txtDate, txtTime, txtMaxTix, txtChildPrice, txtAdultPrice);
                _aSale.aEvent.aVenue.FillVenueDetails(txtVenueID, txtVdVenue, txtStreet1, txtStreet2, txtCity, txtEircode, txtCounty, txtMaxCap, txtContact, txtPhone, txtFee);
                txtSaleID.Text = _aSale.GetNextSaleID().ToString("000");
            }
        }

        private void btnCreateSale_Click(object sender, EventArgs e)
        {
            _aSale.AddSaleDetails(txtSaleID, txtFirstName, txtLastName, txtEmail, txtPhone, nudAdultQty, nudChildQty, txtTotal);
            _aSale.AddSale();
            Utilities.ResetAllControls(this);
        }

        private void nudAdultQty_ValueChanged(object sender, EventArgs e)
        {
            txtTotal.Text = "€" + _aSale.CalculateTotal(nudAdultQty, nudChildQty).ToString();
        }

        private void nudChildQty_ValueChanged(object sender, EventArgs e)
        {
            txtTotal.Text = "€" + _aSale.CalculateTotal(nudAdultQty, nudChildQty).ToString();
        }
    }
}
