namespace TRACNGHIEMBYWINFORM
{
    partial class Themtheofile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Themtheofile));
            this.btn_excel = new System.Windows.Forms.Button();
            this.btn_SQL = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_excel
            // 
            this.btn_excel.BackgroundImage = global::TRACNGHIEMBYWINFORM.Properties.Resources.Custom_Icon_Design_Pretty_Office_2_Briefcase;
            this.btn_excel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_excel.Location = new System.Drawing.Point(118, 12);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(208, 48);
            this.btn_excel.TabIndex = 5;
            this.btn_excel.Text = "        Thêm từ file excel";
            this.btn_excel.UseVisualStyleBackColor = true;
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // btn_SQL
            // 
            this.btn_SQL.BackgroundImage = global::TRACNGHIEMBYWINFORM.Properties.Resources.Rokey_Fantastic_Dream_Connect;
            this.btn_SQL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_SQL.Location = new System.Drawing.Point(661, 12);
            this.btn_SQL.Name = "btn_SQL";
            this.btn_SQL.Size = new System.Drawing.Size(167, 48);
            this.btn_SQL.TabIndex = 6;
            this.btn_SQL.Text = "         Thêm vào SQL";
            this.btn_SQL.UseVisualStyleBackColor = true;
            this.btn_SQL.Click += new System.EventHandler(this.btn_SQL_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1024, 499);
            this.dataGridView1.TabIndex = 7;
            // 
            // Themtheofile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 577);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_SQL);
            this.Controls.Add(this.btn_excel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Themtheofile";
            this.Text = "Thêmtheofile";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_excel;
        private System.Windows.Forms.Button btn_SQL;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}