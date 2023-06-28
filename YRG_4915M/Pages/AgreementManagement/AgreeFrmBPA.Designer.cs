<<<<<<< HEAD
﻿namespace YRG_4915M.Pages.AgreementManagement
{
    partial class AgreeFrmBPA
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
            this.dgvBPA = new Krypton.Toolkit.KryptonDataGridView();
            this.headerSearch02 = new Krypton.Toolkit.KryptonHeader();
            this.btnCreateBPA = new Krypton.Toolkit.ButtonSpecAny();
            this.btnEditBPA = new Krypton.Toolkit.ButtonSpecAny();
            this.headerSearch01 = new Krypton.Toolkit.KryptonHeader();
            this.btnSearch = new Krypton.Toolkit.ButtonSpecAny();
            this.tlpItemSearchCriteria = new System.Windows.Forms.TableLayoutPanel();
            this.lblAgreeID = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.txtBPAID = new Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny1 = new Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.cbCurrency = new Krypton.Toolkit.KryptonComboBox();
            this.btnCancelCurrency = new Krypton.Toolkit.ButtonSpecAny();
            this.lblItemName = new Krypton.Toolkit.KryptonLabel();
            this.txtSupplierID = new Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny2 = new Krypton.Toolkit.ButtonSpecAny();
            this.kryptonTextBox2 = new Krypton.Toolkit.KryptonTextBox();
            this.btnCancelType = new Krypton.Toolkit.ButtonSpecAny();
            this.txtItemID = new Krypton.Toolkit.KryptonTextBox();
            this.btnItemIDCancel = new Krypton.Toolkit.ButtonSpecAny();
            this.txtItemName = new Krypton.Toolkit.KryptonTextBox();
            this.btnItemNameCancel = new Krypton.Toolkit.ButtonSpecAny();
            this.tlpItemSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBPA)).BeginInit();
            this.tlpItemSearchCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCurrency)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpItemSearch
            // 
            this.tlpItemSearch.AutoScroll = true;
            this.tlpItemSearch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tlpItemSearch.ColumnCount = 1;
            this.tlpItemSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpItemSearch.Controls.Add(this.dgvBPA, 0, 3);
            this.tlpItemSearch.Controls.Add(this.headerSearch02, 0, 2);
            this.tlpItemSearch.Controls.Add(this.headerSearch01, 0, 0);
            this.tlpItemSearch.Controls.Add(this.tlpItemSearchCriteria, 0, 1);
            this.tlpItemSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpItemSearch.Location = new System.Drawing.Point(0, 0);
            this.tlpItemSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpItemSearch.Name = "tlpItemSearch";
            this.tlpItemSearch.RowCount = 4;
            this.tlpItemSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpItemSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpItemSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpItemSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpItemSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpItemSearch.Size = new System.Drawing.Size(1898, 1055);
            this.tlpItemSearch.TabIndex = 2;
            // 
            // dgvBPA
            // 
            this.dgvBPA.AllowUserToAddRows = false;
            this.dgvBPA.AllowUserToDeleteRows = false;
            this.dgvBPA.AllowUserToResizeRows = false;
            this.dgvBPA.ColumnHeadersHeight = 28;
            this.dgvBPA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBPA.Location = new System.Drawing.Point(3, 169);
            this.dgvBPA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBPA.Name = "dgvBPA";
            this.dgvBPA.ReadOnly = true;
            this.dgvBPA.RowHeadersWidth = 75;
            this.dgvBPA.RowTemplate.Height = 29;
            this.dgvBPA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBPA.Size = new System.Drawing.Size(1892, 884);
            this.dgvBPA.TabIndex = 3;
            // 
            // headerSearch02
            // 
            this.headerSearch02.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.btnCreateBPA,
            this.btnEditBPA});
            this.headerSearch02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerSearch02.HeaderStyle = Krypton.Toolkit.HeaderStyle.Form;
            this.headerSearch02.Location = new System.Drawing.Point(2, 121);
            this.headerSearch02.Margin = new System.Windows.Forms.Padding(2);
            this.headerSearch02.Name = "headerSearch02";
            this.headerSearch02.Size = new System.Drawing.Size(1894, 44);
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
            // btnCreateBPA
            // 
            this.btnCreateBPA.ExtraText = "Create New Blanket Purchase Agreement";
            this.btnCreateBPA.Image = global::YRG_4915M.Properties.Resources.application_form;
            this.btnCreateBPA.UniqueName = "ef9e966d34ca477fa0e5ac58e9fd086e";
            this.btnCreateBPA.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnEditBPA
            // 
            this.btnEditBPA.ExtraText = "Edit Agreement";
            this.btnEditBPA.Image = global::YRG_4915M.Properties.Resources.pencil;
            this.btnEditBPA.UniqueName = "90b8baa6439c466eb23697aaab6acec5";
            this.btnEditBPA.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // headerSearch01
            // 
            this.headerSearch01.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.btnSearch});
            this.headerSearch01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerSearch01.HeaderStyle = Krypton.Toolkit.HeaderStyle.Form;
            this.headerSearch01.Location = new System.Drawing.Point(2, 2);
            this.headerSearch01.Margin = new System.Windows.Forms.Padding(2);
            this.headerSearch01.Name = "headerSearch01";
            this.headerSearch01.Size = new System.Drawing.Size(1894, 46);
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
            // btnSearch
            // 
            this.btnSearch.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btnSearch.Image = global::YRG_4915M.Properties.Resources.magnifier;
            this.btnSearch.Text = "Search BPA";
            this.btnSearch.UniqueName = "4f6ee0408dfc46d4bc102babd366485b";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tlpItemSearchCriteria
            // 
            this.tlpItemSearchCriteria.AutoSize = true;
            this.tlpItemSearchCriteria.ColumnCount = 10;
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpItemSearchCriteria.Controls.Add(this.lblAgreeID, 0, 2);
            this.tlpItemSearchCriteria.Controls.Add(this.kryptonLabel3, 1, 1);
            this.tlpItemSearchCriteria.Controls.Add(this.txtBPAID, 2, 1);
            this.tlpItemSearchCriteria.Controls.Add(this.kryptonLabel1, 7, 1);
            this.tlpItemSearchCriteria.Controls.Add(this.cbCurrency, 8, 1);
            this.tlpItemSearchCriteria.Controls.Add(this.lblItemName, 4, 1);
            this.tlpItemSearchCriteria.Controls.Add(this.txtSupplierID, 5, 1);
            this.tlpItemSearchCriteria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpItemSearchCriteria.Location = new System.Drawing.Point(3, 52);
            this.tlpItemSearchCriteria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpItemSearchCriteria.Name = "tlpItemSearchCriteria";
            this.tlpItemSearchCriteria.RowCount = 3;
            this.tlpItemSearchCriteria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpItemSearchCriteria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpItemSearchCriteria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpItemSearchCriteria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpItemSearchCriteria.Size = new System.Drawing.Size(1892, 65);
            this.tlpItemSearchCriteria.TabIndex = 0;
            // 
            // lblAgreeID
            // 
            this.lblAgreeID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAgreeID.Location = new System.Drawing.Point(3, 59);
            this.lblAgreeID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblAgreeID.Name = "lblAgreeID";
            this.lblAgreeID.Size = new System.Drawing.Size(4, 2);
            this.lblAgreeID.TabIndex = 3;
            this.lblAgreeID.Values.Text = "";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kryptonLabel3.Location = new System.Drawing.Point(13, 18);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(68, 29);
            this.kryptonLabel3.TabIndex = 13;
            this.kryptonLabel3.Values.Text = "BPA ID";
            // 
            // txtBPAID
            // 
            this.txtBPAID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBPAID.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.txtBPAID.CueHint.CueHintText = "Agreement ID";
            this.txtBPAID.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtBPAID.Location = new System.Drawing.Point(87, 17);
            this.txtBPAID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBPAID.Name = "txtBPAID";
            this.txtBPAID.Size = new System.Drawing.Size(302, 31);
            this.txtBPAID.TabIndex = 14;
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.buttonSpecAny1.UniqueName = "6fb900f9fa524f45950d2ef28f395a0c";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kryptonLabel1.Location = new System.Drawing.Point(892, 18);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(85, 29);
            this.kryptonLabel1.TabIndex = 17;
            this.kryptonLabel1.Values.Text = "Currency";
            // 
            // cbCurrency
            // 
            this.cbCurrency.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbCurrency.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.btnCancelCurrency});
            this.cbCurrency.CornerRoundingRadius = -1F;
            this.cbCurrency.CueHint.CueHintText = "Currency";
            this.cbCurrency.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.cbCurrency.DropDownWidth = 301;
            this.cbCurrency.IntegralHeight = false;
            this.cbCurrency.Location = new System.Drawing.Point(983, 18);
            this.cbCurrency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Size = new System.Drawing.Size(256, 29);
            this.cbCurrency.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbCurrency.TabIndex = 18;
            // 
            // btnCancelCurrency
            // 
            this.btnCancelCurrency.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btnCancelCurrency.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.btnCancelCurrency.UniqueName = "da40efd0712f418d89fc8b607d76bcda";
            // 
            // lblItemName
            // 
            this.lblItemName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblItemName.Location = new System.Drawing.Point(435, 18);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(103, 29);
            this.lblItemName.TabIndex = 16;
            this.lblItemName.Values.Text = "Supplier ID";
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSupplierID.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny2});
            this.txtSupplierID.CueHint.CueHintText = "Supplier ID";
            this.txtSupplierID.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtSupplierID.Location = new System.Drawing.Point(544, 17);
            this.txtSupplierID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Size = new System.Drawing.Size(302, 31);
            this.txtSupplierID.TabIndex = 15;
            // 
            // buttonSpecAny2
            // 
            this.buttonSpecAny2.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.buttonSpecAny2.UniqueName = "130bee2941b345629cbf0e4d8263e0de";
            // 
            // kryptonTextBox2
            // 
            this.kryptonTextBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kryptonTextBox2.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.btnCancelType});
            this.kryptonTextBox2.CueHint.CueHintText = "Supplier ID";
            this.kryptonTextBox2.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.kryptonTextBox2.Location = new System.Drawing.Point(618, 62);
            this.kryptonTextBox2.Name = "kryptonTextBox2";
            this.kryptonTextBox2.Size = new System.Drawing.Size(301, 31);
            this.kryptonTextBox2.TabIndex = 10;
            // 
            // btnCancelType
            // 
            this.btnCancelType.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.btnCancelType.UniqueName = "dcacd8e8f4914b0896abc134f8bfa49d";
            // 
            // txtItemID
            // 
            this.txtItemID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtItemID.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.btnItemIDCancel});
            this.txtItemID.CueHint.CueHintText = "Item ID";
            this.txtItemID.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtItemID.Location = new System.Drawing.Point(125, 17);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(301, 31);
            this.txtItemID.TabIndex = 4;
            // 
            // btnItemIDCancel
            // 
            this.btnItemIDCancel.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.btnItemIDCancel.UniqueName = "6fb900f9fa524f45950d2ef28f395a0c";
            // 
            // txtItemName
            // 
            this.txtItemName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtItemName.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.btnItemNameCancel});
            this.txtItemName.CueHint.CueHintText = "Item Name";
            this.txtItemName.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtItemName.Location = new System.Drawing.Point(125, 62);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(301, 31);
            this.txtItemName.TabIndex = 6;
            // 
            // btnItemNameCancel
            // 
            this.btnItemNameCancel.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.btnItemNameCancel.UniqueName = "130bee2941b345629cbf0e4d8263e0de";
            // 
            // AgreeFrmBPA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1055);
            this.Controls.Add(this.tlpItemSearch);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AgreeFrmBPA";
            this.Text = "YRGCPS Blanket Purchase Agreement";
            this.tlpItemSearch.ResumeLayout(false);
            this.tlpItemSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBPA)).EndInit();
            this.tlpItemSearchCriteria.ResumeLayout(false);
            this.tlpItemSearchCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCurrency)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpItemSearch;
        private Krypton.Toolkit.KryptonHeader headerSearch02;
        private Krypton.Toolkit.KryptonHeader headerSearch01;
        private Krypton.Toolkit.ButtonSpecAny btnSearch;
        private Krypton.Toolkit.ButtonSpecAny btnCancelType;
        private Krypton.Toolkit.ButtonSpecAny btnItemIDCancel;
        private Krypton.Toolkit.ButtonSpecAny btnItemNameCancel;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private Krypton.Toolkit.KryptonTextBox txtItemID;
        private Krypton.Toolkit.KryptonTextBox txtItemName;
        private System.Windows.Forms.TableLayoutPanel tlpItemSearchCriteria;
        private Krypton.Toolkit.KryptonLabel lblAgreeID;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonTextBox txtBPAID;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private Krypton.Toolkit.KryptonTextBox txtSupplierID;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny2;
        private Krypton.Toolkit.KryptonLabel lblItemName;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonComboBox cbCurrency;
        private Krypton.Toolkit.ButtonSpecAny btnCancelCurrency;
        private Krypton.Toolkit.ButtonSpecAny btnCreateBPA;
        private Krypton.Toolkit.ButtonSpecAny btnEditBPA;
        private Krypton.Toolkit.KryptonDataGridView dgvBPA;
    }
