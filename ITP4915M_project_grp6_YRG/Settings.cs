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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void linklblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Logout f1 = new Logout();
            f1.ShowDialog();
            Application.Exit();
        }

        private void linklblSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
