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
using YRG_4915M.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace YRG_4915M.Pages.StockManagement
{
    public partial class StockFrmRestaurant : DockContent
    {
        public StockFrmRestaurant()
        {
            InitializeComponent();
            initComboBox();
            initRestaurant();
            showData();
        }
        //==========================================================================
        private void initComboBox()
        {
            cbItemType.Items.Add("*All*");
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
                cbItemType.Items.Add(s);
            }
            cbItemType.SelectedIndex = 0;
        }
        private void initRestaurant()
        {
            List<object> queryResult = DatabaseAdapter.retrieveDataOneCol($"SELECT [UserType] FROM [User] WHERE [UserName] = '{UserSingleton.username}';");
            if (queryResult.Count <= 0)
            {
                txtRestaurantID.Enabled = false;
                return;
            }
            string userType = (string)queryResult[0];
            if (userType == "Manager" || userType == "sysadmin")
            {
                txtRestaurantID.Enabled = true;
            }
            else
            {
                txtRestaurantID.Enabled = false;
            }
        }
        private void showData()
        {
            DataSet dataSet = DatabaseAdapter.retrieveDataSet("SELECT * FROM [RestaurantStockCount];");
            dgvStockCount.DataSource = dataSet.Tables[0];
            dgvStockCount.ClearSelection();
            dgvStockCount.CurrentCell = null;
        }
        private void showData(Dictionary<string, string> conditions)
        {
            Dictionary<string, object> paramList = new Dictionary<string, object>();
            foreach (KeyValuePair<string, string> entry in conditions)
            {
                paramList.Add(entry.Key, $"%{entry.Value}%");
            }
            DataSet dataSet = DatabaseAdapter.retrieveDataSet(
                "SELECT * FROM [RestaurantStockCount]" +
                "WHERE [RestID] LIKE ? AND [ItemVID] LIKE ? AND [ItemName] LIKE ? AND [ItemType] LIKE ?;",
                paramList);
            dgvStockCount.DataSource = dataSet.Tables[0];
            dgvStockCount.ClearSelection();
            dgvStockCount.CurrentCell = null;
        }
        //==========================================================================
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtRestaurantID.Text == "" || txtVirtualItemId.Text == "" || txtItemName.Text == "" || cbItemType.SelectedIndex > 0)
            {
                Dictionary<string, string> conditions = new Dictionary<string, string>();
                conditions.Add("@restId", txtRestaurantID.Text);
                conditions.Add("@vId", txtVirtualItemId.Text);
                conditions.Add("@name", txtItemName.Text);
                conditions.Add("@type", cbItemType.Items[cbItemType.SelectedIndex].ToString());
                showData(conditions);
            }
            else
            {
                showData();
            }
        }
        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
