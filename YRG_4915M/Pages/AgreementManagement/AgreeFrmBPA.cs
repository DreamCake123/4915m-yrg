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
using WeifenLuo.WinFormsUI.Docking;
using YRG_4915M.Database;

namespace YRG_4915M.Pages.AgreementManagement
{
    public partial class AgreeFrmBPA : DockContent
    {
        public AgreeFrmBPA()
        {
            InitializeComponent();
            initCurrency();
            showData();
        }
        //===============================
        private void initCurrency()
        {
            cbCurrency.Items.Add("*All*");
            List<object> dataRows = DatabaseAdapter.retrieveDataOneCol("SELECT [CurrencyList] FROM [UtilTable];");
            List<string> cbListValues = new List<string>();
            foreach (object o in dataRows)
            {
                if (o != DBNull.Value)
                {
                    cbListValues.Add((string)o);
                }
            }
            foreach (string s in cbListValues)
            {
                cbCurrency.Items.Add(s);
            }
            cbCurrency.SelectedIndex = 0;
        }
        private void showData()
        {
            DataSet dataSet = DatabaseAdapter.retrieveDataSet("SELECT [AgreementID], [SupplierID], [Currency], [CreateDate], [EffectiveDate], [ItemCategory], [ItemDesc] FROM [Agreement] WHERE [AgreementType]='BPA';");
            dgvBPA.DataSource = dataSet.Tables[0];
            dgvBPA.ClearSelection();
            dgvBPA.CurrentCell = null;
        }
        private void showData(Dictionary<string, string> conditions)
        {
            Dictionary<string, object> paramList = new Dictionary<string, object>();
            foreach (KeyValuePair<string, string> entry in conditions)
            {
                paramList.Add(entry.Key, $"%{entry.Value}%");
            }
            DataSet dataSet = DatabaseAdapter.retrieveDataSet(
                "SELECT * FROM [Agreement]" +
                "WHERE [AgreementType]='BPA' AND [AgreementID] LIKE ? AND [SupplierID] LIKE ? AND [Currency] LIKE ?;",
                paramList);
            dgvBPA.DataSource = dataSet.Tables[0];
            dgvBPA.ClearSelection();
            dgvBPA.CurrentCell = null;
        }
        //===============================
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtBPAID.Text != "" || kryptonTextBox2.Text != "" || cbCurrency.SelectedIndex >= 0)
            {
                Dictionary<string, string> conditions = new Dictionary<string, string>();
                conditions.Add("@ID", txtBPAID.Text);
                conditions.Add("@supplierID", kryptonTextBox2.Text);
                if (cbCurrency.SelectedIndex < 0 || cbCurrency.Items[cbCurrency.SelectedIndex].ToString().Equals("*All*"))
                {
                    conditions.Add("@currency", "");
                }
                else
                {
                    conditions.Add("@currency", cbCurrency.Items[cbCurrency.SelectedIndex].ToString());
                }
                showData(conditions);
            }
            else
            {
                showData();
            }
        }
        //===============================
        private void onDataUpdated(object sender, EventArgs e)
        {
            showData();
        }
        //===============================
        private void btnCreate_Click(object sender, EventArgs e)
        {
            AgreeFrmCreateBPA frmCreateBPA = new AgreeFrmCreateBPA();
            frmCreateBPA.dataChanged += onDataUpdated;
            frmCreateBPA.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvBPA.SelectedRows.Count < 0 || dgvBPA.SelectedRows == null)
            {
                MessageBox.Show("No rows selected");
                return;
            }
            else if (dgvBPA.SelectedRows.Count > 1)
            {
                MessageBox.Show("Can only edit one row at a time");
                return;
            }
            int id;
            try
            {
                id = (int)(dgvBPA.SelectedRows[0].Cells[0].Value);
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show("Error in selected data!\n" + ex);
                return;
            }
            AgreeFrmEditBPA frmEditBPA = new AgreeFrmEditBPA();
            Dictionary<string, object> paramList = new Dictionary<string, object>();
            paramList.Add("@ID", id);
            DataSet dataSet = DatabaseAdapter.retrieveDataSet("SELECT * FROM [Agreement] WHERE [AgreementID] = ?;", paramList);
            DataRow dataRow = dataSet.Tables[0].Rows[0];
            if (dataRow == null)
            {
                MessageBox.Show("Error in selected data!");
                return;
            }
            frmEditBPA.editingDataRow = dataRow;
            frmEditBPA.dataChanged += onDataUpdated;
            frmEditBPA.Show();
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
using WeifenLuo.WinFormsUI.Docking;
using YRG_4915M.Database;

