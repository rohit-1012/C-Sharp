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
        public static void Main1(string[] args)
        {
            using (SqlConnection connString = new SqlConnection("Server=ROHIT-LAPTOP\\SQLEXPRESS;Database=practiceTest;User Id=practiceTestSA;\r\nPassword=practiceDB@1012;"))
            {
                List<SqlParameter> paramList = new List<SqlParameter>();
                string AddParams(string tableName, object insVal)
                {
                    SqlParameter sqlparams = new SqlParameter(tableName, insVal);
                    paramList.Add(sqlparams);
                }
                SqlCommand sqlCmd = new SqlCommand();

                string sqlQueryCmd(string sqlQuery)
                {
                    int recordCount = 0;
                    string excptnShow = "";

                    try
                    {
                        connString.Open();
                        SqlCommand sqlCmd = new SqlCommand(sqlQuery, connString);
                        paramList.ForEach(p => { sqlCmd.Parameters.Add(p); });
                        paramList.Clear();
                        DataTable sqlDT = new DataTable();
                        SqlDataAdapter sqlDA = new SqlDataAdapter(sqlCmd);
                        recordCount = sqlDA.Fill(sqlDT);
                    }
                    catch(Exception ex)
                    {
                        excptnShow = "Error: \r\n" + ex.Message;
                    }
                    finally
                    {
                        if (connString.State == ConnectionState.Open)
                        {
                            connString.Close();
                        }
                    }
                }
            }
        }
    }
}
