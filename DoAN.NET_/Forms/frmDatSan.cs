using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DoAN.NET_.Forms
{
    public partial class frmDatSan : Form
    {
        public frmDatSan()
        {
            InitializeComponent();


            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;

            txtGioThue.Enabled = false;
            txtDonGia.Enabled = false;
            txtTT.Enabled = false;

            txtTimKiemSan.Text = PlaceholderText;
            txtTimKiemSan.ForeColor = System.Drawing.SystemColors.GrayText;

            // Gắn sự kiện
            txtTimKiemSan.GotFocus += TextBoxSearch_GotFocus;
            txtTimKiemSan.LostFocus += TextBoxSearch_LostFocus;
        }
        Modify modify = new Modify();
        SqlConnection conn = new SqlConnection(@"Data Source=YN\SQLEXPRESS;Initial Catalog=QL_SanBanh1;Integrated Security=True");
        //private void load_dgvDSS()
        //{
        //    DataTable dt = Red("Select IdLoaiSan,IdUser,ThoiGianBatDau,ThoiGianKetThuc,Gia from DatSan,LoaiSanBanh,KhachHang");
        //    if (dt != null)
        //    {
        //        dgvDSSan.DataSource = dt;
        //    }
        //}
        private void load_cbo_DatSan()
        {
            DataSet ds = new DataSet();
            string query = "Select TenLoai,IdLoaiSan from LoaiSanBanh ";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(ds, "LoaiSanBanh");
            cbo_MaSan.DataSource = ds.Tables[0];
            cbo_MaSan.DisplayMember = "TenLoai";
            cbo_MaSan.ValueMember = "IdLoaiSan";

            //using (SqlConnection connection = Connection.GetSqlConnection())
            //{
            //    connection.Open();

            //    string query = "SELECT IdLoaiSan, TenLoai, Gia FROM LoaiSanBanh";
            //    using (SqlCommand command = new SqlCommand(query, connection))
            //    {
            //        using (SqlDataReader reader = command.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                // Add các items vào ComboBox với Text là TenLoai và Value là IdLoaiSan
            //                cbo_MaSan.Items.Add(new { Text = reader["TenLoai"].ToString(), Value = reader["IdLoaiSan"].ToString(), Gia = reader["Gia"].ToString() });
            //            }
            //        }
            //    }
            //}

        }
        private void load_cbo_MaKH()
        {
            DataSet ds = new DataSet();
            string query = "Select IdKhachHang,TenKhachHang from KhachHang ";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(ds, "KhachHang");
            cbo_MaKH.DataSource = ds.Tables[0];
            cbo_MaKH.DisplayMember = "TenKhachHang";
            cbo_MaKH.ValueMember = "IdKhachHang";

        }
        private void load_cbo_MaSB()
        {
            DataSet ds = new DataSet();
            string query = "Select TenSanBanh,IdSanBanh from SanBanh ";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(ds, "SanBanh");
            cboMaSB.DataSource = ds.Tables[0];
            cboMaSB.DisplayMember = "TenSanBanh";
            cboMaSB.ValueMember = "IdSanBanh";

        }
        private void tpDatSan_Click(object sender, EventArgs e)
        {

        }

        private void cbo_MaSan_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();

                string query = "SELECT * FROM LoaiSanBanh where IdLoaiSan = '" + cbo_MaSan.SelectedValue.ToString() + "' ";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            txtDonGia.Text = reader.GetString(2).ToString();
                        }
                    }
                }
            }

            //if (cbo_MaSan.SelectedItem != null)
            //{
            //    // Lấy dữ liệu từ item được chọn
            //    var selectedLoaiSan = (dynamic)cbo_MaSan.SelectedItem;

            //    // Hiển thị dữ liệu trong TextBox
            //    txtDonGia.Text = selectedLoaiSan.Gia;
            //}
        }

        private void dgvDS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmDatSan_Load(object sender, EventArgs e)
        {
            try
            {

                load_cbo_DatSan();
                load_cbo_MaKH();
                load_cbo_MaSB();
                dgvDSSan.DataSource = modify.Table("SELECT * from DatSan");
                dgvDSKH.DataSource = modify.Table("Select * from KhachHang");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: \n" + ex.Message);
            }
            //load_cbo_DatSan();


        }
        DataSet GetDanhSachSan()
        {
            DataSet ds = new DataSet();
            //SqlConnection
            string query = "Select * from SanBanh";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, connection);

                da.Fill(ds);
                connection.Close();
            }
            //SqlCommand
            //SqlDataAdapter
            return ds;
        }



        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {

            try
            {
                Modify modify = new Modify();
                string query = "INSERT INTO KhachHang Values ('" + txtMaKH.Text + "',N'" + txtHoTen.Text + "',N'" + txtDiaChi.Text + "','" + txtSDT.Text + "')";
                modify.SqlCommand(query);
                MessageBox.Show("Thêm Thành Công !");
                frmDatSan_Load(sender, e);
                txtMaKH.Text = txtHoTen.Text = txtSDT.Text = txtDiaChi.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Thêm: " + ex.Message);
            }
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            string query = "UPDATE KhachHang SET TenKhachHang = N'" + txtHoTen.Text + "',DiaChi = N'" + txtDiaChi.Text + "',SDT = '" + txtSDT.Text + "' WHERE IdKhachHang ='" + txtMaKH.Text + "' ";
            try
            {
                if (MessageBox.Show("Bạn có muốn sửa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    modify.SqlCommand(query);
                    MessageBox.Show("Sửa thành công !");
                    frmDatSan_Load(sender, e);
                    txtMaKH.Text = txtHoTen.Text = txtSDT.Text = txtDiaChi.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Sửa: " + ex.Message);
            }
        }

        private void dgvDSKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDSKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDSKH.Rows.Count > 1)
            {
                txtMaKH.Text = dgvDSKH.SelectedRows[0].Cells[0].Value.ToString();
                txtHoTen.Text = dgvDSKH.SelectedRows[0].Cells[1].Value.ToString();
                txtDiaChi.Text = dgvDSKH.SelectedRows[0].Cells[2].Value.ToString();
                txtSDT.Text = dgvDSKH.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            if (dgvDSKH.Rows.Count > 1)
            {
                string chon = dgvDSKH.SelectedRows[0].Cells[0].Value.ToString();
                string query = "DELETE KhachHang WHERE IdKhachHang = '" + chon + "'";

                try
                {
                    if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.SqlCommand(query);
                        MessageBox.Show("Xóa thành công !");
                        frmDatSan_Load(sender, e);
                        txtMaKH.Text = txtHoTen.Text = txtSDT.Text = txtDiaChi.Text = "";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Xóa: " + ex.Message);
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

            string name = txtTimKiem.Text.Trim();
            if (name == "")
            {
                frmDatSan_Load(sender, e);

            }
            else
            {
                //string query = "Select * from KhachHang Where IdKhachHang= '" + name + "'";
                string query = "Select * from KhachHang Where IdKhachHang like '%" + name + "%'";
                dgvDSKH.DataSource = modify.Table(query);
            }
        }
        private void btnDatSan_Click(object sender, EventArgs e)
        {
            try
            {
                Modify modify = new Modify();
                DateTime date1 = DateTime.Parse(dateTimePicker1.Value.ToString());
                DateTime date2 = DateTime.Parse(dateTimePicker2.Value.ToString());


                string query = "INSERT INTO DatSan VALUES (N'" + txtMaDatSan.Text + "',N'" + cbo_MaKH.SelectedValue.ToString() + "',N'" + cboMaSB.SelectedValue.ToString() + "','" + date1.ToString("yyyy-MM-dd HH:mm:ss")
                        + "','" + date2.ToString("yyyy-MM-dd HH:mm:ss") + "',N'" + cbo_MaSan.SelectedValue.ToString() + "'," + float.Parse(txtGioThue.Text) + "," + txtTT.Text + "); ";
                MessageBox.Show("Đặt sân với số giờ :" +txtGioThue.Text+"Giờ");
                modify.SqlCommand(query);
                frmDatSan_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Thêm: " + ex.Message);
            }


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            UpdateHours();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            UpdateHours();
        }
        private void UpdateHours()
        {
            // Lấy giá trị từ DateTimePicker của ngày bắt đầu và kết thúc
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;

            // Tính số giờ giữa hai ngày
            TimeSpan duration = endDate - startDate;

            // Hiển thị số giờ trong ô text box
            txtGioThue.Text = duration.TotalHours.ToString("N1");
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

        }

        private void txtTimKiemSan_TextChanged(object sender, EventArgs e)
        {
            string name = txtTimKiemSan.Text.Trim();
            if (name == "")
            {
                frmDatSan_Load(sender, e);

            }
            else
            {
                //string query = "Select * from KhachHang Where IdKhachHang= '" + name + "'";
                string query = "Select IdLoaiSan,IdKhachHang from DatSan Where IdLoaiSan like '%" + name + "%' or IdKhachHang like '%" + name + "%'";
                dgvDSSan.DataSource = modify.Table(query);
            }
        }

        private const string PlaceholderText = "Nhập loại sân banh hoặc khách hàng để tìm kiếm ...";

        private void TextBoxSearch_GotFocus(object sender, EventArgs e)
        {
            // Khi ô TextBox được focus, kiểm tra nếu nó vẫn chứa placeholder
            if (txtTimKiemSan.Text == PlaceholderText)
            {
                txtTimKiemSan.Text = string.Empty;
                txtTimKiemSan.ForeColor = System.Drawing.SystemColors.WindowText; // Đổi màu văn bản khi người dùng bắt đầu nhập
            }
        }

        private void TextBoxSearch_LostFocus(object sender, EventArgs e)
        {
            // Khi ô TextBox mất focus, kiểm tra nếu nó rỗng thì hiển thị lại placeholder
            if (string.IsNullOrWhiteSpace(txtTimKiemSan.Text))
            {
                txtTimKiemSan.Text = PlaceholderText;
                txtTimKiemSan.ForeColor = System.Drawing.SystemColors.GrayText; // Đổi màu văn bản khi placeholder được hiển thị
            }
        }



        private void PerformSearch()
        {
            // Thực hiện tìm kiếm dựa trên nội dung trong ô TextBox
            string searchTerm = txtTimKiemSan.Text.Trim();

            // Xử lý tìm kiếm ở đây
            MessageBox.Show("Đang tìm kiếm: " + searchTerm);
        }

        private void txtTimKiemSan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Xử lý tìm kiếm ở đây
                PerformSearch();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGioThue_TextChanged(object sender, EventArgs e)
        {
            Double TT = 0;
            if (Convert.ToDouble(txtGioThue.Text) > 0)
            {
                TT = Convert.ToDouble(txtGioThue.Text) * Convert.ToDouble(txtDonGia.Text);
                txtTT.Text = TT.ToString();
            }
        }



        private void btnTraSan_Click(object sender, EventArgs e)
        {
            if (dgvDSKH.Rows.Count > 1)
            {
                string chon = dgvDSSan.SelectedRows[0].Cells[0].Value.ToString();
                string query = "DELETE DatSan WHERE IdDatSan = '" + chon + "'";

                try
                {
                    if (MessageBox.Show("Bạn có muốn trả sân không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.SqlCommand(query);
                        MessageBox.Show("Trả sân thành công !");
                        frmDatSan_Load(sender, e);

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Trả Sân: " + ex.Message);
                }
            }
        }

    }
}
