<<<<<<< HEAD
﻿namespace YRG_4915M
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
            this.pageBasicInfo = new Krypton.Navigator.KryptonPage();
            this.tableLayoutPanelBase = new System.Windows.Forms.TableLayoutPanel();
            this.lblBasicInfoStaff = new Krypton.Toolkit.KryptonLabel();
            this.lblBasicInfoSupplier = new Krypton.Toolkit.KryptonLabel();
            this.lblBasicInfoRestaurant = new Krypton.Toolkit.KryptonLabel();
            this.lblBasicInfoWarehouse = new Krypton.Toolkit.KryptonLabel();
            this.lblBasicInfoTable5 = new Krypton.Toolkit.KryptonLabel();
            this.pageItem = new Krypton.Navigator.KryptonPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblItemMajor = new Krypton.Toolkit.KryptonLabel();
            this.lblItems = new Krypton.Toolkit.KryptonLabel();
            this.pageStockCount = new Krypton.Navigator.KryptonPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lblWarehouseStockCount = new Krypton.Toolkit.KryptonLabel();
            this.lblRestaurantStockCount = new Krypton.Toolkit.KryptonLabel();
            this.pageRequest = new Krypton.Navigator.KryptonPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRequestRM = new Krypton.Toolkit.KryptonLabel();
            this.lblRequestPM = new Krypton.Toolkit.KryptonLabel();
            this.pageAgreement = new Krypton.Navigator.KryptonPage();
            this.tlpAgree = new System.Windows.Forms.TableLayoutPanel();
            this.lblAgreementView = new Krypton.Toolkit.KryptonLabel();
            this.lblAgreementBPA = new Krypton.Toolkit.KryptonLabel();
            this.lblAgreementCPA = new Krypton.Toolkit.KryptonLabel();
            this.pageOrder = new Krypton.Navigator.KryptonPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.lblOrderAccounting = new Krypton.Toolkit.KryptonLabel();
            this.pageReport = new Krypton.Navigator.KryptonPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblReportMajor = new Krypton.Toolkit.KryptonLabel();
            this.lblReportMinor = new Krypton.Toolkit.KryptonLabel();
            this.lblReportTable3 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dockPanelMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBasicInfo)).BeginInit();
            this.pageBasicInfo.SuspendLayout();
            this.tableLayoutPanelBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageItem)).BeginInit();
            this.pageItem.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageStockCount)).BeginInit();
            this.pageStockCount.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageRequest)).BeginInit();
            this.pageRequest.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageAgreement)).BeginInit();
            this.pageAgreement.SuspendLayout();
            this.tlpAgree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageOrder)).BeginInit();
            this.pageOrder.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageReport)).BeginInit();
            this.pageReport.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockPanelMain
            // 
            this.dockPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanelMain.Location = new System.Drawing.Point(0, 0);
            this.dockPanelMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dockPanelMain.Name = "dockPanelMain";
            this.dockPanelMain.NavigatorMode = Krypton.Navigator.NavigatorMode.OutlookFull;
            this.dockPanelMain.PageBackStyle = Krypton.Toolkit.PaletteBackStyle.FormMain;
            this.dockPanelMain.Pages.AddRange(new Krypton.Navigator.KryptonPage[] {
            this.pageBasicInfo,
            this.pageItem,
            this.pageStockCount,
            this.pageRequest,
            this.pageAgreement,
            this.pageOrder,
            this.pageReport});
            this.dockPanelMain.SelectedIndex = 0;
            this.dockPanelMain.Size = new System.Drawing.Size(228, 1055);
            this.dockPanelMain.TabIndex = 0;
            this.dockPanelMain.Text = "kryptonDockableNavigator1";
            // 
            // pageBasicInfo
            // 
            this.pageBasicInfo.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageBasicInfo.Controls.Add(this.tableLayoutPanelBase);
            this.pageBasicInfo.Flags = 65534;
            this.pageBasicInfo.ImageLarge = global::YRG_4915M.Properties.Resources.large_tiles;
            this.pageBasicInfo.ImageMedium = global::YRG_4915M.Properties.Resources.large_tiles;
            this.pageBasicInfo.ImageSmall = global::YRG_4915M.Properties.Resources.large_tiles;
            this.pageBasicInfo.LastVisibleSet = true;
            this.pageBasicInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pageBasicInfo.MinimumSize = new System.Drawing.Size(150, 50);
            this.pageBasicInfo.Name = "pageBasicInfo";
            this.pageBasicInfo.Size = new System.Drawing.Size(226, 690);
            this.pageBasicInfo.Text = "Basic Info";
            this.pageBasicInfo.TextDescription = "Basic Information";
            this.pageBasicInfo.TextTitle = "Basic Info";
            this.pageBasicInfo.ToolTipTitle = "Page ToolTip";
            this.pageBasicInfo.UniqueName = "882fb5fd8212425d805e9b8be1b614f1";
            // 
            // tableLayoutPanelBase
            // 
            this.tableLayoutPanelBase.AutoScroll = true;
            this.tableLayoutPanelBase.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tableLayoutPanelBase.ColumnCount = 3;
            this.tableLayoutPanelBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBase.Controls.Add(this.lblBasicInfoStaff, 1, 1);
            this.tableLayoutPanelBase.Controls.Add(this.lblBasicInfoSupplier, 1, 2);
            this.tableLayoutPanelBase.Controls.Add(this.lblBasicInfoRestaurant, 1, 3);
            this.tableLayoutPanelBase.Controls.Add(this.lblBasicInfoWarehouse, 1, 4);
            this.tableLayoutPanelBase.Controls.Add(this.lblBasicInfoTable5, 1, 5);
            this.tableLayoutPanelBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBase.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelBase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.tableLayoutPanelBase.Size = new System.Drawing.Size(226, 690);
            this.tableLayoutPanelBase.TabIndex = 0;
            // 
            // lblBasicInfoStaff
            // 
            this.lblBasicInfoStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBasicInfoStaff.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblBasicInfoStaff.Location = new System.Drawing.Point(58, 17);
            this.lblBasicInfoStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblBasicInfoStaff.Name = "lblBasicInfoStaff";
            this.lblBasicInfoStaff.Size = new System.Drawing.Size(110, 76);
            this.lblBasicInfoStaff.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblBasicInfoStaff.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblBasicInfoStaff.StateCommon.LongText.Font = new System.Drawing.Font("Garamond", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasicInfoStaff.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblBasicInfoStaff.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblBasicInfoStaff.TabIndex = 0;
            this.lblBasicInfoStaff.Values.Image = global::YRG_4915M.Properties.Resources.group;
            this.lblBasicInfoStaff.Values.Text = "Staff";
            this.lblBasicInfoStaff.Click += new System.EventHandler(this.lblBasicInfoStaff_Click);
            // 
            // lblBasicInfoSupplier
            // 
            this.lblBasicInfoSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBasicInfoSupplier.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblBasicInfoSupplier.Location = new System.Drawing.Point(58, 97);
            this.lblBasicInfoSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblBasicInfoSupplier.Name = "lblBasicInfoSupplier";
            this.lblBasicInfoSupplier.Size = new System.Drawing.Size(110, 76);
            this.lblBasicInfoSupplier.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblBasicInfoSupplier.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblBasicInfoSupplier.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblBasicInfoSupplier.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblBasicInfoSupplier.TabIndex = 1;
            this.lblBasicInfoSupplier.Values.Image = global::YRG_4915M.Properties.Resources.ceo;
            this.lblBasicInfoSupplier.Values.Text = "Supplier";
            this.lblBasicInfoSupplier.Click += new System.EventHandler(this.lblBasicInfoSupplier_Click);
            // 
            // lblBasicInfoRestaurant
            // 
            this.lblBasicInfoRestaurant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBasicInfoRestaurant.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblBasicInfoRestaurant.Location = new System.Drawing.Point(58, 177);
            this.lblBasicInfoRestaurant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblBasicInfoRestaurant.Name = "lblBasicInfoRestaurant";
            this.lblBasicInfoRestaurant.Size = new System.Drawing.Size(110, 76);
            this.lblBasicInfoRestaurant.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblBasicInfoRestaurant.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblBasicInfoRestaurant.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblBasicInfoRestaurant.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblBasicInfoRestaurant.TabIndex = 2;
            this.lblBasicInfoRestaurant.Values.Image = global::YRG_4915M.Properties.Resources.chart_organisation;
            this.lblBasicInfoRestaurant.Values.Text = "Restaurant";
            this.lblBasicInfoRestaurant.Click += new System.EventHandler(this.lblBasicInfoRestaurant_Click);
            // 
            // lblBasicInfoWarehouse
            // 
            this.lblBasicInfoWarehouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBasicInfoWarehouse.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblBasicInfoWarehouse.Location = new System.Drawing.Point(58, 257);
            this.lblBasicInfoWarehouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblBasicInfoWarehouse.Name = "lblBasicInfoWarehouse";
            this.lblBasicInfoWarehouse.Size = new System.Drawing.Size(110, 76);
            this.lblBasicInfoWarehouse.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblBasicInfoWarehouse.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblBasicInfoWarehouse.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblBasicInfoWarehouse.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblBasicInfoWarehouse.TabIndex = 3;
            this.lblBasicInfoWarehouse.Values.Image = global::YRG_4915M.Properties.Resources.building;
            this.lblBasicInfoWarehouse.Values.Text = "Warehouse";
            this.lblBasicInfoWarehouse.Click += new System.EventHandler(this.lblBasicInfoWarehouse_Click);
            // 
            // lblBasicInfoTable5
            // 
            this.lblBasicInfoTable5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBasicInfoTable5.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblBasicInfoTable5.Location = new System.Drawing.Point(58, 337);
            this.lblBasicInfoTable5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblBasicInfoTable5.Name = "lblBasicInfoTable5";
            this.lblBasicInfoTable5.Size = new System.Drawing.Size(110, 76);
            this.lblBasicInfoTable5.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblBasicInfoTable5.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblBasicInfoTable5.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblBasicInfoTable5.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblBasicInfoTable5.TabIndex = 4;
            this.lblBasicInfoTable5.Values.Image = global::YRG_4915M.Properties.Resources.vcard;
            this.lblBasicInfoTable5.Values.Text = "Table5";
            this.lblBasicInfoTable5.Click += new System.EventHandler(this.lblBasicInfoYourAccount_Click);
            // 
            // pageItem
            // 
            this.pageItem.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageItem.Controls.Add(this.tableLayoutPanel2);
            this.pageItem.Flags = 65534;
            this.pageItem.ImageLarge = global::YRG_4915M.Properties.Resources.barcode;
            this.pageItem.ImageMedium = global::YRG_4915M.Properties.Resources.barcode;
            this.pageItem.ImageSmall = global::YRG_4915M.Properties.Resources.barcode;
            this.pageItem.LastVisibleSet = true;
            this.pageItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pageItem.MinimumSize = new System.Drawing.Size(150, 50);
            this.pageItem.Name = "pageItem";
            this.pageItem.Size = new System.Drawing.Size(226, 570);
            this.pageItem.Text = "Item";
            this.pageItem.TextDescription = "Item Management";
            this.pageItem.TextTitle = "Item";
            this.pageItem.ToolTipTitle = "Page ToolTip";
            this.pageItem.UniqueName = "2268293a882447c7b7ea61f7b2d6af31";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblItemMajor, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblItems, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(226, 570);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lblItemMajor
            // 
            this.lblItemMajor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblItemMajor.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblItemMajor.Location = new System.Drawing.Point(81, 17);
            this.lblItemMajor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblItemMajor.Name = "lblItemMajor";
            this.lblItemMajor.Size = new System.Drawing.Size(64, 76);
            this.lblItemMajor.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblItemMajor.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblItemMajor.StateCommon.LongText.Font = new System.Drawing.Font("Garamond", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemMajor.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblItemMajor.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblItemMajor.TabIndex = 0;
            this.lblItemMajor.Values.Image = global::YRG_4915M.Properties.Resources.resource_usage;
            this.lblItemMajor.Values.Text = "Major";
            this.lblItemMajor.Click += new System.EventHandler(this.lblItemMajor_Click);
            // 
            // lblItems
            // 
            this.lblItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblItems.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblItems.Location = new System.Drawing.Point(81, 97);
            this.lblItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(64, 76);
            this.lblItems.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblItems.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblItems.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblItems.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblItems.TabIndex = 1;
            this.lblItems.Values.Image = global::YRG_4915M.Properties.Resources.resources;
            this.lblItems.Values.Text = "Items";
            this.lblItems.Click += new System.EventHandler(this.lblItemItems_Click);
            // 
            // pageStockCount
            // 
            this.pageStockCount.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageStockCount.AutoScroll = true;
            this.pageStockCount.Controls.Add(this.tableLayoutPanel5);
            this.pageStockCount.Flags = 65534;
            this.pageStockCount.ImageLarge = global::YRG_4915M.Properties.Resources.resource_usage;
            this.pageStockCount.ImageMedium = global::YRG_4915M.Properties.Resources.resource_usage;
            this.pageStockCount.ImageSmall = global::YRG_4915M.Properties.Resources.resource_usage;
            this.pageStockCount.LastVisibleSet = true;
            this.pageStockCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pageStockCount.MinimumSize = new System.Drawing.Size(150, 50);
            this.pageStockCount.Name = "pageStockCount";
            this.pageStockCount.Size = new System.Drawing.Size(226, 690);
            this.pageStockCount.Text = "Stock Count";
            this.pageStockCount.TextDescription = "Stock Count";
            this.pageStockCount.TextTitle = "Stock Count";
            this.pageStockCount.ToolTipTitle = "Page ToolTip";
            this.pageStockCount.UniqueName = "88e71506f0c943209dff740dc3df9fc9";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoScroll = true;
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.lblWarehouseStockCount, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblRestaurantStockCount, 1, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 8;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(226, 690);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // lblWarehouseStockCount
            // 
            this.lblWarehouseStockCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWarehouseStockCount.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblWarehouseStockCount.Location = new System.Drawing.Point(58, 17);
            this.lblWarehouseStockCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblWarehouseStockCount.Name = "lblWarehouseStockCount";
            this.lblWarehouseStockCount.Size = new System.Drawing.Size(110, 76);
            this.lblWarehouseStockCount.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblWarehouseStockCount.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblWarehouseStockCount.StateCommon.LongText.Font = new System.Drawing.Font("Garamond", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarehouseStockCount.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblWarehouseStockCount.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblWarehouseStockCount.TabIndex = 0;
            this.lblWarehouseStockCount.Values.Image = global::YRG_4915M.Properties.Resources.building;
            this.lblWarehouseStockCount.Values.Text = "Warehouse";
            this.lblWarehouseStockCount.Click += new System.EventHandler(this.lblWarehouseStockCount_Click);
            // 
            // lblRestaurantStockCount
            // 
            this.lblRestaurantStockCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRestaurantStockCount.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblRestaurantStockCount.Location = new System.Drawing.Point(58, 97);
            this.lblRestaurantStockCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblRestaurantStockCount.Name = "lblRestaurantStockCount";
            this.lblRestaurantStockCount.Size = new System.Drawing.Size(110, 76);
            this.lblRestaurantStockCount.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblRestaurantStockCount.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblRestaurantStockCount.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblRestaurantStockCount.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblRestaurantStockCount.TabIndex = 1;
            this.lblRestaurantStockCount.Values.Image = global::YRG_4915M.Properties.Resources.chart_organisation;
            this.lblRestaurantStockCount.Values.Text = "Restaurant";
            this.lblRestaurantStockCount.Click += new System.EventHandler(this.lblRestaurantStockCount_Click);
            // 
            // pageRequest
            // 
            this.pageRequest.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageRequest.Controls.Add(this.tableLayoutPanel1);
            this.pageRequest.Flags = 65534;
            this.pageRequest.ImageLarge = global::YRG_4915M.Properties.Resources.application_from_storage;
            this.pageRequest.ImageMedium = global::YRG_4915M.Properties.Resources.application_from_storage;
            this.pageRequest.ImageSmall = global::YRG_4915M.Properties.Resources.application_from_storage;
            this.pageRequest.LastVisibleSet = true;
            this.pageRequest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pageRequest.MinimumSize = new System.Drawing.Size(150, 50);
            this.pageRequest.Name = "pageRequest";
            this.pageRequest.Size = new System.Drawing.Size(226, 690);
            this.pageRequest.Text = "Request";
            this.pageRequest.TextDescription = "Request Management";
            this.pageRequest.TextTitle = "Request";
            this.pageRequest.ToolTipTitle = "Page ToolTip";
            this.pageRequest.UniqueName = "7d268c94df7e43e2a2f02eec18410e0e";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblRequestRM, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblRequestPM, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(226, 690);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblRequestRM
            // 
            this.lblRequestRM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRequestRM.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblRequestRM.Location = new System.Drawing.Point(18, 17);
            this.lblRequestRM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblRequestRM.Name = "lblRequestRM";
            this.lblRequestRM.Size = new System.Drawing.Size(190, 76);
            this.lblRequestRM.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblRequestRM.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblRequestRM.StateCommon.LongText.Font = new System.Drawing.Font("Garamond", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestRM.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblRequestRM.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblRequestRM.TabIndex = 0;
            this.lblRequestRM.Values.Image = global::YRG_4915M.Properties.Resources.resource_usage;
            this.lblRequestRM.Values.Text = "Restaurant Manager";
            this.lblRequestRM.Click += new System.EventHandler(this.lblRequestRM_Click);
            // 
            // lblRequestPM
            // 
            this.lblRequestPM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRequestPM.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblRequestPM.Location = new System.Drawing.Point(18, 97);
            this.lblRequestPM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblRequestPM.Name = "lblRequestPM";
            this.lblRequestPM.Size = new System.Drawing.Size(190, 76);
            this.lblRequestPM.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblRequestPM.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblRequestPM.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblRequestPM.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblRequestPM.TabIndex = 1;
            this.lblRequestPM.Values.Image = global::YRG_4915M.Properties.Resources.resources;
            this.lblRequestPM.Values.Text = "Purchase Manager";
            this.lblRequestPM.Click += new System.EventHandler(this.lblRequestPM_Click);
            // 
            // pageAgreement
            // 
            this.pageAgreement.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageAgreement.Controls.Add(this.tlpAgree);
            this.pageAgreement.Flags = 65534;
            this.pageAgreement.ImageLarge = global::YRG_4915M.Properties.Resources.small_business;
            this.pageAgreement.ImageMedium = global::YRG_4915M.Properties.Resources.small_business;
            this.pageAgreement.ImageSmall = global::YRG_4915M.Properties.Resources.small_business;
            this.pageAgreement.LastVisibleSet = true;
            this.pageAgreement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pageAgreement.MinimumSize = new System.Drawing.Size(150, 50);
            this.pageAgreement.Name = "pageAgreement";
            this.pageAgreement.Size = new System.Drawing.Size(226, 690);
            this.pageAgreement.Text = "Agreement";
            this.pageAgreement.TextDescription = "Agreement Management";
            this.pageAgreement.TextTitle = "Agreement";
            this.pageAgreement.ToolTipTitle = "Page ToolTip";
            this.pageAgreement.UniqueName = "68ea8ebcc96945bf9f64ccf535baad96";
            // 
            // tlpAgree
            // 
            this.tlpAgree.AutoScroll = true;
            this.tlpAgree.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tlpAgree.ColumnCount = 3;
            this.tlpAgree.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAgree.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpAgree.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAgree.Controls.Add(this.lblAgreementView, 1, 1);
            this.tlpAgree.Controls.Add(this.lblAgreementBPA, 1, 2);
            this.tlpAgree.Controls.Add(this.lblAgreementCPA, 1, 3);
            this.tlpAgree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAgree.Location = new System.Drawing.Point(0, 0);
            this.tlpAgree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpAgree.Name = "tlpAgree";
            this.tlpAgree.RowCount = 8;
            this.tlpAgree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpAgree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpAgree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpAgree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpAgree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpAgree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpAgree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpAgree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAgree.Size = new System.Drawing.Size(226, 690);
            this.tlpAgree.TabIndex = 1;
            // 
            // lblAgreementView
            // 
            this.lblAgreementView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAgreementView.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblAgreementView.Location = new System.Drawing.Point(54, 17);
            this.lblAgreementView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblAgreementView.Name = "lblAgreementView";
            this.lblAgreementView.Size = new System.Drawing.Size(117, 76);
            this.lblAgreementView.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblAgreementView.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblAgreementView.StateCommon.LongText.Font = new System.Drawing.Font("Garamond", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgreementView.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblAgreementView.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblAgreementView.TabIndex = 0;
            this.lblAgreementView.Values.Image = global::YRG_4915M.Properties.Resources.application_form_magnify;
            this.lblAgreementView.Values.Text = "View All";
            this.lblAgreementView.Click += new System.EventHandler(this.lblAgreementView_Click);
            // 
            // lblAgreementBPA
            // 
            this.lblAgreementBPA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAgreementBPA.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblAgreementBPA.Location = new System.Drawing.Point(54, 97);
            this.lblAgreementBPA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblAgreementBPA.Name = "lblAgreementBPA";
            this.lblAgreementBPA.Size = new System.Drawing.Size(117, 76);
            this.lblAgreementBPA.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblAgreementBPA.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblAgreementBPA.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblAgreementBPA.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblAgreementBPA.TabIndex = 1;
            this.lblAgreementBPA.Values.Image = global::YRG_4915M.Properties.Resources.application_view_list;
            this.lblAgreementBPA.Values.Text = "Blanket PA";
            this.lblAgreementBPA.Click += new System.EventHandler(this.lblAgreementBPA_Click);
            // 
            // lblAgreementCPA
            // 
            this.lblAgreementCPA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAgreementCPA.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblAgreementCPA.Location = new System.Drawing.Point(54, 177);
            this.lblAgreementCPA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblAgreementCPA.Name = "lblAgreementCPA";
            this.lblAgreementCPA.Size = new System.Drawing.Size(117, 76);
            this.lblAgreementCPA.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblAgreementCPA.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblAgreementCPA.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblAgreementCPA.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblAgreementCPA.TabIndex = 2;
            this.lblAgreementCPA.Values.Image = global::YRG_4915M.Properties.Resources.application_side_list;
            this.lblAgreementCPA.Values.Text = "Contract PA";
            this.lblAgreementCPA.Click += new System.EventHandler(this.lblAgreeTable3_Click);
            // 
            // pageOrder
            // 
            this.pageOrder.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageOrder.Controls.Add(this.tableLayoutPanel3);
            this.pageOrder.Flags = 65534;
            this.pageOrder.ImageLarge = global::YRG_4915M.Properties.Resources.cart;
            this.pageOrder.ImageMedium = global::YRG_4915M.Properties.Resources.cart;
            this.pageOrder.ImageSmall = global::YRG_4915M.Properties.Resources.cart;
            this.pageOrder.LastVisibleSet = true;
            this.pageOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pageOrder.MinimumSize = new System.Drawing.Size(150, 50);
            this.pageOrder.Name = "pageOrder";
            this.pageOrder.Size = new System.Drawing.Size(226, 690);
            this.pageOrder.Text = "Order";
            this.pageOrder.TextDescription = "Order Management";
            this.pageOrder.TextTitle = "Order";
            this.pageOrder.ToolTipTitle = "Page ToolTip";
            this.pageOrder.UniqueName = "abe7127d346548369314162b3ce6314e";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoScroll = true;
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.kryptonLabel1, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.kryptonLabel2, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.kryptonLabel3, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblOrderAccounting, 1, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(226, 690);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(26, 17);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(174, 76);
            this.kryptonLabel1.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel1.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Garamond", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel1.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Image = global::YRG_4915M.Properties.Resources.resource_usage;
            this.kryptonLabel1.Values.Text = "Purchase Manager";
            this.kryptonLabel1.Click += new System.EventHandler(this.lblPurchaseManager_Click);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(26, 97);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(174, 76);
            this.kryptonLabel2.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel2.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel2.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel2.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Image = global::YRG_4915M.Properties.Resources.resources;
            this.kryptonLabel2.Values.Text = "Supplier";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonLabel3.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel3.Location = new System.Drawing.Point(26, 177);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(174, 76);
            this.kryptonLabel3.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel3.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel3.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel3.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kryptonLabel3.TabIndex = 2;
            this.kryptonLabel3.Values.Image = global::YRG_4915M.Properties.Resources.ceo;
            this.kryptonLabel3.Values.Text = "Warehouse";
            // 
            // lblOrderAccounting
            // 
            this.lblOrderAccounting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOrderAccounting.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblOrderAccounting.Location = new System.Drawing.Point(26, 257);
            this.lblOrderAccounting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblOrderAccounting.Name = "lblOrderAccounting";
            this.lblOrderAccounting.Size = new System.Drawing.Size(174, 76);
            this.lblOrderAccounting.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblOrderAccounting.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblOrderAccounting.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblOrderAccounting.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblOrderAccounting.TabIndex = 3;
            this.lblOrderAccounting.Values.Image = global::YRG_4915M.Properties.Resources.group;
            this.lblOrderAccounting.Values.Text = "Accounting\r\n";
            this.lblOrderAccounting.Click += new System.EventHandler(this.lblOrderAccounting_Click);
            // 
            // pageReport
            // 
            this.pageReport.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageReport.Controls.Add(this.tableLayoutPanel4);
            this.pageReport.Flags = 65534;
            this.pageReport.ImageLarge = global::YRG_4915M.Properties.Resources.report;
            this.pageReport.ImageMedium = global::YRG_4915M.Properties.Resources.report;
            this.pageReport.ImageSmall = global::YRG_4915M.Properties.Resources.report;
            this.pageReport.LastVisibleSet = true;
            this.pageReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pageReport.MinimumSize = new System.Drawing.Size(150, 50);
            this.pageReport.Name = "pageReport";
            this.pageReport.Size = new System.Drawing.Size(226, 690);
            this.pageReport.Text = "Report";
            this.pageReport.TextDescription = "Report";
            this.pageReport.TextTitle = "Report";
            this.pageReport.ToolTipTitle = "Page ToolTip";
            this.pageReport.UniqueName = "3597eaedf40045279c7a954b98724108";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoScroll = true;
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.lblReportMajor, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblReportMinor, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.lblReportTable3, 1, 3);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 8;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(226, 690);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // lblReportMajor
            // 
            this.lblReportMajor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReportMajor.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblReportMajor.Location = new System.Drawing.Point(77, 17);
            this.lblReportMajor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblReportMajor.Name = "lblReportMajor";
            this.lblReportMajor.Size = new System.Drawing.Size(71, 76);
            this.lblReportMajor.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblReportMajor.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblReportMajor.StateCommon.LongText.Font = new System.Drawing.Font("Garamond", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportMajor.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblReportMajor.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblReportMajor.TabIndex = 0;
            this.lblReportMajor.Values.Image = global::YRG_4915M.Properties.Resources.resource_usage;
            this.lblReportMajor.Values.Text = "Major";
            this.lblReportMajor.Click += new System.EventHandler(this.lblReportMajor_Click);
            // 
            // lblReportMinor
            // 
            this.lblReportMinor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReportMinor.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblReportMinor.Location = new System.Drawing.Point(77, 97);
            this.lblReportMinor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblReportMinor.Name = "lblReportMinor";
            this.lblReportMinor.Size = new System.Drawing.Size(71, 76);
            this.lblReportMinor.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblReportMinor.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblReportMinor.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblReportMinor.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblReportMinor.TabIndex = 1;
            this.lblReportMinor.Values.Image = global::YRG_4915M.Properties.Resources.resources;
            this.lblReportMinor.Values.Text = "Minor";
            this.lblReportMinor.Click += new System.EventHandler(this.lblReportMinor_Click);
            // 
            // lblReportTable3
            // 
            this.lblReportTable3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReportTable3.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblReportTable3.Location = new System.Drawing.Point(77, 177);
            this.lblReportTable3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblReportTable3.Name = "lblReportTable3";
            this.lblReportTable3.Size = new System.Drawing.Size(71, 76);
            this.lblReportTable3.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblReportTable3.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblReportTable3.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblReportTable3.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblReportTable3.TabIndex = 2;
            this.lblReportTable3.Values.Image = global::YRG_4915M.Properties.Resources.ceo;
            this.lblReportTable3.Values.Text = "Table3";
            this.lblReportTable3.Click += new System.EventHandler(this.lblReportTable3_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(228, 1055);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.dockPanelMain);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)(((((WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockTop) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockBottom) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.Document)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMenu";
            this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.DockLeft;
            this.Text = "User Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dockPanelMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBasicInfo)).EndInit();
            this.pageBasicInfo.ResumeLayout(false);
            this.tableLayoutPanelBase.ResumeLayout(false);
            this.tableLayoutPanelBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageItem)).EndInit();
            this.pageItem.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageStockCount)).EndInit();
            this.pageStockCount.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageRequest)).EndInit();
            this.pageRequest.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageAgreement)).EndInit();
            this.pageAgreement.ResumeLayout(false);
            this.tlpAgree.ResumeLayout(false);
            this.tlpAgree.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageOrder)).EndInit();
            this.pageOrder.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageReport)).EndInit();
            this.pageReport.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Docking.KryptonDockableNavigator dockPanelMain;
        private Krypton.Navigator.KryptonPage pageBasicInfo;
        private Krypton.Navigator.KryptonPage pageRequest;
        private Krypton.Navigator.KryptonPage pageItem;
        private Krypton.Navigator.KryptonPage pageAgreement;
        private Krypton.Navigator.KryptonPage pageReport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBase;
        private Krypton.Toolkit.KryptonLabel lblBasicInfoStaff;
        private Krypton.Toolkit.KryptonLabel lblBasicInfoSupplier;
        private Krypton.Toolkit.KryptonLabel lblBasicInfoRestaurant;
        private Krypton.Toolkit.KryptonLabel lblBasicInfoWarehouse;
        private Krypton.Toolkit.KryptonLabel lblBasicInfoTable5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Krypton.Toolkit.KryptonLabel lblRequestRM;
        private Krypton.Toolkit.KryptonLabel lblRequestPM;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Krypton.Toolkit.KryptonLabel lblItemMajor;
        private Krypton.Toolkit.KryptonLabel lblItems;
        private System.Windows.Forms.TableLayoutPanel tlpAgree;
        private Krypton.Toolkit.KryptonLabel lblAgreementView;
        private Krypton.Toolkit.KryptonLabel lblAgreementBPA;
        private Krypton.Toolkit.KryptonLabel lblAgreementCPA;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Krypton.Toolkit.KryptonLabel lblReportMajor;
        private Krypton.Toolkit.KryptonLabel lblReportMinor;
        private Krypton.Toolkit.KryptonLabel lblReportTable3;
        private Krypton.Navigator.KryptonPage pageOrder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel lblOrderAccounting;
        private Krypton.Navigator.KryptonPage pageStockCount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private Krypton.Toolkit.KryptonLabel lblWarehouseStockCount;
        private Krypton.Toolkit.KryptonLabel lblRestaurantStockCount;
    }
