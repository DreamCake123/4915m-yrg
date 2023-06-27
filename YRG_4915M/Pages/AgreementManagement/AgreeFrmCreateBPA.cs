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
            if (txtItemID.Text == "" || kryptonTextBox8.Text == "" || kryptonTextBox9.Text == "" || kryptonTextBox16.Text == ""
                || kryptonTextBox13.Text == "" || kryptonTextBox14.Text == "" || kryptonTextBox10.Text == "" || kryptonTextBox11.Text == ""
                || kryptonTextBox12.Text == "" || txtItemDescription.Text == "" || kryptonTextBox15.Text == "" || kryptonTextBox18.Text == "" 
                || kryptonTextBox17.Text == "" || cbItemCategory.SelectedIndex < 1)
            {
                MessageBox.Show("Data entry incomplete");
                return;
            }
            int supplierId = 0;
            try
            {
                supplierId = int.Parse(txtItemID.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Data entry invalid\n" + ex);
                return;
            }
            Regex regexDate = new Regex(@"^\d{4}-(0[1-9]|1[012])-(0[1-9]|[12][0-9]|3[01])$");
            if (!regexDate.IsMatch(kryptonTextBox8.Text) || !regexDate.IsMatch(kryptonTextBox9.Text))
            {
                MessageBox.Show("Data entry invalid");
                return;
            }
            Dictionary<string, object> sqlDataValues = new Dictionary<string, object>();
            sqlDataValues.Add("@SupplierID", txtItemID.Text);
            sqlDataValues.Add("@Currency", kryptonTextBox16.Text);
            sqlDataValues.Add("@CreateDate", kryptonTextBox8.Text);
            sqlDataValues.Add("@EffectiveDate", kryptonTextBox9.Text);
            sqlDataValues.Add("@ItemCategory", cbItemCategory.Items[cbItemCategory.SelectedIndex]);
            sqlDataValues.Add("@ItemDesc", txtItemDescription.Text);
            sqlDataValues.Add("@ItemPrice", kryptonTextBox13.Text);
            sqlDataValues.Add("@TotalAmount", kryptonTextBox14.Text);
            sqlDataValues.Add("@AmountAgreed", kryptonTextBox10.Text);
            sqlDataValues.Add("@UOM", kryptonTextBox11.Text);
            sqlDataValues.Add("@MOQ", kryptonTextBox12.Text);
            sqlDataValues.Add("@BreakQuantity", kryptonTextBox15.Text);
            sqlDataValues.Add("@BreakPrice", kryptonTextBox18.Text);
            sqlDataValues.Add("@Discount", kryptonTextBox17.Text);
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
