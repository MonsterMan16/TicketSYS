
namespace TicketSYS
{
    partial class frmVenueEventScheduleAnalysis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenueEventScheduleAnalysis));
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuItemBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpVenueDetails = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVenue = new System.Windows.Forms.TextBox();
            this.txtEircode = new System.Windows.Forms.TextBox();
            this.txtVenueID = new System.Windows.Forms.TextBox();
            this.lblVenueID = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.txtMaxCap = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblMaxCap = new System.Windows.Forms.Label();
            this.lblEircode = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.grpSearchEvent = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.cboVenue = new System.Windows.Forms.ComboBox();
            this.lblVenue = new System.Windows.Forms.Label();
            this.grpAnalysis = new System.Windows.Forms.GroupBox();
            this.picEventAnalysis = new System.Windows.Forms.PictureBox();
            this.mnuMainMenu.SuspendLayout();
            this.grpVenueDetails.SuspendLayout();
            this.grpSearchEvent.SuspendLayout();
            this.grpAnalysis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEventAnalysis)).BeginInit();
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
            this.mnuMainMenu.Size = new System.Drawing.Size(1810, 40);
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
            // grpVenueDetails
            // 
            this.grpVenueDetails.Controls.Add(this.label6);
            this.grpVenueDetails.Controls.Add(this.txtVenue);
            this.grpVenueDetails.Controls.Add(this.txtEircode);
            this.grpVenueDetails.Controls.Add(this.txtVenueID);
            this.grpVenueDetails.Controls.Add(this.lblVenueID);
            this.grpVenueDetails.Controls.Add(this.lblStreetAddress);
            this.grpVenueDetails.Controls.Add(this.txtMaxCap);
            this.grpVenueDetails.Controls.Add(this.txtCity);
            this.grpVenueDetails.Controls.Add(this.lblMaxCap);
            this.grpVenueDetails.Controls.Add(this.lblEircode);
            this.grpVenueDetails.Controls.Add(this.txtStreet);
            this.grpVenueDetails.Controls.Add(this.lblCity);
            this.grpVenueDetails.Location = new System.Drawing.Point(32, 311);
            this.grpVenueDetails.Name = "grpVenueDetails";
            this.grpVenueDetails.Size = new System.Drawing.Size(701, 375);
            this.grpVenueDetails.TabIndex = 60;
            this.grpVenueDetails.TabStop = false;
            this.grpVenueDetails.Text = "Venue Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 32);
            this.label6.TabIndex = 26;
            this.label6.Text = "Venue Name:";
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
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Location = new System.Drawing.Point(80, 165);
            this.lblStreetAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(172, 32);
            this.lblStreetAddress.TabIndex = 18;
            this.lblStreetAddress.Text = "Street Address:";
            // 
            // txtMaxCap
            // 
            this.txtMaxCap.BackColor = System.Drawing.Color.Black;
            this.txtMaxCap.ForeColor = System.Drawing.Color.White;
            this.txtMaxCap.Location = new System.Drawing.Point(293, 321);
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
            this.lblEircode.Location = new System.Drawing.Point(152, 268);
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
            // grpSearchEvent
            // 
            this.grpSearchEvent.Controls.Add(this.btnGenerate);
            this.grpSearchEvent.Controls.Add(this.cboVenue);
            this.grpSearchEvent.Controls.Add(this.lblVenue);
            this.grpSearchEvent.Location = new System.Drawing.Point(32, 71);
            this.grpSearchEvent.Name = "grpSearchEvent";
            this.grpSearchEvent.Size = new System.Drawing.Size(701, 224);
            this.grpSearchEvent.TabIndex = 59;
            this.grpSearchEvent.TabStop = false;
            this.grpSearchEvent.Text = "Filter Ticket";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnGenerate.Location = new System.Drawing.Point(152, 149);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(375, 45);
            this.btnGenerate.TabIndex = 45;
            this.btnGenerate.Text = "Generate Venue Sales Analysis";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // cboVenue
            // 
            this.cboVenue.FormattingEnabled = true;
            this.cboVenue.Items.AddRange(new object[] {
            "",
            "1  |  3Arena",
            "2  |  Aviva Stadium"});
            this.cboVenue.Location = new System.Drawing.Point(209, 74);
            this.cboVenue.Name = "cboVenue";
            this.cboVenue.Size = new System.Drawing.Size(386, 40);
            this.cboVenue.TabIndex = 44;
            this.cboVenue.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.Location = new System.Drawing.Point(91, 82);
            this.lblVenue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(86, 32);
            this.lblVenue.TabIndex = 43;
            this.lblVenue.Text = "Venue:";
            // 
            // grpAnalysis
            // 
            this.grpAnalysis.Controls.Add(this.picEventAnalysis);
            this.grpAnalysis.Location = new System.Drawing.Point(782, 71);
            this.grpAnalysis.Margin = new System.Windows.Forms.Padding(2);
            this.grpAnalysis.Name = "grpAnalysis";
            this.grpAnalysis.Padding = new System.Windows.Forms.Padding(2);
            this.grpAnalysis.Size = new System.Drawing.Size(995, 615);
            this.grpAnalysis.TabIndex = 62;
            this.grpAnalysis.TabStop = false;
            this.grpAnalysis.Text = "Venue Sales Analysis";
            this.grpAnalysis.Visible = false;
            // 
            // picEventAnalysis
            // 
            this.picEventAnalysis.Image = global::TicketSYS.Properties.Resources.Venue_Event_Analysis;
            this.picEventAnalysis.Location = new System.Drawing.Point(17, 37);
            this.picEventAnalysis.Name = "picEventAnalysis";
            this.picEventAnalysis.Size = new System.Drawing.Size(962, 563);
            this.picEventAnalysis.TabIndex = 0;
            this.picEventAnalysis.TabStop = false;
            // 
            // frmVenueEventScheduleAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1810, 710);
            this.Controls.Add(this.grpAnalysis);
            this.Controls.Add(this.grpVenueDetails);
            this.Controls.Add(this.mnuMainMenu);
            this.Controls.Add(this.grpSearchEvent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmVenueEventScheduleAnalysis";
            this.Text = "Venue Schedule Analysis";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmVenueAnalysis_FormClosed);
            this.Load += new System.EventHandler(this.frmVenueAnalysis_Load);
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.grpVenueDetails.ResumeLayout(false);
            this.grpVenueDetails.PerformLayout();
            this.grpSearchEvent.ResumeLayout(false);
            this.grpSearchEvent.PerformLayout();
            this.grpAnalysis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picEventAnalysis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuItemBack;
        private System.Windows.Forms.GroupBox grpVenueDetails;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVenue;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.TextBox txtVenueID;
        private System.Windows.Forms.Label lblVenueID;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.TextBox txtMaxCap;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblMaxCap;
        private System.Windows.Forms.Label lblEircode;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.GroupBox grpSearchEvent;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ComboBox cboVenue;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.GroupBox grpAnalysis;
        private System.Windows.Forms.PictureBox picEventAnalysis;
    }
}