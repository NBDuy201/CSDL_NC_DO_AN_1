USE DoAn1_CSDL_NC
GO
-- tuấn
-- cau 3 a) Danh sách các đơn lập trong năm 2020
SELECT * FROM dbo.HoaDon
WHERE YEAR(NgayLap) = 2020
GO

SELECT * FROM dbo.HoaDon
WHERE DATEPART(YEAR, NgayLap) = 2020
GO

-- Cau 3 b) Danh sách khách hàng ở TPHCM
SELECT * FROM dbo.KhachHang
WHERE Tpho = 'TPHCM'
GO

-- Cau 3 c) Danh sách các sản phẩm có giá trị trong một khoảng từ ..đến..
SELECT* FROM dbo.SanPham
WHERE Gia BETWEEN 100 AND 500
GO

-- câu 3 d) Danh sách các sản phẩm có số lượng tồn < 100
SELECT* FROM dbo.SanPham
WHERE SoLuongTon < 100
GO

-- câu 3 e) Danh sách các sản phẩm bán chạy nhất (bán nhiều nhất)
SELECT SP.MaSP, SP.TenSP FROM dbo.SanPham SP 
JOIN dbo.CT_HoaDon CTHD ON SP.MaSP = CTHD.MaSP
GROUP BY SP.MaSP, SP.TenSP
HAVING SUM(CTHD.SoLuong) >= ALL (SELECT SUM(CTHD.SoLuong)
								FROM dbo.SanPham SP 
								JOIN dbo.CT_HoaDon CTHD ON SP.MaSP = CTHD.MaSP
								GROUP BY SP.MaSP)
GO

-- câu 3 f)
SELECT SP.MaSP, SP.TenSP, SP.Gia, SP.MoTa, SP.SoLuongTonFROM SanPham SP JOIN CT_HOADON CTHD ON SP.MaSP = CTHD.MaSPGROUP BY SP.MaSP, SP.TenSP, SP.Gia, SP.MoTa, SP.SoLuongTonHAVING SUM(CTHD.ThanhTien) >= ALL 
							(SELECT SUM(ThanhTien)
							FROM SanPham SP JOIN CT_HOADON CTHD ON SP.MaSP = CTHD.MaSP
							GROUP BY SP.MaSP
							)
GO

-- duy
-- e
CREATE OR ALTER FUNCTION spBanChayNhat()
RETURNS TABLE
AS
RETURN
	(
		SELECT ct.MaSP
		FROM CT_HoaDon ct
		GROUP BY ct.MaSP
		HAVING SUM(ct.SoLuong) >= ALL(
								-- Tong so luong sp tren ct hoa don
								SELECT SUM(ct.SoLuong) AS SL
								FROM CT_HoaDon ct
								GROUP BY ct.MaSP
								)
	)
GO

SELECT *
FROM SanPham sp
WHERE sp.MaSP in (SELECT *
					FROM dbo.spBanChayNhat())
GO

-- f
CREATE OR ALTER FUNCTION spDanhThuCaoNhat()
RETURNS TABLE
AS
RETURN
	(
		SELECT ct.MaSP
		FROM CT_HoaDon ct
		GROUP BY ct.MaSP
		HAVING SUM(ct.ThanhTien) >= ALL(
								-- Doanh thu cac sp
								SELECT SUM(ct.ThanhTien) AS doanhThu
								FROM CT_HoaDon ct
								GROUP BY ct.MaSP
								)
	)
GO

SELECT *
FROM SanPham sp
WHERE sp.MaSP in (SELECT *
					FROM dbo.spDanhThuCaoNhat())
GO