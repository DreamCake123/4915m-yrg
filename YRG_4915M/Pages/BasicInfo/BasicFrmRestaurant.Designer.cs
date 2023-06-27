namespace YRG_4915M.Pages.BasicInfo
{
    partial class BasicFrmRestaurant
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
            this.btnSearch = new Krypton.Toolkit.ButtonSpecAny();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRestaurantID = new Krypton.Toolkit.KryptonLabel();
            this.txtRestaurantID = new Krypton.Toolkit.KryptonTextBox();
            this.btnInfoIDCancel = new Krypton.Toolkit.ButtonSpecAny();
            this.lblBranch = new Krypton.Toolkit.KryptonLabel();
            this.lblRestaurantTel = new Krypton.Toolkit.KryptonLabel();
            this.txtRestaurantTel = new Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny2 = new Krypton.Toolkit.ButtonSpecAny();
            this.cbBranch = new Krypton.Toolkit.KryptonComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRestaurantAddress = new Krypton.Toolkit.KryptonLabel();
            this.txtRestaurantAddress = new Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny3 = new Krypton.Toolkit.ButtonSpecAny();
            this.kryptonHeader2 = new Krypton.Toolkit.KryptonHeader();
            this.btnAddSupplier = new Krypton.Toolkit.ButtonSpecAny();
            this.btnSaveEdit = new Krypton.Toolkit.ButtonSpecAny();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierInfo)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbBranch)).BeginInit();
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
            this.tableLayoutPanel1.TabIndex = 4;
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
            this.kryptonHeader3.Values.Heading = "Restaurant Information";
            this.kryptonHeader3.Values.Image = global::YRG_4915M.Properties.Resources.application_form_magnify;
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.btnDelete,
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
            this.btnDelete.Text = "Delete Restaurant";
            this.btnDelete.UniqueName = "c479132da6ba4c56863f52c6712fede5";
            // 
            // btnSearch
            // 
            this.btnSearch.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btnSearch.Image = global::YRG_4915M.Properties.Resources.magnifier;
            this.btnSearch.Text = "Search Restaurant";
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
            this.tableLayoutPanel2.Controls.Add(this.lblRestaurantID, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtRestaurantID, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblBranch, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblRestaurantTel, 7, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtRestaurantTel, 8, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbBranch, 5, 1);
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
            // lblRestaurantID
            // 
            this.lblRestaurantID.Location = new System.Drawing.Point(18, 20);
            this.lblRestaurantID.Name = "lblRestaurantID";
            this.lblRestaurantID.Size = new System.Drawing.Size(123, 29);
            this.lblRestaurantID.TabIndex = 0;
            this.lblRestaurantID.Values.Text = "Restaurant ID";
            // 
            // txtRestaurantID
            // 
            this.txtRestaurantID.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.btnInfoIDCancel});
            this.txtRestaurantID.CueHint.CueHintText = "ID";
            this.txtRestaurantID.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtRestaurantID.Location = new System.Drawing.Point(147, 20);
            this.txtRestaurantID.Name = "txtRestaurantID";
            this.txtRestaurantID.Size = new System.Drawing.Size(210, 31);
            this.txtRestaurantID.TabIndex = 6;
            // 
            // btnInfoIDCancel
            // 
            this.btnInfoIDCancel.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.btnInfoIDCancel.UniqueName = "6fb900f9fa524f45950d2ef28f395a0c";
            // 
            // lblBranch
            // 
            this.lblBranch.Location = new System.Drawing.Point(403, 20);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(69, 29);
            this.lblBranch.TabIndex = 1;
            this.lblBranch.Values.Text = "Branch";
            // 
            // lblRestaurantTel
            // 
            this.lblRestaurantTel.Location = new System.Drawing.Point(841, 20);
            this.lblRestaurantTel.Name = "lblRestaurantTel";
            this.lblRestaurantTel.Size = new System.Drawing.Size(133, 29);
            this.lblRestaurantTel.TabIndex = 2;
            this.lblRestaurantTel.Values.Text = "Restaurant Tel.";
            // 
            // txtRestaurantTel
            // 
            this.txtRestaurantTel.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny2});
            this.txtRestaurantTel.CueHint.CueHintText = "Tel.";
            this.txtRestaurantTel.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtRestaurantTel.Location = new System.Drawing.Point(980, 20);
            this.txtRestaurantTel.Name = "txtRestaurantTel";
            this.txtRestaurantTel.Size = new System.Drawing.Size(210, 31);
            this.txtRestaurantTel.TabIndex = 11;
            // 
            // buttonSpecAny2
            // 
            this.buttonSpecAny2.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.buttonSpecAny2.UniqueName = "6fb900f9fa524f45950d2ef28f395a0c";
            // 
            // cbBranch
            // 
            this.cbBranch.CornerRoundingRadius = -1F;
            this.cbBranch.CueHint.CueHintText = "Branch";
            this.cbBranch.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.cbBranch.DropDownWidth = 179;
            this.cbBranch.IntegralHeight = false;
            this.cbBranch.Location = new System.Drawing.Point(478, 20);
            this.cbBranch.Name = "cbBranch";
            this.cbBranch.Size = new System.Drawing.Size(317, 29);
            this.cbBranch.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbBranch.TabIndex = 16;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoScroll = true;
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.lblRestaurantAddress, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtRestaurantAddress, 2, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 190);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1890, 84);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // lblRestaurantAddress
            // 
            this.lblRestaurantAddress.Location = new System.Drawing.Point(18, 20);
            this.lblRestaurantAddress.Name = "lblRestaurantAddress";
            this.lblRestaurantAddress.Size = new System.Drawing.Size(171, 29);
            this.lblRestaurantAddress.TabIndex = 0;
            this.lblRestaurantAddress.Values.Text = "Restaurant Address";
            // 
            // txtRestaurantAddress
            // 
            this.txtRestaurantAddress.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny3});
            this.txtRestaurantAddress.CueHint.CueHintText = "Address";
            this.txtRestaurantAddress.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtRestaurantAddress.Location = new System.Drawing.Point(195, 20);
            this.txtRestaurantAddress.Name = "txtRestaurantAddress";
            this.txtRestaurantAddress.Size = new System.Drawing.Size(420, 31);
            this.txtRestaurantAddress.TabIndex = 12;
            // 
            // buttonSpecAny3
            // 
            this.buttonSpecAny3.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.buttonSpecAny3.UniqueName = "6fb900f9fa524f45950d2ef28f395a0c";
            // 
            // kryptonHeader2
            // 
            this.kryptonHeader2.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.btnAddSupplier,
            this.btnSaveEdit});
            this.kryptonHeader2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeader2.HeaderStyle = Krypton.Toolkit.HeaderStyle.Form;
            this.kryptonHeader2.Location = new System.Drawing.Point(3, 143);
            this.kryptonHeader2.Name = "kryptonHeader2";
            this.kryptonHeader2.Size = new System.Drawing.Size(1892, 39);
            this.kryptonHeader2.TabIndex = 6;
            this.kryptonHeader2.Values.Description = "";
            this.kryptonHeader2.Values.Heading = "Restaurant Details";
            this.kryptonHeader2.Values.Image = global::YRG_4915M.Properties.Resources.small_business;
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Image = global::YRG_4915M.Properties.Resources.table_row_insert;
            this.btnAddSupplier.Text = "Add New Restaurant";
            this.btnAddSupplier.UniqueName = "89056b1c05be48e0ab9db38870d03853";
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.Image = global::YRG_4915M.Properties.Resources.disk;
            this.btnSaveEdit.Text = "Save Edit";
            this.btnSaveEdit.UniqueName = "ed4e222bb7d842758ac2947385472210";
            // 
            // BasicFrmRestaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1898, 1370);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BasicFrmRestaurant";
            this.Text = "YRGCPS Restaurant Management";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierInfo)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbBranch)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Krypton.Toolkit.KryptonDataGridView dgvSupplierInfo;
        private Krypton.Toolkit.KryptonHeader kryptonHeader3;
        private Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private Krypton.Toolkit.ButtonSpecAny btnDelete;
        private Krypton.Toolkit.ButtonSpecAny btnSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Krypton.Toolkit.KryptonLabel lblRestaurantID;
        private Krypton.Toolkit.KryptonTextBox txtRestaurantID;
        private Krypton.Toolkit.ButtonSpecAny btnInfoIDCancel;
        private Krypton.Toolkit.KryptonLabel lblBranch;
        private Krypton.Toolkit.KryptonLabel lblRestaurantTel;
        private Krypton.Toolkit.KryptonTextBox txtRestaurantTel;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Krypton.Toolkit.KryptonTextBox txtRestaurantAddress;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny3;
        private Krypton.Toolkit.KryptonLabel lblRestaurantAddress;
        private Krypton.Toolkit.KryptonHeader kryptonHeader2;
        private Krypton.Toolkit.KryptonComboBox cbBranch;
        private Krypton.Toolkit.ButtonSpecAny btnAddSupplier;
        private Krypton.Toolkit.ButtonSpecAny btnSaveEdit;
    }
}