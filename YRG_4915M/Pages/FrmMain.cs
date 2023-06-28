<<<<<<< HEAD
﻿using System;
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
    public partial class FrmMain : Form
    {
        public static FrmMain FrmMain1;

        public FrmMain()
        {
            InitializeComponent();
            FrmMain1 = this;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmHomePage homePage = new FrmHomePage();
            homePage.Show(dockPanelMain);

            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show(dockPanelMain,DockState.DockLeft);
            dockPanelMain.DockLeftPortion = 165;
        }

        public void OpenSubFrom(DockContent dock)
        {
            foreach (DockContent item in FrmMain.FrmMain1.dockPanelMain.Contents)
            {
                if (item.Name.Equals(dock.Name))
                {
                    item.Activate();
                    return;
                }
            }
            dock.Show(FrmMain.FrmMain1.dockPanelMain);
        }

        private void toolStripMenuItemAccount_Click(object sender, EventArgs e)
        {
            Pages.FrmAccount frm = new Pages.FrmAccount();

            OpenSubFrom(frm);
        }

        private void toolStripMenuItemLogout_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
=======
﻿using System;
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
    public partial class FrmMain : Form
    {
        public static FrmMain FrmMain1;

        public FrmMain()
        {
            InitializeComponent();
            FrmMain1 = this;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmHomePage homePage = new FrmHomePage();
            homePage.Show(dockPanelMain);

            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show(dockPanelMain,DockState.DockLeft);
            dockPanelMain.DockLeftPortion = 165;
        }

        public void OpenSubFrom(DockContent dock)
        {
            foreach (DockContent item in FrmMain.FrmMain1.dockPanelMain.Contents)
            {
                if (item.Name.Equals(dock.Name))
                {
                    item.Activate();
                    return;
                }
            }
            dock.Show(FrmMain.FrmMain1.dockPanelMain);
        }

        private void toolStripMenuItemAccount_Click(object sender, EventArgs e)
        {
            Pages.FrmAccount frm = new Pages.FrmAccount();

            OpenSubFrom(frm);
        }

        private void toolStripMenuItemLogout_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
>>>>>>> e3039030246399001b6a193ac0434d0ab124b1f7
