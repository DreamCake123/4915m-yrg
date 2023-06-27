namespace YRG_4915M
{
    partial class FrmHomePage
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
            this.components = new System.ComponentModel.Container();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnInsertItem = new Krypton.Toolkit.KryptonButton();
            this.btnInsertRequest = new Krypton.Toolkit.KryptonButton();
            this.tbItemName = new Krypton.Toolkit.KryptonTextBox();
            this.tbItemType = new Krypton.Toolkit.KryptonTextBox();
            this.tbRequestStatus = new Krypton.Toolkit.KryptonTextBox();
            this.tbRequestNumber = new Krypton.Toolkit.KryptonTextBox();
            this.tbPkId = new Krypton.Toolkit.KryptonTextBox();
            this.HeaderText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemStyle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataDisplayView = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsertItem
            // 
            this.btnInsertItem.CornerRoundingRadius = -1F;
            this.btnInsertItem.Location = new System.Drawing.Point(944, 15);
            this.btnInsertItem.Name = "btnInsertItem";
            this.btnInsertItem.Size = new System.Drawing.Size(200, 30);
            this.btnInsertItem.TabIndex = 1;
            this.btnInsertItem.Values.Text = "Insert New Item";
            // 
            // btnInsertRequest
            // 
            this.btnInsertRequest.CornerRoundingRadius = -1F;
            this.btnInsertRequest.Location = new System.Drawing.Point(944, 186);
            this.btnInsertRequest.Name = "btnInsertRequest";
            this.btnInsertRequest.Size = new System.Drawing.Size(200, 30);
            this.btnInsertRequest.TabIndex = 2;
            this.btnInsertRequest.Values.Text = "Insert New Request";
            // 
            // tbItemName
            // 
            this.tbItemName.Location = new System.Drawing.Point(1001, 65);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.Size = new System.Drawing.Size(143, 32);
            this.tbItemName.TabIndex = 3;
            this.tbItemName.Text = "Item Name";
            // 
            // tbItemType
            // 
            this.tbItemType.Location = new System.Drawing.Point(1150, 65);
            this.tbItemType.Name = "tbItemType";
            this.tbItemType.Size = new System.Drawing.Size(143, 32);
            this.tbItemType.TabIndex = 4;
            this.tbItemType.Text = "Item Type";
            // 
            // tbRequestStatus
            // 
            this.tbRequestStatus.Location = new System.Drawing.Point(1001, 234);
            this.tbRequestStatus.Name = "tbRequestStatus";
            this.tbRequestStatus.Size = new System.Drawing.Size(143, 32);
            this.tbRequestStatus.TabIndex = 5;
            this.tbRequestStatus.Text = "Request Status";
            // 
            // tbRequestNumber
            // 
            this.tbRequestNumber.Location = new System.Drawing.Point(1150, 234);
            this.tbRequestNumber.Name = "tbRequestNumber";
            this.tbRequestNumber.Size = new System.Drawing.Size(143, 32);
            this.tbRequestNumber.TabIndex = 6;
            this.tbRequestNumber.Text = "Request Item ID";
            // 
            // tbPkId
            // 
            this.tbPkId.Location = new System.Drawing.Point(1001, 286);
            this.tbPkId.Name = "tbPkId";
            this.tbPkId.Size = new System.Drawing.Size(143, 32);
            this.tbPkId.TabIndex = 7;
            this.tbPkId.Text = "Insert By ID";
            // 
            // dataDisplayView
            // 
            this.dataDisplayView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HeaderText,
            this.DataField,
            this.ItemStyle});
            this.dataDisplayView.HideSelection = false;
            this.dataDisplayView.Location = new System.Drawing.Point(36, 15);
            this.dataDisplayView.Name = "dataDisplayView";
            this.dataDisplayView.Size = new System.Drawing.Size(881, 491);
            this.dataDisplayView.TabIndex = 8;
            this.dataDisplayView.UseCompatibleStateImageBehavior = false;
            // 
            // FrmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1424);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.dataDisplayView);
            this.Controls.Add(this.tbPkId);
            this.Controls.Add(this.tbRequestNumber);
            this.Controls.Add(this.tbRequestStatus);
            this.Controls.Add(this.tbItemType);
            this.Controls.Add(this.tbItemName);
            this.Controls.Add(this.btnInsertRequest);
            this.Controls.Add(this.btnInsertItem);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)(((((WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockTop) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockBottom) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.Document)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmHomePage";
            this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.Document;
            this.Text = "Home Page";
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource orderBindingSource;
        private Krypton.Toolkit.KryptonButton btnInsertItem;
        private Krypton.Toolkit.KryptonButton btnInsertRequest;
        private Krypton.Toolkit.KryptonTextBox tbItemName;
        private Krypton.Toolkit.KryptonTextBox tbItemType;
        private Krypton.Toolkit.KryptonTextBox tbRequestStatus;
        private Krypton.Toolkit.KryptonTextBox tbRequestNumber;
        private Krypton.Toolkit.KryptonTextBox tbPkId;
        private System.Windows.Forms.ColumnHeader HeaderText;
        private System.Windows.Forms.ColumnHeader DataField;
        private System.Windows.Forms.ColumnHeader ItemStyle;
        private System.Windows.Forms.ListView dataDisplayView;
    }
}