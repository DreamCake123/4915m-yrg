using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;
using Krypton.Docking;
using Krypton.Navigator;
using Krypton.Workspace;
using WeifenLuo.WinFormsUI.Docking;

namespace YRG_4915M
{
    public partial class FrmMenu : DockContent
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        public void OpenSubFrom(DockContent dock, KryptonLabel label)
        {
            foreach (DockContent item in FrmMain.FrmMain1.dockPanelMain.Contents)
            {
                if (item.Name.Equals(dock.Name))
                {
                    item.Text = label.Text;
                    item.Activate();
                    return;
                }
            }
            dock.Text = label.Text;
            dock.Show(FrmMain.FrmMain1.dockPanelMain);
        }



        // Basic Information
        private void lblBasicInfoStaff_Click(object sender, EventArgs e)
        {
            Pages.BasicInfo.BasicFrmStaff frm = new Pages.BasicInfo.BasicFrmStaff();
            var lbl = sender as KryptonLabel;

            OpenSubFrom(frm, lbl);
        }

        private void lblBasicInfoSupplier_Click(object sender, EventArgs e)
        {
            Pages.BasicInfo.BasicFrmSupplier frm = new Pages.BasicInfo.BasicFrmSupplier();
            var lbl = sender as KryptonLabel;

            OpenSubFrom(frm, lbl);
        }

        private void lblBasicInfoRestaurant_Click(object sender, EventArgs e)
        {
            Pages.BasicInfo.BasicFrmRestaurant frm = new Pages.BasicInfo.BasicFrmRestaurant();
            var lbl = sender as KryptonLabel;

            OpenSubFrom(frm, lbl);
        }

        private void lblBasicInfoWarehouse_Click(object sender, EventArgs e)
        {
            Pages.BasicInfo.BasicFrmWarehouse frm = new Pages.BasicInfo.BasicFrmWarehouse();
            var lbl = sender as KryptonLabel;

            OpenSubFrom(frm, lbl);
        }
        private void lblBasicInfoYourAccount_Click(object sender, EventArgs e)
        {
            
        }

        // Request Management
        private void lblRequestRM_Click(object sender, EventArgs e)
        {
            Pages.RequestManagement.RequestFrmRestaurantManager frm = new Pages.RequestManagement.RequestFrmRestaurantManager();
            var lbl = sender as KryptonLabel;

            OpenSubFrom(frm, lbl);
        }

        private void lblRequestPM_Click(object sender, EventArgs e)
        {
            Pages.RequestManagement.RequestFrmPurchaseManager frm = new Pages.RequestManagement.RequestFrmPurchaseManager();
            var lbl = sender as KryptonLabel;

            OpenSubFrom(frm, lbl);
        }

        private void lblRequestTable3_Click(object sender, EventArgs e)
        { }


        //Stock Count
        private void lblWarehouseStockCount_Click(object sender, EventArgs e)
        {
            Pages.StockManagement.StockFrmWarehouse frm = new Pages.StockManagement.StockFrmWarehouse();
            var lbl = sender as KryptonLabel;

            OpenSubFrom(frm, lbl);
        }

        private void lblRestaurantStockCount_Click(object sender, EventArgs e)
        {
            Pages.StockManagement.StockFrmRestaurant frm = new Pages.StockManagement.StockFrmRestaurant();
            var lbl = sender as KryptonLabel;

            OpenSubFrom(frm, lbl);
        }


        // Item Management
        private void lblItemMajor_Click(object sender, EventArgs e)
        {
            Pages.ItemManagement.ItemFrmMajor frm = new Pages.ItemManagement.ItemFrmMajor();
            var lbl = sender as KryptonLabel;

            OpenSubFrom(frm, lbl);
        }

        private void lblItemItems_Click(object sender, EventArgs e)
        {
            Pages.ItemManagement.ItemFrmItems frm = new Pages.ItemManagement.ItemFrmItems();
            var lbl = sender as KryptonLabel;

            OpenSubFrom(frm, lbl);
        }


        // Agreement Management
        private void lblAgreementView_Click(object sender, EventArgs e)
        {
            Pages.AgreementManagement.AgreeFrmView frm = new Pages.AgreementManagement.AgreeFrmView();
            var lbl = sender as KryptonLabel;

            OpenSubFrom(frm, lbl);
        }

        private void lblAgreementBPA_Click(object sender, EventArgs e)
        {
            Pages.AgreementManagement.AgreeFrmBPA frm = new Pages.AgreementManagement.AgreeFrmBPA();
            var lbl = sender as KryptonLabel;

            OpenSubFrom(frm, lbl);
        }

        private void lblAgreeTable3_Click(object sender, EventArgs e)
        {
            Pages.AgreementManagement.AgreeFrmCPA frm = new Pages.AgreementManagement.AgreeFrmCPA();
            var lbl = sender as KryptonLabel;

            OpenSubFrom(frm, lbl);
        }


        //Order Management
        private void lblPurchaseManager_Click(object sender, EventArgs e)
        {
            Pages.OrderManagement.OrderFrmManager frm = new Pages.OrderManagement.OrderFrmManager();
            var lbl = sender as KryptonLabel;

            OpenSubFrom(frm, lbl);
        }

        private void lblOrderSupplier_Click(object sender, EventArgs e)
        {
            Pages.OrderManagement.OrderFrmSupplier frm = new Pages.OrderManagement.OrderFrmSupplier();
            var lbl = sender as KryptonLabel;

            OpenSubFrom(frm, lbl);
        }

        private void lblOrderWarehouse_Click(object sender, EventArgs e)
        {
            Pages.OrderManagement.OrderFrmWarehouse frm = new Pages.OrderManagement.OrderFrmWarehouse();
            var lbl = sender as KryptonLabel;

            OpenSubFrom(frm, lbl);
        }
        private void lblOrderAccounting_Click(object sender, EventArgs e)
        {
            Pages.OrderManagement.OrderFrmAccounting frm = new Pages.OrderManagement.OrderFrmAccounting();
            var lbl = sender as KryptonLabel;

            OpenSubFrom(frm, lbl);
        }


        // Report
        private void lblReportMajor_Click(object sender, EventArgs e)
        {
            Pages.Report.ReportFrmMajor frm = new Pages.Report.ReportFrmMajor();
            var lbl = sender as KryptonLabel;

            OpenSubFrom(frm, lbl);
        }

        private void lblReportMinor_Click(object sender, EventArgs e)
        {
            Pages.Report.ReportFrmMinor frm = new Pages.Report.ReportFrmMinor();
            var lbl = sender as KryptonLabel;

            OpenSubFrom(frm, lbl);
        }

        private void lblReportTable3_Click(object sender, EventArgs e)
        {
            Pages.Report.ReportFrmTable3 frm = new Pages.Report.ReportFrmTable3();
            var lbl = sender as KryptonLabel;

            OpenSubFrom(frm, lbl);
        }

        
    }
}
