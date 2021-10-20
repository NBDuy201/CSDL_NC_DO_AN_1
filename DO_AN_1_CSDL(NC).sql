CREATE DATABASE DoAn1_CSDL_NC
<<<<<<< Updated upstream
=======
GO

USE DoAn1_CSDL_NC
>>>>>>> Stashed changes
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


-- Trigger --
-- Duy
-- Trig 1
--				Them	Xoa		Sua
-- CT_HoaDon	+		-		+(SoLuong, GiaBan, GiaGiam)

-- Test --
SELECT *
FROM CT_HoaDon
WHERE MaHD = 'oghi'
GO

--DELETE FROM CT_HoaDon WHERE MaHD = 'oghi' AND MaSP = 'onac'
INSERT INTO CT_HoaDon VALUES('oghi', 'onac', 20, 30000, 10, NULL)
GO
UPDATE CT_HoaDon SET ThanhTien = 300 WHERE MaHD = 'oghi' AND MaSP = 'onzc'
GO
-- Test --

CREATE trigger trg_ThanhTien On CT_HoaDon
AFTER INSERT, UPDATE
AS
BEGIN
	-- Insert
	IF EXISTS(SELECT * FROM inserted) AND NOT EXISTS(SELECT * FROM DELETED)
	OR
	-- Update
	(UPDATE(SoLuong) OR UPDATE(GiaBan) OR UPDATE(GiaGiam) OR UPDATE(ThanhTien))
	BEGIN
		DECLARE 
			@maHD VARCHAR(4),
			@maSP VARCHAR(4)
		SET @maHD = (SELECT MaHD FROM INSERTED)
		SET @maSP = (SELECT MaSP FROM INSERTED)

		UPDATE CT_HoaDon
		SET ThanhTien = 
		(
			SELECT ct.SoLuong * (ct.GiaBan - ct.GiaGiam)
			FROM CT_HoaDon AS ct
			WHERE ct.MaHD = @maHD AND ct.MaSP = @maSP
		)
		WHERE CT_HoaDon.MaHD = @maHD AND CT_HoaDon.MaSP = @maSP
	END
END
GO

-- Nhựt

-- Tuấn