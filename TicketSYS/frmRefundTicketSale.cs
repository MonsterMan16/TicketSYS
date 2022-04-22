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


        private void frmDeleteSale_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (parent.Visible == false)
            {
                parent.Show();
            }
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
    }
}
