using Krypton.Toolkit;
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
    public partial class AgreeFrmMajor : DockContent
    {
        public AgreeFrmMajor()
        {
            InitializeComponent();
            initComboBox();
            showData();
        }
        private void initComboBox()
        {
            cbAgreeType.Items.Add("*All*");
            cbAgreeType.Items.Add("BPA");
            cbAgreeType.Items.Add("CPA");
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
            DataSet dataSet = DatabaseAdapter.retrieveDataSet("SELECT * FROM [Agreement];");
            dgvAgreement.DataSource = dataSet.Tables[0];
            dgvAgreement.ClearSelection();
            dgvAgreement.CurrentCell = null;
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
                "WHERE [ID] LIKE ? AND [AgreementType] LIKE ? AND [Currency] LIKE ? AND [SupplierID] LIKE ?;",
                paramList);
            dgvAgreement.DataSource = dataSet.Tables[0];
            dgvAgreement.ClearSelection();
            dgvAgreement.CurrentCell = null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtAgreeId.Text != "" || txtSuppId.Text != "" || cbAgreeType.SelectedIndex >= 0 || cbCurrency.SelectedIndex >= 0)
            {
                Dictionary<string, string> conditions = new Dictionary<string, string>();
                conditions.Add("@ID", txtAgreeId.Text);
                if (cbAgreeType.SelectedIndex < 0 || cbAgreeType.Items[cbAgreeType.SelectedIndex].ToString().Equals("*All*"))
                {
                    conditions.Add("@agreementType", "");
                }
                else
                {
                    conditions.Add("@agreementType", cbAgreeType.Items[cbAgreeType.SelectedIndex].ToString());
                }
                if (cbCurrency.SelectedIndex < 0 || cbCurrency.Items[cbCurrency.SelectedIndex].ToString().Equals("*All*"))
                {
                    conditions.Add("@currency", "");
                }
                else
                {
                    conditions.Add("@currency", cbCurrency.Items[cbCurrency.SelectedIndex].ToString());
                }
                conditions.Add("@supplierID", txtSuppId.Text);
                showData(conditions);
            }
            else
            {
                showData();
            }
        }
        //===============================
    }
}
