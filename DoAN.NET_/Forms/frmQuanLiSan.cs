using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAN.NET_.Forms
{
    public partial class frmQuanLiSan : Form
    {
        private bool checkQLSan = true;

        SqlConnection connection;
        string query;

        public frmQuanLiSan()
        {
            InitializeComponent();

        }
        
        //load data sân
        public DataSet GetAllSanTenLoaiSan()
        {
            DataSet data = new DataSet();

            query = "select IdSanBanh as N'Mã', TenLoai as N'Tên Loại', TenSanBanh as N'Tên Sân' from SanBanh, LoaiSanBanh where SanBanh.IdLoaiSan = LoaiSanBanh.IdLoaiSan";

            using (connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        public DataSet GetAllLoaiSan()
        {
            DataSet data = new DataSet();

            query = "select IdLoaiSan as N'Mã', TenLoai as N'Tên', Gia as N'Giá', MoTa as N'Mô tả' from LoaiSanBanh";

            using (connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        public DataSet GetSearchSan(string txt)
        {
            DataSet data = new DataSet();

            query = "select IdSanBanh as N'Mã', TenLoai as N'Tên Loại', TenSanBanh as N'Tên Sân' from SanBanh, LoaiSanBanh where TenSanBanh like N'%" + txt + "%' and SanBanh.IdLoaiSan = LoaiSanBanh.IdLoaiSan";

            using (connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        public DataSet GetSearchLoaiSan(string txt)
        {
            DataSet data = new DataSet();

            query = "select IdLoaiSan as N'Mã', TenLoai as N'Tên', Gia as N'Giá', MoTa as N'Mô tả' from LoaiSanBanh where TenLoai like N'%" + txt+"%'";

            using (connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }
        //Load Giao Diện

        public void LoadCboLoaiSan()
        {
            cbo_LoaiSan.DataSource = GetAllLoaiSan().Tables[0];
            cbo_LoaiSan.DisplayMember = "Tên";
            cbo_LoaiSan.ValueMember = "Mã";
        }

        public void LoadDataDGV(DataSet GetData)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.DataSource = GetData.Tables[0];

        }

        

        private void quảnLýLoạiSânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkQLSan = false;
            LoadDataDGV(GetAllLoaiSan());
            quảnLýSânToolStripMenuItem.ForeColor = Color.FromArgb(64, 64, 64);
            quảnLýLoạiSânToolStripMenuItem.ForeColor = Color.FromArgb(0, 192, 192);
            txt_Mota.Visible = true;
            lbl_mTa.Visible = true;
            //
            loadFormThongTin();
        }
        public void loadFormSan(bool a)
        {
            lbl_MaSan.Visible = a;
            txt_MaSan.Visible = a;
            lbl_TenSan.Visible = a;
            txt_TenSan.Visible = a;
            lbl_LoaiSan.Visible = a;
            cbo_LoaiSan.Visible = a;
            LoadCboLoaiSan();
        }

        public void loadFormLoaiSan(bool a)
        {
            lbl_MaLoaiSan.Visible = a;
            txt_MaLoaiSan.Visible = a;
            lbl_TenLoaiSan.Visible = a;
            txt_TenLoaiSan.Visible = a;
            lbl_GiaLoaiSan.Visible = a;
            txt_GiaLoaiSan.Visible = a;
        }



        public void loadFormThongTin()
        {
            if (checkQLSan)
            {
                loadFormSan(true);
                loadFormLoaiSan(false);
            }
            else
            {
                loadFormSan(false);
                loadFormLoaiSan(true);
            }
            ResertTxtBoxAll();
        }

        // xử lý button 
        private void Search_btn_Click(object sender, EventArgs e)
        {
            if (checkQLSan)
                LoadDataDGV(GetSearchSan(txt_Search.Text));
            else
                LoadDataDGV(GetSearchLoaiSan(txt_Search.Text));
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = this.dgv.Rows[e.RowIndex];

            if (checkQLSan)
            {
                txt_MaSan.Text = row.Cells[0].Value.ToString();
                txt_TenSan.Text = row.Cells[2].Value.ToString();
                cbo_LoaiSan.SelectedIndex = cbo_LoaiSan.FindString(row.Cells[1].Value.ToString());
            }
            else
            {
                txt_MaLoaiSan.Text = row.Cells[0].Value.ToString();
                txt_TenLoaiSan.Text = row.Cells[1].Value.ToString();
                txt_GiaLoaiSan.Text = row.Cells[2].Value.ToString();
                txt_Mota.Text = row.Cells[3].Value.ToString();
            }
            Del_btn.Enabled = Upd_btn.Enabled = true;
            txt_MaSan.Enabled = txt_MaLoaiSan.Enabled = false;
        }

        private void ResertTxtBoxAll()
        {
            txt_Search.Clear();
            txt_GiaLoaiSan.Clear();
            txt_MaLoaiSan.Clear();
            txt_TenLoaiSan.Clear();
            txt_MaSan.Clear();
            txt_TenSan.Clear();
            txt_Mota.Clear();
            add_btn.Enabled = false;
            Del_btn.Enabled = false;
            Upd_btn.Enabled = false;
        }

        private bool CheckNullAllTextBox(bool Focus, params TextBox[] txtList)
        {
            foreach (TextBox textBox in txtList)
            {
                if (textBox.Text.Trim() == "")
                {
                    if (Focus)
                        textBox.Focus();
                    return false;
                }
            }
            return true;
        }

        private void LeaveNullAllTextBox(object sender, EventArgs e)
        {
            //if (checkQLSan)
            //{
            //    if (CheckNullAllTextBox(true, txt_MaSan, txt_TenSan))
            //    {
            //        add_btn.Enabled = true;
            //    }
            //    else
            //    {
            //        add_btn.Enabled = false;
            //    }
            //}
            //else
            //{
            //    if (CheckNullAllTextBox(true, txt_MaLoaiSan, txt_TenLoaiSan, txt_GiaLoaiSan))
            //    {
            //        add_btn.Enabled = true;
            //    }
            //    else
            //    {
            //        add_btn.Enabled = false;
            //    }
            //}
        }

        public bool CheckMa()
        {
            TextBox txtB = txt_MaSan;
            if (!checkQLSan)
                txtB = txt_MaLoaiSan;

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {

                connection.Open();

                string query = "select count(*) from SanBanh where IdSanBanh = '" + txtB.Text +"'";

                if (!checkQLSan)
                    query = "select count(*) from LoaiSanBanh where IdLoaiSan = '" + txtB.Text +"'";

                SqlCommand cmd = new SqlCommand(query, connection);

                if ((int)cmd.ExecuteScalar() != 0)
                {
                    MessageBox.Show("Mã Trùng Vui Lòng Sửa Lại Mã");
                    txtB.Clear();
                    txtB.Focus();
                    return false;
                }

                connection.Close();
            }

            return true;

        }

        private void keyDownCheckNull(object sender = null, KeyEventArgs e = null)
        {
            if (checkQLSan)
            {
                if (CheckNullAllTextBox(false, txt_MaSan, txt_TenSan))
                {
                    add_btn.Enabled = true;
                }
                else
                {
                    add_btn.Enabled = false;
                }
            }
            else
            {
                if (CheckNullAllTextBox(false, txt_MaLoaiSan, txt_TenLoaiSan, txt_GiaLoaiSan))
                {
                    add_btn.Enabled = true;
                }
                else
                {
                    add_btn.Enabled = false;
                }
            }
        }
        private void quảnLýLoạiSânToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            checkQLSan = false;
            LoadDataDGV(GetAllLoaiSan());
            quảnLýSânToolStripMenuItem.ForeColor = Color.FromArgb(64, 64, 64);
            quảnLýLoạiSânToolStripMenuItem.ForeColor = Color.FromArgb(0, 192, 192);
            
            //
            loadFormThongTin();
        }

        private void quảnLýSânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkQLSan = true;
            LoadDataDGV(GetAllSanTenLoaiSan());
            quảnLýSânToolStripMenuItem.ForeColor = Color.FromArgb(0, 192, 192);
            quảnLýLoạiSânToolStripMenuItem.ForeColor = Color.FromArgb(64, 64, 64);
            txt_Mota.Visible = false;
            lbl_mTa.Visible = false;
            //
            loadFormThongTin();
        }

        private void frmQuanLiSan_Load(object sender, EventArgs e)
        {
            LoadDataDGV(GetAllSanTenLoaiSan());
            loadFormThongTin();
        }

        private void add_btn_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                try
                {
                    if (!CheckMa())
                        return;

                    string query = "insert into SanBanh values ('" + txt_MaSan.Text + "',N'" + txt_TenSan.Text + "','" + cbo_LoaiSan.SelectedValue.ToString() + "')";

                    if (!checkQLSan)
                        query = "insert into LoaiSanBanh values ('" + txt_MaLoaiSan.Text + "',N'" + txt_TenLoaiSan.Text + "', " + txt_GiaLoaiSan.Text + " ,N'"+txt_Mota.Text+"')";

                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm Thành Công");

                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm Không Thành Công");
                }

                connection.Close();
            }

            Res_btn_Click(sender, e);

            ResertTxtBoxAll();
        }

        private void Upd_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                try
                {

                    string query = "update SanBanh set IdSanBanh = ' " + txt_MaSan.Text + "', TenSanBanh = N'" + txt_TenSan.Text + "', IdLoaiSan = '" + cbo_LoaiSan.SelectedValue.ToString() + "' where IdSanBanh ='" + txt_MaSan.Text + "'";

                    if (!checkQLSan)
                        query = "update LoaiSanBanh set IdLoaiSan = '" + txt_MaLoaiSan.Text + "', TenLoai = N'" + txt_TenLoaiSan.Text + "', Gia = " + txt_GiaLoaiSan.Text + ", MoTa = N'" + txt_Mota.Text + "' where IdLoaiSan ='" + txt_MaLoaiSan.Text + "'";

                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Sửa Thành Công");
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa Không Thành Công");
                }

                connection.Close();
            }

            Res_btn_Click(sender, e);


            ResertTxtBoxAll();
        }

        private void Res_btn_Click(object sender, EventArgs e)
        {
            if (checkQLSan)
                quảnLýSânToolStripMenuItem_Click(sender, e);
            else
                quảnLýLoạiSânToolStripMenuItem_Click(sender, e);
            ResertTxtBoxAll();
            txt_MaSan.Enabled = txt_MaLoaiSan.Enabled = true;
        }

        private void Del_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                try
                {
                    string query = "delete SanBanh where IdSanBanh = '" + txt_MaSan.Text + "'";

                    if (!checkQLSan)
                        query = "delete LoaiSanBanh where IdLoaiSan = '" + txt_MaLoaiSan.Text + "'";

                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Xóa Thành Công");

                }
                catch (Exception)
                {
                    if (!checkQLSan)
                        MessageBox.Show("Không Thể Xóa" + txt_MaLoaiSan.Text);
                    else
                        MessageBox.Show("Không Thể Xóa" + txt_MaSan.Text);
                }

                connection.Close();
            }

            Res_btn_Click(sender, e);

            ResertTxtBoxAll();
        }
    }
}
