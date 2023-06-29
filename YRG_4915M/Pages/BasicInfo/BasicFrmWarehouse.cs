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

namespace YRG_4915M.Pages.BasicInfo
{
    public partial class BasicFrmWarehouse : DockContent
    {
        public BasicFrmWarehouse()
        {
            InitializeComponent();
            showData();
        }
        //==========================================================================
        private void showData()
        {
            DataSet dataSet = DatabaseAdapter.retrieveDataSet("SELECT * FROM [Warehouse];");
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
                "SELECT * FROM [Warehouse]" +
                "WHERE [WarehouseTel] LIKE ? AND [WarehouseAddress] LIKE ?;",
                paramList);
            dgvSupplierInfo.DataSource = dataSet.Tables[0];
            dgvSupplierInfo.ClearSelection();
            dgvSupplierInfo.CurrentCell = null;
        }
        private bool inputIncomplete()
        {
            if (txtWarehouseID.Text == "" || txtWarehouseTel.Text == "" || txtWarehouseAddress.Text == "")
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
            if (txtWarehouseID.Text != "" || txtWarehouseTel.Text != "" || txtWarehouseAddress.Text != "")
            {
                Dictionary<string, string> conditions = new Dictionary<string, string>();
                conditions.Add("@id", txtWarehouseID.Text);
                conditions.Add("@name", txtWarehouseTel.Text);
                conditions.Add("@tel", txtWarehouseAddress.Text);
                showData(conditions);
            }
            else
            {
                showData();
            }
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            if (inputIncomplete())
            {
                MessageBox.Show("Data entry incomplete");
                return;
            }
            int id = 0;
            try
            {
                id = int.Parse(txtWarehouseID.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Primary key must be a number!\n" + ex);
                return;
            }

            if (DatabaseAdapter.retrieveDataOneCol($"SELECT * FROM [Warehouse] WHERE [WarehouseID]={id}").Count <= 0)
            {
                MessageBox.Show("No entry found with input primary key for edit");
                return;
            }

            Dictionary<string, object> sqlDataValues = new Dictionary<string, object>();
            sqlDataValues.Add("@tel", txtWarehouseTel.Text);
            sqlDataValues.Add("@address", txtWarehouseAddress.Text);
            sqlDataValues.Add("@id", txtWarehouseID.Text);
            DatabaseAdapter.execute("UPDATE [Warehouse] " +
                "SET [WarehouseTel]= ?, [WarehouseAddress]= ?, " +
                $"WHERE [WarehouseID]= ?;", sqlDataValues);
            showData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (inputIncomplete())
            {
                MessageBox.Show("Data entry incomplete");
                return;
            }
            int id = 0;
            try
            {
                id = int.Parse(txtWarehouseID.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Primary key must be a number!\n" + ex);
                return;
            }

            if (DatabaseAdapter.retrieveDataOneCol($"SELECT * FROM [Warehouse] WHERE [WarehouseID]={id}").Count > 0)
            {
                MessageBox.Show("Primary key duplicated in data entry");
                return;
            }

            Dictionary<string, object> sqlDataValues = new Dictionary<string, object>();
            sqlDataValues.Add("@id", txtWarehouseID.Text);
            sqlDataValues.Add("@tel", txtWarehouseTel.Text);
            sqlDataValues.Add("@address", txtWarehouseAddress.Text);
            if (DatabaseAdapter.execute("INSERT INTO [Warehouse]([WarehouseID], [WarehouseTel], [WarehouseAddress]) VALUES(?, ?, ?)", sqlDataValues) > 0)
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
                    DatabaseAdapter.execute("DELETE FROM [Warehouse] WHERE [WarehouseID]= ?", paramList);
                }
                showData();
            }
        }
    }
}
