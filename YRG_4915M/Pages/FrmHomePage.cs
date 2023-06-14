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

namespace YRG_4915M
{
    public partial class FrmHomePage : DockContent
    {
        const string CONNSTR = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=db.accdb";
        string sqlStr = "";
        DataTable dt;
        OleDbDataAdapter dataAdapter;
        public FrmHomePage()
        {
            InitializeComponent();
            reloadData();
        }
        void reloadData()
        {
            textBox1.Text = "";

            textBox1.AppendText("=====Items=====");
            textBox1.AppendText(Environment.NewLine);
            sqlStr = "SELECT * FROM [Item]";

            dt = new DataTable();
            dataAdapter = new OleDbDataAdapter(sqlStr, CONNSTR);
            dataAdapter.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    textBox1.AppendText($"[{dt.Columns[j]}]: {dt.Rows[i].ItemArray[j]}      ");

                }
                textBox1.AppendText(Environment.NewLine);
            }

            textBox1.AppendText("=====Request=====");
            textBox1.AppendText(Environment.NewLine);
            sqlStr = "SELECT * FROM [Request]";
            dt = new DataTable();
            dataAdapter = new OleDbDataAdapter(sqlStr, CONNSTR);
            dataAdapter.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    textBox1.AppendText($"[{dt.Columns[j]}]: {dt.Rows[i].ItemArray[j]}      ");

                }
                textBox1.AppendText(Environment.NewLine);
            }

            dataAdapter.Dispose();
        }

        private void btnNewItem_Click(object sender, EventArgs e)
        {
            int pk = 0;
            try
            {
                pk = int.Parse(tbPkId.Text);
            }
            catch (FormatException ex)
            {
                return;
            }
            sqlStr = $"INSERT INTO [Item] VALUES ('{pk}', '{tbItemName.Text}', '{tbItemType.Text}');";
            using (OleDbConnection connection = new OleDbConnection(CONNSTR))
            {
                connection.Open();

                using (OleDbCommand command = new OleDbCommand(sqlStr, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            reloadData();
        }

        private void btnInsertRequest_Click(object sender, EventArgs e)
        {
            int pk = 0;
            int itemId = 0;
            try
            {
                pk = int.Parse(tbPkId.Text);
                itemId = int.Parse(tbRequestNumber.Text);
            }catch(FormatException ex)
            {
                return;
            }
            sqlStr = $"INSERT INTO [Request] VALUES ('{pk}', '{tbRequestStatus.Text}', {itemId});";
            using (OleDbConnection connection = new OleDbConnection(CONNSTR))
            {
                connection.Open();

                using (OleDbCommand command = new OleDbCommand(sqlStr, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            reloadData();
        }
    }
}
