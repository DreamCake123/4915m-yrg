namespace YRG_4915M.Pages.RequestManagement
{
    partial class RequestFrmMajor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpInfoSearch = new System.Windows.Forms.TableLayoutPanel();
            this.dgvReqRM = new Krypton.Toolkit.KryptonDataGridView();
            this.reqId = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.reqStatus = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.reqExpectedDeliveryDate = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.restId = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.restManagerId = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.reqItem = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.reqItemQty = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.reqCreationDate = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.reqRemark = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.deliveryNoteNumber = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.headerSearch02 = new Krypton.Toolkit.KryptonHeader();
            this.btnCreateReq = new Krypton.Toolkit.ButtonSpecAny();
            this.btnEditReq = new Krypton.Toolkit.ButtonSpecAny();
            this.btnCancelReq = new Krypton.Toolkit.ButtonSpecAny();
            this.headerSearch01 = new Krypton.Toolkit.KryptonHeader();
            this.btnSearchReq = new Krypton.Toolkit.ButtonSpecAny();
            this.tlpInfoSearchCriteria = new System.Windows.Forms.TableLayoutPanel();
            this.txtReqItemId = new Krypton.Toolkit.KryptonTextBox();
            this.btnCancelItemId = new Krypton.Toolkit.ButtonSpecAny();
            this.lblRequestStatus = new Krypton.Toolkit.KryptonLabel();
            this.lblRequestItemId = new Krypton.Toolkit.KryptonLabel();
            this.txtReqStatus = new Krypton.Toolkit.KryptonComboBox();
            this.txtReqId = new Krypton.Toolkit.KryptonTextBox();
            this.btnCancelReqId = new Krypton.Toolkit.ButtonSpecAny();
            this.lblRepuestId = new Krypton.Toolkit.KryptonLabel();
            this.lblRestId = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.lblExpectedDeliveryDate = new Krypton.Toolkit.KryptonLabel();
            this.txtReqExpectedDeliveryDate = new Krypton.Toolkit.KryptonTextBox();
            this.btnCancelExpectedDeliveryDate = new Krypton.Toolkit.ButtonSpecAny();
            this.txtRestId = new Krypton.Toolkit.KryptonTextBox();
            this.btnCancelRestId = new Krypton.Toolkit.ButtonSpecAny();
            this.tlpInfoSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReqRM)).BeginInit();
            this.tlpInfoSearchCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtReqStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpInfoSearch
            // 
            this.tlpInfoSearch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tlpInfoSearch.ColumnCount = 1;
            this.tlpInfoSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInfoSearch.Controls.Add(this.dgvReqRM, 0, 3);
            this.tlpInfoSearch.Controls.Add(this.headerSearch02, 0, 2);
            this.tlpInfoSearch.Controls.Add(this.headerSearch01, 0, 0);
            this.tlpInfoSearch.Controls.Add(this.tlpInfoSearchCriteria, 0, 1);
            this.tlpInfoSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInfoSearch.Location = new System.Drawing.Point(0, 0);
            this.tlpInfoSearch.Name = "tlpInfoSearch";
            this.tlpInfoSearch.RowCount = 4;
            this.tlpInfoSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInfoSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInfoSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInfoSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInfoSearch.Size = new System.Drawing.Size(1898, 1370);
            this.tlpInfoSearch.TabIndex = 3;
            // 
            // dgvReqRM
            // 
            this.dgvReqRM.AllowUserToAddRows = false;
            this.dgvReqRM.AllowUserToDeleteRows = false;
            this.dgvReqRM.AllowUserToResizeRows = false;
            this.dgvReqRM.ColumnHeadersHeight = 28;
            this.dgvReqRM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reqId,
            this.reqStatus,
            this.reqExpectedDeliveryDate,
            this.restId,
            this.restManagerId,
            this.reqItem,
            this.reqItemQty,
            this.reqCreationDate,
            this.reqRemark,
            this.deliveryNoteNumber});
            this.dgvReqRM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReqRM.Location = new System.Drawing.Point(3, 217);
            this.dgvReqRM.Name = "dgvReqRM";
            this.dgvReqRM.RowHeadersWidth = 75;
            this.dgvReqRM.RowTemplate.Height = 29;
            this.dgvReqRM.Size = new System.Drawing.Size(1892, 1150);
            this.dgvReqRM.TabIndex = 3;
            // 
            // reqId
            // 
            this.reqId.DefaultCellStyle = dataGridViewCellStyle1;
            this.reqId.HeaderText = "reqId";
            this.reqId.MinimumWidth = 8;
            this.reqId.Name = "reqId";
            this.reqId.Width = 150;
            // 
            // reqStatus
            // 
            this.reqStatus.DefaultCellStyle = dataGridViewCellStyle2;
            this.reqStatus.HeaderText = "reqStatus";
            this.reqStatus.MinimumWidth = 8;
            this.reqStatus.Name = "reqStatus";
            this.reqStatus.Width = 150;
            // 
            // reqExpectedDeliveryDate
            // 
            this.reqExpectedDeliveryDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.reqExpectedDeliveryDate.HeaderText = "reqExpectedDeliveryDate";
            this.reqExpectedDeliveryDate.MinimumWidth = 8;
            this.reqExpectedDeliveryDate.Name = "reqExpectedDeliveryDate";
            this.reqExpectedDeliveryDate.Width = 150;
            // 
            // restId
            // 
            this.restId.DefaultCellStyle = dataGridViewCellStyle4;
            this.restId.HeaderText = "restId";
            this.restId.MinimumWidth = 8;
            this.restId.Name = "restId";
            this.restId.Width = 150;
            // 
            // restManagerId
            // 
            this.restManagerId.DefaultCellStyle = dataGridViewCellStyle5;
            this.restManagerId.HeaderText = "restManagerId";
            this.restManagerId.MinimumWidth = 8;
            this.restManagerId.Name = "restManagerId";
            this.restManagerId.Width = 150;
            // 
            // reqItem
            // 
            this.reqItem.DefaultCellStyle = dataGridViewCellStyle6;
            this.reqItem.HeaderText = "reqItem";
            this.reqItem.MinimumWidth = 8;
            this.reqItem.Name = "reqItem";
            this.reqItem.Width = 150;
            // 
            // reqItemQty
            // 
            this.reqItemQty.DefaultCellStyle = dataGridViewCellStyle7;
            this.reqItemQty.HeaderText = "reqItemQty";
            this.reqItemQty.MinimumWidth = 8;
            this.reqItemQty.Name = "reqItemQty";
            this.reqItemQty.Width = 150;
            // 
            // reqCreationDate
            // 
            this.reqCreationDate.DefaultCellStyle = dataGridViewCellStyle8;
            this.reqCreationDate.HeaderText = "reqCreationDateTime";
            this.reqCreationDate.MinimumWidth = 8;
            this.reqCreationDate.Name = "reqCreationDate";
            this.reqCreationDate.Width = 150;
            // 
            // reqRemark
            // 
            this.reqRemark.DefaultCellStyle = dataGridViewCellStyle9;
            this.reqRemark.HeaderText = "reqRemark";
            this.reqRemark.MinimumWidth = 8;
            this.reqRemark.Name = "reqRemark";
            this.reqRemark.Width = 150;
            // 
            // deliveryNoteNumber
            // 
            this.deliveryNoteNumber.DefaultCellStyle = dataGridViewCellStyle10;
            this.deliveryNoteNumber.HeaderText = "deliveryNoteNumber";
            this.deliveryNoteNumber.MinimumWidth = 8;
            this.deliveryNoteNumber.Name = "deliveryNoteNumber";
            this.deliveryNoteNumber.Width = 150;
            // 
            // headerSearch02
            // 
            this.headerSearch02.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.btnCreateReq,
            this.btnEditReq,
            this.btnCancelReq});
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
            // btnCreateReq
            // 
            this.btnCreateReq.ExtraText = "Create New Request";
            this.btnCreateReq.Image = global::YRG_4915M.Properties.Resources.application_form_add;
            this.btnCreateReq.UniqueName = "e126e3f30d144dffa9c4788ebc794773";
            // 
            // btnEditReq
            // 
            this.btnEditReq.ExtraText = "Edit Request";
            this.btnEditReq.Image = global::YRG_4915M.Properties.Resources.application_form_edit;
            this.btnEditReq.UniqueName = "610ad4596cb64fed9eb8d55f4a05d343";
            // 
            // btnCancelReq
            // 
            this.btnCancelReq.ExtraText = "Cancel Request";
            this.btnCancelReq.Image = global::YRG_4915M.Properties.Resources.application_form_delete;
            this.btnCancelReq.UniqueName = "3d41a09ffad84f42bb1a2de95df02f50";
            // 
            // headerSearch01
            // 
            this.headerSearch01.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.btnSearchReq});
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
            // btnSearchReq
            // 
            this.btnSearchReq.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btnSearchReq.Image = global::YRG_4915M.Properties.Resources.magnifier;
            this.btnSearchReq.Text = "Search Request";
            this.btnSearchReq.UniqueName = "4f6ee0408dfc46d4bc102babd366485b";
            // 
            // tlpInfoSearchCriteria
            // 
            this.tlpInfoSearchCriteria.AutoSize = true;
            this.tlpInfoSearchCriteria.ColumnCount = 10;
            this.tlpInfoSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpInfoSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpInfoSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpInfoSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpInfoSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpInfoSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpInfoSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpInfoSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpInfoSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpInfoSearchCriteria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInfoSearchCriteria.Controls.Add(this.txtReqItemId, 5, 2);
            this.tlpInfoSearchCriteria.Controls.Add(this.lblRequestStatus, 4, 1);
            this.tlpInfoSearchCriteria.Controls.Add(this.lblRequestItemId, 4, 2);
            this.tlpInfoSearchCriteria.Controls.Add(this.txtReqStatus, 5, 1);
            this.tlpInfoSearchCriteria.Controls.Add(this.txtReqId, 2, 1);
            this.tlpInfoSearchCriteria.Controls.Add(this.lblRepuestId, 1, 1);
            this.tlpInfoSearchCriteria.Controls.Add(this.lblRestId, 2, 2);
            this.tlpInfoSearchCriteria.Controls.Add(this.kryptonLabel3, 1, 2);
            this.tlpInfoSearchCriteria.Controls.Add(this.lblExpectedDeliveryDate, 7, 1);
            this.tlpInfoSearchCriteria.Controls.Add(this.txtReqExpectedDeliveryDate, 8, 1);
            this.tlpInfoSearchCriteria.Controls.Add(this.txtRestId, 9, 2);
            this.tlpInfoSearchCriteria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInfoSearchCriteria.Location = new System.Drawing.Point(3, 53);
            this.tlpInfoSearchCriteria.Name = "tlpInfoSearchCriteria";
            this.tlpInfoSearchCriteria.RowCount = 4;
            this.tlpInfoSearchCriteria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpInfoSearchCriteria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpInfoSearchCriteria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpInfoSearchCriteria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpInfoSearchCriteria.Size = new System.Drawing.Size(1892, 110);
            this.tlpInfoSearchCriteria.TabIndex = 0;
            // 
            // txtReqItemId
            // 
            this.txtReqItemId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtReqItemId.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.btnCancelItemId});
            this.txtReqItemId.CueHint.CueHintText = "Item ID";
            this.txtReqItemId.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtReqItemId.Location = new System.Drawing.Point(639, 62);
            this.txtReqItemId.Name = "txtReqItemId";
            this.txtReqItemId.Size = new System.Drawing.Size(301, 31);
            this.txtReqItemId.TabIndex = 10;
            // 
            // btnCancelItemId
            // 
            this.btnCancelItemId.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.btnCancelItemId.UniqueName = "296e74a4121e4d28a887d8ee22f1b76b";
            // 
            // lblRequestStatus
            // 
            this.lblRequestStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRequestStatus.Location = new System.Drawing.Point(489, 18);
            this.lblRequestStatus.Name = "lblRequestStatus";
            this.lblRequestStatus.Size = new System.Drawing.Size(134, 29);
            this.lblRequestStatus.TabIndex = 7;
            this.lblRequestStatus.Values.Text = "Request Status";
            // 
            // lblRequestItemId
            // 
            this.lblRequestItemId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRequestItemId.Location = new System.Drawing.Point(489, 63);
            this.lblRequestItemId.Name = "lblRequestItemId";
            this.lblRequestItemId.Size = new System.Drawing.Size(144, 29);
            this.lblRequestItemId.TabIndex = 8;
            this.lblRequestItemId.Values.Text = "Request Item ID";
            // 
            // txtReqStatus
            // 
            this.txtReqStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtReqStatus.CornerRoundingRadius = -1F;
            this.txtReqStatus.CueHint.CueHintText = "Status";
            this.txtReqStatus.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtReqStatus.DropDownWidth = 301;
            this.txtReqStatus.IntegralHeight = false;
            this.txtReqStatus.Location = new System.Drawing.Point(639, 18);
            this.txtReqStatus.Name = "txtReqStatus";
            this.txtReqStatus.Size = new System.Drawing.Size(301, 29);
            this.txtReqStatus.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.txtReqStatus.TabIndex = 11;
            // 
            // txtReqId
            // 
            this.txtReqId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtReqId.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.btnCancelReqId});
            this.txtReqId.CueHint.CueHintText = "Request ID";
            this.txtReqId.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtReqId.Location = new System.Drawing.Point(142, 17);
            this.txtReqId.Name = "txtReqId";
            this.txtReqId.Size = new System.Drawing.Size(301, 31);
            this.txtReqId.TabIndex = 4;
            // 
            // btnCancelReqId
            // 
            this.btnCancelReqId.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.btnCancelReqId.UniqueName = "6fb900f9fa524f45950d2ef28f395a0c";
            // 
            // lblRepuestId
            // 
            this.lblRepuestId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRepuestId.Location = new System.Drawing.Point(13, 18);
            this.lblRepuestId.Name = "lblRepuestId";
            this.lblRepuestId.Size = new System.Drawing.Size(102, 29);
            this.lblRepuestId.TabIndex = 3;
            this.lblRepuestId.Values.Text = "Request ID";
            // 
            // lblRestId
            // 
            this.lblRestId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRestId.Location = new System.Drawing.Point(142, 63);
            this.lblRestId.Name = "lblRestId";
            this.lblRestId.Size = new System.Drawing.Size(251, 29);
            this.lblRestId.TabIndex = 2;
            this.lblRestId.Values.Text = "Restaurant ID (not allow edit)";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kryptonLabel3.Location = new System.Drawing.Point(13, 63);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(123, 29);
            this.kryptonLabel3.TabIndex = 12;
            this.kryptonLabel3.Values.Text = "Restaurant ID";
            // 
            // lblExpectedDeliveryDate
            // 
            this.lblExpectedDeliveryDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblExpectedDeliveryDate.Location = new System.Drawing.Point(986, 18);
            this.lblExpectedDeliveryDate.Name = "lblExpectedDeliveryDate";
            this.lblExpectedDeliveryDate.Size = new System.Drawing.Size(201, 29);
            this.lblExpectedDeliveryDate.TabIndex = 13;
            this.lblExpectedDeliveryDate.Values.Text = "Expected Delivery Date";
            // 
            // txtReqExpectedDeliveryDate
            // 
            this.txtReqExpectedDeliveryDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtReqExpectedDeliveryDate.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.btnCancelExpectedDeliveryDate});
            this.txtReqExpectedDeliveryDate.CueHint.CueHintText = "i.e. 2023-01-23";
            this.txtReqExpectedDeliveryDate.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtReqExpectedDeliveryDate.Location = new System.Drawing.Point(1193, 17);
            this.txtReqExpectedDeliveryDate.Name = "txtReqExpectedDeliveryDate";
            this.txtReqExpectedDeliveryDate.Size = new System.Drawing.Size(301, 31);
            this.txtReqExpectedDeliveryDate.TabIndex = 14;
            // 
            // btnCancelExpectedDeliveryDate
            // 
            this.btnCancelExpectedDeliveryDate.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.btnCancelExpectedDeliveryDate.UniqueName = "130bee2941b345629cbf0e4d8263e0de";
            // 
            // txtRestId
            // 
            this.txtRestId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtRestId.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.btnCancelRestId});
            this.txtRestId.CueHint.CueHintText = "Request Restaurant ID";
            this.txtRestId.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtRestId.Location = new System.Drawing.Point(1500, 62);
            this.txtRestId.Name = "txtRestId";
            this.txtRestId.Size = new System.Drawing.Size(301, 31);
            this.txtRestId.TabIndex = 6;
            // 
            // btnCancelRestId
            // 
            this.btnCancelRestId.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.btnCancelRestId.UniqueName = "130bee2941b345629cbf0e4d8263e0de";
            // 
            // RequestFrmMajor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1898, 1370);
            this.Controls.Add(this.tlpInfoSearch);
            this.Name = "RequestFrmMajor";
            this.Text = "YRGCPS Restaurant Manager Request Management";
            this.tlpInfoSearch.ResumeLayout(false);
            this.tlpInfoSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReqRM)).EndInit();
            this.tlpInfoSearchCriteria.ResumeLayout(false);
            this.tlpInfoSearchCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtReqStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpInfoSearch;
        private Krypton.Toolkit.KryptonHeader headerSearch02;
        private Krypton.Toolkit.KryptonHeader headerSearch01;
        private Krypton.Toolkit.ButtonSpecAny btnSearchReq;
        private System.Windows.Forms.TableLayoutPanel tlpInfoSearchCriteria;
        private Krypton.Toolkit.KryptonTextBox txtRestId;
        private Krypton.Toolkit.ButtonSpecAny btnCancelRestId;
        private Krypton.Toolkit.KryptonLabel lblRepuestId;
        private Krypton.Toolkit.KryptonLabel lblRestId;
        private Krypton.Toolkit.KryptonTextBox txtReqId;
        private Krypton.Toolkit.ButtonSpecAny btnCancelReqId;
        private Krypton.Toolkit.KryptonDataGridView dgvReqRM;
        private Krypton.Toolkit.KryptonTextBox txtReqItemId;
        private Krypton.Toolkit.KryptonLabel lblRequestStatus;
        private Krypton.Toolkit.KryptonLabel lblRequestItemId;
        private Krypton.Toolkit.KryptonComboBox txtReqStatus;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel lblExpectedDeliveryDate;
        private Krypton.Toolkit.KryptonTextBox txtReqExpectedDeliveryDate;
        private Krypton.Toolkit.ButtonSpecAny btnCancelExpectedDeliveryDate;
        private Krypton.Toolkit.ButtonSpecAny btnCreateReq;
        private Krypton.Toolkit.ButtonSpecAny btnEditReq;
        private Krypton.Toolkit.ButtonSpecAny btnCancelReq;
        private Krypton.Toolkit.ButtonSpecAny btnCancelItemId;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn reqId;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn reqStatus;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn reqExpectedDeliveryDate;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn restId;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn restManagerId;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn reqItem;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn reqItemQty;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn reqCreationDate;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn reqRemark;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn deliveryNoteNumber;
    }
}