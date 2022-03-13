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
        private int ticketID = 1;
        private DateTime currentDate = DateTime.Now;
        private DateTime date;
        private DateTime time;
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
            cboVenue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cboVenue.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboVenue.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cboEvent.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboEvent.AutoCompleteSource = AutoCompleteSource.ListItems;
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "dd/MM/yy";
            dtpTime.Format = DateTimePickerFormat.Time;
            dtpTime.ShowUpDown = true;
            nudTotal.Controls.RemoveAt(0);
        }

        private void mnuMainMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmCreateSale_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(parent.Visible == false)
            {
                parent.Show();
            }
        }

        private void txtTicketID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTicketID_Click(object sender, EventArgs e)
        {

        }

        private void lblEvent_Click(object sender, EventArgs e)
        {

        }

        private void cboEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboEvent.SelectedItem.ToString().Contains("Michael Jackson"))
            {
                ticketID = 1;
                txtTicketID.Text = Convert.ToString(ticketID);
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
            } else if(cboEvent.SelectedItem.ToString().Contains("Walking on Cars"))
            {
                txtTicketID.Text = "1";
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
            } else 
            {
                txtTicketID.Text = "";
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

        private void lblVenueDetails_Click(object sender, EventArgs e)
        {

        }

        private void chkVenueDetails_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVDetails.Checked == true)
            {
                grpVDetails.Visible = true;
            }
            else if (chkVDetails.Checked == false)
            {
                grpVDetails.Visible = false;
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

        private void cboVenue_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboEvent.Items.Clear();
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

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void lblAvailTix_Click(object sender, EventArgs e)
        {

        }

        private void txtAvailTix_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpEDetails_Enter(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if(cboVenue.SelectedItem != null)
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
        }

        private void btnCreateSale_Click(object sender, EventArgs e)
        {
            if(cboVenue.SelectedItem != null & cboEvent.SelectedItem != null)
            {
                if (cboEvent.SelectedItem.ToString() != "" & txtFirstName.Text != "" & txtLastName.Text != "" & txtEmail.Text != "" & txtPhoneNum.Text != "" & (nudAdultTktQty.Value > 0 | nudChildTktQty.Value > 0))
                {
                    MessageBox.Show(this, "Purchase Successful", "Sucess", MessageBoxButtons.OK);
                    ticketID += 1;
                    txtAvailTix.Text = Convert.ToString(int.Parse(txtAvailTix.Text) - 1);
                    txtTicketID.Text = Convert.ToString(ticketID);

                    dtpDate.Value = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, currentDate.Hour, currentDate.Minute, currentDate.Second);
                    dtpTime.Value = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, currentDate.Hour, currentDate.Minute, currentDate.Second);


                    txtFirstName.Text = "";
                    txtLastName.Text = "";
                    txtEmail.Text = "";
                    txtPhoneNum.Text = "";
                    nudAdultTktQty.Value = 0;
                    nudChildTktQty.Value = 0;

                    nudTotal.Value = 0.00m;

                }
                else
                {
                    MessageBox.Show(this, "All form fields must be filled in!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(this, "You need to select an Venue & Event first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nudAdultTktQty_ValueChanged(object sender, EventArgs e)
        {
            if (cboVenue.SelectedItem != null & cboEvent.SelectedItem != null)
            {
                nudTotal.Value = (nudAdultTktQty.Value * (decimal)double.Parse(txtAdultTktPrice.Text)) + (nudChildTktQty.Value * (decimal)float.Parse(txtChildTktPrice.Text));
            }
        }

        private void nudChildTktQty_ValueChanged(object sender, EventArgs e)
        {
            if(cboVenue.SelectedItem != null & cboEvent.SelectedItem != null)
            {
                nudTotal.Value = (nudAdultTktQty.Value * (decimal)double.Parse(txtAdultTktPrice.Text)) + (nudChildTktQty.Value * (decimal)float.Parse(txtChildTktPrice.Text));            
            }

        }

        private void grpCreateSale_Enter(object sender, EventArgs e)
        {

        }
    }
}
