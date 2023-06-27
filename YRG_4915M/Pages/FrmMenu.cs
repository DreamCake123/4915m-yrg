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
            // dock.Text = label.Text;
            dock.Show(FrmMain.FrmMain1.dockPanelMain);
        }



        // Basic Information
        private void lblBasicInfoMajor_Click(object sender, EventArgs e)
        {
            Pages.BasicInfo.BasicFrmMajor frm = new Pages.BasicInfo.BasicFrmMajor();
            var lbl = sender as KryptonLabel;

            OpenSubFrom(frm, lbl);
        }

        private void lblBasicInfoMinor_Click(object sender, EventArgs e)
        {
            Pages.BasicInfo.BasicFrmMinor frm = new Pages.BasicInfo.BasicFrmMinor();
            var lbl = sender as KryptonLabel;

            OpenSubFrom(frm, lbl);
        }

        private void lblBasicInfoTable3_Click(object sender, EventArgs e)
        {
            Pages.BasicInfo.BasicFrmTable3 frm = new Pages.BasicInfo.BasicFrmTable3();
            var lbl = sender as KryptonLabel;

            OpenSubFrom(frm, lbl);
        }

        private void lblBasicInfoTable4_Click(object sender, EventArgs e)
        {
            Pages.BasicInfo.BasicFrmTable4 frm = new Pages.BasicInfo.BasicFrmTable4();
            var lbl = sender as KryptonLabel;

            OpenSubFrom(frm, lbl);
        }


        // Request Management
        private void lblRequestMajor_Click(object sender, EventArgs e)
        {
            Pages.RequestManagement.RequestFrmMajor frm = new Pages.RequestManagement.RequestFrmMajor();
            var lbl = sender as KryptonLabel;

            OpenSubFrom(frm, lbl);
        }

        private void lblRequestMinor_Click(object sender, EventArgs e)
        {
            Pages.RequestManagement.RequestFrmMinor frm = new Pages.RequestManagement.RequestFrmMinor();
            var lbl = sender as KryptonLabel;

            OpenSubFrom(frm, lbl);
        }

        private void lblRequestTable3_Click(object sender, EventArgs e)
        {
            Pages.RequestManagement.RequestFrmTable3 frm = new Pages.RequestManagement.RequestFrmTable3();
            var lbl = sender as KryptonLabel;

            OpenSubFrom(frm, lbl);
        }


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

        private void lblItemMinor_Click(object sender, EventArgs e)
        {
            Pages.ItemManagement.ItemFrmMinor frm = new Pages.ItemManagement.ItemFrmMinor();
            var lbl = sender as KryptonLabel;

            OpenSubFrom(frm, lbl);
        }


        // Agreement Management
        private void lblAgreeMajor_Click(object sender, EventArgs e)
        {
            Pages.AgreementManagement.AgreeFrmMajor frm = new Pages.AgreementManagement.AgreeFrmMajor();
            var lbl = sender as KryptonLabel;

            OpenSubFrom(frm, lbl);
        }

        private void lblAgreeMinor_Click(object sender, EventArgs e)
        {
            Pages.AgreementManagement.AgreeFrmMinor frm = new Pages.AgreementManagement.AgreeFrmMinor();
            var lbl = sender as KryptonLabel;

            OpenSubFrom(frm, lbl);
        }

        private void lblAgreeTable3_Click(object sender, EventArgs e)
        {
            Pages.AgreementManagement.AgreeFrmTable3 frm = new Pages.AgreementManagement.AgreeFrmTable3();
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
