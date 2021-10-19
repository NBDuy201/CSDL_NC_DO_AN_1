USE DoAn1_CSDL_NC
GO

CREATE TABLE [KhachHang] (
  [MakH] Varchar(4),
  [Ho] Varchar(10),
  [Ten] Varchar(30),
  [Ngsinh] Datetime,
  [SoNha] Varchar(4),
  [Duong] Varchar(20),
  [Phuong] Varchar(20),
  [Quan] Varchar(20),
  [Tpho] Varchar(30),
  [DienThoai] Varchar(10),
  PRIMARY KEY ([MakH])
);
GO

CREATE TABLE [HoaDon] (
  [MaHD] Varchar(4),
  [MaKH] Varchar(4),
  [NgayLap] Datetime,
  [TongTien] int,
  PRIMARY KEY ([MaHD]),
  CONSTRAINT [FK_HD_KH_MaKH] FOREIGN KEY ([MaKH]) REFERENCES [KhachHang]([MakH])
);
GO

CREATE TABLE [SanPham] (
  [MaSP] Varchar(4),
  [TenSP] Varchar(20),
  [SoLuongTon] int,
  [Mota] Varchar(40),
  [Gia] int,
  PRIMARY KEY ([MaSP])
);
GO

CREATE TABLE [CT_HoaDon] (
  [MaHD] Varchar(4),
  [MaSP] Varchar(4),
  [SoLuong] int,
  [GiaBan] int,
  [GiaGiam] int,
  [ThanhTien] int,
  PRIMARY KEY ([MaHD], [MaSP]),
  CONSTRAINT [FK_CtHD_HD_MaHD] FOREIGN KEY ([MaHD]) REFERENCES [HoaDon]([MaHD]),
  CONSTRAINT [FK_CtHD_SP_MaSP] FOREIGN KEY ([MaSP]) REFERENCES [SanPham]([MaSP])
);
GO

--ALTER TABLE [HoaDon]
--ADD TongTien AS 
--	(SELECT SUM(ct_hd.ThanhTien)
--	FROM CT_HoaDon AS ct_hd JOIN HoaDon AS hd
--	ON ct_hd.MaHD = hd.MaHD
--	GROUP BY ct_hd.MaHD
--	)

SELECT *
FROM KhachHang