using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhongKham
{
    public partial class DangNhapForm : Form
    {
        public DangNhapForm()
        {
            InitializeComponent();
        }

        private void linkLabel_QuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhauForm quenMatKhau = new QuenMatKhauForm();
            quenMatKhau.ShowDialog();
        }

        private void linkLabel_DangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            
        {
            DangKyForm dangKy = new DangKyForm();
            dangKy.ShowDialog();
        }
        Modify modify = new Modify();

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string tenTaiKhoan = txt_TenTaiKhoan.Text;
            string matKhau = txt_MatKhau.Text;
            if (tenTaiKhoan.Trim() == "") { MessageBox.Show("Vui lòng nhập Tên Tài Khoản!"); }
             else if (matKhau.Trim() == "") { MessageBox.Show("Vui lòng nhập Mật Khẩu!"); }
             else
            {
                string query = "Select * from tblTaiKhoan where TenTaiKhoan = '" + tenTaiKhoan + "' and MatKhau = '" + matKhau + "'";
                if(modify.TaiKhoans(query).Count>0)
                {
                    MessageBox.Show("Đăng Nhập thành công!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    HomeForm homeform = new HomeForm();
                    homeform.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên Tài Khoản hoặc Mật Khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void DangNhapForm_Load(object sender, EventArgs e)
        {

        }
    }
}
