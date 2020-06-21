namespace TRACNGHIEMBYWINFORM
{
    partial class form_DangKy
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_pw = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_xacnhanpw = new System.Windows.Forms.TextBox();
            this.btn_dangky_dangky = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đăng Nhập :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu :";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(341, 70);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(100, 22);
            this.txt_username.TabIndex = 2;
            // 
            // txt_pw
            // 
            this.txt_pw.Location = new System.Drawing.Point(341, 120);
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.Size = new System.Drawing.Size(100, 22);
            this.txt_pw.TabIndex = 3;
            this.txt_pw.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Xác nhận mật khẩu :";
            // 
            // txt_xacnhanpw
            // 
            this.txt_xacnhanpw.Location = new System.Drawing.Point(341, 167);
            this.txt_xacnhanpw.Name = "txt_xacnhanpw";
            this.txt_xacnhanpw.Size = new System.Drawing.Size(100, 22);
            this.txt_xacnhanpw.TabIndex = 5;
            this.txt_xacnhanpw.UseSystemPasswordChar = true;
            this.txt_xacnhanpw.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btn_dangky_dangky
            // 
            this.btn_dangky_dangky.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangky_dangky.Location = new System.Drawing.Point(185, 265);
            this.btn_dangky_dangky.Name = "btn_dangky_dangky";
            this.btn_dangky_dangky.Size = new System.Drawing.Size(150, 47);
            this.btn_dangky_dangky.TabIndex = 6;
            this.btn_dangky_dangky.Text = "Xác Nhận";
            this.btn_dangky_dangky.UseVisualStyleBackColor = true;
            this.btn_dangky_dangky.Click += new System.EventHandler(this.btn_dangky_dangky_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(419, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 47);
            this.button1.TabIndex = 7;
            this.button1.Text = "Quay Lại\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // form_DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_dangky_dangky);
            this.Controls.Add(this.txt_xacnhanpw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_pw);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "form_DangKy";
            this.Text = "form_DangKy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_pw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_xacnhanpw;
        private System.Windows.Forms.Button btn_dangky_dangky;
        private System.Windows.Forms.Button button1;
    }
}