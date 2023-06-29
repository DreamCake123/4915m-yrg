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
using YRG_4915M.Database;

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
            if(txtUserID.Text == "" || txtPswd.Text == "")
            {
                return;
            }
            Dictionary<string, object> paramList = new Dictionary<string, object> ();
            paramList.Add("@userid", txtUserID.Text);
            List<object> dataRow = DatabaseAdapter.retrieveDataOneCol("SELECT [UserPswd] FROM [User] WHERE [UserName]=@userid;", paramList);
            if(dataRow.Count < 1)
            {
                MessageBox.Show("Incorrect username or password");
                return;
            }
            if ((string)dataRow[0] == txtPswd.Text)
            {
                UserSingleton.username = txtUserID.Text;
                FrmMain frmMain = new FrmMain();
                this.Hide();
                frmMain.Show();
            }
            else
            {
                MessageBox.Show("Incorrect username or password");
            }
        }

        private void btnCancelLogin_Click(object sender, EventArgs e)
        {
            txtUserID.Text = string.Empty;
            txtPswd.Text = string.Empty;
        }

        private void lblForgotPswd_Click(object sender, EventArgs e)
        {
            FrmForgotPswd frmForgotPswd = new FrmForgotPswd();
            this.Hide();
            frmForgotPswd.Show();
        }
    }
}
