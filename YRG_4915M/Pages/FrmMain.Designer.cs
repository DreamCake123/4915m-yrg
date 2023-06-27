namespace YRG_4915M
{
    partial class FrmMain
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
            this.dockPanelMain = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.vS2015BlueTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2015BlueTheme();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsLblUserID = new System.Windows.Forms.ToolStripLabel();
            this.tsDropDownBtnAccount = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsLblVersion = new System.Windows.Forms.ToolStripLabel();
            this.tsSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsLblDate = new System.Windows.Forms.ToolStripLabel();
            this.tsSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockPanelMain
            // 
            this.dockPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanelMain.DockBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.dockPanelMain.DocumentStyle = WeifenLuo.WinFormsUI.Docking.DocumentStyle.DockingMdi;
            this.dockPanelMain.Location = new System.Drawing.Point(0, 0);
            this.dockPanelMain.Name = "dockPanelMain";
            this.dockPanelMain.Padding = new System.Windows.Forms.Padding(6);
            this.dockPanelMain.ShowAutoHideContentOnHover = false;
            this.dockPanelMain.Size = new System.Drawing.Size(1898, 1370);
            this.dockPanelMain.TabIndex = 1;
            this.dockPanelMain.Theme = this.vS2015BlueTheme1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(1);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLblUserID,
            this.tsDropDownBtnAccount,
            this.tsSeparator1,
            this.tsLblVersion,
            this.tsSeparator2,
            this.tsLblDate,
            this.tsSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 1332);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStrip1.Size = new System.Drawing.Size(1898, 38);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsLblUserID
            // 
            this.tsLblUserID.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsLblUserID.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tsLblUserID.Image = global::YRG_4915M.Properties.Resources.user_orange;
            this.tsLblUserID.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.tsLblUserID.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsLblUserID.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.tsLblUserID.Name = "tsLblUserID";
            this.tsLblUserID.Size = new System.Drawing.Size(104, 27);
            this.tsLblUserID.Text = "User: ???";
            this.tsLblUserID.ToolTipText = "User ID";
            this.tsLblUserID.VisitedLinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            // 
            // tsDropDownBtnAccount
            // 
            this.tsDropDownBtnAccount.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tsDropDownBtnAccount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDropDownBtnAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAccount,
            this.toolStripMenuItemLogout});
            this.tsDropDownBtnAccount.Image = global::YRG_4915M.Properties.Resources.cog1;
            this.tsDropDownBtnAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDropDownBtnAccount.Name = "tsDropDownBtnAccount";
            this.tsDropDownBtnAccount.Size = new System.Drawing.Size(42, 28);
            this.tsDropDownBtnAccount.ToolTipText = "Logout / Account Settings";
            // 
            // toolStripMenuItemAccount
            // 
            this.toolStripMenuItemAccount.Name = "toolStripMenuItemAccount";
            this.toolStripMenuItemAccount.Size = new System.Drawing.Size(270, 34);
            this.toolStripMenuItemAccount.Text = "View Account";
            this.toolStripMenuItemAccount.Click += new System.EventHandler(this.toolStripMenuItemAccount_Click);
            // 
            // toolStripMenuItemLogout
            // 
            this.toolStripMenuItemLogout.Name = "toolStripMenuItemLogout";
            this.toolStripMenuItemLogout.Size = new System.Drawing.Size(270, 34);
            this.toolStripMenuItemLogout.Text = "Logout";
            this.toolStripMenuItemLogout.Click += new System.EventHandler(this.toolStripMenuItemLogout_Click);
            // 
            // tsSeparator1
            // 
            this.tsSeparator1.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.tsSeparator1.Name = "tsSeparator1";
            this.tsSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // tsLblVersion
            // 
            this.tsLblVersion.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsLblVersion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsLblVersion.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.tsLblVersion.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsLblVersion.Margin = new System.Windows.Forms.Padding(0, 2, 8, 3);
            this.tsLblVersion.Name = "tsLblVersion";
            this.tsLblVersion.Size = new System.Drawing.Size(167, 28);
            this.tsLblVersion.Text = "Version: 2023.07.01";
            this.tsLblVersion.ToolTipText = "System Version";
            this.tsLblVersion.VisitedLinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            // 
            // tsSeparator2
            // 
            this.tsSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsSeparator2.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.tsSeparator2.Name = "tsSeparator2";
            this.tsSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // tsLblDate
            // 
            this.tsLblDate.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsLblDate.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsLblDate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tsLblDate.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.tsLblDate.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsLblDate.Name = "tsLblDate";
            this.tsLblDate.Size = new System.Drawing.Size(199, 28);
            this.tsLblDate.Text = "Current Date: ????-??-??";
            this.tsLblDate.ToolTipText = "Current Date";
            this.tsLblDate.VisitedLinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            // 
            // tsSeparator3
            // 
            this.tsSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsSeparator3.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.tsSeparator3.Name = "tsSeparator3";
            this.tsSeparator3.Size = new System.Drawing.Size(6, 33);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1370);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dockPanelMain);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Text = "Yummy Restaurant Group Centralized Procurement System (YRGCPS)";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private WeifenLuo.WinFormsUI.Docking.VS2015BlueTheme vS2015BlueTheme1;
        public WeifenLuo.WinFormsUI.Docking.DockPanel dockPanelMain;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tsLblUserID;
        private System.Windows.Forms.ToolStripDropDownButton tsDropDownBtnAccount;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAccount;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLogout;
        private System.Windows.Forms.ToolStripSeparator tsSeparator1;
        private System.Windows.Forms.ToolStripLabel tsLblDate;
        private System.Windows.Forms.ToolStripSeparator tsSeparator2;
        private System.Windows.Forms.ToolStripLabel tsLblVersion;
        private System.Windows.Forms.ToolStripSeparator tsSeparator3;
    }
}