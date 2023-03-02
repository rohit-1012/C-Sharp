using Microsoft.Data.SqlClient;

namespace dbConnectivityTest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlDBCon = new SqlConnection("Server=ROHIT-LAPTOP\\SQLEXPRESS;Database=receptionKioskDB;User=receptionKioskSA;Pwd=BliincInnov@2022;Encrypt=False;");
        }
    }
}