
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
            this.grpVenueDetails = new System.Windows.Forms.GroupBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblStreet2 = new System.Windows.Forms.Label();
            this.txtStreet2 = new System.Windows.Forms.TextBox();
            this.txtVdVenue = new System.Windows.Forms.TextBox();
            this.txtEircode = new System.Windows.Forms.TextBox();
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
            this.grpFilterEvent = new System.Windows.Forms.GroupBox();
            this.chkDetails = new System.Windows.Forms.CheckBox();
            this.lblVenueDetail = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cboEvent = new System.Windows.Forms.ComboBox();
            this.lblEvent = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cboVenue = new System.Windows.Forms.ComboBox();
            this.lblFeVenue = new System.Windows.Forms.Label();
            this.lblEventDate = new System.Windows.Forms.Label();
            this.grpEventDetails = new System.Windows.Forms.GroupBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtAdultPrice = new System.Windows.Forms.TextBox();
            this.txtChildPrice = new System.Windows.Forms.TextBox();
            this.txtMaxTix = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblEventID = new System.Windows.Forms.Label();
            this.txtEventID = new System.Windows.Forms.TextBox();
            this.lblAdultTktPrice = new System.Windows.Forms.Label();
            this.lblChildTktPrice = new System.Windows.Forms.Label();
            this.lblMaxTix = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mnuMainMenu.SuspendLayout();
            this.grpCancelEvent.SuspendLayout();
            this.grpVenueDetails.SuspendLayout();
            this.grpFilterEvent.SuspendLayout();
            this.grpEventDetails.SuspendLayout();
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
            this.mnuMainMenu.Size = new System.Drawing.Size(1784, 45);
            this.mnuMainMenu.TabIndex = 1;
            this.mnuMainMenu.Text = "menuStrip1";
            // 
            // exitToolStripMnuItem
            // 
            this.exitToolStripMnuItem.Name = "exitToolStripMnuItem";
            this.exitToolStripMnuItem.Size = new System.Drawing.Size(93, 41);
            this.exitToolStripMnuItem.Text = "Back";
            this.exitToolStripMnuItem.Click += new System.EventHandler(this.exitToolStripMnuItem_Click);
            // 
            // grpCancelEvent
            // 
            this.grpCancelEvent.Controls.Add(this.grpVenueDetails);
            this.grpCancelEvent.Controls.Add(this.grpFilterEvent);
            this.grpCancelEvent.Controls.Add(this.grpEventDetails);
            this.grpCancelEvent.Location = new System.Drawing.Point(35, 72);
            this.grpCancelEvent.Margin = new System.Windows.Forms.Padding(2);
            this.grpCancelEvent.Name = "grpCancelEvent";
            this.grpCancelEvent.Padding = new System.Windows.Forms.Padding(2);
            this.grpCancelEvent.Size = new System.Drawing.Size(1711, 1246);
            this.grpCancelEvent.TabIndex = 5;
            this.grpCancelEvent.TabStop = false;
            this.grpCancelEvent.Text = "Cancel Event Form";
            // 
            // grpVenueDetails
            // 
            this.grpVenueDetails.Controls.Add(this.txtPhone);
            this.grpVenueDetails.Controls.Add(this.label1);
            this.grpVenueDetails.Controls.Add(this.txtContact);
            this.grpVenueDetails.Controls.Add(this.lblContact);
            this.grpVenueDetails.Controls.Add(this.txtCounty);
            this.grpVenueDetails.Controls.Add(this.lblCounty);
            this.grpVenueDetails.Controls.Add(this.lblStreet2);
            this.grpVenueDetails.Controls.Add(this.txtStreet2);
            this.grpVenueDetails.Controls.Add(this.txtVdVenue);
            this.grpVenueDetails.Controls.Add(this.txtEircode);
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
            this.grpVenueDetails.Location = new System.Drawing.Point(886, 66);
            this.grpVenueDetails.Name = "grpVenueDetails";
            this.grpVenueDetails.Size = new System.Drawing.Size(786, 799);
            this.grpVenueDetails.TabIndex = 45;
            this.grpVenueDetails.TabStop = false;
            this.grpVenueDetails.Text = "Venue Details";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.Black;
            this.txtPhone.ForeColor = System.Drawing.Color.White;
            this.txtPhone.Location = new System.Drawing.Point(327, 656);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(166, 43);
            this.txtPhone.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 662);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 37);
            this.label1.TabIndex = 50;
            this.label1.Text = "Phone:";
            // 
            // txtContact
            // 
            this.txtContact.BackColor = System.Drawing.Color.Black;
            this.txtContact.ForeColor = System.Drawing.Color.White;
            this.txtContact.Location = new System.Drawing.Point(327, 593);
            this.txtContact.Margin = new System.Windows.Forms.Padding(2);
            this.txtContact.Name = "txtContact";
            this.txtContact.ReadOnly = true;
            this.txtContact.Size = new System.Drawing.Size(166, 43);
            this.txtContact.TabIndex = 49;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(157, 599);
            this.lblContact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(115, 37);
            this.lblContact.TabIndex = 48;
            this.lblContact.Text = "Contact:";
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
            // txtFee
            // 
            this.txtFee.BackColor = System.Drawing.Color.Black;
            this.txtFee.ForeColor = System.Drawing.Color.White;
            this.txtFee.Location = new System.Drawing.Point(328, 727);
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
            this.label2.Location = new System.Drawing.Point(197, 733);
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
            // grpFilterEvent
            // 
            this.grpFilterEvent.Controls.Add(this.chkDetails);
            this.grpFilterEvent.Controls.Add(this.lblVenueDetail);
            this.grpFilterEvent.Controls.Add(this.dtpDate);
            this.grpFilterEvent.Controls.Add(this.cboEvent);
            this.grpFilterEvent.Controls.Add(this.lblEvent);
            this.grpFilterEvent.Controls.Add(this.btnFilter);
            this.grpFilterEvent.Controls.Add(this.cboVenue);
            this.grpFilterEvent.Controls.Add(this.lblFeVenue);
            this.grpFilterEvent.Controls.Add(this.lblEventDate);
            this.grpFilterEvent.Location = new System.Drawing.Point(40, 66);
            this.grpFilterEvent.Name = "grpFilterEvent";
            this.grpFilterEvent.Size = new System.Drawing.Size(809, 401);
            this.grpFilterEvent.TabIndex = 44;
            this.grpFilterEvent.TabStop = false;
            this.grpFilterEvent.Text = "Filter Event";
            // 
            // chkDetails
            // 
            this.chkDetails.AutoSize = true;
            this.chkDetails.Checked = true;
            this.chkDetails.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDetails.Location = new System.Drawing.Point(310, 276);
            this.chkDetails.Name = "chkDetails";
            this.chkDetails.Size = new System.Drawing.Size(28, 27);
            this.chkDetails.TabIndex = 54;
            this.chkDetails.UseVisualStyleBackColor = true;
            this.chkDetails.CheckedChanged += new System.EventHandler(this.chkDetail_CheckedChanged);
            // 
            // lblVenueDetail
            // 
            this.lblVenueDetail.AutoSize = true;
            this.lblVenueDetail.Location = new System.Drawing.Point(56, 266);
            this.lblVenueDetail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVenueDetail.Name = "lblVenueDetail";
            this.lblVenueDetail.Size = new System.Drawing.Size(184, 37);
            this.lblVenueDetail.TabIndex = 53;
            this.lblVenueDetail.Text = "Venue Details:";
            // 
            // dtpDate
            // 
            this.dtpDate.Enabled = false;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(310, 201);
            this.dtpDate.MinDate = new System.DateTime(2021, 12, 8, 23, 44, 17, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(181, 43);
            this.dtpDate.TabIndex = 46;
            this.dtpDate.Value = new System.DateTime(2021, 12, 8, 23, 44, 17, 0);
            // 
            // cboEvent
            // 
            this.cboEvent.FormattingEnabled = true;
            this.cboEvent.Location = new System.Drawing.Point(310, 127);
            this.cboEvent.Name = "cboEvent";
            this.cboEvent.Size = new System.Drawing.Size(445, 45);
            this.cboEvent.TabIndex = 46;
            this.cboEvent.SelectedIndexChanged += new System.EventHandler(this.cboEvent_SelectedIndexChanged);
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Location = new System.Drawing.Point(75, 135);
            this.lblEvent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(165, 37);
            this.lblEvent.TabIndex = 43;
            this.lblEvent.Text = "Select Event:";
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnFilter.Location = new System.Drawing.Point(171, 322);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(433, 52);
            this.btnFilter.TabIndex = 45;
            this.btnFilter.Text = "Filter Events";
            this.btnFilter.UseVisualStyleBackColor = false;
            // 
            // cboVenue
            // 
            this.cboVenue.FormattingEnabled = true;
            this.cboVenue.Location = new System.Drawing.Point(310, 54);
            this.cboVenue.Name = "cboVenue";
            this.cboVenue.Size = new System.Drawing.Size(445, 45);
            this.cboVenue.TabIndex = 44;
            // 
            // lblFeVenue
            // 
            this.lblFeVenue.AutoSize = true;
            this.lblFeVenue.Location = new System.Drawing.Point(144, 58);
            this.lblFeVenue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFeVenue.Name = "lblFeVenue";
            this.lblFeVenue.Size = new System.Drawing.Size(96, 37);
            this.lblFeVenue.TabIndex = 43;
            this.lblFeVenue.Text = "Venue:";
            // 
            // lblEventDate
            // 
            this.lblEventDate.AutoSize = true;
            this.lblEventDate.Location = new System.Drawing.Point(88, 207);
            this.lblEventDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventDate.Name = "lblEventDate";
            this.lblEventDate.Size = new System.Drawing.Size(151, 37);
            this.lblEventDate.TabIndex = 15;
            this.lblEventDate.Text = "Event Date:";
            // 
            // grpEventDetails
            // 
            this.grpEventDetails.Controls.Add(this.txtTime);
            this.grpEventDetails.Controls.Add(this.txtDate);
            this.grpEventDetails.Controls.Add(this.lblTitle);
            this.grpEventDetails.Controls.Add(this.txtTitle);
            this.grpEventDetails.Controls.Add(this.lblDescription);
            this.grpEventDetails.Controls.Add(this.txtAdultPrice);
            this.grpEventDetails.Controls.Add(this.txtChildPrice);
            this.grpEventDetails.Controls.Add(this.txtMaxTix);
            this.grpEventDetails.Controls.Add(this.txtDescription);
            this.grpEventDetails.Controls.Add(this.lblTime);
            this.grpEventDetails.Controls.Add(this.btnCancel);
            this.grpEventDetails.Controls.Add(this.lblEventID);
            this.grpEventDetails.Controls.Add(this.txtEventID);
            this.grpEventDetails.Controls.Add(this.lblAdultTktPrice);
            this.grpEventDetails.Controls.Add(this.lblChildTktPrice);
            this.grpEventDetails.Controls.Add(this.lblMaxTix);
            this.grpEventDetails.Controls.Add(this.lblDate);
            this.grpEventDetails.Location = new System.Drawing.Point(40, 490);
            this.grpEventDetails.Name = "grpEventDetails";
            this.grpEventDetails.Size = new System.Drawing.Size(809, 740);
            this.grpEventDetails.TabIndex = 25;
            this.grpEventDetails.TabStop = false;
            this.grpEventDetails.Text = "Event Details";
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.Color.Black;
            this.txtTime.ForeColor = System.Drawing.Color.White;
            this.txtTime.Location = new System.Drawing.Point(310, 359);
            this.txtTime.Margin = new System.Windows.Forms.Padding(2);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(127, 43);
            this.txtTime.TabIndex = 56;
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.Black;
            this.txtDate.ForeColor = System.Drawing.Color.White;
            this.txtDate.Location = new System.Drawing.Point(310, 286);
            this.txtDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(127, 43);
            this.txtDate.TabIndex = 55;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(87, 144);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(146, 37);
            this.lblTitle.TabIndex = 53;
            this.lblTitle.Text = "Event Title:";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.Black;
            this.txtTitle.ForeColor = System.Drawing.Color.White;
            this.txtTitle.Location = new System.Drawing.Point(310, 138);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(445, 43);
            this.txtTitle.TabIndex = 54;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(8, 214);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(230, 37);
            this.lblDescription.TabIndex = 45;
            this.lblDescription.Text = "Event Description:";
            // 
            // txtAdultPrice
            // 
            this.txtAdultPrice.BackColor = System.Drawing.Color.Black;
            this.txtAdultPrice.ForeColor = System.Drawing.Color.White;
            this.txtAdultPrice.Location = new System.Drawing.Point(310, 575);
            this.txtAdultPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdultPrice.Name = "txtAdultPrice";
            this.txtAdultPrice.ReadOnly = true;
            this.txtAdultPrice.Size = new System.Drawing.Size(127, 43);
            this.txtAdultPrice.TabIndex = 52;
            // 
            // txtChildPrice
            // 
            this.txtChildPrice.BackColor = System.Drawing.Color.Black;
            this.txtChildPrice.ForeColor = System.Drawing.Color.White;
            this.txtChildPrice.Location = new System.Drawing.Point(310, 501);
            this.txtChildPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtChildPrice.Name = "txtChildPrice";
            this.txtChildPrice.ReadOnly = true;
            this.txtChildPrice.Size = new System.Drawing.Size(127, 43);
            this.txtChildPrice.TabIndex = 51;
            // 
            // txtMaxTix
            // 
            this.txtMaxTix.BackColor = System.Drawing.Color.Black;
            this.txtMaxTix.ForeColor = System.Drawing.Color.White;
            this.txtMaxTix.Location = new System.Drawing.Point(310, 427);
            this.txtMaxTix.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaxTix.Name = "txtMaxTix";
            this.txtMaxTix.ReadOnly = true;
            this.txtMaxTix.Size = new System.Drawing.Size(127, 43);
            this.txtMaxTix.TabIndex = 50;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.Black;
            this.txtDescription.ForeColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(310, 206);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(445, 43);
            this.txtDescription.TabIndex = 46;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(84, 365);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(153, 37);
            this.lblTime.TabIndex = 49;
            this.lblTime.Text = "Event Time:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCancel.Location = new System.Drawing.Point(62, 663);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(627, 52);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Cancel Event";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblEventID
            // 
            this.lblEventID.AutoSize = true;
            this.lblEventID.Location = new System.Drawing.Point(119, 72);
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
            this.txtEventID.Location = new System.Drawing.Point(310, 64);
            this.txtEventID.Margin = new System.Windows.Forms.Padding(2);
            this.txtEventID.Name = "txtEventID";
            this.txtEventID.ReadOnly = true;
            this.txtEventID.Size = new System.Drawing.Size(88, 43);
            this.txtEventID.TabIndex = 3;
            // 
            // lblAdultTktPrice
            // 
            this.lblAdultTktPrice.AutoSize = true;
            this.lblAdultTktPrice.Location = new System.Drawing.Point(7, 583);
            this.lblAdultTktPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdultTktPrice.Name = "lblAdultTktPrice";
            this.lblAdultTktPrice.Size = new System.Drawing.Size(227, 37);
            this.lblAdultTktPrice.TabIndex = 30;
            this.lblAdultTktPrice.Text = "Adult Ticket Price:";
            // 
            // lblChildTktPrice
            // 
            this.lblChildTktPrice.AutoSize = true;
            this.lblChildTktPrice.Location = new System.Drawing.Point(10, 509);
            this.lblChildTktPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChildTktPrice.Name = "lblChildTktPrice";
            this.lblChildTktPrice.Size = new System.Drawing.Size(225, 37);
            this.lblChildTktPrice.TabIndex = 29;
            this.lblChildTktPrice.Text = "Child Ticket Price:";
            // 
            // lblMaxTix
            // 
            this.lblMaxTix.AutoSize = true;
            this.lblMaxTix.Location = new System.Drawing.Point(18, 435);
            this.lblMaxTix.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxTix.Name = "lblMaxTix";
            this.lblMaxTix.Size = new System.Drawing.Size(228, 37);
            this.lblMaxTix.TabIndex = 33;
            this.lblMaxTix.Text = "Maximum Tickets:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(87, 292);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(151, 37);
            this.lblDate.TabIndex = 16;
            this.lblDate.Text = "Event Date:";
            // 
            // frmCancelEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1784, 1337);
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
            this.grpVenueDetails.ResumeLayout(false);
            this.grpVenueDetails.PerformLayout();
            this.grpFilterEvent.ResumeLayout(false);
            this.grpFilterEvent.PerformLayout();
            this.grpEventDetails.ResumeLayout(false);
            this.grpEventDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMnuItem;
        private System.Windows.Forms.GroupBox grpCancelEvent;
        private System.Windows.Forms.GroupBox grpEventDetails;
        private System.Windows.Forms.Label lblMaxTix;
        private System.Windows.Forms.Label lblAdultTktPrice;
        private System.Windows.Forms.Label lblChildTktPrice;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblEventDate;
        private System.Windows.Forms.Label lblEventID;
        private System.Windows.Forms.TextBox txtEventID;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpFilterEvent;
        private System.Windows.Forms.Label lblFeVenue;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cboVenue;
        private System.Windows.Forms.ComboBox cboEvent;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtMaxTix;
        private System.Windows.Forms.TextBox txtAdultPrice;
        private System.Windows.Forms.TextBox txtChildPrice;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.CheckBox chkDetails;
        private System.Windows.Forms.Label lblVenueDetail;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.GroupBox grpVenueDetails;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblStreet2;
        private System.Windows.Forms.TextBox txtStreet2;
        private System.Windows.Forms.TextBox txtVdVenue;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.Label lblVdVenue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtVenueID;
        private System.Windows.Forms.Label lblVenueID;
        private System.Windows.Forms.Label lblStreet1;
        private System.Windows.Forms.TextBox txtMaxCap;
        private System.Windows.Forms.Label lblMaxCap;
        private System.Windows.Forms.Label lblEircode;
        private System.Windows.Forms.TextBox txtStreet1;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtDate;
    }
}