
namespace TicketSYS
{
    partial class frmCancelEvent
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCancelEvent));
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMnuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpCancelEvent = new System.Windows.Forms.GroupBox();
            this.grpFilterEvent = new System.Windows.Forms.GroupBox();
            this.chkDetails = new System.Windows.Forms.CheckBox();
            this.lblVenueDetail = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cboVenue = new System.Windows.Forms.ComboBox();
            this.lblVenue = new System.Windows.Forms.Label();
            this.lblEventDate = new System.Windows.Forms.Label();
            this.grpEventDetails = new System.Windows.Forms.GroupBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtAdultTktPrice = new System.Windows.Forms.TextBox();
            this.txtChildTktPrice = new System.Windows.Forms.TextBox();
            this.txtAvailTix = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblEventID = new System.Windows.Forms.Label();
            this.txtEventID = new System.Windows.Forms.TextBox();
            this.cboEvent = new System.Windows.Forms.ComboBox();
            this.lblEvent = new System.Windows.Forms.Label();
            this.lblAdultTktPrice = new System.Windows.Forms.Label();
            this.lblChildTktPrice = new System.Windows.Forms.Label();
            this.lblAvailTkt = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.grpVenueDetails = new System.Windows.Forms.GroupBox();
            this.lblVdVenue = new System.Windows.Forms.Label();
            this.txtVdVenue = new System.Windows.Forms.TextBox();
            this.txtEircode = new System.Windows.Forms.TextBox();
            this.txtVenueID = new System.Windows.Forms.TextBox();
            this.lblVenueID = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtMaxCap = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblVenueMaxCapacity = new System.Windows.Forms.Label();
            this.lblEircode = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mnuMainMenu.SuspendLayout();
            this.grpCancelEvent.SuspendLayout();
            this.grpFilterEvent.SuspendLayout();
            this.grpEventDetails.SuspendLayout();
            this.grpVenueDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMnuItem});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnuMainMenu.Size = new System.Drawing.Size(1585, 40);
            this.mnuMainMenu.TabIndex = 1;
            this.mnuMainMenu.Text = "menuStrip1";
            // 
            // exitToolStripMnuItem
            // 
            this.exitToolStripMnuItem.Name = "exitToolStripMnuItem";
            this.exitToolStripMnuItem.Size = new System.Drawing.Size(83, 36);
            this.exitToolStripMnuItem.Text = "Back";
            this.exitToolStripMnuItem.Click += new System.EventHandler(this.exitToolStripMnuItem_Click);
            // 
            // grpCancelEvent
            // 
            this.grpCancelEvent.Controls.Add(this.grpFilterEvent);
            this.grpCancelEvent.Controls.Add(this.grpEventDetails);
            this.grpCancelEvent.Controls.Add(this.grpVenueDetails);
            this.grpCancelEvent.Location = new System.Drawing.Point(30, 62);
            this.grpCancelEvent.Margin = new System.Windows.Forms.Padding(2);
            this.grpCancelEvent.Name = "grpCancelEvent";
            this.grpCancelEvent.Padding = new System.Windows.Forms.Padding(2);
            this.grpCancelEvent.Size = new System.Drawing.Size(1521, 1079);
            this.grpCancelEvent.TabIndex = 5;
            this.grpCancelEvent.TabStop = false;
            this.grpCancelEvent.Text = "Cancel Event Form";
            // 
            // grpFilterEvent
            // 
            this.grpFilterEvent.Controls.Add(this.chkDetails);
            this.grpFilterEvent.Controls.Add(this.lblVenueDetail);
            this.grpFilterEvent.Controls.Add(this.dtpDate);
            this.grpFilterEvent.Controls.Add(this.btnFilter);
            this.grpFilterEvent.Controls.Add(this.cboVenue);
            this.grpFilterEvent.Controls.Add(this.lblVenue);
            this.grpFilterEvent.Controls.Add(this.lblEventDate);
            this.grpFilterEvent.Location = new System.Drawing.Point(35, 57);
            this.grpFilterEvent.Name = "grpFilterEvent";
            this.grpFilterEvent.Size = new System.Drawing.Size(701, 329);
            this.grpFilterEvent.TabIndex = 44;
            this.grpFilterEvent.TabStop = false;
            this.grpFilterEvent.Text = "Filter Event";
            // 
            // chkDetails
            // 
            this.chkDetails.AutoSize = true;
            this.chkDetails.Checked = true;
            this.chkDetails.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDetails.Location = new System.Drawing.Point(263, 203);
            this.chkDetails.Name = "chkDetails";
            this.chkDetails.Size = new System.Drawing.Size(28, 27);
            this.chkDetails.TabIndex = 54;
            this.chkDetails.UseVisualStyleBackColor = true;
            this.chkDetails.CheckedChanged += new System.EventHandler(this.chkDetail_CheckedChanged);
            // 
            // lblVenueDetail
            // 
            this.lblVenueDetail.AutoSize = true;
            this.lblVenueDetail.Location = new System.Drawing.Point(54, 199);
            this.lblVenueDetail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVenueDetail.Name = "lblVenueDetail";
            this.lblVenueDetail.Size = new System.Drawing.Size(165, 32);
            this.lblVenueDetail.TabIndex = 53;
            this.lblVenueDetail.Text = "Venue Details:";
            // 
            // dtpDate
            // 
            this.dtpDate.Enabled = false;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(269, 140);
            this.dtpDate.MinDate = new System.DateTime(2021, 12, 8, 23, 44, 17, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(157, 39);
            this.dtpDate.TabIndex = 46;
            this.dtpDate.Value = new System.DateTime(2021, 12, 8, 23, 44, 17, 0);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnFilter.Location = new System.Drawing.Point(162, 264);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(375, 45);
            this.btnFilter.TabIndex = 45;
            this.btnFilter.Text = "Filter Events";
            this.btnFilter.UseVisualStyleBackColor = false;
            // 
            // cboVenue
            // 
            this.cboVenue.FormattingEnabled = true;
            this.cboVenue.Items.AddRange(new object[] {
            "",
            "1  |  3Arena",
            "2  |  Aviva Stadium"});
            this.cboVenue.Location = new System.Drawing.Point(269, 72);
            this.cboVenue.Name = "cboVenue";
            this.cboVenue.Size = new System.Drawing.Size(386, 40);
            this.cboVenue.TabIndex = 44;
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.Location = new System.Drawing.Point(125, 75);
            this.lblVenue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(86, 32);
            this.lblVenue.TabIndex = 43;
            this.lblVenue.Text = "Venue:";
            // 
            // lblEventDate
            // 
            this.lblEventDate.AutoSize = true;
            this.lblEventDate.Location = new System.Drawing.Point(76, 145);
            this.lblEventDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventDate.Name = "lblEventDate";
            this.lblEventDate.Size = new System.Drawing.Size(135, 32);
            this.lblEventDate.TabIndex = 15;
            this.lblEventDate.Text = "Event Date:";
            // 
            // grpEventDetails
            // 
            this.grpEventDetails.Controls.Add(this.dtpTime);
            this.grpEventDetails.Controls.Add(this.dateTimePicker1);
            this.grpEventDetails.Controls.Add(this.lblDescription);
            this.grpEventDetails.Controls.Add(this.txtAdultTktPrice);
            this.grpEventDetails.Controls.Add(this.txtChildTktPrice);
            this.grpEventDetails.Controls.Add(this.txtAvailTix);
            this.grpEventDetails.Controls.Add(this.txtDescription);
            this.grpEventDetails.Controls.Add(this.lblTime);
            this.grpEventDetails.Controls.Add(this.btnCancel);
            this.grpEventDetails.Controls.Add(this.lblEventID);
            this.grpEventDetails.Controls.Add(this.txtEventID);
            this.grpEventDetails.Controls.Add(this.cboEvent);
            this.grpEventDetails.Controls.Add(this.lblEvent);
            this.grpEventDetails.Controls.Add(this.lblAdultTktPrice);
            this.grpEventDetails.Controls.Add(this.lblChildTktPrice);
            this.grpEventDetails.Controls.Add(this.lblAvailTkt);
            this.grpEventDetails.Controls.Add(this.lblDate);
            this.grpEventDetails.Location = new System.Drawing.Point(35, 409);
            this.grpEventDetails.Name = "grpEventDetails";
            this.grpEventDetails.Size = new System.Drawing.Size(701, 644);
            this.grpEventDetails.TabIndex = 25;
            this.grpEventDetails.TabStop = false;
            this.grpEventDetails.Text = "Event Details";
            // 
            // dtpTime
            // 
            this.dtpTime.Enabled = false;
            this.dtpTime.CustomFormat = "HH:mm";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(271, 306);
            this.dtpTime.MinDate = new System.DateTime(2021, 12, 17, 0, 0, 0, 0);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(157, 39);
            this.dtpTime.TabIndex = 30;
            this.dtpTime.Value = new System.DateTime(2021, 12, 18, 2, 27, 3, 552);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(271, 243);
            this.dateTimePicker1.MaxDate = new System.DateTime(2026, 12, 18, 2, 27, 3, 554);
            this.dateTimePicker1.MinDate = new System.DateTime(2021, 12, 18, 2, 27, 3, 554);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(157, 39);
            this.dateTimePicker1.TabIndex = 29;
            this.dateTimePicker1.Value = new System.DateTime(2021, 12, 18, 2, 27, 3, 554);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(7, 185);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(206, 32);
            this.lblDescription.TabIndex = 45;
            this.lblDescription.Text = "Event Description:";
            // 
            // txtAdultTktPrice
            // 
            this.txtAdultTktPrice.BackColor = System.Drawing.Color.Black;
            this.txtAdultTktPrice.ForeColor = System.Drawing.Color.White;
            this.txtAdultTktPrice.Location = new System.Drawing.Point(271, 495);
            this.txtAdultTktPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdultTktPrice.Name = "txtAdultTktPrice";
            this.txtAdultTktPrice.ReadOnly = true;
            this.txtAdultTktPrice.Size = new System.Drawing.Size(111, 39);
            this.txtAdultTktPrice.TabIndex = 52;
            // 
            // txtChildTktPrice
            // 
            this.txtChildTktPrice.BackColor = System.Drawing.Color.Black;
            this.txtChildTktPrice.ForeColor = System.Drawing.Color.White;
            this.txtChildTktPrice.Location = new System.Drawing.Point(271, 431);
            this.txtChildTktPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtChildTktPrice.Name = "txtChildTktPrice";
            this.txtChildTktPrice.ReadOnly = true;
            this.txtChildTktPrice.Size = new System.Drawing.Size(111, 39);
            this.txtChildTktPrice.TabIndex = 51;
            // 
            // txtAvailTix
            // 
            this.txtAvailTix.BackColor = System.Drawing.Color.Black;
            this.txtAvailTix.ForeColor = System.Drawing.Color.White;
            this.txtAvailTix.Location = new System.Drawing.Point(271, 367);
            this.txtAvailTix.Margin = new System.Windows.Forms.Padding(2);
            this.txtAvailTix.Name = "txtAvailTix";
            this.txtAvailTix.ReadOnly = true;
            this.txtAvailTix.Size = new System.Drawing.Size(111, 39);
            this.txtAvailTix.TabIndex = 50;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.Black;
            this.txtDescription.ForeColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(269, 178);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(386, 39);
            this.txtDescription.TabIndex = 46;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(75, 313);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(138, 32);
            this.lblTime.TabIndex = 49;
            this.lblTime.Text = "Event Time:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCancel.Location = new System.Drawing.Point(56, 569);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(543, 45);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Cancel Event";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblEventID
            // 
            this.lblEventID.AutoSize = true;
            this.lblEventID.Location = new System.Drawing.Point(103, 62);
            this.lblEventID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventID.Name = "lblEventID";
            this.lblEventID.Size = new System.Drawing.Size(108, 32);
            this.lblEventID.TabIndex = 0;
            this.lblEventID.Text = "Event ID:";
            // 
            // txtEventID
            // 
            this.txtEventID.BackColor = System.Drawing.Color.Black;
            this.txtEventID.ForeColor = System.Drawing.Color.White;
            this.txtEventID.Location = new System.Drawing.Point(269, 55);
            this.txtEventID.Margin = new System.Windows.Forms.Padding(2);
            this.txtEventID.Name = "txtEventID";
            this.txtEventID.ReadOnly = true;
            this.txtEventID.Size = new System.Drawing.Size(77, 39);
            this.txtEventID.TabIndex = 3;
            // 
            // cboEvent
            // 
            this.cboEvent.FormattingEnabled = true;
            this.cboEvent.Items.AddRange(new object[] {
            "",
            "1 | Micheal Jackson",
            "2 | Walking on Cars"});
            this.cboEvent.Location = new System.Drawing.Point(269, 115);
            this.cboEvent.Name = "cboEvent";
            this.cboEvent.Size = new System.Drawing.Size(386, 40);
            this.cboEvent.TabIndex = 46;
            this.cboEvent.SelectedIndexChanged += new System.EventHandler(this.cboEvent_SelectedIndexChanged);
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Location = new System.Drawing.Point(64, 123);
            this.lblEvent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(149, 32);
            this.lblEvent.TabIndex = 43;
            this.lblEvent.Text = "Select Event:";
            // 
            // lblAdultTktPrice
            // 
            this.lblAdultTktPrice.AutoSize = true;
            this.lblAdultTktPrice.Location = new System.Drawing.Point(9, 502);
            this.lblAdultTktPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdultTktPrice.Name = "lblAdultTktPrice";
            this.lblAdultTktPrice.Size = new System.Drawing.Size(204, 32);
            this.lblAdultTktPrice.TabIndex = 30;
            this.lblAdultTktPrice.Text = "Adult Ticket Price:";
            // 
            // lblChildTktPrice
            // 
            this.lblChildTktPrice.AutoSize = true;
            this.lblChildTktPrice.Location = new System.Drawing.Point(11, 438);
            this.lblChildTktPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChildTktPrice.Name = "lblChildTktPrice";
            this.lblChildTktPrice.Size = new System.Drawing.Size(202, 32);
            this.lblChildTktPrice.TabIndex = 29;
            this.lblChildTktPrice.Text = "Child Ticket Price:";
            // 
            // lblAvailTkt
            // 
            this.lblAvailTkt.AutoSize = true;
            this.lblAvailTkt.Location = new System.Drawing.Point(18, 374);
            this.lblAvailTkt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvailTkt.Name = "lblAvailTkt";
            this.lblAvailTkt.Size = new System.Drawing.Size(195, 32);
            this.lblAvailTkt.TabIndex = 33;
            this.lblAvailTkt.Text = "Available Tickets:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(78, 250);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(135, 32);
            this.lblDate.TabIndex = 16;
            this.lblDate.Text = "Event Date:";
            // 
            // grpVenueDetails
            // 
            this.grpVenueDetails.Controls.Add(this.lblVdVenue);
            this.grpVenueDetails.Controls.Add(this.txtVdVenue);
            this.grpVenueDetails.Controls.Add(this.txtEircode);
            this.grpVenueDetails.Controls.Add(this.txtVenueID);
            this.grpVenueDetails.Controls.Add(this.lblVenueID);
            this.grpVenueDetails.Controls.Add(this.lblStreet);
            this.grpVenueDetails.Controls.Add(this.txtMaxCap);
            this.grpVenueDetails.Controls.Add(this.txtCity);
            this.grpVenueDetails.Controls.Add(this.lblVenueMaxCapacity);
            this.grpVenueDetails.Controls.Add(this.lblEircode);
            this.grpVenueDetails.Controls.Add(this.txtStreet);
            this.grpVenueDetails.Controls.Add(this.lblCity);
            this.grpVenueDetails.Location = new System.Drawing.Point(783, 57);
            this.grpVenueDetails.Name = "grpVenueDetails";
            this.grpVenueDetails.Size = new System.Drawing.Size(701, 387);
            this.grpVenueDetails.TabIndex = 15;
            this.grpVenueDetails.TabStop = false;
            this.grpVenueDetails.Text = "Venue Details";
            // 
            // lblVdVenue
            // 
            this.lblVdVenue.AutoSize = true;
            this.lblVdVenue.Location = new System.Drawing.Point(162, 112);
            this.lblVdVenue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVdVenue.Name = "lblVdVenue";
            this.lblVdVenue.Size = new System.Drawing.Size(86, 32);
            this.lblVdVenue.TabIndex = 26;
            this.lblVdVenue.Text = "Venue:";
            // 
            // txtVdVenue
            // 
            this.txtVdVenue.BackColor = System.Drawing.Color.Black;
            this.txtVdVenue.ForeColor = System.Drawing.Color.White;
            this.txtVdVenue.Location = new System.Drawing.Point(291, 105);
            this.txtVdVenue.Margin = new System.Windows.Forms.Padding(2);
            this.txtVdVenue.Name = "txtVdVenue";
            this.txtVdVenue.ReadOnly = true;
            this.txtVdVenue.Size = new System.Drawing.Size(386, 39);
            this.txtVdVenue.TabIndex = 27;
            // 
            // txtEircode
            // 
            this.txtEircode.BackColor = System.Drawing.Color.Black;
            this.txtEircode.ForeColor = System.Drawing.Color.White;
            this.txtEircode.Location = new System.Drawing.Point(291, 264);
            this.txtEircode.Margin = new System.Windows.Forms.Padding(2);
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.ReadOnly = true;
            this.txtEircode.Size = new System.Drawing.Size(121, 39);
            this.txtEircode.TabIndex = 25;
            // 
            // txtVenueID
            // 
            this.txtVenueID.BackColor = System.Drawing.Color.Black;
            this.txtVenueID.ForeColor = System.Drawing.Color.White;
            this.txtVenueID.Location = new System.Drawing.Point(291, 48);
            this.txtVenueID.Margin = new System.Windows.Forms.Padding(2);
            this.txtVenueID.Name = "txtVenueID";
            this.txtVenueID.ReadOnly = true;
            this.txtVenueID.Size = new System.Drawing.Size(77, 39);
            this.txtVenueID.TabIndex = 17;
            // 
            // lblVenueID
            // 
            this.lblVenueID.AutoSize = true;
            this.lblVenueID.Location = new System.Drawing.Point(132, 55);
            this.lblVenueID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVenueID.Name = "lblVenueID";
            this.lblVenueID.Size = new System.Drawing.Size(116, 32);
            this.lblVenueID.TabIndex = 16;
            this.lblVenueID.Text = "Venue ID:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(76, 166);
            this.lblStreet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(172, 32);
            this.lblStreet.TabIndex = 18;
            this.lblStreet.Text = "Street Address:";
            // 
            // txtMaxCap
            // 
            this.txtMaxCap.BackColor = System.Drawing.Color.Black;
            this.txtMaxCap.ForeColor = System.Drawing.Color.White;
            this.txtMaxCap.Location = new System.Drawing.Point(291, 324);
            this.txtMaxCap.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaxCap.Name = "txtMaxCap";
            this.txtMaxCap.ReadOnly = true;
            this.txtMaxCap.Size = new System.Drawing.Size(121, 39);
            this.txtMaxCap.TabIndex = 13;
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.Black;
            this.txtCity.ForeColor = System.Drawing.Color.White;
            this.txtCity.Location = new System.Drawing.Point(291, 212);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(386, 39);
            this.txtCity.TabIndex = 23;
            // 
            // lblVenueMaxCapacity
            // 
            this.lblVenueMaxCapacity.AutoSize = true;
            this.lblVenueMaxCapacity.Location = new System.Drawing.Point(87, 331);
            this.lblVenueMaxCapacity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVenueMaxCapacity.Name = "lblVenueMaxCapacity";
            this.lblVenueMaxCapacity.Size = new System.Drawing.Size(161, 32);
            this.lblVenueMaxCapacity.TabIndex = 10;
            this.lblVenueMaxCapacity.Text = "Max Capacity:";
            // 
            // lblEircode
            // 
            this.lblEircode.AutoSize = true;
            this.lblEircode.Location = new System.Drawing.Point(151, 271);
            this.lblEircode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEircode.Name = "lblEircode";
            this.lblEircode.Size = new System.Drawing.Size(97, 32);
            this.lblEircode.TabIndex = 21;
            this.lblEircode.Text = "Eircode:";
            // 
            // txtStreet
            // 
            this.txtStreet.BackColor = System.Drawing.Color.Black;
            this.txtStreet.ForeColor = System.Drawing.Color.White;
            this.txtStreet.Location = new System.Drawing.Point(291, 159);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(2);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.ReadOnly = true;
            this.txtStreet.Size = new System.Drawing.Size(386, 39);
            this.txtStreet.TabIndex = 20;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(188, 219);
            this.lblCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(60, 32);
            this.lblCity.TabIndex = 19;
            this.lblCity.Text = "City:";
            // 
            // frmCancelEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1585, 1175);
            this.Controls.Add(this.grpCancelEvent);
            this.Controls.Add(this.mnuMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCancelEvent";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDeleteEvent_FormClosed);
            this.Load += new System.EventHandler(this.frmCancelEvent_Load);
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.grpCancelEvent.ResumeLayout(false);
            this.grpFilterEvent.ResumeLayout(false);
            this.grpFilterEvent.PerformLayout();
            this.grpEventDetails.ResumeLayout(false);
            this.grpEventDetails.PerformLayout();
            this.grpVenueDetails.ResumeLayout(false);
            this.grpVenueDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMnuItem;
        private System.Windows.Forms.GroupBox grpCancelEvent;
        private System.Windows.Forms.GroupBox grpEventDetails;
        private System.Windows.Forms.Label lblAvailTkt;
        private System.Windows.Forms.Label lblAdultTktPrice;
        private System.Windows.Forms.Label lblChildTktPrice;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblEventDate;
        private System.Windows.Forms.Label lblEventID;
        private System.Windows.Forms.TextBox txtEventID;
        private System.Windows.Forms.GroupBox grpVenueDetails;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.TextBox txtVenueID;
        private System.Windows.Forms.Label lblVenueID;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtMaxCap;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblVenueMaxCapacity;
        private System.Windows.Forms.Label lblEircode;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpFilterEvent;
        private System.Windows.Forms.Label lblVdVenue;
        private System.Windows.Forms.TextBox txtVdVenue;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cboVenue;
        private System.Windows.Forms.ComboBox cboEvent;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtAvailTix;
        private System.Windows.Forms.TextBox txtAdultTktPrice;
        private System.Windows.Forms.TextBox txtChildTktPrice;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.CheckBox chkDetails;
        private System.Windows.Forms.Label lblVenueDetail;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}