=======
﻿namespace YRG_4915M.Pages.AgreementManagement
{
    partial class AgreeFrmBPA
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
            this.dgvBPA = new Krypton.Toolkit.KryptonDataGridView();
            this.headerSearch02 = new Krypton.Toolkit.KryptonHeader();
            this.btnCreateBPA = new Krypton.Toolkit.ButtonSpecAny();
            this.btnEditBPA = new Krypton.Toolkit.ButtonSpecAny();
            this.headerSearch01 = new Krypton.Toolkit.KryptonHeader();
            this.btnSearch = new Krypton.Toolkit.ButtonSpecAny();
            this.tlpItemSearchCriteria = new System.Windows.Forms.TableLayoutPanel();
            this.lblAgreeID = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.txtBPAID = new Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny1 = new Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.cbCurrency = new Krypton.Toolkit.KryptonComboBox();
            this.btnCancelCurrency = new Krypton.Toolkit.ButtonSpecAny();
            this.lblItemName = new Krypton.Toolkit.KryptonLabel();
            this.txtSupplierID = new Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny2 = new Krypton.Toolkit.ButtonSpecAny();
            this.kryptonTextBox2 = new Krypton.Toolkit.KryptonTextBox();
            this.btnCancelType = new Krypton.Toolkit.ButtonSpecAny();
            this.txtItemID = new Krypton.Toolkit.KryptonTextBox();
            this.btnItemIDCancel = new Krypton.Toolkit.ButtonSpecAny();
            this.txtItemName = new Krypton.Toolkit.KryptonTextBox();
            this.btnItemNameCancel = new Krypton.Toolkit.ButtonSpecAny();
            this.tlpItemSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBPA)).BeginInit();
            this.tlpItemSearchCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCurrency)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpItemSearch
            // 
            this.tlpItemSearch.AutoScroll = true;
            this.tlpItemSearch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tlpItemSearch.ColumnCount = 1;
            this.tlpItemSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpItemSearch.Controls.Add(this.dgvBPA, 0, 3);
            this.tlpItemSearch.Controls.Add(this.headerSearch02, 0, 2);
            this.tlpItemSearch.Controls.Add(this.headerSearch01, 0, 0);
            this.tlpItemSearch.Controls.Add(this.tlpItemSearchCriteria, 0, 1);
            this.tlpItemSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpItemSearch.Location = new System.Drawing.Point(0, 0);
            this.tlpItemSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpItemSearch.Name = "tlpItemSearch";
            this.tlpItemSearch.RowCount = 4;
            this.tlpItemSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpItemSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpItemSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpItemSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpItemSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpItemSearch.Size = new System.Drawing.Size(1898, 1055);
            this.tlpItemSearch.TabIndex = 2;
            // 
            // dgvBPA
            // 
            this.dgvBPA.AllowUserToAddRows = false;
            this.dgvBPA.AllowUserToDeleteRows = false;
            this.dgvBPA.AllowUserToResizeRows = false;
            this.dgvBPA.ColumnHeadersHeight = 28;
            this.dgvBPA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBPA.Location = new System.Drawing.Point(3, 169);
            this.dgvBPA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBPA.Name = "dgvBPA";
            this.dgvBPA.ReadOnly = true;
            this.dgvBPA.RowHeadersWidth = 75;
            this.dgvBPA.RowTemplate.Height = 29;
            this.dgvBPA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBPA.Size = new System.Drawing.Size(1892, 884);
            this.dgvBPA.TabIndex = 3;
            // 
            // headerSearch02
            // 
            this.headerSearch02.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.btnCreateBPA,
            this.btnEditBPA});
            this.headerSearch02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerSearch02.HeaderStyle = Krypton.Toolkit.HeaderStyle.Form;
            this.headerSearch02.Location = new System.Drawing.Point(2, 121);
            this.headerSearch02.Margin = new System.Windows.Forms.Padding(2);
            this.headerSearch02.Name = "headerSearch02";
            this.headerSearch02.Size = new System.Drawing.Size(1894, 44);
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
            // btnCreateBPA
            // 
            this.btnCreateBPA.ExtraText = "Create New Blanket Purchase Agreement";
            this.btnCreateBPA.Image = global::YRG_4915M.Properties.Resources.application_form;
            this.btnCreateBPA.UniqueName = "ef9e966d34ca477fa0e5ac58e9fd086e";
            this.btnCreateBPA.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnEditBPA
            // 
            this.btnEditBPA.ExtraText = "Edit Agreement";
            this.btnEditBPA.Image = global::YRG_4915M.Properties.Resources.pencil;
            this.btnEditBPA.UniqueName = "90b8baa6439c466eb23697aaab6acec5";
            this.btnEditBPA.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // headerSearch01
            // 
            this.headerSearch01.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.btnSearch});
            this.headerSearch01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerSearch01.HeaderStyle = Krypton.Toolkit.HeaderStyle.Form;
            this.headerSearch01.Location = new System.Drawing.Point(2, 2);
            this.headerSearch01.Margin = new System.Windows.Forms.Padding(2);
            this.headerSearch01.Name = "headerSearch01";
            this.headerSearch01.Size = new System.Drawing.Size(1894, 46);
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
            // btnSearch
            // 
            this.btnSearch.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btnSearch.Image = global::YRG_4915M.Properties.Resources.magnifier;
            this.btnSearch.Text = "Search BPA";
            this.btnSearch.UniqueName = "4f6ee0408dfc46d4bc102babd366485b";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tlpItemSearchCriteria
            // 
            this.tlpItemSearchCriteria.AutoSize = true;
            this.tlpItemSearchCriteria.ColumnCount = 10;
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpItemSearchCriteria.Controls.Add(this.lblAgreeID, 0, 2);
            this.tlpItemSearchCriteria.Controls.Add(this.kryptonLabel3, 1, 1);
            this.tlpItemSearchCriteria.Controls.Add(this.txtBPAID, 2, 1);
            this.tlpItemSearchCriteria.Controls.Add(this.kryptonLabel1, 7, 1);
            this.tlpItemSearchCriteria.Controls.Add(this.cbCurrency, 8, 1);
            this.tlpItemSearchCriteria.Controls.Add(this.lblItemName, 4, 1);
            this.tlpItemSearchCriteria.Controls.Add(this.txtSupplierID, 5, 1);
            this.tlpItemSearchCriteria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpItemSearchCriteria.Location = new System.Drawing.Point(3, 52);
            this.tlpItemSearchCriteria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpItemSearchCriteria.Name = "tlpItemSearchCriteria";
            this.tlpItemSearchCriteria.RowCount = 3;
            this.tlpItemSearchCriteria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpItemSearchCriteria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpItemSearchCriteria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpItemSearchCriteria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpItemSearchCriteria.Size = new System.Drawing.Size(1892, 65);
            this.tlpItemSearchCriteria.TabIndex = 0;
            // 
            // lblAgreeID
            // 
            this.lblAgreeID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAgreeID.Location = new System.Drawing.Point(3, 59);
            this.lblAgreeID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblAgreeID.Name = "lblAgreeID";
            this.lblAgreeID.Size = new System.Drawing.Size(4, 2);
            this.lblAgreeID.TabIndex = 3;
            this.lblAgreeID.Values.Text = "";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kryptonLabel3.Location = new System.Drawing.Point(13, 18);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(68, 29);
            this.kryptonLabel3.TabIndex = 13;
            this.kryptonLabel3.Values.Text = "BPA ID";
            // 
            // txtBPAID
            // 
            this.txtBPAID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBPAID.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.txtBPAID.CueHint.CueHintText = "Agreement ID";
            this.txtBPAID.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtBPAID.Location = new System.Drawing.Point(87, 17);
            this.txtBPAID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBPAID.Name = "txtBPAID";
            this.txtBPAID.Size = new System.Drawing.Size(302, 31);
            this.txtBPAID.TabIndex = 14;
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.buttonSpecAny1.UniqueName = "6fb900f9fa524f45950d2ef28f395a0c";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kryptonLabel1.Location = new System.Drawing.Point(892, 18);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(85, 29);
            this.kryptonLabel1.TabIndex = 17;
            this.kryptonLabel1.Values.Text = "Currency";
            // 
            // cbCurrency
            // 
            this.cbCurrency.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbCurrency.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.btnCancelCurrency});
            this.cbCurrency.CornerRoundingRadius = -1F;
            this.cbCurrency.CueHint.CueHintText = "Currency";
            this.cbCurrency.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.cbCurrency.DropDownWidth = 301;
            this.cbCurrency.IntegralHeight = false;
            this.cbCurrency.Location = new System.Drawing.Point(983, 18);
            this.cbCurrency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Size = new System.Drawing.Size(256, 29);
            this.cbCurrency.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbCurrency.TabIndex = 18;
            // 
            // btnCancelCurrency
            // 
            this.btnCancelCurrency.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btnCancelCurrency.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.btnCancelCurrency.UniqueName = "da40efd0712f418d89fc8b607d76bcda";
            // 
            // lblItemName
            // 
            this.lblItemName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblItemName.Location = new System.Drawing.Point(435, 18);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(103, 29);
            this.lblItemName.TabIndex = 16;
            this.lblItemName.Values.Text = "Supplier ID";
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSupplierID.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny2});
            this.txtSupplierID.CueHint.CueHintText = "Supplier ID";
            this.txtSupplierID.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtSupplierID.Location = new System.Drawing.Point(544, 17);
            this.txtSupplierID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Size = new System.Drawing.Size(302, 31);
            this.txtSupplierID.TabIndex = 15;
            // 
            // buttonSpecAny2
            // 
            this.buttonSpecAny2.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.buttonSpecAny2.UniqueName = "130bee2941b345629cbf0e4d8263e0de";
            // 
            // kryptonTextBox2
            // 
            this.kryptonTextBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kryptonTextBox2.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.btnCancelType});
            this.kryptonTextBox2.CueHint.CueHintText = "Supplier ID";
            this.kryptonTextBox2.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.kryptonTextBox2.Location = new System.Drawing.Point(618, 62);
            this.kryptonTextBox2.Name = "kryptonTextBox2";
            this.kryptonTextBox2.Size = new System.Drawing.Size(301, 31);
            this.kryptonTextBox2.TabIndex = 10;
            // 
            // btnCancelType
            // 
            this.btnCancelType.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.btnCancelType.UniqueName = "dcacd8e8f4914b0896abc134f8bfa49d";
            // 
            // txtItemID
            // 
            this.txtItemID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtItemID.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.btnItemIDCancel});
            this.txtItemID.CueHint.CueHintText = "Item ID";
            this.txtItemID.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtItemID.Location = new System.Drawing.Point(125, 17);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(301, 31);
            this.txtItemID.TabIndex = 4;
            // 
            // btnItemIDCancel
            // 
            this.btnItemIDCancel.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.btnItemIDCancel.UniqueName = "6fb900f9fa524f45950d2ef28f395a0c";
            // 
            // txtItemName
            // 
            this.txtItemName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtItemName.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.btnItemNameCancel});
            this.txtItemName.CueHint.CueHintText = "Item Name";
            this.txtItemName.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtItemName.Location = new System.Drawing.Point(125, 62);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(301, 31);
            this.txtItemName.TabIndex = 6;
            // 
            // btnItemNameCancel
            // 
            this.btnItemNameCancel.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.btnItemNameCancel.UniqueName = "130bee2941b345629cbf0e4d8263e0de";
            // 
            // AgreeFrmBPA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1055);
            this.Controls.Add(this.tlpItemSearch);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AgreeFrmBPA";
            this.Text = "YRGCPS Blanket Purchase Agreement";
            this.tlpItemSearch.ResumeLayout(false);
            this.tlpItemSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBPA)).EndInit();
            this.tlpItemSearchCriteria.ResumeLayout(false);
            this.tlpItemSearchCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCurrency)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpItemSearch;
        private Krypton.Toolkit.KryptonHeader headerSearch02;
        private Krypton.Toolkit.KryptonHeader headerSearch01;
        private Krypton.Toolkit.ButtonSpecAny btnSearch;
        private Krypton.Toolkit.ButtonSpecAny btnCancelType;
        private Krypton.Toolkit.ButtonSpecAny btnItemIDCancel;
        private Krypton.Toolkit.ButtonSpecAny btnItemNameCancel;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private Krypton.Toolkit.KryptonTextBox txtItemID;
        private Krypton.Toolkit.KryptonTextBox txtItemName;
        private System.Windows.Forms.TableLayoutPanel tlpItemSearchCriteria;
        private Krypton.Toolkit.KryptonLabel lblAgreeID;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonTextBox txtBPAID;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private Krypton.Toolkit.KryptonTextBox txtSupplierID;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny2;
        private Krypton.Toolkit.KryptonLabel lblItemName;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonComboBox cbCurrency;
        private Krypton.Toolkit.ButtonSpecAny btnCancelCurrency;
        private Krypton.Toolkit.ButtonSpecAny btnCreateBPA;
        private Krypton.Toolkit.ButtonSpecAny btnEditBPA;
        private Krypton.Toolkit.KryptonDataGridView dgvBPA;
    }
>>>>>>> e3039030246399001b6a193ac0434d0ab124b1f7
}