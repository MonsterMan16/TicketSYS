
namespace TicketSYS
{
    partial class frmAddVenue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddVenue));
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuItemBack = new System.Windows.Forms.ToolStripMenuItem();
            this.lblVenueID = new System.Windows.Forms.Label();
            this.txtVenueID = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grpAddVenue = new System.Windows.Forms.GroupBox();
            this.lblCounty = new System.Windows.Forms.Label();
            this.nudFee = new System.Windows.Forms.NumericUpDown();
            this.cboCounty = new System.Windows.Forms.ComboBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
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
            this.btnAddVenue = new System.Windows.Forms.Button();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreet1 = new System.Windows.Forms.Label();
            this.mnuMainMenu.SuspendLayout();
            this.grpAddVenue.SuspendLayout();
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
            this.mnuMainMenu.Size = new System.Drawing.Size(1024, 45);
            this.mnuMainMenu.TabIndex = 2;
            this.mnuMainMenu.Text = "mnuMainMenu";
            // 
            // mnuItemBack
            // 
            this.mnuItemBack.Name = "mnuItemBack";
            this.mnuItemBack.Size = new System.Drawing.Size(93, 41);
            this.mnuItemBack.Text = "Back";
            this.mnuItemBack.Click += new System.EventHandler(this.exitToolStripMnuItem_Click);
            // 
            // lblVenueID
            // 
            this.lblVenueID.AutoSize = true;
            this.lblVenueID.Location = new System.Drawing.Point(211, 61);
            this.lblVenueID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVenueID.Name = "lblVenueID";
            this.lblVenueID.Size = new System.Drawing.Size(136, 37);
            this.lblVenueID.TabIndex = 0;
            this.lblVenueID.Text = "Venue ID: ";
            // 
            // txtVenueID
            // 
            this.txtVenueID.BackColor = System.Drawing.Color.Black;
            this.txtVenueID.ForeColor = System.Drawing.SystemColors.Window;
            this.txtVenueID.HideSelection = false;
            this.txtVenueID.Location = new System.Drawing.Point(396, 56);
            this.txtVenueID.Margin = new System.Windows.Forms.Padding(2);
            this.txtVenueID.Name = "txtVenueID";
            this.txtVenueID.ReadOnly = true;
            this.txtVenueID.Size = new System.Drawing.Size(88, 43);
            this.txtVenueID.TabIndex = 0;
            this.txtVenueID.TabStop = false;
            this.txtVenueID.Text = "1";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(166, 134);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(174, 37);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Venue Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(396, 129);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(445, 43);
            this.txtName.TabIndex = 1;
            // 
            // grpAddVenue
            // 
            this.grpAddVenue.Controls.Add(this.lblCounty);
            this.grpAddVenue.Controls.Add(this.nudFee);
            this.grpAddVenue.Controls.Add(this.cboCounty);
            this.grpAddVenue.Controls.Add(this.txtAddress2);
            this.grpAddVenue.Controls.Add(this.lblStreet2);
            this.grpAddVenue.Controls.Add(this.lblFee);
            this.grpAddVenue.Controls.Add(this.txtContact);
            this.grpAddVenue.Controls.Add(this.txtPhone);
            this.grpAddVenue.Controls.Add(this.lblContact);
            this.grpAddVenue.Controls.Add(this.lblPhone);
            this.grpAddVenue.Controls.Add(this.nudCapacity);
            this.grpAddVenue.Controls.Add(this.txtEircode);
            this.grpAddVenue.Controls.Add(this.txtCity);
            this.grpAddVenue.Controls.Add(this.lblMaxCap);
            this.grpAddVenue.Controls.Add(this.lblEircode);
            this.grpAddVenue.Controls.Add(this.btnAddVenue);
            this.grpAddVenue.Controls.Add(this.txtAddress1);
            this.grpAddVenue.Controls.Add(this.lblCity);
            this.grpAddVenue.Controls.Add(this.txtName);
            this.grpAddVenue.Controls.Add(this.lblStreet1);
            this.grpAddVenue.Controls.Add(this.txtVenueID);
            this.grpAddVenue.Controls.Add(this.lblName);
            this.grpAddVenue.Controls.Add(this.lblVenueID);
            this.grpAddVenue.Location = new System.Drawing.Point(22, 63);
            this.grpAddVenue.Margin = new System.Windows.Forms.Padding(2);
            this.grpAddVenue.Name = "grpAddVenue";
            this.grpAddVenue.Padding = new System.Windows.Forms.Padding(2);
            this.grpAddVenue.Size = new System.Drawing.Size(980, 991);
            this.grpAddVenue.TabIndex = 3;
            this.grpAddVenue.TabStop = false;
            this.grpAddVenue.Text = "Add Venue";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(226, 526);
            this.lblCounty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(108, 37);
            this.lblCounty.TabIndex = 23;
            this.lblCounty.Text = "County:";
            // 
            // nudFee
            // 
            this.nudFee.Location = new System.Drawing.Point(396, 821);
            this.nudFee.Margin = new System.Windows.Forms.Padding(2);
            this.nudFee.Name = "nudFee";
            this.nudFee.Size = new System.Drawing.Size(132, 43);
            this.nudFee.TabIndex = 22;
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
            this.cboCounty.Location = new System.Drawing.Point(396, 520);
            this.cboCounty.Margin = new System.Windows.Forms.Padding(2);
            this.cboCounty.Name = "cboCounty";
            this.cboCounty.Size = new System.Drawing.Size(289, 45);
            this.cboCounty.TabIndex = 21;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(396, 288);
            this.txtAddress2.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(445, 43);
            this.txtAddress2.TabIndex = 20;
            // 
            // lblStreet2
            // 
            this.lblStreet2.AutoSize = true;
            this.lblStreet2.Location = new System.Drawing.Point(124, 293);
            this.lblStreet2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStreet2.Name = "lblStreet2";
            this.lblStreet2.Size = new System.Drawing.Size(214, 37);
            this.lblStreet2.TabIndex = 19;
            this.lblStreet2.Text = "Street Address 2:";
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Location = new System.Drawing.Point(276, 821);
            this.lblFee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(64, 37);
            this.lblFee.TabIndex = 15;
            this.lblFee.Text = "Fee:";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(396, 674);
            this.txtContact.Margin = new System.Windows.Forms.Padding(2);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(289, 43);
            this.txtContact.TabIndex = 14;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(396, 743);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(289, 43);
            this.txtPhone.TabIndex = 12;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(226, 679);
            this.lblContact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(115, 37);
            this.lblContact.TabIndex = 13;
            this.lblContact.Text = "Contact:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(243, 748);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(98, 37);
            this.lblPhone.TabIndex = 11;
            this.lblPhone.Text = "Phone:";
            // 
            // nudCapacity
            // 
            this.nudCapacity.Location = new System.Drawing.Point(396, 597);
            this.nudCapacity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.nudCapacity.Size = new System.Drawing.Size(166, 43);
            this.nudCapacity.TabIndex = 9;
            this.nudCapacity.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // txtEircode
            // 
            this.txtEircode.Location = new System.Drawing.Point(396, 440);
            this.txtEircode.Margin = new System.Windows.Forms.Padding(2);
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.Size = new System.Drawing.Size(168, 43);
            this.txtEircode.TabIndex = 7;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(396, 362);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(289, 43);
            this.txtCity.TabIndex = 5;
            // 
            // lblMaxCap
            // 
            this.lblMaxCap.AutoSize = true;
            this.lblMaxCap.Location = new System.Drawing.Point(160, 603);
            this.lblMaxCap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxCap.Name = "lblMaxCap";
            this.lblMaxCap.Size = new System.Drawing.Size(182, 37);
            this.lblMaxCap.TabIndex = 8;
            this.lblMaxCap.Text = "Max Capacity:";
            // 
            // lblEircode
            // 
            this.lblEircode.AutoSize = true;
            this.lblEircode.Location = new System.Drawing.Point(226, 446);
            this.lblEircode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEircode.Name = "lblEircode";
            this.lblEircode.Size = new System.Drawing.Size(111, 37);
            this.lblEircode.TabIndex = 6;
            this.lblEircode.Text = "Eircode:";
            // 
            // btnAddVenue
            // 
            this.btnAddVenue.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAddVenue.Location = new System.Drawing.Point(132, 916);
            this.btnAddVenue.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddVenue.Name = "btnAddVenue";
            this.btnAddVenue.Size = new System.Drawing.Size(708, 52);
            this.btnAddVenue.TabIndex = 10;
            this.btnAddVenue.Text = "Add Venue";
            this.btnAddVenue.UseVisualStyleBackColor = false;
            this.btnAddVenue.Click += new System.EventHandler(this.btnAddVenue_Click);
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(396, 207);
            this.txtAddress1.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(445, 43);
            this.txtAddress1.TabIndex = 3;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(273, 367);
            this.lblCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(69, 37);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "City:";
            // 
            // lblStreet1
            // 
            this.lblStreet1.AutoSize = true;
            this.lblStreet1.Location = new System.Drawing.Point(124, 213);
            this.lblStreet1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStreet1.Name = "lblStreet1";
            this.lblStreet1.Size = new System.Drawing.Size(214, 37);
            this.lblStreet1.TabIndex = 2;
            this.lblStreet1.Text = "Street Address 1:";
            // 
            // frmAddVenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 1074);
            this.Controls.Add(this.grpAddVenue);
            this.Controls.Add(this.mnuMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAddVenue";
            this.Text = "Add Venue";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCreateVenue_FormClosed);
            this.Load += new System.EventHandler(this.frmCreateVenue_Load);
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.grpAddVenue.ResumeLayout(false);
            this.grpAddVenue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuItemBack;
        private System.Windows.Forms.GroupBox grpAddVenue;
        private System.Windows.Forms.Label lblVenueID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtVenueID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblStreet1;
        private System.Windows.Forms.Button btnAddVenue;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblMaxCap;
        private System.Windows.Forms.Label lblEircode;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.NumericUpDown nudCapacity;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.Label lblStreet2;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.NumericUpDown nudFee;
        private System.Windows.Forms.ComboBox cboCounty;
    }
}