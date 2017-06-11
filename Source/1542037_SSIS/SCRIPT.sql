CREATE DATABASE DEMO_SSIS 
GO

USE DEMO_SSIS
GO

CREATE TABLE ChiTietHoaDon
(
	MaCTHD				INT PRIMARY KEY IDENTITY,
	NgayMuaHang			DATE,
	SoLuong				INT,
	Gia					MONEY,
	MaSanPham			VARCHAR(20),
	MaKH				VARCHAR(20),
	XuLy				INT
)

GO

CREATE TABLE ChiTietHoaDon_TMP
(
	NgayMuaHang			DATE,
	SoLuong				INT,
	Gia					MONEY,
	MaSanPham			VARCHAR(20),
	MaKH				VARCHAR(20),
	XuLy				INT DEFAULT(0) NOT NULL
)

GO

CREATE TABLE HoaDon
(
	MaHoaDon			INT PRIMARY KEY IDENTITY,
	NgayMuaHang			DATE,
	NgayLapHD			DATE,
	MaKH				VARCHAR(20),
	TongTien			MONEY
)

GO

CREATE PROC [dbo].[USP_TaoHoaDon]
AS 
BEGIN
	-- Prevent duplicate data
	DECLARE @NgayMua DATE,@MaKH VARCHAR(20)
	SELECT TOP 1 @NgayMua=NgayMuaHang, @Makh = Makh FROM ChiTietHoaDon_TMP
	DELETE FROM ChiTietHoaDon WHERE MaKH = @MaKH AND NgayMuaHang = @NgayMua

	INSERT INTO ChiTietHoaDon (NgayMuaHang,MaKH,Gia,SoLuong,MaSanPham) 
	SELECT NgayMuaHang,MaKH,Gia,SoLuong,MaSanPham
	FROM ChiTietHoaDon_TMP	

	DELETE FROM HoaDon WHERE MaKH = @MaKH AND NgayMuaHang = @NgayMua
	-- Processing HoaDon from CTHD
	INSERT INTO HoaDon (MaKH,NgayLapHD,NgayMuaHang,TongTien)
	SELECT cthd.MaKH,
			GETDATE(),
			cthd.NgayMuaHang,
			SUM (cthd.SoLuong * cthd.Gia)
	FROM ChiTietHoaDon cthd
	WHERE cthd.XuLy=0 OR cthd.XuLy IS NULL -- v.1.1
	GROUP BY cthd.MaKH,cthd.NgayMuaHang

	UPDATE ChiTietHoaDon 
	SET XuLy = 1
	WHERE NgayMuaHang=@NgayMua AND MaKH = @MaKH
END

-----------------------------------------------------------------

DELETE FROM [dbo].[HoaDon]
GO
DELETE FROM [dbo].[ChiTietHoaDon]
GO
DELETE FROM [dbo].[ChiTietHoaDon_TMP]
GO

-----------------------------------------------------------------

SELECT * FROM [dbo].[HoaDon]

SELECT * FROM [dbo].[ChiTietHoaDon]

SELECT * FROM [dbo].[ChiTietHoaDon_TMP]

