using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Data.SqlClient;
using System.Data;


namespace ADB_1_7_DA1
{
    public partial class fHoaDon 
    {
     

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

     

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHoaDon));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BangHoaDon = new System.Windows.Forms.Panel();
            this.Refresh_HoaDon = new System.Windows.Forms.Button();
            this.cbbMaKH = new System.Windows.Forms.ComboBox();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doAn1_CSDL_NCDataSet = new ADB_1_7_DA1.DoAn1_CSDL_NCDataSet();
            this.NgayLap = new System.Windows.Forms.DateTimePicker();
            this.MaHD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Quit_HoaDon = new System.Windows.Forms.Button();
            this.HoaDon = new System.Windows.Forms.Panel();
            this.DanhSachHoaDon = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Refresh = new System.Windows.Forms.Button();
            this.Quit_DoanhThu = new System.Windows.Forms.Button();
            this.DoanhThuTheoThang = new System.Windows.Forms.DataGridView();
            this.khachHangTableAdapter = new ADB_1_7_DA1.DoAn1_CSDL_NCDataSetTableAdapters.KhachHangTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.BangHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAn1_CSDL_NCDataSet)).BeginInit();
            this.HoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachHoaDon)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoanhThuTheoThang)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleName = "";
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1037, 524);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BangHoaDon);
            this.tabPage1.Controls.Add(this.HoaDon);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1029, 491);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hóa đơn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BangHoaDon
            // 
            this.BangHoaDon.Controls.Add(this.Refresh_HoaDon);
            this.BangHoaDon.Controls.Add(this.cbbMaKH);
            this.BangHoaDon.Controls.Add(this.NgayLap);
            this.BangHoaDon.Controls.Add(this.MaHD);
            this.BangHoaDon.Controls.Add(this.label3);
            this.BangHoaDon.Controls.Add(this.label2);
            this.BangHoaDon.Controls.Add(this.label1);
            this.BangHoaDon.Controls.Add(this.Add);
            this.BangHoaDon.Controls.Add(this.Quit_HoaDon);
            this.BangHoaDon.Location = new System.Drawing.Point(613, 3);
            this.BangHoaDon.Name = "BangHoaDon";
            this.BangHoaDon.Size = new System.Drawing.Size(402, 358);
            this.BangHoaDon.TabIndex = 4;
            // 
            // Refresh_HoaDon
            // 
            this.Refresh_HoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh_HoaDon.Location = new System.Drawing.Point(244, 226);
            this.Refresh_HoaDon.Name = "Refresh_HoaDon";
            this.Refresh_HoaDon.Size = new System.Drawing.Size(124, 46);
            this.Refresh_HoaDon.TabIndex = 11;
            this.Refresh_HoaDon.Text = "Refresh";
            this.Refresh_HoaDon.UseVisualStyleBackColor = true;
            this.Refresh_HoaDon.Click += new System.EventHandler(this.Refresh_HoaDon_Click);
            // 
            // cbbMaKH
            // 
            this.cbbMaKH.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.khachHangBindingSource, "MakH", true));
            this.cbbMaKH.DataSource = this.khachHangBindingSource;
            this.cbbMaKH.DisplayMember = "MakH";
            this.cbbMaKH.FormattingEnabled = true;
            this.cbbMaKH.Location = new System.Drawing.Point(173, 105);
            this.cbbMaKH.Name = "cbbMaKH";
            this.cbbMaKH.Size = new System.Drawing.Size(154, 28);
            this.cbbMaKH.TabIndex = 10;
            this.cbbMaKH.ValueMember = "MakH";
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataMember = "KhachHang";
            this.khachHangBindingSource.DataSource = this.doAn1_CSDL_NCDataSet;
            // 
            // doAn1_CSDL_NCDataSet
            // 
            this.doAn1_CSDL_NCDataSet.DataSetName = "DoAn1_CSDL_NCDataSet";
            this.doAn1_CSDL_NCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NgayLap
            // 
            this.NgayLap.CustomFormat = "yyyy-MM-dd H:mm:ss zzz";
            this.NgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NgayLap.Location = new System.Drawing.Point(173, 169);
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.Size = new System.Drawing.Size(154, 26);
            this.NgayLap.TabIndex = 3;
            // 
            // MaHD
            // 
            this.MaHD.Location = new System.Drawing.Point(173, 38);
            this.MaHD.Name = "MaHD";
            this.MaHD.Size = new System.Drawing.Size(154, 26);
            this.MaHD.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ngày lập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã khách hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(40, 226);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(124, 46);
            this.Add.TabIndex = 5;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Quit_HoaDon
            // 
            this.Quit_HoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit_HoaDon.Location = new System.Drawing.Point(143, 292);
            this.Quit_HoaDon.Name = "Quit_HoaDon";
            this.Quit_HoaDon.Size = new System.Drawing.Size(124, 46);
            this.Quit_HoaDon.TabIndex = 7;
            this.Quit_HoaDon.Text = "Quit";
            this.Quit_HoaDon.UseVisualStyleBackColor = true;
            this.Quit_HoaDon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Quit_HoaDon_MouseClick);
            // 
            // HoaDon
            // 
            this.HoaDon.Controls.Add(this.DanhSachHoaDon);
            this.HoaDon.Location = new System.Drawing.Point(6, 6);
            this.HoaDon.Name = "HoaDon";
            this.HoaDon.Size = new System.Drawing.Size(601, 474);
            this.HoaDon.TabIndex = 3;
            // 
            // DanhSachHoaDon
            // 
            this.DanhSachHoaDon.AllowUserToAddRows = false;
            this.DanhSachHoaDon.AllowUserToDeleteRows = false;
            this.DanhSachHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DanhSachHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DanhSachHoaDon.Location = new System.Drawing.Point(0, 0);
            this.DanhSachHoaDon.Name = "DanhSachHoaDon";
            this.DanhSachHoaDon.ReadOnly = true;
            this.DanhSachHoaDon.RowHeadersWidth = 62;
            this.DanhSachHoaDon.Size = new System.Drawing.Size(601, 474);
            this.DanhSachHoaDon.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.DoanhThuTheoThang);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1029, 491);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Doanh Thu";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Refresh);
            this.panel3.Controls.Add(this.Quit_DoanhThu);
            this.panel3.Location = new System.Drawing.Point(660, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(353, 292);
            this.panel3.TabIndex = 3;
            // 
            // Refresh
            // 
            this.Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.Location = new System.Drawing.Point(91, 54);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(176, 68);
            this.Refresh.TabIndex = 1;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Quit_DoanhThu
            // 
            this.Quit_DoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit_DoanhThu.Location = new System.Drawing.Point(91, 187);
            this.Quit_DoanhThu.Name = "Quit_DoanhThu";
            this.Quit_DoanhThu.Size = new System.Drawing.Size(176, 68);
            this.Quit_DoanhThu.TabIndex = 2;
            this.Quit_DoanhThu.Text = "Quit";
            this.Quit_DoanhThu.UseVisualStyleBackColor = true;
            this.Quit_DoanhThu.Click += new System.EventHandler(this.Quit_DoanhThu_Click);
            // 
            // DoanhThuTheoThang
            // 
            this.DoanhThuTheoThang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoanhThuTheoThang.Location = new System.Drawing.Point(6, 6);
            this.DoanhThuTheoThang.Name = "DoanhThuTheoThang";
            this.DoanhThuTheoThang.RowHeadersWidth = 62;
            this.DoanhThuTheoThang.RowTemplate.Height = 28;
            this.DoanhThuTheoThang.Size = new System.Drawing.Size(648, 466);
            this.DoanhThuTheoThang.TabIndex = 0;
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // fHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 535);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fHoaDon";
            this.Text = "Quản lý hóa đơn - ADB_1_7";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fHoaDon_FormClosing);
            this.Load += new System.EventHandler(this.fHoaDon_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.BangHoaDon.ResumeLayout(false);
            this.BangHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAn1_CSDL_NCDataSet)).EndInit();
            this.HoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachHoaDon)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DoanhThuTheoThang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel BangHoaDon;
        private DateTimePicker NgayLap;
        private TextBox MaHD;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Add;
        private Button Quit_HoaDon;
        private Panel HoaDon;
        private DataGridView DanhSachHoaDon;
        private Panel panel3;
        private Button Quit_DoanhThu;
        private Button Refresh;
        private DataGridView DoanhThuTheoThang;
        private ComboBox cbbMaKH;
        private DoAn1_CSDL_NCDataSet doAn1_CSDL_NCDataSet;
        private BindingSource khachHangBindingSource;
        private DoAn1_CSDL_NCDataSetTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private Button Refresh_HoaDon;
    }
}

