
using System.Windows.Forms;

namespace TicketSYS
{
    partial class frmUpdateVenue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateVenue));
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuItemBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpAddVenue = new System.Windows.Forms.GroupBox();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.lblVenue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFtCity = new System.Windows.Forms.Label();
            this.cboVenue = new System.Windows.Forms.ComboBox();
            this.cboFtCity = new System.Windows.Forms.ComboBox();
            this.cboFtCounty = new System.Windows.Forms.ComboBox();
            this.grpVenue = new System.Windows.Forms.GroupBox();
            this.btnUpdateVenue = new System.Windows.Forms.Button();
            this.cboCounty = new System.Windows.Forms.ComboBox();
            this.lblVenueID = new System.Windows.Forms.Label();
            this.txtVenueID = new System.Windows.Forms.TextBox();
            this.lblCounty = new System.Windows.Forms.Label();
            this.nudFee = new System.Windows.Forms.NumericUpDown();
            this.txtStreet2 = new System.Windows.Forms.TextBox();
            this.lblStreet2 = new System.Windows.Forms.Label();
            this.lblFee = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.nudCapacity = new System.Windows.Forms.NumericUpDown();
            this.txtEircode = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblMaxCap = new System.Windows.Forms.Label();
            this.lblEircode = new System.Windows.Forms.Label();
            this.txtStreet1 = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblStreet1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.mnuMainMenu.SuspendLayout();
            this.grpAddVenue.SuspendLayout();
            this.grpFilter.SuspendLayout();
            this.grpVenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).BeginInit();
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
            this.mnuMainMenu.Size = new System.Drawing.Size(1139, 58);
            this.mnuMainMenu.TabIndex = 2;
            this.mnuMainMenu.Text = "menuStrip1";
            // 
            // mnuItemBack
            // 
            this.mnuItemBack.Name = "mnuItemBack";
            this.mnuItemBack.Size = new System.Drawing.Size(122, 52);
            this.mnuItemBack.Text = "Back";
            this.mnuItemBack.Click += new System.EventHandler(this.exitToolStripMnuItem_Click);
            // 
            // grpAddVenue
            // 
            this.grpAddVenue.Controls.Add(this.grpFilter);
            this.grpAddVenue.Controls.Add(this.grpVenue);
            this.grpAddVenue.Location = new System.Drawing.Point(29, 74);
            this.grpAddVenue.Name = "grpAddVenue";
            this.grpAddVenue.Size = new System.Drawing.Size(1079, 1646);
            this.grpAddVenue.TabIndex = 4;
            this.grpAddVenue.TabStop = false;
            this.grpAddVenue.Text = "Add Venue";
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.lblVenue);
            this.grpFilter.Controls.Add(this.label2);
            this.grpFilter.Controls.Add(this.lblFtCity);
            this.grpFilter.Controls.Add(this.cboVenue);
            this.grpFilter.Controls.Add(this.cboFtCity);
            this.grpFilter.Controls.Add(this.cboFtCounty);
            this.grpFilter.Location = new System.Drawing.Point(29, 66);
            this.grpFilter.Margin = new System.Windows.Forms.Padding(4);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Padding = new System.Windows.Forms.Padding(4);
            this.grpFilter.Size = new System.Drawing.Size(1012, 365);
            this.grpFilter.TabIndex = 56;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Filter Ticket";
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.Location = new System.Drawing.Point(167, 271);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(126, 48);
            this.lblVenue.TabIndex = 48;
            this.lblVenue.Text = "Venue:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 48);
            this.label2.TabIndex = 47;
            this.label2.Text = "County:";
            // 
            // lblFtCity
            // 
            this.lblFtCity.AutoSize = true;
            this.lblFtCity.Location = new System.Drawing.Point(203, 99);
            this.lblFtCity.Name = "lblFtCity";
            this.lblFtCity.Size = new System.Drawing.Size(88, 48);
            this.lblFtCity.TabIndex = 46;
            this.lblFtCity.Text = "City:";
            // 
            // cboVenue
            // 
            this.cboVenue.FormattingEnabled = true;
            this.cboVenue.Location = new System.Drawing.Point(384, 261);
            this.cboVenue.Name = "cboVenue";
            this.cboVenue.Size = new System.Drawing.Size(385, 56);
            this.cboVenue.TabIndex = 45;
            this.cboVenue.SelectedIndexChanged += new System.EventHandler(this.cboVenue_SelectedIndexChanged);

            this.cboVenue.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cboVenue.AutoCompleteSource = AutoCompleteSource.ListItems;
            // 
            // cboFtCity
            // 
            this.cboFtCity.FormattingEnabled = true;
            this.cboFtCity.Location = new System.Drawing.Point(384, 88);
            this.cboFtCity.Margin = new System.Windows.Forms.Padding(4);
            this.cboFtCity.Name = "cboFtCity";
            this.cboFtCity.Size = new System.Drawing.Size(385, 56);
            this.cboFtCity.TabIndex = 44;
            // 
            // cboFtCounty
            // 
            this.cboFtCounty.FormattingEnabled = true;
            this.cboFtCounty.Location = new System.Drawing.Point(384, 174);
            this.cboFtCounty.Name = "cboFtCounty";
            this.cboFtCounty.Size = new System.Drawing.Size(385, 56);
            this.cboFtCounty.TabIndex = 20;
            // 
            // grpVenue
            // 
            this.grpVenue.Controls.Add(this.btnUpdateVenue);
            this.grpVenue.Controls.Add(this.cboCounty);
            this.grpVenue.Controls.Add(this.lblVenueID);
            this.grpVenue.Controls.Add(this.txtVenueID);
            this.grpVenue.Controls.Add(this.lblCounty);
            this.grpVenue.Controls.Add(this.nudFee);
            this.grpVenue.Controls.Add(this.txtStreet2);
            this.grpVenue.Controls.Add(this.lblStreet2);
            this.grpVenue.Controls.Add(this.lblFee);
            this.grpVenue.Controls.Add(this.txtContact);
            this.grpVenue.Controls.Add(this.txtPhone);
            this.grpVenue.Controls.Add(this.lblContact);
            this.grpVenue.Controls.Add(this.lblPhone);
            this.grpVenue.Controls.Add(this.nudCapacity);
            this.grpVenue.Controls.Add(this.txtEircode);
            this.grpVenue.Controls.Add(this.txtCity);
            this.grpVenue.Controls.Add(this.lblMaxCap);
            this.grpVenue.Controls.Add(this.lblEircode);
            this.grpVenue.Controls.Add(this.txtStreet1);
            this.grpVenue.Controls.Add(this.lblCity);
            this.grpVenue.Controls.Add(this.txtName);
            this.grpVenue.Controls.Add(this.lblStreet1);
            this.grpVenue.Controls.Add(this.lblName);
            this.grpVenue.Location = new System.Drawing.Point(29, 457);
            this.grpVenue.Name = "grpVenue";
            this.grpVenue.Size = new System.Drawing.Size(1012, 1160);
            this.grpVenue.TabIndex = 20;
            this.grpVenue.TabStop = false;
            this.grpVenue.Text = "Update Venue Details";
            this.grpVenue.Visible = false;
            // 
            // btnUpdateVenue
            // 
            this.btnUpdateVenue.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnUpdateVenue.Location = new System.Drawing.Point(33, 1069);
            this.btnUpdateVenue.Name = "btnUpdateVenue";
            this.btnUpdateVenue.Size = new System.Drawing.Size(944, 67);
            this.btnUpdateVenue.TabIndex = 45;
            this.btnUpdateVenue.Text = "Update Venue";
            this.btnUpdateVenue.UseVisualStyleBackColor = false;
            this.btnUpdateVenue.Click += new System.EventHandler(this.btnUpdateVenue_Click);
            // 
            // cboCounty
            // 
            this.cboCounty.FormattingEnabled = true;
            this.cboCounty.Items.AddRange(new object[] {
            "",
            "Antrim",
            "Armagh",
            "Carlow",
            "Cavan",
            "Clare",
            "Cork",
            "Derry",
            "Donegal",
            "Down",
            "Dublin",
            "Fermanagh",
            "Galway",
            "Kerry",
            "Kildare",
            "Kilkenny",
            "Laois",
            "Leitrim",
            "Limerick",
            "Longford",
            "Louth",
            "Mayo",
            "Meath",
            "Monaghan",
            "Offaly",
            "Roscommon",
            "Sligo",
            "Tipperary",
            "Tyrone",
            "Waterford",
            "Westmeath",
            "Wexford",
            "Wicklow"});
            this.cboCounty.Location = new System.Drawing.Point(389, 537);
            this.cboCounty.Name = "cboCounty";
            this.cboCounty.Size = new System.Drawing.Size(384, 56);
            this.cboCounty.TabIndex = 44;
            // 
            // lblVenueID
            // 
            this.lblVenueID.AutoSize = true;
            this.lblVenueID.Location = new System.Drawing.Point(135, 99);
            this.lblVenueID.Name = "lblVenueID";
            this.lblVenueID.Size = new System.Drawing.Size(171, 48);
            this.lblVenueID.TabIndex = 0;
            this.lblVenueID.Text = "Venue ID:";
            // 
            // txtVenueID
            // 
            this.txtVenueID.BackColor = System.Drawing.Color.Black;
            this.txtVenueID.ForeColor = System.Drawing.SystemColors.Window;
            this.txtVenueID.HideSelection = false;
            this.txtVenueID.Location = new System.Drawing.Point(384, 91);
            this.txtVenueID.Name = "txtVenueID";
            this.txtVenueID.ReadOnly = true;
            this.txtVenueID.Size = new System.Drawing.Size(116, 55);
            this.txtVenueID.TabIndex = 0;
            this.txtVenueID.TabStop = false;
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(163, 545);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(140, 48);
            this.lblCounty.TabIndex = 43;
            this.lblCounty.Text = "County:";
            // 
            // nudFee
            // 
            this.nudFee.DecimalPlaces = 1;
            this.nudFee.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudFee.Location = new System.Drawing.Point(389, 981);
            this.nudFee.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nudFee.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudFee.Name = "nudFee";
            this.nudFee.Size = new System.Drawing.Size(221, 55);
            this.nudFee.TabIndex = 42;
            this.nudFee.Value = new decimal(new int[] {
            99,
            0,
            0,
            0});
            // 
            // txtStreet2
            // 
            this.txtStreet2.Location = new System.Drawing.Point(384, 371);
            this.txtStreet2.Name = "txtStreet2";
            this.txtStreet2.Size = new System.Drawing.Size(592, 55);
            this.txtStreet2.TabIndex = 41;
            // 
            // lblStreet2
            // 
            this.lblStreet2.AutoSize = true;
            this.lblStreet2.Location = new System.Drawing.Point(21, 379);
            this.lblStreet2.Name = "lblStreet2";
            this.lblStreet2.Size = new System.Drawing.Size(287, 48);
            this.lblStreet2.TabIndex = 40;
            this.lblStreet2.Text = "Street Address 2:";
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Location = new System.Drawing.Point(232, 987);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(84, 48);
            this.lblFee.TabIndex = 39;
            this.lblFee.Text = "Fee:";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(389, 890);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(219, 55);
            this.txtContact.TabIndex = 38;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(389, 799);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(219, 55);
            this.txtPhone.TabIndex = 36;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(163, 898);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(150, 48);
            this.lblContact.TabIndex = 37;
            this.lblContact.Text = "Contact:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(185, 807);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(128, 48);
            this.lblPhone.TabIndex = 35;
            this.lblPhone.Text = "Phone:";
            // 
            // nudCapacity
            // 
            this.nudCapacity.Location = new System.Drawing.Point(389, 708);
            this.nudCapacity.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nudCapacity.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nudCapacity.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudCapacity.Name = "nudCapacity";
            this.nudCapacity.Size = new System.Drawing.Size(221, 55);
            this.nudCapacity.TabIndex = 34;
            this.nudCapacity.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});

            this.nudCapacity.Controls.RemoveAt(0);
            // 
            // txtEircode
            // 
            this.txtEircode.Location = new System.Drawing.Point(389, 618);
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.Size = new System.Drawing.Size(219, 55);
            this.txtEircode.TabIndex = 32;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(389, 454);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(219, 55);
            this.txtCity.TabIndex = 30;
            // 
            // lblMaxCap
            // 
            this.lblMaxCap.AutoSize = true;
            this.lblMaxCap.Location = new System.Drawing.Point(75, 715);
            this.lblMaxCap.Name = "lblMaxCap";
            this.lblMaxCap.Size = new System.Drawing.Size(239, 48);
            this.lblMaxCap.TabIndex = 33;
            this.lblMaxCap.Text = "Max Capacity:";
            // 
            // lblEircode
            // 
            this.lblEircode.AutoSize = true;
            this.lblEircode.Location = new System.Drawing.Point(163, 624);
            this.lblEircode.Name = "lblEircode";
            this.lblEircode.Size = new System.Drawing.Size(146, 48);
            this.lblEircode.TabIndex = 31;
            this.lblEircode.Text = "Eircode:";
            // 
            // txtStreet1
            // 
            this.txtStreet1.Location = new System.Drawing.Point(384, 279);
            this.txtStreet1.Name = "txtStreet1";
            this.txtStreet1.Size = new System.Drawing.Size(592, 55);
            this.txtStreet1.TabIndex = 28;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(220, 461);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(88, 48);
            this.lblCity.TabIndex = 29;
            this.lblCity.Text = "City:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(384, 187);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(592, 55);
            this.txtName.TabIndex = 26;
            // 
            // lblStreet1
            // 
            this.lblStreet1.AutoSize = true;
            this.lblStreet1.Location = new System.Drawing.Point(51, 285);
            this.lblStreet1.Name = "lblStreet1";
            this.lblStreet1.Size = new System.Drawing.Size(258, 48);
            this.lblStreet1.TabIndex = 27;
            this.lblStreet1.Text = "Street Address:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(77, 195);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(231, 48);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "Venue Name:";
            // 
            // frmUpdateVenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 1745);
            this.Controls.Add(this.grpAddVenue);
            this.Controls.Add(this.mnuMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUpdateVenue";
            this.Text = "Update Venue";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUpdateVenue_FormClosed);
            this.Load += new System.EventHandler(this.frmUpdateVenues_Load);
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.grpAddVenue.ResumeLayout(false);
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.grpVenue.ResumeLayout(false);
            this.grpVenue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuItemBack;
        private System.Windows.Forms.GroupBox grpAddVenue;
        private System.Windows.Forms.TextBox txtVenueID;
        private System.Windows.Forms.Label lblVenueID;
        private System.Windows.Forms.GroupBox grpVenue;
        private System.Windows.Forms.Button btnUpdateVenue;
        private System.Windows.Forms.ComboBox cboCounty;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.NumericUpDown nudFee;
        private System.Windows.Forms.TextBox txtStreet2;
        private System.Windows.Forms.Label lblStreet2;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.NumericUpDown nudCapacity;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblMaxCap;
        private System.Windows.Forms.Label lblEircode;
        private System.Windows.Forms.TextBox txtStreet1;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblStreet1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.ComboBox cboFtCity;
        private System.Windows.Forms.ComboBox cboFtCounty;
        private System.Windows.Forms.ComboBox cboVenue;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFtCity;
    }
}