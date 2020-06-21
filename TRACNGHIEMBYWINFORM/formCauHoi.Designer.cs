namespace TRACNGHIEMBYWINFORM
{
    partial class FormCauHoi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCauHoi));
            this.btn_capnhap = new System.Windows.Forms.Button();
            this.quizDataSet = new TRACNGHIEMBYWINFORM.quizDataSet();
            this.bangcauhoiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bangcauhoiTableAdapter = new TRACNGHIEMBYWINFORM.quizDataSetTableAdapters.bangcauhoiTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaDeThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CauHoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DapAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_Sửa = new System.Windows.Forms.Button();
            this.txt_made = new System.Windows.Forms.TextBox();
            this.txtcau = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangcauhoiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_capnhap
            // 
            this.btn_capnhap.BackgroundImage = global::TRACNGHIEMBYWINFORM.Properties.Resources.Custom_Icon_Design_Pretty_Office_2_Help_desk;
            this.btn_capnhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_capnhap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capnhap.Location = new System.Drawing.Point(976, 35);
            this.btn_capnhap.Name = "btn_capnhap";
            this.btn_capnhap.Size = new System.Drawing.Size(150, 70);
            this.btn_capnhap.TabIndex = 2;
            this.btn_capnhap.Text = "         Cập Nhập";
            this.btn_capnhap.UseVisualStyleBackColor = true;
            this.btn_capnhap.Click += new System.EventHandler(this.button2_Click);
            // 
            // quizDataSet
            // 
            this.quizDataSet.DataSetName = "quizDataSet";
            this.quizDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bangcauhoiBindingSource
            // 
            this.bangcauhoiBindingSource.DataMember = "bangcauhoi";
            this.bangcauhoiBindingSource.DataSource = this.quizDataSet;
            // 
            // bangcauhoiTableAdapter
            // 
            this.bangcauhoiTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDeThi,
            this.chude,
            this.CauHoi,
            this.NoiDung,
            this.A,
            this.B,
            this.C,
            this.D,
            this.DapAN});
            this.dataGridView1.Location = new System.Drawing.Point(1, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1158, 396);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MaDeThi
            // 
            this.MaDeThi.DataPropertyName = "madt";
            this.MaDeThi.HeaderText = "Mã Đề Thi";
            this.MaDeThi.MinimumWidth = 6;
            this.MaDeThi.Name = "MaDeThi";
            this.MaDeThi.ReadOnly = true;
            // 
            // chude
            // 
            this.chude.DataPropertyName = "chude";
            this.chude.HeaderText = "Chủ Đề";
            this.chude.MinimumWidth = 6;
            this.chude.Name = "chude";
            this.chude.ReadOnly = true;
            // 
            // CauHoi
            // 
            this.CauHoi.DataPropertyName = "cau";
            this.CauHoi.HeaderText = "Câu Hỏi";
            this.CauHoi.MinimumWidth = 6;
            this.CauHoi.Name = "CauHoi";
            this.CauHoi.ReadOnly = true;
            // 
            // NoiDung
            // 
            this.NoiDung.DataPropertyName = "noidung";
            this.NoiDung.HeaderText = "Nội Dung";
            this.NoiDung.MinimumWidth = 6;
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.ReadOnly = true;
            // 
            // A
            // 
            this.A.DataPropertyName = "dapanA";
            this.A.HeaderText = "A";
            this.A.MinimumWidth = 6;
            this.A.Name = "A";
            this.A.ReadOnly = true;
            // 
            // B
            // 
            this.B.DataPropertyName = "dapanB";
            this.B.HeaderText = "B";
            this.B.MinimumWidth = 6;
            this.B.Name = "B";
            this.B.ReadOnly = true;
            // 
            // C
            // 
            this.C.DataPropertyName = "dapanC";
            this.C.HeaderText = "C";
            this.C.MinimumWidth = 6;
            this.C.Name = "C";
            this.C.ReadOnly = true;
            // 
            // D
            // 
            this.D.DataPropertyName = "dapanD";
            this.D.HeaderText = "D";
            this.D.MinimumWidth = 6;
            this.D.Name = "D";
            this.D.ReadOnly = true;
            // 
            // DapAN
            // 
            this.DapAN.DataPropertyName = "DapAn";
            this.DapAN.HeaderText = "Đáp Án";
            this.DapAN.MinimumWidth = 6;
            this.DapAN.Name = "DapAN";
            this.DapAN.ReadOnly = true;
            // 
            // btn_them
            // 
            this.btn_them.BackgroundImage = global::TRACNGHIEMBYWINFORM.Properties.Resources.Raindropmemory_Red_Little_Shoes_Help_Info_2;
            this.btn_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_them.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(12, 35);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(150, 70);
            this.btn_them.TabIndex = 4;
            this.btn_them.Text = "        Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackgroundImage = global::TRACNGHIEMBYWINFORM.Properties.Resources.Awicons_Vista_Artistic_Delete;
            this.btn_xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.Location = new System.Drawing.Point(188, 35);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(150, 70);
            this.btn_xoa.TabIndex = 5;
            this.btn_xoa.Text = "       Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_Sửa
            // 
            this.btn_Sửa.BackgroundImage = global::TRACNGHIEMBYWINFORM.Properties.Resources.Custom_Icon_Design_Flatastic_9_Tests;
            this.btn_Sửa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Sửa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sửa.Location = new System.Drawing.Point(463, 35);
            this.btn_Sửa.Name = "btn_Sửa";
            this.btn_Sửa.Size = new System.Drawing.Size(150, 70);
            this.btn_Sửa.TabIndex = 6;
            this.btn_Sửa.Text = "         Sửa";
            this.btn_Sửa.UseVisualStyleBackColor = true;
            this.btn_Sửa.Click += new System.EventHandler(this.btn_Sửa_Click);
            // 
            // txt_made
            // 
            this.txt_made.Location = new System.Drawing.Point(344, 58);
            this.txt_made.Name = "txt_made";
            this.txt_made.Size = new System.Drawing.Size(100, 22);
            this.txt_made.TabIndex = 8;
            this.txt_made.Visible = false;
            this.txt_made.TextChanged += new System.EventHandler(this.txt_made_TextChanged);
            // 
            // txtcau
            // 
            this.txtcau.Location = new System.Drawing.Point(344, 86);
            this.txtcau.Name = "txtcau";
            this.txtcau.Size = new System.Drawing.Size(100, 22);
            this.txtcau.TabIndex = 9;
            this.txtcau.Visible = false;
            this.txtcau.TextChanged += new System.EventHandler(this.txtcau_TextChanged);
            // 
            // FormCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 515);
            this.Controls.Add(this.txtcau);
            this.Controls.Add(this.txt_made);
            this.Controls.Add(this.btn_Sửa);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_capnhap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCauHoi";
            this.Text = "formCauHoi";
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangcauhoiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_capnhap;
        private quizDataSet quizDataSet;
        private System.Windows.Forms.BindingSource bangcauhoiBindingSource;
        private quizDataSetTableAdapters.bangcauhoiTableAdapter bangcauhoiTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_Sửa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDeThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn chude;
        private System.Windows.Forms.DataGridViewTextBoxColumn CauHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn A;
        private System.Windows.Forms.DataGridViewTextBoxColumn B;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.DataGridViewTextBoxColumn D;
        private System.Windows.Forms.DataGridViewTextBoxColumn DapAN;
        private System.Windows.Forms.TextBox txt_made;
        private System.Windows.Forms.TextBox txtcau;
    }
}