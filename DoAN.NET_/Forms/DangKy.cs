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

namespace DoAN.NET_.Forms
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }
        
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            Modify modify = new Modify();
            DangNhap dn = new DangNhap();
            DangKy dk = new DangKy();

            string tk = txt_tk.Text;
            string mk = txt_mk.Text;
            string displayname = txtdisplayname.Text;
            string xnmk = txtXacNhanMK.Text;

            if (!checkAccount(tk))
            {
                MessageBox.Show("Vui lòng nhập tài khoản 6 - 24 kí tự, bao gồm chữ ,số, chữ hoa, chữ thường ");
                return;
            }
            if (!checkAccount(mk))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu 6 - 24 kí tự, bao gồm chữ ,số, chữ hoa, chữ thường ");
                return;
            }
            if (xnmk != mk)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu chính xác"); return;
            }
            try
            {
                string query = "Insert into TaiKhoan values ('" + tk + "','" + mk + "','" + displayname + "')";
                modify.SqlCommand(query);
                if (MessageBox.Show("Đăng kí Thành công! Bạn có muốn đăng nhập luôn không?   ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    dn.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tên tài khoản đã được đăng ký, vui lòng nhập tên tài khoản khác!");
            }
        }
        public bool checkAccount(string acc)
        {
            return Regex.IsMatch(acc, "^[a-zA-Z0-9]{6,24}$");
        }
        
        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (txt_mk.PasswordChar == '*')
            {
                pictureBox5.BringToFront();
                txt_mk.PasswordChar = '\0';
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (txtXacNhanMK.PasswordChar == '*')
            {
                pictureBox7.BringToFront();
                txtXacNhanMK.PasswordChar = '\0';
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (txt_mk.PasswordChar == '\0')
            {
                pictureBox6.BringToFront();
                txt_mk.PasswordChar = '*';
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (txtXacNhanMK.PasswordChar == '\0')
            {
                pictureBox8.BringToFront();
                txtXacNhanMK.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DangNhap dn = new DangNhap();
            if (MessageBox.Show("Quay lại trang đăng nhập ?   ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {   
                dn.ShowDialog();
                this.Hide();
            }
            
        }
    }
}
