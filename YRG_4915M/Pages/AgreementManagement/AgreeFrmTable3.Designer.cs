namespace YRG_4915M.Pages.AgreementManagement
{
    partial class AgreeFrmTable3
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
            this.dgvCPA = new Krypton.Toolkit.KryptonDataGridView();
            this.headerSearch02 = new Krypton.Toolkit.KryptonHeader();
            this.btnCreate = new Krypton.Toolkit.ButtonSpecAny();
            this.btnEdit = new Krypton.Toolkit.ButtonSpecAny();
            this.headerSearch01 = new Krypton.Toolkit.KryptonHeader();
            this.btnSearch = new Krypton.Toolkit.ButtonSpecAny();
            this.tlpItemSearchCriteria = new System.Windows.Forms.TableLayoutPanel();
            this.lblAgreeID = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.txtAgreeId = new Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny1 = new Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.cbCurrency = new Krypton.Toolkit.KryptonComboBox();
            this.btnCancelCurrency = new Krypton.Toolkit.ButtonSpecAny();
            this.lblItemName = new Krypton.Toolkit.KryptonLabel();
            this.txtSuppId = new Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny2 = new Krypton.Toolkit.ButtonSpecAny();
            this.tlpItemSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCPA)).BeginInit();
            this.tlpItemSearchCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCurrency)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpItemSearch
            // 
            this.tlpItemSearch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tlpItemSearch.ColumnCount = 1;
            this.tlpItemSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpItemSearch.Controls.Add(this.dgvCPA, 0, 3);
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
            this.tlpItemSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpItemSearch.Size = new System.Drawing.Size(1687, 844);
            this.tlpItemSearch.TabIndex = 3;
            // 
            // dgvCPA
            // 
            this.dgvCPA.AllowUserToAddRows = false;
            this.dgvCPA.AllowUserToDeleteRows = false;
            this.dgvCPA.AllowUserToResizeRows = false;
            this.dgvCPA.ColumnHeadersHeight = 28;
            this.dgvCPA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCPA.Location = new System.Drawing.Point(3, 156);
            this.dgvCPA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCPA.Name = "dgvCPA";
            this.dgvCPA.ReadOnly = true;
            this.dgvCPA.RowHeadersWidth = 75;
            this.dgvCPA.RowTemplate.Height = 29;
            this.dgvCPA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCPA.Size = new System.Drawing.Size(1681, 686);
            this.dgvCPA.TabIndex = 3;
            // 
            // headerSearch02
            // 
            this.headerSearch02.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.btnCreate,
            this.btnEdit});
            this.headerSearch02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerSearch02.HeaderStyle = Krypton.Toolkit.HeaderStyle.Form;
            this.headerSearch02.Location = new System.Drawing.Point(2, 108);
            this.headerSearch02.Margin = new System.Windows.Forms.Padding(2);
            this.headerSearch02.Name = "headerSearch02";
            this.headerSearch02.Size = new System.Drawing.Size(1683, 44);
            this.headerSearch02.StateCommon.Border.Color1 = System.Drawing.Color.DarkGray;
            this.headerSearch02.StateCommon.Border.Color2 = System.Drawing.Color.DarkGray;
            this.headerSearch02.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.headerSearch02.StateCommon.ButtonPadding = new System.Windows.Forms.Padding(5, 5, 15, 5);
            this.headerSearch02.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5);
            this.headerSearch02.TabIndex = 1;
            this.headerSearch02.Values.Description = "";
            this.headerSearch02.Values.Heading = "Search Result";
            this.headerSearch02.Values.Image = global::YRG_4915M.Properties.Resources.find;
            // 
            // btnCreate
            // 
            this.btnCreate.ExtraText = "Create New Contract Purchase Agreement";
            this.btnCreate.Image = global::YRG_4915M.Properties.Resources.application_form;
            this.btnCreate.UniqueName = "ef9e966d34ca477fa0e5ac58e9fd086e";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ExtraText = "Edit Agreement";
            this.btnEdit.Image = global::YRG_4915M.Properties.Resources.pencil;
            this.btnEdit.UniqueName = "90b8baa6439c466eb23697aaab6acec5";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            // btnSearch
            // 
            this.btnSearch.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btnSearch.Image = global::YRG_4915M.Properties.Resources.magnifier;
            this.btnSearch.Text = "Search Contract PA";
            this.btnSearch.UniqueName = "4f6ee0408dfc46d4bc102babd366485b";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tlpItemSearchCriteria
            // 
            this.tlpItemSearchCriteria.AutoSize = true;
            this.tlpItemSearchCriteria.ColumnCount = 10;
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpItemSearchCriteria.Controls.Add(this.lblAgreeID, 0, 2);
            this.tlpItemSearchCriteria.Controls.Add(this.kryptonLabel3, 1, 1);
            this.tlpItemSearchCriteria.Controls.Add(this.txtAgreeId, 2, 1);
            this.tlpItemSearchCriteria.Controls.Add(this.kryptonLabel1, 7, 1);
            this.tlpItemSearchCriteria.Controls.Add(this.cbCurrency, 8, 1);
            this.tlpItemSearchCriteria.Controls.Add(this.lblItemName, 4, 1);
            this.tlpItemSearchCriteria.Controls.Add(this.txtSuppId, 5, 1);
            this.tlpItemSearchCriteria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpItemSearchCriteria.Location = new System.Drawing.Point(3, 52);
            this.tlpItemSearchCriteria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpItemSearchCriteria.Name = "tlpItemSearchCriteria";
            this.tlpItemSearchCriteria.RowCount = 3;
            this.tlpItemSearchCriteria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpItemSearchCriteria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpItemSearchCriteria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpItemSearchCriteria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpItemSearchCriteria.Size = new System.Drawing.Size(1681, 52);
            this.tlpItemSearchCriteria.TabIndex = 0;
            // 
            // lblAgreeID
            // 
            this.lblAgreeID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAgreeID.Location = new System.Drawing.Point(3, 47);
            this.lblAgreeID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblAgreeID.Name = "lblAgreeID";
            this.lblAgreeID.Size = new System.Drawing.Size(3, 2);
            this.lblAgreeID.TabIndex = 3;
            this.lblAgreeID.Values.Text = "";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kryptonLabel3.Location = new System.Drawing.Point(12, 14);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(112, 24);
            this.kryptonLabel3.TabIndex = 13;
            this.kryptonLabel3.Values.Text = "Contract PA ID";
            // 
            // txtAgreeId
            // 
            this.txtAgreeId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAgreeId.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.txtAgreeId.CueHint.CueHintText = "Agreement ID";
            this.txtAgreeId.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtAgreeId.Location = new System.Drawing.Point(130, 12);
            this.txtAgreeId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAgreeId.Name = "txtAgreeId";
            this.txtAgreeId.Size = new System.Drawing.Size(268, 27);
            this.txtAgreeId.TabIndex = 14;
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.buttonSpecAny1.UniqueName = "6fb900f9fa524f45950d2ef28f395a0c";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kryptonLabel1.Location = new System.Drawing.Point(843, 14);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(72, 24);
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
            this.cbCurrency.Location = new System.Drawing.Point(921, 13);
            this.cbCurrency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Size = new System.Drawing.Size(228, 25);
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
            this.lblItemName.Location = new System.Drawing.Point(440, 14);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(87, 24);
            this.lblItemName.TabIndex = 16;
            this.lblItemName.Values.Text = "Supplier ID";
            // 
            // txtSuppId
            // 
            this.txtSuppId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSuppId.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny2});
            this.txtSuppId.CueHint.CueHintText = "Supplier ID";
            this.txtSuppId.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtSuppId.Location = new System.Drawing.Point(533, 12);
            this.txtSuppId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSuppId.Name = "txtSuppId";
            this.txtSuppId.Size = new System.Drawing.Size(268, 27);
            this.txtSuppId.TabIndex = 15;
            // 
            // buttonSpecAny2
            // 
            this.buttonSpecAny2.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.buttonSpecAny2.UniqueName = "130bee2941b345629cbf0e4d8263e0de";
            // 
            // AgreeFrmTable3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1687, 844);
            this.Controls.Add(this.tlpItemSearch);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AgreeFrmTable3";
            this.Text = "YRGCPS Contract Purchase Agreement";
            this.tlpItemSearch.ResumeLayout(false);
            this.tlpItemSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCPA)).EndInit();
            this.tlpItemSearchCriteria.ResumeLayout(false);
            this.tlpItemSearchCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCurrency)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpItemSearch;
        private Krypton.Toolkit.KryptonHeader headerSearch02;
        private Krypton.Toolkit.ButtonSpecAny btnCreate;
        private Krypton.Toolkit.ButtonSpecAny btnEdit;
        private Krypton.Toolkit.KryptonHeader headerSearch01;
        private Krypton.Toolkit.ButtonSpecAny btnSearch;
        private System.Windows.Forms.TableLayoutPanel tlpItemSearchCriteria;
        private Krypton.Toolkit.KryptonLabel lblAgreeID;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonTextBox txtAgreeId;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonComboBox cbCurrency;
        private Krypton.Toolkit.ButtonSpecAny btnCancelCurrency;
        private Krypton.Toolkit.KryptonLabel lblItemName;
        private Krypton.Toolkit.KryptonTextBox txtSuppId;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny2;
        private Krypton.Toolkit.KryptonDataGridView dgvCPA;
    }
}