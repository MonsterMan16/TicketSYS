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
    }
}
