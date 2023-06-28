<<<<<<< HEAD
﻿using Krypton.Toolkit;
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
    public partial class AgreeFrmCreateCPA : Form
    {
        public event EventHandler dataChanged;  
        public AgreeFrmCreateCPA()
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
        //==========================================
        private void btnCreateCPA_Click(object sender, EventArgs e)
        {
            if (txtSupplierId.Text == "" || txtCurrency.Text == "" || txtCreateDate.Text == "" || txtEffectiveUntilDate.Text == "" || txtItemDescription.Text == ""
                || cbItemCategory.SelectedIndex < 1)
            {
                MessageBox.Show("Data entry incomplete");
                return;
            }
            int supplierId = 0;
            try
            {
                supplierId = int.Parse(txtSupplierId.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Data entry invalid\n"+ex);
                return;
            }
            Regex regexDate = new Regex(@"^\d{4}-(0[1-9]|1[012])-(0[1-9]|[12][0-9]|3[01])$");
            if (!regexDate.IsMatch(txtCreateDate.Text) || !regexDate.IsMatch(txtEffectiveUntilDate.Text))
            {
                MessageBox.Show("Data entry invalid");
                return;
            }
            Dictionary<string, object> sqlDataValues = new Dictionary<string, object>();
            sqlDataValues.Add("@SupplierID", supplierId);
            sqlDataValues.Add("@Currency", txtCurrency.Text);
            sqlDataValues.Add("@CreateDate", txtCreateDate.Text);
            sqlDataValues.Add("@EffectiveDate", txtEffectiveUntilDate.Text);
            sqlDataValues.Add("@ItemDesc", txtItemDescription.Text);
            sqlDataValues.Add("@ItemCategory", cbItemCategory.Items[cbItemCategory.SelectedIndex]);
            int success = DatabaseAdapter.execute("INSERT INTO [Agreement]([AgreementType], [SupplierID], [Currency], [CreateDate], [EffectiveDate], [ItemDesc], [ItemCategory])" +
                "VALUES ('CPA', ?, ?, ?, ?, ?, ?);", sqlDataValues);
            if(success > 0)
            {
                MessageBox.Show("Data inserted");
                dataChanged?.Invoke(this, EventArgs.Empty);
                this.Close();
            }

        }

        private void btnCancelCPA_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
=======
﻿using Krypton.Toolkit;
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
    public partial class AgreeFrmCreateCPA : Form
    {
        public event EventHandler dataChanged;  
        public AgreeFrmCreateCPA()
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
        //==========================================
        private void btnCreateCPA_Click(object sender, EventArgs e)
        {
            if (txtSupplierId.Text == "" || txtCurrency.Text == "" || txtCreateDate.Text == "" || txtEffectiveUntilDate.Text == "" || txtItemDescription.Text == ""
                || cbItemCategory.SelectedIndex < 1)
            {
                MessageBox.Show("Data entry incomplete");
                return;
            }
            int supplierId = 0;
            try
            {
                supplierId = int.Parse(txtSupplierId.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Data entry invalid\n"+ex);
                return;
            }
            Regex regexDate = new Regex(@"^\d{4}-(0[1-9]|1[012])-(0[1-9]|[12][0-9]|3[01])$");
            if (!regexDate.IsMatch(txtCreateDate.Text) || !regexDate.IsMatch(txtEffectiveUntilDate.Text))
            {
                MessageBox.Show("Data entry invalid");
                return;
            }
            Dictionary<string, object> sqlDataValues = new Dictionary<string, object>();
            sqlDataValues.Add("@SupplierID", supplierId);
            sqlDataValues.Add("@Currency", txtCurrency.Text);
            sqlDataValues.Add("@CreateDate", txtCreateDate.Text);
            sqlDataValues.Add("@EffectiveDate", txtEffectiveUntilDate.Text);
            sqlDataValues.Add("@ItemDesc", txtItemDescription.Text);
            sqlDataValues.Add("@ItemCategory", cbItemCategory.Items[cbItemCategory.SelectedIndex]);
            int success = DatabaseAdapter.execute("INSERT INTO [Agreement]([AgreementType], [SupplierID], [Currency], [CreateDate], [EffectiveDate], [ItemDesc], [ItemCategory])" +
                "VALUES ('CPA', ?, ?, ?, ?, ?, ?);", sqlDataValues);
            if(success > 0)
            {
                MessageBox.Show("Data inserted");
                dataChanged?.Invoke(this, EventArgs.Empty);
                this.Close();
            }

        }

        private void btnCancelCPA_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
>>>>>>> e3039030246399001b6a193ac0434d0ab124b1f7
