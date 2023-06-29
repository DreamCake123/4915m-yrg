namespace YRG_4915M.Pages.StockManagement
{
    partial class StockFrmRestaurant
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
            this.tlpItemSearch = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonHeader1 = new Krypton.Toolkit.KryptonHeader();
            this.headerSearch02 = new Krypton.Toolkit.KryptonHeader();
            this.headerSearch01 = new Krypton.Toolkit.KryptonHeader();
            this.btnSaveUpdate = new Krypton.Toolkit.ButtonSpecAny();
            this.btnSearch = new Krypton.Toolkit.ButtonSpecAny();
            this.tlpItemSearchCriteria = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.rbBoth = new Krypton.Toolkit.KryptonRadioButton();
            this.rbFB = new Krypton.Toolkit.KryptonRadioButton();
            this.rbGI = new Krypton.Toolkit.KryptonRadioButton();
            this.kryptonLabel13 = new Krypton.Toolkit.KryptonLabel();
            this.txtVirtualItemId = new Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny9 = new Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.txtItemName = new Krypton.Toolkit.KryptonTextBox();
            this.btnItemNameCancel = new Krypton.Toolkit.ButtonSpecAny();
            this.cbItemType = new Krypton.Toolkit.KryptonComboBox();
            this.lblItemName = new Krypton.Toolkit.KryptonLabel();
            this.dgvStockCount = new Krypton.Toolkit.KryptonDataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonLabel14 = new Krypton.Toolkit.KryptonLabel();
            this.txtItemStock = new Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny10 = new Krypton.Toolkit.ButtonSpecAny();
            this.lblItemStockCountUpdateDate = new Krypton.Toolkit.KryptonLabel();
            this.txtItemStockCountUpdateDate = new Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny6 = new Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.txtRestaurantID = new Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny1 = new Krypton.Toolkit.ButtonSpecAny();
            this.tlpItemSearch.SuspendLayout();
            this.tlpItemSearchCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbItemType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockCount)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpItemSearch
            // 
            this.tlpItemSearch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tlpItemSearch.ColumnCount = 1;
            this.tlpItemSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpItemSearch.Controls.Add(this.kryptonHeader1, 0, 2);
            this.tlpItemSearch.Controls.Add(this.headerSearch02, 0, 4);
            this.tlpItemSearch.Controls.Add(this.headerSearch01, 0, 0);
            this.tlpItemSearch.Controls.Add(this.tlpItemSearchCriteria, 0, 1);
            this.tlpItemSearch.Controls.Add(this.dgvStockCount, 0, 5);
            this.tlpItemSearch.Controls.Add(this.tableLayoutPanel1, 0, 3);
            this.tlpItemSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpItemSearch.Location = new System.Drawing.Point(0, 0);
            this.tlpItemSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpItemSearch.Name = "tlpItemSearch";
            this.tlpItemSearch.RowCount = 6;
            this.tlpItemSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpItemSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpItemSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpItemSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpItemSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpItemSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpItemSearch.Size = new System.Drawing.Size(1687, 844);
            this.tlpItemSearch.TabIndex = 1;
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeader1.HeaderStyle = Krypton.Toolkit.HeaderStyle.Form;
            this.kryptonHeader1.Location = new System.Drawing.Point(2, 156);
            this.kryptonHeader1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(1683, 40);
            this.kryptonHeader1.StateCommon.Border.Color1 = System.Drawing.Color.DarkGray;
            this.kryptonHeader1.StateCommon.Border.Color2 = System.Drawing.Color.DarkGray;
            this.kryptonHeader1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonHeader1.StateCommon.ButtonPadding = new System.Windows.Forms.Padding(6, 6, 20, 6);
            this.kryptonHeader1.StateCommon.Content.Padding = new System.Windows.Forms.Padding(3);
            this.kryptonHeader1.TabIndex = 3;
            this.kryptonHeader1.Values.Description = "";
            this.kryptonHeader1.Values.Heading = "Item Stock Count";
            this.kryptonHeader1.Values.Image = global::YRG_4915M.Properties.Resources.application_form;
            // 
            // headerSearch02
            // 
            this.headerSearch02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerSearch02.HeaderStyle = Krypton.Toolkit.HeaderStyle.Form;
            this.headerSearch02.Location = new System.Drawing.Point(2, 268);
            this.headerSearch02.Margin = new System.Windows.Forms.Padding(2);
            this.headerSearch02.Name = "headerSearch02";
            this.headerSearch02.Size = new System.Drawing.Size(1683, 44);
            this.headerSearch02.StateCommon.Border.Color1 = System.Drawing.Color.DarkGray;
            this.headerSearch02.StateCommon.Border.Color2 = System.Drawing.Color.DarkGray;
            this.headerSearch02.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.headerSearch02.StateCommon.ButtonPadding = new System.Windows.Forms.Padding(5);
            this.headerSearch02.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.headerSearch02.TabIndex = 1;
            this.headerSearch02.Values.Description = "";
            this.headerSearch02.Values.Heading = "Search Result";
            this.headerSearch02.Values.Image = global::YRG_4915M.Properties.Resources.find;
            // 
            // headerSearch01
            // 
            this.headerSearch01.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.btnSaveUpdate,
            this.btnSearch});
            this.headerSearch01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerSearch01.HeaderStyle = Krypton.Toolkit.HeaderStyle.Form;
            this.headerSearch01.Location = new System.Drawing.Point(2, 2);
            this.headerSearch01.Margin = new System.Windows.Forms.Padding(2);
            this.headerSearch01.Name = "headerSearch01";
            this.headerSearch01.Size = new System.Drawing.Size(1683, 46);
            this.headerSearch01.StateCommon.Border.Color1 = System.Drawing.Color.DarkGray;
            this.headerSearch01.StateCommon.Border.Color2 = System.Drawing.Color.DarkGray;
            this.headerSearch01.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.headerSearch01.StateCommon.ButtonPadding = new System.Windows.Forms.Padding(6, 6, 15, 6);
            this.headerSearch01.StateCommon.Content.Padding = new System.Windows.Forms.Padding(3);
            this.headerSearch01.TabIndex = 0;
            this.headerSearch01.Values.Description = "";
            this.headerSearch01.Values.Heading = "";
            this.headerSearch01.Values.Image = null;
            // 
            // btnSaveUpdate
            // 
            this.btnSaveUpdate.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btnSaveUpdate.ExtraText = "Save Stock Count Update";
            this.btnSaveUpdate.Image = global::YRG_4915M.Properties.Resources.disk;
            this.btnSaveUpdate.UniqueName = "872a252e0e884f5ab37f29475076dba2";
            this.btnSaveUpdate.Click += new System.EventHandler(this.btnSaveUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btnSearch.Image = global::YRG_4915M.Properties.Resources.magnifier;
            this.btnSearch.Text = "Search Item";
            this.btnSearch.UniqueName = "4f6ee0408dfc46d4bc102babd366485b";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tlpItemSearchCriteria
            // 
            this.tlpItemSearchCriteria.AutoScroll = true;
            this.tlpItemSearchCriteria.AutoScrollMargin = new System.Drawing.Size(5, 0);
            this.tlpItemSearchCriteria.AutoSize = true;
            this.tlpItemSearchCriteria.ColumnCount = 12;
            this.tlpItemSearch.SetColumnSpan(this.tlpItemSearchCriteria, 2);
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpItemSearchCriteria.Controls.Add(this.kryptonLabel1, 7, 1);
            this.tlpItemSearchCriteria.Controls.Add(this.rbBoth, 8, 1);
            this.tlpItemSearchCriteria.Controls.Add(this.rbFB, 9, 1);
            this.tlpItemSearchCriteria.Controls.Add(this.rbGI, 10, 1);
            this.tlpItemSearchCriteria.Controls.Add(this.kryptonLabel7, 4, 1);
            this.tlpItemSearchCriteria.Controls.Add(this.cbItemType, 5, 1);
            this.tlpItemSearchCriteria.Controls.Add(this.txtItemName, 5, 2);
            this.tlpItemSearchCriteria.Controls.Add(this.lblItemName, 4, 2);
            this.tlpItemSearchCriteria.Controls.Add(this.txtVirtualItemId, 2, 2);
            this.tlpItemSearchCriteria.Controls.Add(this.kryptonLabel13, 1, 2);
            this.tlpItemSearchCriteria.Controls.Add(this.kryptonLabel2, 1, 1);
            this.tlpItemSearchCriteria.Controls.Add(this.txtRestaurantID, 2, 1);
            this.tlpItemSearchCriteria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpItemSearchCriteria.Location = new System.Drawing.Point(3, 52);
            this.tlpItemSearchCriteria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpItemSearchCriteria.Name = "tlpItemSearchCriteria";
            this.tlpItemSearchCriteria.RowCount = 4;
            this.tlpItemSearchCriteria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpItemSearchCriteria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpItemSearchCriteria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpItemSearchCriteria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpItemSearchCriteria.Size = new System.Drawing.Size(1681, 100);
            this.tlpItemSearchCriteria.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kryptonLabel1.Location = new System.Drawing.Point(787, 14);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(108, 24);
            this.kryptonLabel1.TabIndex = 7;
            this.kryptonLabel1.Values.Text = "Item Category";
            // 
            // rbBoth
            // 
            this.rbBoth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbBoth.Location = new System.Drawing.Point(901, 14);
            this.rbBoth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbBoth.Name = "rbBoth";
            this.rbBoth.Size = new System.Drawing.Size(112, 24);
            this.rbBoth.TabIndex = 13;
            this.rbBoth.Values.ExtraText = "Both GI & FB";
            this.rbBoth.Values.Text = "";
            // 
            // rbFB
            // 
            this.rbFB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbFB.Location = new System.Drawing.Point(1019, 14);
            this.rbFB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbFB.Name = "rbFB";
            this.rbFB.Size = new System.Drawing.Size(172, 24);
            this.rbFB.TabIndex = 12;
            this.rbFB.Values.ExtraText = "Food & Beverage (FB)";
            this.rbFB.Values.Text = "";
            // 
            // rbGI
            // 
            this.rbGI.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbGI.Location = new System.Drawing.Point(1197, 14);
            this.rbGI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbGI.Name = "rbGI";
            this.rbGI.Size = new System.Drawing.Size(146, 24);
            this.rbGI.TabIndex = 11;
            this.rbGI.Values.Text = "General Items (GI)";
            // 
            // kryptonLabel13
            // 
            this.kryptonLabel13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kryptonLabel13.Location = new System.Drawing.Point(12, 50);
            this.kryptonLabel13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel13.Name = "kryptonLabel13";
            this.kryptonLabel13.Size = new System.Drawing.Size(110, 24);
            this.kryptonLabel13.TabIndex = 25;
            this.kryptonLabel13.Values.Text = "Virtual Item ID";
            // 
            // txtVirtualItemId
            // 
            this.txtVirtualItemId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtVirtualItemId.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny9});
            this.txtVirtualItemId.CueHint.CueHintText = "Virtual Item ID (YRG)";
            this.txtVirtualItemId.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtVirtualItemId.Location = new System.Drawing.Point(128, 48);
            this.txtVirtualItemId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVirtualItemId.Name = "txtVirtualItemId";
            this.txtVirtualItemId.Size = new System.Drawing.Size(241, 27);
            this.txtVirtualItemId.TabIndex = 26;
            // 
            // buttonSpecAny9
            // 
            this.buttonSpecAny9.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.buttonSpecAny9.UniqueName = "6fb900f9fa524f45950d2ef28f395a0c";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kryptonLabel7.Location = new System.Drawing.Point(411, 14);
            this.kryptonLabel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(79, 24);
            this.kryptonLabel7.TabIndex = 14;
            this.kryptonLabel7.Values.Text = "Item Type";
            // 
            // txtItemName
            // 
            this.txtItemName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtItemName.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.btnItemNameCancel});
            this.txtItemName.CueHint.CueHintText = "Item Name";
            this.txtItemName.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtItemName.Location = new System.Drawing.Point(504, 48);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(241, 27);
            this.txtItemName.TabIndex = 6;
            // 
            // btnItemNameCancel
            // 
            this.btnItemNameCancel.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.btnItemNameCancel.UniqueName = "130bee2941b345629cbf0e4d8263e0de";
            // 
            // cbItemType
            // 
            this.cbItemType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbItemType.CornerRoundingRadius = -1F;
            this.cbItemType.CueHint.CueHintText = "Type";
            this.cbItemType.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.cbItemType.DropDownWidth = 179;
            this.cbItemType.IntegralHeight = false;
            this.cbItemType.Location = new System.Drawing.Point(504, 13);
            this.cbItemType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbItemType.Name = "cbItemType";
            this.cbItemType.Size = new System.Drawing.Size(151, 25);
            this.cbItemType.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbItemType.TabIndex = 15;
            // 
            // lblItemName
            // 
            this.lblItemName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblItemName.Location = new System.Drawing.Point(411, 50);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(87, 24);
            this.lblItemName.TabIndex = 2;
            this.lblItemName.Values.Text = "Item Name";
            // 
            // dgvStockCount
            // 
            this.dgvStockCount.AllowUserToAddRows = false;
            this.dgvStockCount.AllowUserToDeleteRows = false;
            this.dgvStockCount.AllowUserToResizeRows = false;
            this.dgvStockCount.ColumnHeadersHeight = 28;
            this.dgvStockCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStockCount.Location = new System.Drawing.Point(3, 316);
            this.dgvStockCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvStockCount.Name = "dgvStockCount";
            this.dgvStockCount.RowHeadersWidth = 75;
            this.dgvStockCount.RowTemplate.Height = 29;
            this.dgvStockCount.Size = new System.Drawing.Size(1681, 526);
            this.dgvStockCount.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoScrollMargin = new System.Drawing.Size(5, 0);
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tlpItemSearch.SetColumnSpan(this.tableLayoutPanel1, 2);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.Controls.Add(this.kryptonLabel14, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtItemStock, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblItemStockCountUpdateDate, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtItemStockCountUpdateDate, 5, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 200);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1681, 64);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // kryptonLabel14
            // 
            this.kryptonLabel14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kryptonLabel14.Location = new System.Drawing.Point(12, 14);
            this.kryptonLabel14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel14.Name = "kryptonLabel14";
            this.kryptonLabel14.Size = new System.Drawing.Size(129, 24);
            this.kryptonLabel14.TabIndex = 27;
            this.kryptonLabel14.Values.Text = "Item Stock Count";
            // 
            // txtItemStock
            // 
            this.txtItemStock.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtItemStock.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny10});
            this.txtItemStock.CueHint.CueHintText = "Item Stock Count";
            this.txtItemStock.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtItemStock.Location = new System.Drawing.Point(147, 12);
            this.txtItemStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtItemStock.Name = "txtItemStock";
            this.txtItemStock.Size = new System.Drawing.Size(186, 27);
            this.txtItemStock.TabIndex = 28;
            // 
            // buttonSpecAny10
            // 
            this.buttonSpecAny10.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.buttonSpecAny10.UniqueName = "130bee2941b345629cbf0e4d8263e0de";
            // 
            // lblItemStockCountUpdateDate
            // 
            this.lblItemStockCountUpdateDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblItemStockCountUpdateDate.Location = new System.Drawing.Point(375, 14);
            this.lblItemStockCountUpdateDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblItemStockCountUpdateDate.Name = "lblItemStockCountUpdateDate";
            this.lblItemStockCountUpdateDate.Size = new System.Drawing.Size(220, 24);
            this.lblItemStockCountUpdateDate.TabIndex = 19;
            this.lblItemStockCountUpdateDate.Values.Text = "Item Stock Count Update Date";
            // 
            // txtItemStockCountUpdateDate
            // 
            this.txtItemStockCountUpdateDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtItemStockCountUpdateDate.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny6});
            this.txtItemStockCountUpdateDate.CueHint.CueHintText = "i.e. 2023-01-23";
            this.txtItemStockCountUpdateDate.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtItemStockCountUpdateDate.Location = new System.Drawing.Point(601, 12);
            this.txtItemStockCountUpdateDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtItemStockCountUpdateDate.Name = "txtItemStockCountUpdateDate";
            this.txtItemStockCountUpdateDate.Size = new System.Drawing.Size(175, 27);
            this.txtItemStockCountUpdateDate.TabIndex = 20;
            // 
            // buttonSpecAny6
            // 
            this.buttonSpecAny6.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.buttonSpecAny6.UniqueName = "6fb900f9fa524f45950d2ef28f395a0c";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 14);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(104, 24);
            this.kryptonLabel2.TabIndex = 27;
            this.kryptonLabel2.Values.Text = "Restauarnt ID";
            // 
            // txtRestaurantID
            // 
            this.txtRestaurantID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtRestaurantID.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.txtRestaurantID.CueHint.CueHintText = "Restaurant ID";
            this.txtRestaurantID.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtRestaurantID.Location = new System.Drawing.Point(128, 12);
            this.txtRestaurantID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRestaurantID.Name = "txtRestaurantID";
            this.txtRestaurantID.Size = new System.Drawing.Size(241, 27);
            this.txtRestaurantID.TabIndex = 28;
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.buttonSpecAny1.UniqueName = "6fb900f9fa524f45950d2ef28f395a0c";
            // 
            // StockFrmRestaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1687, 844);
            this.Controls.Add(this.tlpItemSearch);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StockFrmRestaurant";
            this.Text = "YRGPCS Restaurant Stock Management";
            this.tlpItemSearch.ResumeLayout(false);
            this.tlpItemSearch.PerformLayout();
            this.tlpItemSearchCriteria.ResumeLayout(false);
            this.tlpItemSearchCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbItemType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockCount)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpItemSearch;
        private Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private Krypton.Toolkit.KryptonHeader headerSearch02;
        private Krypton.Toolkit.KryptonHeader headerSearch01;
        private Krypton.Toolkit.ButtonSpecAny btnSaveUpdate;
        private Krypton.Toolkit.ButtonSpecAny btnSearch;
        private System.Windows.Forms.TableLayoutPanel tlpItemSearchCriteria;
        private Krypton.Toolkit.KryptonLabel lblItemName;
        private Krypton.Toolkit.KryptonTextBox txtItemName;
        private Krypton.Toolkit.ButtonSpecAny btnItemNameCancel;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonRadioButton rbBoth;
        private Krypton.Toolkit.KryptonRadioButton rbFB;
        private Krypton.Toolkit.KryptonRadioButton rbGI;
        private Krypton.Toolkit.KryptonLabel kryptonLabel13;
        private Krypton.Toolkit.KryptonTextBox txtVirtualItemId;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny9;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonComboBox cbItemType;
        private Krypton.Toolkit.KryptonDataGridView dgvStockCount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel14;
        private Krypton.Toolkit.KryptonTextBox txtItemStock;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny10;
        private Krypton.Toolkit.KryptonLabel lblItemStockCountUpdateDate;
        private Krypton.Toolkit.KryptonTextBox txtItemStockCountUpdateDate;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox txtRestaurantID;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
    }
}