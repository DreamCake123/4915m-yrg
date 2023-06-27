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
<<<<<<< HEAD
            dock.Text = label.Text;
=======
            // dock.Text = label.Text;
>>>>>>> e186b4bd104961d8d8194ae2f665f8d61c2932bb
            dock.Show(FrmMain.FrmMain1.dockPanelMain);
        }



        // Basic Information
<<<<<<< HEAD
        private void lblBasicInfoStaff_Click(object sender, EventArgs e)
        {
            Pages.BasicInfo.BasicFrmStaff frm = new Pages.BasicInfo.BasicFrmStaff();
=======
        private void lblBasicInfoMajor_Click(object sender, EventArgs e)
        {
            Pages.BasicInfo.BasicFrmMajor frm = new Pages.BasicInfo.BasicFrmMajor();
>>>>>>> e186b4bd104961d8d8194ae2f665f8d61c2932bb
            var lbl = sender as KryptonLabel;

            OpenSubFrom(frm, lbl);
        }

<<<<<<< HEAD
        private void lblBasicInfoSupplier_Click(object sender, EventArgs e)
        {
            Pages.BasicInfo.BasicFrmSupplier frm = new Pages.BasicInfo.BasicFrmSupplier();
=======
        private void lblBasicInfoMinor_Click(object sender, EventArgs e)
        {
            Pages.BasicInfo.BasicFrmMinor frm = new Pages.BasicInfo.BasicFrmMinor();
>>>>>>> e186b4bd104961d8d8194ae2f665f8d61c2932bb
            var lbl = sender as KryptonLabel;

            OpenSubFrom(frm, lbl);
        }

<<<<<<< HEAD
        private void lblBasicInfoRestaurant_Click(object sender, EventArgs e)
        {
            Pages.BasicInfo.BasicFrmRestaurant frm = new Pages.BasicInfo.BasicFrmRestaurant();
=======
        private void lblBasicInfoTable3_Click(object sender, EventArgs e)
        {
            Pages.BasicInfo.BasicFrmTable3 frm = new Pages.BasicInfo.BasicFrmTable3();
>>>>>>> e186b4bd104961d8d8194ae2f665f8d61c2932bb
            var lbl = sender as KryptonLabel;

            OpenSubFrom(frm, lbl);
        }

<<<<<<< HEAD
        private void lblBasicInfoWarehouse_Click(object sender, EventArgs e)
        {
            Pages.BasicInfo.BasicFrmWarehouse frm = new Pages.BasicInfo.BasicFrmWarehouse();
=======
        private void lblBasicInfoTable4_Click(object sender, EventArgs e)
        {
            Pages.BasicInfo.BasicFrmTable4 frm = new Pages.BasicInfo.BasicFrmTable4();
>>>>>>> e186b4bd104961d8d8194ae2f665f8d61c2932bb
            var lbl = sender as KryptonLabel;

            OpenSubFrom(frm, lbl);
        }
<<<<<<< HEAD
        private void lblBasicInfoYourAccount_Click(object sender, EventArgs e)
        {
            
        }

        // Request Management
        private void lblRequestRM_Click(object sender, EventArgs e)
        {
            Pages.RequestManagement.RequestFrmRestaurantManager frm = new Pages.RequestManagement.RequestFrmRestaurantManager();
=======


        // Request Management
        private void lblRequestMajor_Click(object sender, EventArgs e)
        {
            Pages.RequestManagement.RequestFrmMajor frm = new Pages.RequestManagement.RequestFrmMajor();
>>>>>>> e186b4bd104961d8d8194ae2f665f8d61c2932bb
            var lbl = sender as KryptonLabel;

            OpenSubFrom(frm, lbl);
        }

<<<<<<< HEAD
        private void lblRequestPM_Click(object sender, EventArgs e)
        {
            Pages.RequestManagement.RequestFrmPurchaseManager frm = new Pages.RequestManagement.RequestFrmPurchaseManager();
=======
        private void lblRequestMinor_Click(object sender, EventArgs e)
        {
            Pages.RequestManagement.RequestFrmMinor frm = new Pages.RequestManagement.RequestFrmMinor();
>>>>>>> e186b4bd104961d8d8194ae2f665f8d61c2932bb
            var lbl = sender as KryptonLabel;

            OpenSubFrom(frm, lbl);
        }

        private void lblRequestTable3_Click(object sender, EventArgs e)
<<<<<<< HEAD
        { }


        //Stock Count
        private void lblWarehouseStockCount_Click(object sender, EventArgs e)
        {
            Pages.StockManagement.StockFrmWarehouse frm = new Pages.StockManagement.StockFrmWarehouse();
=======
        {
            Pages.RequestManagement.RequestFrmTable3 frm = new Pages.RequestManagement.RequestFrmTable3();
>>>>>>> e186b4bd104961d8d8194ae2f665f8d61c2932bb
            var lbl = sender as KryptonLabel;

            OpenSubFrom(frm, lbl);
        }

<<<<<<< HEAD
        private void lblRestaurantStockCount_Click(object sender, EventArgs e)
        {
            Pages.StockManagement.StockFrmRestaurant frm = new Pages.StockManagement.StockFrmRestaurant();
=======

        //Stock Management
        private void lblWarehouseStock_Click(object sender, EventArgs e)
        {
            Pages.StockManagement.StockFrmMajor frm = new Pages.StockManagement.StockFrmMajor();
            var lbl = sender as KryptonLabel;

            OpenSubFrom(frm, lbl);
        }

        private void lblRestaurantStock_Click(object sender, EventArgs e)
        {
            Pages.StockManagement.StockFrmMinor frm = new Pages.StockManagement.StockFrmMinor();
>>>>>>> e186b4bd104961d8d8194ae2f665f8d61c2932bb
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

<<<<<<< HEAD
        private void lblItemItems_Click(object sender, EventArgs e)
        {
            Pages.ItemManagement.ItemFrmItems frm = new Pages.ItemManagement.ItemFrmItems();
=======
        private void lblItemMinor_Click(object sender, EventArgs e)
        {
            Pages.ItemManagement.ItemFrmMinor frm = new Pages.ItemManagement.ItemFrmMinor();
>>>>>>> e186b4bd104961d8d8194ae2f665f8d61c2932bb
            var lbl = sender as KryptonLabel;

            OpenSubFrom(frm, lbl);
        }


        // Agreement Management
<<<<<<< HEAD
        private void lblAgreementView_Click(object sender, EventArgs e)
        {
            Pages.AgreementManagement.AgreeFrmView frm = new Pages.AgreementManagement.AgreeFrmView();
=======
        private void lblAgreeMajor_Click(object sender, EventArgs e)
        {
            Pages.AgreementManagement.AgreeFrmMajor frm = new Pages.AgreementManagement.AgreeFrmMajor();
>>>>>>> e186b4bd104961d8d8194ae2f665f8d61c2932bb
            var lbl = sender as KryptonLabel;

            OpenSubFrom(frm, lbl);
        }

<<<<<<< HEAD
        private void lblAgreementBPA_Click(object sender, EventArgs e)
        {
            Pages.AgreementManagement.AgreeFrmBPA frm = new Pages.AgreementManagement.AgreeFrmBPA();
=======
        private void lblAgreeMinor_Click(object sender, EventArgs e)
        {
            Pages.AgreementManagement.AgreeFrmMinor frm = new Pages.AgreementManagement.AgreeFrmMinor();
>>>>>>> e186b4bd104961d8d8194ae2f665f8d61c2932bb
            var lbl = sender as KryptonLabel;

            OpenSubFrom(frm, lbl);
        }

        private void lblAgreeTable3_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Pages.AgreementManagement.AgreeFrmCPA frm = new Pages.AgreementManagement.AgreeFrmCPA();
=======
            Pages.AgreementManagement.AgreeFrmTable3 frm = new Pages.AgreementManagement.AgreeFrmTable3();
>>>>>>> e186b4bd104961d8d8194ae2f665f8d61c2932bb
            var lbl = sender as KryptonLabel;

            OpenSubFrom(frm, lbl);
        }


<<<<<<< HEAD
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

=======
>>>>>>> e186b4bd104961d8d8194ae2f665f8d61c2932bb

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
<<<<<<< HEAD

        
=======
>>>>>>> e186b4bd104961d8d8194ae2f665f8d61c2932bb
    }
}
