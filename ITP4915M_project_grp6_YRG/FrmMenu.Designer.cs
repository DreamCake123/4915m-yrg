namespace ITP4915M_project_grp6_YRG
{
    partial class FrmMenu
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
            this.dockPanelMain = new Krypton.Docking.KryptonDockableNavigator();
            this.kryptonRequestManage = new Krypton.Navigator.KryptonPage();
            this.tableLayoutPanelBase = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonItemManage = new Krypton.Navigator.KryptonPage();
            this.kryptonAgreementManage = new Krypton.Navigator.KryptonPage();
            this.kryptonDashboard = new Krypton.Navigator.KryptonPage();
            this.kryptonPage5 = new Krypton.Navigator.KryptonPage();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dockPanelMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRequestManage)).BeginInit();
            this.kryptonRequestManage.SuspendLayout();
            this.tableLayoutPanelBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonItemManage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonAgreementManage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage5)).BeginInit();
            this.SuspendLayout();
            // 
            // dockPanelMain
            // 
            this.dockPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanelMain.Location = new System.Drawing.Point(0, 0);
            this.dockPanelMain.Name = "dockPanelMain";
            this.dockPanelMain.NavigatorMode = Krypton.Navigator.NavigatorMode.OutlookFull;
            this.dockPanelMain.PageBackStyle = Krypton.Toolkit.PaletteBackStyle.FormMain;
            this.dockPanelMain.Pages.AddRange(new Krypton.Navigator.KryptonPage[] {
            this.kryptonRequestManage,
            this.kryptonItemManage,
            this.kryptonAgreementManage,
            this.kryptonDashboard,
            this.kryptonPage5});
            this.dockPanelMain.SelectedIndex = 0;
            this.dockPanelMain.Size = new System.Drawing.Size(328, 1064);
            this.dockPanelMain.TabIndex = 0;
            this.dockPanelMain.Text = "kryptonDockableNavigator1";
            // 
            // kryptonRequestManage
            // 
            this.kryptonRequestManage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonRequestManage.Controls.Add(this.tableLayoutPanelBase);
            this.kryptonRequestManage.Flags = 65534;
            this.kryptonRequestManage.LastVisibleSet = true;
            this.kryptonRequestManage.MinimumSize = new System.Drawing.Size(150, 50);
            this.kryptonRequestManage.Name = "kryptonRequestManage";
            this.kryptonRequestManage.Size = new System.Drawing.Size(326, 822);
            this.kryptonRequestManage.Text = "Basic Information";
            this.kryptonRequestManage.TextDescription = "Basic Information";
            this.kryptonRequestManage.TextTitle = "Basic Information";
            this.kryptonRequestManage.ToolTipTitle = "Page ToolTip";
            this.kryptonRequestManage.UniqueName = "882fb5fd8212425d805e9b8be1b614f1";
            // 
            // tableLayoutPanelBase
            // 
            this.tableLayoutPanelBase.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tableLayoutPanelBase.ColumnCount = 3;
            this.tableLayoutPanelBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanelBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBase.Controls.Add(this.kryptonLabel1, 1, 0);
            this.tableLayoutPanelBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBase.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelBase.Name = "tableLayoutPanelBase";
            this.tableLayoutPanelBase.RowCount = 6;
            this.tableLayoutPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBase.Size = new System.Drawing.Size(326, 822);
            this.tableLayoutPanelBase.TabIndex = 0;
            // 
            // kryptonItemManage
            // 
            this.kryptonItemManage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonItemManage.Flags = 65534;
            this.kryptonItemManage.LastVisibleSet = true;
            this.kryptonItemManage.MinimumSize = new System.Drawing.Size(150, 50);
            this.kryptonItemManage.Name = "kryptonItemManage";
            this.kryptonItemManage.Size = new System.Drawing.Size(326, 822);
            this.kryptonItemManage.Text = "Request Management";
            this.kryptonItemManage.TextDescription = "Request Management";
            this.kryptonItemManage.TextTitle = "Request Management";
            this.kryptonItemManage.ToolTipTitle = "Page ToolTip";
            this.kryptonItemManage.UniqueName = "7d268c94df7e43e2a2f02eec18410e0e";
            // 
            // kryptonAgreementManage
            // 
            this.kryptonAgreementManage.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonAgreementManage.Flags = 65534;
            this.kryptonAgreementManage.LastVisibleSet = true;
            this.kryptonAgreementManage.MinimumSize = new System.Drawing.Size(150, 50);
            this.kryptonAgreementManage.Name = "kryptonAgreementManage";
            this.kryptonAgreementManage.Size = new System.Drawing.Size(326, 822);
            this.kryptonAgreementManage.Text = "Item Management";
            this.kryptonAgreementManage.TextDescription = "Item Management";
            this.kryptonAgreementManage.TextTitle = "Item Management";
            this.kryptonAgreementManage.ToolTipTitle = "Page ToolTip";
            this.kryptonAgreementManage.UniqueName = "2268293a882447c7b7ea61f7b2d6af31";
            // 
            // kryptonDashboard
            // 
            this.kryptonDashboard.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonDashboard.Flags = 65534;
            this.kryptonDashboard.LastVisibleSet = true;
            this.kryptonDashboard.MinimumSize = new System.Drawing.Size(150, 50);
            this.kryptonDashboard.Name = "kryptonDashboard";
            this.kryptonDashboard.Size = new System.Drawing.Size(326, 822);
            this.kryptonDashboard.Text = "Agreement Management";
            this.kryptonDashboard.TextDescription = "Agreement Management";
            this.kryptonDashboard.TextTitle = "Agreement Management";
            this.kryptonDashboard.ToolTipTitle = "Page ToolTip";
            this.kryptonDashboard.UniqueName = "68ea8ebcc96945bf9f64ccf535baad96";
            // 
            // kryptonPage5
            // 
            this.kryptonPage5.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage5.Flags = 65534;
            this.kryptonPage5.LastVisibleSet = true;
            this.kryptonPage5.MinimumSize = new System.Drawing.Size(150, 50);
            this.kryptonPage5.Name = "kryptonPage5";
            this.kryptonPage5.Size = new System.Drawing.Size(326, 822);
            this.kryptonPage5.Text = "Basic Information";
            this.kryptonPage5.ToolTipTitle = "Page ToolTip";
            this.kryptonPage5.UniqueName = "3597eaedf40045279c7a954b98724108";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(126, 3);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(74, 29);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "kryptonLabel1";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 1064);
            this.Controls.Add(this.dockPanelMain);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            ((System.ComponentModel.ISupportInitialize)(this.dockPanelMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRequestManage)).EndInit();
            this.kryptonRequestManage.ResumeLayout(false);
            this.tableLayoutPanelBase.ResumeLayout(false);
            this.tableLayoutPanelBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonItemManage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonAgreementManage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Docking.KryptonDockableNavigator dockPanelMain;
        private Krypton.Navigator.KryptonPage kryptonRequestManage;
        private Krypton.Navigator.KryptonPage kryptonItemManage;
        private Krypton.Navigator.KryptonPage kryptonAgreementManage;
        private Krypton.Navigator.KryptonPage kryptonDashboard;
        private Krypton.Navigator.KryptonPage kryptonPage5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBase;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}