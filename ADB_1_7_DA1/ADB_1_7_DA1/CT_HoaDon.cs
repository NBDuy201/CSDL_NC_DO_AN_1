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
    public partial class CT_HoaDon : Form
    {
        string _message;
        public CT_HoaDon()
        {
            InitializeComponent();
        }

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        //public string Constr="Data Source=MINHNHUT-HOME;Initial Catalog=DoAn1_CSDL_NC;Integrated Security=True";
        SqlConnection con;
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'doAn1_CSDL_NCDataSet.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.doAn1_CSDL_NCDataSet.SanPham);
            MaHD_CT_HoaDon.Text = _message;
            DATAPRO datapro = new DATAPRO();
            con = new SqlConnection(datapro.StrCon());
            con.Open();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string query = "Insert into CT_HoaDon(@MaHD,@MaSP,@SoLuong,@GiaBan,@GiaGiam) ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("MaHD", MaHD_CT_HoaDon.Text);
            cmd.Parameters.AddWithValue("MaSP", MaSP.Text);
            cmd.Parameters.AddWithValue("SL", SL.Text);
            cmd.Parameters.AddWithValue("GiaBan", GiaBan.Text);
            cmd.Parameters.AddWithValue("GiaGiam", GiaGiam.Text);
            fHoaDon HD = new fHoaDon();
            this.Close();
            HD.ShowDialog();
        }

        private void CT_HoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
    }
}
