
namespace TicketSYS
{
    partial class frmRefundTicketSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRefundTicketSale));
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuItemBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpVDetails = new System.Windows.Forms.GroupBox();
            this.lblVenue = new System.Windows.Forms.Label();
            this.txtVenue = new System.Windows.Forms.TextBox();
            this.txtEircode = new System.Windows.Forms.TextBox();
            this.txtVenueID = new System.Windows.Forms.TextBox();
            this.lblVenueID = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtVdMaxCap = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblVdMaxCap = new System.Windows.Forms.Label();
            this.lblEircode = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.grpEDetails = new System.Windows.Forms.GroupBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblEventID = new System.Windows.Forms.Label();
            this.txtEventID = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtAdultTktPrice = new System.Windows.Forms.TextBox();
            this.txtChildTktPrice = new System.Windows.Forms.TextBox();
            this.txtAvailTix = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblAdultTktPrice = new System.Windows.Forms.Label();
            this.lblChildTktPrice = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAvailTix = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cboVenue = new System.Windows.Forms.ComboBox();
            this.lblFtVenue = new System.Windows.Forms.Label();
            this.lblEvent = new System.Windows.Forms.Label();
            this.cboEvent = new System.Windows.Forms.ComboBox();
            this.grpRefundTicketSale = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTicketID = new System.Windows.Forms.ComboBox();
            this.lblTicketID = new System.Windows.Forms.Label();
            this.chkEDetails = new System.Windows.Forms.CheckBox();
            this.lblEventDetails = new System.Windows.Forms.Label();
            this.chkVDetails = new System.Windows.Forms.CheckBox();
            this.lblVenueDetails = new System.Windows.Forms.Label();
            this.txtChildTktQty = new System.Windows.Forms.TextBox();
            this.lblChildTixQty = new System.Windows.Forms.Label();
            this.txtAdultTktQty = new System.Windows.Forms.TextBox();
            this.lblAdultTixQty = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnRefundSale = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.mnuMainMenu.SuspendLayout();
            this.grpVDetails.SuspendLayout();
            this.grpEDetails.SuspendLayout();
            this.grpFilter.SuspendLayout();
            this.grpRefundTicketSale.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemBack});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(1800, 45);
            this.mnuMainMenu.TabIndex = 1;
            this.mnuMainMenu.Text = "menuStrip1";
            // 
            // mnuItemBack
            // 
            this.mnuItemBack.Name = "mnuItemBack";
            this.mnuItemBack.Size = new System.Drawing.Size(93, 41);
            this.mnuItemBack.Text = "Back";
            this.mnuItemBack.Click += new System.EventHandler(this.exitToolStripMnuItem_Click);
            // 
            // grpVDetails
            // 
            this.grpVDetails.Controls.Add(this.lblVenue);
            this.grpVDetails.Controls.Add(this.txtVenue);
            this.grpVDetails.Controls.Add(this.txtEircode);
            this.grpVDetails.Controls.Add(this.txtVenueID);
            this.grpVDetails.Controls.Add(this.lblVenueID);
            this.grpVDetails.Controls.Add(this.lblStreet);
            this.grpVDetails.Controls.Add(this.txtVdMaxCap);
            this.grpVDetails.Controls.Add(this.txtCity);
            this.grpVDetails.Controls.Add(this.lblVdMaxCap);
            this.grpVDetails.Controls.Add(this.lblEircode);
            this.grpVDetails.Controls.Add(this.txtStreet);
            this.grpVDetails.Controls.Add(this.lblCity);
            this.grpVDetails.Location = new System.Drawing.Point(937, 51);
            this.grpVDetails.Name = "grpVDetails";
            this.grpVDetails.Size = new System.Drawing.Size(809, 434);
            this.grpVDetails.TabIndex = 56;
            this.grpVDetails.TabStop = false;
            this.grpVDetails.Text = "Venue Details";
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.Location = new System.Drawing.Point(190, 126);
            this.lblVenue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(96, 37);
            this.lblVenue.TabIndex = 26;
            this.lblVenue.Text = "Venue:";
            // 
            // txtVenue
            // 
            this.txtVenue.BackColor = System.Drawing.Color.Black;
            this.txtVenue.ForeColor = System.Drawing.Color.White;
            this.txtVenue.Location = new System.Drawing.Point(338, 118);
            this.txtVenue.Margin = new System.Windows.Forms.Padding(2);
            this.txtVenue.Name = "txtVenue";
            this.txtVenue.ReadOnly = true;
            this.txtVenue.Size = new System.Drawing.Size(445, 43);
            this.txtVenue.TabIndex = 27;
            // 
            // txtEircode
            // 
            this.txtEircode.BackColor = System.Drawing.Color.Black;
            this.txtEircode.ForeColor = System.Drawing.Color.White;
            this.txtEircode.Location = new System.Drawing.Point(338, 302);
            this.txtEircode.Margin = new System.Windows.Forms.Padding(2);
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.ReadOnly = true;
            this.txtEircode.Size = new System.Drawing.Size(139, 43);
            this.txtEircode.TabIndex = 25;
            // 
            // txtVenueID
            // 
            this.txtVenueID.BackColor = System.Drawing.Color.Black;
            this.txtVenueID.ForeColor = System.Drawing.Color.White;
            this.txtVenueID.Location = new System.Drawing.Point(338, 51);
            this.txtVenueID.Margin = new System.Windows.Forms.Padding(2);
            this.txtVenueID.Name = "txtVenueID";
            this.txtVenueID.ReadOnly = true;
            this.txtVenueID.Size = new System.Drawing.Size(88, 43);
            this.txtVenueID.TabIndex = 17;
            // 
            // lblVenueID
            // 
            this.lblVenueID.AutoSize = true;
            this.lblVenueID.Location = new System.Drawing.Point(157, 61);
            this.lblVenueID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVenueID.Name = "lblVenueID";
            this.lblVenueID.Size = new System.Drawing.Size(129, 37);
            this.lblVenueID.TabIndex = 16;
            this.lblVenueID.Text = "Venue ID:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(92, 191);
            this.lblStreet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(192, 37);
            this.lblStreet.TabIndex = 18;
            this.lblStreet.Text = "Street Address:";
            // 
            // txtVdMaxCap
            // 
            this.txtVdMaxCap.BackColor = System.Drawing.Color.Black;
            this.txtVdMaxCap.ForeColor = System.Drawing.Color.White;
            this.txtVdMaxCap.Location = new System.Drawing.Point(338, 371);
            this.txtVdMaxCap.Margin = new System.Windows.Forms.Padding(2);
            this.txtVdMaxCap.Name = "txtVdMaxCap";
            this.txtVdMaxCap.ReadOnly = true;
            this.txtVdMaxCap.Size = new System.Drawing.Size(139, 43);
            this.txtVdMaxCap.TabIndex = 13;
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.Black;
            this.txtCity.ForeColor = System.Drawing.Color.White;
            this.txtCity.Location = new System.Drawing.Point(338, 240);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(445, 43);
            this.txtCity.TabIndex = 23;
            // 
            // lblVdMaxCap
            // 
            this.lblVdMaxCap.AutoSize = true;
            this.lblVdMaxCap.Location = new System.Drawing.Point(110, 379);
            this.lblVdMaxCap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVdMaxCap.Name = "lblVdMaxCap";
            this.lblVdMaxCap.Size = new System.Drawing.Size(182, 37);
            this.lblVdMaxCap.TabIndex = 10;
            this.lblVdMaxCap.Text = "Max Capacity:";
            // 
            // lblEircode
            // 
            this.lblEircode.AutoSize = true;
            this.lblEircode.Location = new System.Drawing.Point(178, 310);
            this.lblEircode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEircode.Name = "lblEircode";
            this.lblEircode.Size = new System.Drawing.Size(111, 37);
            this.lblEircode.TabIndex = 21;
            this.lblEircode.Text = "Eircode:";
            // 
            // txtStreet
            // 
            this.txtStreet.BackColor = System.Drawing.Color.Black;
            this.txtStreet.ForeColor = System.Drawing.Color.White;
            this.txtStreet.Location = new System.Drawing.Point(338, 180);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(2);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.ReadOnly = true;
            this.txtStreet.Size = new System.Drawing.Size(445, 43);
            this.txtStreet.TabIndex = 20;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(222, 251);
            this.lblCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(69, 37);
            this.lblCity.TabIndex = 19;
            this.lblCity.Text = "City:";
            // 
            // grpEDetails
            // 
            this.grpEDetails.Controls.Add(this.lblDescription);
            this.grpEDetails.Controls.Add(this.dtpTime);
            this.grpEDetails.Controls.Add(this.dtpDate);
            this.grpEDetails.Controls.Add(this.lblEventID);
            this.grpEDetails.Controls.Add(this.txtEventID);
            this.grpEDetails.Controls.Add(this.txtDescription);
            this.grpEDetails.Controls.Add(this.txtAdultTktPrice);
            this.grpEDetails.Controls.Add(this.txtChildTktPrice);
            this.grpEDetails.Controls.Add(this.txtAvailTix);
            this.grpEDetails.Controls.Add(this.lblTime);
            this.grpEDetails.Controls.Add(this.lblAdultTktPrice);
            this.grpEDetails.Controls.Add(this.lblChildTktPrice);
            this.grpEDetails.Controls.Add(this.txtTitle);
            this.grpEDetails.Controls.Add(this.lblTitle);
            this.grpEDetails.Controls.Add(this.lblAvailTix);
            this.grpEDetails.Controls.Add(this.lblDate);
            this.grpEDetails.Location = new System.Drawing.Point(937, 525);
            this.grpEDetails.Name = "grpEDetails";
            this.grpEDetails.Size = new System.Drawing.Size(809, 617);
            this.grpEDetails.TabIndex = 57;
            this.grpEDetails.TabStop = false;
            this.grpEDetails.Text = "Event Details";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(22, 199);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(230, 37);
            this.lblDescription.TabIndex = 59;
            this.lblDescription.Text = "Event Description:";
            this.lblDescription.Click += new System.EventHandler(this.lblDescription_Click);
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "HH:mm";
            this.dtpTime.Enabled = false;
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(327, 335);
            this.dtpTime.MaxDate = new System.DateTime(2030, 1, 31, 0, 0, 0, 0);
            this.dtpTime.MinDate = new System.DateTime(2021, 12, 13, 2, 57, 8, 0);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(181, 43);
            this.dtpTime.TabIndex = 58;
            this.dtpTime.Value = new System.DateTime(2021, 12, 18, 0, 17, 59, 767);
            // 
            // dtpDate
            // 
            this.dtpDate.Enabled = false;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(327, 262);
            this.dtpDate.MaxDate = new System.DateTime(2026, 12, 18, 5, 48, 41, 915);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(181, 43);
            this.dtpDate.TabIndex = 57;
            this.dtpDate.Value = new System.DateTime(2021, 12, 18, 0, 17, 59, 768);
            // 
            // lblEventID
            // 
            this.lblEventID.AutoSize = true;
            this.lblEventID.Location = new System.Drawing.Point(135, 71);
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
            this.txtEventID.Location = new System.Drawing.Point(325, 60);
            this.txtEventID.Margin = new System.Windows.Forms.Padding(2);
            this.txtEventID.Name = "txtEventID";
            this.txtEventID.ReadOnly = true;
            this.txtEventID.Size = new System.Drawing.Size(88, 43);
            this.txtEventID.TabIndex = 3;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.Black;
            this.txtDescription.ForeColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(327, 191);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(445, 43);
            this.txtDescription.TabIndex = 60;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // txtAdultTktPrice
            // 
            this.txtAdultTktPrice.BackColor = System.Drawing.Color.Black;
            this.txtAdultTktPrice.ForeColor = System.Drawing.Color.White;
            this.txtAdultTktPrice.Location = new System.Drawing.Point(327, 545);
            this.txtAdultTktPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdultTktPrice.Name = "txtAdultTktPrice";
            this.txtAdultTktPrice.ReadOnly = true;
            this.txtAdultTktPrice.Size = new System.Drawing.Size(127, 43);
            this.txtAdultTktPrice.TabIndex = 52;
            // 
            // txtChildTktPrice
            // 
            this.txtChildTktPrice.BackColor = System.Drawing.Color.Black;
            this.txtChildTktPrice.ForeColor = System.Drawing.Color.White;
            this.txtChildTktPrice.Location = new System.Drawing.Point(327, 476);
            this.txtChildTktPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtChildTktPrice.Name = "txtChildTktPrice";
            this.txtChildTktPrice.ReadOnly = true;
            this.txtChildTktPrice.Size = new System.Drawing.Size(127, 43);
            this.txtChildTktPrice.TabIndex = 51;
            // 
            // txtAvailTix
            // 
            this.txtAvailTix.BackColor = System.Drawing.Color.Black;
            this.txtAvailTix.ForeColor = System.Drawing.Color.White;
            this.txtAvailTix.Location = new System.Drawing.Point(327, 406);
            this.txtAvailTix.Margin = new System.Windows.Forms.Padding(2);
            this.txtAvailTix.Name = "txtAvailTix";
            this.txtAvailTix.ReadOnly = true;
            this.txtAvailTix.Size = new System.Drawing.Size(127, 43);
            this.txtAvailTix.TabIndex = 50;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(104, 343);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(153, 37);
            this.lblTime.TabIndex = 49;
            this.lblTime.Text = "Event Time:";
            // 
            // lblAdultTktPrice
            // 
            this.lblAdultTktPrice.AutoSize = true;
            this.lblAdultTktPrice.Location = new System.Drawing.Point(24, 553);
            this.lblAdultTktPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdultTktPrice.Name = "lblAdultTktPrice";
            this.lblAdultTktPrice.Size = new System.Drawing.Size(227, 37);
            this.lblAdultTktPrice.TabIndex = 30;
            this.lblAdultTktPrice.Text = "Adult Ticket Price:";
            this.lblAdultTktPrice.Click += new System.EventHandler(this.lblAdultTktPrice_Click);
            // 
            // lblChildTktPrice
            // 
            this.lblChildTktPrice.AutoSize = true;
            this.lblChildTktPrice.Location = new System.Drawing.Point(30, 484);
            this.lblChildTktPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChildTktPrice.Name = "lblChildTktPrice";
            this.lblChildTktPrice.Size = new System.Drawing.Size(225, 37);
            this.lblChildTktPrice.TabIndex = 29;
            this.lblChildTktPrice.Text = "Child Ticket Price:";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.Black;
            this.txtTitle.ForeColor = System.Drawing.Color.White;
            this.txtTitle.Location = new System.Drawing.Point(327, 124);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(445, 43);
            this.txtTitle.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(112, 134);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(146, 37);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Event Title:";
            // 
            // lblAvailTix
            // 
            this.lblAvailTix.AutoSize = true;
            this.lblAvailTix.Location = new System.Drawing.Point(39, 414);
            this.lblAvailTix.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvailTix.Name = "lblAvailTix";
            this.lblAvailTix.Size = new System.Drawing.Size(218, 37);
            this.lblAvailTix.TabIndex = 33;
            this.lblAvailTix.Text = "Available Tickets:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(107, 271);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(151, 37);
            this.lblDate.TabIndex = 16;
            this.lblDate.Text = "Event Date:";
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.btnFilter);
            this.grpFilter.Controls.Add(this.cboVenue);
            this.grpFilter.Controls.Add(this.lblFtVenue);
            this.grpFilter.Controls.Add(this.lblEvent);
            this.grpFilter.Controls.Add(this.cboEvent);
            this.grpFilter.Location = new System.Drawing.Point(55, 51);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(817, 326);
            this.grpFilter.TabIndex = 55;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Filter Ticket";
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnFilter.Location = new System.Drawing.Point(179, 244);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(433, 52);
            this.btnFilter.TabIndex = 45;
            this.btnFilter.Text = "Filter Tickets";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboVenue
            // 
            this.cboVenue.FormattingEnabled = true;
            this.cboVenue.Items.AddRange(new object[] {
            "",
            "1 | 3Arena",
            "2 | Aviva Stadium"});
            this.cboVenue.Location = new System.Drawing.Point(275, 76);
            this.cboVenue.Name = "cboVenue";
            this.cboVenue.Size = new System.Drawing.Size(445, 45);
            this.cboVenue.TabIndex = 44;
            this.cboVenue.SelectedIndexChanged += new System.EventHandler(this.cboVenue_SelectedIndexChanged);
            // 
            // lblFtVenue
            // 
            this.lblFtVenue.AutoSize = true;
            this.lblFtVenue.Location = new System.Drawing.Point(110, 82);
            this.lblFtVenue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFtVenue.Name = "lblFtVenue";
            this.lblFtVenue.Size = new System.Drawing.Size(96, 37);
            this.lblFtVenue.TabIndex = 43;
            this.lblFtVenue.Text = "Venue:";
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Location = new System.Drawing.Point(120, 157);
            this.lblEvent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(88, 37);
            this.lblEvent.TabIndex = 19;
            this.lblEvent.Text = "Event:";
            // 
            // cboEvent
            // 
            this.cboEvent.FormattingEnabled = true;
            this.cboEvent.Location = new System.Drawing.Point(275, 150);
            this.cboEvent.Margin = new System.Windows.Forms.Padding(2);
            this.cboEvent.Name = "cboEvent";
            this.cboEvent.Size = new System.Drawing.Size(267, 45);
            this.cboEvent.TabIndex = 20;
            this.cboEvent.SelectedIndexChanged += new System.EventHandler(this.cboEvent_SelectedIndexChanged);
            // 
            // grpRefundTicketSale
            // 
            this.grpRefundTicketSale.Controls.Add(this.txtTotal);
            this.grpRefundTicketSale.Controls.Add(this.label1);
            this.grpRefundTicketSale.Controls.Add(this.cboTicketID);
            this.grpRefundTicketSale.Controls.Add(this.lblTicketID);
            this.grpRefundTicketSale.Controls.Add(this.chkEDetails);
            this.grpRefundTicketSale.Controls.Add(this.lblEventDetails);
            this.grpRefundTicketSale.Controls.Add(this.chkVDetails);
            this.grpRefundTicketSale.Controls.Add(this.lblVenueDetails);
            this.grpRefundTicketSale.Controls.Add(this.txtChildTktQty);
            this.grpRefundTicketSale.Controls.Add(this.lblChildTixQty);
            this.grpRefundTicketSale.Controls.Add(this.txtAdultTktQty);
            this.grpRefundTicketSale.Controls.Add(this.lblAdultTixQty);
            this.grpRefundTicketSale.Controls.Add(this.txtLastName);
            this.grpRefundTicketSale.Controls.Add(this.lblLastName);
            this.grpRefundTicketSale.Controls.Add(this.txtPhoneNum);
            this.grpRefundTicketSale.Controls.Add(this.lblPhoneNum);
            this.grpRefundTicketSale.Controls.Add(this.txtFirstName);
            this.grpRefundTicketSale.Controls.Add(this.btnRefundSale);
            this.grpRefundTicketSale.Controls.Add(this.lblFirstName);
            this.grpRefundTicketSale.Controls.Add(this.txtEmail);
            this.grpRefundTicketSale.Controls.Add(this.lblEmail);
            this.grpRefundTicketSale.Location = new System.Drawing.Point(55, 407);
            this.grpRefundTicketSale.Margin = new System.Windows.Forms.Padding(2);
            this.grpRefundTicketSale.Name = "grpRefundTicketSale";
            this.grpRefundTicketSale.Padding = new System.Windows.Forms.Padding(2);
            this.grpRefundTicketSale.Size = new System.Drawing.Size(817, 828);
            this.grpRefundTicketSale.TabIndex = 54;
            this.grpRefundTicketSale.TabStop = false;
            this.grpRefundTicketSale.Text = "Refund Ticket Sale";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.Black;
            this.txtTotal.ForeColor = System.Drawing.Color.White;
            this.txtTotal.Location = new System.Drawing.Point(323, 658);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(123, 43);
            this.txtTotal.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 666);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 37);
            this.label1.TabIndex = 54;
            this.label1.Text = "Sale Total:";
            // 
            // cboTicketID
            // 
            this.cboTicketID.FormattingEnabled = true;
            this.cboTicketID.Location = new System.Drawing.Point(323, 59);
            this.cboTicketID.Margin = new System.Windows.Forms.Padding(2);
            this.cboTicketID.Name = "cboTicketID";
            this.cboTicketID.Size = new System.Drawing.Size(267, 45);
            this.cboTicketID.TabIndex = 53;
            this.cboTicketID.SelectedIndexChanged += new System.EventHandler(this.cboTicketID_SelectedIndexChanged);
            // 
            // lblTicketID
            // 
            this.lblTicketID.AutoSize = true;
            this.lblTicketID.Location = new System.Drawing.Point(133, 66);
            this.lblTicketID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTicketID.Name = "lblTicketID";
            this.lblTicketID.Size = new System.Drawing.Size(125, 37);
            this.lblTicketID.TabIndex = 47;
            this.lblTicketID.Text = "Ticket ID:";
            // 
            // chkEDetails
            // 
            this.chkEDetails.AutoSize = true;
            this.chkEDetails.Checked = true;
            this.chkEDetails.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEDetails.Location = new System.Drawing.Point(323, 190);
            this.chkEDetails.Name = "chkEDetails";
            this.chkEDetails.Size = new System.Drawing.Size(28, 27);
            this.chkEDetails.TabIndex = 52;
            this.chkEDetails.UseVisualStyleBackColor = true;
            this.chkEDetails.CheckedChanged += new System.EventHandler(this.chkEventDetails_CheckedChanged);
            // 
            // lblEventDetails
            // 
            this.lblEventDetails.AutoSize = true;
            this.lblEventDetails.Location = new System.Drawing.Point(88, 184);
            this.lblEventDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventDetails.Name = "lblEventDetails";
            this.lblEventDetails.Size = new System.Drawing.Size(176, 37);
            this.lblEventDetails.TabIndex = 51;
            this.lblEventDetails.Text = "Event Details:";
            this.lblEventDetails.Click += new System.EventHandler(this.lblEventDetails_Click);
            // 
            // chkVDetails
            // 
            this.chkVDetails.AutoSize = true;
            this.chkVDetails.Checked = true;
            this.chkVDetails.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVDetails.Location = new System.Drawing.Point(323, 133);
            this.chkVDetails.Name = "chkVDetails";
            this.chkVDetails.Size = new System.Drawing.Size(28, 27);
            this.chkVDetails.TabIndex = 50;
            this.chkVDetails.UseVisualStyleBackColor = true;
            this.chkVDetails.CheckedChanged += new System.EventHandler(this.chkVenueDetails_CheckedChanged);
            // 
            // lblVenueDetails
            // 
            this.lblVenueDetails.AutoSize = true;
            this.lblVenueDetails.Location = new System.Drawing.Point(82, 128);
            this.lblVenueDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVenueDetails.Name = "lblVenueDetails";
            this.lblVenueDetails.Size = new System.Drawing.Size(184, 37);
            this.lblVenueDetails.TabIndex = 49;
            this.lblVenueDetails.Text = "Venue Details:";
            // 
            // txtChildTktQty
            // 
            this.txtChildTktQty.BackColor = System.Drawing.Color.Black;
            this.txtChildTktQty.ForeColor = System.Drawing.Color.White;
            this.txtChildTktQty.Location = new System.Drawing.Point(323, 587);
            this.txtChildTktQty.Margin = new System.Windows.Forms.Padding(2);
            this.txtChildTktQty.Name = "txtChildTktQty";
            this.txtChildTktQty.ReadOnly = true;
            this.txtChildTktQty.Size = new System.Drawing.Size(87, 43);
            this.txtChildTktQty.TabIndex = 26;
            // 
            // lblChildTixQty
            // 
            this.lblChildTixQty.AutoSize = true;
            this.lblChildTixQty.Location = new System.Drawing.Point(55, 593);
            this.lblChildTixQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChildTixQty.Name = "lblChildTixQty";
            this.lblChildTixQty.Size = new System.Drawing.Size(210, 37);
            this.lblChildTixQty.TabIndex = 25;
            this.lblChildTixQty.Text = "Child Ticket Qty:";
            // 
            // txtAdultTktQty
            // 
            this.txtAdultTktQty.BackColor = System.Drawing.Color.Black;
            this.txtAdultTktQty.ForeColor = System.Drawing.Color.White;
            this.txtAdultTktQty.Location = new System.Drawing.Point(323, 516);
            this.txtAdultTktQty.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdultTktQty.Name = "txtAdultTktQty";
            this.txtAdultTktQty.ReadOnly = true;
            this.txtAdultTktQty.Size = new System.Drawing.Size(87, 43);
            this.txtAdultTktQty.TabIndex = 24;
            // 
            // lblAdultTixQty
            // 
            this.lblAdultTixQty.AutoSize = true;
            this.lblAdultTixQty.Location = new System.Drawing.Point(129, 519);
            this.lblAdultTixQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdultTixQty.Name = "lblAdultTixQty";
            this.lblAdultTixQty.Size = new System.Drawing.Size(136, 37);
            this.lblAdultTixQty.TabIndex = 23;
            this.lblAdultTixQty.Text = "Adult Qty:";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.Black;
            this.txtLastName.ForeColor = System.Drawing.Color.White;
            this.txtLastName.Location = new System.Drawing.Point(323, 314);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(445, 43);
            this.txtLastName.TabIndex = 22;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(118, 320);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(148, 37);
            this.lblLastName.TabIndex = 21;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.BackColor = System.Drawing.Color.Black;
            this.txtPhoneNum.ForeColor = System.Drawing.Color.White;
            this.txtPhoneNum.Location = new System.Drawing.Point(323, 446);
            this.txtPhoneNum.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.ReadOnly = true;
            this.txtPhoneNum.Size = new System.Drawing.Size(445, 43);
            this.txtPhoneNum.TabIndex = 16;
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Location = new System.Drawing.Point(62, 446);
            this.lblPhoneNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(202, 37);
            this.lblPhoneNum.TabIndex = 15;
            this.lblPhoneNum.Text = "Phone Number:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.Black;
            this.txtFirstName.ForeColor = System.Drawing.Color.White;
            this.txtFirstName.Location = new System.Drawing.Point(323, 256);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(445, 43);
            this.txtFirstName.TabIndex = 10;
            // 
            // btnRefundSale
            // 
            this.btnRefundSale.Location = new System.Drawing.Point(82, 741);
            this.btnRefundSale.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefundSale.Name = "btnRefundSale";
            this.btnRefundSale.Size = new System.Drawing.Size(637, 52);
            this.btnRefundSale.TabIndex = 14;
            this.btnRefundSale.Text = "Refund Sale";
            this.btnRefundSale.UseVisualStyleBackColor = true;
            this.btnRefundSale.Click += new System.EventHandler(this.btnRefundSale_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(115, 261);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(150, 37);
            this.lblFirstName.TabIndex = 9;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Black;
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(323, 379);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(445, 43);
            this.txtEmail.TabIndex = 13;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(77, 384);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(189, 37);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email Address:";
            // 
            // frmRefundTicketSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 1263);
            this.Controls.Add(this.grpVDetails);
            this.Controls.Add(this.grpEDetails);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.grpRefundTicketSale);
            this.Controls.Add(this.mnuMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRefundTicketSale";
            this.Text = "Refund Ticket Sale";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDeleteSale_FormClosed);
            this.Load += new System.EventHandler(this.frmDeleteSale_Load);
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.grpVDetails.ResumeLayout(false);
            this.grpVDetails.PerformLayout();
            this.grpEDetails.ResumeLayout(false);
            this.grpEDetails.PerformLayout();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.grpRefundTicketSale.ResumeLayout(false);
            this.grpRefundTicketSale.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuItemBack;
        private System.Windows.Forms.GroupBox grpVDetails;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.TextBox txtVenue;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.TextBox txtVenueID;
        private System.Windows.Forms.Label lblVenueID;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtVdMaxCap;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblVdMaxCap;
        private System.Windows.Forms.Label lblEircode;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.GroupBox grpEDetails;
        private System.Windows.Forms.TextBox txtAdultTktPrice;
        private System.Windows.Forms.TextBox txtChildTktPrice;
        private System.Windows.Forms.TextBox txtAvailTix;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblAdultTktPrice;
        private System.Windows.Forms.Label lblChildTktPrice;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAvailTix;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cboVenue;
        private System.Windows.Forms.Label lblFtVenue;
        private System.Windows.Forms.Label lblEventID;
        private System.Windows.Forms.TextBox txtEventID;
        private System.Windows.Forms.GroupBox grpRefundTicketSale;
        private System.Windows.Forms.Label lblTicketID;
        private System.Windows.Forms.CheckBox chkEDetails;
        private System.Windows.Forms.Label lblEventDetails;
        private System.Windows.Forms.CheckBox chkVDetails;
        private System.Windows.Forms.Label lblVenueDetails;
        private System.Windows.Forms.TextBox txtChildTktQty;
        private System.Windows.Forms.Label lblChildTixQty;
        private System.Windows.Forms.TextBox txtAdultTktQty;
        private System.Windows.Forms.Label lblAdultTixQty;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.ComboBox cboEvent;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnRefundSale;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ComboBox cboTicketID;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
    }
}