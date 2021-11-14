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
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        SqlConnection con;
        SqlCommand cmd;
        DATAPRO datapro = new DATAPRO();


        public fHoaDon()
        {
            InitializeComponent();
            LoadDoanhThu();
        }

        void LoadDoanhThu()
        {
            string query = "Select  MONTH(NgayLap) as N'Tháng',YEAR(NgayLap) as N'Năm', Sum(TongTien) as N'Doanh thu' From HoaDon Group by MONTH(NgayLap),YEAR(NgayLap) Order by MONTH(NgayLap),YEAR(NgayLap)";
            DATAPRO datapro = new DATAPRO();
            DoanhThuTheoThang.DataSource = datapro.ExecuteQuery(query);
        }
     

        public void HienThiLHoaDon()
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
            string check = "";
            string query = "insert into HoaDon(MaHD,MaKH,NgayLap) values (@MaHD,@MaKH,@NgayLap) ";
            cmd = con.CreateCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("MaHD", MaHD.Text);
            cmd.Parameters.AddWithValue("MaKH", cbbMaKH.Text);
            cmd.Parameters.AddWithValue("NgayLap", NgayLap.Text.Substring(0,8));
            if (MaHD.Text == check)
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin đơn hàng!");
            }
            else
            {
                adapter.SelectCommand = cmd;
                table.Clear();
                adapter.Fill(table);
                DanhSachHoaDon.DataSource = table;
                HienThiLHoaDon();
                CT_HoaDon Ct = new CT_HoaDon();
                Ct.Message = MaHD.Text;
                Ct.Show();
            }
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
