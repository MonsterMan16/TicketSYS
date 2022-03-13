
namespace TicketSYS
{
    partial class frmEventSalesAnalysis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEventSalesAnalysis));
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuItemBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.cboVenue = new System.Windows.Forms.ComboBox();
            this.lblVenue = new System.Windows.Forms.Label();
            this.btnFilterEvent = new System.Windows.Forms.Button();
            this.chkEDetails = new System.Windows.Forms.CheckBox();
            this.lblEDetails = new System.Windows.Forms.Label();
            this.chkVDetails = new System.Windows.Forms.CheckBox();
            this.lblVDetails = new System.Windows.Forms.Label();
            this.lblEventID = new System.Windows.Forms.Label();
            this.txtEventID = new System.Windows.Forms.TextBox();
            this.grpEDetails = new System.Windows.Forms.GroupBox();
            this.lblEventCap = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtEdEventCap = new System.Windows.Forms.TextBox();
            this.txtAdultTktPrice = new System.Windows.Forms.TextBox();
            this.txtChildTktPrice = new System.Windows.Forms.TextBox();
            this.txtAvailTix = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblAdultTktPrice = new System.Windows.Forms.Label();
            this.lblChildTktPrice = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAvailTix = new System.Windows.Forms.Label();
            this.lblEventDate = new System.Windows.Forms.Label();
            this.grpVDetails = new System.Windows.Forms.GroupBox();
            this.lblVeVenue = new System.Windows.Forms.Label();
            this.txtVenue = new System.Windows.Forms.TextBox();
            this.txtEircode = new System.Windows.Forms.TextBox();
            this.txtVenueID = new System.Windows.Forms.TextBox();
            this.lblVenueID = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtVdMaxCap = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblMaxCap = new System.Windows.Forms.Label();
            this.lblEircode = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.grpEvent = new System.Windows.Forms.GroupBox();
            this.btnGenerateAnalysis = new System.Windows.Forms.Button();
            this.cboEvent = new System.Windows.Forms.ComboBox();
            this.lblEvent = new System.Windows.Forms.Label();
            this.picEventSalesAnalysis = new System.Windows.Forms.PictureBox();
            this.grpAnalysis = new System.Windows.Forms.GroupBox();
            this.mnuMainMenu.SuspendLayout();
            this.grpFilter.SuspendLayout();
            this.grpEDetails.SuspendLayout();
            this.grpVDetails.SuspendLayout();
            this.grpEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEventSalesAnalysis)).BeginInit();
            this.grpAnalysis.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemBack});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnuMainMenu.Size = new System.Drawing.Size(1524, 40);
            this.mnuMainMenu.TabIndex = 2;
            this.mnuMainMenu.Text = "menuStrip1";
            // 
            // mnuItemBack
            // 
            this.mnuItemBack.Name = "mnuItemBack";
            this.mnuItemBack.Size = new System.Drawing.Size(83, 36);
            this.mnuItemBack.Text = "Back";
            this.mnuItemBack.Click += new System.EventHandler(this.exitToolStripMnuItem_Click);
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.cboVenue);
            this.grpFilter.Controls.Add(this.lblVenue);
            this.grpFilter.Controls.Add(this.btnFilterEvent);
            this.grpFilter.Location = new System.Drawing.Point(37, 69);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(708, 195);
            this.grpFilter.TabIndex = 59;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Filter Event";
            // 
            // cboVenue
            // 
            this.cboVenue.FormattingEnabled = true;
            this.cboVenue.Items.AddRange(new object[] {
            "",
            "1 | 3Arena",
            "2 | Aviva Stadium"});
            this.cboVenue.Location = new System.Drawing.Point(224, 55);
            this.cboVenue.Name = "cboVenue";
            this.cboVenue.Size = new System.Drawing.Size(386, 40);
            this.cboVenue.TabIndex = 44;
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.Location = new System.Drawing.Point(103, 63);
            this.lblVenue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(86, 32);
            this.lblVenue.TabIndex = 43;
            this.lblVenue.Text = "Venue:";
            // 
            // btnFilterEvent
            // 
            this.btnFilterEvent.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnFilterEvent.Location = new System.Drawing.Point(161, 128);
            this.btnFilterEvent.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilterEvent.Name = "btnFilterEvent";
            this.btnFilterEvent.Size = new System.Drawing.Size(375, 45);
            this.btnFilterEvent.TabIndex = 45;
            this.btnFilterEvent.Text = "Filter Event";
            this.btnFilterEvent.UseVisualStyleBackColor = false;
            this.btnFilterEvent.Click += new System.EventHandler(this.btnFilterEvent_Click);
            // 
            // chkEDetails
            // 
            this.chkEDetails.AutoSize = true;
            this.chkEDetails.Checked = true;
            this.chkEDetails.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEDetails.Location = new System.Drawing.Point(224, 244);
            this.chkEDetails.Name = "chkEDetails";
            this.chkEDetails.Size = new System.Drawing.Size(28, 27);
            this.chkEDetails.TabIndex = 56;
            this.chkEDetails.UseVisualStyleBackColor = true;
            this.chkEDetails.CheckedChanged += new System.EventHandler(this.chkEDetails_CheckedChanged);
            // 
            // lblEDetails
            // 
            this.lblEDetails.AutoSize = true;
            this.lblEDetails.Location = new System.Drawing.Point(32, 239);
            this.lblEDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEDetails.Name = "lblEDetails";
            this.lblEDetails.Size = new System.Drawing.Size(157, 32);
            this.lblEDetails.TabIndex = 55;
            this.lblEDetails.Text = "Event Details:";
            // 
            // chkVDetails
            // 
            this.chkVDetails.AutoSize = true;
            this.chkVDetails.Checked = true;
            this.chkVDetails.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVDetails.Location = new System.Drawing.Point(224, 187);
            this.chkVDetails.Name = "chkVDetails";
            this.chkVDetails.Size = new System.Drawing.Size(28, 27);
            this.chkVDetails.TabIndex = 54;
            this.chkVDetails.UseVisualStyleBackColor = true;
            this.chkVDetails.CheckedChanged += new System.EventHandler(this.chkVenueDetails_CheckedChanged);
            // 
            // lblVDetails
            // 
            this.lblVDetails.AutoSize = true;
            this.lblVDetails.Location = new System.Drawing.Point(24, 182);
            this.lblVDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVDetails.Name = "lblVDetails";
            this.lblVDetails.Size = new System.Drawing.Size(165, 32);
            this.lblVDetails.TabIndex = 53;
            this.lblVDetails.Text = "Venue Details:";
            // 
            // lblEventID
            // 
            this.lblEventID.AutoSize = true;
            this.lblEventID.Location = new System.Drawing.Point(81, 49);
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
            this.txtEventID.Location = new System.Drawing.Point(224, 42);
            this.txtEventID.Margin = new System.Windows.Forms.Padding(2);
            this.txtEventID.Name = "txtEventID";
            this.txtEventID.ReadOnly = true;
            this.txtEventID.Size = new System.Drawing.Size(77, 39);
            this.txtEventID.TabIndex = 3;
            // 
            // grpEDetails
            // 
            this.grpEDetails.Controls.Add(this.lblEventCap);
            this.grpEDetails.Controls.Add(this.dtpTime);
            this.grpEDetails.Controls.Add(this.dtpDate);
            this.grpEDetails.Controls.Add(this.txtDescription);
            this.grpEDetails.Controls.Add(this.lblDescription);
            this.grpEDetails.Controls.Add(this.txtEdEventCap);
            this.grpEDetails.Controls.Add(this.txtAdultTktPrice);
            this.grpEDetails.Controls.Add(this.txtChildTktPrice);
            this.grpEDetails.Controls.Add(this.txtAvailTix);
            this.grpEDetails.Controls.Add(this.lblTime);
            this.grpEDetails.Controls.Add(this.lblAdultTktPrice);
            this.grpEDetails.Controls.Add(this.lblChildTktPrice);
            this.grpEDetails.Controls.Add(this.txtTitle);
            this.grpEDetails.Controls.Add(this.lblTitle);
            this.grpEDetails.Controls.Add(this.lblAvailTix);
            this.grpEDetails.Controls.Add(this.lblEventDate);
            this.grpEDetails.Location = new System.Drawing.Point(782, 491);
            this.grpEDetails.Name = "grpEDetails";
            this.grpEDetails.Size = new System.Drawing.Size(701, 596);
            this.grpEDetails.TabIndex = 61;
            this.grpEDetails.TabStop = false;
            this.grpEDetails.Text = "Event Details";
            // 
            // lblEventCap
            // 
            this.lblEventCap.AutoSize = true;
            this.lblEventCap.Location = new System.Drawing.Point(61, 391);
            this.lblEventCap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventCap.Name = "lblEventCap";
            this.lblEventCap.Size = new System.Drawing.Size(175, 32);
            this.lblEventCap.TabIndex = 65;
            this.lblEventCap.Text = "Event Capacity:";
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "HH:mm";
            this.dtpTime.Enabled = false;
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(289, 255);
            this.dtpTime.MaxDate = new System.DateTime(2030, 1, 31, 0, 0, 0, 0);
            this.dtpTime.MinDate = new System.DateTime(2021, 12, 13, 2, 57, 8, 0);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(157, 39);
            this.dtpTime.TabIndex = 64;
            this.dtpTime.Value = new System.DateTime(2021, 12, 18, 0, 17, 59, 767);
            // 
            // dtpDate
            // 
            this.dtpDate.Enabled = false;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(289, 189);
            this.dtpDate.MaxDate = new System.DateTime(2026, 12, 18, 5, 48, 41, 915);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(157, 39);
            this.dtpDate.TabIndex = 63;
            this.dtpDate.Value = new System.DateTime(2021, 12, 18, 0, 17, 59, 768);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.Black;
            this.txtDescription.ForeColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(290, 128);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(386, 39);
            this.txtDescription.TabIndex = 56;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(30, 135);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(206, 32);
            this.lblDescription.TabIndex = 55;
            this.lblDescription.Text = "Event Description:";
            // 
            // txtEdEventCap
            // 
            this.txtEdEventCap.BackColor = System.Drawing.Color.Black;
            this.txtEdEventCap.ForeColor = System.Drawing.Color.White;
            this.txtEdEventCap.Location = new System.Drawing.Point(289, 384);
            this.txtEdEventCap.Margin = new System.Windows.Forms.Padding(2);
            this.txtEdEventCap.Name = "txtEdEventCap";
            this.txtEdEventCap.ReadOnly = true;
            this.txtEdEventCap.Size = new System.Drawing.Size(111, 39);
            this.txtEdEventCap.TabIndex = 54;
            // 
            // txtAdultTktPrice
            // 
            this.txtAdultTktPrice.BackColor = System.Drawing.Color.Black;
            this.txtAdultTktPrice.ForeColor = System.Drawing.Color.White;
            this.txtAdultTktPrice.Location = new System.Drawing.Point(289, 510);
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
            this.txtChildTktPrice.Location = new System.Drawing.Point(289, 446);
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
            this.txtAvailTix.Location = new System.Drawing.Point(289, 320);
            this.txtAvailTix.Margin = new System.Windows.Forms.Padding(2);
            this.txtAvailTix.Name = "txtAvailTix";
            this.txtAvailTix.ReadOnly = true;
            this.txtAvailTix.Size = new System.Drawing.Size(111, 39);
            this.txtAvailTix.TabIndex = 50;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(98, 262);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(138, 32);
            this.lblTime.TabIndex = 49;
            this.lblTime.Text = "Event Time:";
            // 
            // lblAdultTktPrice
            // 
            this.lblAdultTktPrice.AutoSize = true;
            this.lblAdultTktPrice.Location = new System.Drawing.Point(32, 517);
            this.lblAdultTktPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdultTktPrice.Name = "lblAdultTktPrice";
            this.lblAdultTktPrice.Size = new System.Drawing.Size(204, 32);
            this.lblAdultTktPrice.TabIndex = 30;
            this.lblAdultTktPrice.Text = "Adult Ticket Price:";
            // 
            // lblChildTktPrice
            // 
            this.lblChildTktPrice.AutoSize = true;
            this.lblChildTktPrice.Location = new System.Drawing.Point(34, 453);
            this.lblChildTktPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChildTktPrice.Name = "lblChildTktPrice";
            this.lblChildTktPrice.Size = new System.Drawing.Size(202, 32);
            this.lblChildTktPrice.TabIndex = 29;
            this.lblChildTktPrice.Text = "Child Ticket Price:";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.Black;
            this.txtTitle.ForeColor = System.Drawing.Color.White;
            this.txtTitle.Location = new System.Drawing.Point(289, 70);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(386, 39);
            this.txtTitle.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(105, 77);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(131, 32);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Event Title:";
            // 
            // lblAvailTix
            // 
            this.lblAvailTix.AutoSize = true;
            this.lblAvailTix.Location = new System.Drawing.Point(41, 327);
            this.lblAvailTix.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvailTix.Name = "lblAvailTix";
            this.lblAvailTix.Size = new System.Drawing.Size(195, 32);
            this.lblAvailTix.TabIndex = 33;
            this.lblAvailTix.Text = "Available Tickets:";
            // 
            // lblEventDate
            // 
            this.lblEventDate.AutoSize = true;
            this.lblEventDate.Location = new System.Drawing.Point(101, 196);
            this.lblEventDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventDate.Name = "lblEventDate";
            this.lblEventDate.Size = new System.Drawing.Size(135, 32);
            this.lblEventDate.TabIndex = 16;
            this.lblEventDate.Text = "Event Date:";
            // 
            // grpVDetails
            // 
            this.grpVDetails.Controls.Add(this.lblVeVenue);
            this.grpVDetails.Controls.Add(this.txtVenue);
            this.grpVDetails.Controls.Add(this.txtEircode);
            this.grpVDetails.Controls.Add(this.txtVenueID);
            this.grpVDetails.Controls.Add(this.lblVenueID);
            this.grpVDetails.Controls.Add(this.lblStreet);
            this.grpVDetails.Controls.Add(this.txtVdMaxCap);
            this.grpVDetails.Controls.Add(this.txtCity);
            this.grpVDetails.Controls.Add(this.lblMaxCap);
            this.grpVDetails.Controls.Add(this.lblEircode);
            this.grpVDetails.Controls.Add(this.txtStreet);
            this.grpVDetails.Controls.Add(this.lblCity);
            this.grpVDetails.Location = new System.Drawing.Point(782, 69);
            this.grpVDetails.Name = "grpVDetails";
            this.grpVDetails.Size = new System.Drawing.Size(701, 375);
            this.grpVDetails.TabIndex = 60;
            this.grpVDetails.TabStop = false;
            this.grpVDetails.Text = "Venue Details";
            // 
            // lblVeVenue
            // 
            this.lblVeVenue.AutoSize = true;
            this.lblVeVenue.Location = new System.Drawing.Point(166, 109);
            this.lblVeVenue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVeVenue.Name = "lblVeVenue";
            this.lblVeVenue.Size = new System.Drawing.Size(86, 32);
            this.lblVeVenue.TabIndex = 26;
            this.lblVeVenue.Text = "Venue:";
            // 
            // txtVenue
            // 
            this.txtVenue.BackColor = System.Drawing.Color.Black;
            this.txtVenue.ForeColor = System.Drawing.Color.White;
            this.txtVenue.Location = new System.Drawing.Point(293, 102);
            this.txtVenue.Margin = new System.Windows.Forms.Padding(2);
            this.txtVenue.Name = "txtVenue";
            this.txtVenue.ReadOnly = true;
            this.txtVenue.Size = new System.Drawing.Size(386, 39);
            this.txtVenue.TabIndex = 27;
            // 
            // txtEircode
            // 
            this.txtEircode.BackColor = System.Drawing.Color.Black;
            this.txtEircode.ForeColor = System.Drawing.Color.White;
            this.txtEircode.Location = new System.Drawing.Point(293, 261);
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
            this.txtVenueID.Location = new System.Drawing.Point(293, 44);
            this.txtVenueID.Margin = new System.Windows.Forms.Padding(2);
            this.txtVenueID.Name = "txtVenueID";
            this.txtVenueID.ReadOnly = true;
            this.txtVenueID.Size = new System.Drawing.Size(77, 39);
            this.txtVenueID.TabIndex = 17;
            // 
            // lblVenueID
            // 
            this.lblVenueID.AutoSize = true;
            this.lblVenueID.Location = new System.Drawing.Point(137, 54);
            this.lblVenueID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVenueID.Name = "lblVenueID";
            this.lblVenueID.Size = new System.Drawing.Size(116, 32);
            this.lblVenueID.TabIndex = 16;
            this.lblVenueID.Text = "Venue ID:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(80, 165);
            this.lblStreet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(172, 32);
            this.lblStreet.TabIndex = 18;
            this.lblStreet.Text = "Street Address:";
            // 
            // txtVdMaxCap
            // 
            this.txtVdMaxCap.BackColor = System.Drawing.Color.Black;
            this.txtVdMaxCap.ForeColor = System.Drawing.Color.White;
            this.txtVdMaxCap.Location = new System.Drawing.Point(293, 321);
            this.txtVdMaxCap.Margin = new System.Windows.Forms.Padding(2);
            this.txtVdMaxCap.Name = "txtVdMaxCap";
            this.txtVdMaxCap.ReadOnly = true;
            this.txtVdMaxCap.Size = new System.Drawing.Size(121, 39);
            this.txtVdMaxCap.TabIndex = 13;
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.Black;
            this.txtCity.ForeColor = System.Drawing.Color.White;
            this.txtCity.Location = new System.Drawing.Point(293, 208);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(386, 39);
            this.txtCity.TabIndex = 23;
            // 
            // lblMaxCap
            // 
            this.lblMaxCap.AutoSize = true;
            this.lblMaxCap.Location = new System.Drawing.Point(18, 324);
            this.lblMaxCap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxCap.Name = "lblMaxCap";
            this.lblMaxCap.Size = new System.Drawing.Size(235, 32);
            this.lblMaxCap.TabIndex = 10;
            this.lblMaxCap.Text = "Venue Max Capacity:";
            // 
            // lblEircode
            // 
            this.lblEircode.AutoSize = true;
            this.lblEircode.Location = new System.Drawing.Point(156, 268);
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
            this.txtStreet.Location = new System.Drawing.Point(293, 156);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(2);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.ReadOnly = true;
            this.txtStreet.Size = new System.Drawing.Size(386, 39);
            this.txtStreet.TabIndex = 20;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(193, 218);
            this.lblCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(60, 32);
            this.lblCity.TabIndex = 19;
            this.lblCity.Text = "City:";
            // 
            // grpEvent
            // 
            this.grpEvent.Controls.Add(this.btnGenerateAnalysis);
            this.grpEvent.Controls.Add(this.cboEvent);
            this.grpEvent.Controls.Add(this.lblEvent);
            this.grpEvent.Controls.Add(this.chkEDetails);
            this.grpEvent.Controls.Add(this.txtEventID);
            this.grpEvent.Controls.Add(this.lblEDetails);
            this.grpEvent.Controls.Add(this.lblEventID);
            this.grpEvent.Controls.Add(this.chkVDetails);
            this.grpEvent.Controls.Add(this.lblVDetails);
            this.grpEvent.Location = new System.Drawing.Point(37, 287);
            this.grpEvent.Margin = new System.Windows.Forms.Padding(2);
            this.grpEvent.Name = "grpEvent";
            this.grpEvent.Padding = new System.Windows.Forms.Padding(2);
            this.grpEvent.Size = new System.Drawing.Size(708, 376);
            this.grpEvent.TabIndex = 62;
            this.grpEvent.TabStop = false;
            this.grpEvent.Text = "Event";
            // 
            // btnGenerateAnalysis
            // 
            this.btnGenerateAnalysis.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnGenerateAnalysis.Location = new System.Drawing.Point(161, 303);
            this.btnGenerateAnalysis.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerateAnalysis.Name = "btnGenerateAnalysis";
            this.btnGenerateAnalysis.Size = new System.Drawing.Size(375, 45);
            this.btnGenerateAnalysis.TabIndex = 46;
            this.btnGenerateAnalysis.Text = "Generate Sales Analysis";
            this.btnGenerateAnalysis.UseVisualStyleBackColor = false;
            this.btnGenerateAnalysis.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboEvent
            // 
            this.cboEvent.FormattingEnabled = true;
            this.cboEvent.Location = new System.Drawing.Point(224, 110);
            this.cboEvent.Name = "cboEvent";
            this.cboEvent.Size = new System.Drawing.Size(386, 40);
            this.cboEvent.TabIndex = 47;
            this.cboEvent.SelectedIndexChanged += new System.EventHandler(this.cboEvent_SelectedIndexChanged_1);
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Location = new System.Drawing.Point(111, 118);
            this.lblEvent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(78, 32);
            this.lblEvent.TabIndex = 46;
            this.lblEvent.Text = "Event:";
            // 
            // picEventSalesAnalysis
            // 
            this.picEventSalesAnalysis.Image = ((System.Drawing.Image)(resources.GetObject("picEventSalesAnalysis.Image")));
            this.picEventSalesAnalysis.Location = new System.Drawing.Point(24, 52);
            this.picEventSalesAnalysis.Name = "picEventSalesAnalysis";
            this.picEventSalesAnalysis.Size = new System.Drawing.Size(663, 327);
            this.picEventSalesAnalysis.TabIndex = 63;
            this.picEventSalesAnalysis.TabStop = false;
            // 
            // grpAnalysis
            // 
            this.grpAnalysis.Visible = false;
            this.grpAnalysis.Controls.Add(this.picEventSalesAnalysis);
            this.grpAnalysis.Location = new System.Drawing.Point(37, 687);
            this.grpAnalysis.Name = "grpAnalysis";
            this.grpAnalysis.Size = new System.Drawing.Size(708, 400);
            this.grpAnalysis.TabIndex = 63;
            this.grpAnalysis.TabStop = false;
            this.grpAnalysis.Text = "Event Sales Analysis";
            // 
            // frmEventSalesAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1524, 1123);
            this.Controls.Add(this.grpAnalysis);
            this.Controls.Add(this.grpEvent);
            this.Controls.Add(this.grpEDetails);
            this.Controls.Add(this.grpVDetails);
            this.Controls.Add(this.mnuMainMenu);
            this.Controls.Add(this.grpFilter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmEventSalesAnalysis";
            this.Text = "Event Sales Analysis";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEventAnalysis_FormClosed);
            this.Load += new System.EventHandler(this.frmEventAnalysis_Load);
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.grpEDetails.ResumeLayout(false);
            this.grpEDetails.PerformLayout();
            this.grpVDetails.ResumeLayout(false);
            this.grpVDetails.PerformLayout();
            this.grpEvent.ResumeLayout(false);
            this.grpEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEventSalesAnalysis)).EndInit();
            this.grpAnalysis.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuItemBack;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Button btnFilterEvent;
        private System.Windows.Forms.ComboBox cboVenue;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.Label lblEventID;
        private System.Windows.Forms.TextBox txtEventID;
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
        private System.Windows.Forms.Label lblEventDate;
        private System.Windows.Forms.GroupBox grpVDetails;
        private System.Windows.Forms.Label lblVeVenue;
        private System.Windows.Forms.TextBox txtVenue;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.TextBox txtVenueID;
        private System.Windows.Forms.Label lblVenueID;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtVdMaxCap;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblMaxCap;
        private System.Windows.Forms.Label lblEircode;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.GroupBox grpEvent;
        private System.Windows.Forms.CheckBox chkEDetails;
        private System.Windows.Forms.Label lblEDetails;
        private System.Windows.Forms.CheckBox chkVDetails;
        private System.Windows.Forms.Label lblVDetails;
        private System.Windows.Forms.ComboBox cboEvent;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnGenerateAnalysis;
        private System.Windows.Forms.PictureBox picEventSalesAnalysis;
        private System.Windows.Forms.GroupBox grpAnalysis;
        private System.Windows.Forms.Label lblEventCap;
        private System.Windows.Forms.TextBox txtEdEventCap;
    }
}