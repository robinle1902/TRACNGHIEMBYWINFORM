namespace TRACNGHIEMBYWINFORM
{
    partial class FormThemCauHoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThemCauHoi));
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rtxtNoiDung = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radD = new System.Windows.Forms.RadioButton();
            this.radC = new System.Windows.Forms.RadioButton();
            this.radB = new System.Windows.Forms.RadioButton();
            this.radA = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btn_themtheofile = new System.Windows.Forms.Button();
            this.quizDataSet = new TRACNGHIEMBYWINFORM.quizDataSet();
            this.bangcauhoiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bangcauhoiTableAdapter = new TRACNGHIEMBYWINFORM.quizDataSetTableAdapters.bangcauhoiTableAdapter();
            this.quizDataSet1 = new TRACNGHIEMBYWINFORM.quizDataSet1();
            this.tablecauhoi2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_cauhoi2TableAdapter = new TRACNGHIEMBYWINFORM.quizDataSet1TableAdapters.table_cauhoi2TableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.txtchude = new System.Windows.Forms.TextBox();
            this.txtmade = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangcauhoiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablecauhoi2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(24, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nội dung";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(13, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Chủ đề";
            // 
            // rtxtNoiDung
            // 
            this.rtxtNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rtxtNoiDung.Location = new System.Drawing.Point(27, 98);
            this.rtxtNoiDung.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtNoiDung.Name = "rtxtNoiDung";
            this.rtxtNoiDung.Size = new System.Drawing.Size(500, 105);
            this.rtxtNoiDung.TabIndex = 15;
            this.rtxtNoiDung.Text = "";
            this.rtxtNoiDung.TextChanged += new System.EventHandler(this.rtxtNoiDung_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(30, 207);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Câu Hỏi";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGhiChu.Location = new System.Drawing.Point(28, 231);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(93, 30);
            this.txtGhiChu.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radD);
            this.groupBox1.Controls.Add(this.radC);
            this.groupBox1.Controls.Add(this.radB);
            this.groupBox1.Controls.Add(this.radA);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtD);
            this.groupBox1.Controls.Add(this.txtC);
            this.groupBox1.Controls.Add(this.txtB);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(152, 231);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(501, 209);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đáp án";
            // 
            // radD
            // 
            this.radD.AutoSize = true;
            this.radD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radD.Location = new System.Drawing.Point(460, 153);
            this.radD.Margin = new System.Windows.Forms.Padding(4);
            this.radD.Name = "radD";
            this.radD.Size = new System.Drawing.Size(17, 16);
            this.radD.TabIndex = 15;
            this.radD.TabStop = true;
            this.radD.UseVisualStyleBackColor = true;
            this.radD.CheckedChanged += new System.EventHandler(this.radD_CheckedChanged_1);
            // 
            // radC
            // 
            this.radC.AutoSize = true;
            this.radC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radC.Location = new System.Drawing.Point(460, 113);
            this.radC.Margin = new System.Windows.Forms.Padding(4);
            this.radC.Name = "radC";
            this.radC.Size = new System.Drawing.Size(17, 16);
            this.radC.TabIndex = 14;
            this.radC.TabStop = true;
            this.radC.UseVisualStyleBackColor = true;
            this.radC.CheckedChanged += new System.EventHandler(this.radC_CheckedChanged_1);
            // 
            // radB
            // 
            this.radB.AutoSize = true;
            this.radB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radB.Location = new System.Drawing.Point(460, 74);
            this.radB.Margin = new System.Windows.Forms.Padding(4);
            this.radB.Name = "radB";
            this.radB.Size = new System.Drawing.Size(17, 16);
            this.radB.TabIndex = 13;
            this.radB.TabStop = true;
            this.radB.UseVisualStyleBackColor = true;
            this.radB.CheckedChanged += new System.EventHandler(this.radB_CheckedChanged_1);
            // 
            // radA
            // 
            this.radA.AutoSize = true;
            this.radA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radA.Location = new System.Drawing.Point(460, 33);
            this.radA.Margin = new System.Windows.Forms.Padding(4);
            this.radA.Name = "radA";
            this.radA.Size = new System.Drawing.Size(17, 16);
            this.radA.TabIndex = 12;
            this.radA.TabStop = true;
            this.radA.UseVisualStyleBackColor = true;
            this.radA.CheckedChanged += new System.EventHandler(this.radA_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(8, 151);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "D";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(8, 112);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(8, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "B";
            // 
            // txtD
            // 
            this.txtD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtD.Location = new System.Drawing.Point(40, 144);
            this.txtD.Margin = new System.Windows.Forms.Padding(4);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(411, 30);
            this.txtD.TabIndex = 8;
            // 
            // txtC
            // 
            this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtC.Location = new System.Drawing.Point(40, 105);
            this.txtC.Margin = new System.Windows.Forms.Padding(4);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(411, 30);
            this.txtC.TabIndex = 7;
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtB.Location = new System.Drawing.Point(40, 65);
            this.txtB.Margin = new System.Windows.Forms.Padding(4);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(411, 30);
            this.txtB.TabIndex = 6;
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtA.Location = new System.Drawing.Point(40, 26);
            this.txtA.Margin = new System.Windows.Forms.Padding(4);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(411, 30);
            this.txtA.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(8, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "A";
            // 
            // btnLuu
            // 
            this.btnLuu.BackgroundImage = global::TRACNGHIEMBYWINFORM.Properties.Resources.Custom_Icon_Design_Flatastic_9_Save;
            this.btnLuu.Location = new System.Drawing.Point(239, 458);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(53, 49);
            this.btnLuu.TabIndex = 19;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackgroundImage = global::TRACNGHIEMBYWINFORM.Properties.Resources.Awicons_Vista_Artistic_Delete;
            this.btnHuy.Location = new System.Drawing.Point(438, 458);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(53, 49);
            this.btnHuy.TabIndex = 20;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btn_themtheofile
            // 
            this.btn_themtheofile.BackgroundImage = global::TRACNGHIEMBYWINFORM.Properties.Resources.Custom_Icon_Design_Flatastic_9_Stats;
            this.btn_themtheofile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_themtheofile.Location = new System.Drawing.Point(590, 28);
            this.btn_themtheofile.Name = "btn_themtheofile";
            this.btn_themtheofile.Size = new System.Drawing.Size(160, 59);
            this.btn_themtheofile.TabIndex = 21;
            this.btn_themtheofile.Text = "           Thêm theo file";
            this.btn_themtheofile.UseVisualStyleBackColor = true;
            this.btn_themtheofile.Click += new System.EventHandler(this.btn_themtheofile_Click);
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
            // quizDataSet1
            // 
            this.quizDataSet1.DataSetName = "quizDataSet1";
            this.quizDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tablecauhoi2BindingSource
            // 
            this.tablecauhoi2BindingSource.DataMember = "table_cauhoi2";
            this.tablecauhoi2BindingSource.DataSource = this.quizDataSet1;
            // 
            // table_cauhoi2TableAdapter
            // 
            this.table_cauhoi2TableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(296, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Mã Đề";
            // 
            // txtchude
            // 
            this.txtchude.Location = new System.Drawing.Point(115, 26);
            this.txtchude.Name = "txtchude";
            this.txtchude.Size = new System.Drawing.Size(100, 22);
            this.txtchude.TabIndex = 24;
            // 
            // txtmade
            // 
            this.txtmade.Location = new System.Drawing.Point(405, 28);
            this.txtmade.Name = "txtmade";
            this.txtmade.Size = new System.Drawing.Size(100, 22);
            this.txtmade.TabIndex = 25;
            // 
            // FormThemCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 587);
            this.Controls.Add(this.txtmade);
            this.Controls.Add(this.txtchude);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_themtheofile);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtxtNoiDung);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormThemCauHoi";
            this.Text = "FormThemCauHoi";
            this.Load += new System.EventHandler(this.FormThemCauHoi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangcauhoiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablecauhoi2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtxtNoiDung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radD;
        private System.Windows.Forms.RadioButton radC;
        private System.Windows.Forms.RadioButton radB;
        private System.Windows.Forms.RadioButton radA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btn_themtheofile;
        private quizDataSet quizDataSet;
        private System.Windows.Forms.BindingSource bangcauhoiBindingSource;
        private quizDataSetTableAdapters.bangcauhoiTableAdapter bangcauhoiTableAdapter;
        private quizDataSet1 quizDataSet1;
        private System.Windows.Forms.BindingSource tablecauhoi2BindingSource;
        private quizDataSet1TableAdapters.table_cauhoi2TableAdapter table_cauhoi2TableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtchude;
        private System.Windows.Forms.TextBox txtmade;
    }
}