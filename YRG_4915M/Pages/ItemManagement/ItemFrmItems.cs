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
using YRG_4915M.Database;

namespace YRG_4915M.Pages.ItemManagement
{
    public partial class ItemFrmItems : DockContent
    {
        public ItemFrmItems()
        {
            InitializeComponent();
            initItemTypes();
            showData();
        }
        //===============================
        private void initItemTypes()
        {
            kryptonComboBox1.Items.Add("*All*");
            List<object> dataRows = DatabaseAdapter.retrieveDataOneCol("SELECT [ItemTypeList] FROM [UtilTable];");
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
                kryptonComboBox1.Items.Add(s);
            }
            kryptonComboBox1.SelectedIndex = 0;
        }
        private void showData()
        {
            DataSet dataSet = DatabaseAdapter.retrieveDataSet("SELECT [ItemID], [ItemName], [ItemType] FROM [Item];");
            dgvItemMinor.DataSource = dataSet.Tables[0];
            dgvItemMinor.ClearSelection();
            dgvItemMinor.CurrentCell = null;
        }
        private void showData(Dictionary<string, string> conditions)
        {
            Dictionary<string, object> paramList = new Dictionary<string, object>();
            foreach (KeyValuePair<string, string> entry in conditions)
            {
                paramList.Add(entry.Key, $"%{entry.Value}%");
            }
            DataSet dataSet = DatabaseAdapter.retrieveDataSet(
                "SELECT [ItemID], [ItemName], [ItemType] FROM [Item]" +
                "WHERE [ItemID] LIKE @itemId AND [ItemName] LIKE ? AND [ItemType] LIKE ?;",
                paramList);
            dgvItemMinor.DataSource = dataSet.Tables[0];
            dgvItemMinor.ClearSelection();
            dgvItemMinor.CurrentCell = null;
        }
        private void updateSelection()
        {
            if (dgvItemMinor.SelectedRows.Count <= 0) return;
            DataGridViewRow selectedDataRow = dgvItemMinor.SelectedRows[0];
            if (selectedDataRow != null)
            {
                txtItemID.Text = selectedDataRow.Cells[0].Value.ToString();
                txtItemName.Text = selectedDataRow.Cells[1].Value.ToString();
                kryptonComboBox1.SelectedIndex = kryptonComboBox1.FindStringExact(selectedDataRow.Cells[2].Value.ToString());
            }
        }
        //===============================
        private void btnAddRow_Click(object sender, EventArgs e)
        {

            if (txtItemID.Text == "" || txtItemName.Text == "" || kryptonComboBox1.SelectedIndex < 0 ||
                kryptonComboBox1.Items[kryptonComboBox1.SelectedIndex].ToString().Equals("*All*"))
            {
                MessageBox.Show("Data entry incomplete");
                return;
            }
            int itemId = 0;
            try
            {
                itemId = int.Parse(txtItemID.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Primary key must be a number!\n" + ex);
                return;
            }
            if (DatabaseAdapter.retrieveDataOneCol($"SELECT [ItemID] FROM [Item] WHERE [ItemID]={itemId}").Count > 0)
            {
                MessageBox.Show("Primary key duplicated in data entry");
                return;
            }

            Dictionary<string, object> sqlDataValues = new Dictionary<string, object>();
            sqlDataValues.Add("@itemId", itemId);
            sqlDataValues.Add("@itemName", txtItemName.Text);
            sqlDataValues.Add("@itemType", kryptonComboBox1.Items[kryptonComboBox1.SelectedIndex]);
            if (DatabaseAdapter.execute("INSERT INTO [Item] VALUES(?, ?, ?);", sqlDataValues) > 0)
            {
                MessageBox.Show("Data inserted");
            }
            
            showData();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtItemID.Text == "" || txtItemName.Text == "" || kryptonComboBox1.SelectedIndex < 0 ||
                kryptonComboBox1.Items[kryptonComboBox1.SelectedIndex].ToString().Equals("*All*"))
            {
                MessageBox.Show("Data entry incomplete");
                return;
            }
            int itemId = 0;
            try
            {
                itemId = int.Parse(txtItemID.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Primary key must be a number!\n" + ex);
                return;
            }

            if (DatabaseAdapter.retrieveDataOneCol($"SELECT [ItemID] FROM [Item] WHERE [ItemID]={itemId}").Count <= 0)
            {
                MessageBox.Show("No entry found with input primary key for edit");
                return;
            }


            Dictionary<string, object> sqlDataValues = new Dictionary<string, object>();
            sqlDataValues.Add("@itemName", txtItemName.Text);
            sqlDataValues.Add("@itemType", kryptonComboBox1.Items[kryptonComboBox1.SelectedIndex]);
            sqlDataValues.Add("@itemId", itemId);
            DatabaseAdapter.execute("UPDATE [Item] " +
                "SET [ItemName]= ?, [ItemType]= ? " +
                $"WHERE [ItemID]= ?;", sqlDataValues);
            showData();
        }
        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            if (dgvItemMinor.SelectedRows.Count < 0)
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
                foreach (DataGridViewRow row in dgvItemMinor.SelectedRows)
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
                    paramList.Add("@itemID", id);
                    DatabaseAdapter.execute("DELETE FROM [Item] WHERE [ItemID]= ?", paramList);
                }
                showData();
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtItemID.Text != "" || txtItemName.Text != "" || kryptonComboBox1.SelectedIndex >= 0)
            {
                Dictionary<string, string> conditions = new Dictionary<string, string>();
                conditions.Add("@itemId", txtItemID.Text);
                conditions.Add("@itemName", txtItemName.Text);
                if (kryptonComboBox1.SelectedIndex < 0 || kryptonComboBox1.Items[kryptonComboBox1.SelectedIndex].ToString().Equals("*All*"))
                {
                    conditions.Add("@itemType", "");
                }
                else
                {
                    conditions.Add("@itemType", kryptonComboBox1.Items[kryptonComboBox1.SelectedIndex].ToString());
                }
                showData(conditions);
            }
            else
            {
                showData();
            }
        }


        //===============================

        private void btnItemIDCancel_Click(object sender, EventArgs e)
        {
            txtItemID.Text = "";
        }
        private void btnItemNameCancel_Click(object sender, EventArgs e)
        {
            txtItemName.Text = "";
        }

        private void dgvItemMinor_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            updateSelection();
        }

        private void dgvItemMinor_MultiSelectChanged(object sender, EventArgs e)
        {
            updateSelection();
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
using YRG_4915M.Database;

namespace YRG_4915M.Pages.ItemManagement
{
    public partial class ItemFrmItems : DockContent
    {
        public ItemFrmItems()
        {
            InitializeComponent();
            initItemTypes();
            showData();
        }
        //===============================
        private void initItemTypes()
        {
            kryptonComboBox1.Items.Add("*All*");
            List<object> dataRows = DatabaseAdapter.retrieveDataOneCol("SELECT [ItemTypeList] FROM [UtilTable];");
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
                kryptonComboBox1.Items.Add(s);
            }
            kryptonComboBox1.SelectedIndex = 0;
        }
        private void showData()
        {
            DataSet dataSet = DatabaseAdapter.retrieveDataSet("SELECT [ItemID], [ItemName], [ItemType] FROM [Item];");
            dgvItemMinor.DataSource = dataSet.Tables[0];
            dgvItemMinor.ClearSelection();
            dgvItemMinor.CurrentCell = null;
        }
        private void showData(Dictionary<string, string> conditions)
        {
            Dictionary<string, object> paramList = new Dictionary<string, object>();
            foreach (KeyValuePair<string, string> entry in conditions)
            {
                paramList.Add(entry.Key, $"%{entry.Value}%");
            }
            DataSet dataSet = DatabaseAdapter.retrieveDataSet(
                "SELECT [ItemID], [ItemName], [ItemType] FROM [Item]" +
                "WHERE [ItemID] LIKE @itemId AND [ItemName] LIKE ? AND [ItemType] LIKE ?;",
                paramList);
            dgvItemMinor.DataSource = dataSet.Tables[0];
            dgvItemMinor.ClearSelection();
            dgvItemMinor.CurrentCell = null;
        }
        private void updateSelection()
        {
            if (dgvItemMinor.SelectedRows.Count <= 0) return;
            DataGridViewRow selectedDataRow = dgvItemMinor.SelectedRows[0];
            if (selectedDataRow != null)
            {
                txtItemID.Text = selectedDataRow.Cells[0].Value.ToString();
                txtItemName.Text = selectedDataRow.Cells[1].Value.ToString();
                kryptonComboBox1.SelectedIndex = kryptonComboBox1.FindStringExact(selectedDataRow.Cells[2].Value.ToString());
            }
        }
        //===============================
        private void btnAddRow_Click(object sender, EventArgs e)
        {

            if (txtItemID.Text == "" || txtItemName.Text == "" || kryptonComboBox1.SelectedIndex < 0 ||
                kryptonComboBox1.Items[kryptonComboBox1.SelectedIndex].ToString().Equals("*All*"))
            {
                MessageBox.Show("Data entry incomplete");
                return;
            }
            int itemId = 0;
            try
            {
                itemId = int.Parse(txtItemID.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Primary key must be a number!\n" + ex);
                return;
            }
            if (DatabaseAdapter.retrieveDataOneCol($"SELECT [ItemID] FROM [Item] WHERE [ItemID]={itemId}").Count > 0)
            {
                MessageBox.Show("Primary key duplicated in data entry");
                return;
            }

            Dictionary<string, object> sqlDataValues = new Dictionary<string, object>();
            sqlDataValues.Add("@itemId", itemId);
            sqlDataValues.Add("@itemName", txtItemName.Text);
            sqlDataValues.Add("@itemType", kryptonComboBox1.Items[kryptonComboBox1.SelectedIndex]);
            DatabaseAdapter.execute("INSERT INTO [Item] VALUES(?, ?, ?);", sqlDataValues);
            showData();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtItemID.Text == "" || txtItemName.Text == "" || kryptonComboBox1.SelectedIndex < 0 ||
                kryptonComboBox1.Items[kryptonComboBox1.SelectedIndex].ToString().Equals("*All*"))
            {
                MessageBox.Show("Data entry incomplete");
                return;
            }
            int itemId = 0;
            try
            {
                itemId = int.Parse(txtItemID.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Primary key must be a number!\n" + ex);
                return;
            }

            if (DatabaseAdapter.retrieveDataOneCol($"SELECT [ItemID] FROM [Item] WHERE [ItemID]={itemId}").Count <= 0)
            {
                MessageBox.Show("No entry found with input primary key for edit");
                return;
            }


            Dictionary<string, object> sqlDataValues = new Dictionary<string, object>();
            sqlDataValues.Add("@itemName", txtItemName.Text);
            sqlDataValues.Add("@itemType", kryptonComboBox1.Items[kryptonComboBox1.SelectedIndex]);
            sqlDataValues.Add("@itemId", itemId);
            DatabaseAdapter.execute("UPDATE [Item] " +
                "SET [ItemName]= ?, [ItemType]= ? " +
                $"WHERE [ItemID]= ?;", sqlDataValues);
            showData();
        }
        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            if (dgvItemMinor.SelectedRows.Count < 0)
            {
                MessageBox.Show("No rows selected");
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected rows?", "Confirma Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                List<int> selectedDataRowsId = new List<int>();
                foreach (DataGridViewRow row in dgvItemMinor.SelectedRows)
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
                    paramList.Add("@itemID", id);
                    DatabaseAdapter.execute("DELETE FROM [Item] WHERE [ItemID]= ?", paramList);
                }
                showData();
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtItemID.Text != "" || txtItemName.Text != "" || kryptonComboBox1.SelectedIndex >= 0)
            {
                Dictionary<string, string> conditions = new Dictionary<string, string>();
                conditions.Add("@itemId", txtItemID.Text);
                conditions.Add("@itemName", txtItemName.Text);
                if (kryptonComboBox1.SelectedIndex < 0 || kryptonComboBox1.Items[kryptonComboBox1.SelectedIndex].ToString().Equals("*All*"))
                {
                    conditions.Add("@itemType", "");
                }
                else
                {
                    conditions.Add("@itemType", kryptonComboBox1.Items[kryptonComboBox1.SelectedIndex].ToString());
                }
                showData(conditions);
            }
            else
            {
                showData();
            }
        }


        //===============================

        private void btnItemIDCancel_Click(object sender, EventArgs e)
        {
            txtItemID.Text = "";
        }
        private void btnItemNameCancel_Click(object sender, EventArgs e)
        {
            txtItemName.Text = "";
        }

        private void dgvItemMinor_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            updateSelection();
        }

        private void dgvItemMinor_MultiSelectChanged(object sender, EventArgs e)
        {
            updateSelection();
        }
    }
}
>>>>>>> e3039030246399001b6a193ac0434d0ab124b1f7
