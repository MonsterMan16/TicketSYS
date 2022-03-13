using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;
using Oracle.ManagedDataAccess.Client;

namespace TicketSYS
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void databaseConnectionCheck()
        {
            try
            {
                DBConnect oradb = new DBConnect();
                OracleConnection conn = new OracleConnection(DBConnect.getOradb());
                MessageBox.Show("Oracle Database Connection Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch
            {
                MessageBox.Show("ERROR: Oracle Database Connection Unsuccessful", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitToolStripMnuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void mnuMainMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnuItemAddVenue_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddVenue addVenueForm = new frmAddVenue(this);
            addVenueForm.Show();
        }

        private void mnuItemVenueSalesAnalysis_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVenueEventScheduleAnalysis venueEventAnalysisfrm = new frmVenueEventScheduleAnalysis(this);
            venueEventAnalysisfrm.Show();
        }

        private void mnuItemRefundTicketSale_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRefundTicketSale refundTicketSaleForm = new frmRefundTicketSale(this);
            refundTicketSaleForm.Show();
        }

        private void mnuItemUpdateVenueCapacity_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateVenue updateVenueCapacityForm = new frmUpdateVenue(this);
            updateVenueCapacityForm.Show();
        }

        private void mnuItemCancelEvent_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCancelEvent cancelEventForm = new frmCancelEvent(this);
            cancelEventForm.Show();
        }

        private void mnuItemAddEvent_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmScheduleEvent addEventForm = new frmScheduleEvent(this);
            addEventForm.Show();
        }

        private void mnuItemUpdateEvent_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateEvent updateEventForm = new frmUpdateEvent(this);
            updateEventForm.Show();
        }

        private void mnuItemProcessTicketSale_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProcessTicketSale processTicketSaleForm = new frmProcessTicketSale(this);
            processTicketSaleForm.Show();
        }

        private void mnuItemCloseVenue_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCloseVenue closeVenueForm = new frmCloseVenue(this);
            closeVenueForm.Show();
        }

        private void mnuItemEventSalesAnalysis_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEventSalesAnalysis eventSalesAnalysisForm = new frmEventSalesAnalysis(this);
            eventSalesAnalysisForm.Show();
        }

        private void frmMainMenu_Shown(object sender, EventArgs e)
        {
            databaseConnectionCheck();
        }
    }
}
