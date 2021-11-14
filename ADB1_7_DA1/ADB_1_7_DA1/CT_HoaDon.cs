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
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        
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
            string check = "";
            string query = "Insert into CT_HoaDon(MaHD,MaSP,SoLuong,GiaBan,GiaGiam) values(@MaHD,@MaSP,@SoLuong,@GiaBan,@GiaGiam) ";
            cmd = con.CreateCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("MaHD", MaHD_CT_HoaDon.Text);
            cmd.Parameters.AddWithValue("MaSP", comboBox1.Text);
            cmd.Parameters.AddWithValue("SoLuong", textBox2.Text);
            cmd.Parameters.AddWithValue("GiaBan", GiaBan.Text);
            cmd.Parameters.AddWithValue("GiaGiam", GiaGiam.Text);
          
            if (GiaBan.Text == check || GiaGiam.Text == check || SL.Text == check)
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin đơn hàng!");
            }
            else
            {
                adapter.SelectCommand = cmd;
                table.Clear();
                adapter.Fill(table);
                CT_HD_data.DataSource = table;
                LoadCTHD();
                MessageBox.Show("Thêm chi tiết hóa đơn thành công!");
            }
        }
        void LoadCTHD()
        {
            string query = "Select * from CT_HoaDon where MaHD=@MaHD ";
            cmd = con.CreateCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("MaHD", MaHD_CT_HoaDon.Text);
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            CT_HD_data.DataSource = table;
        }

        private void CT_HoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Thêm Hóa đơn thành công!");
        }
    }
}
