using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YRG_4915M
{
    public partial class FrmForgotPswd : Form
    {
        public FrmForgotPswd()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            FrmForgotPswd frmForgot = new FrmForgotPswd();
            FrmLogin frmLogin = new FrmLogin();
            this.Hide();
            frmLogin.Show();
        }

        private void btnCancelLogin_Click(object sender, EventArgs e)
        {
            txtUserID.Text = string.Empty;
            txtUserEmail.Text = string.Empty;
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            FrmForgotPswd frmForgotPswd = new FrmForgotPswd();
            FrmLogin frmLogin = new FrmLogin();
            this.Hide();
            frmLogin.Show();
        }

    }
}
