using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongKham
{
    
     class TaiKhoan
    {
       
        private string TenTaiKhoan;
        private string MatKhau;
        private string Email;
        
        public TaiKhoan()
        {

        }
        public TaiKhoan(string TenTaiKhoan, string MatKhau, string Email)
        {
            
            this.TenTaiKhoan = TenTaiKhoan;
            this.MatKhau = MatKhau;
            this.Email = Email;
        }
        

        
        public string tenTaiKhoan { get => TenTaiKhoan; set => TenTaiKhoan = value; }
        public string matKhau { get => MatKhau; set => MatKhau= value; }
        public string email { get => Email; set => MatKhau = value; }
        

    }
}
