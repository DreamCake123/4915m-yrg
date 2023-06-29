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
    public partial class BasicFrmRestaurant : DockContent
    {
        public BasicFrmRestaurant()
        {
            InitializeComponent();
            initComboBox();
            showData();
        }
        private void initComboBox()
        {
            cbBranch.Items.Add("*All*");
            List<object> dataRows = DatabaseAdapter.retrieveDataOneCol("SELECT [BranchList] FROM [UtilTable];");
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
                cbBranch.Items.Add(s);
            }
            cbBranch.SelectedIndex = 0;
        }
        private void showData()
        {
            DataSet dataSet = DatabaseAdapter.retrieveDataSet("SELECT * FROM [Restaurant];");
            dgvRestaurantInfo.DataSource = dataSet.Tables[0];
            dgvRestaurantInfo.ClearSelection();
            dgvRestaurantInfo.CurrentCell = null;
        }
        private void showData(Dictionary<string, string> conditions)
        {
            Dictionary<string, object> paramList = new Dictionary<string, object>();
            foreach (KeyValuePair<string, string> entry in conditions)
            {
                paramList.Add(entry.Key, $"%{entry.Value}%");
            }
            DataSet dataSet = DatabaseAdapter.retrieveDataSet(
                "SELECT * FROM [Restaurant]" +
                "WHERE [RestaurantID] LIKE ? AND [RestTel] LIKE ? AND [RestAddress] LIKE ? AND [Branch] LIKE ?;",
                paramList);
            dgvRestaurantInfo.DataSource = dataSet.Tables[0];
            dgvRestaurantInfo.ClearSelection();
            dgvRestaurantInfo.CurrentCell = null;
        }
        private bool inputIncomplete()
        {
            if (txtRestaurantID.Text == "" || txtRestaurantTel.Text == "" || txtRestaurantAddress.Text == "" || cbBranch.SelectedIndex <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool inputExist()
        {
            if (txtRestaurantID.Text != "" || txtRestaurantTel.Text != "" || txtRestaurantAddress.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //==========================================================
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (inputExist())
            {
                Dictionary<string, string> conditions = new Dictionary<string, string>();
                conditions.Add("@ID", txtRestaurantID.Text);
                conditions.Add("@tel", txtRestaurantTel.Text);
                conditions.Add("@address", txtRestaurantAddress.Text);
                if (cbBranch.SelectedIndex < 0 || cbBranch.Items[cbBranch.SelectedIndex].ToString().Equals("*All*"))
                {
                    conditions.Add("@itemType", "");
                }
                else
                {
                    conditions.Add("@itemType", cbBranch.Items[cbBranch.SelectedIndex].ToString());
                }
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
                id = int.Parse(txtRestaurantID.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Primary key must be a number!\n" + ex);
                return;
            }

            if (DatabaseAdapter.retrieveDataOneCol($"SELECT [RestaurantID] FROM [Restaurant] WHERE [RestaurantID]={id}").Count <= 0)
            {
                MessageBox.Show("No entry found with input primary key for edit");
                return;
            }

            Dictionary<string, object> sqlDataValues = new Dictionary<string, object>();
            sqlDataValues.Add("@tel", txtRestaurantTel.Text);
            sqlDataValues.Add("@branch", cbBranch.Items[cbBranch.SelectedIndex]);
            sqlDataValues.Add("@address", txtRestaurantAddress.Text);
            sqlDataValues.Add("@id", txtRestaurantID.Text);
            DatabaseAdapter.execute("UPDATE [Restaurant] " +
                "SET [RestTel]= ?, [Branch]= ?, [RestAddress]= ? " +
                $"WHERE [RestaurantID]= ?;", sqlDataValues);
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
                id = int.Parse(txtRestaurantID.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Primary key must be a number!\n" + ex);
                return;
            }

            if (DatabaseAdapter.retrieveDataOneCol($"SELECT [RestaurantID] FROM [Restaurant] WHERE [RestaurantID]={id}").Count > 0)
            {
                MessageBox.Show("Primary key duplicated in data entry");
                return;
            }

            Dictionary<string, object> sqlDataValues = new Dictionary<string, object>();
            sqlDataValues.Add("@id", txtRestaurantID.Text);
            sqlDataValues.Add("@tel", txtRestaurantTel.Text);
            sqlDataValues.Add("@address", txtRestaurantAddress.Text);
            sqlDataValues.Add("@branch", cbBranch.Items[cbBranch.SelectedIndex]);
            if (DatabaseAdapter.execute("INSERT INTO [Restaurant]([RestaurantID], [RestTel], [RestAddress], [Branch]) VALUES(?, ?, ?, ?)", sqlDataValues) > 0)
            {
                MessageBox.Show("Data inserted");
                showData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvRestaurantInfo.SelectedRows.Count < 0)
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
                foreach (DataGridViewRow row in dgvRestaurantInfo.SelectedRows)
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
                    DatabaseAdapter.execute("DELETE FROM [Restaurant] WHERE [RestaurantID]= ?", paramList);
                }
                showData();
            }
        }
    }
}