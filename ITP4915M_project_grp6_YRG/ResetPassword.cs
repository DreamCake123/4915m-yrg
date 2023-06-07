using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915M_project_grp6_YRG
{
    public partial class formResetPswd : Form
    {
        public formResetPswd()
        {
            InitializeComponent();
        }

        private void txtUserId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRequest_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            formLogin f1 = new formLogin();
            f1.ShowDialog();
            Application.Exit();
        }
    }
}
