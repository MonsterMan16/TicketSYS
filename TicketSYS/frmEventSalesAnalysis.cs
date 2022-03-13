using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TicketSYS
{
    public partial class frmEventSalesAnalysis : Form
    {
        frmMainMenu parent;
        private DateTime currentDate = DateTime.Now;
        public frmEventSalesAnalysis(frmMainMenu parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void frmEventAnalysis_Load(object sender, EventArgs e)
        {
            picEventSalesAnalysis.SizeMode = PictureBoxSizeMode.StretchImage;
            cboVenue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cboVenue.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboVenue.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cboEvent.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboEvent.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void frmEventAnalysis_FormClosed(object sender, FormClosedEventArgs e)
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
                Size = new Size(807, 1194);
            }
            else
            {
                Size = new Size(1550, 1194);
            }
        }

        private void btnFilterEvent_Click(object sender, EventArgs e)
        {
            if(cboVenue.SelectedItem != null & cboVenue.SelectedItem.ToString() != "")
            {
                if(cboVenue.SelectedItem.ToString().Contains("3Arena"))
                {
                    cboEvent.Items.Clear();
                    cboEvent.Items.Add("");
                    cboEvent.Items.Add("Michael Jackson");
                } else if (cboVenue.SelectedItem.ToString().Contains("Aviva Stadium"))
                {
                    cboEvent.Items.Clear();
                    cboEvent.Items.Add("");
                    cboEvent.Items.Add("Walking on Cars");
                }
            } else
            {
                MessageBox.Show(this, "You need to select an event first...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboEvent_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if(cboEvent.SelectedItem != null) {
                grpAnalysis.Visible = false;
                if(cboEvent.SelectedItem.ToString().Contains("Michael Jackson"))
                {
                    txtVenueID.Text = "1";
                    txtVenue.Text = "3Arena";
                    txtStreet.Text = "3Arena, N Wall Quay, North Dock";
                    txtCity.Text = "Dublin, 1";
                    txtEircode.Text = "D01 EW90";
                    txtVdMaxCap.Text = Convert.ToString(13_000);
                    txtEdEventCap.Text = Convert.ToString(13_000);
                    txtEventID.Text = "1";
                    txtTitle.Text = "Micheal Jackson";
                    txtDescription.Text = "Michael Jackson, the return of a legend";
                    dtpDate.Value = new DateTime(2023, 6, 14, currentDate.Hour, currentDate.Minute, currentDate.Second);
                    dtpTime.Value = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 20, 30, 00);
                    txtAvailTix.Text = "12500";
                    txtChildTktPrice.Text = "27.50";
                    txtAdultTktPrice.Text = "45.00";


                }
                else if(cboEvent.SelectedItem.ToString().Contains("Walking on Cars"))
                {
                    txtVenueID.Text = "2";
                    txtVenue.Text = "Aviva Stadium";
                    txtStreet.Text = "Aviva Stadium, Lansdowne Rd";
                    txtCity.Text = "Dublin 4";
                    txtEircode.Text = "D04 K5F9";
                    txtVdMaxCap.Text = Convert.ToString(51_700);
                    txtEdEventCap.Text = Convert.ToString(51_700);
                    txtEventID.Text = "1";
                    txtTitle.Text = "Walking on Cars";
                    txtDescription.Text = "Walking on cars, Irish and original";
                    dtpDate.Value = new DateTime(2022, 1, 15, currentDate.Hour, currentDate.Minute, currentDate.Second);
                    dtpTime.Value = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 18, 30, 00);
                    txtAvailTix.Text = "32500";
                    txtChildTktPrice.Text = "15.50";
                    txtAdultTktPrice.Text = "29.20";
                }
            } else
            {
                txtVenueID.Text = "";
                txtVenue.Text = "";
                txtVenue.Text = "";
                txtCity.Text = "";
                txtEircode.Text = "";
                txtEdEventCap.Text = "";
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

        private void button1_Click(object sender, EventArgs e)
        {
            if(cboEvent.SelectedItem != null)
            {
                if (cboEvent.SelectedItem.ToString().Contains("Michael Jackson"))
                {
                    grpAnalysis.Visible = true;
                } else if(cboEvent.SelectedItem.ToString().Contains("Walking on Cars"))
                {
                    MessageBox.Show(this, "An Analysis of this event is not ready yet...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    MessageBox.Show(this, "Please select an event....", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show(this, "You need to filter an event first...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (!chkEDetails.Checked & !chkVDetails.Checked)
            {
                Size = new Size(807, 1194);
            }
            else
            {
                Size = new Size(1550, 1194);
            }
        }
    }
}
