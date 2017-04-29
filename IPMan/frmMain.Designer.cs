namespace IPMan
{
    partial class frmMain
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cbAdapter = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbGateway = new System.Windows.Forms.Label();
            this.lbMask = new System.Windows.Forms.Label();
            this.lbIP = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnToggle = new System.Windows.Forms.Button();
            this.btnDHCP = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txGateway = new System.Windows.Forms.TextBox();
            this.txMask = new System.Windows.Forms.TextBox();
            this.txIP = new System.Windows.Forms.TextBox();
            this.nIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tmRefresh = new System.Windows.Forms.Timer(this.components);
            this.lnkDonate = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.cMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(304, 193);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(61, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "&Apply";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(235, 193);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(61, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "&Hide";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.cbAdapter);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Network adapter";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(269, 21);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cbAdapter
            // 
            this.cbAdapter.DisplayMember = "Caption";
            this.cbAdapter.FormattingEnabled = true;
            this.cbAdapter.Location = new System.Drawing.Point(18, 22);
            this.cbAdapter.Name = "cbAdapter";
            this.cbAdapter.Size = new System.Drawing.Size(245, 21);
            this.cbAdapter.TabIndex = 0;
            this.cbAdapter.SelectedIndexChanged += new System.EventHandler(this.cbAdapter_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbGateway);
            this.groupBox2.Controls.Add(this.lbMask);
            this.groupBox2.Controls.Add(this.lbIP);
            this.groupBox2.Location = new System.Drawing.Point(235, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 112);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current settings";
            // 
            // lbGateway
            // 
            this.lbGateway.Location = new System.Drawing.Point(15, 77);
            this.lbGateway.Name = "lbGateway";
            this.lbGateway.Size = new System.Drawing.Size(99, 18);
            this.lbGateway.TabIndex = 14;
            this.lbGateway.Text = "N/A";
            this.lbGateway.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMask
            // 
            this.lbMask.Location = new System.Drawing.Point(15, 51);
            this.lbMask.Name = "lbMask";
            this.lbMask.Size = new System.Drawing.Size(99, 18);
            this.lbMask.TabIndex = 13;
            this.lbMask.Text = "N/A";
            this.lbMask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbIP
            // 
            this.lbIP.Location = new System.Drawing.Point(15, 25);
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(99, 18);
            this.lbIP.TabIndex = 12;
            this.lbIP.Text = "N/A";
            this.lbIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnToggle);
            this.groupBox3.Controls.Add(this.btnDHCP);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txGateway);
            this.groupBox3.Controls.Add(this.txMask);
            this.groupBox3.Controls.Add(this.txIP);
            this.groupBox3.Location = new System.Drawing.Point(12, 75);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 141);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "New settings";
            // 
            // btnToggle
            // 
            this.btnToggle.Location = new System.Drawing.Point(123, 103);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(73, 23);
            this.btnToggle.TabIndex = 15;
            this.btnToggle.Text = "&Enable";
            this.btnToggle.UseVisualStyleBackColor = true;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // btnDHCP
            // 
            this.btnDHCP.Location = new System.Drawing.Point(18, 103);
            this.btnDHCP.Name = "btnDHCP";
            this.btnDHCP.Size = new System.Drawing.Size(99, 23);
            this.btnDHCP.TabIndex = 3;
            this.btnDHCP.Text = "Reset to &DHCP";
            this.btnDHCP.UseVisualStyleBackColor = true;
            this.btnDHCP.Click += new System.EventHandler(this.btnDHCP_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(25, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Gateway:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(25, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Netmask:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "IP Address:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txGateway
            // 
            this.txGateway.Location = new System.Drawing.Point(96, 77);
            this.txGateway.Name = "txGateway";
            this.txGateway.Size = new System.Drawing.Size(100, 20);
            this.txGateway.TabIndex = 2;
            // 
            // txMask
            // 
            this.txMask.Location = new System.Drawing.Point(96, 51);
            this.txMask.Name = "txMask";
            this.txMask.Size = new System.Drawing.Size(100, 20);
            this.txMask.TabIndex = 1;
            this.txMask.Text = "255.255.255.0";
            // 
            // txIP
            // 
            this.txIP.Location = new System.Drawing.Point(96, 25);
            this.txIP.Name = "txIP";
            this.txIP.Size = new System.Drawing.Size(100, 20);
            this.txIP.TabIndex = 0;
            // 
            // nIcon
            // 
            this.nIcon.ContextMenuStrip = this.cMenu;
            this.nIcon.Text = "IPMan";
            this.nIcon.Visible = true;
            this.nIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.nIcon_MouseDoubleClick);
            // 
            // cMenu
            // 
            this.cMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.cMenu.Name = "cMenu";
            this.cMenu.Size = new System.Drawing.Size(134, 70);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItem1.Text = "Show/Hide";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItem2.Text = "About";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItem3.Text = "Exit";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // tmRefresh
            // 
            this.tmRefresh.Enabled = true;
            this.tmRefresh.Interval = 500;
            this.tmRefresh.Tick += new System.EventHandler(this.tmRefresh_Tick);
            // 
            // lnkDonate
            // 
            this.lnkDonate.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.lnkDonate.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkDonate.Location = new System.Drawing.Point(6, 220);
            this.lnkDonate.Name = "lnkDonate";
            this.lnkDonate.Size = new System.Drawing.Size(365, 48);
            this.lnkDonate.TabIndex = 16;
            this.lnkDonate.TabStop = true;
            this.lnkDonate.Text = "Do you like this app? Support me! Consider donating so I can keep making free, gr" +
    "eat, ad-free apps like this one :). I hate ads, and so do you!\r\n\r\nClick here!";
            this.lnkDonate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkDonate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDonate_LinkClicked);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(378, 273);
            this.Controls.Add(this.lnkDonate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IPMan 20170429.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.cMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbGateway;
        private System.Windows.Forms.Label lbMask;
        private System.Windows.Forms.Label lbIP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txGateway;
        private System.Windows.Forms.TextBox txMask;
        private System.Windows.Forms.TextBox txIP;
        private System.Windows.Forms.NotifyIcon nIcon;
        private System.Windows.Forms.ContextMenuStrip cMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Timer tmRefresh;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDHCP;
        private System.Windows.Forms.LinkLabel lnkDonate;
        private System.Windows.Forms.Button btnToggle;
    }
}

