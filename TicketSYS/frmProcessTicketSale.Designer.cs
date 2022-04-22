
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
            this.grpSales = new System.Windows.Forms.GroupBox();
            this.grpVenueDetails = new System.Windows.Forms.GroupBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.lblCounty = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStreet2 = new System.Windows.Forms.Label();
            this.txtStreet2 = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtVdVenue = new System.Windows.Forms.TextBox();
            this.txtEircode = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.lblVdVenue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtVenueID = new System.Windows.Forms.TextBox();
            this.lblVenueID = new System.Windows.Forms.Label();
            this.lblStreet1 = new System.Windows.Forms.Label();
            this.txtMaxCap = new System.Windows.Forms.TextBox();
            this.lblMaxCap = new System.Windows.Forms.Label();
            this.lblEircode = new System.Windows.Forms.Label();
            this.txtStreet1 = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.grpEDetails = new System.Windows.Forms.GroupBox();
            this.txtAvailTix = new System.Windows.Forms.TextBox();
            this.lblAvailTix = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtEventID = new System.Windows.Forms.TextBox();
            this.txtAdultPrice = new System.Windows.Forms.TextBox();
            this.txtChildPrice = new System.Windows.Forms.TextBox();
            this.txtMaxTix = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblAdultPrice = new System.Windows.Forms.Label();
            this.lblChildPrice = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMaxTix = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.grpFilterEvent = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cboVenue = new System.Windows.Forms.ComboBox();
            this.lblFeVenue = new System.Windows.Forms.Label();
            this.grpCreateSale = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.nudChildQty = new System.Windows.Forms.NumericUpDown();
            this.nudAdultQty = new System.Windows.Forms.NumericUpDown();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblTicketID = new System.Windows.Forms.Label();
            this.chkEDetails = new System.Windows.Forms.CheckBox();
            this.txtSaleID = new System.Windows.Forms.TextBox();
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
            this.mnuMainMenu.SuspendLayout();
            this.grpSales.SuspendLayout();
            this.grpVenueDetails.SuspendLayout();
            this.grpEDetails.SuspendLayout();
            this.grpFilterEvent.SuspendLayout();
            this.grpCreateSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudChildQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdultQty)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuItemBack});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(1779, 45);
            this.mnuMainMenu.TabIndex = 1;
            this.mnuMainMenu.Text = "menuStrip1";
            // 
            // MnuItemBack
            // 
            this.MnuItemBack.Name = "MnuItemBack";
            this.MnuItemBack.Size = new System.Drawing.Size(93, 41);
            this.MnuItemBack.Text = "Back";
            this.MnuItemBack.Click += new System.EventHandler(this.exitToolStripMnuItem_Click);
            // 
            // grpSales
            // 
            this.grpSales.Controls.Add(this.grpVenueDetails);
            this.grpSales.Controls.Add(this.grpEDetails);
            this.grpSales.Controls.Add(this.grpFilterEvent);
            this.grpSales.Controls.Add(this.grpCreateSale);
            this.grpSales.Location = new System.Drawing.Point(23, 71);
            this.grpSales.Name = "grpSales";
            this.grpSales.Size = new System.Drawing.Size(1722, 1627);
            this.grpSales.TabIndex = 2;
            this.grpSales.TabStop = false;
            this.grpSales.Text = "Sales";
            // 
            // grpVenueDetails
            // 
            this.grpVenueDetails.Controls.Add(this.txtPhone);
            this.grpVenueDetails.Controls.Add(this.txtCounty);
            this.grpVenueDetails.Controls.Add(this.lblCounty);
            this.grpVenueDetails.Controls.Add(this.label2);
            this.grpVenueDetails.Controls.Add(this.lblStreet2);
            this.grpVenueDetails.Controls.Add(this.txtStreet2);
            this.grpVenueDetails.Controls.Add(this.txtContact);
            this.grpVenueDetails.Controls.Add(this.txtVdVenue);
            this.grpVenueDetails.Controls.Add(this.txtEircode);
            this.grpVenueDetails.Controls.Add(this.lblContact);
            this.grpVenueDetails.Controls.Add(this.txtFee);
            this.grpVenueDetails.Controls.Add(this.lblVdVenue);
            this.grpVenueDetails.Controls.Add(this.label3);
            this.grpVenueDetails.Controls.Add(this.txtCity);
            this.grpVenueDetails.Controls.Add(this.txtVenueID);
            this.grpVenueDetails.Controls.Add(this.lblVenueID);
            this.grpVenueDetails.Controls.Add(this.lblStreet1);
            this.grpVenueDetails.Controls.Add(this.txtMaxCap);
            this.grpVenueDetails.Controls.Add(this.lblMaxCap);
            this.grpVenueDetails.Controls.Add(this.lblEircode);
            this.grpVenueDetails.Controls.Add(this.txtStreet1);
            this.grpVenueDetails.Controls.Add(this.lblCity);
            this.grpVenueDetails.Location = new System.Drawing.Point(906, 73);
            this.grpVenueDetails.Name = "grpVenueDetails";
            this.grpVenueDetails.Size = new System.Drawing.Size(786, 785);
            this.grpVenueDetails.TabIndex = 61;
            this.grpVenueDetails.TabStop = false;
            this.grpVenueDetails.Text = "Venue Details";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 663);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 37);
            this.label2.TabIndex = 46;
            this.label2.Text = "Phone:";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 724);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 37);
            this.label3.TabIndex = 42;
            this.label3.Text = "Fee:";
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
            // grpEDetails
            // 
            this.grpEDetails.Controls.Add(this.txtAvailTix);
            this.grpEDetails.Controls.Add(this.lblAvailTix);
            this.grpEDetails.Controls.Add(this.txtTime);
            this.grpEDetails.Controls.Add(this.txtDate);
            this.grpEDetails.Controls.Add(this.lblDescription);
            this.grpEDetails.Controls.Add(this.label1);
            this.grpEDetails.Controls.Add(this.txtDescription);
            this.grpEDetails.Controls.Add(this.txtEventID);
            this.grpEDetails.Controls.Add(this.txtAdultPrice);
            this.grpEDetails.Controls.Add(this.txtChildPrice);
            this.grpEDetails.Controls.Add(this.txtMaxTix);
            this.grpEDetails.Controls.Add(this.lblTime);
            this.grpEDetails.Controls.Add(this.lblAdultPrice);
            this.grpEDetails.Controls.Add(this.lblChildPrice);
            this.grpEDetails.Controls.Add(this.txtTitle);
            this.grpEDetails.Controls.Add(this.lblTitle);
            this.grpEDetails.Controls.Add(this.lblMaxTix);
            this.grpEDetails.Controls.Add(this.lblDate);
            this.grpEDetails.Location = new System.Drawing.Point(906, 903);
            this.grpEDetails.Name = "grpEDetails";
            this.grpEDetails.Size = new System.Drawing.Size(786, 703);
            this.grpEDetails.TabIndex = 60;
            this.grpEDetails.TabStop = false;
            this.grpEDetails.Text = "Event Details";
            // 
            // txtAvailTix
            // 
            this.txtAvailTix.BackColor = System.Drawing.Color.Black;
            this.txtAvailTix.ForeColor = System.Drawing.Color.White;
            this.txtAvailTix.Location = new System.Drawing.Point(319, 493);
            this.txtAvailTix.Margin = new System.Windows.Forms.Padding(2);
            this.txtAvailTix.Name = "txtAvailTix";
            this.txtAvailTix.ReadOnly = true;
            this.txtAvailTix.Size = new System.Drawing.Size(127, 43);
            this.txtAvailTix.TabIndex = 56;
            // 
            // lblAvailTix
            // 
            this.lblAvailTix.AutoSize = true;
            this.lblAvailTix.Location = new System.Drawing.Point(32, 501);
            this.lblAvailTix.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvailTix.Name = "lblAvailTix";
            this.lblAvailTix.Size = new System.Drawing.Size(218, 37);
            this.lblAvailTix.TabIndex = 55;
            this.lblAvailTix.Text = "Available Tickets:";
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.Color.Black;
            this.txtTime.ForeColor = System.Drawing.Color.White;
            this.txtTime.Location = new System.Drawing.Point(320, 350);
            this.txtTime.Margin = new System.Windows.Forms.Padding(2);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(127, 43);
            this.txtTime.TabIndex = 54;
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.Black;
            this.txtDate.ForeColor = System.Drawing.Color.White;
            this.txtDate.Location = new System.Drawing.Point(319, 280);
            this.txtDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(127, 43);
            this.txtDate.TabIndex = 53;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(14, 221);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(230, 37);
            this.lblDescription.TabIndex = 28;
            this.lblDescription.Text = "Event Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 37);
            this.label1.TabIndex = 47;
            this.label1.Text = "Event ID:";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.Black;
            this.txtDescription.ForeColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(319, 213);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(445, 43);
            this.txtDescription.TabIndex = 29;
            // 
            // txtEventID
            // 
            this.txtEventID.BackColor = System.Drawing.Color.Black;
            this.txtEventID.ForeColor = System.Drawing.Color.White;
            this.txtEventID.Location = new System.Drawing.Point(319, 68);
            this.txtEventID.Margin = new System.Windows.Forms.Padding(2);
            this.txtEventID.Name = "txtEventID";
            this.txtEventID.ReadOnly = true;
            this.txtEventID.Size = new System.Drawing.Size(109, 43);
            this.txtEventID.TabIndex = 48;
            // 
            // txtAdultPrice
            // 
            this.txtAdultPrice.BackColor = System.Drawing.Color.Black;
            this.txtAdultPrice.ForeColor = System.Drawing.Color.White;
            this.txtAdultPrice.Location = new System.Drawing.Point(319, 568);
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
            this.txtChildPrice.Location = new System.Drawing.Point(319, 636);
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
            this.txtMaxTix.Location = new System.Drawing.Point(319, 421);
            this.txtMaxTix.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaxTix.Name = "txtMaxTix";
            this.txtMaxTix.ReadOnly = true;
            this.txtMaxTix.Size = new System.Drawing.Size(127, 43);
            this.txtMaxTix.TabIndex = 50;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(96, 359);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(153, 37);
            this.lblTime.TabIndex = 49;
            this.lblTime.Text = "Event Time:";
            // 
            // lblAdultPrice
            // 
            this.lblAdultPrice.AutoSize = true;
            this.lblAdultPrice.Location = new System.Drawing.Point(22, 574);
            this.lblAdultPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdultPrice.Name = "lblAdultPrice";
            this.lblAdultPrice.Size = new System.Drawing.Size(227, 37);
            this.lblAdultPrice.TabIndex = 30;
            this.lblAdultPrice.Text = "Adult Ticket Price:";
            // 
            // lblChildPrice
            // 
            this.lblChildPrice.AutoSize = true;
            this.lblChildPrice.Location = new System.Drawing.Point(24, 644);
            this.lblChildPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChildPrice.Name = "lblChildPrice";
            this.lblChildPrice.Size = new System.Drawing.Size(225, 37);
            this.lblChildPrice.TabIndex = 29;
            this.lblChildPrice.Text = "Child Ticket Price:";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.Black;
            this.txtTitle.ForeColor = System.Drawing.Color.White;
            this.txtTitle.Location = new System.Drawing.Point(320, 142);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(445, 43);
            this.txtTitle.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(104, 151);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(146, 37);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Event Title:";
            // 
            // lblMaxTix
            // 
            this.lblMaxTix.AutoSize = true;
            this.lblMaxTix.Location = new System.Drawing.Point(32, 429);
            this.lblMaxTix.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxTix.Name = "lblMaxTix";
            this.lblMaxTix.Size = new System.Drawing.Size(228, 37);
            this.lblMaxTix.TabIndex = 33;
            this.lblMaxTix.Text = "Maximum Tickets:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(101, 286);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(151, 37);
            this.lblDate.TabIndex = 16;
            this.lblDate.Text = "Event Date:";
            // 
            // grpFilterEvent
            // 
            this.grpFilterEvent.Controls.Add(this.btnFilter);
            this.grpFilterEvent.Controls.Add(this.cboVenue);
            this.grpFilterEvent.Controls.Add(this.lblFeVenue);
            this.grpFilterEvent.Location = new System.Drawing.Point(42, 58);
            this.grpFilterEvent.Name = "grpFilterEvent";
            this.grpFilterEvent.Size = new System.Drawing.Size(817, 251);
            this.grpFilterEvent.TabIndex = 59;
            this.grpFilterEvent.TabStop = false;
            this.grpFilterEvent.Text = "Filter Event";
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnFilter.Location = new System.Drawing.Point(163, 160);
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
            this.cboVenue.Location = new System.Drawing.Point(241, 66);
            this.cboVenue.Name = "cboVenue";
            this.cboVenue.Size = new System.Drawing.Size(445, 45);
            this.cboVenue.TabIndex = 44;
            // 
            // lblFeVenue
            // 
            this.lblFeVenue.AutoSize = true;
            this.lblFeVenue.Location = new System.Drawing.Point(97, 75);
            this.lblFeVenue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFeVenue.Name = "lblFeVenue";
            this.lblFeVenue.Size = new System.Drawing.Size(96, 37);
            this.lblFeVenue.TabIndex = 43;
            this.lblFeVenue.Text = "Venue:";
            // 
            // grpCreateSale
            // 
            this.grpCreateSale.Controls.Add(this.txtTotal);
            this.grpCreateSale.Controls.Add(this.nudChildQty);
            this.grpCreateSale.Controls.Add(this.nudAdultQty);
            this.grpCreateSale.Controls.Add(this.lblTotalCost);
            this.grpCreateSale.Controls.Add(this.lblTicketID);
            this.grpCreateSale.Controls.Add(this.chkEDetails);
            this.grpCreateSale.Controls.Add(this.txtSaleID);
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
            this.grpCreateSale.Location = new System.Drawing.Point(42, 350);
            this.grpCreateSale.Margin = new System.Windows.Forms.Padding(2);
            this.grpCreateSale.Name = "grpCreateSale";
            this.grpCreateSale.Padding = new System.Windows.Forms.Padding(2);
            this.grpCreateSale.Size = new System.Drawing.Size(817, 902);
            this.grpCreateSale.TabIndex = 58;
            this.grpCreateSale.TabStop = false;
            this.grpCreateSale.Text = "Create Sale";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.Black;
            this.txtTotal.ForeColor = System.Drawing.Color.White;
            this.txtTotal.Location = new System.Drawing.Point(305, 752);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(127, 43);
            this.txtTotal.TabIndex = 57;
            this.txtTotal.Text = "€0";
            // 
            // nudChildQty
            // 
            this.nudChildQty.Location = new System.Drawing.Point(305, 675);
            this.nudChildQty.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudChildQty.Name = "nudChildQty";
            this.nudChildQty.Size = new System.Drawing.Size(181, 43);
            this.nudChildQty.TabIndex = 38;
            this.nudChildQty.TextChanged += new System.EventHandler(this.nudChildQty_ValueChanged);
            // 
            // nudAdultQty
            // 
            this.nudAdultQty.Location = new System.Drawing.Point(305, 606);
            this.nudAdultQty.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nudAdultQty.Name = "nudAdultQty";
            this.nudAdultQty.Size = new System.Drawing.Size(181, 43);
            this.nudAdultQty.TabIndex = 37;
            this.nudAdultQty.TextChanged += new System.EventHandler(this.nudAdultQty_ValueChanged);
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(104, 757);
            this.lblTotalCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(140, 37);
            this.lblTotalCost.TabIndex = 53;
            this.lblTotalCost.Text = "Total Cost:";
            // 
            // lblTicketID
            // 
            this.lblTicketID.AutoSize = true;
            this.lblTicketID.Location = new System.Drawing.Point(142, 64);
            this.lblTicketID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTicketID.Name = "lblTicketID";
            this.lblTicketID.Size = new System.Drawing.Size(105, 37);
            this.lblTicketID.TabIndex = 47;
            this.lblTicketID.Text = "Sale ID:";
            // 
            // chkEDetails
            // 
            this.chkEDetails.AutoSize = true;
            this.chkEDetails.Checked = true;
            this.chkEDetails.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEDetails.Location = new System.Drawing.Point(304, 275);
            this.chkEDetails.Name = "chkEDetails";
            this.chkEDetails.Size = new System.Drawing.Size(28, 27);
            this.chkEDetails.TabIndex = 52;
            this.chkEDetails.UseVisualStyleBackColor = true;
            // 
            // txtSaleID
            // 
            this.txtSaleID.BackColor = System.Drawing.Color.Black;
            this.txtSaleID.ForeColor = System.Drawing.Color.White;
            this.txtSaleID.Location = new System.Drawing.Point(328, 59);
            this.txtSaleID.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaleID.Name = "txtSaleID";
            this.txtSaleID.ReadOnly = true;
            this.txtSaleID.Size = new System.Drawing.Size(110, 43);
            this.txtSaleID.TabIndex = 48;
            // 
            // lblEventDetails
            // 
            this.lblEventDetails.AutoSize = true;
            this.lblEventDetails.Location = new System.Drawing.Point(66, 271);
            this.lblEventDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventDetails.Name = "lblEventDetails";
            this.lblEventDetails.Size = new System.Drawing.Size(176, 37);
            this.lblEventDetails.TabIndex = 51;
            this.lblEventDetails.Text = "Event Details:";
            // 
            // chkVDetails
            // 
            this.chkVDetails.AutoSize = true;
            this.chkVDetails.Checked = true;
            this.chkVDetails.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVDetails.Location = new System.Drawing.Point(304, 219);
            this.chkVDetails.Name = "chkVDetails";
            this.chkVDetails.Size = new System.Drawing.Size(28, 27);
            this.chkVDetails.TabIndex = 50;
            this.chkVDetails.UseVisualStyleBackColor = true;
            // 
            // lblVenueDetails
            // 
            this.lblVenueDetails.AutoSize = true;
            this.lblVenueDetails.Location = new System.Drawing.Point(62, 214);
            this.lblVenueDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVenueDetails.Name = "lblVenueDetails";
            this.lblVenueDetails.Size = new System.Drawing.Size(184, 37);
            this.lblVenueDetails.TabIndex = 49;
            this.lblVenueDetails.Text = "Venue Details:";
            // 
            // lblChildTktQty
            // 
            this.lblChildTktQty.AutoSize = true;
            this.lblChildTktQty.Location = new System.Drawing.Point(29, 682);
            this.lblChildTktQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChildTktQty.Name = "lblChildTktQty";
            this.lblChildTktQty.Size = new System.Drawing.Size(210, 37);
            this.lblChildTktQty.TabIndex = 25;
            this.lblChildTktQty.Text = "Child Ticket Qty:";
            // 
            // lblAdultTktQty
            // 
            this.lblAdultTktQty.AutoSize = true;
            this.lblAdultTktQty.Location = new System.Drawing.Point(107, 609);
            this.lblAdultTktQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdultTktQty.Name = "lblAdultTktQty";
            this.lblAdultTktQty.Size = new System.Drawing.Size(136, 37);
            this.lblAdultTktQty.TabIndex = 23;
            this.lblAdultTktQty.Text = "Adult Qty:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(305, 402);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(445, 43);
            this.txtLastName.TabIndex = 22;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(98, 407);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(148, 37);
            this.lblLastName.TabIndex = 21;
            this.lblLastName.Text = "Last Name:";
            // 
            // cboEvent
            // 
            this.cboEvent.FormattingEnabled = true;
            this.cboEvent.Items.AddRange(new object[] {
            ""});
            this.cboEvent.Location = new System.Drawing.Point(328, 130);
            this.cboEvent.Margin = new System.Windows.Forms.Padding(2);
            this.cboEvent.Name = "cboEvent";
            this.cboEvent.Size = new System.Drawing.Size(267, 45);
            this.cboEvent.TabIndex = 20;
            this.cboEvent.SelectedIndexChanged += new System.EventHandler(this.cboEvent_SelectedIndexChanged);
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Location = new System.Drawing.Point(181, 135);
            this.lblEvent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(88, 37);
            this.lblEvent.TabIndex = 19;
            this.lblEvent.Text = "Event:";
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(305, 530);
            this.txtPhoneNum.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(445, 43);
            this.txtPhoneNum.TabIndex = 16;
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Location = new System.Drawing.Point(43, 532);
            this.lblPhoneNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(202, 37);
            this.lblPhoneNum.TabIndex = 15;
            this.lblPhoneNum.Text = "Phone Number:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(305, 342);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(445, 43);
            this.txtFirstName.TabIndex = 10;
            // 
            // btnCreateSale
            // 
            this.btnCreateSale.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCreateSale.Location = new System.Drawing.Point(84, 828);
            this.btnCreateSale.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateSale.Name = "btnCreateSale";
            this.btnCreateSale.Size = new System.Drawing.Size(637, 52);
            this.btnCreateSale.TabIndex = 14;
            this.btnCreateSale.Text = "Create Sale";
            this.btnCreateSale.UseVisualStyleBackColor = false;
            this.btnCreateSale.Click += new System.EventHandler(this.btnCreateSale_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(96, 347);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(150, 37);
            this.lblFirstName.TabIndex = 9;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(305, 466);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(445, 43);
            this.txtEmail.TabIndex = 13;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(58, 471);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(189, 37);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email Address:";
            // 
            // frmProcessTicketSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1779, 1726);
            this.Controls.Add(this.grpSales);
            this.Controls.Add(this.mnuMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmProcessTicketSale";
            this.Text = "Process Ticket Sale";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCreateSale_FormClosed);
            this.Load += new System.EventHandler(this.frmCreateSale_Load);
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.grpSales.ResumeLayout(false);
            this.grpVenueDetails.ResumeLayout(false);
            this.grpVenueDetails.PerformLayout();
            this.grpEDetails.ResumeLayout(false);
            this.grpEDetails.PerformLayout();
            this.grpFilterEvent.ResumeLayout(false);
            this.grpFilterEvent.PerformLayout();
            this.grpCreateSale.ResumeLayout(false);
            this.grpCreateSale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudChildQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdultQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem MnuItemBack;
        private System.Windows.Forms.GroupBox grpSales;
        private System.Windows.Forms.GroupBox grpVenueDetails;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStreet2;
        private System.Windows.Forms.TextBox txtStreet2;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtVdVenue;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.Label lblVdVenue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtVenueID;
        private System.Windows.Forms.Label lblVenueID;
        private System.Windows.Forms.Label lblStreet1;
        private System.Windows.Forms.TextBox txtMaxCap;
        private System.Windows.Forms.Label lblMaxCap;
        private System.Windows.Forms.Label lblEircode;
        private System.Windows.Forms.TextBox txtStreet1;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.GroupBox grpEDetails;
        private System.Windows.Forms.TextBox txtAvailTix;
        private System.Windows.Forms.Label lblAvailTix;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtEventID;
        private System.Windows.Forms.TextBox txtAdultPrice;
        private System.Windows.Forms.TextBox txtChildPrice;
        private System.Windows.Forms.TextBox txtMaxTix;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblAdultPrice;
        private System.Windows.Forms.Label lblChildPrice;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMaxTix;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox grpFilterEvent;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cboVenue;
        private System.Windows.Forms.Label lblFeVenue;
        private System.Windows.Forms.GroupBox grpCreateSale;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.NumericUpDown nudChildQty;
        private System.Windows.Forms.NumericUpDown nudAdultQty;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblTicketID;
        private System.Windows.Forms.CheckBox chkEDetails;
        private System.Windows.Forms.TextBox txtSaleID;
        private System.Windows.Forms.Label lblEventDetails;
        private System.Windows.Forms.CheckBox chkVDetails;
        private System.Windows.Forms.Label lblVenueDetails;
        private System.Windows.Forms.Label lblChildTktQty;
        private System.Windows.Forms.Label lblAdultTktQty;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.ComboBox cboEvent;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnCreateSale;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
    }
}