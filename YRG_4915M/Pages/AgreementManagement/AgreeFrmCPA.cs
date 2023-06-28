<<<<<<< HEAD
﻿using Krypton.Toolkit;
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
using YRG_4915M.Database;

namespace YRG_4915M.Pages.AgreementManagement
{
    public partial class AgreeFrmCPA : DockContent
    {
        public AgreeFrmCPA()
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
                if(o != DBNull.Value)
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
            DataSet dataSet = DatabaseAdapter.retrieveDataSet("SELECT * FROM [Agreement] WHERE [AgreementType]='CPA';");
            dgvCPA.DataSource = dataSet.Tables[0];
            dgvCPA.ClearSelection();
            dgvCPA.CurrentCell = null;
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
                "WHERE [AgreementType]='CPA' AND [AgreementID] LIKE ? AND [SupplierID] LIKE ? AND [Currency] LIKE ?;",
                paramList);
            dgvCPA.DataSource = dataSet.Tables[0];
            dgvCPA.ClearSelection();
            dgvCPA.CurrentCell = null;
        }

        //===============================
        private void onDataUpdated(object sender, EventArgs e)
        {
            showData();
        }
        //===============================
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtCPAID.Text != "" || txtSupplierID.Text != "" || cbCurrency.SelectedIndex >= 0)
            {
                Dictionary<string, string> conditions = new Dictionary<string, string>();
                conditions.Add("@ID", txtCPAID.Text);
                conditions.Add("@supplierID", txtSupplierID.Text);
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
        private void btnCreate_Click(object sender, EventArgs e)
        {
            AgreeFrmCreateCPA frmCreateCPA = new AgreeFrmCreateCPA();
            frmCreateCPA.dataChanged += onDataUpdated;
            frmCreateCPA.Show();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCPA.SelectedRows.Count < 0 || dgvCPA.SelectedRows == null)
            {
                MessageBox.Show("No rows selected");
                return;
            }else if(dgvCPA.SelectedRows.Count > 1)
            {
                MessageBox.Show("Can only edit one row at a time");
                return;
            }
            int id;
            try
            {
                id = (int)(dgvCPA.SelectedRows[0].Cells[0].Value);
            }catch(InvalidCastException ex)
            {
                MessageBox.Show("Error in selected data!\n" + ex);
                return;
            }
            AgreeFrmEditCPA frmEditCPA = new AgreeFrmEditCPA();
            Dictionary<string, object> paramList = new Dictionary<string, object>();
            paramList.Add("@ID", id);
            DataSet dataSet = DatabaseAdapter.retrieveDataSet("SELECT * FROM [Agreement] WHERE [AgreementID] = ?;", paramList);
            DataRow dataRow = dataSet.Tables[0].Rows[0];
            if(dataRow == null)
            {
                MessageBox.Show("Error in selected data!");
                return;
            }
            frmEditCPA.editingDataRow = dataRow;
            frmEditCPA.dataChanged += onDataUpdated;
            frmEditCPA.Show();
        }
        //===============================
    }
}
=======
﻿using Krypton.Toolkit;
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
using YRG_4915M.Database;

namespace YRG_4915M.Pages.AgreementManagement
{
    public partial class AgreeFrmCPA : DockContent
    {
        public AgreeFrmCPA()
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
                if(o != DBNull.Value)
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
            DataSet dataSet = DatabaseAdapter.retrieveDataSet("SELECT * FROM [Agreement] WHERE [AgreementType]='CPA';");
            dgvCPA.DataSource = dataSet.Tables[0];
            dgvCPA.ClearSelection();
            dgvCPA.CurrentCell = null;
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
                "WHERE [AgreementType]='CPA' AND [AgreementID] LIKE ? AND [SupplierID] LIKE ? AND [Currency] LIKE ?;",
                paramList);
            dgvCPA.DataSource = dataSet.Tables[0];
            dgvCPA.ClearSelection();
            dgvCPA.CurrentCell = null;
        }

        //===============================
        private void onDataUpdated(object sender, EventArgs e)
        {
            showData();
        }
        //===============================
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtCPAID.Text != "" || txtSupplierID.Text != "" || cbCurrency.SelectedIndex >= 0)
            {
                Dictionary<string, string> conditions = new Dictionary<string, string>();
                conditions.Add("@ID", txtCPAID.Text);
                conditions.Add("@supplierID", txtSupplierID.Text);
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
        private void btnCreate_Click(object sender, EventArgs e)
        {
            AgreeFrmCreateCPA frmCreateCPA = new AgreeFrmCreateCPA();
            frmCreateCPA.dataChanged += onDataUpdated;
            frmCreateCPA.Show();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCPA.SelectedRows.Count < 0 || dgvCPA.SelectedRows == null)
            {
                MessageBox.Show("No rows selected");
                return;
            }else if(dgvCPA.SelectedRows.Count > 1)
            {
                MessageBox.Show("Can only edit one row at a time");
                return;
            }
            int id;
            try
            {
                id = (int)(dgvCPA.SelectedRows[0].Cells[0].Value);
            }catch(InvalidCastException ex)
            {
                MessageBox.Show("Error in selected data!\n" + ex);
                return;
            }
            AgreeFrmEditCPA frmEditCPA = new AgreeFrmEditCPA();
            Dictionary<string, object> paramList = new Dictionary<string, object>();
            paramList.Add("@ID", id);
            DataSet dataSet = DatabaseAdapter.retrieveDataSet("SELECT * FROM [Agreement] WHERE [AgreementID] = ?;", paramList);
            DataRow dataRow = dataSet.Tables[0].Rows[0];
            if(dataRow == null)
            {
                MessageBox.Show("Error in selected data!");
                return;
            }
            frmEditCPA.editingDataRow = dataRow;
            frmEditCPA.dataChanged += onDataUpdated;
            frmEditCPA.Show();
        }
        //===============================
    }
}
>>>>>>> e3039030246399001b6a193ac0434d0ab124b1f7
