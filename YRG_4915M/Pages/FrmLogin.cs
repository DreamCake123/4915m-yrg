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
using System.Data.OleDb;
using System.Data.Common;
using System.Collections.ObjectModel;
using System.Windows.Forms.VisualStyles;

namespace YRG_4915M
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            FrmMain frmMain = new FrmMain();
            this.Hide();
            frmMain.Show();
            // this.close();
        }

        private void btnCancelLogin_Click(object sender, EventArgs e)
        {
            txtUserID.Text = string.Empty;
            txtPswd.Text = string.Empty;
        }

        private void lblForgotPswd_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            FrmForgotPswd frmForgotPswd = new FrmForgotPswd();
            this.Hide();
            frmForgotPswd.Show();
        }
    }
}
