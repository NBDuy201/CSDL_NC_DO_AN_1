
namespace ADB_1_7_DA1
{
    partial class CT_HoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CT_HoaDon));
            this.MaHD_CT = new System.Windows.Forms.Label();
            this.MaHD_CT_HoaDon = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.GiaBan = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doAn1_CSDL_NCDataSet = new ADB_1_7_DA1.DoAn1_CSDL_NCDataSet();
            this.GiaGiam = new System.Windows.Forms.TextBox();
            this.MaSP = new System.Windows.Forms.Label();
            this.SL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.sanPhamTableAdapter = new ADB_1_7_DA1.DoAn1_CSDL_NCDataSetTableAdapters.SanPhamTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAn1_CSDL_NCDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // MaHD_CT
            // 
            this.MaHD_CT.AutoSize = true;
            this.MaHD_CT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaHD_CT.Location = new System.Drawing.Point(17, 24);
            this.MaHD_CT.Name = "MaHD_CT";
            this.MaHD_CT.Size = new System.Drawing.Size(164, 30);
            this.MaHD_CT.TabIndex = 0;
            this.MaHD_CT.Text = "Mã Hóa Đơn:";
            // 
            // MaHD_CT_HoaDon
            // 
            this.MaHD_CT_HoaDon.Location = new System.Drawing.Point(207, 24);
            this.MaHD_CT_HoaDon.Multiline = true;
            this.MaHD_CT_HoaDon.Name = "MaHD_CT_HoaDon";
            this.MaHD_CT_HoaDon.ReadOnly = true;
            this.MaHD_CT_HoaDon.Size = new System.Drawing.Size(109, 32);
            this.MaHD_CT_HoaDon.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(207, 128);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(109, 26);
            this.textBox2.TabIndex = 5;
            // 
            // GiaBan
            // 
            this.GiaBan.Location = new System.Drawing.Point(207, 178);
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.Size = new System.Drawing.Size(109, 26);
            this.GiaBan.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sanPhamBindingSource, "MaSP", true));
            this.comboBox1.DataSource = this.sanPhamBindingSource;
            this.comboBox1.DisplayMember = "MaSP";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(207, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(109, 28);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "MaSP";
            // 
            // sanPhamBindingSource
            // 
            this.sanPhamBindingSource.DataMember = "SanPham";
            this.sanPhamBindingSource.DataSource = this.doAn1_CSDL_NCDataSet;
            // 
            // doAn1_CSDL_NCDataSet
            // 
            this.doAn1_CSDL_NCDataSet.DataSetName = "DoAn1_CSDL_NCDataSet";
            this.doAn1_CSDL_NCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GiaGiam
            // 
            this.GiaGiam.Location = new System.Drawing.Point(207, 232);
            this.GiaGiam.Name = "GiaGiam";
            this.GiaGiam.Size = new System.Drawing.Size(109, 26);
            this.GiaGiam.TabIndex = 9;
            // 
            // MaSP
            // 
            this.MaSP.AutoSize = true;
            this.MaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaSP.Location = new System.Drawing.Point(17, 71);
            this.MaSP.Name = "MaSP";
            this.MaSP.Size = new System.Drawing.Size(175, 30);
            this.MaSP.TabIndex = 10;
            this.MaSP.Text = "Mã Sản Phẩm";
            // 
            // SL
            // 
            this.SL.AutoSize = true;
            this.SL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SL.Location = new System.Drawing.Point(17, 122);
            this.SL.Name = "SL";
            this.SL.Size = new System.Drawing.Size(121, 30);
            this.SL.TabIndex = 11;
            this.SL.Text = "Số Lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 30);
            this.label4.TabIndex = 12;
            this.label4.Text = "Giá Bán:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 30);
            this.label5.TabIndex = 13;
            this.label5.Text = "Giá Giảm:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(84, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 47);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sanPhamTableAdapter
            // 
            this.sanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // CT_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 338);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SL);
            this.Controls.Add(this.MaSP);
            this.Controls.Add(this.GiaGiam);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.GiaBan);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.MaHD_CT_HoaDon);
            this.Controls.Add(this.MaHD_CT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CT_HoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm chi tiết hóa đơn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CT_HoaDon_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doAn1_CSDL_NCDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MaHD_CT;
        private System.Windows.Forms.TextBox MaHD_CT_HoaDon;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox GiaBan;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox GiaGiam;
        private System.Windows.Forms.Label MaSP;
        private System.Windows.Forms.Label SL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private DoAn1_CSDL_NCDataSet doAn1_CSDL_NCDataSet;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private DoAn1_CSDL_NCDataSetTableAdapters.SanPhamTableAdapter sanPhamTableAdapter;
    }
}