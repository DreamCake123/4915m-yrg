namespace YRG_4915M.Pages.Order
{
    partial class OrderFrmMinor
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
            this.dgvPurchaseOrder = new Krypton.Toolkit.KryptonDataGridView();
            this.headerSearch02 = new Krypton.Toolkit.KryptonHeader();
            this.btnCreate = new Krypton.Toolkit.ButtonSpecAny();
            this.headerSearch01 = new Krypton.Toolkit.KryptonHeader();
            this.btnSearch = new Krypton.Toolkit.ButtonSpecAny();
            this.tlpItemSearchCriteria = new System.Windows.Forms.TableLayoutPanel();
            this.lblAgreeID = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.txtPONum = new Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny1 = new Krypton.Toolkit.ButtonSpecAny();
            this.lblItemName = new Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBox3 = new Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny2 = new Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.rbPOBlanket = new Krypton.Toolkit.KryptonRadioButton();
            this.rbAgreeBPA = new Krypton.Toolkit.KryptonRadioButton();
            this.rdAgreeContract = new Krypton.Toolkit.KryptonRadioButton();
            this.rbPOPlanned = new Krypton.Toolkit.KryptonRadioButton();
            this.rbPOStandard = new Krypton.Toolkit.KryptonRadioButton();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.cbPOStatus = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonHeader1 = new Krypton.Toolkit.KryptonHeader();
            this.dgvPOItem = new Krypton.Toolkit.KryptonDataGridView();
            this.tlpItemSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrder)).BeginInit();
            this.tlpItemSearchCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbPOStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPOItem)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpItemSearch
            // 
            this.tlpItemSearch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tlpItemSearch.ColumnCount = 1;
            this.tlpItemSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpItemSearch.Controls.Add(this.dgvPurchaseOrder, 0, 3);
            this.tlpItemSearch.Controls.Add(this.headerSearch02, 0, 2);
            this.tlpItemSearch.Controls.Add(this.headerSearch01, 0, 0);
            this.tlpItemSearch.Controls.Add(this.tlpItemSearchCriteria, 0, 1);
            this.tlpItemSearch.Controls.Add(this.kryptonHeader1, 0, 4);
            this.tlpItemSearch.Controls.Add(this.dgvPOItem, 0, 5);
            this.tlpItemSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpItemSearch.Location = new System.Drawing.Point(0, 0);
            this.tlpItemSearch.Name = "tlpItemSearch";
            this.tlpItemSearch.RowCount = 6;
            this.tlpItemSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpItemSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpItemSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpItemSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpItemSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpItemSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpItemSearch.Size = new System.Drawing.Size(1898, 1424);
            this.tlpItemSearch.TabIndex = 4;
            // 
            // dgvPurchaseOrder
            // 
            this.dgvPurchaseOrder.AllowUserToAddRows = false;
            this.dgvPurchaseOrder.AllowUserToDeleteRows = false;
            this.dgvPurchaseOrder.AllowUserToResizeRows = false;
            this.dgvPurchaseOrder.ColumnHeadersHeight = 28;
            this.dgvPurchaseOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPurchaseOrder.Location = new System.Drawing.Point(3, 217);
            this.dgvPurchaseOrder.Name = "dgvPurchaseOrder";
            this.dgvPurchaseOrder.RowHeadersWidth = 75;
            this.dgvPurchaseOrder.RowTemplate.Height = 29;
            this.dgvPurchaseOrder.Size = new System.Drawing.Size(1892, 809);
            this.dgvPurchaseOrder.TabIndex = 3;
            // 
            // headerSearch02
            // 
            this.headerSearch02.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.btnCreate});
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
            this.headerSearch02.Values.Heading = "Purchase Orders";
            this.headerSearch02.Values.Image = global::YRG_4915M.Properties.Resources.resources;
            // 
            // btnCreate
            // 
            this.btnCreate.ExtraText = "Create New Purchase Order";
            this.btnCreate.Image = global::YRG_4915M.Properties.Resources.application_form_add;
            this.btnCreate.UniqueName = "ef9e966d34ca477fa0e5ac58e9fd086e";
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
            this.btnSearch.Text = "Search Purchase Order";
            this.btnSearch.UniqueName = "4f6ee0408dfc46d4bc102babd366485b";
            // 
            // tlpItemSearchCriteria
            // 
            this.tlpItemSearchCriteria.AutoSize = true;
            this.tlpItemSearchCriteria.ColumnCount = 14;
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItemSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpItemSearchCriteria.Controls.Add(this.lblAgreeID, 0, 3);
            this.tlpItemSearchCriteria.Controls.Add(this.kryptonLabel3, 1, 1);
            this.tlpItemSearchCriteria.Controls.Add(this.txtPONum, 2, 1);
            this.tlpItemSearchCriteria.Controls.Add(this.lblItemName, 1, 2);
            this.tlpItemSearchCriteria.Controls.Add(this.kryptonTextBox3, 2, 2);
            this.tlpItemSearchCriteria.Controls.Add(this.kryptonLabel1, 4, 1);
            this.tlpItemSearchCriteria.Controls.Add(this.kryptonLabel2, 4, 2);
            this.tlpItemSearchCriteria.Controls.Add(this.rbPOBlanket, 5, 2);
            this.tlpItemSearchCriteria.Controls.Add(this.rbAgreeBPA, 5, 1);
            this.tlpItemSearchCriteria.Controls.Add(this.rdAgreeContract, 6, 1);
            this.tlpItemSearchCriteria.Controls.Add(this.rbPOPlanned, 9, 2);
            this.tlpItemSearchCriteria.Controls.Add(this.rbPOStandard, 6, 2);
            this.tlpItemSearchCriteria.Controls.Add(this.kryptonLabel4, 11, 1);
            this.tlpItemSearchCriteria.Controls.Add(this.cbPOStatus, 12, 1);
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
            this.kryptonLabel3.Size = new System.Drawing.Size(211, 29);
            this.kryptonLabel3.TabIndex = 13;
            this.kryptonLabel3.Values.Text = "Purchase Order Number";
            // 
            // txtPONum
            // 
            this.txtPONum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPONum.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.txtPONum.CueHint.CueHintText = "P.O. Number";
            this.txtPONum.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtPONum.Location = new System.Drawing.Point(230, 17);
            this.txtPONum.Name = "txtPONum";
            this.txtPONum.Size = new System.Drawing.Size(266, 31);
            this.txtPONum.TabIndex = 14;
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.buttonSpecAny1.UniqueName = "6fb900f9fa524f45950d2ef28f395a0c";
            // 
            // lblItemName
            // 
            this.lblItemName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblItemName.Location = new System.Drawing.Point(13, 63);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(103, 29);
            this.lblItemName.TabIndex = 16;
            this.lblItemName.Values.Text = "Supplier ID";
            // 
            // kryptonTextBox3
            // 
            this.kryptonTextBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kryptonTextBox3.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny2});
            this.kryptonTextBox3.CueHint.CueHintText = "Supplier ID";
            this.kryptonTextBox3.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.kryptonTextBox3.Location = new System.Drawing.Point(230, 62);
            this.kryptonTextBox3.Name = "kryptonTextBox3";
            this.kryptonTextBox3.Size = new System.Drawing.Size(266, 31);
            this.kryptonTextBox3.TabIndex = 15;
            // 
            // buttonSpecAny2
            // 
            this.buttonSpecAny2.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.buttonSpecAny2.UniqueName = "130bee2941b345629cbf0e4d8263e0de";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kryptonLabel1.Location = new System.Drawing.Point(542, 18);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(148, 29);
            this.kryptonLabel1.TabIndex = 17;
            this.kryptonLabel1.Values.Text = "Agreement Type";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kryptonLabel2.Location = new System.Drawing.Point(542, 63);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(89, 29);
            this.kryptonLabel2.TabIndex = 19;
            this.kryptonLabel2.Values.Text = "P.O. Type";
            // 
            // rbPOBlanket
            // 
            this.rbPOBlanket.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbPOBlanket.Location = new System.Drawing.Point(696, 63);
            this.rbPOBlanket.Name = "rbPOBlanket";
            this.rbPOBlanket.Size = new System.Drawing.Size(85, 29);
            this.rbPOBlanket.TabIndex = 20;
            this.rbPOBlanket.Values.Text = "Blanket";
            // 
            // rbAgreeBPA
            // 
            this.rbAgreeBPA.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbAgreeBPA.Location = new System.Drawing.Point(696, 18);
            this.rbAgreeBPA.Name = "rbAgreeBPA";
            this.rbAgreeBPA.Size = new System.Drawing.Size(57, 29);
            this.rbAgreeBPA.TabIndex = 23;
            this.rbAgreeBPA.Values.Text = "BPA";
            // 
            // rdAgreeContract
            // 
            this.rdAgreeContract.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdAgreeContract.Location = new System.Drawing.Point(787, 18);
            this.rdAgreeContract.Name = "rdAgreeContract";
            this.rdAgreeContract.Size = new System.Drawing.Size(94, 29);
            this.rdAgreeContract.TabIndex = 24;
            this.rdAgreeContract.Values.Text = "Contract";
            // 
            // rbPOPlanned
            // 
            this.rbPOPlanned.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbPOPlanned.Location = new System.Drawing.Point(891, 63);
            this.rbPOPlanned.Name = "rbPOPlanned";
            this.rbPOPlanned.Size = new System.Drawing.Size(90, 29);
            this.rbPOPlanned.TabIndex = 22;
            this.rbPOPlanned.Values.Text = "Planned";
            // 
            // rbPOStandard
            // 
            this.rbPOStandard.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbPOStandard.Location = new System.Drawing.Point(787, 63);
            this.rbPOStandard.Name = "rbPOStandard";
            this.rbPOStandard.Size = new System.Drawing.Size(98, 29);
            this.rbPOStandard.TabIndex = 21;
            this.rbPOStandard.Values.Text = "Standard";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kryptonLabel4.Location = new System.Drawing.Point(1027, 18);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(100, 29);
            this.kryptonLabel4.TabIndex = 25;
            this.kryptonLabel4.Values.Text = "P.O. Status";
            // 
            // cbPOStatus
            // 
            this.cbPOStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbPOStatus.CornerRoundingRadius = -1F;
            this.cbPOStatus.CueHint.CueHintText = "Status";
            this.cbPOStatus.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.cbPOStatus.DropDownWidth = 159;
            this.cbPOStatus.IntegralHeight = false;
            this.cbPOStatus.Location = new System.Drawing.Point(1133, 18);
            this.cbPOStatus.Name = "cbPOStatus";
            this.cbPOStatus.Size = new System.Drawing.Size(159, 29);
            this.cbPOStatus.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbPOStatus.TabIndex = 26;
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeader1.HeaderStyle = Krypton.Toolkit.HeaderStyle.Form;
            this.kryptonHeader1.Location = new System.Drawing.Point(3, 1032);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(1892, 39);
            this.kryptonHeader1.TabIndex = 4;
            this.kryptonHeader1.Values.Description = "";
            this.kryptonHeader1.Values.Heading = "P.O. Item";
            this.kryptonHeader1.Values.Image = global::YRG_4915M.Properties.Resources.application_from_storage;
            // 
            // dgvPOItem
            // 
            this.dgvPOItem.AllowUserToAddRows = false;
            this.dgvPOItem.AllowUserToDeleteRows = false;
            this.dgvPOItem.ColumnHeadersHeight = 28;
            this.dgvPOItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPOItem.Location = new System.Drawing.Point(3, 1077);
            this.dgvPOItem.Name = "dgvPOItem";
            this.dgvPOItem.RowHeadersWidth = 75;
            this.dgvPOItem.RowTemplate.Height = 28;
            this.dgvPOItem.Size = new System.Drawing.Size(1892, 344);
            this.dgvPOItem.TabIndex = 5;
            // 
            // OrderFrmMinor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1898, 1424);
            this.Controls.Add(this.tlpItemSearch);
            this.Name = "OrderFrmMinor";
            this.Text = "YRGCPS Supplier View Order & Issue Delivery Notes";
            this.tlpItemSearch.ResumeLayout(false);
            this.tlpItemSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrder)).EndInit();
            this.tlpItemSearchCriteria.ResumeLayout(false);
            this.tlpItemSearchCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbPOStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPOItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpItemSearch;
        private Krypton.Toolkit.KryptonDataGridView dgvPurchaseOrder;
        private Krypton.Toolkit.KryptonHeader headerSearch02;
        private Krypton.Toolkit.ButtonSpecAny btnCreate;
        private Krypton.Toolkit.KryptonHeader headerSearch01;
        private Krypton.Toolkit.ButtonSpecAny btnSearch;
        private System.Windows.Forms.TableLayoutPanel tlpItemSearchCriteria;
        private Krypton.Toolkit.KryptonLabel lblAgreeID;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonTextBox txtPONum;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private Krypton.Toolkit.KryptonLabel lblItemName;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox3;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonRadioButton rbPOBlanket;
        private Krypton.Toolkit.KryptonRadioButton rbAgreeBPA;
        private Krypton.Toolkit.KryptonRadioButton rdAgreeContract;
        private Krypton.Toolkit.KryptonRadioButton rbPOPlanned;
        private Krypton.Toolkit.KryptonRadioButton rbPOStandard;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonComboBox cbPOStatus;
        private Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private Krypton.Toolkit.KryptonDataGridView dgvPOItem;
    }
}