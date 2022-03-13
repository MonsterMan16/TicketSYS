
namespace TicketSYS
{
    partial class frmMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuItemManageVenues = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemAddVenue = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemUpdateVenueCapacity = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemCloseVenue = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemManageEvents = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemScheduleEvent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemUpdateEvent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemCancelEvent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemManageTickets = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemProcessTicketSale = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemRefundTicketSale = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemAdministration = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemVenueSalesAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemEventSalesAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemManageVenues,
            this.mnuItemManageEvents,
            this.mnuItemManageTickets,
            this.mnuItemAdministration,
            this.mnuItemExit,
            this.toolStripMenuItem1});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.mnuMainMenu.Size = new System.Drawing.Size(1509, 58);
            this.mnuMainMenu.TabIndex = 0;
            this.mnuMainMenu.Text = "mnuMainMenu";
            this.mnuMainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuMainMenu_ItemClicked);
            // 
            // mnuItemManageVenues
            // 
            this.mnuItemManageVenues.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemAddVenue,
            this.mnuItemUpdateVenueCapacity,
            this.mnuItemCloseVenue});
            this.mnuItemManageVenues.Name = "mnuItemManageVenues";
            this.mnuItemManageVenues.Size = new System.Drawing.Size(299, 52);
            this.mnuItemManageVenues.Text = "Manage Venues";
            // 
            // mnuItemAddVenue
            // 
            this.mnuItemAddVenue.Name = "mnuItemAddVenue";
            this.mnuItemAddVenue.Size = new System.Drawing.Size(442, 66);
            this.mnuItemAddVenue.Text = "Add Venue";
            this.mnuItemAddVenue.Click += new System.EventHandler(this.mnuItemAddVenue_Click);
            // 
            // mnuItemUpdateVenueCapacity
            // 
            this.mnuItemUpdateVenueCapacity.Name = "mnuItemUpdateVenueCapacity";
            this.mnuItemUpdateVenueCapacity.Size = new System.Drawing.Size(442, 66);
            this.mnuItemUpdateVenueCapacity.Text = "Update Venue";
            this.mnuItemUpdateVenueCapacity.Click += new System.EventHandler(this.mnuItemUpdateVenueCapacity_Click);
            // 
            // mnuItemCloseVenue
            // 
            this.mnuItemCloseVenue.Name = "mnuItemCloseVenue";
            this.mnuItemCloseVenue.Size = new System.Drawing.Size(442, 66);
            this.mnuItemCloseVenue.Text = "Close Venue";
            this.mnuItemCloseVenue.Click += new System.EventHandler(this.mnuItemCloseVenue_Click);
            // 
            // mnuItemManageEvents
            // 
            this.mnuItemManageEvents.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemScheduleEvent,
            this.mnuItemUpdateEvent,
            this.mnuItemCancelEvent});
            this.mnuItemManageEvents.Name = "mnuItemManageEvents";
            this.mnuItemManageEvents.Size = new System.Drawing.Size(287, 52);
            this.mnuItemManageEvents.Text = "Manage Events";
            // 
            // mnuItemScheduleEvent
            // 
            this.mnuItemScheduleEvent.Name = "mnuItemScheduleEvent";
            this.mnuItemScheduleEvent.Size = new System.Drawing.Size(458, 66);
            this.mnuItemScheduleEvent.Text = "Schedule Event";
            this.mnuItemScheduleEvent.Click += new System.EventHandler(this.mnuItemAddEvent_Click);
            // 
            // mnuItemUpdateEvent
            // 
            this.mnuItemUpdateEvent.Name = "mnuItemUpdateEvent";
            this.mnuItemUpdateEvent.Size = new System.Drawing.Size(458, 66);
            this.mnuItemUpdateEvent.Text = "Update Event";
            this.mnuItemUpdateEvent.Click += new System.EventHandler(this.mnuItemUpdateEvent_Click);
            // 
            // mnuItemCancelEvent
            // 
            this.mnuItemCancelEvent.Name = "mnuItemCancelEvent";
            this.mnuItemCancelEvent.Size = new System.Drawing.Size(458, 66);
            this.mnuItemCancelEvent.Text = "Cancel Event";
            this.mnuItemCancelEvent.Click += new System.EventHandler(this.mnuItemCancelEvent_Click);
            // 
            // mnuItemManageTickets
            // 
            this.mnuItemManageTickets.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemProcessTicketSale,
            this.mnuItemRefundTicketSale});
            this.mnuItemManageTickets.Name = "mnuItemManageTickets";
            this.mnuItemManageTickets.Size = new System.Drawing.Size(295, 52);
            this.mnuItemManageTickets.Text = "Manage Tickets";
            // 
            // mnuItemProcessTicketSale
            // 
            this.mnuItemProcessTicketSale.Name = "mnuItemProcessTicketSale";
            this.mnuItemProcessTicketSale.Size = new System.Drawing.Size(517, 66);
            this.mnuItemProcessTicketSale.Text = "Process Ticket Sale";
            this.mnuItemProcessTicketSale.Click += new System.EventHandler(this.mnuItemProcessTicketSale_Click);
            // 
            // mnuItemRefundTicketSale
            // 
            this.mnuItemRefundTicketSale.Name = "mnuItemRefundTicketSale";
            this.mnuItemRefundTicketSale.Size = new System.Drawing.Size(517, 66);
            this.mnuItemRefundTicketSale.Text = "Refund Ticket Sale";
            this.mnuItemRefundTicketSale.Click += new System.EventHandler(this.mnuItemRefundTicketSale_Click);
            // 
            // mnuItemAdministration
            // 
            this.mnuItemAdministration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemVenueSalesAnalysis,
            this.mnuItemEventSalesAnalysis});
            this.mnuItemAdministration.Name = "mnuItemAdministration";
            this.mnuItemAdministration.Size = new System.Drawing.Size(281, 52);
            this.mnuItemAdministration.Text = "Administration";
            // 
            // mnuItemVenueSalesAnalysis
            // 
            this.mnuItemVenueSalesAnalysis.Name = "mnuItemVenueSalesAnalysis";
            this.mnuItemVenueSalesAnalysis.Size = new System.Drawing.Size(548, 66);
            this.mnuItemVenueSalesAnalysis.Text = "Venue Event Analysis";
            this.mnuItemVenueSalesAnalysis.Click += new System.EventHandler(this.mnuItemVenueSalesAnalysis_Click);
            // 
            // mnuItemEventSalesAnalysis
            // 
            this.mnuItemEventSalesAnalysis.Name = "mnuItemEventSalesAnalysis";
            this.mnuItemEventSalesAnalysis.Size = new System.Drawing.Size(548, 66);
            this.mnuItemEventSalesAnalysis.Text = "Event Sales Analysis";
            this.mnuItemEventSalesAnalysis.Click += new System.EventHandler(this.mnuItemEventSalesAnalysis_Click);
            // 
            // mnuItemExit
            // 
            this.mnuItemExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuItemExit.Name = "mnuItemExit";
            this.mnuItemExit.Size = new System.Drawing.Size(104, 52);
            this.mnuItemExit.Text = "Exit";
            this.mnuItemExit.Click += new System.EventHandler(this.exitToolStripMnuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(28, 52);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 526);
            this.Controls.Add(this.mnuMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMainMenu;
            this.Name = "frmMainMenu";
            this.Text = "Main Menu";
            this.Shown += new System.EventHandler(this.frmMainMenu_Shown);
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuItemExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuItemManageVenues;
        private System.Windows.Forms.ToolStripMenuItem mnuItemManageEvents;
        private System.Windows.Forms.ToolStripMenuItem mnuItemManageTickets;
        private System.Windows.Forms.ToolStripMenuItem mnuItemAdministration;
        private System.Windows.Forms.ToolStripMenuItem mnuItemVenueSalesAnalysis;
        private System.Windows.Forms.ToolStripMenuItem mnuItemEventSalesAnalysis;
        private System.Windows.Forms.ToolStripMenuItem mnuItemAddVenue;
        private System.Windows.Forms.ToolStripMenuItem mnuItemUpdateVenueCapacity;
        private System.Windows.Forms.ToolStripMenuItem mnuItemCloseVenue;
        private System.Windows.Forms.ToolStripMenuItem mnuItemScheduleEvent;
        private System.Windows.Forms.ToolStripMenuItem mnuItemUpdateEvent;
        private System.Windows.Forms.ToolStripMenuItem mnuItemCancelEvent;
        private System.Windows.Forms.ToolStripMenuItem mnuItemProcessTicketSale;
        private System.Windows.Forms.ToolStripMenuItem mnuItemRefundTicketSale;
    }
}

