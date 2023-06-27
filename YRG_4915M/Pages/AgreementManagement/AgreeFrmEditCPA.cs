using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using YRG_4915M.Database;

namespace YRG_4915M.Pages.AgreementManagement
{
    public partial class AgreeFrmEditCPA : Form
    {
        public event EventHandler dataChanged;
        public DataRow editingDataRow;
        public AgreeFrmEditCPA()
        {
            InitializeComponent();
        }
        private void initAllData()
        {
            lblSuppId.Text = editingDataRow["SupplierID"].ToString();
            lblContractCreatedDate.Text = editingDataRow["CreateDate"].ToString();
            txtContractEffectiveDate.Text = editingDataRow["EffectiveDate"].ToString();
            lblCurrency.Text = editingDataRow["Currency"].ToString();
            lblItemCategory.Text = editingDataRow["ItemCategory"].ToString();
            lblItemDescription.Text = editingDataRow["ItemDesc"].ToString();
        }

        private void btnConfirmEditCPA_Click(object sender, EventArgs e)
        {
            if(txtContractEffectiveDate.Text == "")
            {
                MessageBox.Show("Data entry incomplete");
                return;
            }
            Regex regexDate = new Regex(@"^\d{4}-(0[1-9]|1[012])-(0[1-9]|[12][0-9]|3[01])$");
            if (!regexDate.IsMatch(txtContractEffectiveDate.Text))
            {
                MessageBox.Show("Data entry invalid");
                return;
            }
            Dictionary<string, object> sqlDataValues = new Dictionary<string, object>();
            sqlDataValues.Add("@EffectiveDate", txtContractEffectiveDate.Text);
            sqlDataValues.Add("@selectedKey", editingDataRow["ID"]);
            int success = DatabaseAdapter.execute("UPDATE [Agreement] SET [EffectiveDate]=? WHERE [ID]=?", sqlDataValues);
            if (success > 0) {
                MessageBox.Show("Data updated");
                dataChanged?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
        }
        private void AgreeFrmEditCPA_Load(object sender, EventArgs e)
        {
            initAllData();
        }
        private void btnCancelEditCPA_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
