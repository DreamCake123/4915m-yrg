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
    public partial class AgreeFrmEditBPA : Form
    {
        public event EventHandler dataChanged;
        public DataRow editingDataRow;
        public AgreeFrmEditBPA()
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
            txtItemPrice.Text = editingDataRow["ItemPrice"].ToString();
            lblTotalAmount.Text = editingDataRow["TotalAmount"].ToString();
            txtAmountAgreed.Text = editingDataRow["AmountAgreed"].ToString();
            lblUOM.Text = editingDataRow["UOM"].ToString();
            txtMOQ.Text = editingDataRow["MOQ"].ToString();
            lblItemDescription.Text = editingDataRow["ItemDesc"].ToString();
            txtPriceBreakQty.Text = editingDataRow["BreakQuantity"].ToString();
            txtPriceBreak.Text = editingDataRow["BreakPrice"].ToString();
            txtPriceBreakDiscount.Text = editingDataRow["Discount"].ToString();
        }
        private void btnConfirmEditBPA_Click(object sender, EventArgs e)
        {
            if (txtContractEffectiveDate.Text == "" || txtItemPrice.Text == "" || txtAmountAgreed.Text == "" || txtMOQ.Text == ""
                 || txtPriceBreakQty.Text == "" || txtPriceBreak.Text == "" | txtPriceBreakDiscount.Text == "")
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
            sqlDataValues.Add("@ItemPrice", txtItemPrice.Text);
            sqlDataValues.Add("@AmountAgreed", txtAmountAgreed.Text);
            sqlDataValues.Add("@MOQ", txtMOQ.Text);
            sqlDataValues.Add("@BreakQuantity", txtPriceBreakQty.Text);
            sqlDataValues.Add("@BreakPrice", txtPriceBreak.Text);
            sqlDataValues.Add("@Discount", txtPriceBreakDiscount.Text);
            sqlDataValues.Add("@selectedKey", editingDataRow["ID"]);
            int success = DatabaseAdapter.execute("UPDATE [Agreement] SET [EffectiveDate]=?, [ItemPrice]=?, [AmountAgreed]=?, [MOQ]=?, " +
                "[BreakQuantity]=?, [BreakPrice]=?, [Discount]=? WHERE [ID]=?", sqlDataValues);
            if (success > 0)
            {
                MessageBox.Show("Data updated");
                dataChanged?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
        }
        private void AgreeFrmEditBPA_Load(object sender, EventArgs e)
        {
            initAllData();
        }

        private void btnCancelEditBPA_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
