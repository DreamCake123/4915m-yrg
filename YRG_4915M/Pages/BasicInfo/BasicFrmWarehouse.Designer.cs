namespace YRG_4915M.Pages.BasicInfo
{
    partial class BasicFrmWarehouse
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
            this.txtWarehouseID = new Krypton.Toolkit.KryptonTextBox();
            this.btnInfoIDCancel = new Krypton.Toolkit.ButtonSpecAny();
            this.lblRestaurantTel = new Krypton.Toolkit.KryptonLabel();
            this.txtWarehouseTel = new Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny2 = new Krypton.Toolkit.ButtonSpecAny();
            this.lblWarehouseAddress = new Krypton.Toolkit.KryptonLabel();
            this.txtWarehouseAddress = new Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny3 = new Krypton.Toolkit.ButtonSpecAny();
            this.btnAdd = new Krypton.Toolkit.ButtonSpecAny();
            this.btnSaveEdit = new Krypton.Toolkit.ButtonSpecAny();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierInfo)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1687, 844);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // dgvSupplierInfo
            // 
            this.dgvSupplierInfo.AllowUserToAddRows = false;
            this.dgvSupplierInfo.AllowUserToDeleteRows = false;
            this.dgvSupplierInfo.AllowUserToResizeRows = false;
            this.dgvSupplierInfo.ColumnHeadersHeight = 28;
            this.dgvSupplierInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSupplierInfo.Location = new System.Drawing.Point(3, 165);
            this.dgvSupplierInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSupplierInfo.Name = "dgvSupplierInfo";
            this.dgvSupplierInfo.RowHeadersWidth = 75;
            this.dgvSupplierInfo.RowTemplate.Height = 29;
            this.dgvSupplierInfo.Size = new System.Drawing.Size(1681, 677);
            this.dgvSupplierInfo.TabIndex = 8;
            // 
            // kryptonHeader3
            // 
            this.kryptonHeader3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeader3.HeaderStyle = Krypton.Toolkit.HeaderStyle.Form;
            this.kryptonHeader3.Location = new System.Drawing.Point(3, 122);
            this.kryptonHeader3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonHeader3.Name = "kryptonHeader3";
            this.kryptonHeader3.Size = new System.Drawing.Size(1681, 39);
            this.kryptonHeader3.TabIndex = 7;
            this.kryptonHeader3.Values.Description = "";
            this.kryptonHeader3.Values.Heading = "Warehouse Information";
            this.kryptonHeader3.Values.Image = global::YRG_4915M.Properties.Resources.application_form_magnify;
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.btnDelete,
            this.btnAdd,
            this.btnSaveEdit,
            this.btnSearch});
            this.kryptonHeader1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeader1.HeaderStyle = Krypton.Toolkit.HeaderStyle.Form;
            this.kryptonHeader1.Location = new System.Drawing.Point(3, 2);
            this.kryptonHeader1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(1681, 40);
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
            this.btnDelete.Text = "Delete Warehouse";
            this.btnDelete.UniqueName = "c479132da6ba4c56863f52c6712fede5";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btnSearch.Image = global::YRG_4915M.Properties.Resources.magnifier;
            this.btnSearch.Text = "Search Warehouse";
            this.btnSearch.UniqueName = "8d0470310cdc40eaa7db3181ff0e958a";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 10;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.85715F));
            this.tableLayoutPanel2.Controls.Add(this.txtWarehouseAddress, 8, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblWarehouseAddress, 7, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblRestaurantID, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtWarehouseID, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblRestaurantTel, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtWarehouseTel, 5, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 48);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1679, 68);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lblRestaurantID
            // 
            this.lblRestaurantID.Location = new System.Drawing.Point(16, 16);
            this.lblRestaurantID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblRestaurantID.Name = "lblRestaurantID";
            this.lblRestaurantID.Size = new System.Drawing.Size(108, 24);
            this.lblRestaurantID.TabIndex = 0;
            this.lblRestaurantID.Values.Text = "Warehouse ID";
            // 
            // txtWarehouseID
            // 
            this.txtWarehouseID.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.btnInfoIDCancel});
            this.txtWarehouseID.CueHint.CueHintText = "ID";
            this.txtWarehouseID.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtWarehouseID.Location = new System.Drawing.Point(130, 16);
            this.txtWarehouseID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWarehouseID.Name = "txtWarehouseID";
            this.txtWarehouseID.Size = new System.Drawing.Size(187, 27);
            this.txtWarehouseID.TabIndex = 6;
            // 
            // btnInfoIDCancel
            // 
            this.btnInfoIDCancel.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.btnInfoIDCancel.UniqueName = "6fb900f9fa524f45950d2ef28f395a0c";
            // 
            // lblRestaurantTel
            // 
            this.lblRestaurantTel.Location = new System.Drawing.Point(363, 16);
            this.lblRestaurantTel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblRestaurantTel.Name = "lblRestaurantTel";
            this.lblRestaurantTel.Size = new System.Drawing.Size(116, 24);
            this.lblRestaurantTel.TabIndex = 2;
            this.lblRestaurantTel.Values.Text = "Warehouse Tel.";
            // 
            // txtWarehouseTel
            // 
            this.txtWarehouseTel.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny2});
            this.txtWarehouseTel.CueHint.CueHintText = "Tel.";
            this.txtWarehouseTel.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtWarehouseTel.Location = new System.Drawing.Point(485, 16);
            this.txtWarehouseTel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWarehouseTel.Name = "txtWarehouseTel";
            this.txtWarehouseTel.Size = new System.Drawing.Size(187, 27);
            this.txtWarehouseTel.TabIndex = 11;
            // 
            // buttonSpecAny2
            // 
            this.buttonSpecAny2.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.buttonSpecAny2.UniqueName = "6fb900f9fa524f45950d2ef28f395a0c";
            // 
            // lblWarehouseAddress
            // 
            this.lblWarehouseAddress.Location = new System.Drawing.Point(718, 16);
            this.lblWarehouseAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblWarehouseAddress.Name = "lblWarehouseAddress";
            this.lblWarehouseAddress.Size = new System.Drawing.Size(147, 24);
            this.lblWarehouseAddress.TabIndex = 0;
            this.lblWarehouseAddress.Values.Text = "Warehouse Address";
            // 
            // txtWarehouseAddress
            // 
            this.txtWarehouseAddress.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny3});
            this.txtWarehouseAddress.CueHint.CueHintText = "Address";
            this.txtWarehouseAddress.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtWarehouseAddress.Location = new System.Drawing.Point(993, 16);
            this.txtWarehouseAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWarehouseAddress.Name = "txtWarehouseAddress";
            this.txtWarehouseAddress.Size = new System.Drawing.Size(269, 27);
            this.txtWarehouseAddress.TabIndex = 12;
            // 
            // buttonSpecAny3
            // 
            this.buttonSpecAny3.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.buttonSpecAny3.UniqueName = "6fb900f9fa524f45950d2ef28f395a0c";
            // 
            // btnAdd
            // 
            this.btnAdd.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btnAdd.Image = global::YRG_4915M.Properties.Resources.table_row_insert;
            this.btnAdd.Text = "Add New Warehouse";
            this.btnAdd.UniqueName = "bbcc922aef4a4918b6098de1d7111cad";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btnSaveEdit.Image = global::YRG_4915M.Properties.Resources.disk;
            this.btnSaveEdit.Text = "Save Edit";
            this.btnSaveEdit.UniqueName = "a9610e59ee934e8d91e6b3ad4fa544ae";
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // BasicFrmWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1687, 844);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BasicFrmWarehouse";
            this.Text = "YRGCPS Warehouse Management";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierInfo)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
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
        private Krypton.Toolkit.KryptonTextBox txtWarehouseID;
        private Krypton.Toolkit.ButtonSpecAny btnInfoIDCancel;
        private Krypton.Toolkit.KryptonLabel lblRestaurantTel;
        private Krypton.Toolkit.KryptonTextBox txtWarehouseTel;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny2;
        private Krypton.Toolkit.KryptonLabel lblWarehouseAddress;
        private Krypton.Toolkit.KryptonTextBox txtWarehouseAddress;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny3;
        private Krypton.Toolkit.ButtonSpecAny btnAdd;
        private Krypton.Toolkit.ButtonSpecAny btnSaveEdit;
    }
}