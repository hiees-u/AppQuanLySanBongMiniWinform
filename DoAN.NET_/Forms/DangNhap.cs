using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAN.NET_.Forms
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Modify modify = new Modify();

            string tentk = txt_tk.Text;
            string mk = txt_mk.Text;

            if (tentk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản");
                return;
            }
            else if (mk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                return;
            }
            else
            {
                string query = "Select * from TaiKhoan where TenDangNhap = '" + txt_tk.Text + "' and MatKhau = '" + txt_mk.Text + "'";
                if (modify.TaiKhoans(query).Count() != 0)
                {
                    MessageBox.Show("Đăng nhập thành công"); 
                    frmMainMenu mainMenu = new frmMainMenu();
                    mainMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại ");
                }

            }
           

        }


        private void btnDangKi_Click_1(object sender, EventArgs e)
        {
             DangKy dk = new DangKy();
             dk.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
            if (txt_mk.PasswordChar == '\0')
            {
                pictureBox5.BringToFront();
                txt_mk.PasswordChar = '*';
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (txt_mk.PasswordChar == '*')
            {
                pictureBox4.BringToFront();
                txt_mk.PasswordChar = '\0';
            }

        }
    }
    
}
