<<<<<<< HEAD
﻿namespace YRG_4915M.Pages.RequestManagement
{
    partial class RequestFrmPurchaseManager
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
            this.tlpInfoSearch = new System.Windows.Forms.TableLayoutPanel();
            this.dgvReqRM = new Krypton.Toolkit.KryptonDataGridView();
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
            this.tlpInfoSearch.TabIndex = 4;
            // 
            // dgvReqRM
            // 
            this.dgvReqRM.AllowUserToAddRows = false;
            this.dgvReqRM.AllowUserToDeleteRows = false;
            this.dgvReqRM.AllowUserToResizeRows = false;
            this.dgvReqRM.ColumnHeadersHeight = 28;
            this.dgvReqRM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReqRM.Location = new System.Drawing.Point(3, 217);
            this.dgvReqRM.Name = "dgvReqRM";
            this.dgvReqRM.RowHeadersWidth = 75;
            this.dgvReqRM.RowTemplate.Height = 29;
            this.dgvReqRM.Size = new System.Drawing.Size(1892, 1150);
            this.dgvReqRM.TabIndex = 3;
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
            // RequestFrmPurchaseManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1898, 1370);
            this.Controls.Add(this.tlpInfoSearch);
            this.Name = "RequestFrmPurchaseManager";
            this.Text = "YRGCPS Purchase Manager Request Management";
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
        private Krypton.Toolkit.KryptonDataGridView dgvReqRM;
        private Krypton.Toolkit.KryptonHeader headerSearch02;
        private Krypton.Toolkit.ButtonSpecAny btnCreateReq;
        private Krypton.Toolkit.ButtonSpecAny btnEditReq;
        private Krypton.Toolkit.ButtonSpecAny btnCancelReq;
        private Krypton.Toolkit.KryptonHeader headerSearch01;
        private Krypton.Toolkit.ButtonSpecAny btnSearchReq;
        private System.Windows.Forms.TableLayoutPanel tlpInfoSearchCriteria;
        private Krypton.Toolkit.KryptonTextBox txtReqItemId;
        private Krypton.Toolkit.ButtonSpecAny btnCancelItemId;
        private Krypton.Toolkit.KryptonLabel lblRequestStatus;
        private Krypton.Toolkit.KryptonLabel lblRequestItemId;
        private Krypton.Toolkit.KryptonComboBox txtReqStatus;
        private Krypton.Toolkit.KryptonTextBox txtReqId;
        private Krypton.Toolkit.ButtonSpecAny btnCancelReqId;
        private Krypton.Toolkit.KryptonLabel lblRepuestId;
        private Krypton.Toolkit.KryptonLabel lblRestId;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel lblExpectedDeliveryDate;
        private Krypton.Toolkit.KryptonTextBox txtReqExpectedDeliveryDate;
        private Krypton.Toolkit.ButtonSpecAny btnCancelExpectedDeliveryDate;
    }
=======
﻿namespace YRG_4915M.Pages.RequestManagement
{
    partial class RequestFrmPurchaseManager
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
            this.tlpInfoSearch = new System.Windows.Forms.TableLayoutPanel();
            this.dgvReqRM = new Krypton.Toolkit.KryptonDataGridView();
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
            this.tlpInfoSearch.TabIndex = 4;
            // 
            // dgvReqRM
            // 
            this.dgvReqRM.AllowUserToAddRows = false;
            this.dgvReqRM.AllowUserToDeleteRows = false;
            this.dgvReqRM.AllowUserToResizeRows = false;
            this.dgvReqRM.ColumnHeadersHeight = 28;
            this.dgvReqRM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReqRM.Location = new System.Drawing.Point(3, 217);
            this.dgvReqRM.Name = "dgvReqRM";
            this.dgvReqRM.RowHeadersWidth = 75;
            this.dgvReqRM.RowTemplate.Height = 29;
            this.dgvReqRM.Size = new System.Drawing.Size(1892, 1150);
            this.dgvReqRM.TabIndex = 3;
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
            // RequestFrmPurchaseManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1898, 1370);
            this.Controls.Add(this.tlpInfoSearch);
            this.Name = "RequestFrmPurchaseManager";
            this.Text = "YRGCPS Purchase Manager Request Management";
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
        private Krypton.Toolkit.KryptonDataGridView dgvReqRM;
        private Krypton.Toolkit.KryptonHeader headerSearch02;
        private Krypton.Toolkit.ButtonSpecAny btnCreateReq;
        private Krypton.Toolkit.ButtonSpecAny btnEditReq;
        private Krypton.Toolkit.ButtonSpecAny btnCancelReq;
        private Krypton.Toolkit.KryptonHeader headerSearch01;
        private Krypton.Toolkit.ButtonSpecAny btnSearchReq;
        private System.Windows.Forms.TableLayoutPanel tlpInfoSearchCriteria;
        private Krypton.Toolkit.KryptonTextBox txtReqItemId;
        private Krypton.Toolkit.ButtonSpecAny btnCancelItemId;
        private Krypton.Toolkit.KryptonLabel lblRequestStatus;
        private Krypton.Toolkit.KryptonLabel lblRequestItemId;
        private Krypton.Toolkit.KryptonComboBox txtReqStatus;
        private Krypton.Toolkit.KryptonTextBox txtReqId;
        private Krypton.Toolkit.ButtonSpecAny btnCancelReqId;
        private Krypton.Toolkit.KryptonLabel lblRepuestId;
        private Krypton.Toolkit.KryptonLabel lblRestId;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel lblExpectedDeliveryDate;
        private Krypton.Toolkit.KryptonTextBox txtReqExpectedDeliveryDate;
        private Krypton.Toolkit.ButtonSpecAny btnCancelExpectedDeliveryDate;
    }
>>>>>>> e3039030246399001b6a193ac0434d0ab124b1f7
}