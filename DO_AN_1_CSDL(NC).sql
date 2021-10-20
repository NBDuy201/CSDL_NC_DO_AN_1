CREATE DATABASE DoAn1_CSDL_NC
GO
USE DoAn1_CSDL_NC
GO

CREATE TABLE KhachHang
(
	MakH Varchar(8),
	Ho Varchar(10),
	Ten Varchar(30),
	Ngsinh Datetime,
	SoNha Varchar(4),
	Duong Varchar(50),
	Phuong Varchar(50),
	Quan Varchar(50),
	Tpho Varchar(50),
	DienThoai Varchar(15),
	PRIMARY KEY (MakH)
)
GO
CREATE TABLE HoaDon
(
	MaHD Varchar(8),
	MaKH Varchar(8),
	NgayLap Datetime,
	TongTien int,
	PRIMARY KEY (MaHD),
	CONSTRAINT FK_HD_KH_MaKH FOREIGN KEY (MaKH) REFERENCES KhachHang(MakH)
)
GO
CREATE TABLE SanPham
(
	MaSP Varchar(8),
	TenSP Varchar(30),
	SoLuongTon int,
	Mota Varchar(100),
	Gia int,
	PRIMARY KEY (MaSP)
)
GO
CREATE TABLE CT_HoaDon 
(
	MaHD Varchar(8),
	MaSP Varchar(8),
	SoLuong int,
	GiaBan int,
	GiaGiam int,
	ThanhTien int,
	PRIMARY KEY (MaHD, MaSP),
	CONSTRAINT FK_CtHD_HD_MaHD FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD),
	CONSTRAINT FK_CtHD_SP_MaSP FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)
)
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