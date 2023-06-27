namespace YRG_4915M.Pages.BasicInfo
{
    partial class BasicFrmSupplier
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvSupplierInfo = new Krypton.Toolkit.KryptonDataGridView();
            this.kryptonHeader3 = new Krypton.Toolkit.KryptonHeader();
            this.kryptonHeader1 = new Krypton.Toolkit.KryptonHeader();
            this.btnDelete = new Krypton.Toolkit.ButtonSpecAny();
            this.btnCreate = new Krypton.Toolkit.ButtonSpecAny();
            this.btnSave = new Krypton.Toolkit.ButtonSpecAny();
            this.btnSearch = new Krypton.Toolkit.ButtonSpecAny();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSuppId = new Krypton.Toolkit.KryptonLabel();
            this.txtSuppId = new Krypton.Toolkit.KryptonTextBox();
            this.btnInfoIDCancel = new Krypton.Toolkit.ButtonSpecAny();
            this.lblSuppName = new Krypton.Toolkit.KryptonLabel();
            this.txtSuppName = new Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny1 = new Krypton.Toolkit.ButtonSpecAny();
            this.lblSuppTel = new Krypton.Toolkit.KryptonLabel();
            this.txtSuppTel = new Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny2 = new Krypton.Toolkit.ButtonSpecAny();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSuppContactPerson = new Krypton.Toolkit.KryptonLabel();
            this.txtSuppContactPerson = new Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny4 = new Krypton.Toolkit.ButtonSpecAny();
            this.txtSuppAddress = new Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny3 = new Krypton.Toolkit.ButtonSpecAny();
            this.lblSuppAddress = new Krypton.Toolkit.KryptonLabel();
            this.lblSuppEmail = new Krypton.Toolkit.KryptonLabel();
            this.txtSuppEmail = new Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny5 = new Krypton.Toolkit.ButtonSpecAny();
            this.kryptonHeader2 = new Krypton.Toolkit.KryptonHeader();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierInfo)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvSupplierInfo, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.kryptonHeader3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.kryptonHeader1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.kryptonHeader2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1898, 1370);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // dgvSupplierInfo
            // 
            this.dgvSupplierInfo.AllowUserToAddRows = false;
            this.dgvSupplierInfo.AllowUserToDeleteRows = false;
            this.dgvSupplierInfo.AllowUserToResizeRows = false;
            this.dgvSupplierInfo.ColumnHeadersHeight = 28;
            this.dgvSupplierInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSupplierInfo.Location = new System.Drawing.Point(3, 327);
            this.dgvSupplierInfo.Name = "dgvSupplierInfo";
            this.dgvSupplierInfo.RowHeadersWidth = 75;
            this.dgvSupplierInfo.RowTemplate.Height = 29;
            this.dgvSupplierInfo.Size = new System.Drawing.Size(1892, 1040);
            this.dgvSupplierInfo.TabIndex = 8;
            // 
            // kryptonHeader3
            // 
            this.kryptonHeader3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeader3.HeaderStyle = Krypton.Toolkit.HeaderStyle.Form;
            this.kryptonHeader3.Location = new System.Drawing.Point(3, 282);
            this.kryptonHeader3.Name = "kryptonHeader3";
            this.kryptonHeader3.Size = new System.Drawing.Size(1892, 39);
            this.kryptonHeader3.TabIndex = 7;
            this.kryptonHeader3.Values.Description = "";
            this.kryptonHeader3.Values.Heading = "Supplier Information";
            this.kryptonHeader3.Values.Image = global::YRG_4915M.Properties.Resources.application_form_magnify;
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.btnDelete,
            this.btnCreate,
            this.btnSave,
            this.btnSearch});
            this.kryptonHeader1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeader1.HeaderStyle = Krypton.Toolkit.HeaderStyle.Form;
            this.kryptonHeader1.Location = new System.Drawing.Point(3, 3);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(1892, 40);
            this.kryptonHeader1.StateCommon.ButtonPadding = new System.Windows.Forms.Padding(3, 3, 16, 3);
            this.kryptonHeader1.TabIndex = 0;
            this.kryptonHeader1.Values.Description = "";
            this.kryptonHeader1.Values.Heading = "";
            this.kryptonHeader1.Values.Image = null;
            // 
            // btnDelete
            // 
            this.btnDelete.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btnDelete.Image = global::YRG_4915M.Properties.Resources.table_row_delete;
            this.btnDelete.Text = "Delete Supplier";
            this.btnDelete.UniqueName = "c479132da6ba4c56863f52c6712fede5";
            // 
            // btnCreate
            // 
            this.btnCreate.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btnCreate.Image = global::YRG_4915M.Properties.Resources.table_row_insert;
            this.btnCreate.Text = "Add New Supplier";
            this.btnCreate.UniqueName = "b2e1ffa964f74685978df328c355fa19";
            // 
            // btnSave
            // 
            this.btnSave.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btnSave.Image = global::YRG_4915M.Properties.Resources.disk;
            this.btnSave.Text = "Save";
            this.btnSave.UniqueName = "3627c85bd04a4878ba01ef0465c70b0d";
            // 
            // btnSearch
            // 
            this.btnSearch.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btnSearch.Image = global::YRG_4915M.Properties.Resources.magnifier;
            this.btnSearch.Text = "Search";
            this.btnSearch.UniqueName = "8d0470310cdc40eaa7db3181ff0e958a";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 12;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.lblSuppId, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtSuppId, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblSuppName, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtSuppName, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblSuppTel, 7, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtSuppTel, 8, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 51);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1890, 84);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lblSuppId
            // 
            this.lblSuppId.Location = new System.Drawing.Point(18, 20);
            this.lblSuppId.Name = "lblSuppId";
            this.lblSuppId.Size = new System.Drawing.Size(103, 29);
            this.lblSuppId.TabIndex = 0;
            this.lblSuppId.Values.Text = "Supplier ID";
            // 
            // txtSuppId
            // 
            this.txtSuppId.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.btnInfoIDCancel});
            this.txtSuppId.CueHint.CueHintText = "ID";
            this.txtSuppId.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtSuppId.Location = new System.Drawing.Point(127, 20);
            this.txtSuppId.Name = "txtSuppId";
            this.txtSuppId.Size = new System.Drawing.Size(210, 31);
            this.txtSuppId.TabIndex = 6;
            // 
            // btnInfoIDCancel
            // 
            this.btnInfoIDCancel.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.btnInfoIDCancel.UniqueName = "6fb900f9fa524f45950d2ef28f395a0c";
            // 
            // lblSuppName
            // 
            this.lblSuppName.Location = new System.Drawing.Point(383, 20);
            this.lblSuppName.Name = "lblSuppName";
            this.lblSuppName.Size = new System.Drawing.Size(134, 29);
            this.lblSuppName.TabIndex = 1;
            this.lblSuppName.Values.Text = "Supplier Name";
            // 
            // txtSuppName
            // 
            this.txtSuppName.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.txtSuppName.CueHint.CueHintText = "Name";
            this.txtSuppName.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtSuppName.Location = new System.Drawing.Point(523, 20);
            this.txtSuppName.Name = "txtSuppName";
            this.txtSuppName.Size = new System.Drawing.Size(325, 31);
            this.txtSuppName.TabIndex = 10;
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.buttonSpecAny1.UniqueName = "6fb900f9fa524f45950d2ef28f395a0c";
            // 
            // lblSuppTel
            // 
            this.lblSuppTel.Location = new System.Drawing.Point(894, 20);
            this.lblSuppTel.Name = "lblSuppTel";
            this.lblSuppTel.Size = new System.Drawing.Size(113, 29);
            this.lblSuppTel.TabIndex = 2;
            this.lblSuppTel.Values.Text = "Supplier Tel.";
            // 
            // txtSuppTel
            // 
            this.txtSuppTel.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny2});
            this.txtSuppTel.CueHint.CueHintText = "Tel.";
            this.txtSuppTel.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtSuppTel.Location = new System.Drawing.Point(1013, 20);
            this.txtSuppTel.Name = "txtSuppTel";
            this.txtSuppTel.Size = new System.Drawing.Size(210, 31);
            this.txtSuppTel.TabIndex = 11;
            // 
            // buttonSpecAny2
            // 
            this.buttonSpecAny2.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.buttonSpecAny2.UniqueName = "6fb900f9fa524f45950d2ef28f395a0c";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoScroll = true;
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 10;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.lblSuppContactPerson, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtSuppContactPerson, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtSuppAddress, 8, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblSuppAddress, 7, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblSuppEmail, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtSuppEmail, 5, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 190);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1890, 84);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // lblSuppContactPerson
            // 
            this.lblSuppContactPerson.Location = new System.Drawing.Point(18, 20);
            this.lblSuppContactPerson.Name = "lblSuppContactPerson";
            this.lblSuppContactPerson.Size = new System.Drawing.Size(137, 29);
            this.lblSuppContactPerson.TabIndex = 5;
            this.lblSuppContactPerson.Values.Text = "Contact Person";
            // 
            // txtSuppContactPerson
            // 
            this.txtSuppContactPerson.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny4});
            this.txtSuppContactPerson.CueHint.CueHintText = "Contact Person";
            this.txtSuppContactPerson.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtSuppContactPerson.Location = new System.Drawing.Point(161, 20);
            this.txtSuppContactPerson.Name = "txtSuppContactPerson";
            this.txtSuppContactPerson.Size = new System.Drawing.Size(272, 31);
            this.txtSuppContactPerson.TabIndex = 13;
            // 
            // buttonSpecAny4
            // 
            this.buttonSpecAny4.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.buttonSpecAny4.UniqueName = "6fb900f9fa524f45950d2ef28f395a0c";
            // 
            // txtSuppAddress
            // 
            this.txtSuppAddress.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny3});
            this.txtSuppAddress.CueHint.CueHintText = "Address";
            this.txtSuppAddress.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtSuppAddress.Location = new System.Drawing.Point(1142, 20);
            this.txtSuppAddress.Name = "txtSuppAddress";
            this.txtSuppAddress.Size = new System.Drawing.Size(420, 31);
            this.txtSuppAddress.TabIndex = 12;
            // 
            // buttonSpecAny3
            // 
            this.buttonSpecAny3.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.buttonSpecAny3.UniqueName = "6fb900f9fa524f45950d2ef28f395a0c";
            // 
            // lblSuppAddress
            // 
            this.lblSuppAddress.Location = new System.Drawing.Point(985, 20);
            this.lblSuppAddress.Name = "lblSuppAddress";
            this.lblSuppAddress.Size = new System.Drawing.Size(151, 29);
            this.lblSuppAddress.TabIndex = 0;
            this.lblSuppAddress.Values.Text = "Supplier Address";
            // 
            // lblSuppEmail
            // 
            this.lblSuppEmail.Location = new System.Drawing.Point(479, 20);
            this.lblSuppEmail.Name = "lblSuppEmail";
            this.lblSuppEmail.Size = new System.Drawing.Size(129, 29);
            this.lblSuppEmail.TabIndex = 1;
            this.lblSuppEmail.Values.Text = "Supplier Email";
            // 
            // txtSuppEmail
            // 
            this.txtSuppEmail.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny5});
            this.txtSuppEmail.CueHint.CueHintText = "Email";
            this.txtSuppEmail.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtSuppEmail.Location = new System.Drawing.Point(614, 20);
            this.txtSuppEmail.Name = "txtSuppEmail";
            this.txtSuppEmail.Size = new System.Drawing.Size(325, 31);
            this.txtSuppEmail.TabIndex = 14;
            // 
            // buttonSpecAny5
            // 
            this.buttonSpecAny5.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.buttonSpecAny5.UniqueName = "6fb900f9fa524f45950d2ef28f395a0c";
            // 
            // kryptonHeader2
            // 
            this.kryptonHeader2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeader2.HeaderStyle = Krypton.Toolkit.HeaderStyle.Form;
            this.kryptonHeader2.Location = new System.Drawing.Point(3, 143);
            this.kryptonHeader2.Name = "kryptonHeader2";
            this.kryptonHeader2.Size = new System.Drawing.Size(1892, 39);
            this.kryptonHeader2.TabIndex = 6;
            this.kryptonHeader2.Values.Description = "for Insert / Edit / Delete";
            this.kryptonHeader2.Values.Heading = "Supplier Details";
            this.kryptonHeader2.Values.Image = global::YRG_4915M.Properties.Resources.small_business;
            // 
            // BasicFrmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1898, 1370);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BasicFrmSupplier";
            this.Text = "YRGCPS Supplier Management";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierInfo)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Krypton.Toolkit.KryptonHeader kryptonHeader2;
        private Krypton.Toolkit.ButtonSpecAny btnDelete;
        private Krypton.Toolkit.ButtonSpecAny btnCreate;
        private Krypton.Toolkit.ButtonSpecAny btnSave;
        private Krypton.Toolkit.ButtonSpecAny btnSearch;
        private Krypton.Toolkit.KryptonLabel lblSuppId;
        private Krypton.Toolkit.KryptonLabel lblSuppName;
        private Krypton.Toolkit.KryptonLabel lblSuppAddress;
        private Krypton.Toolkit.KryptonLabel lblSuppEmail;
        private Krypton.Toolkit.KryptonLabel lblSuppContactPerson;
        private Krypton.Toolkit.KryptonTextBox txtSuppId;
        private Krypton.Toolkit.ButtonSpecAny btnInfoIDCancel;
        private Krypton.Toolkit.KryptonTextBox txtSuppName;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private Krypton.Toolkit.KryptonTextBox txtSuppAddress;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny3;
        private Krypton.Toolkit.KryptonTextBox txtSuppContactPerson;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny4;
        private Krypton.Toolkit.KryptonTextBox txtSuppEmail;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny5;
        private Krypton.Toolkit.KryptonLabel lblSuppTel;
        private Krypton.Toolkit.KryptonTextBox txtSuppTel;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny2;
        private Krypton.Toolkit.KryptonHeader kryptonHeader3;
        private Krypton.Toolkit.KryptonDataGridView dgvSupplierInfo;
    }
}