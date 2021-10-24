-- Table --
Create database DoAn1_CSDL_NC
GO

USE DoAn1_CSDL_NC
GO

CREATE TABLE KhachHang
(
	MakH Varchar(8),
	Ho nVarchar(10),
	Ten nVarchar(30),
	Ngsinh Datetime,
	SoNha nVarchar(4),
	Duong nVarchar(50),
	Phuong nVarchar(50),
	Quan nVarchar(50),
	Tpho nVarchar(50),
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
	TenSP nVarchar(30),
	SoLuongTon int,
	Mota nVarchar(100),
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
	CONSTRAINT FK_CtHD_HD_MaHD FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD) ON DELETE CASCADE,
	CONSTRAINT FK_CtHD_SP_MaSP FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP) ON DELETE CASCADE
)
GO

-- Trigger --
-- Trig 1
--				Them	Xoa		Sua
-- CT_HoaDon	+		-		+(SoLuong, GiaBan, GiaGiam, ThanhTien)
CREATE OR ALTER trigger trg_ThanhTien_ct On CT_HoaDon
AFTER INSERT, UPDATE
AS
BEGIN
	IF UPDATE(ThanhTien) AND EXISTS(SELECT * FROM DELETED)
	BEGIN
		RAISERROR('Khong duoc update ThanhTien',-1,-1)
		ROLLBACK TRAN
		RETURN
	END
	-- Insert
	IF EXISTS(SELECT * FROM inserted) AND NOT EXISTS(SELECT * FROM DELETED)
	OR
	-- Update
	(UPDATE(SoLuong) OR UPDATE(GiaBan) OR UPDATE(GiaGiam))
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

-- Trig 2
--				Them	Xoa		Sua
-- HOADON		-		-		+(TongTien)
-- CT_HoaDon	+		+		+(ThanhTien)
CREATE OR ALTER trigger trg_TongTien_hd On HoaDon
AFTER UPDATE
AS
BEGIN
	IF UPDATE(TongTien) AND EXISTS(SELECT * FROM DELETED)
	BEGIN
		RAISERROR('Khong duoc update TongTien',-1,-1)
		ROLLBACK
		RETURN
	END
END
GO

CREATE OR ALTER trigger trg_TongTien_ct On CT_HoaDon
AFTER INSERT, DELETE, UPDATE
AS
BEGIN
	DECLARE @maHD VARCHAR(4)

	-- Insert / Update
	IF EXISTS(SELECT * FROM inserted) AND NOT EXISTS(SELECT * FROM DELETED) OR (UPDATE(SoLuong) OR UPDATE(GiaBan) OR UPDATE(GiaGiam))
	BEGIN
		SET @maHD = (SELECT MaHD FROM INSERTED)
	END
	IF EXISTS(SELECT * FROM DELETED) AND NOT EXISTS(SELECT * FROM INSERTED)
	-- Delete
	BEGIN
		SET @maHD = (SELECT MaHD FROM DELETED)
	END

	ALTER TABLE HoaDon DISABLE TRIGGER trg_TongTien_hd
	UPDATE HoaDon
	SET TongTien = 
	(
		SELECT SUM(ct_hd.ThanhTien)
		FROM CT_HoaDon AS ct_hd
		WHERE ct_hd.MaHD = @maHD
	)
	WHERE HoaDon.MaHD = @maHD	
	ALTER TABLE HoaDon ENABLE TRIGGER trg_TongTien_hd
END
GO