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
    public partial class Login : Form
    {
       SqlConnection con = new SqlConnection("Data Source =.;Initial Catalog=quiz; Integrated Security = True");

        public Login()
        {
            InitializeComponent();
           
        }
        public void clear()
        {
            txtus.Text = "";
            txtpw.Text = "";
        }
        
        public void openCauHoi()
        {
            this.Hide();
            Main n = new Main();
            n.hienthiAdmin();
            n.ShowDialog();
            this.Close();
            

        }
        public void normal()
        {
            Main n = new Main();
            n.hienthiUser();
            n.hideonbush();
            n.ShowDialog();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM login WHERE username='" + txtus.Text + "'AND password='" + txtpw.Text + "'", con);
            DataTable dt = new DataTable();
            try
            { 
                da.Fill(dt);

                if (txtus.Text != "" || txtpw.Text != "")
                {
                    if (dt.Rows.Count > 0)
                    {
                        if (txtus.Text == "admin")
                        {
                         //   clear();
                            openCauHoi();
                           
                           
                        }
                        else
                        {
                       
                            normal();
                            label2.Text = "Hi user";

                        }
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu bạn vừa nhập chưa đúng ! Vui lòng nhập lại sau", "Thông Báo");
                    }

                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu bạn vừa nhập chưa đúng ! Vui lòng nhập lại sau", "Thông Báo");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu bạn vừa nhập chưa đúng ! Vui lòng nhập lại sau", "Thông Báo");
            }
           
            con.Close();

           
        }

        private void btn_dangki_Click(object sender, EventArgs e)
        {
            form_DangKy n = new form_DangKy();
            n.ShowDialog();
            
           
        }

        
    }
}
