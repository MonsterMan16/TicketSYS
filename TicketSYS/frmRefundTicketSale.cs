using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TicketSYS
{
    public partial class frmRefundTicketSale : Form
    {
        frmMainMenu parent;
        private DateTime currentDate = System.DateTime.Now;
        public frmRefundTicketSale(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void exitToolStripMnuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
            //parent.Visible();
        }

        private void frmDeleteSale_Load(object sender, EventArgs e)
        {

        }

        private void frmDeleteSale_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (parent.Visible == false)
            {
                parent.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cboVenue.SelectedItem != null & cboEvent.SelectedItem != null)
            {
                if(cboEvent.SelectedItem.ToString().Contains("Michael Jackson"))
                {
                    cboTicketID.Items.Clear();
                    cboTicketID.Items.Add("");
                    cboTicketID.Items.Add("1 | Keelan McCarthy");
                } else if(cboEvent.SelectedItem.ToString().Contains("Walking on Cars"))
                {
                    cboTicketID.Items.Clear();
                    cboTicketID.Items.Add("");
                    cboTicketID.Items.Add("1 | Catherine Woods");
                } else
                {
                    cboTicketID.Items.Clear();
                }
            }
        }

        private void cboVenue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboVenue.SelectedItem != null)
            {
                if (cboVenue.SelectedItem.ToString().Contains("3Arena"))
                {
                    cboEvent.Items.Clear();
                    cboEvent.Items.Add("");
                    cboEvent.Items.Add("Michael Jackson");
                }
                else if (cboVenue.SelectedItem.ToString().Contains("Aviva Stadium"))
                {
                    cboEvent.Items.Clear();
                    cboEvent.Items.Add("");
                    cboEvent.Items.Add("Walking on Cars");
                }
            }
            else
            {
                MessageBox.Show(this, "You need to select an Venue to filter first....", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEvent.SelectedItem.ToString().Contains("Michael Jackson"))
            {
                txtVenueID.Text = "1";
                txtVenue.Text = "3Arena";
                txtStreet.Text = "3Arena, N Wall Quay, North Dock";
                txtCity.Text = "Dublin, 1";
                txtEircode.Text = "D01 EW90";
                txtVdMaxCap.Text = Convert.ToString(13_000);

                txtEventID.Text = "1";
                txtTitle.Text = "Michael Jackson";
                txtDescription.Text = "Michael Jackson, the return of a legend";

                dtpDate.Value = new DateTime(2023, 6, 14, currentDate.Hour, currentDate.Minute, currentDate.Second);
                dtpTime.Value = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 20, 30, 00);

                txtAvailTix.Text = "12500";
                txtChildTktPrice.Text = "27.50";
                txtAdultTktPrice.Text = "45.00";
            }
            else if (cboEvent.SelectedItem.ToString().Contains("Walking on Cars"))
            {
                txtVenueID.Text = "2";
                txtVenue.Text = "Aviva Stadium";


                txtStreet.Text = "Aviva Stadium, Lansdowne Rd";
                txtCity.Text = "Dublin 4";
                txtEircode.Text = "D04 K5F9";
                txtVdMaxCap.Text = Convert.ToString(51_700);

                txtEventID.Text = "1";
                txtTitle.Text = "Walking on Cars";
                txtDescription.Text = "Walking on cars, Irish and original";

                dtpDate.Value = new DateTime(2022, 1, 15, currentDate.Hour, currentDate.Minute, currentDate.Second);
                dtpTime.Value = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 18, 30, 00);

                txtAvailTix.Text = "32500";
                txtChildTktPrice.Text = "15.50";
                txtAdultTktPrice.Text = "29.20";
            }
            else
            {
                txtVenueID.Text = "";
                txtVenue.Text = "";


                txtStreet.Text = "";
                txtCity.Text = "";
                txtEircode.Text = "";
                txtVdMaxCap.Text = "";

                txtEventID.Text = "";
                txtTitle.Text = "";
                txtDescription.Text = "";

                dtpDate.Value = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, currentDate.Hour, currentDate.Minute, currentDate.Second);
                dtpTime.Value = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, currentDate.Hour, currentDate.Minute, currentDate.Second);

                txtAvailTix.Text = "";
                txtChildTktPrice.Text = "";
                txtAdultTktPrice.Text = "";
            }
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        private void chkVenueDetails_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVDetails.Checked)
            {
                grpVDetails.Visible = true;
            }
            else if (!chkVDetails.Checked)
            {
                grpVDetails.Visible = false;
            }

            if (!chkEDetails.Checked & !chkVDetails.Checked)
            {
                Size = new Size(829, 1216);
            }
            else
            {
                Size = new Size(1586, 1216);
            }
        }

        private void chkEventDetails_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEDetails.Checked)
            {
                grpEDetails.Visible = true;
            }
            else if (!chkEDetails.Checked)
            {
                grpEDetails.Visible = false;
            }

            if (!chkEDetails.Checked & !chkVDetails.Checked)
            {
                Size = new Size(829, 1216);
            }
            else
            {
                Size = new Size(1586, 1216);
            }
        }

        private void cboTicketID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboEvent.SelectedItem != null)
            {
                if (cboTicketID.SelectedItem.ToString().Contains("Keelan McCarthy"))
                {
                    txtFirstName.Text = "Keelan";
                    txtLastName.Text = "McCarthy";
                    txtEmail.Text = "Keelan.McCarthy@students.ittralee.ie";
                    txtPhoneNum.Text = "0873884688";
                    txtAdultTktQty.Text = "1";
                    txtChildTktQty.Text = "0";
                    txtTotal.Text = "€45.00";

                } else if (cboTicketID.SelectedItem.ToString().Contains("Catherine Woods"))
                {
                    txtFirstName.Text = "Catherine";
                    txtLastName.Text = "Woods";
                    txtEmail.Text = "Catherine.Woods@mtu.ie";
                    txtPhoneNum.Text = "XXXXXXXXXX";
                    txtAdultTktQty.Text = "2";
                    txtChildTktQty.Text = "1";
                    txtTotal.Text = Convert.ToString(Int16.Parse(txtAdultTktQty.Text) * (decimal)double.Parse(txtAdultTktPrice.Text) + Int16.Parse(txtChildTktQty.Text) * (decimal)double.Parse(txtChildTktPrice.Text));
                } else
                {
                    txtFirstName.Text = "";
                    txtLastName.Text = "";
                    txtEmail.Text = "";
                    txtPhoneNum.Text = "";
                    txtAdultTktQty.Text = "0";
                    txtChildTktQty.Text = "0";
                    txtTotal.Text = "€73.90";
                }
            }
        }

        private void lblAdultTktPrice_Click(object sender, EventArgs e)
        {

        }

        private void btnRefundSale_Click(object sender, EventArgs e)
        {
            if(cboTicketID.SelectedItem != null)
            {
                MessageBox.Show(this, "Purchase Successful", "Sucess", MessageBoxButtons.OK);
            } else
            {
                MessageBox.Show(this, "You need to select a Ticket first...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboEvent.Items.Clear();
                cboVenue.SelectedIndex = 0;
                cboTicketID.Items.Clear();
                txtVenueID.Text = "";
                txtVenue.Text = "";


                txtStreet.Text = "";
                txtCity.Text = "";
                txtEircode.Text = "";
                txtVdMaxCap.Text = "";

                txtEventID.Text = "";
                txtTitle.Text = "";
                txtDescription.Text = "";

                dtpDate.Value = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, currentDate.Hour, currentDate.Minute, currentDate.Second);
                dtpTime.Value = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, currentDate.Hour, currentDate.Minute, currentDate.Second);

                txtAvailTix.Text = "";
                txtChildTktPrice.Text = "";
                txtAdultTktPrice.Text = "";

                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtEmail.Text = "";
                txtPhoneNum.Text = "";
                txtAdultTktQty.Text = "";
                txtChildTktQty.Text = "";

                txtTotal.Text = "0.00";

            }
        }

        private void lblEventDetails_Click(object sender, EventArgs e)
        {

        }
    }
}
