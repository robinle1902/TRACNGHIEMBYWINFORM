namespace TRACNGHIEMBYWINFORM
{
    partial class FormDeThi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDeThi));
            this.btn_tim = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_tim
            // 
            this.btn_tim.BackgroundImage = global::TRACNGHIEMBYWINFORM.Properties.Resources.Custom_Icon_Design_Pretty_Office_2_Search;
            this.btn_tim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_tim.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tim.Location = new System.Drawing.Point(51, 49);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(150, 70);
            this.btn_tim.TabIndex = 0;
            this.btn_tim.Text = "    Tìm đề thi";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // btn_export
            // 
            this.btn_export.BackgroundImage = global::TRACNGHIEMBYWINFORM.Properties.Resources.Graphicloads_Filetype_Word_doc;
            this.btn_export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_export.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export.Location = new System.Drawing.Point(389, 460);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(183, 57);
            this.btn_export.TabIndex = 2;
            this.btn_export.Text = "    Xuất file";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(235, 89);
            this.txt_timkiem.Multiline = true;
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(90, 30);
            this.txt_timkiem.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 300);
            this.dataGridView1.TabIndex = 5;
            // 
            // MaDeThi
            // 
            this.MaDeThi.DataPropertyName = "madt";
            this.MaDeThi.HeaderText = "Code Ex";
            this.MaDeThi.MinimumWidth = 6;
            this.MaDeThi.Name = "MaDeThi";
            this.MaDeThi.ReadOnly = true;
            // 
            // chude
            // 
            this.chude.DataPropertyName = "chude";
            this.chude.HeaderText = "Content";
            this.chude.MinimumWidth = 6;
            this.chude.Name = "chude";
            this.chude.ReadOnly = true;
            // 
            // CauHoi
            // 
            this.CauHoi.DataPropertyName = "cau";
            this.CauHoi.HeaderText = "Question";
            this.CauHoi.MinimumWidth = 6;
            this.CauHoi.Name = "CauHoi";
            this.CauHoi.ReadOnly = true;
            // 
            // NoiDung
            // 
            this.NoiDung.DataPropertyName = "noidung";
            this.NoiDung.HeaderText = "Content";
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
            this.DapAN.HeaderText = "Answer";
            this.DapAN.MinimumWidth = 6;
            this.DapAN.Name = "DapAN";
            this.DapAN.ReadOnly = true;
            // 
            // FormDeThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 566);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.btn_tim);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDeThi";
            this.Text = "FormDeThi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDeThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn chude;
        private System.Windows.Forms.DataGridViewTextBoxColumn CauHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn A;
        private System.Windows.Forms.DataGridViewTextBoxColumn B;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.DataGridViewTextBoxColumn D;
        private System.Windows.Forms.DataGridViewTextBoxColumn DapAN;
    }
}