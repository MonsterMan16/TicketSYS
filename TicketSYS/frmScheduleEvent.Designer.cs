
namespace TicketSYS
{
    partial class frmScheduleEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScheduleEvent));
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuItemBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpScheduleEvent = new System.Windows.Forms.GroupBox();
            this.grpEventDetails = new System.Windows.Forms.GroupBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.nudAdultTktPrice = new System.Windows.Forms.NumericUpDown();
            this.nudChildTktPrice = new System.Windows.Forms.NumericUpDown();
            this.nudMaxTix = new System.Windows.Forms.NumericUpDown();
            this.lblAvailTickets = new System.Windows.Forms.Label();
            this.lblAdultTktPrice = new System.Windows.Forms.Label();
            this.lblChildTktPrice = new System.Windows.Forms.Label();
            this.chkDetails = new System.Windows.Forms.CheckBox();
            this.lblVenueDetails = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblEventID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtEventID = new System.Windows.Forms.TextBox();
            this.cboVenue = new System.Windows.Forms.ComboBox();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblVenue = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.grpVenueDetails = new System.Windows.Forms.GroupBox();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblFee = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStreet1 = new System.Windows.Forms.TextBox();
            this.txtEircode = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtVenueID = new System.Windows.Forms.TextBox();
            this.lblVenueID = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtMaxCap = new System.Windows.Forms.TextBox();
            this.lblMaxCap = new System.Windows.Forms.Label();
            this.lblEircode = new System.Windows.Forms.Label();
            this.txtStreet2 = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.mnuMainMenu.SuspendLayout();
            this.grpScheduleEvent.SuspendLayout();
            this.grpEventDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdultTktPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChildTktPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxTix)).BeginInit();
            this.grpVenueDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemBack});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.mnuMainMenu.Size = new System.Drawing.Size(2387, 58);
            this.mnuMainMenu.TabIndex = 1;
            this.mnuMainMenu.Text = "menuStrip1";
            // 
            // mnuItemBack
            // 
            this.mnuItemBack.Name = "mnuItemBack";
            this.mnuItemBack.Size = new System.Drawing.Size(122, 52);
            this.mnuItemBack.Text = "Back";
            this.mnuItemBack.Click += new System.EventHandler(this.exitToolStripMnuItem_Click);
            // 
            // grpScheduleEvent
            // 
            this.grpScheduleEvent.Controls.Add(this.grpEventDetails);
            this.grpScheduleEvent.Controls.Add(this.grpVenueDetails);
            this.grpScheduleEvent.Location = new System.Drawing.Point(41, 93);
            this.grpScheduleEvent.Name = "grpScheduleEvent";
            this.grpScheduleEvent.Size = new System.Drawing.Size(2301, 1242);
            this.grpScheduleEvent.TabIndex = 4;
            this.grpScheduleEvent.TabStop = false;
            this.grpScheduleEvent.Text = "Schedule Event";
            // 
            // grpEventDetails
            // 
            this.grpEventDetails.Controls.Add(this.dtpTime);
            this.grpEventDetails.Controls.Add(this.dtpDate);
            this.grpEventDetails.Controls.Add(this.nudAdultTktPrice);
            this.grpEventDetails.Controls.Add(this.nudChildTktPrice);
            this.grpEventDetails.Controls.Add(this.nudMaxTix);
            this.grpEventDetails.Controls.Add(this.lblAvailTickets);
            this.grpEventDetails.Controls.Add(this.lblAdultTktPrice);
            this.grpEventDetails.Controls.Add(this.lblChildTktPrice);
            this.grpEventDetails.Controls.Add(this.chkDetails);
            this.grpEventDetails.Controls.Add(this.lblVenueDetails);
            this.grpEventDetails.Controls.Add(this.lblTime);
            this.grpEventDetails.Controls.Add(this.lblFromDate);
            this.grpEventDetails.Controls.Add(this.lblEventID);
            this.grpEventDetails.Controls.Add(this.lblTitle);
            this.grpEventDetails.Controls.Add(this.txtEventID);
            this.grpEventDetails.Controls.Add(this.cboVenue);
            this.grpEventDetails.Controls.Add(this.btnAddEvent);
            this.grpEventDetails.Controls.Add(this.lblDescription);
            this.grpEventDetails.Controls.Add(this.txtTitle);
            this.grpEventDetails.Controls.Add(this.lblVenue);
            this.grpEventDetails.Controls.Add(this.txtDesc);
            this.grpEventDetails.Location = new System.Drawing.Point(67, 86);
            this.grpEventDetails.Margin = new System.Windows.Forms.Padding(4);
            this.grpEventDetails.Name = "grpEventDetails";
            this.grpEventDetails.Padding = new System.Windows.Forms.Padding(4);
            this.grpEventDetails.Size = new System.Drawing.Size(1079, 1110);
            this.grpEventDetails.TabIndex = 25;
            this.grpEventDetails.TabStop = false;
            this.grpEventDetails.Text = "Event Details";
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "HH:mm";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(449, 654);
            this.dtpTime.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTime.MinDate = new System.DateTime(2021, 12, 17, 0, 0, 0, 0);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(240, 55);
            this.dtpTime.TabIndex = 41;
            this.dtpTime.Value = new System.DateTime(2021, 12, 18, 7, 26, 12, 405);
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(449, 555);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDate.MaxDate = new System.DateTime(2026, 12, 18, 7, 26, 12, 407);
            this.dtpDate.MinDate = new System.DateTime(2021, 12, 18, 7, 26, 12, 407);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(328, 55);
            this.dtpDate.TabIndex = 39;
            this.dtpDate.Value = new System.DateTime(2021, 12, 18, 7, 26, 12, 407);
            // 
            // nudAdultTktPrice
            // 
            this.nudAdultTktPrice.DecimalPlaces = 2;
            this.nudAdultTktPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudAdultTktPrice.Location = new System.Drawing.Point(449, 925);
            this.nudAdultTktPrice.Margin = new System.Windows.Forms.Padding(4);
            this.nudAdultTktPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudAdultTktPrice.Name = "nudAdultTktPrice";
            this.nudAdultTktPrice.Size = new System.Drawing.Size(241, 55);
            this.nudAdultTktPrice.TabIndex = 36;
            // 
            // nudChildTktPrice
            // 
            this.nudChildTktPrice.DecimalPlaces = 2;
            this.nudChildTktPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudChildTktPrice.Location = new System.Drawing.Point(449, 835);
            this.nudChildTktPrice.Margin = new System.Windows.Forms.Padding(4);
            this.nudChildTktPrice.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nudChildTktPrice.Name = "nudChildTktPrice";
            this.nudChildTktPrice.Size = new System.Drawing.Size(241, 55);
            this.nudChildTktPrice.TabIndex = 35;
            // 
            // nudMaxTix
            // 
            this.nudMaxTix.Location = new System.Drawing.Point(449, 745);
            this.nudMaxTix.Margin = new System.Windows.Forms.Padding(4);
            this.nudMaxTix.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nudMaxTix.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudMaxTix.Name = "nudMaxTix";
            this.nudMaxTix.Size = new System.Drawing.Size(241, 55);
            this.nudMaxTix.TabIndex = 34;
            this.nudMaxTix.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // lblAvailTickets
            // 
            this.lblAvailTickets.AutoSize = true;
            this.lblAvailTickets.Location = new System.Drawing.Point(63, 755);
            this.lblAvailTickets.Name = "lblAvailTickets";
            this.lblAvailTickets.Size = new System.Drawing.Size(289, 48);
            this.lblAvailTickets.TabIndex = 33;
            this.lblAvailTickets.Text = "Available Tickets:";
            // 
            // lblAdultTktPrice
            // 
            this.lblAdultTktPrice.AutoSize = true;
            this.lblAdultTktPrice.Location = new System.Drawing.Point(49, 935);
            this.lblAdultTktPrice.Name = "lblAdultTktPrice";
            this.lblAdultTktPrice.Size = new System.Drawing.Size(305, 48);
            this.lblAdultTktPrice.TabIndex = 30;
            this.lblAdultTktPrice.Text = "Adult Ticket Price:";
            // 
            // lblChildTktPrice
            // 
            this.lblChildTktPrice.AutoSize = true;
            this.lblChildTktPrice.Location = new System.Drawing.Point(52, 846);
            this.lblChildTktPrice.Name = "lblChildTktPrice";
            this.lblChildTktPrice.Size = new System.Drawing.Size(301, 48);
            this.lblChildTktPrice.TabIndex = 29;
            this.lblChildTktPrice.Text = "Child Ticket Price:";
            // 
            // chkDetails
            // 
            this.chkDetails.AutoSize = true;
            this.chkDetails.Checked = true;
            this.chkDetails.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDetails.Location = new System.Drawing.Point(449, 471);
            this.chkDetails.Margin = new System.Windows.Forms.Padding(4);
            this.chkDetails.Name = "chkDetails";
            this.chkDetails.Size = new System.Drawing.Size(42, 41);
            this.chkDetails.TabIndex = 27;
            this.chkDetails.UseVisualStyleBackColor = true;
            this.chkDetails.CheckedChanged += new System.EventHandler(this.chkVenueDetails_CheckedChanged);
            // 
            // lblVenueDetails
            // 
            this.lblVenueDetails.AutoSize = true;
            this.lblVenueDetails.Location = new System.Drawing.Point(109, 464);
            this.lblVenueDetails.Name = "lblVenueDetails";
            this.lblVenueDetails.Size = new System.Drawing.Size(243, 48);
            this.lblVenueDetails.TabIndex = 26;
            this.lblVenueDetails.Text = "Venue Details:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(163, 661);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(189, 48);
            this.lblTime.TabIndex = 16;
            this.lblTime.Text = "Start Time:";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(247, 563);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(102, 48);
            this.lblFromDate.TabIndex = 15;
            this.lblFromDate.Text = "Date:";
            // 
            // lblEventID
            // 
            this.lblEventID.AutoSize = true;
            this.lblEventID.Location = new System.Drawing.Point(197, 77);
            this.lblEventID.Name = "lblEventID";
            this.lblEventID.Size = new System.Drawing.Size(159, 48);
            this.lblEventID.TabIndex = 0;
            this.lblEventID.Text = "Event ID:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(161, 182);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(192, 48);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Event Title:";
            // 
            // txtEventID
            // 
            this.txtEventID.BackColor = System.Drawing.Color.Black;
            this.txtEventID.ForeColor = System.Drawing.Color.White;
            this.txtEventID.Location = new System.Drawing.Point(449, 67);
            this.txtEventID.Name = "txtEventID";
            this.txtEventID.ReadOnly = true;
            this.txtEventID.Size = new System.Drawing.Size(116, 55);
            this.txtEventID.TabIndex = 3;
            this.txtEventID.Text = "1";
            // 
            // cboVenue
            // 
            this.cboVenue.FormattingEnabled = true;
            this.cboVenue.Items.AddRange(new object[] {
            "",
            "1  |  3Arena",
            "2  |  Aviva Stadium"});
            this.cboVenue.Location = new System.Drawing.Point(449, 375);
            this.cboVenue.Margin = new System.Windows.Forms.Padding(4);
            this.cboVenue.Name = "cboVenue";
            this.cboVenue.Size = new System.Drawing.Size(592, 56);
            this.cboVenue.TabIndex = 14;
            this.cboVenue.SelectedIndexChanged += new System.EventHandler(this.cboVenue_SelectedIndexChanged);
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAddEvent.Location = new System.Drawing.Point(109, 1022);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(829, 67);
            this.btnAddEvent.TabIndex = 8;
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.UseVisualStyleBackColor = false;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(59, 285);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(305, 48);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Event Description:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(449, 171);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(592, 55);
            this.txtTitle.TabIndex = 5;
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.Location = new System.Drawing.Point(231, 387);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(126, 48);
            this.lblVenue.TabIndex = 6;
            this.lblVenue.Text = "Venue:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(449, 275);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(592, 55);
            this.txtDesc.TabIndex = 7;
            // 
            // grpVenueDetails
            // 
            this.grpVenueDetails.Controls.Add(this.txtFee);
            this.grpVenueDetails.Controls.Add(this.txtCounty);
            this.grpVenueDetails.Controls.Add(this.lblCounty);
            this.grpVenueDetails.Controls.Add(this.lblName);
            this.grpVenueDetails.Controls.Add(this.txtName);
            this.grpVenueDetails.Controls.Add(this.lblFee);
            this.grpVenueDetails.Controls.Add(this.txtContact);
            this.grpVenueDetails.Controls.Add(this.txtPhone);
            this.grpVenueDetails.Controls.Add(this.lblContact);
            this.grpVenueDetails.Controls.Add(this.lblPhone);
            this.grpVenueDetails.Controls.Add(this.label1);
            this.grpVenueDetails.Controls.Add(this.txtStreet1);
            this.grpVenueDetails.Controls.Add(this.txtEircode);
            this.grpVenueDetails.Controls.Add(this.txtCity);
            this.grpVenueDetails.Controls.Add(this.txtVenueID);
            this.grpVenueDetails.Controls.Add(this.lblVenueID);
            this.grpVenueDetails.Controls.Add(this.lblStreet);
            this.grpVenueDetails.Controls.Add(this.txtMaxCap);
            this.grpVenueDetails.Controls.Add(this.lblMaxCap);
            this.grpVenueDetails.Controls.Add(this.lblEircode);
            this.grpVenueDetails.Controls.Add(this.txtStreet2);
            this.grpVenueDetails.Controls.Add(this.lblCity);
            this.grpVenueDetails.Location = new System.Drawing.Point(1191, 86);
            this.grpVenueDetails.Margin = new System.Windows.Forms.Padding(4);
            this.grpVenueDetails.Name = "grpVenueDetails";
            this.grpVenueDetails.Padding = new System.Windows.Forms.Padding(4);
            this.grpVenueDetails.Size = new System.Drawing.Size(1048, 1110);
            this.grpVenueDetails.TabIndex = 15;
            this.grpVenueDetails.TabStop = false;
            this.grpVenueDetails.Text = "Venue Details";
            // 
            // txtFee
            // 
            this.txtFee.BackColor = System.Drawing.Color.Black;
            this.txtFee.ForeColor = System.Drawing.Color.White;
            this.txtFee.Location = new System.Drawing.Point(439, 1014);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(175, 55);
            this.txtFee.TabIndex = 40;
            // 
            // txtCounty
            // 
            this.txtCounty.BackColor = System.Drawing.Color.Black;
            this.txtCounty.ForeColor = System.Drawing.Color.White;
            this.txtCounty.Location = new System.Drawing.Point(439, 553);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.ReadOnly = true;
            this.txtCounty.Size = new System.Drawing.Size(220, 55);
            this.txtCounty.TabIndex = 39;
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(248, 560);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(140, 48);
            this.lblCounty.TabIndex = 38;
            this.lblCounty.Text = "County:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(107, 188);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(287, 48);
            this.lblName.TabIndex = 36;
            this.lblName.Text = "Street Address 1:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Black;
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(439, 178);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(592, 55);
            this.txtName.TabIndex = 37;
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Location = new System.Drawing.Point(307, 1022);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(84, 48);
            this.lblFee.TabIndex = 34;
            this.lblFee.Text = "Fee:";
            // 
            // txtContact
            // 
            this.txtContact.BackColor = System.Drawing.Color.Black;
            this.txtContact.ForeColor = System.Drawing.Color.White;
            this.txtContact.Location = new System.Drawing.Point(439, 813);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(384, 55);
            this.txtContact.TabIndex = 33;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.Black;
            this.txtPhone.ForeColor = System.Drawing.Color.White;
            this.txtPhone.Location = new System.Drawing.Point(439, 909);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(384, 55);
            this.txtPhone.TabIndex = 31;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(239, 821);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(150, 48);
            this.lblContact.TabIndex = 32;
            this.lblContact.Text = "Contact:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(261, 917);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(128, 48);
            this.lblPhone.TabIndex = 30;
            this.lblPhone.Text = "Phone:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 48);
            this.label1.TabIndex = 28;
            this.label1.Text = "Street Address 1:";
            // 
            // txtStreet1
            // 
            this.txtStreet1.BackColor = System.Drawing.Color.Black;
            this.txtStreet1.ForeColor = System.Drawing.Color.White;
            this.txtStreet1.Location = new System.Drawing.Point(439, 276);
            this.txtStreet1.Name = "txtStreet1";
            this.txtStreet1.ReadOnly = true;
            this.txtStreet1.Size = new System.Drawing.Size(592, 55);
            this.txtStreet1.TabIndex = 29;
            // 
            // txtEircode
            // 
            this.txtEircode.BackColor = System.Drawing.Color.Black;
            this.txtEircode.ForeColor = System.Drawing.Color.White;
            this.txtEircode.Location = new System.Drawing.Point(439, 621);
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.ReadOnly = true;
            this.txtEircode.Size = new System.Drawing.Size(220, 55);
            this.txtEircode.TabIndex = 27;
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.Black;
            this.txtCity.ForeColor = System.Drawing.Color.White;
            this.txtCity.Location = new System.Drawing.Point(439, 475);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(220, 55);
            this.txtCity.TabIndex = 26;
            // 
            // txtVenueID
            // 
            this.txtVenueID.BackColor = System.Drawing.Color.Black;
            this.txtVenueID.ForeColor = System.Drawing.Color.White;
            this.txtVenueID.Location = new System.Drawing.Point(439, 87);
            this.txtVenueID.Name = "txtVenueID";
            this.txtVenueID.ReadOnly = true;
            this.txtVenueID.Size = new System.Drawing.Size(116, 55);
            this.txtVenueID.TabIndex = 17;
            // 
            // lblVenueID
            // 
            this.lblVenueID.AutoSize = true;
            this.lblVenueID.Location = new System.Drawing.Point(220, 95);
            this.lblVenueID.Name = "lblVenueID";
            this.lblVenueID.Size = new System.Drawing.Size(171, 48);
            this.lblVenueID.TabIndex = 16;
            this.lblVenueID.Text = "Venue ID:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(107, 388);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(287, 48);
            this.lblStreet.TabIndex = 18;
            this.lblStreet.Text = "Street Address 2:";
            // 
            // txtMaxCap
            // 
            this.txtMaxCap.BackColor = System.Drawing.Color.Black;
            this.txtMaxCap.ForeColor = System.Drawing.Color.White;
            this.txtMaxCap.Location = new System.Drawing.Point(439, 719);
            this.txtMaxCap.Name = "txtMaxCap";
            this.txtMaxCap.ReadOnly = true;
            this.txtMaxCap.Size = new System.Drawing.Size(184, 55);
            this.txtMaxCap.TabIndex = 13;
            // 
            // lblMaxCap
            // 
            this.lblMaxCap.AutoSize = true;
            this.lblMaxCap.Location = new System.Drawing.Point(149, 726);
            this.lblMaxCap.Name = "lblMaxCap";
            this.lblMaxCap.Size = new System.Drawing.Size(239, 48);
            this.lblMaxCap.TabIndex = 10;
            this.lblMaxCap.Text = "Max Capacity:";
            // 
            // lblEircode
            // 
            this.lblEircode.AutoSize = true;
            this.lblEircode.Location = new System.Drawing.Point(244, 629);
            this.lblEircode.Name = "lblEircode";
            this.lblEircode.Size = new System.Drawing.Size(146, 48);
            this.lblEircode.TabIndex = 21;
            this.lblEircode.Text = "Eircode:";
            // 
            // txtStreet2
            // 
            this.txtStreet2.BackColor = System.Drawing.Color.Black;
            this.txtStreet2.ForeColor = System.Drawing.Color.White;
            this.txtStreet2.Location = new System.Drawing.Point(439, 374);
            this.txtStreet2.Name = "txtStreet2";
            this.txtStreet2.ReadOnly = true;
            this.txtStreet2.Size = new System.Drawing.Size(592, 55);
            this.txtStreet2.TabIndex = 20;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(300, 483);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(88, 48);
            this.lblCity.TabIndex = 19;
            this.lblCity.Text = "City:";
            // 
            // frmScheduleEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2387, 1379);
            this.Controls.Add(this.grpScheduleEvent);
            this.Controls.Add(this.mnuMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmScheduleEvent";
            this.Text = "Schedule Event";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCreateEvent_FormClosed);
            this.Load += new System.EventHandler(this.frmScheduleEvent_Loader);
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.grpScheduleEvent.ResumeLayout(false);
            this.grpEventDetails.ResumeLayout(false);
            this.grpEventDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdultTktPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChildTktPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxTix)).EndInit();
            this.grpVenueDetails.ResumeLayout(false);
            this.grpVenueDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuItemBack;
        private System.Windows.Forms.GroupBox grpScheduleEvent;
        private System.Windows.Forms.TextBox txtMaxCap;
        private System.Windows.Forms.Label lblMaxCap;
        private System.Windows.Forms.GroupBox grpVenueDetails;
        private System.Windows.Forms.TextBox txtVenueID;
        private System.Windows.Forms.Label lblVenueID;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblEircode;
        private System.Windows.Forms.TextBox txtStreet2;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStreet1;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.GroupBox grpEventDetails;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.NumericUpDown nudAdultTktPrice;
        private System.Windows.Forms.NumericUpDown nudChildTktPrice;
        private System.Windows.Forms.NumericUpDown nudMaxTix;
        private System.Windows.Forms.Label lblAvailTickets;
        private System.Windows.Forms.Label lblAdultTktPrice;
        private System.Windows.Forms.Label lblChildTktPrice;
        private System.Windows.Forms.CheckBox chkDetails;
        private System.Windows.Forms.Label lblVenueDetails;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblEventID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtEventID;
        private System.Windows.Forms.ComboBox cboVenue;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.TextBox txtDesc;
    }
}