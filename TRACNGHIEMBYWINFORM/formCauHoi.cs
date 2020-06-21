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
using System.Data.OleDb;

namespace TRACNGHIEMBYWINFORM
{

    public partial class FormCauHoi : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog =quiz; Integrated Security = True");
        public FormCauHoi()
        {
            InitializeComponent();
            loadtable();
        }
        public void loadtable()
        {
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM new", con);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridView1.DataSource = dtbl;


                con.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadtable();
        }



        private void btn_them_Click(object sender, EventArgs e)
        {
            FormThemCauHoi n = new FormThemCauHoi();
            n.ShowDialog();
        }
        private void fresh()
        {
            txtcau.Text = "";
            txt_made.Text = "";
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
           
            if (txt_made.Text != "" || txtcau.Text != "")
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("Delete from new WHERE cau='" + txtcau.Text + "'AND madt='" + txt_made.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                MessageBox.Show("Đã xóa thành công");
                fresh();
                con.Close();
            }
            else
            {
                MessageBox.Show("File đã xóa hoặc không tồn tại !", "THÔNG BÁO");
            }

           

        }

        private void btn_Sửa_Click(object sender, EventArgs e)
        {
            Formsua n = new Formsua();
            n.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_made.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtcau.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void txt_made_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcau_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}

