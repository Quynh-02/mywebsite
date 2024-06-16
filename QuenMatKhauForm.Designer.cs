namespace QLPhongKham
{
    partial class QuenMatKhauForm
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
            this.btn_LayLaiMatKhau = new System.Windows.Forms.Button();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_Ketqua = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_LayLaiMatKhau
            // 
            this.btn_LayLaiMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_LayLaiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LayLaiMatKhau.Location = new System.Drawing.Point(193, 348);
            this.btn_LayLaiMatKhau.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_LayLaiMatKhau.Name = "btn_LayLaiMatKhau";
            this.btn_LayLaiMatKhau.Size = new System.Drawing.Size(206, 48);
            this.btn_LayLaiMatKhau.TabIndex = 20;
            this.btn_LayLaiMatKhau.Text = "Lấy Lại Mật Khẩu";
            this.btn_LayLaiMatKhau.UseVisualStyleBackColor = false;
            this.btn_LayLaiMatKhau.Click += new System.EventHandler(this.btn_LayLaiMatKhau_Click);
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(130, 258);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(325, 22);
            this.txt_Email.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Quên Mật Khẩu";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Email.ForeColor = System.Drawing.Color.Navy;
            this.label_Email.Location = new System.Drawing.Point(27, 258);
            this.label_Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(95, 17);
            this.label_Email.TabIndex = 12;
            this.label_Email.Text = "Nhập Email:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLPhongKham.Properties.Resources.background;
            this.pictureBox1.Location = new System.Drawing.Point(112, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label_Ketqua
            // 
            this.label_Ketqua.AutoSize = true;
            this.label_Ketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Ketqua.ForeColor = System.Drawing.Color.Navy;
            this.label_Ketqua.Location = new System.Drawing.Point(27, 313);
            this.label_Ketqua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Ketqua.Name = "label_Ketqua";
            this.label_Ketqua.Size = new System.Drawing.Size(69, 17);
            this.label_Ketqua.TabIndex = 21;
            this.label_Ketqua.Text = "Kết quả:";
            // 
            // QuenMatKhauForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 423);
            this.Controls.Add(this.label_Ketqua);
            this.Controls.Add(this.btn_LayLaiMatKhau);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.pictureBox1);
            this.Name = "QuenMatKhauForm";
            this.Text = "QuenMatKhau";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_LayLaiMatKhau;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Ketqua;
    }
}