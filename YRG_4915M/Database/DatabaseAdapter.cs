using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YRG_4915M.Database
{
    internal class DatabaseAdapter
    {
        const string CONNSTR = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=db.accdb";
        private static OleDbConnection conn;
        public static DataSet retrieveDataSet(string sqlQuery)
        {
            using (OleDbConnection conn = new OleDbConnection(CONNSTR))
            {
                OleDbCommand cmd = new OleDbCommand(sqlQuery, conn);
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                conn.Open();
                dataAdapter.Fill(dataSet);
                conn.Close();
                return dataSet;
            }
        }
        public static DataSet retrieveDataSet(string sqlQuery, Dictionary<string, object> sqlParameters)
        {
            using (OleDbConnection conn = new OleDbConnection(CONNSTR))
            {
                OleDbCommand cmd = new OleDbCommand(sqlQuery, conn);
                foreach (KeyValuePair<string, object> entry in sqlParameters)
                {
                    OleDbParameter newParam = new OleDbParameter(entry.Key, entry.Value);
                    cmd.Parameters.Add(newParam);
                }
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                conn.Open();
                dataAdapter.Fill(dataSet);
                conn.Close();
                return dataSet;
            }
        }
        public static List<object> retrieveDataOneCol(string sqlStr, Dictionary<string, object> sqlParameters)
        {
            using (OleDbConnection conn = new OleDbConnection(CONNSTR))
            {
                OleDbCommand cmd = new OleDbCommand(sqlStr, conn);
                foreach (KeyValuePair<string, object> entry in sqlParameters)
                {
                    OleDbParameter newParam = new OleDbParameter(entry.Key, entry.Value);
                    cmd.Parameters.Add(newParam);
                }
                List<object> outputList = new List<object>();
                try
                {
                    conn.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        outputList.Add(reader.GetValue(0));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DatabaseAdapter Error: \n" + ex);
                }
                conn.Close();
                return outputList;
            }
        }
        public static List<object> retrieveDataOneCol(string sqlStr)
        {
            using(OleDbConnection conn = new OleDbConnection(CONNSTR))
            {
                OleDbCommand cmd = new OleDbCommand(sqlStr, conn);
                List<object> outputList = new List<object>();
                try
                {
                    conn.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        outputList.Add(reader.GetValue(0));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DatabaseAdapter Error: \n" + ex);
                }
                finally
                {
                    conn.Close();
                }
                return outputList;
            }
        }

        public static int execute(string sqlStr, Dictionary<string, object> sqlParameters)
        {
            int affected = 0;
            using (OleDbConnection conn = new OleDbConnection(CONNSTR))
            {
                OleDbCommand cmd = new OleDbCommand(sqlStr, conn);
                foreach (KeyValuePair<string, object> entry in sqlParameters)
                {
                    OleDbParameter newParam = new OleDbParameter(entry.Key, entry.Value);
                    cmd.Parameters.Add(newParam);
                }
                try
                {
                    conn.Open();
                    affected = cmd.ExecuteNonQuery();
                }
                catch (OleDbException ex)
                {
                    string errorString = "Database Adapter Error: \n";
                    foreach (OleDbError error in ex.Errors)
                    {
                        errorString +=
                            $"Status: {error.SQLState}\n Error {error.Message}\n Query: {cmd.CommandText}";
                    }
                    
                }catch(Exception ex)
                {
                    MessageBox.Show("Unknown Error: \n" + ex + "\nQuery:\n" + cmd.CommandText);
                }
                finally
                {
                    conn.Close();
                }
            }
            return affected;
        }
    }
}
