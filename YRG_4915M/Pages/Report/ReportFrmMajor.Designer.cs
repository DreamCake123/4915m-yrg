<<<<<<< HEAD
﻿namespace YRG_4915M.Pages.Report
{
    partial class ReportFrmMajor
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
            this.headerSearch02 = new Krypton.Toolkit.KryptonHeader();
            this.headerSearch01 = new Krypton.Toolkit.KryptonHeader();
            this.btnSearch = new Krypton.Toolkit.ButtonSpecAny();
            this.tlpItemSearchCriteria = new System.Windows.Forms.TableLayoutPanel();
            this.txtSuppId = new Krypton.Toolkit.KryptonTextBox();
            this.btnItemNameCancel = new Krypton.Toolkit.ButtonSpecAny();
            this.lblItemName = new Krypton.Toolkit.KryptonLabel();
            this.txtAgreeId = new Krypton.Toolkit.KryptonTextBox();
            this.btnItemIDCancel = new Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.cbAgreeType = new Krypton.Toolkit.KryptonComboBox();
            this.lblAgreeID = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.cbCurrency = new Krypton.Toolkit.KryptonComboBox();
            this.dgvAgreement = new Krypton.Toolkit.KryptonDataGridView();
            this.tlpItemSearch.SuspendLayout();
            this.tlpItemSearchCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbAgreeType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgreement)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpItemSearch
            // 
            this.tlpItemSearch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tlpItemSearch.ColumnCount = 1;
            this.tlpItemSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpItemSearch.Controls.Add(this.headerSearch02, 0, 2);
            this.tlpItemSearch.Controls.Add(this.headerSearch01, 0, 0);
            this.tlpItemSearch.Controls.Add(this.tlpItemSearchCriteria, 0, 1);
            this.tlpItemSearch.Controls.Add(this.dgvAgreement, 0, 3);
            this.tlpItemSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpItemSearch.Location = new System.Drawing.Point(0, 0);
            this.tlpItemSearch.Name = "tlpItemSearch";
            this.tlpItemSearch.RowCount = 4;
            this.tlpItemSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpItemSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpItemSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpItemSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpItemSearch.Size = new System.Drawing.Size(1898, 1370);
            this.tlpItemSearch.TabIndex = 4;
            // 
            // headerSearch02
            // 
            this.headerSearch02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerSearch02.HeaderStyle = Krypton.Toolkit.HeaderStyle.Form;
            this.headerSearch02.Location = new System.Drawing.Point(2, 168);
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
            this.btnSearch.Text = "Search";
            this.btnSearch.UniqueName = "4f6ee0408dfc46d4bc102babd366485b";
            // 
            // tlpItemSearchCriteria
            // 
            this.tlpItemSearchCriteria.AutoSize = true;
            this.tlpItemSearchCriteria.ColumnCount = 7;
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpItemSearchCriteria.Controls.Add(this.txtSuppId, 2, 2);
            this.tlpItemSearchCriteria.Controls.Add(this.lblItemName, 1, 2);
            this.tlpItemSearchCriteria.Controls.Add(this.txtAgreeId, 2, 1);
            this.tlpItemSearchCriteria.Controls.Add(this.kryptonLabel1, 4, 1);
            this.tlpItemSearchCriteria.Controls.Add(this.kryptonLabel2, 4, 2);
            this.tlpItemSearchCriteria.Controls.Add(this.cbAgreeType, 5, 1);
            this.tlpItemSearchCriteria.Controls.Add(this.lblAgreeID, 0, 3);
            this.tlpItemSearchCriteria.Controls.Add(this.kryptonLabel3, 1, 1);
            this.tlpItemSearchCriteria.Controls.Add(this.cbCurrency, 5, 2);
            this.tlpItemSearchCriteria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpItemSearchCriteria.Location = new System.Drawing.Point(3, 53);
            this.tlpItemSearchCriteria.Name = "tlpItemSearchCriteria";
            this.tlpItemSearchCriteria.RowCount = 4;
            this.tlpItemSearchCriteria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpItemSearchCriteria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpItemSearchCriteria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpItemSearchCriteria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpItemSearchCriteria.Size = new System.Drawing.Size(1892, 110);
            this.tlpItemSearchCriteria.TabIndex = 0;
            // 
            // txtSuppId
            // 
            this.txtSuppId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSuppId.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.btnItemNameCancel});
            this.txtSuppId.CueHint.CueHintText = "Supplier ID";
            this.txtSuppId.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtSuppId.Location = new System.Drawing.Point(146, 62);
            this.txtSuppId.Name = "txtSuppId";
            this.txtSuppId.Size = new System.Drawing.Size(301, 31);
            this.txtSuppId.TabIndex = 6;
            // 
            // btnItemNameCancel
            // 
            this.btnItemNameCancel.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.btnItemNameCancel.UniqueName = "130bee2941b345629cbf0e4d8263e0de";
            // 
            // lblItemName
            // 
            this.lblItemName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblItemName.Location = new System.Drawing.Point(13, 63);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(103, 29);
            this.lblItemName.TabIndex = 2;
            this.lblItemName.Values.Text = "Supplier ID";
            // 
            // txtAgreeId
            // 
            this.txtAgreeId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAgreeId.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.btnItemIDCancel});
            this.txtAgreeId.CueHint.CueHintText = "Agreement ID";
            this.txtAgreeId.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtAgreeId.Location = new System.Drawing.Point(146, 17);
            this.txtAgreeId.Name = "txtAgreeId";
            this.txtAgreeId.Size = new System.Drawing.Size(301, 31);
            this.txtAgreeId.TabIndex = 4;
            // 
            // btnItemIDCancel
            // 
            this.btnItemIDCancel.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.btnItemIDCancel.UniqueName = "6fb900f9fa524f45950d2ef28f395a0c";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kryptonLabel1.Location = new System.Drawing.Point(528, 18);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(148, 29);
            this.kryptonLabel1.TabIndex = 7;
            this.kryptonLabel1.Values.Text = "Agreement Type";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kryptonLabel2.Location = new System.Drawing.Point(528, 63);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(85, 29);
            this.kryptonLabel2.TabIndex = 8;
            this.kryptonLabel2.Values.Text = "Currency";
            // 
            // cbAgreeType
            // 
            this.cbAgreeType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbAgreeType.CornerRoundingRadius = -1F;
            this.cbAgreeType.CueHint.CueHintText = "Agreement Type";
            this.cbAgreeType.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.cbAgreeType.DropDownWidth = 301;
            this.cbAgreeType.IntegralHeight = false;
            this.cbAgreeType.Location = new System.Drawing.Point(682, 18);
            this.cbAgreeType.Name = "cbAgreeType";
            this.cbAgreeType.Size = new System.Drawing.Size(257, 29);
            this.cbAgreeType.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbAgreeType.TabIndex = 11;
            // 
            // lblAgreeID
            // 
            this.lblAgreeID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAgreeID.Location = new System.Drawing.Point(3, 104);
            this.lblAgreeID.Name = "lblAgreeID";
            this.lblAgreeID.Size = new System.Drawing.Size(4, 2);
            this.lblAgreeID.TabIndex = 3;
            this.lblAgreeID.Values.Text = "";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kryptonLabel3.Location = new System.Drawing.Point(13, 18);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(127, 29);
            this.kryptonLabel3.TabIndex = 12;
            this.kryptonLabel3.Values.Text = "Agreement ID";
            // 
            // cbCurrency
            // 
            this.cbCurrency.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbCurrency.CornerRoundingRadius = -1F;
            this.cbCurrency.CueHint.CueHintText = "Currency";
            this.cbCurrency.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.cbCurrency.DropDownWidth = 301;
            this.cbCurrency.IntegralHeight = false;
            this.cbCurrency.Location = new System.Drawing.Point(682, 63);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Size = new System.Drawing.Size(257, 29);
            this.cbCurrency.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbCurrency.TabIndex = 13;
            // 
            // dgvAgreement
            // 
            this.dgvAgreement.AllowUserToAddRows = false;
            this.dgvAgreement.AllowUserToDeleteRows = false;
            this.dgvAgreement.AllowUserToResizeRows = false;
            this.dgvAgreement.ColumnHeadersHeight = 28;
            this.dgvAgreement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAgreement.Location = new System.Drawing.Point(3, 217);
            this.dgvAgreement.Name = "dgvAgreement";
            this.dgvAgreement.RowHeadersWidth = 75;
            this.dgvAgreement.RowTemplate.Height = 29;
            this.dgvAgreement.Size = new System.Drawing.Size(1892, 1150);
            this.dgvAgreement.TabIndex = 2;
            // 
            // ReportFrmMajor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1898, 1370);
            this.Controls.Add(this.tlpItemSearch);
            this.Name = "ReportFrmMajor";
            this.Text = "YRGCPS Report Major";
            this.tlpItemSearch.ResumeLayout(false);
            this.tlpItemSearch.PerformLayout();
            this.tlpItemSearchCriteria.ResumeLayout(false);
            this.tlpItemSearchCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbAgreeType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgreement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpItemSearch;
        private Krypton.Toolkit.KryptonHeader headerSearch02;
        private Krypton.Toolkit.KryptonHeader headerSearch01;
        private Krypton.Toolkit.ButtonSpecAny btnSearch;
        private System.Windows.Forms.TableLayoutPanel tlpItemSearchCriteria;
        private Krypton.Toolkit.KryptonTextBox txtSuppId;
        private Krypton.Toolkit.ButtonSpecAny btnItemNameCancel;
        private Krypton.Toolkit.KryptonLabel lblItemName;
        private Krypton.Toolkit.KryptonTextBox txtAgreeId;
        private Krypton.Toolkit.ButtonSpecAny btnItemIDCancel;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonComboBox cbAgreeType;
        private Krypton.Toolkit.KryptonLabel lblAgreeID;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonComboBox cbCurrency;
        private Krypton.Toolkit.KryptonDataGridView dgvAgreement;
    }
