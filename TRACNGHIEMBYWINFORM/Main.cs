using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRACNGHIEMBYWINFORM
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
          
        }
        public void hienthiAdmin()
        {
            label2.Text = " Xin Chào Admin ! ";
        }
        public void hienthiUser()
        { 
            label2.Text = " Xin Chào User ! ";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FormCauHoi n = new FormCauHoi();
            n.ShowDialog();
        }
        public void hideonbush()
        {

            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDeThi n = new FormDeThi();
            n.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

      

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login n = new Login();
                n.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
