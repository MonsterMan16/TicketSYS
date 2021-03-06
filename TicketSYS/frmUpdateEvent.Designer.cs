
using System.Windows.Forms;

namespace TicketSYS
{
    partial class frmUpdateEvent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateEvent));
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.MnuItemBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpUpdateEvent = new System.Windows.Forms.GroupBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.grpFilterEvent = new System.Windows.Forms.GroupBox();
            this.cboEvent = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkDetails = new System.Windows.Forms.CheckBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.dtpFeDate = new System.Windows.Forms.DateTimePicker();
            this.cboFeVenue = new System.Windows.Forms.ComboBox();
            this.lblFeVenue = new System.Windows.Forms.Label();
            this.lblFeDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpEventDetails = new System.Windows.Forms.GroupBox();
            this.cboVenue = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.nudAdultTktPrice = new System.Windows.Forms.NumericUpDown();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.nudChildTktPrice = new System.Windows.Forms.NumericUpDown();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.nudAvailTix = new System.Windows.Forms.NumericUpDown();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblEvent = new System.Windows.Forms.Label();
            this.lblAvailTkt = new System.Windows.Forms.Label();
            this.lblAdultTktPrice = new System.Windows.Forms.Label();
            this.lblChildTktPrice = new System.Windows.Forms.Label();
            this.lblEventID = new System.Windows.Forms.Label();
            this.txtEventID = new System.Windows.Forms.TextBox();
            this.btnUpdateEvent = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.grpVenueDetails = new System.Windows.Forms.GroupBox();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblStreet2 = new System.Windows.Forms.Label();
            this.txtStreet2 = new System.Windows.Forms.TextBox();
            this.txtVdVenue = new System.Windows.Forms.TextBox();
            this.txtEircode = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.lblVdVenue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtVenueID = new System.Windows.Forms.TextBox();
            this.lblVenueID = new System.Windows.Forms.Label();
            this.lblStreet1 = new System.Windows.Forms.Label();
            this.txtMaxCap = new System.Windows.Forms.TextBox();
            this.lblMaxCap = new System.Windows.Forms.Label();
            this.lblEircode = new System.Windows.Forms.Label();
            this.txtStreet1 = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.mnuMainMenu.SuspendLayout();
            this.grpUpdateEvent.SuspendLayout();
            this.grpFilterEvent.SuspendLayout();
            this.grpEventDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdultTktPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChildTktPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAvailTix)).BeginInit();
            this.grpVenueDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuItemBack});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(1767, 45);
            this.mnuMainMenu.TabIndex = 1;
            this.mnuMainMenu.Text = "mnuMainMenu";
            // 
            // MnuItemBack
            // 
            this.MnuItemBack.Name = "MnuItemBack";
            this.MnuItemBack.Size = new System.Drawing.Size(93, 41);
            this.MnuItemBack.Text = "Back";
            this.MnuItemBack.Click += new System.EventHandler(this.exitToolStripMnuItem_Click);
            // 
            // grpUpdateEvent
            // 
            this.grpUpdateEvent.Controls.Add(this.grpFilterEvent);
            this.grpUpdateEvent.Controls.Add(this.grpEventDetails);
            this.grpUpdateEvent.Controls.Add(this.grpVenueDetails);
            this.grpUpdateEvent.Location = new System.Drawing.Point(35, 72);
            this.grpUpdateEvent.Margin = new System.Windows.Forms.Padding(2);
            this.grpUpdateEvent.Name = "grpUpdateEvent";
            this.grpUpdateEvent.Padding = new System.Windows.Forms.Padding(2);
            this.grpUpdateEvent.Size = new System.Drawing.Size(1694, 1283);
            this.grpUpdateEvent.TabIndex = 5;
            this.grpUpdateEvent.TabStop = false;
            this.grpUpdateEvent.Text = "Update Event";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.Black;
            this.txtPhone.ForeColor = System.Drawing.Color.White;
            this.txtPhone.Location = new System.Drawing.Point(327, 657);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(166, 43);
            this.txtPhone.TabIndex = 47;
            // 
            // grpFilterEvent
            // 
            this.grpFilterEvent.Controls.Add(this.cboEvent);
            this.grpFilterEvent.Controls.Add(this.label3);
            this.grpFilterEvent.Controls.Add(this.chkDetails);
            this.grpFilterEvent.Controls.Add(this.lblDetails);
            this.grpFilterEvent.Controls.Add(this.dtpFeDate);
            this.grpFilterEvent.Controls.Add(this.cboFeVenue);
            this.grpFilterEvent.Controls.Add(this.lblFeVenue);
            this.grpFilterEvent.Controls.Add(this.lblFeDate);
            this.grpFilterEvent.Location = new System.Drawing.Point(32, 66);
            this.grpFilterEvent.Name = "grpFilterEvent";
            this.grpFilterEvent.Size = new System.Drawing.Size(809, 378);
            this.grpFilterEvent.TabIndex = 45;
            this.grpFilterEvent.TabStop = false;
            this.grpFilterEvent.Text = "Select Event";
            // 
            // cboEvent
            // 
            this.cboEvent.FormattingEnabled = true;
            this.cboEvent.Location = new System.Drawing.Point(285, 140);
            this.cboEvent.Name = "cboEvent";
            this.cboEvent.Size = new System.Drawing.Size(445, 45);
            this.cboEvent.TabIndex = 60;
            this.cboEvent.SelectedIndexChanged += new System.EventHandler(this.cboEvent_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 37);
            this.label3.TabIndex = 59;
            this.label3.Text = "Event:";
            // 
            // chkDetails
            // 
            this.chkDetails.AutoSize = true;
            this.chkDetails.Checked = true;
            this.chkDetails.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDetails.Location = new System.Drawing.Point(288, 292);
            this.chkDetails.Name = "chkDetails";
            this.chkDetails.Size = new System.Drawing.Size(28, 27);
            this.chkDetails.TabIndex = 54;
            this.chkDetails.UseVisualStyleBackColor = true;
            this.chkDetails.CheckedChanged += new System.EventHandler(this.chkDetails_CheckedChanged);
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(31, 287);
            this.lblDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(184, 37);
            this.lblDetails.TabIndex = 53;
            this.lblDetails.Text = "Venue Details:";
            // 
            // dtpFeDate
            // 
            this.dtpFeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFeDate.Location = new System.Drawing.Point(288, 216);
            this.dtpFeDate.Name = "dtpFeDate";
            this.dtpFeDate.Size = new System.Drawing.Size(181, 43);
            this.dtpFeDate.TabIndex = 46;
            this.dtpFeDate.Value = new System.DateTime(2021, 12, 8, 23, 44, 17, 0);
            // 
            // cboFeVenue
            // 
            this.cboFeVenue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboFeVenue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboFeVenue.FormattingEnabled = true;
            this.cboFeVenue.Location = new System.Drawing.Point(285, 65);
            this.cboFeVenue.Name = "cboFeVenue";
            this.cboFeVenue.Size = new System.Drawing.Size(445, 45);
            this.cboFeVenue.TabIndex = 44;
            // 
            // lblFeVenue
            // 
            this.lblFeVenue.AutoSize = true;
            this.lblFeVenue.Location = new System.Drawing.Point(119, 68);
            this.lblFeVenue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFeVenue.Name = "lblFeVenue";
            this.lblFeVenue.Size = new System.Drawing.Size(96, 37);
            this.lblFeVenue.TabIndex = 43;
            this.lblFeVenue.Text = "Venue:";
            // 
            // lblFeDate
            // 
            this.lblFeDate.AutoSize = true;
            this.lblFeDate.Location = new System.Drawing.Point(65, 224);
            this.lblFeDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFeDate.Name = "lblFeDate";
            this.lblFeDate.Size = new System.Drawing.Size(151, 37);
            this.lblFeDate.TabIndex = 15;
            this.lblFeDate.Text = "Event Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 663);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 37);
            this.label1.TabIndex = 46;
            this.label1.Text = "Phone:";
            // 
            // grpEventDetails
            // 
            this.grpEventDetails.Controls.Add(this.cboVenue);
            this.grpEventDetails.Controls.Add(this.label4);
            this.grpEventDetails.Controls.Add(this.txtTitle);
            this.grpEventDetails.Controls.Add(this.nudAdultTktPrice);
            this.grpEventDetails.Controls.Add(this.dtpDate);
            this.grpEventDetails.Controls.Add(this.nudChildTktPrice);
            this.grpEventDetails.Controls.Add(this.dtpTime);
            this.grpEventDetails.Controls.Add(this.nudAvailTix);
            this.grpEventDetails.Controls.Add(this.lblTime);
            this.grpEventDetails.Controls.Add(this.lblDate);
            this.grpEventDetails.Controls.Add(this.lblEvent);
            this.grpEventDetails.Controls.Add(this.lblAvailTkt);
            this.grpEventDetails.Controls.Add(this.lblAdultTktPrice);
            this.grpEventDetails.Controls.Add(this.lblChildTktPrice);
            this.grpEventDetails.Controls.Add(this.lblEventID);
            this.grpEventDetails.Controls.Add(this.txtEventID);
            this.grpEventDetails.Controls.Add(this.btnUpdateEvent);
            this.grpEventDetails.Controls.Add(this.lblDescription);
            this.grpEventDetails.Controls.Add(this.txtDescription);
            this.grpEventDetails.Location = new System.Drawing.Point(32, 468);
            this.grpEventDetails.Name = "grpEventDetails";
            this.grpEventDetails.Size = new System.Drawing.Size(809, 796);
            this.grpEventDetails.TabIndex = 25;
            this.grpEventDetails.TabStop = false;
            this.grpEventDetails.Text = "Event Details";
            // 
            // cboVenue
            // 
            this.cboVenue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboVenue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboVenue.FormattingEnabled = true;
            this.cboVenue.Location = new System.Drawing.Point(334, 284);
            this.cboVenue.Name = "cboVenue";
            this.cboVenue.Size = new System.Drawing.Size(445, 45);
            this.cboVenue.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 288);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 37);
            this.label4.TabIndex = 61;
            this.label4.Text = "Venue:";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.White;
            this.txtTitle.ForeColor = System.Drawing.Color.Black;
            this.txtTitle.Location = new System.Drawing.Point(337, 130);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(445, 43);
            this.txtTitle.TabIndex = 59;
            // 
            // nudAdultTktPrice
            // 
            this.nudAdultTktPrice.DecimalPlaces = 2;
            this.nudAdultTktPrice.Location = new System.Drawing.Point(334, 637);
            this.nudAdultTktPrice.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudAdultTktPrice.Name = "nudAdultTktPrice";
            this.nudAdultTktPrice.Size = new System.Drawing.Size(183, 43);
            this.nudAdultTktPrice.TabIndex = 58;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(335, 355);
            this.dtpDate.MaxDate = new System.DateTime(2026, 12, 18, 7, 26, 12, 407);
            this.dtpDate.MinDate = new System.DateTime(1999, 12, 18, 7, 26, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(247, 43);
            this.dtpDate.TabIndex = 46;
            this.dtpDate.Value = new System.DateTime(2021, 12, 18, 7, 26, 12, 407);
            // 
            // nudChildTktPrice
            // 
            this.nudChildTktPrice.DecimalPlaces = 2;
            this.nudChildTktPrice.Location = new System.Drawing.Point(334, 567);
            this.nudChildTktPrice.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudChildTktPrice.Name = "nudChildTktPrice";
            this.nudChildTktPrice.Size = new System.Drawing.Size(183, 43);
            this.nudChildTktPrice.TabIndex = 57;
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "HH:mm";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(334, 427);
            this.dtpTime.MinDate = new System.DateTime(1999, 12, 17, 0, 0, 0, 0);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(181, 43);
            this.dtpTime.TabIndex = 45;
            this.dtpTime.Value = new System.DateTime(2021, 12, 18, 7, 26, 12, 405);
            // 
            // nudAvailTix
            // 
            this.nudAvailTix.Location = new System.Drawing.Point(334, 499);
            this.nudAvailTix.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudAvailTix.Name = "nudAvailTix";
            this.nudAvailTix.Size = new System.Drawing.Size(183, 43);
            this.nudAvailTix.TabIndex = 56;
            this.nudAvailTix.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(187, 432);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(81, 37);
            this.lblTime.TabIndex = 44;
            this.lblTime.Text = "Time:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(188, 361);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(79, 37);
            this.lblDate.TabIndex = 43;
            this.lblDate.Text = "Date:";
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Location = new System.Drawing.Point(119, 136);
            this.lblEvent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(146, 37);
            this.lblEvent.TabIndex = 35;
            this.lblEvent.Text = "Event Title:";
            // 
            // lblAvailTkt
            // 
            this.lblAvailTkt.AutoSize = true;
            this.lblAvailTkt.Location = new System.Drawing.Point(46, 506);
            this.lblAvailTkt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvailTkt.Name = "lblAvailTkt";
            this.lblAvailTkt.Size = new System.Drawing.Size(218, 37);
            this.lblAvailTkt.TabIndex = 33;
            this.lblAvailTkt.Text = "Available Tickets:";
            // 
            // lblAdultTktPrice
            // 
            this.lblAdultTktPrice.AutoSize = true;
            this.lblAdultTktPrice.Location = new System.Drawing.Point(35, 646);
            this.lblAdultTktPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdultTktPrice.Name = "lblAdultTktPrice";
            this.lblAdultTktPrice.Size = new System.Drawing.Size(227, 37);
            this.lblAdultTktPrice.TabIndex = 30;
            this.lblAdultTktPrice.Text = "Adult Ticket Price:";
            // 
            // lblChildTktPrice
            // 
            this.lblChildTktPrice.AutoSize = true;
            this.lblChildTktPrice.Location = new System.Drawing.Point(38, 576);
            this.lblChildTktPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChildTktPrice.Name = "lblChildTktPrice";
            this.lblChildTktPrice.Size = new System.Drawing.Size(225, 37);
            this.lblChildTktPrice.TabIndex = 29;
            this.lblChildTktPrice.Text = "Child Ticket Price:";
            // 
            // lblEventID
            // 
            this.lblEventID.AutoSize = true;
            this.lblEventID.Location = new System.Drawing.Point(148, 59);
            this.lblEventID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventID.Name = "lblEventID";
            this.lblEventID.Size = new System.Drawing.Size(121, 37);
            this.lblEventID.TabIndex = 0;
            this.lblEventID.Text = "Event ID:";
            // 
            // txtEventID
            // 
            this.txtEventID.BackColor = System.Drawing.Color.Black;
            this.txtEventID.ForeColor = System.Drawing.Color.White;
            this.txtEventID.Location = new System.Drawing.Point(337, 52);
            this.txtEventID.Margin = new System.Windows.Forms.Padding(2);
            this.txtEventID.Name = "txtEventID";
            this.txtEventID.ReadOnly = true;
            this.txtEventID.Size = new System.Drawing.Size(88, 43);
            this.txtEventID.TabIndex = 3;
            // 
            // btnUpdateEvent
            // 
            this.btnUpdateEvent.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnUpdateEvent.Location = new System.Drawing.Point(72, 722);
            this.btnUpdateEvent.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateEvent.Name = "btnUpdateEvent";
            this.btnUpdateEvent.Size = new System.Drawing.Size(622, 52);
            this.btnUpdateEvent.TabIndex = 8;
            this.btnUpdateEvent.Text = "Update Event";
            this.btnUpdateEvent.UseVisualStyleBackColor = false;
            this.btnUpdateEvent.Click += new System.EventHandler(this.btnUpdateEvent_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(37, 214);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(230, 37);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Event Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.Location = new System.Drawing.Point(335, 209);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(445, 43);
            this.txtDescription.TabIndex = 7;
            // 
            // txtContact
            // 
            this.txtContact.BackColor = System.Drawing.Color.Black;
            this.txtContact.ForeColor = System.Drawing.Color.White;
            this.txtContact.Location = new System.Drawing.Point(327, 594);
            this.txtContact.Margin = new System.Windows.Forms.Padding(2);
            this.txtContact.Name = "txtContact";
            this.txtContact.ReadOnly = true;
            this.txtContact.Size = new System.Drawing.Size(166, 43);
            this.txtContact.TabIndex = 45;
            // 
            // grpVenueDetails
            // 
            this.grpVenueDetails.Controls.Add(this.txtPhone);
            this.grpVenueDetails.Controls.Add(this.txtCounty);
            this.grpVenueDetails.Controls.Add(this.lblCounty);
            this.grpVenueDetails.Controls.Add(this.label1);
            this.grpVenueDetails.Controls.Add(this.lblStreet2);
            this.grpVenueDetails.Controls.Add(this.txtStreet2);
            this.grpVenueDetails.Controls.Add(this.txtContact);
            this.grpVenueDetails.Controls.Add(this.txtVdVenue);
            this.grpVenueDetails.Controls.Add(this.txtEircode);
            this.grpVenueDetails.Controls.Add(this.lblContact);
            this.grpVenueDetails.Controls.Add(this.txtFee);
            this.grpVenueDetails.Controls.Add(this.lblVdVenue);
            this.grpVenueDetails.Controls.Add(this.label2);
            this.grpVenueDetails.Controls.Add(this.txtCity);
            this.grpVenueDetails.Controls.Add(this.txtVenueID);
            this.grpVenueDetails.Controls.Add(this.lblVenueID);
            this.grpVenueDetails.Controls.Add(this.lblStreet1);
            this.grpVenueDetails.Controls.Add(this.txtMaxCap);
            this.grpVenueDetails.Controls.Add(this.lblMaxCap);
            this.grpVenueDetails.Controls.Add(this.lblEircode);
            this.grpVenueDetails.Controls.Add(this.txtStreet1);
            this.grpVenueDetails.Controls.Add(this.lblCity);
            this.grpVenueDetails.Location = new System.Drawing.Point(873, 66);
            this.grpVenueDetails.Name = "grpVenueDetails";
            this.grpVenueDetails.Size = new System.Drawing.Size(786, 785);
            this.grpVenueDetails.TabIndex = 15;
            this.grpVenueDetails.TabStop = false;
            this.grpVenueDetails.Text = "Venue Details";
            // 
            // txtCounty
            // 
            this.txtCounty.BackColor = System.Drawing.Color.Black;
            this.txtCounty.ForeColor = System.Drawing.Color.White;
            this.txtCounty.Location = new System.Drawing.Point(327, 461);
            this.txtCounty.Margin = new System.Windows.Forms.Padding(2);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.ReadOnly = true;
            this.txtCounty.Size = new System.Drawing.Size(166, 43);
            this.txtCounty.TabIndex = 41;
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(164, 467);
            this.lblCounty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(108, 37);
            this.lblCounty.TabIndex = 40;
            this.lblCounty.Text = "County:";
            // 
            // lblStreet2
            // 
            this.lblStreet2.AutoSize = true;
            this.lblStreet2.Location = new System.Drawing.Point(58, 268);
            this.lblStreet2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStreet2.Name = "lblStreet2";
            this.lblStreet2.Size = new System.Drawing.Size(214, 37);
            this.lblStreet2.TabIndex = 38;
            this.lblStreet2.Text = "Street Address 2:";
            // 
            // txtStreet2
            // 
            this.txtStreet2.BackColor = System.Drawing.Color.Black;
            this.txtStreet2.ForeColor = System.Drawing.Color.White;
            this.txtStreet2.Location = new System.Drawing.Point(327, 262);
            this.txtStreet2.Margin = new System.Windows.Forms.Padding(2);
            this.txtStreet2.Name = "txtStreet2";
            this.txtStreet2.ReadOnly = true;
            this.txtStreet2.Size = new System.Drawing.Size(445, 43);
            this.txtStreet2.TabIndex = 39;
            // 
            // txtVdVenue
            // 
            this.txtVdVenue.BackColor = System.Drawing.Color.Black;
            this.txtVdVenue.ForeColor = System.Drawing.Color.White;
            this.txtVdVenue.Location = new System.Drawing.Point(327, 125);
            this.txtVdVenue.Margin = new System.Windows.Forms.Padding(2);
            this.txtVdVenue.Name = "txtVdVenue";
            this.txtVdVenue.ReadOnly = true;
            this.txtVdVenue.Size = new System.Drawing.Size(445, 43);
            this.txtVdVenue.TabIndex = 37;
            // 
            // txtEircode
            // 
            this.txtEircode.BackColor = System.Drawing.Color.Black;
            this.txtEircode.ForeColor = System.Drawing.Color.White;
            this.txtEircode.Location = new System.Drawing.Point(327, 395);
            this.txtEircode.Margin = new System.Windows.Forms.Padding(2);
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.ReadOnly = true;
            this.txtEircode.Size = new System.Drawing.Size(166, 43);
            this.txtEircode.TabIndex = 27;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(157, 600);
            this.lblContact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(115, 37);
            this.lblContact.TabIndex = 44;
            this.lblContact.Text = "Contact:";
            // 
            // txtFee
            // 
            this.txtFee.BackColor = System.Drawing.Color.Black;
            this.txtFee.ForeColor = System.Drawing.Color.White;
            this.txtFee.Location = new System.Drawing.Point(327, 718);
            this.txtFee.Margin = new System.Windows.Forms.Padding(2);
            this.txtFee.Name = "txtFee";
            this.txtFee.ReadOnly = true;
            this.txtFee.Size = new System.Drawing.Size(139, 43);
            this.txtFee.TabIndex = 43;
            // 
            // lblVdVenue
            // 
            this.lblVdVenue.AutoSize = true;
            this.lblVdVenue.Location = new System.Drawing.Point(178, 133);
            this.lblVdVenue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVdVenue.Name = "lblVdVenue";
            this.lblVdVenue.Size = new System.Drawing.Size(96, 37);
            this.lblVdVenue.TabIndex = 36;
            this.lblVdVenue.Text = "Venue:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 724);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 37);
            this.label2.TabIndex = 42;
            this.label2.Text = "Fee:";
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.Black;
            this.txtCity.ForeColor = System.Drawing.Color.White;
            this.txtCity.Location = new System.Drawing.Point(327, 335);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(166, 43);
            this.txtCity.TabIndex = 26;
            // 
            // txtVenueID
            // 
            this.txtVenueID.BackColor = System.Drawing.Color.Black;
            this.txtVenueID.ForeColor = System.Drawing.Color.White;
            this.txtVenueID.Location = new System.Drawing.Point(327, 56);
            this.txtVenueID.Margin = new System.Windows.Forms.Padding(2);
            this.txtVenueID.Name = "txtVenueID";
            this.txtVenueID.ReadOnly = true;
            this.txtVenueID.Size = new System.Drawing.Size(88, 43);
            this.txtVenueID.TabIndex = 17;
            // 
            // lblVenueID
            // 
            this.lblVenueID.AutoSize = true;
            this.lblVenueID.Location = new System.Drawing.Point(143, 64);
            this.lblVenueID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVenueID.Name = "lblVenueID";
            this.lblVenueID.Size = new System.Drawing.Size(129, 37);
            this.lblVenueID.TabIndex = 16;
            this.lblVenueID.Text = "Venue ID:";
            // 
            // lblStreet1
            // 
            this.lblStreet1.AutoSize = true;
            this.lblStreet1.Location = new System.Drawing.Point(58, 198);
            this.lblStreet1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStreet1.Name = "lblStreet1";
            this.lblStreet1.Size = new System.Drawing.Size(214, 37);
            this.lblStreet1.TabIndex = 18;
            this.lblStreet1.Text = "Street Address 1:";
            // 
            // txtMaxCap
            // 
            this.txtMaxCap.BackColor = System.Drawing.Color.Black;
            this.txtMaxCap.ForeColor = System.Drawing.Color.White;
            this.txtMaxCap.Location = new System.Drawing.Point(327, 524);
            this.txtMaxCap.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaxCap.Name = "txtMaxCap";
            this.txtMaxCap.ReadOnly = true;
            this.txtMaxCap.Size = new System.Drawing.Size(139, 43);
            this.txtMaxCap.TabIndex = 13;
            // 
            // lblMaxCap
            // 
            this.lblMaxCap.AutoSize = true;
            this.lblMaxCap.Location = new System.Drawing.Point(91, 532);
            this.lblMaxCap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxCap.Name = "lblMaxCap";
            this.lblMaxCap.Size = new System.Drawing.Size(182, 37);
            this.lblMaxCap.TabIndex = 10;
            this.lblMaxCap.Text = "Max Capacity:";
            // 
            // lblEircode
            // 
            this.lblEircode.AutoSize = true;
            this.lblEircode.Location = new System.Drawing.Point(161, 402);
            this.lblEircode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEircode.Name = "lblEircode";
            this.lblEircode.Size = new System.Drawing.Size(111, 37);
            this.lblEircode.TabIndex = 21;
            this.lblEircode.Text = "Eircode:";
            // 
            // txtStreet1
            // 
            this.txtStreet1.BackColor = System.Drawing.Color.Black;
            this.txtStreet1.ForeColor = System.Drawing.Color.White;
            this.txtStreet1.Location = new System.Drawing.Point(327, 192);
            this.txtStreet1.Margin = new System.Windows.Forms.Padding(2);
            this.txtStreet1.Name = "txtStreet1";
            this.txtStreet1.ReadOnly = true;
            this.txtStreet1.Size = new System.Drawing.Size(445, 43);
            this.txtStreet1.TabIndex = 20;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(203, 341);
            this.lblCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(69, 37);
            this.lblCity.TabIndex = 19;
            this.lblCity.Text = "City:";
            // 
            // frmUpdateEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1767, 1378);
            this.Controls.Add(this.grpUpdateEvent);
            this.Controls.Add(this.mnuMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmUpdateEvent";
            this.Text = "Update Event";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUpdateEvent_FormClosed);
            this.Load += new System.EventHandler(this.frmUpdateEvent_Load);
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.grpUpdateEvent.ResumeLayout(false);
            this.grpFilterEvent.ResumeLayout(false);
            this.grpFilterEvent.PerformLayout();
            this.grpEventDetails.ResumeLayout(false);
            this.grpEventDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdultTktPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChildTktPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAvailTix)).EndInit();
            this.grpVenueDetails.ResumeLayout(false);
            this.grpVenueDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem MnuItemBack;
        private System.Windows.Forms.GroupBox grpUpdateEvent;
        private System.Windows.Forms.GroupBox grpEventDetails;
        private System.Windows.Forms.Label lblAvailTkt;
        private System.Windows.Forms.Label lblAdultTktPrice;
        private System.Windows.Forms.Label lblChildTktPrice;
        private System.Windows.Forms.Label lblEventID;
        private System.Windows.Forms.TextBox txtEventID;
        private System.Windows.Forms.Button btnUpdateEvent;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.GroupBox grpVenueDetails;
        private System.Windows.Forms.TextBox txtVenueID;
        private System.Windows.Forms.Label lblVenueID;
        private System.Windows.Forms.Label lblStreet1;
        private System.Windows.Forms.TextBox txtMaxCap;
        private System.Windows.Forms.Label lblMaxCap;
        private System.Windows.Forms.Label lblEircode;
        private System.Windows.Forms.TextBox txtStreet1;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.GroupBox grpFilterEvent;
        private System.Windows.Forms.DateTimePicker dtpFeDate;
        private System.Windows.Forms.ComboBox cboFeVenue;
        private System.Windows.Forms.Label lblFeVenue;
        private System.Windows.Forms.Label lblFeDate;
        private System.Windows.Forms.CheckBox chkDetails;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.TextBox txtVdVenue;
        private System.Windows.Forms.Label lblVdVenue;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.NumericUpDown nudAdultTktPrice;
        private System.Windows.Forms.NumericUpDown nudChildTktPrice;
        private System.Windows.Forms.NumericUpDown nudAvailTix;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblStreet2;
        private System.Windows.Forms.TextBox txtStreet2;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblContact;
        private ComboBox cboEvent;
        private Label label3;
        private TextBox txtTitle;
        private ComboBox cboVenue;
        private Label label4;
    }
}