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
using YRG_4915M.Pages.ItemManagement;
using YRG_4915M.Database;

namespace YRG_4915M.Pages.BasicInfo
{
    public partial class BasicFrmSupplier : DockContent
    {
        public BasicFrmSupplier()
        {
            InitializeComponent();
            showData();
        }
        private void showData()
        {
            DataSet dataSet = DatabaseAdapter.retrieveDataSet("SELECT * FROM [User] WHERE [UserType] = 'Supplier'");
            dgvSupplierInfo.DataSource = dataSet.Tables[0];
            dgvSupplierInfo.ClearSelection();
            dgvSupplierInfo.CurrentCell = null;
        }
        private void showData(Dictionary<string, string> conditions)
        {
            Dictionary<string, object> paramList = new Dictionary<string, object>();
            foreach (KeyValuePair<string, string> entry in conditions)
            {
                paramList.Add(entry.Key, $"%{entry.Value}%");
            }
            DataSet dataSet = DatabaseAdapter.retrieveDataSet(
                "SELECT * FROM [User]" +
                "WHERE [UserID] LIKE ? AND [UserName] LIKE ? AND [UserTel] LIKE ? AND [UserType] LIKE ?;",
                paramList);
            dgvSupplierInfo.DataSource = dataSet.Tables[0];
            dgvSupplierInfo.ClearSelection();
            dgvSupplierInfo.CurrentCell = null;
        }
        private bool inputIncomplete()
        {
            if (txtSuppId.Text == "" || txtSuppName.Text == "" || txtSuppTel.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //==========================================================================
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSuppId.Text != "" || txtSuppName.Text != "" || txtSuppTel.Text != "")
            {
                Dictionary<string, string> conditions = new Dictionary<string, string>();
                conditions.Add("@id", txtSuppId.Text);
                conditions.Add("@name", txtSuppName.Text);
                conditions.Add("@tel", txtSuppTel.Text);
                showData(conditions);
            }
            else
            {
                showData();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (inputIncomplete())
            {
                MessageBox.Show("Data entry incomplete");
                return;
            }
            int id = 0;
            try
            {
                id = int.Parse(txtSuppId.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Primary key must be a number!\n" + ex);
                return;
            }

            if (DatabaseAdapter.retrieveDataOneCol($"SELECT * FROM [User] WHERE [UserID]={id}").Count <= 0)
            {
                MessageBox.Show("No entry found with input primary key for edit");
                return;
            }

            Dictionary<string, object> sqlDataValues = new Dictionary<string, object>();
            sqlDataValues.Add("@name", txtSuppName.Text);
            sqlDataValues.Add("@tel", txtSuppTel.Text);
            sqlDataValues.Add("@id", txtSuppId.Text);
            DatabaseAdapter.execute("UPDATE [User] " +
                "SET [UserName]= ?, [UserTel]= ?, " +
                $"WHERE [UserID]= ?;", sqlDataValues);
            showData();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (inputIncomplete())
            {
                MessageBox.Show("Data entry incomplete");
                return;
            }
            int id = 0;
            try
            {
                id = int.Parse(txtSuppId.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Primary key must be a number!\n" + ex);
                return;
            }

            if (DatabaseAdapter.retrieveDataOneCol($"SELECT * FROM [User] WHERE [UserID]={id}").Count > 0)
            {
                MessageBox.Show("Primary key duplicated in data entry");
                return;
            }

            Dictionary<string, object> sqlDataValues = new Dictionary<string, object>();
            sqlDataValues.Add("@id", txtSuppId.Text);
            sqlDataValues.Add("@name", txtSuppName.Text);
            sqlDataValues.Add("@tel", txtSuppTel.Text);
            if (DatabaseAdapter.execute("INSERT INTO [User]([UserID], [UserName], [UserTel], [UserType]) VALUES(?, ?, ?, 'Supplier')", sqlDataValues) > 0)
            {
                MessageBox.Show("Data inserted");
                showData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSupplierInfo.SelectedRows.Count < 0)
            {
                MessageBox.Show("No rows selected");
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected rows?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                List<int> selectedDataRowsId = new List<int>();
                foreach (DataGridViewRow row in dgvSupplierInfo.SelectedRows)
                {
                    try
                    {
                        selectedDataRowsId.Add((int)row.Cells[0].Value);
                    }
                    catch (InvalidCastException ex)
                    {
                        MessageBox.Show("Error in selected data!\n" + ex);
                        return;
                    }
                }
                foreach (int id in selectedDataRowsId)
                {
                    Dictionary<string, object> paramList = new Dictionary<string, object>();
                    paramList.Add("@id", id);
                    DatabaseAdapter.execute("DELETE FROM [User] WHERE [UserID]= ?", paramList);
                }
                showData();
            }
        }
    }
}
