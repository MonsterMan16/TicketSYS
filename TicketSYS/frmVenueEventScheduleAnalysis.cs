using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TicketSYS
{
    public partial class frmVenueEventScheduleAnalysis : Form
    {
        frmMainMenu parent;
        public frmVenueEventScheduleAnalysis(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void frmVenueAnalysis_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (parent.Visible == false)
            {
                parent.Show();
            }
        }

        private void frmVenueAnalysis_Load(object sender, EventArgs e)
        {
            picEventAnalysis.SizeMode = PictureBoxSizeMode.StretchImage;
            Size = new Size(791, 781);
        }

        private void exitToolStripMnuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboVenue.SelectedItem != null)
            {
                grpAnalysis.Visible = false;
                if(cboVenue.SelectedItem.ToString().Contains("3Arena"))
                {
                    txtVenueID.Text = "1";
                    txtVenue.Text = "3Arena";
                    txtStreet.Text = "3Arena, N Wall Quay, North Dock";
                    txtCity.Text = "Dublin, 1";
                    txtEircode.Text = "D01 EW90";
                    txtMaxCap.Text = Convert.ToString(13_000);
                    grpAnalysis.Visible = false;
                } else if (cboVenue.SelectedItem.ToString().Contains("Aviva Stadium"))
                {
                    txtVenueID.Text = "2";
                    txtVenue.Text = "Aviva Stadium";
                    txtStreet.Text = "Aviva Stadium, Lansdowne Rd";
                    txtCity.Text = "Dublin, 4";
                    txtEircode.Text = "D04 k5F9";
                    txtMaxCap.Text = Convert.ToString(51_700);
                    grpAnalysis.Visible = false;
                } else
                {
                    txtVenueID.Text = "";
                    txtVenue.Text = "";
                    txtStreet.Text = "";
                    txtCity.Text = "";
                    txtEircode.Text = "";
                    txtMaxCap.Text = "";
                                        grpAnalysis.Visible = false;
                }
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if(cboVenue.SelectedItem != null)
            {
                if (cboVenue.SelectedItem.ToString().Contains("3Arena"))
                {
                    Size = new Size(1831, 781);
                    grpAnalysis.Visible = true;
                } else if (cboVenue.SelectedItem.ToString().Contains("Aviva Stadium"))
                {
                    MessageBox.Show(this, "An Analysis is not available for this venue...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    MessageBox.Show(this, "All form fields must be filled in!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
