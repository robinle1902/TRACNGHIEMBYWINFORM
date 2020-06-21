using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;
using System.IO;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace TRACNGHIEMBYWINFORM
{
    public partial class Themtheofile : Form
    {
       
        public Themtheofile()
        {
            InitializeComponent();
        }
        DataSet dsTest = new DataSet();
        private void btn_excel_Click(object sender, EventArgs e)
        {
            OleDbConnection olecon = new OleDbConnection();
            string strCon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/super/Desktop/fileexport/finalcauhoi2.xls;Extended Properties=Excel 8.0";
            olecon.ConnectionString = strCon;
            olecon.Open();
            string strSQL = "SELECT * FROM [Finalcauhoi$]";
            OleDbDataAdapter oleda = new OleDbDataAdapter(strSQL, olecon);
            oleda.Fill(dsTest);
            olecon.Close();
            dsTest.Tables[0].TableName = "new";//Tên này phải giống với tên của Table trên SQL
            dataGridView1.DataSource = dsTest.Tables[0];
        }
        public bool ExecBulkCopy(DataTable pDt, string pDesTableName = "")
        {
            try
            {
                if (pDesTableName.Length == 0) pDesTableName = pDt.TableName;
                using (SqlConnection sqlCon = new SqlConnection("Data Source =.; Initial Catalog = quiz; Integrated Security = True"))
                {
                    sqlCon.Open();
                    using (SqlBulkCopy sbc = new SqlBulkCopy(sqlCon))
                    {
                        sbc.DestinationTableName = pDesTableName;
                        sbc.WriteToServer(pDt);
                    }
                }
                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }
        private void btn_SQL_Click(object sender, EventArgs e)
        {
            if (!ExecBulkCopy(dsTest.Tables[0], "new"))
                MessageBox.Show("Không thành công!", "THÔNG BÁO");
            else
                MessageBox.Show("Đã thực hiện thành công!", "THÔNG BÁO ");
        }
    }
}
