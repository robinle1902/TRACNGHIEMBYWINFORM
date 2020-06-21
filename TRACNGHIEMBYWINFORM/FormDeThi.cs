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

using iTextSharp.text;
using iTextSharp.text.pdf;

using System.IO;

namespace TRACNGHIEMBYWINFORM
{
    
    public partial class FormDeThi : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog =quiz; Integrated Security = True");
        public FormDeThi()
        {
            InitializeComponent();
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
             SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog =quiz; Integrated Security = True");
            con.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT distinct * FROM new where chude=N'"+txt_timkiem.Text+"'", con);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
        }


        /// //////////////////////////////////////////////////////////////////////////
        private void FormDeThi_Load(object sender, EventArgs e)
        {
            SqlConnection sqlCon;
            string conString = null;
            string sqlQuery = null;

            conString = "Data Source=.;Initial Catalog=quiz;Integrated Security=True;";
            sqlCon = new SqlConnection(conString);
            sqlCon.Open();
            sqlQuery = "SELECT * FROM new";
            SqlDataAdapter dscmd = new SqlDataAdapter(sqlQuery, sqlCon);
            DataTable dtData = new DataTable();
            dscmd.Fill(dtData);
            dataGridView1.DataSource = dtData;
        }
      
        private void btn_export_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            System.IO.File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Xuất Dữ Liệu Thành Công !!!", "THÔNG BÁO");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Không Có Câu Hỏi Nào Để Xuất !!!", "THÔNG BÁO");
            }

        }
    }
}
