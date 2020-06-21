using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;




namespace TRACNGHIEMBYWINFORM
{
    public partial class FormThemCauHoi : Form
    {

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog =quiz; Integrated Security = True");

      

        public FormThemCauHoi()
        {
            InitializeComponent();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormThemCauHoi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quizDataSet1.table_cauhoi2' table. You can move, or remove it, as needed.


        }
        

        private void cboChuDe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rtxtNoiDung_TextChanged(object sender, EventArgs e)
        {

        }

        public string DapAn = "";
        private void radA_CheckedChanged(object sender, EventArgs e)
        {
            DapAn = "A";

        }
        private void radB_CheckedChanged_1(object sender, EventArgs e)
        {
            DapAn = "B";
        }
        private void radC_CheckedChanged_1(object sender, EventArgs e)
        {
            DapAn = "C";
        }
        private void radD_CheckedChanged_1(object sender, EventArgs e)
        {
            DapAn = "D";
        }
        
        private void fresh()
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtD.Text = "";
            txtmade.Text = "";
            txtGhiChu.Text = "";
            txtchude.Text = "";
            rtxtNoiDung.Text = "";
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            int count = 0;

            if (txtGhiChu.Text == "" || txtA.Text == "" || txtB.Text == "" || txtC.Text == "" || txtD.Text == "" || txtchude.Text == "" || txtmade.Text == "")
            {
                MessageBox.Show("Bạn chưa điền đầy đủ câu hỏi ! Vui lòng kiểm tra lại ");
                count = 1;
            }

            if (count == 0)
            {
                if (radA.Checked || radB.Checked || radC.Checked || radD.Checked)
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("INSERT INTO new VALUES('" + txtmade.Text + " ' , '" + txtchude.Text + "','" + txtGhiChu.Text + "' , '" + rtxtNoiDung.Text + "','" + txtA.Text + "' , '" + txtB.Text + "','" + txtC.Text + "' , '" + txtD.Text + "','" + DapAn + "' )", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    MessageBox.Show("Thêm thành công");
                    fresh();
                    con.Close();
                }
                else
                    MessageBox.Show("Bạn chưa điền đầy đủ câu hỏi ! Vui lòng kiểm tra lại ");
            }

           
          
        }

        private void btn_themtheofile_Click(object sender, EventArgs e)
        {
            Themtheofile n = new Themtheofile();
            n.ShowDialog();
        }

    }
    }

