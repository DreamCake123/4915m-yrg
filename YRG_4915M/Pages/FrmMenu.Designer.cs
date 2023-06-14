namespace YRG_4915M
{
    partial class FrmMenu
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
            this.dockPanelMain = new Krypton.Docking.KryptonDockableNavigator();
            this.kryptonRequestManage = new Krypton.Navigator.KryptonPage();
            this.tableLayoutPanelBase = new System.Windows.Forms.TableLayoutPanel();
            this.lblMajor = new Krypton.Toolkit.KryptonLabel();
            this.lblMinor = new Krypton.Toolkit.KryptonLabel();
            this.lblTable3 = new Krypton.Toolkit.KryptonLabel();
            this.lblTable4 = new Krypton.Toolkit.KryptonLabel();
            this.lblTable5 = new Krypton.Toolkit.KryptonLabel();
            this.lblTable6 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonItemManage = new Krypton.Navigator.KryptonPage();
            this.kryptonAgreementManage = new Krypton.Navigator.KryptonPage();
            this.kryptonDashboard = new Krypton.Navigator.KryptonPage();
            this.kryptonPage5 = new Krypton.Navigator.KryptonPage();
            ((System.ComponentModel.ISupportInitialize)(this.dockPanelMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRequestManage)).BeginInit();
            this.kryptonRequestManage.SuspendLayout();
            this.tableLayoutPanelBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonItemManage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonAgreementManage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage5)).BeginInit();
            this.SuspendLayout();
            // 
            // dockPanelMain
            // 
            this.dockPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanelMain.Location = new System.Drawing.Point(0, 0);
            this.dockPanelMain.Name = "dockPanelMain";
            this.dockPanelMain.NavigatorMode = Krypton.Navigator.NavigatorMode.OutlookFull;
            this.dockPanelMain.PageBackStyle = Krypton.Toolkit.PaletteBackStyle.FormMain;
            this.dockPanelMain.Pages.AddRange(new Krypton.Navigator.KryptonPage[] {
            this.kryptonRequestManage,
            this.kryptonItemManage,
            this.kryptonAgreementManage,
            this.kryptonDashboard,
            this.kryptonPage5});
            this.dockPanelMain.SelectedIndex = 0;
            this.dockPanelMain.Size = new System.Drawing.Size(208, 1054);
            this.dockPanelMain.TabIndex = 0;
            this.dockPanelMain.Text = "kryptonDockableNavigator1";
            // 
            // kryptonRequestManage
            // 
            this.kryptonRequestManage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonRequestManage.Controls.Add(this.tableLayoutPanelBase);
            this.kryptonRequestManage.Flags = 65534;
            this.kryptonRequestManage.ImageLarge = global::YRG_4915M.Properties.Resources.large_tiles;
            this.kryptonRequestManage.ImageMedium = global::YRG_4915M.Properties.Resources.large_tiles;
            this.kryptonRequestManage.ImageSmall = global::YRG_4915M.Properties.Resources.large_tiles;
            this.kryptonRequestManage.LastVisibleSet = true;
            this.kryptonRequestManage.MinimumSize = new System.Drawing.Size(150, 50);
            this.kryptonRequestManage.Name = "kryptonRequestManage";
            this.kryptonRequestManage.Size = new System.Drawing.Size(206, 767);
            this.kryptonRequestManage.Text = "Basic Information";
            this.kryptonRequestManage.TextDescription = "Basic Information";
            this.kryptonRequestManage.TextTitle = "Basic Information";
            this.kryptonRequestManage.ToolTipTitle = "Page ToolTip";
            this.kryptonRequestManage.UniqueName = "882fb5fd8212425d805e9b8be1b614f1";
            // 
            // tableLayoutPanelBase
            // 
            this.tableLayoutPanelBase.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tableLayoutPanelBase.ColumnCount = 3;
            this.tableLayoutPanelBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanelBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBase.Controls.Add(this.lblMajor, 1, 1);
            this.tableLayoutPanelBase.Controls.Add(this.lblMinor, 1, 2);
            this.tableLayoutPanelBase.Controls.Add(this.lblTable3, 1, 3);
            this.tableLayoutPanelBase.Controls.Add(this.lblTable4, 1, 4);
            this.tableLayoutPanelBase.Controls.Add(this.lblTable5, 1, 5);
            this.tableLayoutPanelBase.Controls.Add(this.lblTable6, 1, 6);
            this.tableLayoutPanelBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBase.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelBase.Name = "tableLayoutPanelBase";
            this.tableLayoutPanelBase.RowCount = 8;
            this.tableLayoutPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBase.Size = new System.Drawing.Size(206, 767);
            this.tableLayoutPanelBase.TabIndex = 0;
            // 
            // lblMajor
            // 
            this.lblMajor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMajor.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblMajor.Location = new System.Drawing.Point(36, 18);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new System.Drawing.Size(134, 74);
            this.lblMajor.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblMajor.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblMajor.StateCommon.LongText.Font = new System.Drawing.Font("Garamond", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMajor.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblMajor.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblMajor.TabIndex = 0;
            this.lblMajor.Values.Image = global::YRG_4915M.Properties.Resources.resource_usage;
            this.lblMajor.Values.Text = "Major";
            // 
            // lblMinor
            // 
            this.lblMinor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMinor.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblMinor.Location = new System.Drawing.Point(36, 98);
            this.lblMinor.Name = "lblMinor";
            this.lblMinor.Size = new System.Drawing.Size(134, 74);
            this.lblMinor.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblMinor.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblMinor.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblMinor.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblMinor.TabIndex = 1;
            this.lblMinor.Values.Image = global::YRG_4915M.Properties.Resources.resources;
            this.lblMinor.Values.Text = "Minor";
            // 
            // lblTable3
            // 
            this.lblTable3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTable3.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblTable3.Location = new System.Drawing.Point(36, 178);
            this.lblTable3.Name = "lblTable3";
            this.lblTable3.Size = new System.Drawing.Size(134, 74);
            this.lblTable3.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblTable3.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblTable3.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblTable3.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblTable3.TabIndex = 2;
            this.lblTable3.Values.Image = global::YRG_4915M.Properties.Resources.ceo;
            this.lblTable3.Values.Text = "Table3";
            // 
            // lblTable4
            // 
            this.lblTable4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTable4.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblTable4.Location = new System.Drawing.Point(36, 258);
            this.lblTable4.Name = "lblTable4";
            this.lblTable4.Size = new System.Drawing.Size(134, 74);
            this.lblTable4.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblTable4.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblTable4.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblTable4.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblTable4.TabIndex = 3;
            this.lblTable4.Values.Image = global::YRG_4915M.Properties.Resources.group;
            this.lblTable4.Values.Text = "Table4";
            // 
            // lblTable5
            // 
            this.lblTable5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTable5.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblTable5.Location = new System.Drawing.Point(36, 338);
            this.lblTable5.Name = "lblTable5";
            this.lblTable5.Size = new System.Drawing.Size(134, 74);
            this.lblTable5.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblTable5.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblTable5.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblTable5.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblTable5.TabIndex = 4;
            this.lblTable5.Values.Image = global::YRG_4915M.Properties.Resources.vcard;
            this.lblTable5.Values.Text = "Table5";
            // 
            // lblTable6
            // 
            this.lblTable6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTable6.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblTable6.Location = new System.Drawing.Point(36, 418);
            this.lblTable6.Name = "lblTable6";
            this.lblTable6.Size = new System.Drawing.Size(134, 74);
            this.lblTable6.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblTable6.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblTable6.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblTable6.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblTable6.TabIndex = 5;
            this.lblTable6.Values.Image = global::YRG_4915M.Properties.Resources.note;
            this.lblTable6.Values.Text = "Table6";
            // 
            // kryptonItemManage
            // 
            this.kryptonItemManage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonItemManage.Flags = 65534;
            this.kryptonItemManage.ImageLarge = global::YRG_4915M.Properties.Resources.application_from_storage;
            this.kryptonItemManage.ImageMedium = global::YRG_4915M.Properties.Resources.application_from_storage;
            this.kryptonItemManage.ImageSmall = global::YRG_4915M.Properties.Resources.application_from_storage;
            this.kryptonItemManage.LastVisibleSet = true;
            this.kryptonItemManage.MinimumSize = new System.Drawing.Size(150, 50);
            this.kryptonItemManage.Name = "kryptonItemManage";
            this.kryptonItemManage.Size = new System.Drawing.Size(366, 767);
            this.kryptonItemManage.Text = "Request";
            this.kryptonItemManage.TextDescription = "Request Management";
            this.kryptonItemManage.TextTitle = "Request";
            this.kryptonItemManage.ToolTipTitle = "Page ToolTip";
            this.kryptonItemManage.UniqueName = "7d268c94df7e43e2a2f02eec18410e0e";
            // 
            // kryptonAgreementManage
            // 
            this.kryptonAgreementManage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonAgreementManage.Flags = 65534;
            this.kryptonAgreementManage.ImageLarge = global::YRG_4915M.Properties.Resources.barcode;
            this.kryptonAgreementManage.ImageMedium = global::YRG_4915M.Properties.Resources.barcode;
            this.kryptonAgreementManage.ImageSmall = global::YRG_4915M.Properties.Resources.barcode;
            this.kryptonAgreementManage.LastVisibleSet = true;
            this.kryptonAgreementManage.MinimumSize = new System.Drawing.Size(150, 50);
            this.kryptonAgreementManage.Name = "kryptonAgreementManage";
            this.kryptonAgreementManage.Size = new System.Drawing.Size(366, 767);
            this.kryptonAgreementManage.Text = "Item";
            this.kryptonAgreementManage.TextDescription = "Item Management";
            this.kryptonAgreementManage.TextTitle = "Item";
            this.kryptonAgreementManage.ToolTipTitle = "Page ToolTip";
            this.kryptonAgreementManage.UniqueName = "2268293a882447c7b7ea61f7b2d6af31";
            // 
            // kryptonDashboard
            // 
            this.kryptonDashboard.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonDashboard.Flags = 65534;
            this.kryptonDashboard.ImageLarge = global::YRG_4915M.Properties.Resources.small_business;
            this.kryptonDashboard.ImageMedium = global::YRG_4915M.Properties.Resources.small_business;
            this.kryptonDashboard.ImageSmall = global::YRG_4915M.Properties.Resources.small_business;
            this.kryptonDashboard.LastVisibleSet = true;
            this.kryptonDashboard.MinimumSize = new System.Drawing.Size(150, 50);
            this.kryptonDashboard.Name = "kryptonDashboard";
            this.kryptonDashboard.Size = new System.Drawing.Size(366, 767);
            this.kryptonDashboard.Text = "Agreement";
            this.kryptonDashboard.TextDescription = "Agreement Management";
            this.kryptonDashboard.TextTitle = "Agreement";
            this.kryptonDashboard.ToolTipTitle = "Page ToolTip";
            this.kryptonDashboard.UniqueName = "68ea8ebcc96945bf9f64ccf535baad96";
            // 
            // kryptonPage5
            // 
            this.kryptonPage5.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage5.Flags = 65534;
            this.kryptonPage5.ImageLarge = global::YRG_4915M.Properties.Resources.report;
            this.kryptonPage5.ImageMedium = global::YRG_4915M.Properties.Resources.report;
            this.kryptonPage5.ImageSmall = global::YRG_4915M.Properties.Resources.report;
            this.kryptonPage5.LastVisibleSet = true;
            this.kryptonPage5.MinimumSize = new System.Drawing.Size(150, 50);
            this.kryptonPage5.Name = "kryptonPage5";
            this.kryptonPage5.Size = new System.Drawing.Size(326, 767);
            this.kryptonPage5.Text = "Report";
            this.kryptonPage5.TextDescription = "Report";
            this.kryptonPage5.TextTitle = "Report";
            this.kryptonPage5.ToolTipTitle = "Page ToolTip";
            this.kryptonPage5.UniqueName = "3597eaedf40045279c7a954b98724108";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(208, 1054);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.dockPanelMain);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)(((((WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockTop) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockBottom) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.Document)));
            this.Name = "FrmMenu";
            this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.DockLeft;
            this.Text = "User Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dockPanelMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRequestManage)).EndInit();
            this.kryptonRequestManage.ResumeLayout(false);
            this.tableLayoutPanelBase.ResumeLayout(false);
            this.tableLayoutPanelBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonItemManage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonAgreementManage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Docking.KryptonDockableNavigator dockPanelMain;
        private Krypton.Navigator.KryptonPage kryptonRequestManage;
        private Krypton.Navigator.KryptonPage kryptonItemManage;
        private Krypton.Navigator.KryptonPage kryptonAgreementManage;
        private Krypton.Navigator.KryptonPage kryptonDashboard;
        private Krypton.Navigator.KryptonPage kryptonPage5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBase;
        private Krypton.Toolkit.KryptonLabel lblMajor;
        private Krypton.Toolkit.KryptonLabel lblMinor;
        private Krypton.Toolkit.KryptonLabel lblTable3;
        private Krypton.Toolkit.KryptonLabel lblTable4;
        private Krypton.Toolkit.KryptonLabel lblTable5;
        private Krypton.Toolkit.KryptonLabel lblTable6;
    }
}