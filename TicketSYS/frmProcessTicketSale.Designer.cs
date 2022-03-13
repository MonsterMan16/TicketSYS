
namespace TicketSYS
{
    partial class frmProcessTicketSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcessTicketSale));
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.MnuItemBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpCreateSale = new System.Windows.Forms.GroupBox();
            this.nudTotal = new System.Windows.Forms.NumericUpDown();
            this.nudChildTktQty = new System.Windows.Forms.NumericUpDown();
            this.nudAdultTktQty = new System.Windows.Forms.NumericUpDown();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblTicketID = new System.Windows.Forms.Label();
            this.chkEDetails = new System.Windows.Forms.CheckBox();
            this.txtTicketID = new System.Windows.Forms.TextBox();
            this.lblEventDetails = new System.Windows.Forms.Label();
            this.chkVDetails = new System.Windows.Forms.CheckBox();
            this.lblVenueDetails = new System.Windows.Forms.Label();
            this.lblChildTktQty = new System.Windows.Forms.Label();
            this.lblAdultTktQty = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.cboEvent = new System.Windows.Forms.ComboBox();
            this.lblEvent = new System.Windows.Forms.Label();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnCreateSale = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.grpFilterEvent = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cboVenue = new System.Windows.Forms.ComboBox();
            this.lblFeVenue = new System.Windows.Forms.Label();
            this.grpEDetails = new System.Windows.Forms.GroupBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtEventID = new System.Windows.Forms.TextBox();
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
            this.mnuMainMenu.SuspendLayout();
            this.grpCreateSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChildTktQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdultTktQty)).BeginInit();
            this.grpFilterEvent.SuspendLayout();
            this.grpEDetails.SuspendLayout();
            this.grpVDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuItemBack});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnuMainMenu.Size = new System.Drawing.Size(1523, 40);
            this.mnuMainMenu.TabIndex = 1;
            this.mnuMainMenu.Text = "menuStrip1";
            this.mnuMainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuMainMenu_ItemClicked);
            // 
            // MnuItemBack
            // 
            this.MnuItemBack.Name = "MnuItemBack";
            this.MnuItemBack.Size = new System.Drawing.Size(83, 36);
            this.MnuItemBack.Text = "Back";
            this.MnuItemBack.Click += new System.EventHandler(this.exitToolStripMnuItem_Click);
            // 
            // grpCreateSale
            // 
            this.grpCreateSale.Controls.Add(this.nudTotal);
            this.grpCreateSale.Controls.Add(this.nudChildTktQty);
            this.grpCreateSale.Controls.Add(this.nudAdultTktQty);
            this.grpCreateSale.Controls.Add(this.lblTotalCost);
            this.grpCreateSale.Controls.Add(this.lblTicketID);
            this.grpCreateSale.Controls.Add(this.chkEDetails);
            this.grpCreateSale.Controls.Add(this.txtTicketID);
            this.grpCreateSale.Controls.Add(this.lblEventDetails);
            this.grpCreateSale.Controls.Add(this.chkVDetails);
            this.grpCreateSale.Controls.Add(this.lblVenueDetails);
            this.grpCreateSale.Controls.Add(this.lblChildTktQty);
            this.grpCreateSale.Controls.Add(this.lblAdultTktQty);
            this.grpCreateSale.Controls.Add(this.txtLastName);
            this.grpCreateSale.Controls.Add(this.lblLastName);
            this.grpCreateSale.Controls.Add(this.cboEvent);
            this.grpCreateSale.Controls.Add(this.lblEvent);
            this.grpCreateSale.Controls.Add(this.txtPhoneNum);
            this.grpCreateSale.Controls.Add(this.lblPhoneNum);
            this.grpCreateSale.Controls.Add(this.txtFirstName);
            this.grpCreateSale.Controls.Add(this.btnCreateSale);
            this.grpCreateSale.Controls.Add(this.lblFirstName);
            this.grpCreateSale.Controls.Add(this.txtEmail);
            this.grpCreateSale.Controls.Add(this.lblEmail);
            this.grpCreateSale.Location = new System.Drawing.Point(29, 313);
            this.grpCreateSale.Margin = new System.Windows.Forms.Padding(2);
            this.grpCreateSale.Name = "grpCreateSale";
            this.grpCreateSale.Padding = new System.Windows.Forms.Padding(2);
            this.grpCreateSale.Size = new System.Drawing.Size(708, 790);
            this.grpCreateSale.TabIndex = 2;
            this.grpCreateSale.TabStop = false;
            this.grpCreateSale.Text = "Create Sale";
            this.grpCreateSale.Enter += new System.EventHandler(this.grpCreateSale_Enter);
            // 
            // nudTotal
            // 
            this.nudTotal.DecimalPlaces = 2;
            this.nudTotal.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudTotal.Location = new System.Drawing.Point(264, 649);
            this.nudTotal.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudTotal.Name = "nudTotal";
            this.nudTotal.ReadOnly = true;
            this.nudTotal.Size = new System.Drawing.Size(157, 39);
            this.nudTotal.TabIndex = 55;
            // 
            // nudChildTktQty
            // 
            this.nudChildTktQty.Location = new System.Drawing.Point(264, 584);
            this.nudChildTktQty.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudChildTktQty.Name = "nudChildTktQty";
            this.nudChildTktQty.Size = new System.Drawing.Size(157, 39);
            this.nudChildTktQty.TabIndex = 38;
            this.nudChildTktQty.ValueChanged += new System.EventHandler(this.nudChildTktQty_ValueChanged);
            // 
            // nudAdultTktQty
            // 
            this.nudAdultTktQty.Location = new System.Drawing.Point(264, 524);
            this.nudAdultTktQty.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nudAdultTktQty.Name = "nudAdultTktQty";
            this.nudAdultTktQty.Size = new System.Drawing.Size(157, 39);
            this.nudAdultTktQty.TabIndex = 37;
            this.nudAdultTktQty.ValueChanged += new System.EventHandler(this.nudAdultTktQty_ValueChanged);
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(91, 656);
            this.lblTotalCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(124, 32);
            this.lblTotalCost.TabIndex = 53;
            this.lblTotalCost.Text = "Total Cost:";
            // 
            // lblTicketID
            // 
            this.lblTicketID.AutoSize = true;
            this.lblTicketID.Location = new System.Drawing.Point(119, 59);
            this.lblTicketID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTicketID.Name = "lblTicketID";
            this.lblTicketID.Size = new System.Drawing.Size(112, 32);
            this.lblTicketID.TabIndex = 47;
            this.lblTicketID.Text = "Ticket ID:";
            this.lblTicketID.Click += new System.EventHandler(this.lblTicketID_Click);
            // 
            // chkEDetails
            // 
            this.chkEDetails.AutoSize = true;
            this.chkEDetails.Checked = true;
            this.chkEDetails.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEDetails.Location = new System.Drawing.Point(264, 239);
            this.chkEDetails.Name = "chkEDetails";
            this.chkEDetails.Size = new System.Drawing.Size(28, 27);
            this.chkEDetails.TabIndex = 52;
            this.chkEDetails.UseVisualStyleBackColor = true;
            this.chkEDetails.CheckedChanged += new System.EventHandler(this.chkEDetails_CheckedChanged);
            // 
            // txtTicketID
            // 
            this.txtTicketID.BackColor = System.Drawing.Color.Black;
            this.txtTicketID.ForeColor = System.Drawing.Color.White;
            this.txtTicketID.Location = new System.Drawing.Point(284, 51);
            this.txtTicketID.Margin = new System.Windows.Forms.Padding(2);
            this.txtTicketID.Name = "txtTicketID";
            this.txtTicketID.ReadOnly = true;
            this.txtTicketID.Size = new System.Drawing.Size(96, 39);
            this.txtTicketID.TabIndex = 48;
            this.txtTicketID.TextChanged += new System.EventHandler(this.txtTicketID_TextChanged);
            // 
            // lblEventDetails
            // 
            this.lblEventDetails.AutoSize = true;
            this.lblEventDetails.Location = new System.Drawing.Point(58, 235);
            this.lblEventDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventDetails.Name = "lblEventDetails";
            this.lblEventDetails.Size = new System.Drawing.Size(157, 32);
            this.lblEventDetails.TabIndex = 51;
            this.lblEventDetails.Text = "Event Details:";
            // 
            // chkVDetails
            // 
            this.chkVDetails.AutoSize = true;
            this.chkVDetails.Checked = true;
            this.chkVDetails.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVDetails.Location = new System.Drawing.Point(264, 190);
            this.chkVDetails.Name = "chkVDetails";
            this.chkVDetails.Size = new System.Drawing.Size(28, 27);
            this.chkVDetails.TabIndex = 50;
            this.chkVDetails.UseVisualStyleBackColor = true;
            this.chkVDetails.CheckedChanged += new System.EventHandler(this.chkVenueDetails_CheckedChanged);
            // 
            // lblVenueDetails
            // 
            this.lblVenueDetails.AutoSize = true;
            this.lblVenueDetails.Location = new System.Drawing.Point(55, 186);
            this.lblVenueDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVenueDetails.Name = "lblVenueDetails";
            this.lblVenueDetails.Size = new System.Drawing.Size(165, 32);
            this.lblVenueDetails.TabIndex = 49;
            this.lblVenueDetails.Text = "Venue Details:";
            this.lblVenueDetails.Click += new System.EventHandler(this.lblVenueDetails_Click);
            // 
            // lblChildTktQty
            // 
            this.lblChildTktQty.AutoSize = true;
            this.lblChildTktQty.Location = new System.Drawing.Point(26, 591);
            this.lblChildTktQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChildTktQty.Name = "lblChildTktQty";
            this.lblChildTktQty.Size = new System.Drawing.Size(189, 32);
            this.lblChildTktQty.TabIndex = 25;
            this.lblChildTktQty.Text = "Child Ticket Qty:";
            // 
            // lblAdultTktQty
            // 
            this.lblAdultTktQty.AutoSize = true;
            this.lblAdultTktQty.Location = new System.Drawing.Point(94, 528);
            this.lblAdultTktQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdultTktQty.Name = "lblAdultTktQty";
            this.lblAdultTktQty.Size = new System.Drawing.Size(121, 32);
            this.lblAdultTktQty.TabIndex = 23;
            this.lblAdultTktQty.Text = "Adult Qty:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(264, 348);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(386, 39);
            this.txtLastName.TabIndex = 22;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(86, 353);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(131, 32);
            this.lblLastName.TabIndex = 21;
            this.lblLastName.Text = "Last Name:";
            // 
            // cboEvent
            // 
            this.cboEvent.FormattingEnabled = true;
            this.cboEvent.Items.AddRange(new object[] {
            ""});
            this.cboEvent.Location = new System.Drawing.Point(284, 112);
            this.cboEvent.Margin = new System.Windows.Forms.Padding(2);
            this.cboEvent.Name = "cboEvent";
            this.cboEvent.Size = new System.Drawing.Size(232, 40);
            this.cboEvent.TabIndex = 20;
            this.cboEvent.SelectedIndexChanged += new System.EventHandler(this.cboEvent_SelectedIndexChanged);
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Location = new System.Drawing.Point(158, 118);
            this.lblEvent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(78, 32);
            this.lblEvent.TabIndex = 19;
            this.lblEvent.Text = "Event:";
            this.lblEvent.Click += new System.EventHandler(this.lblEvent_Click);
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(264, 458);
            this.txtPhoneNum.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(386, 39);
            this.txtPhoneNum.TabIndex = 16;
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Location = new System.Drawing.Point(38, 461);
            this.lblPhoneNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(182, 32);
            this.lblPhoneNum.TabIndex = 15;
            this.lblPhoneNum.Text = "Phone Number:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(264, 296);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(386, 39);
            this.txtFirstName.TabIndex = 10;
            // 
            // btnCreateSale
            // 
            this.btnCreateSale.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCreateSale.Location = new System.Drawing.Point(73, 724);
            this.btnCreateSale.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateSale.Name = "btnCreateSale";
            this.btnCreateSale.Size = new System.Drawing.Size(552, 45);
            this.btnCreateSale.TabIndex = 14;
            this.btnCreateSale.Text = "Create Sale";
            this.btnCreateSale.UseVisualStyleBackColor = false;
            this.btnCreateSale.Click += new System.EventHandler(this.btnCreateSale_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(84, 301);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(134, 32);
            this.lblFirstName.TabIndex = 9;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(264, 403);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(386, 39);
            this.txtEmail.TabIndex = 13;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(51, 408);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(167, 32);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email Address:";
            // 
            // grpFilterEvent
            // 
            this.grpFilterEvent.Controls.Add(this.btnFilter);
            this.grpFilterEvent.Controls.Add(this.cboVenue);
            this.grpFilterEvent.Controls.Add(this.lblFeVenue);
            this.grpFilterEvent.Location = new System.Drawing.Point(29, 72);
            this.grpFilterEvent.Name = "grpFilterEvent";
            this.grpFilterEvent.Size = new System.Drawing.Size(708, 217);
            this.grpFilterEvent.TabIndex = 45;
            this.grpFilterEvent.TabStop = false;
            this.grpFilterEvent.Text = "Filter Event";
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnFilter.Location = new System.Drawing.Point(141, 138);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(375, 45);
            this.btnFilter.TabIndex = 45;
            this.btnFilter.Text = "Filter Events";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // cboVenue
            // 
            this.cboVenue.FormattingEnabled = true;
            this.cboVenue.Items.AddRange(new object[] {
            "",
            "1 | 3Arena",
            "2 | Aviva Stadium"});
            this.cboVenue.Location = new System.Drawing.Point(209, 57);
            this.cboVenue.Name = "cboVenue";
            this.cboVenue.Size = new System.Drawing.Size(386, 40);
            this.cboVenue.TabIndex = 44;
            this.cboVenue.SelectedIndexChanged += new System.EventHandler(this.cboVenue_SelectedIndexChanged);
            // 
            // lblFeVenue
            // 
            this.lblFeVenue.AutoSize = true;
            this.lblFeVenue.Location = new System.Drawing.Point(84, 65);
            this.lblFeVenue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFeVenue.Name = "lblFeVenue";
            this.lblFeVenue.Size = new System.Drawing.Size(86, 32);
            this.lblFeVenue.TabIndex = 43;
            this.lblFeVenue.Text = "Venue:";
            // 
            // grpEDetails
            // 
            this.grpEDetails.Controls.Add(this.dtpTime);
            this.grpEDetails.Controls.Add(this.dtpDate);
            this.grpEDetails.Controls.Add(this.lblDescription);
            this.grpEDetails.Controls.Add(this.label1);
            this.grpEDetails.Controls.Add(this.txtDescription);
            this.grpEDetails.Controls.Add(this.txtEventID);
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
            this.grpEDetails.Location = new System.Drawing.Point(793, 470);
            this.grpEDetails.Name = "grpEDetails";
            this.grpEDetails.Size = new System.Drawing.Size(701, 549);
            this.grpEDetails.TabIndex = 53;
            this.grpEDetails.TabStop = false;
            this.grpEDetails.Text = "Event Details";
            this.grpEDetails.Enter += new System.EventHandler(this.grpEDetails_Enter);
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "HH:mm";
            this.dtpTime.Enabled = false;
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(293, 306);
            this.dtpTime.MaxDate = new System.DateTime(2030, 1, 31, 0, 0, 0, 0);
            this.dtpTime.MinDate = new System.DateTime(2021, 12, 13, 2, 57, 8, 0);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(157, 39);
            this.dtpTime.TabIndex = 56;
            this.dtpTime.Value = new System.DateTime(2021, 12, 18, 0, 17, 59, 767);
            // 
            // dtpDate
            // 
            this.dtpDate.Enabled = false;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(293, 243);
            this.dtpDate.MaxDate = new System.DateTime(2026, 12, 18, 5, 48, 41, 915);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(157, 39);
            this.dtpDate.TabIndex = 55;
            this.dtpDate.Value = new System.DateTime(2021, 12, 18, 0, 17, 59, 768);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(29, 194);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(206, 32);
            this.lblDescription.TabIndex = 28;
            this.lblDescription.Text = "Event Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 32);
            this.label1.TabIndex = 47;
            this.label1.Text = "Event ID:";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.Black;
            this.txtDescription.ForeColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(293, 187);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(386, 39);
            this.txtDescription.TabIndex = 29;
            // 
            // txtEventID
            // 
            this.txtEventID.BackColor = System.Drawing.Color.Black;
            this.txtEventID.ForeColor = System.Drawing.Color.White;
            this.txtEventID.Location = new System.Drawing.Point(293, 61);
            this.txtEventID.Margin = new System.Windows.Forms.Padding(2);
            this.txtEventID.Name = "txtEventID";
            this.txtEventID.ReadOnly = true;
            this.txtEventID.Size = new System.Drawing.Size(95, 39);
            this.txtEventID.TabIndex = 48;
            // 
            // txtAdultTktPrice
            // 
            this.txtAdultTktPrice.BackColor = System.Drawing.Color.Black;
            this.txtAdultTktPrice.ForeColor = System.Drawing.Color.White;
            this.txtAdultTktPrice.Location = new System.Drawing.Point(294, 493);
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
            this.txtChildTktPrice.Location = new System.Drawing.Point(294, 427);
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
            this.txtAvailTix.Location = new System.Drawing.Point(293, 367);
            this.txtAvailTix.Margin = new System.Windows.Forms.Padding(2);
            this.txtAvailTix.Name = "txtAvailTix";
            this.txtAvailTix.ReadOnly = true;
            this.txtAvailTix.Size = new System.Drawing.Size(111, 39);
            this.txtAvailTix.TabIndex = 50;
            this.txtAvailTix.TextChanged += new System.EventHandler(this.txtAvailTix_TextChanged);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(100, 313);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(138, 32);
            this.lblTime.TabIndex = 49;
            this.lblTime.Text = "Event Time:";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // lblAdultTktPrice
            // 
            this.lblAdultTktPrice.AutoSize = true;
            this.lblAdultTktPrice.Location = new System.Drawing.Point(36, 493);
            this.lblAdultTktPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdultTktPrice.Name = "lblAdultTktPrice";
            this.lblAdultTktPrice.Size = new System.Drawing.Size(204, 32);
            this.lblAdultTktPrice.TabIndex = 30;
            this.lblAdultTktPrice.Text = "Adult Ticket Price:";
            // 
            // lblChildTktPrice
            // 
            this.lblChildTktPrice.AutoSize = true;
            this.lblChildTktPrice.Location = new System.Drawing.Point(38, 434);
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
            this.txtTitle.Location = new System.Drawing.Point(294, 125);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(386, 39);
            this.txtTitle.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(107, 133);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(131, 32);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Event Title:";
            // 
            // lblAvailTix
            // 
            this.lblAvailTix.AutoSize = true;
            this.lblAvailTix.Location = new System.Drawing.Point(44, 374);
            this.lblAvailTix.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvailTix.Name = "lblAvailTix";
            this.lblAvailTix.Size = new System.Drawing.Size(195, 32);
            this.lblAvailTix.TabIndex = 33;
            this.lblAvailTix.Text = "Available Tickets:";
            this.lblAvailTix.Click += new System.EventHandler(this.lblAvailTix_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(104, 250);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(135, 32);
            this.lblDate.TabIndex = 16;
            this.lblDate.Text = "Event Date:";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
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
            this.grpVDetails.Location = new System.Drawing.Point(793, 72);
            this.grpVDetails.Name = "grpVDetails";
            this.grpVDetails.Size = new System.Drawing.Size(701, 375);
            this.grpVDetails.TabIndex = 53;
            this.grpVDetails.TabStop = false;
            this.grpVDetails.Text = "Venue Details";
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.Location = new System.Drawing.Point(164, 109);
            this.lblVenue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(86, 32);
            this.lblVenue.TabIndex = 26;
            this.lblVenue.Text = "Venue:";
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
            this.lblVenueID.Location = new System.Drawing.Point(135, 52);
            this.lblVenueID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVenueID.Name = "lblVenueID";
            this.lblVenueID.Size = new System.Drawing.Size(116, 32);
            this.lblVenueID.TabIndex = 16;
            this.lblVenueID.Text = "Venue ID:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(79, 164);
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
            // lblVdMaxCap
            // 
            this.lblVdMaxCap.AutoSize = true;
            this.lblVdMaxCap.Location = new System.Drawing.Point(89, 324);
            this.lblVdMaxCap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVdMaxCap.Name = "lblVdMaxCap";
            this.lblVdMaxCap.Size = new System.Drawing.Size(161, 32);
            this.lblVdMaxCap.TabIndex = 10;
            this.lblVdMaxCap.Text = "Max Capacity:";
            // 
            // lblEircode
            // 
            this.lblEircode.AutoSize = true;
            this.lblEircode.Location = new System.Drawing.Point(153, 269);
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
            this.lblCity.Location = new System.Drawing.Point(191, 216);
            this.lblCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(60, 32);
            this.lblCity.TabIndex = 19;
            this.lblCity.Text = "City:";
            // 
            // frmProcessTicketSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1523, 1131);
            this.Controls.Add(this.grpVDetails);
            this.Controls.Add(this.grpEDetails);
            this.Controls.Add(this.grpFilterEvent);
            this.Controls.Add(this.grpCreateSale);
            this.Controls.Add(this.mnuMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmProcessTicketSale";
            this.Text = "Process Ticket Sale";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCreateSale_FormClosed);
            this.Load += new System.EventHandler(this.frmCreateSale_Load);
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.grpCreateSale.ResumeLayout(false);
            this.grpCreateSale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChildTktQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdultTktQty)).EndInit();
            this.grpFilterEvent.ResumeLayout(false);
            this.grpFilterEvent.PerformLayout();
            this.grpEDetails.ResumeLayout(false);
            this.grpEDetails.PerformLayout();
            this.grpVDetails.ResumeLayout(false);
            this.grpVDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem MnuItemBack;
        private System.Windows.Forms.GroupBox grpCreateSale;
        private System.Windows.Forms.ComboBox cboEvent;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnCreateSale;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblChildTktQty;
        private System.Windows.Forms.Label lblAdultTktQty;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.GroupBox grpFilterEvent;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cboVenue;
        private System.Windows.Forms.Label lblFeVenue;
        private System.Windows.Forms.CheckBox chkEDetails;
        private System.Windows.Forms.Label lblEventDetails;
        private System.Windows.Forms.CheckBox chkVDetails;
        private System.Windows.Forms.Label lblVenueDetails;
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
        private System.Windows.Forms.Label lblTicketID;
        private System.Windows.Forms.TextBox txtTicketID;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEventID;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.NumericUpDown nudChildTktQty;
        private System.Windows.Forms.NumericUpDown nudAdultTktQty;
        private System.Windows.Forms.NumericUpDown nudTotal;
    }
}