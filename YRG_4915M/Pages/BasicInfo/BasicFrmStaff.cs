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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
using YRG_4915M.Database;

namespace YRG_4915M.Pages.BasicInfo
{
    public partial class BasicFrmStaff : DockContent
    {
        public BasicFrmStaff()
        {
            InitializeComponent();
            initComboBox();
            showData();
        }

        private void initComboBox()
        {
            cbStaffType.Items.Add("*All*");
            List<object> dataRows = DatabaseAdapter.retrieveDataOneCol("SELECT [StaffType] FROM [UtilTable];");
            List<string> listValues = new List<string>();
            foreach (object o in dataRows)
            {
                if (o != DBNull.Value)
                {
                    listValues.Add((string)o);
                }
            }
            foreach (string s in listValues)
            {
                cbStaffType.Items.Add(s);
            }
            cbStaffType.SelectedIndex = 0;

            cbDept.Items.Add("*All*");
            dataRows = DatabaseAdapter.retrieveDataOneCol("SELECT [DeptList] FROM [UtilTable];");
            listValues = new List<string>();
            foreach (object o in dataRows)
            {
                if (o != DBNull.Value)
                {
                    listValues.Add((string)o);
                }
            }
            foreach (string s in listValues)
            {
                cbDept.Items.Add(s);
            }
            cbDept.SelectedIndex = 0;
        }
        private void showData()
        {
            DataSet dataSet = DatabaseAdapter.retrieveDataSet("SELECT * FROM [User] WHERE [UserType] = 'Staff' OR [UserType] = 'Manager';");
            dgvStaffInfo.DataSource = dataSet.Tables[0];
            dgvStaffInfo.ClearSelection();
            dgvStaffInfo.CurrentCell = null;
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
                "WHERE [UserID] LIKE ? AND [UserName] LIKE ? AND [UserType] LIKE ? AND [StaffDept] LIKE ?;",
                paramList);
            dgvStaffInfo.DataSource = dataSet.Tables[0];
            dgvStaffInfo.ClearSelection();
            dgvStaffInfo.CurrentCell = null;
        }
        private bool inputIncomplete()
        {
            if (txtStaffId.Text == "" || txtStaffName.Text == "" || cbStaffType.SelectedIndex <= 0 || cbDept.SelectedIndex <= 0)
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
            if (txtStaffId.Text != "" || txtStaffName.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //==========================================================================
        private void btnSearchStaff_Click(object sender, EventArgs e)
        {
            if (inputExist())
            {
                Dictionary<string, string> conditions = new Dictionary<string, string>();
                conditions.Add("@ID", txtStaffId.Text);
                conditions.Add("@name", txtStaffName.Text);
                if (cbStaffType.SelectedIndex < 0 || cbStaffType.Items[cbStaffType.SelectedIndex].ToString().Equals("*All*"))
                {
                    conditions.Add("@type", "");
                }
                else
                {
                    conditions.Add("@type", cbStaffType.Items[cbStaffType.SelectedIndex].ToString());
                }
                if (cbDept.SelectedIndex < 0 || cbDept.Items[cbDept.SelectedIndex].ToString().Equals("*All*"))
                {
                    conditions.Add("@dept", "");
                }
                else
                {
                    conditions.Add("@dept", cbDept.Items[cbDept.SelectedIndex].ToString());
                }
                showData(conditions);
            }
            else
            {
                showData();
            }
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
                id = int.Parse(txtStaffId.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Primary key must be a number!\n" + ex);
                return;
            }

            if (DatabaseAdapter.retrieveDataOneCol($"SELECT [UserID] FROM [User] WHERE [UserID]={id}").Count > 0)
            {
                MessageBox.Show("Primary key duplicated in data entry");
                return;
            }

            Dictionary<string, object> sqlDataValues = new Dictionary<string, object>();
            sqlDataValues.Add("@id", txtStaffId.Text);
            sqlDataValues.Add("@tel", txtStaffName.Text);
            sqlDataValues.Add("@type", cbStaffType.Items[cbStaffType.SelectedIndex]);
            sqlDataValues.Add("@dept", cbDept.Items[cbDept.SelectedIndex]);
            if (DatabaseAdapter.execute("INSERT INTO [User]([UserID], [UserName], [UserType], [StaffDept]) VALUES(?, ?, ?, ?)", sqlDataValues) > 0)
            {
                MessageBox.Show("Data inserted");
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
                id = int.Parse(txtStaffId.Text);
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
            sqlDataValues.Add("@name", txtStaffName.Text);
            sqlDataValues.Add("@type", cbStaffType.Items[cbStaffType.SelectedIndex]);
            sqlDataValues.Add("@dept", cbDept.Items[cbDept.SelectedIndex]);
            sqlDataValues.Add("@id", txtStaffId.Text);
            DatabaseAdapter.execute("UPDATE [User] " +
                "SET [UserName]= ?, [UserType]= ?, [StaffDept]= ? " +
                $"WHERE [UserID]= ?;", sqlDataValues);
            showData();
        }
        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            if (dgvStaffInfo.SelectedRows.Count < 0)
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
                foreach (DataGridViewRow row in dgvStaffInfo.SelectedRows)
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
