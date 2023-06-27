namespace YRG_4915M.Pages.ItemManagement
{
    partial class ItemFrmMinor
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
            this.btnDeleteRow = new Krypton.Toolkit.ButtonSpecAny();
            this.btnSave = new Krypton.Toolkit.ButtonSpecAny();
            this.btnAddRow = new Krypton.Toolkit.ButtonSpecAny();
            this.btnSearch = new Krypton.Toolkit.ButtonSpecAny();
            this.tlpItemSearchCriteria = new System.Windows.Forms.TableLayoutPanel();
            this.txtItemName = new Krypton.Toolkit.KryptonTextBox();
            this.btnItemNameCancel = new Krypton.Toolkit.ButtonSpecAny();
            this.lblItemID = new Krypton.Toolkit.KryptonLabel();
            this.lblItemName = new Krypton.Toolkit.KryptonLabel();
            this.txtItemID = new Krypton.Toolkit.KryptonTextBox();
            this.btnItemIDCancel = new Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.lblStock = new Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBox2 = new Krypton.Toolkit.KryptonTextBox();
            this.btnCancelType = new Krypton.Toolkit.ButtonSpecAny();
            this.kryptonComboBox1 = new Krypton.Toolkit.KryptonComboBox();
            this.dgvItemMinor = new Krypton.Toolkit.KryptonDataGridView();
            this.tlpItemSearch.SuspendLayout();
            this.tlpItemSearchCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemMinor)).BeginInit();
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
            this.tlpItemSearch.Controls.Add(this.dgvItemMinor, 0, 3);
            this.tlpItemSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpItemSearch.Location = new System.Drawing.Point(0, 0);
            this.tlpItemSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpItemSearch.Name = "tlpItemSearch";
            this.tlpItemSearch.RowCount = 4;
            this.tlpItemSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpItemSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpItemSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpItemSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpItemSearch.Size = new System.Drawing.Size(1687, 844);
            this.tlpItemSearch.TabIndex = 1;
            // 
            // headerSearch02
            // 
            this.headerSearch02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerSearch02.HeaderStyle = Krypton.Toolkit.HeaderStyle.Form;
            this.headerSearch02.Location = new System.Drawing.Point(2, 144);
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
            this.btnDeleteRow,
            this.btnSave,
            this.btnAddRow,
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
            // btnDeleteRow
            // 
            this.btnDeleteRow.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btnDeleteRow.Image = global::YRG_4915M.Properties.Resources.table_row_delete;
            this.btnDeleteRow.Text = "Delete Row";
            this.btnDeleteRow.UniqueName = "f1623fd434544a5d9426150223303d5c";
            this.btnDeleteRow.Click += new System.EventHandler(this.btnDeleteRow_Click);
            // 
            // btnSave
            // 
            this.btnSave.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btnSave.Image = global::YRG_4915M.Properties.Resources.disk;
            this.btnSave.Text = "Save Edit";
            this.btnSave.UniqueName = "5f72cac27edd4f43b9f57935fbd6295b";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddRow
            // 
            this.btnAddRow.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btnAddRow.Image = global::YRG_4915M.Properties.Resources.table_row_insert;
            this.btnAddRow.Text = "Add Row";
            this.btnAddRow.UniqueName = "f0604e4c510c41bfbbecb40b8d7e1c83";
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btnSearch.Image = global::YRG_4915M.Properties.Resources.magnifier;
            this.btnSearch.Text = "Search";
            this.btnSearch.UniqueName = "4f6ee0408dfc46d4bc102babd366485b";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tlpItemSearchCriteria
            // 
            this.tlpItemSearchCriteria.AutoSize = true;
            this.tlpItemSearchCriteria.ColumnCount = 7;
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpItemSearchCriteria.Controls.Add(this.txtItemName, 2, 2);
            this.tlpItemSearchCriteria.Controls.Add(this.lblItemID, 1, 1);
            this.tlpItemSearchCriteria.Controls.Add(this.lblItemName, 1, 2);
            this.tlpItemSearchCriteria.Controls.Add(this.txtItemID, 2, 1);
            this.tlpItemSearchCriteria.Controls.Add(this.kryptonLabel1, 4, 1);
            this.tlpItemSearchCriteria.Controls.Add(this.lblStock, 4, 2);
            this.tlpItemSearchCriteria.Controls.Add(this.kryptonTextBox2, 5, 2);
            this.tlpItemSearchCriteria.Controls.Add(this.kryptonComboBox1, 5, 1);
            this.tlpItemSearchCriteria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpItemSearchCriteria.Location = new System.Drawing.Point(3, 52);
            this.tlpItemSearchCriteria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpItemSearchCriteria.Name = "tlpItemSearchCriteria";
            this.tlpItemSearchCriteria.RowCount = 4;
            this.tlpItemSearchCriteria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpItemSearchCriteria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpItemSearchCriteria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpItemSearchCriteria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpItemSearchCriteria.Size = new System.Drawing.Size(1681, 88);
            this.tlpItemSearchCriteria.TabIndex = 0;
            // 
            // txtItemName
            // 
            this.txtItemName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtItemName.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.btnItemNameCancel});
            this.txtItemName.CueHint.CueHintText = "Item Name";
            this.txtItemName.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtItemName.Location = new System.Drawing.Point(107, 48);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(268, 27);
            this.txtItemName.TabIndex = 6;
            // 
            // btnItemNameCancel
            // 
            this.btnItemNameCancel.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.btnItemNameCancel.UniqueName = "130bee2941b345629cbf0e4d8263e0de";
            // 
            // lblItemID
            // 
            this.lblItemID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblItemID.Location = new System.Drawing.Point(12, 14);
            this.lblItemID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(64, 24);
            this.lblItemID.TabIndex = 3;
            this.lblItemID.Values.Text = "Item_ID";
            // 
            // lblItemName
            // 
            this.lblItemName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblItemName.Location = new System.Drawing.Point(12, 50);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(89, 24);
            this.lblItemName.TabIndex = 2;
            this.lblItemName.Values.Text = "Item_Name";
            // 
            // txtItemID
            // 
            this.txtItemID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtItemID.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.btnItemIDCancel});
            this.txtItemID.CueHint.CueHintText = "Item ID";
            this.txtItemID.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtItemID.Location = new System.Drawing.Point(107, 12);
            this.txtItemID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(268, 27);
            this.txtItemID.TabIndex = 4;
            // 
            // btnItemIDCancel
            // 
            this.btnItemIDCancel.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.btnItemIDCancel.UniqueName = "6fb900f9fa524f45950d2ef28f395a0c";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(448, 10);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(81, 24);
            this.kryptonLabel1.TabIndex = 7;
            this.kryptonLabel1.Values.Text = "Item_Type";
            // 
            // lblStock
            // 
            this.lblStock.Location = new System.Drawing.Point(448, 46);
            this.lblStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(49, 24);
            this.lblStock.TabIndex = 8;
            this.lblStock.Values.Text = "Stock";
            // 
            // kryptonTextBox2
            // 
            this.kryptonTextBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kryptonTextBox2.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.btnCancelType});
            this.kryptonTextBox2.CueHint.CueHintText = "Stock";
            this.kryptonTextBox2.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.kryptonTextBox2.Location = new System.Drawing.Point(535, 48);
            this.kryptonTextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonTextBox2.Name = "kryptonTextBox2";
            this.kryptonTextBox2.Size = new System.Drawing.Size(268, 27);
            this.kryptonTextBox2.TabIndex = 10;
            // 
            // btnCancelType
            // 
            this.btnCancelType.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.btnCancelType.UniqueName = "dcacd8e8f4914b0896abc134f8bfa49d";
            // 
            // kryptonComboBox1
            // 
            this.kryptonComboBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kryptonComboBox1.CornerRoundingRadius = -1F;
            this.kryptonComboBox1.DropDownWidth = 301;
            this.kryptonComboBox1.IntegralHeight = false;
            this.kryptonComboBox1.Location = new System.Drawing.Point(535, 13);
            this.kryptonComboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonComboBox1.Name = "kryptonComboBox1";
            this.kryptonComboBox1.Size = new System.Drawing.Size(268, 25);
            this.kryptonComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonComboBox1.TabIndex = 11;
            this.kryptonComboBox1.Text = "Item Type";
            // 
            // dgvItemMinor
            // 
            this.dgvItemMinor.AllowUserToAddRows = false;
            this.dgvItemMinor.AllowUserToDeleteRows = false;
            this.dgvItemMinor.AllowUserToResizeRows = false;
            this.dgvItemMinor.ColumnHeadersHeight = 28;
            this.dgvItemMinor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItemMinor.Location = new System.Drawing.Point(3, 192);
            this.dgvItemMinor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvItemMinor.Name = "dgvItemMinor";
            this.dgvItemMinor.ReadOnly = true;
            this.dgvItemMinor.RowHeadersWidth = 75;
            this.dgvItemMinor.RowTemplate.Height = 29;
            this.dgvItemMinor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemMinor.Size = new System.Drawing.Size(1681, 650);
            this.dgvItemMinor.TabIndex = 2;
            this.dgvItemMinor.MultiSelectChanged += new System.EventHandler(this.dgvItemMinor_MultiSelectChanged);
            this.dgvItemMinor.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvItemMinor_CellMouseUp);
            this.dgvItemMinor.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvItemMinor_CellMouseUp);
            // 
            // ItemFrmMinor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1687, 844);
            this.Controls.Add(this.tlpItemSearch);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ItemFrmMinor";
            this.Text = "YRGCPS Item Management Minor";
            this.tlpItemSearch.ResumeLayout(false);
            this.tlpItemSearch.PerformLayout();
            this.tlpItemSearchCriteria.ResumeLayout(false);
            this.tlpItemSearchCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemMinor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpItemSearch;
        private Krypton.Toolkit.KryptonHeader headerSearch02;
        private Krypton.Toolkit.KryptonHeader headerSearch01;
        private Krypton.Toolkit.ButtonSpecAny btnDeleteRow;
        private Krypton.Toolkit.ButtonSpecAny btnAddRow;
        private Krypton.Toolkit.ButtonSpecAny btnSave;
        private Krypton.Toolkit.ButtonSpecAny btnSearch;
        private System.Windows.Forms.TableLayoutPanel tlpItemSearchCriteria;
        private Krypton.Toolkit.KryptonTextBox txtItemName;
        private Krypton.Toolkit.ButtonSpecAny btnItemNameCancel;
        private Krypton.Toolkit.KryptonLabel lblItemID;
        private Krypton.Toolkit.KryptonLabel lblItemName;
        private Krypton.Toolkit.KryptonTextBox txtItemID;
        private Krypton.Toolkit.ButtonSpecAny btnItemIDCancel;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel lblStock;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private Krypton.Toolkit.ButtonSpecAny btnCancelType;
        private Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
        private Krypton.Toolkit.KryptonDataGridView dgvItemMinor;
    }
}