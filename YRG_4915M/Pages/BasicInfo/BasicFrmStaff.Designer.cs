namespace YRG_4915M.Pages.BasicInfo
{
    partial class BasicFrmStaff
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
            this.dgvStaffInfo = new Krypton.Toolkit.KryptonDataGridView();
            this.kryptonHeader3 = new Krypton.Toolkit.KryptonHeader();
            this.kryptonHeader1 = new Krypton.Toolkit.KryptonHeader();
            this.btnDeleteStaff = new Krypton.Toolkit.ButtonSpecAny();
            this.btnSearchStaff = new Krypton.Toolkit.ButtonSpecAny();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSuppId = new Krypton.Toolkit.KryptonLabel();
            this.txtStaffId = new Krypton.Toolkit.KryptonTextBox();
            this.btnInfoIDCancel = new Krypton.Toolkit.ButtonSpecAny();
            this.lblSuppName = new Krypton.Toolkit.KryptonLabel();
            this.txtStaffName = new Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny1 = new Krypton.Toolkit.ButtonSpecAny();
            this.cbStaffType = new Krypton.Toolkit.KryptonComboBox();
            this.btnCancelStaffType = new Krypton.Toolkit.ButtonSpecAny();
            this.lblDept = new Krypton.Toolkit.KryptonLabel();
            this.lblSuppEmail = new Krypton.Toolkit.KryptonLabel();
            this.cbDept = new Krypton.Toolkit.KryptonComboBox();
            this.btnCancelDept = new Krypton.Toolkit.ButtonSpecAny();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblGender = new Krypton.Toolkit.KryptonLabel();
            this.rbGenderMale = new Krypton.Toolkit.KryptonRadioButton();
            this.rbGenderFemale = new Krypton.Toolkit.KryptonRadioButton();
            this.rbGenderX = new Krypton.Toolkit.KryptonRadioButton();
            this.lblSuppAddress = new Krypton.Toolkit.KryptonLabel();
            this.txtStaffEmail = new Krypton.Toolkit.KryptonTextBox();
            this.btnCancelStaffEmail = new Krypton.Toolkit.ButtonSpecAny();
            this.lblSuppTel = new Krypton.Toolkit.KryptonLabel();
            this.txtStaffTel = new Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny2 = new Krypton.Toolkit.ButtonSpecAny();
            this.lblJobTitle = new Krypton.Toolkit.KryptonLabel();
            this.txtJobTitle = new Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny3 = new Krypton.Toolkit.ButtonSpecAny();
            this.lblRestId = new Krypton.Toolkit.KryptonLabel();
            this.txtRestId = new Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny4 = new Krypton.Toolkit.ButtonSpecAny();
            this.kryptonHeader2 = new Krypton.Toolkit.KryptonHeader();
            this.btnAdd = new Krypton.Toolkit.ButtonSpecAny();
            this.btnSave = new Krypton.Toolkit.ButtonSpecAny();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffInfo)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbStaffType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDept)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvStaffInfo, 0, 5);
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
            // dgvStaffInfo
            // 
            this.dgvStaffInfo.AllowUserToAddRows = false;
            this.dgvStaffInfo.AllowUserToDeleteRows = false;
            this.dgvStaffInfo.AllowUserToResizeRows = false;
            this.dgvStaffInfo.ColumnHeadersHeight = 28;
            this.dgvStaffInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStaffInfo.Location = new System.Drawing.Point(3, 371);
            this.dgvStaffInfo.Name = "dgvStaffInfo";
            this.dgvStaffInfo.RowHeadersWidth = 75;
            this.dgvStaffInfo.RowTemplate.Height = 29;
            this.dgvStaffInfo.Size = new System.Drawing.Size(1892, 996);
            this.dgvStaffInfo.TabIndex = 8;
            // 
            // kryptonHeader3
            // 
            this.kryptonHeader3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeader3.HeaderStyle = Krypton.Toolkit.HeaderStyle.Form;
            this.kryptonHeader3.Location = new System.Drawing.Point(3, 326);
            this.kryptonHeader3.Name = "kryptonHeader3";
            this.kryptonHeader3.Size = new System.Drawing.Size(1892, 39);
            this.kryptonHeader3.TabIndex = 7;
            this.kryptonHeader3.Values.Description = "";
            this.kryptonHeader3.Values.Heading = "Staff Information";
            this.kryptonHeader3.Values.Image = global::YRG_4915M.Properties.Resources.application_form_magnify;
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.btnDeleteStaff,
            this.btnSearchStaff});
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
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btnDeleteStaff.Image = global::YRG_4915M.Properties.Resources.table_row_delete;
            this.btnDeleteStaff.Text = "Delete Staff";
            this.btnDeleteStaff.UniqueName = "c479132da6ba4c56863f52c6712fede5";
            this.btnDeleteStaff.Click += new System.EventHandler(this.btnDeleteStaff_Click);
            // 
            // btnSearchStaff
            // 
            this.btnSearchStaff.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btnSearchStaff.Image = global::YRG_4915M.Properties.Resources.magnifier;
            this.btnSearchStaff.Text = "Search";
            this.btnSearchStaff.UniqueName = "8d0470310cdc40eaa7db3181ff0e958a";
            this.btnSearchStaff.Click += new System.EventHandler(this.btnSearchStaff_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 13;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 377F));
            this.tableLayoutPanel2.Controls.Add(this.lblSuppId, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtStaffId, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblSuppName, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtStaffName, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbStaffType, 11, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblDept, 7, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblSuppEmail, 10, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbDept, 8, 1);
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
            this.lblSuppId.Size = new System.Drawing.Size(73, 29);
            this.lblSuppId.TabIndex = 0;
            this.lblSuppId.Values.Text = "Staff ID";
            // 
            // txtStaffId
            // 
            this.txtStaffId.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.btnInfoIDCancel});
            this.txtStaffId.CueHint.CueHintText = "ID";
            this.txtStaffId.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtStaffId.Location = new System.Drawing.Point(97, 20);
            this.txtStaffId.Name = "txtStaffId";
            this.txtStaffId.Size = new System.Drawing.Size(210, 31);
            this.txtStaffId.TabIndex = 6;
            // 
            // btnInfoIDCancel
            // 
            this.btnInfoIDCancel.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.btnInfoIDCancel.UniqueName = "6fb900f9fa524f45950d2ef28f395a0c";
            // 
            // lblSuppName
            // 
            this.lblSuppName.Location = new System.Drawing.Point(353, 20);
            this.lblSuppName.Name = "lblSuppName";
            this.lblSuppName.Size = new System.Drawing.Size(104, 29);
            this.lblSuppName.TabIndex = 1;
            this.lblSuppName.Values.Text = "Staff Name";
            // 
            // txtStaffName
            // 
            this.txtStaffName.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.txtStaffName.CueHint.CueHintText = "Name";
            this.txtStaffName.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtStaffName.Location = new System.Drawing.Point(463, 20);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(325, 31);
            this.txtStaffName.TabIndex = 10;
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.buttonSpecAny1.UniqueName = "6fb900f9fa524f45950d2ef28f395a0c";
            // 
            // cbStaffType
            // 
            this.cbStaffType.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.btnCancelStaffType});
            this.cbStaffType.CornerRoundingRadius = -1F;
            this.cbStaffType.CueHint.CueHintText = "Type";
            this.cbStaffType.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.cbStaffType.DropDownWidth = 156;
            this.cbStaffType.IntegralHeight = false;
            this.cbStaffType.Location = new System.Drawing.Point(1333, 20);
            this.cbStaffType.Name = "cbStaffType";
            this.cbStaffType.Size = new System.Drawing.Size(177, 29);
            this.cbStaffType.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbStaffType.TabIndex = 17;
            // 
            // btnCancelStaffType
            // 
            this.btnCancelStaffType.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btnCancelStaffType.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.btnCancelStaffType.UniqueName = "cbf571b13697416ca0e52aad2325ac3a";
            // 
            // lblDept
            // 
            this.lblDept.Location = new System.Drawing.Point(834, 20);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(111, 29);
            this.lblDept.TabIndex = 5;
            this.lblDept.Values.Text = "Department";
            // 
            // lblSuppEmail
            // 
            this.lblSuppEmail.Location = new System.Drawing.Point(1233, 20);
            this.lblSuppEmail.Name = "lblSuppEmail";
            this.lblSuppEmail.Size = new System.Drawing.Size(94, 29);
            this.lblSuppEmail.TabIndex = 1;
            this.lblSuppEmail.Values.Text = "Staff Type";
            // 
            // cbDept
            // 
            this.cbDept.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.btnCancelDept});
            this.cbDept.CornerRoundingRadius = -1F;
            this.cbDept.CueHint.CueHintText = "Department";
            this.cbDept.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.cbDept.DropDownWidth = 156;
            this.cbDept.IntegralHeight = false;
            this.cbDept.Location = new System.Drawing.Point(951, 20);
            this.cbDept.Name = "cbDept";
            this.cbDept.Size = new System.Drawing.Size(236, 29);
            this.cbDept.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbDept.TabIndex = 18;
            // 
            // btnCancelDept
            // 
            this.btnCancelDept.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btnCancelDept.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.btnCancelDept.UniqueName = "cbf571b13697416ca0e52aad2325ac3a";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoScroll = true;
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 12;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.lblGender, 7, 1);
            this.tableLayoutPanel3.Controls.Add(this.rbGenderMale, 8, 1);
            this.tableLayoutPanel3.Controls.Add(this.rbGenderFemale, 9, 1);
            this.tableLayoutPanel3.Controls.Add(this.rbGenderX, 10, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblSuppAddress, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtStaffEmail, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblSuppTel, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtStaffTel, 5, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblJobTitle, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtJobTitle, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblRestId, 4, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtRestId, 5, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 190);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1890, 128);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // lblGender
            // 
            this.lblGender.Location = new System.Drawing.Point(908, 20);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(72, 29);
            this.lblGender.TabIndex = 19;
            this.lblGender.Values.Text = "Gender";
            // 
            // rbGenderMale
            // 
            this.rbGenderMale.Location = new System.Drawing.Point(986, 20);
            this.rbGenderMale.Name = "rbGenderMale";
            this.rbGenderMale.Size = new System.Drawing.Size(65, 29);
            this.rbGenderMale.TabIndex = 20;
            this.rbGenderMale.Values.Text = "Male";
            // 
            // rbGenderFemale
            // 
            this.rbGenderFemale.Location = new System.Drawing.Point(1057, 20);
            this.rbGenderFemale.Name = "rbGenderFemale";
            this.rbGenderFemale.Size = new System.Drawing.Size(83, 29);
            this.rbGenderFemale.TabIndex = 21;
            this.rbGenderFemale.Values.Text = "Female";
            // 
            // rbGenderX
            // 
            this.rbGenderX.Location = new System.Drawing.Point(1146, 20);
            this.rbGenderX.Name = "rbGenderX";
            this.rbGenderX.Size = new System.Drawing.Size(35, 29);
            this.rbGenderX.TabIndex = 22;
            this.rbGenderX.Values.Text = "X";
            // 
            // lblSuppAddress
            // 
            this.lblSuppAddress.Location = new System.Drawing.Point(18, 20);
            this.lblSuppAddress.Name = "lblSuppAddress";
            this.lblSuppAddress.Size = new System.Drawing.Size(99, 29);
            this.lblSuppAddress.TabIndex = 0;
            this.lblSuppAddress.Values.Text = "Staff Email";
            // 
            // txtStaffEmail
            // 
            this.txtStaffEmail.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.btnCancelStaffEmail});
            this.txtStaffEmail.CueHint.CueHintText = "Email";
            this.txtStaffEmail.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtStaffEmail.Location = new System.Drawing.Point(123, 20);
            this.txtStaffEmail.Name = "txtStaffEmail";
            this.txtStaffEmail.Size = new System.Drawing.Size(325, 31);
            this.txtStaffEmail.TabIndex = 16;
            // 
            // btnCancelStaffEmail
            // 
            this.btnCancelStaffEmail.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.btnCancelStaffEmail.UniqueName = "6fb900f9fa524f45950d2ef28f395a0c";
            // 
            // lblSuppTel
            // 
            this.lblSuppTel.Location = new System.Drawing.Point(494, 20);
            this.lblSuppTel.Name = "lblSuppTel";
            this.lblSuppTel.Size = new System.Drawing.Size(83, 29);
            this.lblSuppTel.TabIndex = 2;
            this.lblSuppTel.Values.Text = "Staff Tel.";
            // 
            // txtStaffTel
            // 
            this.txtStaffTel.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny2});
            this.txtStaffTel.CueHint.CueHintText = "Tel.";
            this.txtStaffTel.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtStaffTel.Location = new System.Drawing.Point(623, 20);
            this.txtStaffTel.Name = "txtStaffTel";
            this.txtStaffTel.Size = new System.Drawing.Size(239, 31);
            this.txtStaffTel.TabIndex = 11;
            // 
            // buttonSpecAny2
            // 
            this.buttonSpecAny2.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.buttonSpecAny2.UniqueName = "6fb900f9fa524f45950d2ef28f395a0c";
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.Location = new System.Drawing.Point(18, 67);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(81, 29);
            this.lblJobTitle.TabIndex = 23;
            this.lblJobTitle.Values.Text = "Job Title";
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny3});
            this.txtJobTitle.CueHint.CueHintText = "Job Title";
            this.txtJobTitle.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtJobTitle.Location = new System.Drawing.Point(123, 67);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(325, 31);
            this.txtJobTitle.TabIndex = 24;
            // 
            // buttonSpecAny3
            // 
            this.buttonSpecAny3.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.buttonSpecAny3.UniqueName = "6fb900f9fa524f45950d2ef28f395a0c";
            // 
            // lblRestId
            // 
            this.lblRestId.Location = new System.Drawing.Point(494, 67);
            this.lblRestId.Name = "lblRestId";
            this.lblRestId.Size = new System.Drawing.Size(123, 29);
            this.lblRestId.TabIndex = 25;
            this.lblRestId.Values.Text = "Restaurant ID";
            // 
            // txtRestId
            // 
            this.txtRestId.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny4});
            this.txtRestId.CueHint.CueHintText = "(for Restaurant Manager)";
            this.txtRestId.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtRestId.Location = new System.Drawing.Point(623, 67);
            this.txtRestId.Name = "txtRestId";
            this.txtRestId.Size = new System.Drawing.Size(239, 31);
            this.txtRestId.TabIndex = 26;
            // 
            // buttonSpecAny4
            // 
            this.buttonSpecAny4.Image = global::YRG_4915M.Properties.Resources.cross_icon_16;
            this.buttonSpecAny4.UniqueName = "6fb900f9fa524f45950d2ef28f395a0c";
            // 
            // kryptonHeader2
            // 
            this.kryptonHeader2.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.btnAdd,
            this.btnSave});
            this.kryptonHeader2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonHeader2.HeaderStyle = Krypton.Toolkit.HeaderStyle.Form;
            this.kryptonHeader2.Location = new System.Drawing.Point(3, 143);
            this.kryptonHeader2.Name = "kryptonHeader2";
            this.kryptonHeader2.Size = new System.Drawing.Size(1892, 39);
            this.kryptonHeader2.StateCommon.ButtonPadding = new System.Windows.Forms.Padding(15, -1, -1, -1);
            this.kryptonHeader2.TabIndex = 6;
            this.kryptonHeader2.Values.Description = "";
            this.kryptonHeader2.Values.Heading = "Staff Details";
            this.kryptonHeader2.Values.Image = global::YRG_4915M.Properties.Resources.small_business;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::YRG_4915M.Properties.Resources.table_row_insert;
            this.btnAdd.Text = "Add New Staff";
            this.btnAdd.UniqueName = "a8e1c9a79eca47609aaa855bc2223816";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::YRG_4915M.Properties.Resources.disk;
            this.btnSave.Text = "Save Edit";
            this.btnSave.UniqueName = "6a38ab92ace24b4ca0b587ece4449e17";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // BasicFrmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1898, 1370);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BasicFrmStaff";
            this.Text = "YRGCPS Staff Information Management";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffInfo)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbStaffType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDept)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Krypton.Toolkit.KryptonDataGridView dgvStaffInfo;
        private Krypton.Toolkit.KryptonHeader kryptonHeader3;
        private Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private Krypton.Toolkit.ButtonSpecAny btnDeleteStaff;
        private Krypton.Toolkit.ButtonSpecAny btnSearchStaff;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Krypton.Toolkit.KryptonLabel lblSuppId;
        private Krypton.Toolkit.KryptonTextBox txtStaffId;
        private Krypton.Toolkit.ButtonSpecAny btnInfoIDCancel;
        private Krypton.Toolkit.KryptonLabel lblSuppName;
        private Krypton.Toolkit.KryptonTextBox txtStaffName;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private Krypton.Toolkit.KryptonLabel lblSuppTel;
        private Krypton.Toolkit.KryptonTextBox txtStaffTel;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Krypton.Toolkit.KryptonLabel lblDept;
        private Krypton.Toolkit.KryptonLabel lblSuppAddress;
        private Krypton.Toolkit.KryptonLabel lblSuppEmail;
        private Krypton.Toolkit.KryptonHeader kryptonHeader2;
        private Krypton.Toolkit.KryptonTextBox txtStaffEmail;
        private Krypton.Toolkit.ButtonSpecAny btnCancelStaffEmail;
        private Krypton.Toolkit.KryptonComboBox cbStaffType;
        private Krypton.Toolkit.ButtonSpecAny btnCancelStaffType;
        private Krypton.Toolkit.KryptonComboBox cbDept;
        private Krypton.Toolkit.ButtonSpecAny btnCancelDept;
        private Krypton.Toolkit.KryptonLabel lblGender;
        private Krypton.Toolkit.KryptonRadioButton rbGenderMale;
        private Krypton.Toolkit.KryptonRadioButton rbGenderFemale;
        private Krypton.Toolkit.KryptonRadioButton rbGenderX;
        private Krypton.Toolkit.KryptonLabel lblJobTitle;
        private Krypton.Toolkit.KryptonTextBox txtJobTitle;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny3;
        private Krypton.Toolkit.KryptonLabel lblRestId;
        private Krypton.Toolkit.KryptonTextBox txtRestId;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny4;
        private Krypton.Toolkit.ButtonSpecAny btnAdd;
        private Krypton.Toolkit.ButtonSpecAny btnSave;
    }
}