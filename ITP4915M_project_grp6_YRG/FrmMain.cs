using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace ITP4915M_project_grp6_YRG
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmHomePage homePage = new FrmHomePage();
            homePage.Show(dockPanelMain);

            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show(dockPanelMain,DockState.DockLeft);
            dockPanelMain.DockLeftPortion = 200;
        }
    }
}
