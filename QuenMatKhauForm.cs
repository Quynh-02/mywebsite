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
    public partial class QuenMatKhauForm : Form
    {
        public QuenMatKhauForm()
        {
            InitializeComponent();
            label_Ketqua.Text = "";
        }
        Modify modify = new Modify();

        private void btn_LayLaiMatKhau_Click(object sender, EventArgs e)
        {
            string email = txt_Email.Text;
            if (email.Trim() =="") { MessageBox.Show("Vui lòng nhập Email đăng ký!"); }
            else
            {
                string query = "Select * from tblTaiKhoan where Email = '" + email + "'";
                if(modify.TaiKhoans(query).Count!=0)
                {
                    label_Ketqua.ForeColor = Color.Blue;
                    label_Ketqua.Text = "Mật Khẩu của bạn là: " + modify.TaiKhoans(query)[0].matKhau;

                }
                else
                {
                    label_Ketqua.ForeColor = Color.Red;
                    label_Ketqua.Text = "Email này chưa được đăng ký!";

                }
            }
        }
    }
}
