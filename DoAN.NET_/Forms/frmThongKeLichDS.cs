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
using Microsoft.Reporting.WinForms;

namespace DoAN.NET_.Forms
{
    public partial class frmThongKeLichDS : Form
    {
        public frmThongKeLichDS()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=YN\SQLEXPRESS;Initial Catalog=QL_SanBanh1;User ID=sa;Password = 01633970241");
        private void frmThongKe_Load(object sender, EventArgs e)
        {
           
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void btnLoadDuLieu_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from DatSan",conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("DataSet1",dt);
            reportViewer1.LocalReport.ReportPath = "ThongKe.rdlc";
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();
        }
    }
}
