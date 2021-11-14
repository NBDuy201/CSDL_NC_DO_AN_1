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

namespace ADB_1_7_DA1
{
    public partial class fHoaDon : Form
    {

        SqlConnection con;
        public fHoaDon()
        {
            InitializeComponent();
            LoadDoanhThu();
        }

        void LoadDoanhThu()
        {
            string query = "Select  MONTH(NgayLap) as N'Tháng', Sum(TongTien) as N'Doanh thu' From HoaDon Group by MONTH(NgayLap) Order by MONTH(NgayLap)";
            DATAPRO datapro = new DATAPRO();
            DoanhThuTheoThang.DataSource = datapro.ExecuteQuery(query);
        }
     

        void HienThiLHoaDon()
        {
            string query = "Select * from HoaDon order by MaHD";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            DanhSachHoaDon.DataSource = dt;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string query = "Insert into HoaDon(@MaHD,@MaKH,@Ngaylap) ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("MaHD", MaHD.Text);
            cmd.Parameters.AddWithValue("MaKH", cbbMaKH.Text);
            cmd.Parameters.AddWithValue("NgayLap", NgayLap.Text);
            CT_HoaDon Ct = new CT_HoaDon();
            Ct.Message = MaHD.Text;
            this.Hide();
            Ct.ShowDialog();
            
        }

        

        private void Quit_HoaDon_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void Quit_DoanhThu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void Refresh_Click(object sender, EventArgs e)
        {
            LoadDoanhThu();
        }

        private void fHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'doAn1_CSDL_NCDataSet.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.doAn1_CSDL_NCDataSet.KhachHang);
            DATAPRO datapro = new DATAPRO();
            con = new SqlConnection(datapro.StrCon());
            con.Open();
            HienThiLHoaDon();
            
        }

        private void fHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void Refresh_HoaDon_Click(object sender, EventArgs e)
        {
            HienThiLHoaDon();
        }

      
    }
}