=======
﻿namespace YRG_4915M.Pages.Report
{
    partial class ReportFrmMajor
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
            this.headerSearch02 = new Krypton.Toolkit.KryptonHeader();
            this.headerSearch01 = new Krypton.Toolkit.KryptonHeader();
            this.btnSearch = new Krypton.Toolkit.ButtonSpecAny();
            this.tlpItemSearchCriteria = new System.Windows.Forms.TableLayoutPanel();
            this.txtSuppId = new Krypton.Toolkit.KryptonTextBox();
            this.btnItemNameCancel = new Krypton.Toolkit.ButtonSpecAny();
            this.lblItemName = new Krypton.Toolkit.KryptonLabel();
            this.txtAgreeId = new Krypton.Toolkit.KryptonTextBox();
            this.btnItemIDCancel = new Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.cbAgreeType = new Krypton.Toolkit.KryptonComboBox();
            this.lblAgreeID = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.cbCurrency = new Krypton.Toolkit.KryptonComboBox();
            this.dgvAgreement = new Krypton.Toolkit.KryptonDataGridView();
            this.tlpItemSearch.SuspendLayout();
            this.tlpItemSearchCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbAgreeType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgreement)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpItemSearch
            // 
            this.tlpItemSearch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tlpItemSearch.ColumnCount = 1;
            this.tlpItemSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpItemSearch.Controls.Add(this.headerSearch02, 0, 2);
            this.tlpItemSearch.Controls.Add(this.headerSearch01, 0, 0);
            this.tlpItemSearch.Controls.Add(this.tlpItemSearchCriteria, 0, 1);
            this.tlpItemSearch.Controls.Add(this.dgvAgreement, 0, 3);
            this.tlpItemSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpItemSearch.Location = new System.Drawing.Point(0, 0);
            this.tlpItemSearch.Name = "tlpItemSearch";
            this.tlpItemSearch.RowCount = 4;
            this.tlpItemSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpItemSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpItemSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpItemSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpItemSearch.Size = new System.Drawing.Size(1898, 1370);
            this.tlpItemSearch.TabIndex = 4;
            // 
            // headerSearch02
            // 
            this.headerSearch02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerSearch02.HeaderStyle = Krypton.Toolkit.HeaderStyle.Form;
            this.headerSearch02.Location = new System.Drawing.Point(2, 168);
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
            this.btnSearch.Text = "Search";
            this.btnSearch.UniqueName = "4f6ee0408dfc46d4bc102babd366485b";
            // 
            // tlpItemSearchCriteria
            // 
            this.tlpItemSearchCriteria.AutoSize = true;
            this.tlpItemSearchCriteria.ColumnCount = 7;
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpItemSearchCriteria.Controls.Add(this.txtSuppId, 2, 2);
            this.tlpItemSearchCriteria.Controls.Add(this.lblItemName, 1, 2);
            this.tlpItemSearchCriteria.Controls.Add(this.txtAgreeId, 2, 1);
            this.tlpItemSearchCriteria.Controls.Add(this.kryptonLabel1, 4, 1);
            this.tlpItemSearchCriteria.Controls.Add(this.kryptonLabel2, 4, 2);
            this.tlpItemSearchCriteria.Controls.Add(this.cbAgreeType, 5, 1);
            this.tlpItemSearchCriteria.Controls.Add(this.lblAgreeID, 0, 3);
            this.tlpItemSearchCriteria.Controls.Add(this.kryptonLabel3, 1, 1);
            this.tlpItemSearchCriteria.Controls.Add(this.cbCurrency, 5, 2);
            this.tlpItemSearchCriteria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpItemSearchCriteria.Location = new System.Drawing.Point(3, 53);
            this.tlpItemSearchCriteria.Name = "tlpItemSearchCriteria";
            this.tlpItemSearchCriteria.RowCount = 4;
            this.tlpItemSearchCriteria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpItemSearchCriteria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpItemSearchCriteria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpItemSearchCriteria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpItemSearchCriteria.Size = new System.Drawing.Size(1892, 110);
            this.tlpItemSearchCriteria.TabIndex = 0;
            // 
            // txtSuppId
            // 
            this.txtSuppId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSuppId.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.btnItemNameCancel});
            this.txtSuppId.CueHint.CueHintText = "Supplier ID";
            this.txtSuppId.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtSuppId.Location = new System.Drawing.Point(146, 62);
            this.txtSuppId.Name = "txtSuppId";
            this.txtSuppId.Size = new System.Drawing.Size(301, 31);
            this.txtSuppId.TabIndex = 6;
            // 
            // btnItemNameCancel
            // 
            this.btnItemNameCancel.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.btnItemNameCancel.UniqueName = "130bee2941b345629cbf0e4d8263e0de";
            // 
            // lblItemName
            // 
            this.lblItemName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblItemName.Location = new System.Drawing.Point(13, 63);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(103, 29);
            this.lblItemName.TabIndex = 2;
            this.lblItemName.Values.Text = "Supplier ID";
            // 
            // txtAgreeId
            // 
            this.txtAgreeId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAgreeId.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.btnItemIDCancel});
            this.txtAgreeId.CueHint.CueHintText = "Agreement ID";
            this.txtAgreeId.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtAgreeId.Location = new System.Drawing.Point(146, 17);
            this.txtAgreeId.Name = "txtAgreeId";
            this.txtAgreeId.Size = new System.Drawing.Size(301, 31);
            this.txtAgreeId.TabIndex = 4;
            // 
            // btnItemIDCancel
            // 
            this.btnItemIDCancel.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.btnItemIDCancel.UniqueName = "6fb900f9fa524f45950d2ef28f395a0c";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kryptonLabel1.Location = new System.Drawing.Point(528, 18);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(148, 29);
            this.kryptonLabel1.TabIndex = 7;
            this.kryptonLabel1.Values.Text = "Agreement Type";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kryptonLabel2.Location = new System.Drawing.Point(528, 63);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(85, 29);
            this.kryptonLabel2.TabIndex = 8;
            this.kryptonLabel2.Values.Text = "Currency";
            // 
            // cbAgreeType
            // 
            this.cbAgreeType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbAgreeType.CornerRoundingRadius = -1F;
            this.cbAgreeType.CueHint.CueHintText = "Agreement Type";
            this.cbAgreeType.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.cbAgreeType.DropDownWidth = 301;
            this.cbAgreeType.IntegralHeight = false;
            this.cbAgreeType.Location = new System.Drawing.Point(682, 18);
            this.cbAgreeType.Name = "cbAgreeType";
            this.cbAgreeType.Size = new System.Drawing.Size(257, 29);
            this.cbAgreeType.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbAgreeType.TabIndex = 11;
            // 
            // lblAgreeID
            // 
            this.lblAgreeID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAgreeID.Location = new System.Drawing.Point(3, 104);
            this.lblAgreeID.Name = "lblAgreeID";
            this.lblAgreeID.Size = new System.Drawing.Size(4, 2);
            this.lblAgreeID.TabIndex = 3;
            this.lblAgreeID.Values.Text = "";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kryptonLabel3.Location = new System.Drawing.Point(13, 18);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(127, 29);
            this.kryptonLabel3.TabIndex = 12;
            this.kryptonLabel3.Values.Text = "Agreement ID";
            // 
            // cbCurrency
            // 
            this.cbCurrency.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbCurrency.CornerRoundingRadius = -1F;
            this.cbCurrency.CueHint.CueHintText = "Currency";
            this.cbCurrency.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.cbCurrency.DropDownWidth = 301;
            this.cbCurrency.IntegralHeight = false;
            this.cbCurrency.Location = new System.Drawing.Point(682, 63);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Size = new System.Drawing.Size(257, 29);
            this.cbCurrency.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbCurrency.TabIndex = 13;
            // 
            // dgvAgreement
            // 
            this.dgvAgreement.AllowUserToAddRows = false;
            this.dgvAgreement.AllowUserToDeleteRows = false;
            this.dgvAgreement.AllowUserToResizeRows = false;
            this.dgvAgreement.ColumnHeadersHeight = 28;
            this.dgvAgreement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAgreement.Location = new System.Drawing.Point(3, 217);
            this.dgvAgreement.Name = "dgvAgreement";
            this.dgvAgreement.RowHeadersWidth = 75;
            this.dgvAgreement.RowTemplate.Height = 29;
            this.dgvAgreement.Size = new System.Drawing.Size(1892, 1150);
            this.dgvAgreement.TabIndex = 2;
            // 
            // ReportFrmMajor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1898, 1370);
            this.Controls.Add(this.tlpItemSearch);
            this.Name = "ReportFrmMajor";
            this.Text = "YRGCPS Report Major";
            this.tlpItemSearch.ResumeLayout(false);
            this.tlpItemSearch.PerformLayout();
            this.tlpItemSearchCriteria.ResumeLayout(false);
            this.tlpItemSearchCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbAgreeType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgreement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpItemSearch;
        private Krypton.Toolkit.KryptonHeader headerSearch02;
        private Krypton.Toolkit.KryptonHeader headerSearch01;
        private Krypton.Toolkit.ButtonSpecAny btnSearch;
        private System.Windows.Forms.TableLayoutPanel tlpItemSearchCriteria;
        private Krypton.Toolkit.KryptonTextBox txtSuppId;
        private Krypton.Toolkit.ButtonSpecAny btnItemNameCancel;
        private Krypton.Toolkit.KryptonLabel lblItemName;
        private Krypton.Toolkit.KryptonTextBox txtAgreeId;
        private Krypton.Toolkit.ButtonSpecAny btnItemIDCancel;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonComboBox cbAgreeType;
        private Krypton.Toolkit.KryptonLabel lblAgreeID;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonComboBox cbCurrency;
        private Krypton.Toolkit.KryptonDataGridView dgvAgreement;
    }
>>>>>>> e3039030246399001b6a193ac0434d0ab124b1f7
}