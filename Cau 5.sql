USE DoAn1_CSDL_NC
GO

--Cau 5 a
-- HD0 co khach hang nao mua
SELECT hd.MaHD, hd.MaKH
FROM CT_HoaDon chd, HoaDon hd
WHERE 
	chd.MaHD = 'HD0' AND
	hd.MaHD = chd.MaHD
GO

SELECT hd.MaHD, hd.MaKH
FROM CT_HoaDon chd JOIN HoaDon hd
ON hd.MaHD = chd.MaHD AND hd.MaHD = 'HD0'
--WHERE hd.MaHD = 'HD0'
GO

--Cau 5 b
-- HD0 co khach hang nao mua
SELECT hd.MaHD, hd.MaKH
FROM CT_HoaDon chd, HoaDon hd
WHERE 
	chd.MaHD = 'HD0' AND
	hd.MaHD = chd.MaHD
GO

SELECT hd.MaHD, hd.MaKH
FROM HoaDon hd JOIN CT_HoaDon chd
ON hd.MaHD = chd.MaHD AND hd.MaHD = 'HD0'
--WHERE hd.MaHD = 'HD0'
GO