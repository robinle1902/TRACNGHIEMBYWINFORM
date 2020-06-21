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
    public partial class form_DangKy : Form
    {
        SqlConnection con = new SqlConnection("Data Source =.;Initial Catalog=quiz; Integrated Security = True");
        public form_DangKy()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        public void add_tk()
        {
            

        }
        public void clear ()
        {
            txt_username.Text = ("");
            txt_pw.Text = ("");
            txt_xacnhanpw.Text = ("");
        }
        private void btn_dangky_dangky_Click(object sender, EventArgs e)
        {
            int count = 1;
            if (txt_username.Text != "" && txt_pw.Text != "" || txt_xacnhanpw.Text != "")
            {
                if (txt_pw.Text == txt_xacnhanpw.Text)
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("INSERT INTO login VALUES('" + txt_username.Text + "' , '" + txt_pw.Text + "')", con);
                    DataTable dt = new DataTable();

                    try
                    {
                        da.Fill(dt);
                        
                    }
                    catch (Exception)
                    { 
                        MessageBox.Show(" Tài khoản đã tồn tại trên hệ thống ", " Thông Báo ");
                        clear();
                        count = 0;
                       
                    }
                    if (count == 1 )
                    {
                        MessageBox.Show(" Đăng ký thành công ", "Thông Báo");
                        clear();
                        con.Close();
                    }
                }
                else
                    MessageBox.Show(" Mật khẩu không khớp ! Xin vui lòng kiểm tra lại ", "Thông Báo");

            }
            else
                MessageBox.Show(" Bạn chưa nhập gì cả ! ", "Thông Báo");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login n = new Login();
            n.ShowDialog();
            this.Close();

        }
    }
}
