using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QLPhongKham
{
    public partial class DangKyForm : Form
    {
        public DangKyForm()
        {
            InitializeComponent();
        }
        public bool checkAccount(string ac) //check ten tai khoan và mat khau
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9_]{5,24}$");
        }

        public bool checkEmail(string em) //check ten tai khoan và mat khau
        {
            return Regex.IsMatch(em, "^[a-zA-Z0-9_]{3,20}@gmail.com(.vn|)$");
        }

        Modify modify = new Modify();

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            string id = txt_Id.Text;
            string tenTaiKhoan = txt_TenTaiKhoan.Text;
            string matKhau = txt_MatKhau.Text;
            string xnMatKhau = txt_XNMatKhau.Text;
            string quyen = combotxtQuyen.Text;
            string eMail = txt_Email.Text;
            if (!checkAccount(tenTaiKhoan)) { MessageBox.Show("Vui lòng nhập tên tài khoản dài 6-24 kí tự, với các kí tự chữ và số, chữ hoa và chữ thường!"); return; }
            if (!checkAccount(matKhau)) { MessageBox.Show("Vui lòng nhập mật khẩu dài 6-24 kí tự, với các kí tự chữ và số, chữ hoa và chữ thường!"); return; }
            if (xnMatKhau != matKhau) { MessageBox.Show("Mật khẩu và Xác nhận Mật khẩu không hợp lệ!"); return; }
            if (!checkEmail(eMail)) { MessageBox.Show("Vui lòng nhập Email bao gồm chữ và số theo định dạng ...@gmail.com!"); return; }
            if (modify.TaiKhoans("Select * from tblTaiKhoan where Email = '" + eMail + "'").Count != 0) { MessageBox.Show("Email này đã được đăng ký, vui lòng nhập Email khác!"); return; }
            try
            {
                string query = "Insert into tblTaiKhoan values ('" +id+"','" + tenTaiKhoan + "','" + matKhau + "','" + quyen + "','" + eMail + "')";
                modify.Command(query);
                if (MessageBox.Show("Đăng ký thành công! Bạn có muốn đăng nhập không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Đăng ký không thành công!");


            }
        }
    }
}
