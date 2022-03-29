
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
            this.mnuMainMenu.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.mnuMainMenu.Size = new System.Drawing.Size(1365, 63);
            this.mnuMainMenu.TabIndex = 2;
            this.mnuMainMenu.Text = "mnuMainMenu";
            // 
            // mnuItemBack
            // 
            this.mnuItemBack.Name = "mnuItemBack";
            this.mnuItemBack.Size = new System.Drawing.Size(122, 57);
            this.mnuItemBack.Text = "Back";
            this.mnuItemBack.Click += new System.EventHandler(this.exitToolStripMnuItem_Click);
            // 
            // lblVenueID
            // 
            this.lblVenueID.AutoSize = true;
            this.lblVenueID.Location = new System.Drawing.Point(281, 79);
            this.lblVenueID.Name = "lblVenueID";
            this.lblVenueID.Size = new System.Drawing.Size(181, 48);
            this.lblVenueID.TabIndex = 0;
            this.lblVenueID.Text = "Venue ID: ";
            // 
            // txtVenueID
            // 
            this.txtVenueID.BackColor = System.Drawing.Color.Black;
            this.txtVenueID.ForeColor = System.Drawing.SystemColors.Window;
            this.txtVenueID.HideSelection = false;
            this.txtVenueID.Location = new System.Drawing.Point(528, 73);
            this.txtVenueID.Name = "txtVenueID";
            this.txtVenueID.ReadOnly = true;
            this.txtVenueID.Size = new System.Drawing.Size(116, 55);
            this.txtVenueID.TabIndex = 0;
            this.txtVenueID.TabStop = false;
            this.txtVenueID.Text = "1";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(221, 174);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(231, 48);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Venue Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(528, 167);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(592, 55);
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
            this.grpAddVenue.Location = new System.Drawing.Point(29, 82);
            this.grpAddVenue.Name = "grpAddVenue";
            this.grpAddVenue.Size = new System.Drawing.Size(1307, 1286);
            this.grpAddVenue.TabIndex = 3;
            this.grpAddVenue.TabStop = false;
            this.grpAddVenue.Text = "Add Venue";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(301, 682);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(140, 48);
            this.lblCounty.TabIndex = 23;
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
            this.nudFee.Location = new System.Drawing.Point(528, 1065);
            this.nudFee.Name = "nudFee";
            this.nudFee.Size = new System.Drawing.Size(176, 55);
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
            this.cboCounty.Location = new System.Drawing.Point(528, 675);
            this.cboCounty.Name = "cboCounty";
            this.cboCounty.Size = new System.Drawing.Size(384, 56);
            this.cboCounty.TabIndex = 21;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(528, 374);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(592, 55);
            this.txtAddress2.TabIndex = 20;
            // 
            // lblStreet2
            // 
            this.lblStreet2.AutoSize = true;
            this.lblStreet2.Location = new System.Drawing.Point(165, 380);
            this.lblStreet2.Name = "lblStreet2";
            this.lblStreet2.Size = new System.Drawing.Size(287, 48);
            this.lblStreet2.TabIndex = 19;
            this.lblStreet2.Text = "Street Address 2:";
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Location = new System.Drawing.Point(368, 1065);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(84, 48);
            this.lblFee.TabIndex = 15;
            this.lblFee.Text = "Fee:";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(528, 874);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(384, 55);
            this.txtContact.TabIndex = 14;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(528, 964);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(384, 55);
            this.txtPhone.TabIndex = 12;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(301, 881);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(150, 48);
            this.lblContact.TabIndex = 13;
            this.lblContact.Text = "Contact:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(324, 970);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(128, 48);
            this.lblPhone.TabIndex = 11;
            this.lblPhone.Text = "Phone:";
            // 
            // nudCapacity
            // 
            this.nudCapacity.Location = new System.Drawing.Point(528, 774);
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
            this.nudCapacity.TabIndex = 9;
            this.nudCapacity.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // txtEircode
            // 
            this.txtEircode.Location = new System.Drawing.Point(528, 571);
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.Size = new System.Drawing.Size(223, 55);
            this.txtEircode.TabIndex = 7;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(528, 470);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(384, 55);
            this.txtCity.TabIndex = 5;
            // 
            // lblMaxCap
            // 
            this.lblMaxCap.AutoSize = true;
            this.lblMaxCap.Location = new System.Drawing.Point(213, 782);
            this.lblMaxCap.Name = "lblMaxCap";
            this.lblMaxCap.Size = new System.Drawing.Size(239, 48);
            this.lblMaxCap.TabIndex = 8;
            this.lblMaxCap.Text = "Max Capacity:";
            // 
            // lblEircode
            // 
            this.lblEircode.AutoSize = true;
            this.lblEircode.Location = new System.Drawing.Point(301, 579);
            this.lblEircode.Name = "lblEircode";
            this.lblEircode.Size = new System.Drawing.Size(146, 48);
            this.lblEircode.TabIndex = 6;
            this.lblEircode.Text = "Eircode:";
            // 
            // btnAddVenue
            // 
            this.btnAddVenue.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAddVenue.Location = new System.Drawing.Point(176, 1188);
            this.btnAddVenue.Name = "btnAddVenue";
            this.btnAddVenue.Size = new System.Drawing.Size(944, 67);
            this.btnAddVenue.TabIndex = 10;
            this.btnAddVenue.Text = "Add Venue";
            this.btnAddVenue.UseVisualStyleBackColor = false;
            this.btnAddVenue.Click += new System.EventHandler(this.btnAddVenue_Click);
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(528, 269);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(592, 55);
            this.txtAddress1.TabIndex = 3;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(364, 476);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(88, 48);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "City:";
            // 
            // lblStreet1
            // 
            this.lblStreet1.AutoSize = true;
            this.lblStreet1.Location = new System.Drawing.Point(165, 276);
            this.lblStreet1.Name = "lblStreet1";
            this.lblStreet1.Size = new System.Drawing.Size(287, 48);
            this.lblStreet1.TabIndex = 2;
            this.lblStreet1.Text = "Street Address 1:";
            // 
            // frmAddVenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 1393);
            this.Controls.Add(this.grpAddVenue);
            this.Controls.Add(this.mnuMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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