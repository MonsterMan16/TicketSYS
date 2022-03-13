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
        private DateTime currentDate = DateTime.Now;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {

            if (cboVenue.SelectedIndex.ToString() != "")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel this event??", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show(this, "Venue Closed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtVenueID.Text = "";
                    txtEventID.Text = "";
                    cboEvent.Items.Remove(cboEvent.SelectedItem);
                    txtCity.Text = "";
                    txtStreet.Text = "";
                    txtEircode.Text = "";
                    txtMaxCap.Text = "";
                    txtDescription.Text = "";
                    txtVdVenue.Text = "";

                    dtpDate.Value = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, currentDate.Hour, currentDate.Minute, currentDate.Second);
                    dtpTime.Value = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, currentDate.Hour, currentDate.Minute, currentDate.Second);

                    txtAvailTix.Text = "0";
                    txtChildTktPrice.Text = "0.00";
                    txtAdultTktPrice.Text = "0.00";
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show(this, "Cancelled Close Venue", "Cancel Close Venue", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(this, "A Venue must be selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboEvent_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboEvent.SelectedItem.ToString() == "1 | Micheal Jackson")
            {
                txtEventID.Text = "1";
                txtVenueID.Text = "1";
                txtVdVenue.Text = "1  |  3Arena";
                txtStreet.Text = "3Arena, N Wall Quay, North Dock";
                txtCity.Text = "Dublin, 1";
                txtEircode.Text = "D01 EW90";
                txtMaxCap.Text = Convert.ToString(13_000);


                txtDescription.Text = "Michael Jackson, the return of a legend";

                dtpDate.Value = new DateTime(2023, 6, 14, currentDate.Hour, currentDate.Minute, currentDate.Second);
                dtpTime.Value = new DateTime(2022, currentDate.Month, currentDate.Day, 20, 30, 00);

                txtAvailTix.Text = "12_500";
                txtChildTktPrice.Text = "25.00";
                txtAdultTktPrice.Text = "45.00";
            }
            else if (cboEvent.SelectedItem.ToString() == "2 | Walking on Cars")
            {
                txtEventID.Text = "2";
                txtVenueID.Text = "2";
                txtVdVenue.Text = "2  |  Aviva Stadium";
                txtStreet.Text = "Aviva Stadium, Lansdowne Rd";
                txtCity.Text = "Dublin 4";
                txtEircode.Text = "D04 K5F9";
                txtMaxCap.Text = Convert.ToString(51_700);



                txtDescription.Text = "Michael Jackson, the return of a legend";

                DateTime date = new DateTime(2023, 6, 14, currentDate.Hour, currentDate.Minute, currentDate.Second);
                DateTime time = new DateTime(2022, currentDate.Month, currentDate.Day, 20, 30, 00);
                dtpDate.Value = date;
                dtpTime.Value = time;

                txtAvailTix.Text = "32_500";
                txtChildTktPrice.Text = "15.50";
                txtAdultTktPrice.Text = "29.20";
            }
            else
            {
                txtEventID.Text = "";
                txtVenueID.Text = "";
                txtVdVenue.Text = "";
                txtStreet.Text = "";
                txtCity.Text = "";
                txtEircode.Text = "";
                txtMaxCap.Text = "";

                txtDescription.Text = "";

                dtpDate.Value = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, currentDate.Hour, currentDate.Minute, currentDate.Second);
                dtpTime.Value = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, currentDate.Hour, currentDate.Minute, currentDate.Second);

                txtAvailTix.Text = "0";
                txtChildTktPrice.Text = "0.00";
                txtAdultTktPrice.Text = "0.00";
            }
        }

        private void frmCancelEvent_Load(object sender, EventArgs e)
        {
            cboVenue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cboVenue.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboVenue.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cboEvent.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboEvent.AutoCompleteSource = AutoCompleteSource.ListItems;
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
    }
}
