using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace dbConnectivityTest1
{
    public class SQLConn
    {
        private readonly string _connectionString;
        private List<SqlParameter> _paramList;
        public string excptnShow;
        public int recordCount;
        public DataTable sqlDT = new DataTable();
        
        public SqlDataReader sqlDR;
        public SQLConn()
        {
            _connectionString = "Server=ROHIT-LAPTOP\\SQLEXPRESS;Database=practiceTest;User Id=practiceTestSA;Password=practiceDB@1012;Encrypt=False";
            _paramList = new List<SqlParameter>();
        }

        public void AddParams(string tableName, object insVal)
        {
            SqlParameter sqlparams = new SqlParameter(tableName, insVal);
            _paramList.Add(sqlparams);
        }

        public void sqlQueryCmd(string sqlQuery)
        {
            using (var sqlConn = new SqlConnection(_connectionString))
            {
                try
                {
                    sqlConn.Open();
                    SqlCommand sqlCmd = new SqlCommand(sqlQuery, sqlConn);
                    _paramList.ForEach(p => { sqlCmd.Parameters.Add(p); });
                    _paramList.Clear();
                        DataSet oDs = new DataSet();
                        SqlDataAdapter sqlDA = new SqlDataAdapter(sqlCmd);
                    sqlDA.Fill(oDs);
                    //sqlDR = sqlCmd.ExecuteReader();
                    //sqlDA.Fill(oDs);
                    sqlDT = oDs.Tables[0]; 

                }
                catch (Exception ex)
                {
                    excptnShow = "Error: \r\n" + ex.Message;
                }
                finally
                {
                    if (sqlConn.State == ConnectionState.Open)
                    {
                        sqlConn.Close();
                    }
                }
            }
        }
    }
}
