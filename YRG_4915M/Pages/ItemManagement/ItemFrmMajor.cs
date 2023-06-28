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
using System.Data.OleDb;
using System.Data.Common;
using System.Collections.ObjectModel;
using System.Windows.Forms.VisualStyles;
using System.Configuration;
using System.Windows.Controls;
using System.Data.SqlClient;
using YRG_4915M.Database;

namespace YRG_4915M.Pages.ItemManagement
{
    public partial class ItemFrmMajor : DockContent
    {
        const string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=db.accdb";
        string sqlStr = "";
        DataTable dt;
        OleDbDataAdapter dataAdapter;

        public ItemFrmMajor()
        {
            InitializeComponent();
            initItemTypes();
        }
        private void initItemTypes()
        {
            List<object> dataRows = DatabaseAdapter.retrieveDataOneCol("SELECT [ItemTypeList] FROM [UtilTable];");
            foreach (string row in dataRows)
            {
                cbItemType.Items.Add(row);
            }
        }

        private void btnItemIDCancel_Click(object sender, EventArgs e)
        {
            txtItemID.Text = string.Empty;
        }

        private void btnItemNameCancel_Click(object sender, EventArgs e)
        {
            txtItemName.Text = string.Empty;
        }

        //
        private void Form1_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Item";
            // dgvItemMajor.DataSource = dbHelper.ExecuteQuery(query);
        }

        private void tlpItemSearch_Paint(object sender, PaintEventArgs e)
        {

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
using System.Data.OleDb;
using System.Data.Common;
using System.Collections.ObjectModel;
using System.Windows.Forms.VisualStyles;
using System.Configuration;
using System.Windows.Controls;
using System.Data.SqlClient;
using YRG_4915M.Database;

namespace YRG_4915M.Pages.ItemManagement
{
    public partial class ItemFrmMajor : DockContent
    {
        const string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=db.accdb";
        string sqlStr = "";
        DataTable dt;
        OleDbDataAdapter dataAdapter;

        public ItemFrmMajor()
        {
            InitializeComponent();
            initItemTypes();
        }
        private void initItemTypes()
        {
            List<object> dataRows = DatabaseAdapter.retrieveDataOneCol("SELECT [ItemTypeList] FROM [UtilTable];");
            foreach (string row in dataRows)
            {
                cbItemType.Items.Add(row);
            }
        }

        private void btnItemIDCancel_Click(object sender, EventArgs e)
        {
            txtItemID.Text = string.Empty;
        }

        private void btnItemNameCancel_Click(object sender, EventArgs e)
        {
            txtItemName.Text = string.Empty;
        }

        //
        private void Form1_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Item";
            // dgvItemMajor.DataSource = dbHelper.ExecuteQuery(query);
        }

        private void tlpItemSearch_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
>>>>>>> e3039030246399001b6a193ac0434d0ab124b1f7
