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

namespace ITP4915M_project_grp6_YRG
{
    public partial class FrmHomePage : DockContent
    {
        private DataTable dt;
        public FrmHomePage()
        {
            InitializeComponent();
            string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=db.accdb";
            string sqlStr = "SELECT * FROM [Order]";

            dt = new DataTable();
            OleDbDataAdapter dataAdapter =
                    new OleDbDataAdapter(sqlStr, connStr);
            dataAdapter.Fill(dt);
            string f = "";
            for(int i = 0; i< dt.Rows.Count; i++)
            {
                f += dt.Rows[i]["Field1"];
            }
            textBox1.Text = f;

            dataAdapter.Dispose();
        }


    }
}
