using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAN.NET_
{
    class TaiKhoan
    {
        private string TenTaiKhoan;
        private string MatKhau;

        public TaiKhoan()
        {

        }

        public TaiKhoan(string tenTaiKhoan, string matKhau)
        {
            this.TenTaiKhoan = tenTaiKhoan;
            this.MatKhau = matKhau;
        }

        //public string TenTaiKhoan1 { get => TenTaiKhoan; set => TenTaiKhoan = value; }
        //public string MatKhau1 { get => MatKhau; set => MatKhau = value; }
    }
}
