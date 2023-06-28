<<<<<<< HEAD
﻿using System;
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
    public partial class AgreeFrmCreateBPA : Form
    {
        public event EventHandler dataChanged;
        public AgreeFrmCreateBPA()
        {
            InitializeComponent();
            initItemCategory();
        }
        private void initItemCategory()
        {
            cbItemCategory.Items.Add("Category1");
            cbItemCategory.Items.Add("Category2");
            cbItemCategory.Items.Add("Category3");

            //List<object> dataRows = DatabaseAdapter.retrieveDataOneCol("SELECT [ItemCategoryList] FROM [UtilTable];");
            //List<string> cbListValues = new List<string>();
            //foreach (object o in dataRows)
            //{
            //    if (o != DBNull.Value)
            //    {
            //        cbListValues.Add((string)o);
            //    }
            //}
            //foreach (string s in cbListValues)
            //{
            //    cbItemCategory.Items.Add(s);
            //}
            //cbItemCategory.SelectedIndex = 0;
        }
        private void btnCreateBPA_Click(object sender, EventArgs e)
        {
            if (txtSupplierID.Text == "" || ContractCreateDate.Text == "" || txtContractEffectiveDate.Text == "" || txtCurrency.Text == ""
                || txtItemPrice.Text == "" || txtTotalAmount.Text == "" || txtAmountAgreed.Text == "" || txtUOM.Text == ""
                || txtMOQ.Text == "" || txtItemDescription.Text == "" || txtBreakQuantity.Text == "" || txtBreakPrice.Text == "" 
                || kryptonTextBox17.Text == "" || cbItemCategory.SelectedIndex < 1)
            {
                MessageBox.Show("Data entry incomplete");
                return;
            }
            int supplierId = 0;
            try
            {
                supplierId = int.Parse(txtSupplierID.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Data entry invalid\n" + ex);
                return;
            }
            Regex regexDate = new Regex(@"^\d{4}-(0[1-9]|1[012])-(0[1-9]|[12][0-9]|3[01])$");
            if (!regexDate.IsMatch(ContractCreateDate.Text) || !regexDate.IsMatch(txtContractEffectiveDate.Text))
            {
                MessageBox.Show("Data entry invalid");
                return;
            }
            Dictionary<string, object> sqlDataValues = new Dictionary<string, object>();
            sqlDataValues.Add("@SupplierID", txtSupplierID.Text);
            sqlDataValues.Add("@Currency", txtCurrency.Text);
            sqlDataValues.Add("@CreateDate", ContractCreateDate.Text);
            sqlDataValues.Add("@EffectiveDate", txtContractEffectiveDate.Text);
            sqlDataValues.Add("@ItemCategory", cbItemCategory.Items[cbItemCategory.SelectedIndex]);
            sqlDataValues.Add("@ItemDesc", txtItemDescription.Text);
            sqlDataValues.Add("@ItemPrice", txtItemPrice.Text);
            sqlDataValues.Add("@TotalAmount", txtTotalAmount.Text);
            sqlDataValues.Add("@AmountAgreed", txtAmountAgreed.Text);
            sqlDataValues.Add("@UOM", txtUOM.Text);
            sqlDataValues.Add("@MOQ", txtMOQ.Text);
            sqlDataValues.Add("@BreakQuantity", txtBreakQuantity.Text);
            sqlDataValues.Add("@BreakPrice", txtBreakPrice.Text);
            sqlDataValues.Add("@Discount", txtPriceBreakDiscount.Text);
            int success = DatabaseAdapter.execute(  
                "INSERT INTO [Agreement]([AgreementType], [SupplierID], [Currency], [CreateDate]," +
                " [EffectiveDate], [ItemCategory], [ItemDesc], [ItemPrice]," +
                " [TotalAmount], [AmountAgreed], [UOM], [MOQ], " +
                "[BreakQuantity], [BreakPrice], [Discount])" +
                "VALUES ('BPA', ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?);", sqlDataValues);
            if (success > 0)
            {
                MessageBox.Show("Data inserted");
                dataChanged?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
        }
        private void btnCancelBPA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //==========================================

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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using YRG_4915M.Database;

namespace YRG_4915M.Pages.AgreementManagement
{
    public partial class AgreeFrmCreateBPA : Form
    {
        public event EventHandler dataChanged;
        public AgreeFrmCreateBPA()
        {
            InitializeComponent();
            initItemCategory();
        }
        private void initItemCategory()
        {
            cbItemCategory.Items.Add("Category1");
            cbItemCategory.Items.Add("Category2");
            cbItemCategory.Items.Add("Category3");

            //List<object> dataRows = DatabaseAdapter.retrieveDataOneCol("SELECT [ItemCategoryList] FROM [UtilTable];");
            //List<string> cbListValues = new List<string>();
            //foreach (object o in dataRows)
            //{
            //    if (o != DBNull.Value)
            //    {
            //        cbListValues.Add((string)o);
            //    }
            //}
            //foreach (string s in cbListValues)
            //{
            //    cbItemCategory.Items.Add(s);
            //}
            //cbItemCategory.SelectedIndex = 0;
        }
        private void btnCreateBPA_Click(object sender, EventArgs e)
        {
            if (txtSupplierID.Text == "" || ContractCreateDate.Text == "" || txtContractEffectiveDate.Text == "" || txtCurrency.Text == ""
                || txtItemPrice.Text == "" || txtTotalAmount.Text == "" || txtAmountAgreed.Text == "" || txtUOM.Text == ""
                || txtMOQ.Text == "" || txtItemDescription.Text == "" || txtBreakQuantity.Text == "" || txtBreakPrice.Text == "" 
                || kryptonTextBox17.Text == "" || cbItemCategory.SelectedIndex < 1)
            {
                MessageBox.Show("Data entry incomplete");
                return;
            }
            int supplierId = 0;
            try
            {
                supplierId = int.Parse(txtSupplierID.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Data entry invalid\n" + ex);
                return;
            }
            Regex regexDate = new Regex(@"^\d{4}-(0[1-9]|1[012])-(0[1-9]|[12][0-9]|3[01])$");
            if (!regexDate.IsMatch(ContractCreateDate.Text) || !regexDate.IsMatch(txtContractEffectiveDate.Text))
            {
                MessageBox.Show("Data entry invalid");
                return;
            }
            Dictionary<string, object> sqlDataValues = new Dictionary<string, object>();
            sqlDataValues.Add("@SupplierID", txtSupplierID.Text);
            sqlDataValues.Add("@Currency", txtCurrency.Text);
            sqlDataValues.Add("@CreateDate", ContractCreateDate.Text);
            sqlDataValues.Add("@EffectiveDate", txtContractEffectiveDate.Text);
            sqlDataValues.Add("@ItemCategory", cbItemCategory.Items[cbItemCategory.SelectedIndex]);
            sqlDataValues.Add("@ItemDesc", txtItemDescription.Text);
            sqlDataValues.Add("@ItemPrice", txtItemPrice.Text);
            sqlDataValues.Add("@TotalAmount", txtTotalAmount.Text);
            sqlDataValues.Add("@AmountAgreed", txtAmountAgreed.Text);
            sqlDataValues.Add("@UOM", txtUOM.Text);
            sqlDataValues.Add("@MOQ", txtMOQ.Text);
            sqlDataValues.Add("@BreakQuantity", txtBreakQuantity.Text);
            sqlDataValues.Add("@BreakPrice", txtBreakPrice.Text);
            sqlDataValues.Add("@Discount", txtPriceBreakDiscount.Text);
            int success = DatabaseAdapter.execute(  
                "INSERT INTO [Agreement]([AgreementType], [SupplierID], [Currency], [CreateDate]," +
                " [EffectiveDate], [ItemCategory], [ItemDesc], [ItemPrice]," +
                " [TotalAmount], [AmountAgreed], [UOM], [MOQ], " +
                "[BreakQuantity], [BreakPrice], [Discount])" +
                "VALUES ('BPA', ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?);", sqlDataValues);
            if (success > 0)
            {
                MessageBox.Show("Data inserted");
                dataChanged?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
        }
        private void btnCancelBPA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //==========================================

    }
}
>>>>>>> e3039030246399001b6a193ac0434d0ab124b1f7