namespace YRG_4915M.Pages.AgreementManagement
{
    public partial class AgreeFrmBPA : DockContent
    {
        public AgreeFrmBPA()
        {
            InitializeComponent();
            initCurrency();
            showData();
        }
        //===============================
        private void initCurrency()
        {
            cbCurrency.Items.Add("*All*");
            List<object> dataRows = DatabaseAdapter.retrieveDataOneCol("SELECT [CurrencyList] FROM [UtilTable];");
            List<string> cbListValues = new List<string>();
            foreach (object o in dataRows)
            {
                if (o != DBNull.Value)
                {
                    cbListValues.Add((string)o);
                }
            }
            foreach (string s in cbListValues)
            {
                cbCurrency.Items.Add(s);
            }
            cbCurrency.SelectedIndex = 0;
        }
        private void showData()
        {
            DataSet dataSet = DatabaseAdapter.retrieveDataSet("SELECT [AgreementID], [SupplierID], [Currency], [CreateDate], [EffectiveDate], [ItemCategory], [ItemDesc] FROM [Agreement] WHERE [AgreementType]='BPA';");
            dgvBPA.DataSource = dataSet.Tables[0];
            dgvBPA.ClearSelection();
            dgvBPA.CurrentCell = null;
        }
        private void showData(Dictionary<string, string> conditions)
        {
            Dictionary<string, object> paramList = new Dictionary<string, object>();
            foreach (KeyValuePair<string, string> entry in conditions)
            {
                paramList.Add(entry.Key, $"%{entry.Value}%");
            }
            DataSet dataSet = DatabaseAdapter.retrieveDataSet(
                "SELECT * FROM [Agreement]" +
                "WHERE [AgreementType]='BPA' AND [AgreementID] LIKE ? AND [SupplierID] LIKE ? AND [Currency] LIKE ?;",
                paramList);
            dgvBPA.DataSource = dataSet.Tables[0];
            dgvBPA.ClearSelection();
            dgvBPA.CurrentCell = null;
        }
        //===============================
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtBPAID.Text != "" || kryptonTextBox2.Text != "" || cbCurrency.SelectedIndex >= 0)
            {
                Dictionary<string, string> conditions = new Dictionary<string, string>();
                conditions.Add("@ID", txtBPAID.Text);
                conditions.Add("@supplierID", kryptonTextBox2.Text);
                if (cbCurrency.SelectedIndex < 0 || cbCurrency.Items[cbCurrency.SelectedIndex].ToString().Equals("*All*"))
                {
                    conditions.Add("@currency", "");
                }
                else
                {
                    conditions.Add("@currency", cbCurrency.Items[cbCurrency.SelectedIndex].ToString());
                }
                showData(conditions);
            }
            else
            {
                showData();
            }
        }
        //===============================
        private void onDataUpdated(object sender, EventArgs e)
        {
            showData();
        }
        //===============================
        private void btnCreate_Click(object sender, EventArgs e)
        {
            AgreeFrmCreateBPA frmCreateBPA = new AgreeFrmCreateBPA();
            frmCreateBPA.dataChanged += onDataUpdated;
            frmCreateBPA.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvBPA.SelectedRows.Count < 0 || dgvBPA.SelectedRows == null)
            {
                MessageBox.Show("No rows selected");
                return;
            }
            else if (dgvBPA.SelectedRows.Count > 1)
            {
                MessageBox.Show("Can only edit one row at a time");
                return;
            }
            int id;
            try
            {
                id = (int)(dgvBPA.SelectedRows[0].Cells[0].Value);
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show("Error in selected data!\n" + ex);
                return;
            }
            AgreeFrmEditBPA frmEditBPA = new AgreeFrmEditBPA();
            Dictionary<string, object> paramList = new Dictionary<string, object>();
            paramList.Add("@ID", id);
            DataSet dataSet = DatabaseAdapter.retrieveDataSet("SELECT * FROM [Agreement] WHERE [AgreementID] = ?;", paramList);
            DataRow dataRow = dataSet.Tables[0].Rows[0];
            if (dataRow == null)
            {
                MessageBox.Show("Error in selected data!");
                return;
            }
            frmEditBPA.editingDataRow = dataRow;
            frmEditBPA.dataChanged += onDataUpdated;
            frmEditBPA.Show();
        }
    }
}
>>>>>>> e3039030246399001b6a193ac0434d0ab124b1f7
