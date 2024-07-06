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
    public partial class frmHeThong : Form
    {
        public frmHeThong()
        {
            InitializeComponent();
        }

        SqlConnection connection;
        string query;
        List<string[]> lst = new List<string[]> {
               new string[] {"User Name", "TenDangNhap" } ,
               new string[] {"Display Name", "DisplayName" }
        };
        // load dữ liệu khách hàng
        public DataSet getDataTaiKhoan()
        {
            DataSet dataSet = new DataSet();

            query = "select TenDangNhap as N'User Name' , MatKhau as N'Password' , DisplayName as N'Display Name' from TaiKhoan";

            using (connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                adapter.Fill(dataSet);

                connection.Close();
            }


            return dataSet;
        }

        // load dữ liệu tìm kiếm KH 
        public DataSet getFindTaiKhoan()
        {
            string query1 = cbo_Find.SelectedItem.ToString();
            if (cbo_Find.SelectedItem != null)
                foreach (string[] item in lst)
                {
                    if (query1 == item[0])
                    {
                        query1 = item[1];
                        break;
                    }
                }
            DataSet dataSet = new DataSet();
            query = "select TenDangNhap as N'User Name' , MatKhau as N'Password' , DisplayName as N'Display Name' from TaiKhoan where " + query1 + " like N'%" + txt_Search.Text + "%'";

            using (connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                adapter.Fill(dataSet);

                connection.Close();
            }

            return dataSet;
        }


        //DML

        public void DMLDataTaiKhoan(string DML)
        {
            DataSet dataSet = new DataSet();



            query = DML + " TaiKhoan ";
            switch (DML)
            {
                case "update":
                    query += "set MatKhau = '" + txt_PS.Text + "', DisplayName = N'" + txt_disName.Text + "' where TenDangNhap = '" + txt_UsName.Text + "'";
                    break;
                case "delete":
                    query += "where TenDangNhap = '" + txt_UsName.Text + "'";
                    break;
                default:
                    query += "values ('" + txt_UsName.Text + "', '" + txt_PS.Text + "', N'" + txt_disName.Text + "')";
                    break;
            }

            using (connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();

                connection.Close();
            }

        }


        //Kiểm tra trùng mã
        public bool CheckUserName(string UsName)
        {
            int rs = 0;
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                string query = "select COUNT(*) from TaiKhoan where TenDangNhap = '" + UsName + "'";

                SqlCommand cmd = new SqlCommand(query, connection);

                rs = (int)cmd.ExecuteScalar();

                connection.Close();
            }
            if (rs != 0)
            {
                MessageBox.Show("Trùng UserName Vui Lòng Sửa Lại!!");
                txt_UsName.Clear();
                txt_UsName.Focus();
                return false;
            }
            return true;
        }

        public bool checkTxtNotNul(TextBox txt)
        {
            if (txt.Text == "")
                return false;
            return true;
        }

        // load dgv khách hàng
        public void LoadDataDGV(DataSet GetData)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.DataSource = GetData.Tables[0];
        }


        public void LoadCboFind()
        {
            cbo_Find.Items.Clear();

            foreach (string[] item in lst)
            {
                cbo_Find.Items.Add(item[0]);
            }
            if (cbo_Find.SelectedItem == null)
                cbo_Find.SelectedItem = cbo_Find.Items[0];
        }

        public void ResetAllTxt()
        {
            txt_Search.Text = txt_disName.Text = txt_PS.Text = txt_UsName.Text = txt_PS.Text = "";
            txt_disName.Enabled = txt_PS.Enabled = txt_UsName.Enabled = txt_PS.Enabled = true;
        }

        public void ResetAllBTN()
        {
            btnAdd.Enabled = btnDel.Enabled = btnSua.Enabled = false;
        }


        

        private void CheckEnabelAddBtn(object sender, EventArgs e)
        {
            if (checkTxtNotNul(txt_PS) && checkTxtNotNul(txt_UsName) && txt_UsName.Enabled == true)
                btnAdd.Enabled = true;
            else btnAdd.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckUserName(txt_UsName.Text) && checkTxtNotNul(txt_PS) && checkTxtNotNul(txt_UsName))
            {
                try
                {
                    DMLDataTaiKhoan("insert into");
                    MessageBox.Show("Thêm Thành Công");
                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm Không Thành Công");
                }
                ResetAllTxt();
                ResetAllBTN();
                LoadDataDGV(getDataTaiKhoan());
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkTxtNotNul(txt_PS) && checkTxtNotNul(txt_UsName))
            {
                try
                {
                    DMLDataTaiKhoan("update");
                    MessageBox.Show("Sửa Thành Công");
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa Không Thành Công");
                }
                ResetAllTxt();
                ResetAllBTN();
                LoadDataDGV(getDataTaiKhoan());
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                DMLDataTaiKhoan("delete");
                MessageBox.Show("Xóa Thành Công");
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa Không Thành Công");
            }
            ResetAllTxt();
            ResetAllBTN();
            LoadDataDGV(getDataTaiKhoan());
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            frmHeThong_Load_1(sender, e);
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            LoadDataDGV(getFindTaiKhoan());
            btnHuyFind.Enabled = true;
        }

        private void btnHuyFind_Click(object sender, EventArgs e)
        {
            btnHuyFind.Enabled = false;
            txt_Search.Text = "";
            cbo_Find.SelectedItem = cbo_Find.Items[0];
            LoadDataDGV(getDataTaiKhoan());
        }

        private void frmHeThong_Load_1(object sender, EventArgs e)
        {
            LoadDataDGV(getDataTaiKhoan());
            LoadCboFind();
            ResetAllTxt();
            ResetAllBTN();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = this.dgv.Rows[e.RowIndex];

            txt_UsName.Text = row.Cells[0].Value.ToString();
            txt_UsName.Enabled = false;
            txt_disName.Text = row.Cells[2].Value.ToString();
            txt_PS.Text = row.Cells[1].Value.ToString();

            btnDel.Enabled = btnSua.Enabled = true;
        }
    }
}