=======
﻿namespace YRG_4915M
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
            this.pageBasicInfo = new Krypton.Navigator.KryptonPage();
            this.tableLayoutPanelBase = new System.Windows.Forms.TableLayoutPanel();
            this.lblBasicInfoStaff = new Krypton.Toolkit.KryptonLabel();
            this.lblBasicInfoSupplier = new Krypton.Toolkit.KryptonLabel();
            this.lblBasicInfoRestaurant = new Krypton.Toolkit.KryptonLabel();
            this.lblBasicInfoWarehouse = new Krypton.Toolkit.KryptonLabel();
            this.lblBasicInfoTable5 = new Krypton.Toolkit.KryptonLabel();
            this.pageItem = new Krypton.Navigator.KryptonPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblItemMajor = new Krypton.Toolkit.KryptonLabel();
            this.lblItems = new Krypton.Toolkit.KryptonLabel();
            this.pageStockCount = new Krypton.Navigator.KryptonPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lblWarehouseStockCount = new Krypton.Toolkit.KryptonLabel();
            this.lblRestaurantStockCount = new Krypton.Toolkit.KryptonLabel();
            this.pageRequest = new Krypton.Navigator.KryptonPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRequestRM = new Krypton.Toolkit.KryptonLabel();
            this.lblRequestPM = new Krypton.Toolkit.KryptonLabel();
            this.pageAgreement = new Krypton.Navigator.KryptonPage();
            this.tlpAgree = new System.Windows.Forms.TableLayoutPanel();
            this.lblAgreementView = new Krypton.Toolkit.KryptonLabel();
            this.lblAgreementBPA = new Krypton.Toolkit.KryptonLabel();
            this.lblAgreementCPA = new Krypton.Toolkit.KryptonLabel();
            this.pageOrder = new Krypton.Navigator.KryptonPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.lblOrderAccounting = new Krypton.Toolkit.KryptonLabel();
            this.pageReport = new Krypton.Navigator.KryptonPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblReportMajor = new Krypton.Toolkit.KryptonLabel();
            this.lblReportMinor = new Krypton.Toolkit.KryptonLabel();
            this.lblReportTable3 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dockPanelMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBasicInfo)).BeginInit();
            this.pageBasicInfo.SuspendLayout();
            this.tableLayoutPanelBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageItem)).BeginInit();
            this.pageItem.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageStockCount)).BeginInit();
            this.pageStockCount.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageRequest)).BeginInit();
            this.pageRequest.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageAgreement)).BeginInit();
            this.pageAgreement.SuspendLayout();
            this.tlpAgree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageOrder)).BeginInit();
            this.pageOrder.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageReport)).BeginInit();
            this.pageReport.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockPanelMain
            // 
            this.dockPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanelMain.Location = new System.Drawing.Point(0, 0);
            this.dockPanelMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dockPanelMain.Name = "dockPanelMain";
            this.dockPanelMain.NavigatorMode = Krypton.Navigator.NavigatorMode.OutlookFull;
            this.dockPanelMain.PageBackStyle = Krypton.Toolkit.PaletteBackStyle.FormMain;
            this.dockPanelMain.Pages.AddRange(new Krypton.Navigator.KryptonPage[] {
            this.pageBasicInfo,
            this.pageItem,
            this.pageStockCount,
            this.pageRequest,
            this.pageAgreement,
            this.pageOrder,
            this.pageReport});
            this.dockPanelMain.SelectedIndex = 0;
            this.dockPanelMain.Size = new System.Drawing.Size(228, 1055);
            this.dockPanelMain.TabIndex = 0;
            this.dockPanelMain.Text = "kryptonDockableNavigator1";
            // 
            // pageBasicInfo
            // 
            this.pageBasicInfo.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageBasicInfo.Controls.Add(this.tableLayoutPanelBase);
            this.pageBasicInfo.Flags = 65534;
            this.pageBasicInfo.ImageLarge = global::YRG_4915M.Properties.Resources.large_tiles;
            this.pageBasicInfo.ImageMedium = global::YRG_4915M.Properties.Resources.large_tiles;
            this.pageBasicInfo.ImageSmall = global::YRG_4915M.Properties.Resources.large_tiles;
            this.pageBasicInfo.LastVisibleSet = true;
            this.pageBasicInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pageBasicInfo.MinimumSize = new System.Drawing.Size(150, 50);
            this.pageBasicInfo.Name = "pageBasicInfo";
            this.pageBasicInfo.Size = new System.Drawing.Size(226, 690);
            this.pageBasicInfo.Text = "Basic Info";
            this.pageBasicInfo.TextDescription = "Basic Information";
            this.pageBasicInfo.TextTitle = "Basic Info";
            this.pageBasicInfo.ToolTipTitle = "Page ToolTip";
            this.pageBasicInfo.UniqueName = "882fb5fd8212425d805e9b8be1b614f1";
            // 
            // tableLayoutPanelBase
            // 
            this.tableLayoutPanelBase.AutoScroll = true;
            this.tableLayoutPanelBase.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tableLayoutPanelBase.ColumnCount = 3;
            this.tableLayoutPanelBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBase.Controls.Add(this.lblBasicInfoStaff, 1, 1);
            this.tableLayoutPanelBase.Controls.Add(this.lblBasicInfoSupplier, 1, 2);
            this.tableLayoutPanelBase.Controls.Add(this.lblBasicInfoRestaurant, 1, 3);
            this.tableLayoutPanelBase.Controls.Add(this.lblBasicInfoWarehouse, 1, 4);
            this.tableLayoutPanelBase.Controls.Add(this.lblBasicInfoTable5, 1, 5);
            this.tableLayoutPanelBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBase.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelBase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.tableLayoutPanelBase.Size = new System.Drawing.Size(226, 690);
            this.tableLayoutPanelBase.TabIndex = 0;
            // 
            // lblBasicInfoStaff
            // 
            this.lblBasicInfoStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBasicInfoStaff.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblBasicInfoStaff.Location = new System.Drawing.Point(58, 17);
            this.lblBasicInfoStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblBasicInfoStaff.Name = "lblBasicInfoStaff";
            this.lblBasicInfoStaff.Size = new System.Drawing.Size(110, 76);
            this.lblBasicInfoStaff.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblBasicInfoStaff.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblBasicInfoStaff.StateCommon.LongText.Font = new System.Drawing.Font("Garamond", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasicInfoStaff.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblBasicInfoStaff.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblBasicInfoStaff.TabIndex = 0;
            this.lblBasicInfoStaff.Values.Image = global::YRG_4915M.Properties.Resources.group;
            this.lblBasicInfoStaff.Values.Text = "Staff";
            this.lblBasicInfoStaff.Click += new System.EventHandler(this.lblBasicInfoStaff_Click);
            // 
            // lblBasicInfoSupplier
            // 
            this.lblBasicInfoSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBasicInfoSupplier.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblBasicInfoSupplier.Location = new System.Drawing.Point(58, 97);
            this.lblBasicInfoSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblBasicInfoSupplier.Name = "lblBasicInfoSupplier";
            this.lblBasicInfoSupplier.Size = new System.Drawing.Size(110, 76);
            this.lblBasicInfoSupplier.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblBasicInfoSupplier.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblBasicInfoSupplier.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblBasicInfoSupplier.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblBasicInfoSupplier.TabIndex = 1;
            this.lblBasicInfoSupplier.Values.Image = global::YRG_4915M.Properties.Resources.ceo;
            this.lblBasicInfoSupplier.Values.Text = "Supplier";
            this.lblBasicInfoSupplier.Click += new System.EventHandler(this.lblBasicInfoSupplier_Click);
            // 
            // lblBasicInfoRestaurant
            // 
            this.lblBasicInfoRestaurant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBasicInfoRestaurant.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblBasicInfoRestaurant.Location = new System.Drawing.Point(58, 177);
            this.lblBasicInfoRestaurant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblBasicInfoRestaurant.Name = "lblBasicInfoRestaurant";
            this.lblBasicInfoRestaurant.Size = new System.Drawing.Size(110, 76);
            this.lblBasicInfoRestaurant.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblBasicInfoRestaurant.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblBasicInfoRestaurant.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblBasicInfoRestaurant.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblBasicInfoRestaurant.TabIndex = 2;
            this.lblBasicInfoRestaurant.Values.Image = global::YRG_4915M.Properties.Resources.chart_organisation;
            this.lblBasicInfoRestaurant.Values.Text = "Restaurant";
            this.lblBasicInfoRestaurant.Click += new System.EventHandler(this.lblBasicInfoRestaurant_Click);
            // 
            // lblBasicInfoWarehouse
            // 
            this.lblBasicInfoWarehouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBasicInfoWarehouse.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblBasicInfoWarehouse.Location = new System.Drawing.Point(58, 257);
            this.lblBasicInfoWarehouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblBasicInfoWarehouse.Name = "lblBasicInfoWarehouse";
            this.lblBasicInfoWarehouse.Size = new System.Drawing.Size(110, 76);
            this.lblBasicInfoWarehouse.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblBasicInfoWarehouse.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblBasicInfoWarehouse.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblBasicInfoWarehouse.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblBasicInfoWarehouse.TabIndex = 3;
            this.lblBasicInfoWarehouse.Values.Image = global::YRG_4915M.Properties.Resources.building;
            this.lblBasicInfoWarehouse.Values.Text = "Warehouse";
            this.lblBasicInfoWarehouse.Click += new System.EventHandler(this.lblBasicInfoWarehouse_Click);
            // 
            // lblBasicInfoTable5
            // 
            this.lblBasicInfoTable5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBasicInfoTable5.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblBasicInfoTable5.Location = new System.Drawing.Point(58, 337);
            this.lblBasicInfoTable5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblBasicInfoTable5.Name = "lblBasicInfoTable5";
            this.lblBasicInfoTable5.Size = new System.Drawing.Size(110, 76);
            this.lblBasicInfoTable5.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblBasicInfoTable5.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblBasicInfoTable5.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblBasicInfoTable5.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblBasicInfoTable5.TabIndex = 4;
            this.lblBasicInfoTable5.Values.Image = global::YRG_4915M.Properties.Resources.vcard;
            this.lblBasicInfoTable5.Values.Text = "Table5";
            this.lblBasicInfoTable5.Click += new System.EventHandler(this.lblBasicInfoYourAccount_Click);
            // 
            // pageItem
            // 
            this.pageItem.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageItem.Controls.Add(this.tableLayoutPanel2);
            this.pageItem.Flags = 65534;
            this.pageItem.ImageLarge = global::YRG_4915M.Properties.Resources.barcode;
            this.pageItem.ImageMedium = global::YRG_4915M.Properties.Resources.barcode;
            this.pageItem.ImageSmall = global::YRG_4915M.Properties.Resources.barcode;
            this.pageItem.LastVisibleSet = true;
            this.pageItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pageItem.MinimumSize = new System.Drawing.Size(150, 50);
            this.pageItem.Name = "pageItem";
            this.pageItem.Size = new System.Drawing.Size(226, 570);
            this.pageItem.Text = "Item";
            this.pageItem.TextDescription = "Item Management";
            this.pageItem.TextTitle = "Item";
            this.pageItem.ToolTipTitle = "Page ToolTip";
            this.pageItem.UniqueName = "2268293a882447c7b7ea61f7b2d6af31";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblItemMajor, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblItems, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(226, 570);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lblItemMajor
            // 
            this.lblItemMajor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblItemMajor.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblItemMajor.Location = new System.Drawing.Point(81, 17);
            this.lblItemMajor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblItemMajor.Name = "lblItemMajor";
            this.lblItemMajor.Size = new System.Drawing.Size(64, 76);
            this.lblItemMajor.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblItemMajor.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblItemMajor.StateCommon.LongText.Font = new System.Drawing.Font("Garamond", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemMajor.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblItemMajor.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblItemMajor.TabIndex = 0;
            this.lblItemMajor.Values.Image = global::YRG_4915M.Properties.Resources.resource_usage;
            this.lblItemMajor.Values.Text = "Major";
            this.lblItemMajor.Click += new System.EventHandler(this.lblItemMajor_Click);
            // 
            // lblItems
            // 
            this.lblItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblItems.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblItems.Location = new System.Drawing.Point(81, 97);
            this.lblItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(64, 76);
            this.lblItems.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblItems.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblItems.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblItems.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblItems.TabIndex = 1;
            this.lblItems.Values.Image = global::YRG_4915M.Properties.Resources.resources;
            this.lblItems.Values.Text = "Items";
            this.lblItems.Click += new System.EventHandler(this.lblItemItems_Click);
            // 
            // pageStockCount
            // 
            this.pageStockCount.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageStockCount.AutoScroll = true;
            this.pageStockCount.Controls.Add(this.tableLayoutPanel5);
            this.pageStockCount.Flags = 65534;
            this.pageStockCount.ImageLarge = global::YRG_4915M.Properties.Resources.resource_usage;
            this.pageStockCount.ImageMedium = global::YRG_4915M.Properties.Resources.resource_usage;
            this.pageStockCount.ImageSmall = global::YRG_4915M.Properties.Resources.resource_usage;
            this.pageStockCount.LastVisibleSet = true;
            this.pageStockCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pageStockCount.MinimumSize = new System.Drawing.Size(150, 50);
            this.pageStockCount.Name = "pageStockCount";
            this.pageStockCount.Size = new System.Drawing.Size(226, 690);
            this.pageStockCount.Text = "Stock Count";
            this.pageStockCount.TextDescription = "Stock Count";
            this.pageStockCount.TextTitle = "Stock Count";
            this.pageStockCount.ToolTipTitle = "Page ToolTip";
            this.pageStockCount.UniqueName = "88e71506f0c943209dff740dc3df9fc9";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoScroll = true;
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.lblWarehouseStockCount, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblRestaurantStockCount, 1, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 8;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(226, 690);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // lblWarehouseStockCount
            // 
            this.lblWarehouseStockCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWarehouseStockCount.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblWarehouseStockCount.Location = new System.Drawing.Point(58, 17);
            this.lblWarehouseStockCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblWarehouseStockCount.Name = "lblWarehouseStockCount";
            this.lblWarehouseStockCount.Size = new System.Drawing.Size(110, 76);
            this.lblWarehouseStockCount.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblWarehouseStockCount.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblWarehouseStockCount.StateCommon.LongText.Font = new System.Drawing.Font("Garamond", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarehouseStockCount.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblWarehouseStockCount.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblWarehouseStockCount.TabIndex = 0;
            this.lblWarehouseStockCount.Values.Image = global::YRG_4915M.Properties.Resources.building;
            this.lblWarehouseStockCount.Values.Text = "Warehouse";
            this.lblWarehouseStockCount.Click += new System.EventHandler(this.lblWarehouseStockCount_Click);
            // 
            // lblRestaurantStockCount
            // 
            this.lblRestaurantStockCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRestaurantStockCount.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblRestaurantStockCount.Location = new System.Drawing.Point(58, 97);
            this.lblRestaurantStockCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblRestaurantStockCount.Name = "lblRestaurantStockCount";
            this.lblRestaurantStockCount.Size = new System.Drawing.Size(110, 76);
            this.lblRestaurantStockCount.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblRestaurantStockCount.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblRestaurantStockCount.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblRestaurantStockCount.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblRestaurantStockCount.TabIndex = 1;
            this.lblRestaurantStockCount.Values.Image = global::YRG_4915M.Properties.Resources.chart_organisation;
            this.lblRestaurantStockCount.Values.Text = "Restaurant";
            this.lblRestaurantStockCount.Click += new System.EventHandler(this.lblRestaurantStockCount_Click);
            // 
            // pageRequest
            // 
            this.pageRequest.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageRequest.Controls.Add(this.tableLayoutPanel1);
            this.pageRequest.Flags = 65534;
            this.pageRequest.ImageLarge = global::YRG_4915M.Properties.Resources.application_from_storage;
            this.pageRequest.ImageMedium = global::YRG_4915M.Properties.Resources.application_from_storage;
            this.pageRequest.ImageSmall = global::YRG_4915M.Properties.Resources.application_from_storage;
            this.pageRequest.LastVisibleSet = true;
            this.pageRequest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pageRequest.MinimumSize = new System.Drawing.Size(150, 50);
            this.pageRequest.Name = "pageRequest";
            this.pageRequest.Size = new System.Drawing.Size(226, 690);
            this.pageRequest.Text = "Request";
            this.pageRequest.TextDescription = "Request Management";
            this.pageRequest.TextTitle = "Request";
            this.pageRequest.ToolTipTitle = "Page ToolTip";
            this.pageRequest.UniqueName = "7d268c94df7e43e2a2f02eec18410e0e";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblRequestRM, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblRequestPM, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(226, 690);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblRequestRM
            // 
            this.lblRequestRM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRequestRM.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblRequestRM.Location = new System.Drawing.Point(18, 17);
            this.lblRequestRM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblRequestRM.Name = "lblRequestRM";
            this.lblRequestRM.Size = new System.Drawing.Size(190, 76);
            this.lblRequestRM.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblRequestRM.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblRequestRM.StateCommon.LongText.Font = new System.Drawing.Font("Garamond", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestRM.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblRequestRM.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblRequestRM.TabIndex = 0;
            this.lblRequestRM.Values.Image = global::YRG_4915M.Properties.Resources.resource_usage;
            this.lblRequestRM.Values.Text = "Restaurant Manager";
            this.lblRequestRM.Click += new System.EventHandler(this.lblRequestRM_Click);
            // 
            // lblRequestPM
            // 
            this.lblRequestPM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRequestPM.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblRequestPM.Location = new System.Drawing.Point(18, 97);
            this.lblRequestPM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblRequestPM.Name = "lblRequestPM";
            this.lblRequestPM.Size = new System.Drawing.Size(190, 76);
            this.lblRequestPM.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblRequestPM.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblRequestPM.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblRequestPM.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblRequestPM.TabIndex = 1;
            this.lblRequestPM.Values.Image = global::YRG_4915M.Properties.Resources.resources;
            this.lblRequestPM.Values.Text = "Purchase Manager";
            this.lblRequestPM.Click += new System.EventHandler(this.lblRequestPM_Click);
            // 
            // pageAgreement
            // 
            this.pageAgreement.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageAgreement.Controls.Add(this.tlpAgree);
            this.pageAgreement.Flags = 65534;
            this.pageAgreement.ImageLarge = global::YRG_4915M.Properties.Resources.small_business;
            this.pageAgreement.ImageMedium = global::YRG_4915M.Properties.Resources.small_business;
            this.pageAgreement.ImageSmall = global::YRG_4915M.Properties.Resources.small_business;
            this.pageAgreement.LastVisibleSet = true;
            this.pageAgreement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pageAgreement.MinimumSize = new System.Drawing.Size(150, 50);
            this.pageAgreement.Name = "pageAgreement";
            this.pageAgreement.Size = new System.Drawing.Size(226, 690);
            this.pageAgreement.Text = "Agreement";
            this.pageAgreement.TextDescription = "Agreement Management";
            this.pageAgreement.TextTitle = "Agreement";
            this.pageAgreement.ToolTipTitle = "Page ToolTip";
            this.pageAgreement.UniqueName = "68ea8ebcc96945bf9f64ccf535baad96";
            // 
            // tlpAgree
            // 
            this.tlpAgree.AutoScroll = true;
            this.tlpAgree.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tlpAgree.ColumnCount = 3;
            this.tlpAgree.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAgree.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpAgree.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAgree.Controls.Add(this.lblAgreementView, 1, 1);
            this.tlpAgree.Controls.Add(this.lblAgreementBPA, 1, 2);
            this.tlpAgree.Controls.Add(this.lblAgreementCPA, 1, 3);
            this.tlpAgree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAgree.Location = new System.Drawing.Point(0, 0);
            this.tlpAgree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpAgree.Name = "tlpAgree";
            this.tlpAgree.RowCount = 8;
            this.tlpAgree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpAgree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpAgree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpAgree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpAgree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpAgree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpAgree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpAgree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAgree.Size = new System.Drawing.Size(226, 690);
            this.tlpAgree.TabIndex = 1;
            // 
            // lblAgreementView
            // 
            this.lblAgreementView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAgreementView.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblAgreementView.Location = new System.Drawing.Point(54, 17);
            this.lblAgreementView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblAgreementView.Name = "lblAgreementView";
            this.lblAgreementView.Size = new System.Drawing.Size(117, 76);
            this.lblAgreementView.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblAgreementView.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblAgreementView.StateCommon.LongText.Font = new System.Drawing.Font("Garamond", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgreementView.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblAgreementView.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblAgreementView.TabIndex = 0;
            this.lblAgreementView.Values.Image = global::YRG_4915M.Properties.Resources.application_form_magnify;
            this.lblAgreementView.Values.Text = "View All";
            this.lblAgreementView.Click += new System.EventHandler(this.lblAgreementView_Click);
            // 
            // lblAgreementBPA
            // 
            this.lblAgreementBPA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAgreementBPA.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblAgreementBPA.Location = new System.Drawing.Point(54, 97);
            this.lblAgreementBPA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblAgreementBPA.Name = "lblAgreementBPA";
            this.lblAgreementBPA.Size = new System.Drawing.Size(117, 76);
            this.lblAgreementBPA.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblAgreementBPA.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblAgreementBPA.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblAgreementBPA.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblAgreementBPA.TabIndex = 1;
            this.lblAgreementBPA.Values.Image = global::YRG_4915M.Properties.Resources.application_view_list;
            this.lblAgreementBPA.Values.Text = "Blanket PA";
            this.lblAgreementBPA.Click += new System.EventHandler(this.lblAgreementBPA_Click);
            // 
            // lblAgreementCPA
            // 
            this.lblAgreementCPA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAgreementCPA.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblAgreementCPA.Location = new System.Drawing.Point(54, 177);
            this.lblAgreementCPA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblAgreementCPA.Name = "lblAgreementCPA";
            this.lblAgreementCPA.Size = new System.Drawing.Size(117, 76);
            this.lblAgreementCPA.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblAgreementCPA.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblAgreementCPA.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblAgreementCPA.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblAgreementCPA.TabIndex = 2;
            this.lblAgreementCPA.Values.Image = global::YRG_4915M.Properties.Resources.application_side_list;
            this.lblAgreementCPA.Values.Text = "Contract PA";
            this.lblAgreementCPA.Click += new System.EventHandler(this.lblAgreeTable3_Click);
            // 
            // pageOrder
            // 
            this.pageOrder.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageOrder.Controls.Add(this.tableLayoutPanel3);
            this.pageOrder.Flags = 65534;
            this.pageOrder.ImageLarge = global::YRG_4915M.Properties.Resources.cart;
            this.pageOrder.ImageMedium = global::YRG_4915M.Properties.Resources.cart;
            this.pageOrder.ImageSmall = global::YRG_4915M.Properties.Resources.cart;
            this.pageOrder.LastVisibleSet = true;
            this.pageOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pageOrder.MinimumSize = new System.Drawing.Size(150, 50);
            this.pageOrder.Name = "pageOrder";
            this.pageOrder.Size = new System.Drawing.Size(226, 690);
            this.pageOrder.Text = "Order";
            this.pageOrder.TextDescription = "Order Management";
            this.pageOrder.TextTitle = "Order";
            this.pageOrder.ToolTipTitle = "Page ToolTip";
            this.pageOrder.UniqueName = "abe7127d346548369314162b3ce6314e";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoScroll = true;
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.kryptonLabel1, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.kryptonLabel2, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.kryptonLabel3, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblOrderAccounting, 1, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(226, 690);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(26, 17);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(174, 76);
            this.kryptonLabel1.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel1.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Garamond", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel1.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Image = global::YRG_4915M.Properties.Resources.resource_usage;
            this.kryptonLabel1.Values.Text = "Purchase Manager";
            this.kryptonLabel1.Click += new System.EventHandler(this.lblPurchaseManager_Click);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(26, 97);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(174, 76);
            this.kryptonLabel2.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel2.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel2.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel2.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Image = global::YRG_4915M.Properties.Resources.resources;
            this.kryptonLabel2.Values.Text = "Supplier";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonLabel3.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel3.Location = new System.Drawing.Point(26, 177);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(174, 76);
            this.kryptonLabel3.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel3.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel3.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonLabel3.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kryptonLabel3.TabIndex = 2;
            this.kryptonLabel3.Values.Image = global::YRG_4915M.Properties.Resources.ceo;
            this.kryptonLabel3.Values.Text = "Warehouse";
            // 
            // lblOrderAccounting
            // 
            this.lblOrderAccounting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOrderAccounting.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblOrderAccounting.Location = new System.Drawing.Point(26, 257);
            this.lblOrderAccounting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblOrderAccounting.Name = "lblOrderAccounting";
            this.lblOrderAccounting.Size = new System.Drawing.Size(174, 76);
            this.lblOrderAccounting.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblOrderAccounting.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblOrderAccounting.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblOrderAccounting.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblOrderAccounting.TabIndex = 3;
            this.lblOrderAccounting.Values.Image = global::YRG_4915M.Properties.Resources.group;
            this.lblOrderAccounting.Values.Text = "Accounting\r\n";
            this.lblOrderAccounting.Click += new System.EventHandler(this.lblOrderAccounting_Click);
            // 
            // pageReport
            // 
            this.pageReport.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pageReport.Controls.Add(this.tableLayoutPanel4);
            this.pageReport.Flags = 65534;
            this.pageReport.ImageLarge = global::YRG_4915M.Properties.Resources.report;
            this.pageReport.ImageMedium = global::YRG_4915M.Properties.Resources.report;
            this.pageReport.ImageSmall = global::YRG_4915M.Properties.Resources.report;
            this.pageReport.LastVisibleSet = true;
            this.pageReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pageReport.MinimumSize = new System.Drawing.Size(150, 50);
            this.pageReport.Name = "pageReport";
            this.pageReport.Size = new System.Drawing.Size(226, 690);
            this.pageReport.Text = "Report";
            this.pageReport.TextDescription = "Report";
            this.pageReport.TextTitle = "Report";
            this.pageReport.ToolTipTitle = "Page ToolTip";
            this.pageReport.UniqueName = "3597eaedf40045279c7a954b98724108";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoScroll = true;
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.lblReportMajor, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblReportMinor, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.lblReportTable3, 1, 3);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 8;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(226, 690);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // lblReportMajor
            // 
            this.lblReportMajor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReportMajor.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblReportMajor.Location = new System.Drawing.Point(77, 17);
            this.lblReportMajor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblReportMajor.Name = "lblReportMajor";
            this.lblReportMajor.Size = new System.Drawing.Size(71, 76);
            this.lblReportMajor.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblReportMajor.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblReportMajor.StateCommon.LongText.Font = new System.Drawing.Font("Garamond", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportMajor.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblReportMajor.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblReportMajor.TabIndex = 0;
            this.lblReportMajor.Values.Image = global::YRG_4915M.Properties.Resources.resource_usage;
            this.lblReportMajor.Values.Text = "Major";
            this.lblReportMajor.Click += new System.EventHandler(this.lblReportMajor_Click);
            // 
            // lblReportMinor
            // 
            this.lblReportMinor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReportMinor.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblReportMinor.Location = new System.Drawing.Point(77, 97);
            this.lblReportMinor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblReportMinor.Name = "lblReportMinor";
            this.lblReportMinor.Size = new System.Drawing.Size(71, 76);
            this.lblReportMinor.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblReportMinor.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblReportMinor.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblReportMinor.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblReportMinor.TabIndex = 1;
            this.lblReportMinor.Values.Image = global::YRG_4915M.Properties.Resources.resources;
            this.lblReportMinor.Values.Text = "Minor";
            this.lblReportMinor.Click += new System.EventHandler(this.lblReportMinor_Click);
            // 
            // lblReportTable3
            // 
            this.lblReportTable3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReportTable3.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblReportTable3.Location = new System.Drawing.Point(77, 177);
            this.lblReportTable3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblReportTable3.Name = "lblReportTable3";
            this.lblReportTable3.Size = new System.Drawing.Size(71, 76);
            this.lblReportTable3.StateCommon.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblReportTable3.StateCommon.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblReportTable3.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblReportTable3.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblReportTable3.TabIndex = 2;
            this.lblReportTable3.Values.Image = global::YRG_4915M.Properties.Resources.ceo;
            this.lblReportTable3.Values.Text = "Table3";
            this.lblReportTable3.Click += new System.EventHandler(this.lblReportTable3_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(228, 1055);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.dockPanelMain);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)(((((WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockTop) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockBottom) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.Document)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMenu";
            this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.DockLeft;
            this.Text = "User Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dockPanelMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBasicInfo)).EndInit();
            this.pageBasicInfo.ResumeLayout(false);
            this.tableLayoutPanelBase.ResumeLayout(false);
            this.tableLayoutPanelBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageItem)).EndInit();
            this.pageItem.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageStockCount)).EndInit();
            this.pageStockCount.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageRequest)).EndInit();
            this.pageRequest.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageAgreement)).EndInit();
            this.pageAgreement.ResumeLayout(false);
            this.tlpAgree.ResumeLayout(false);
            this.tlpAgree.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageOrder)).EndInit();
            this.pageOrder.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageReport)).EndInit();
            this.pageReport.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Docking.KryptonDockableNavigator dockPanelMain;
        private Krypton.Navigator.KryptonPage pageBasicInfo;
        private Krypton.Navigator.KryptonPage pageRequest;
        private Krypton.Navigator.KryptonPage pageItem;
        private Krypton.Navigator.KryptonPage pageAgreement;
        private Krypton.Navigator.KryptonPage pageReport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBase;
        private Krypton.Toolkit.KryptonLabel lblBasicInfoStaff;
        private Krypton.Toolkit.KryptonLabel lblBasicInfoSupplier;
        private Krypton.Toolkit.KryptonLabel lblBasicInfoRestaurant;
        private Krypton.Toolkit.KryptonLabel lblBasicInfoWarehouse;
        private Krypton.Toolkit.KryptonLabel lblBasicInfoTable5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Krypton.Toolkit.KryptonLabel lblRequestRM;
        private Krypton.Toolkit.KryptonLabel lblRequestPM;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Krypton.Toolkit.KryptonLabel lblItemMajor;
        private Krypton.Toolkit.KryptonLabel lblItems;
        private System.Windows.Forms.TableLayoutPanel tlpAgree;
        private Krypton.Toolkit.KryptonLabel lblAgreementView;
        private Krypton.Toolkit.KryptonLabel lblAgreementBPA;
        private Krypton.Toolkit.KryptonLabel lblAgreementCPA;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Krypton.Toolkit.KryptonLabel lblReportMajor;
        private Krypton.Toolkit.KryptonLabel lblReportMinor;
        private Krypton.Toolkit.KryptonLabel lblReportTable3;
        private Krypton.Navigator.KryptonPage pageOrder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel lblOrderAccounting;
        private Krypton.Navigator.KryptonPage pageStockCount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private Krypton.Toolkit.KryptonLabel lblWarehouseStockCount;
        private Krypton.Toolkit.KryptonLabel lblRestaurantStockCount;
    }
>>>>>>> e3039030246399001b6a193ac0434d0ab124b1f7
}