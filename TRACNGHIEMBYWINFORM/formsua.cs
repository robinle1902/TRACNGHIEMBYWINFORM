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
    public partial class Formsua : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog =quiz; Integrated Security = True");
        public Formsua()
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
        private string DapAn = "";
        private void radA_CheckedChanged_1(object sender, EventArgs e)
        {
            DapAn = "A";
        }

        private void radB_CheckedChanged(object sender, EventArgs e)
        {
            DapAn = "B";
        }

        private void radC_CheckedChanged(object sender, EventArgs e)
        {
            DapAn = "C";
        }

        private void radD_CheckedChanged(object sender, EventArgs e)
        {
            DapAn = "D";
        }
        public void fresh()
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
        void sua()
        {
            if (rtxtNoiDung.Text != "" || txtchude.Text != "" || txtA.Text != "" || txtB.Text != "" || txtC.Text != "" || txtD.Text != "" || txtGhiChu.Text != "" || txtmade.Text != "")
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(" Update new set noidung='" + rtxtNoiDung.Text + "',chude='" + txtchude.Text + "',dapanA='" + txtA.Text + "',dapanB='" + txtB.Text + "',dapanC='" + txtC.Text + "',dapanD='" + txtD.Text + "',DapAn='" + DapAn + "'where madt='" + txtmade.Text + "'and cau='" + txtGhiChu.Text + "'", con);
                SqlDataAdapter da1 = new SqlDataAdapter(" Update new set noidung='" + rtxtNoiDung.Text + "',madt='" + txtmade.Text + "',cau='"+txtGhiChu.Text+"',dapanA='" + txtA.Text + "',dapanB='" + txtB.Text + "',dapanC='" + txtC.Text + "',dapanD='" + txtD.Text + "',DapAn='" + DapAn + "'where chude='" + txtchude.Text +"'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                da1.Fill(dt);
                dataGridView1.DataSource = dt;
                MessageBox.Show("Sửa thành công");
                fresh();
                con.Close();
                loadtable();
            }
            else

                MessageBox.Show(" Chọn câu để sửa !","THÔNG BÁO");
        
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmade.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtchude.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtGhiChu.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            rtxtNoiDung.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            txtA.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtB.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtC.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtD.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sua();
        }
    }
    }

