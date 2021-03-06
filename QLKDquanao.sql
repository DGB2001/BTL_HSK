CREATE DATABASE QLKDquanao
USE QLKDquanao

-- Tạo Các Bảng
-- tblLoaiHang
 CREATE TABLE tblLoaiHang
 (
	sMaLoaiHang VARCHAR(20) PRIMARY KEY,
	sTenLoaiHang NVARCHAR(30)
 )
GO
 --tblNhaCungCap
 CREATE TABLE tblNhaCungCap
 (
	iMaNCC INT PRIMARY KEY,
	sTenNhaCC NVARCHAR(30),
	sTenGiaoDich NVARCHAR(50),
	sDiaChi NVARCHAR(50),
	sDienThoai CHAR(10)
 )
GO
 --tblMatHang
 CREATE TABLE tblMatHang
 (
	sMaHang VARCHAR(20) PRIMARY KEY,
	sTenHang NVARCHAR(30),
	iMaNCC INT REFERENCES dbo.tblNhaCungCap(iMaNCC),
	sMaLoaiHang VARCHAR(20) REFERENCES dbo.tblLoaiHang(sMaLoaiHang),
	fSoLuong FLOAT,
	fGiaHang FLOAT,
 )
GO
 --tblKhachHang
 CREATE TABLE tblKhachHang
 (
	iMaKH INT PRIMARY KEY,
	sTenKH NVARCHAR(30),
	sDiaChi NVARCHAR(50),
	sDienThoai CHAR(10)
 )
 GO
 --tblNhanVien
 CREATE TABLE tblNhanVien
 (
	iMaNV INT NOT NULL IDENTITY PRIMARY KEY,
	sTenNV NVARCHAR(30),
	sDiaChi NVARCHAR(50),
	sDienThoai CHAR(10),
	dNgaySinh DATETIME CHECK(DATEDIFF(YEAR,dNgaySinh,GETDATE()) >=18),
	sGioiTinh NVARCHAR(5) CHECK(sGioiTinh = N'Nam' OR sGioiTinh = N'Nữ'),
	dNgayVaoLam DATETIME,
	fLuongCoBan FLOAT,
	fPhuCap FLOAT
 )
GO
 --tblDonDatHang
 CREATE TABLE tblDonDatHang
 (
	iSoHD INT PRIMARY KEY,
	iMaNV INT REFERENCES dbo.tblNhanVien(iMaNV) NOT NULL,
	iMaKH INT REFERENCES dbo.tblKhachHang(iMaKH) NOT NULL,
	dNgayDatHang DATETIME,
	dNgayGiaoHang DATETIME,
	fTongTienHD FLOAT CHECK (fTongTienHD >0),
	CONSTRAINT ck_ngaydathang CHECK(DATEDIFF(DAY,dNgayDatHang,dNgayGiaoHang)>=0)
 )
GO
 --tblChiTietDatHang
 CREATE TABLE tblChiTietDatHang
 (
	iSoHD INT REFERENCES dbo.tblDonDatHang(iSoHD),
	sMaHang VARCHAR(20) REFERENCES dbo.tblMatHang(sMaHang),
	iSoLuongMua INT,
	fMucGiamGia FLOAT,
	CONSTRAINT pk_chitietdathang PRIMARY KEY (iSoHD,sMaHang)
 )
GO
 --tblDonNhapKho
CREATE TABLE tblDonNhapKho
(
	iSoNK INT PRIMARY KEY,
	iMaNV INT REFERENCES dbo.tblNhanVien(iMaNV) NOT NULL,
	dNgayNhapHang DATETIME,
	fTongSoLuong FLOAT CHECK(fTongSoLuong >0)
)
GO
-- tblChiTietNhapKho
CREATE TABLE tblChiTietNhapKho
(
	iSoNK INT REFERENCES dbo.tblDonNhapKho(iSoNK),
	sMaHang VARCHAR(20) REFERENCES dbo.tblMatHang(sMaHang),
	fGiaNhap FLOAT,
	fSoLuongNhap FLOAT CHECK (fSoLuongNhap >0),
	CONSTRAINT pk_chitietnhapkho PRIMARY KEY(iSoNK,sMaHang)
)
GO
-- THEM DU LIEU
-- tblLoaiHang
INSERT INTO dbo.tblLoaiHang VALUES
	('LH01', N'Quần'),
	('LH02', N'Áo'),
	('LH03', N'Phụ Kiện')
GO
--tblNhaCungCap
INSERT INTO dbo.tblNhaCungCap VALUES
	(101, N'Taobao', N'Nhập hàng Taobao', N'Hà Nội', '0334455667'), 
	(102, N'Lazada', N'Nhập hàng Lazada', N'Đà Nẵng', '0334455668'),
	(103, N'Shopee', N'Nhập hàng Shopee', N'Hải Phòng', '0334455669'),
	(104, N'Tiki', N'Nhập hàng Tiki', N'TP. Hồ Chí Minh', '0334455670')
	GO
--tblKhachHang
INSERT INTO dbo.tblKhachHang VALUES
	(111, N'Trần Anh Vũ', N'Giáp Nhị, Hà Nội', '0112233445'),
	(112, N'Trần Thanh Tâm', N'Hoàng Mai, Hà Nội', '0112233446'),
	(113, N'Nguyễn Minh Tú', N'Minh Khai, Hà Nội', '0112233447'),
	(114, N'Đỗ Thu Phương', N'Giáp Bát, Hà Nội', '0112233448'),
	(115, N'Lê Văn Cương', N'Định Công, Hà Nội', '0112233449')
	GO
-- tblNhanVien
INSERT INTO dbo.tblNhanVien VALUES
	( N'Đỗ Thị Bích', N'Hoàng Mai, Hà Nội', '0123456781',	'1997/01/01', N'Nữ', '2020/02/26', 7050000, 1000000),
	( N'Đào Gia Bảo',	N'Cầu Giấy, Hà Nội', '0123456782', '1989/12/21', N'Nam', '2019/11/22',	10000000, 2000000),
	( N'Mai Thị Hà', N'Thanh Xuân, Hà Nội', '0123456783',	'1999/03/12', N'Nữ', '2021/04/02',	5500000, 450000),
	( N'Nguyễn Trường Giang', N'Cầu Giấy, Hà Nội', '0123456784',	'2000/07/15', N'Nam', '2020/07/03',	5000000, 500000),
	( N'Nguyễn Sơn Hà', N'Hai Bà Trưng, Hà Nội', '0123618701',	'1992/06/16', N'Nam', '2021/07/02', 4000000, 250000)
	GO
--tblMatHang
INSERT INTO dbo.tblMatHang VALUES
	('MH01', N'quan bo', 101, 'LH01', 400, 200000),
	('MH02', N'quan vai', 101, 'LH01', 350, 150000),
	('MH03', N'quan sooc', 102, 'LH01', 600, 120000),
	('MH04', N'ao len', 102, 'LH02', 200, 180000),
	('MH05', N'ao phong', 103, 'LH02', 800, 150000),
	('MH06', N'hoodie', 103, 'LH02', 250, 250000),
	('MH07', N'ao khoac', 102, 'LH02', 300, 300000),
	('MH08', N'kinh', 104, 'LH03', 200, 160000),
	('MH09', N'tui', 104, 'LH03', 300, 140000),
	('MH10', N'mu', 103, 'LH03', 500, 100000)
	GO
--tblDonNhapKho
INSERT INTO dbo.tblDonNhapKho VALUES
	(511, 1, '2020/01/23', 800),
	(512, 2, '2021/11/12', 500),
	(513, 3, '2021/04/25', 600),
	(514, 4, '2020/07/07', 900)
	GO
--tblChiTietNhapKho
INSERT INTO dbo.tblChiTietNhapKho VALUES
	(511, 'MH01', 120000, 300),
	(511, 'MH08', 90000, 150),
	(511, 'MH03', 80000, 350),
	(512, 'MH06', 180000, 200),
	(512, 'MH07', 220000, 300),
	(513, 'MH04', 110000, 100),
	(513, 'MH02', 70000, 250),
	(513, 'MH10', 40000, 250),
	(514, 'MH09', 60000, 250),
	(514, 'MH05', 60000, 650)
	GO
--tblDonDatHang
INSERT INTO dbo.tblDonDatHang VALUES
	(510, 1, 111, '2021/12/18', '2021/12/28', 700000),
	(520, 2, 112, '2021/12/20', '2021/12/30', 340000),
	(530, 3, 113, '2021/12/26', '2022/01/05', 300000),
	(540, 4, 114, '2022/01/10', '2022/01/20', 270000),
	(550, 5, 115, '2022/01/01', '2022/01/11', 800000)
	GO
--tblChiTietDatHang
INSERT INTO dbo.tblChiTietDatHang VALUES
	(510, 'MH02', 1, 0),
	(510, 'MH06', 1, 0),
	(510, 'MH07', 1, 0),
	(520, 'MH01', 2, 0),
	(520, 'MH09', 1, 0),
	(530, 'MH07', 1, 0),
	(540, 'MH03', 1, 0),
	(540, 'MH05', 1, 0),
	(550, 'MH04', 1, 0),
	(550, 'MH08', 2, 0),
	(550, 'MH10', 3, 0)
	GO
	--in bảng
	select*from tblLoaiHang
	select*from dbo.tblNhaCungCap
	select*from dbo.tblKhachHang
	select*from dbo.tblNhanVien
	select*from dbo.tblMatHang
	select*from dbo.tblDonNhapKho
	select*from dbo.tblDonDatHang
	select*from dbo.tblChiTietDatHang
	select*from tblChiTietNhapKho
	select tblDonDatHang.iMaNV, tblDonDatHang.iMaKH, tblChiTietDatHang.fGiaBan * tblChiTietDatHang.iSoLuongMua as [Tổng tiền]
	from tblDonDatHang, tblChiTietDatHang

	--insert into tblMatHang VALUES(N'MH11',N'quan dui', 101,N'LH01',100,600000);
	--delete from tblMatHang where sMaHang = N'MH11';
	--select * from tblNhanVien where sGioiTinh = N'Nữ'
	--select * from tblNhanVien where sTenNV like '%B%'
	GO;
	
	-- CREATE PROCEDURE --

	-- NHAN VIEN ---
	-- xem nhan vien
	create procedure xem_nv as
	select iMaNV as [Mã NV], sTenNV as [Họ và tên], sGioiTinh as [Giới tính], sDiaChi as [Địa chỉ], sDienThoai as [Số điện thoại],
	dNgaySinh as [Ngày sinh], dNgayVaoLam as [Ngày vào làm], fLuongCoBan as [Lương cơ bản], fPhuCap as [Phụ cấp]
	from tblNhanVien
	exec xem_nv
	GO;

	--them nhan vien
	create procedure them_nv @ten_nv nvarchar(30), @dia_chi nvarchar(30), 
	@sdt char(10), @ngay_sinh datetime, @gioi_tinh nvarchar(5), @ngay_vao_lam datetime, 
	@luong_co_ban float, @phu_cap float
	as
	INSERT INTO tblNhanVien (sTenNV, sDiaChi, sDienThoai, dNgaySinh, sGioiTinh, dNgayVaoLam, fLuongCoBan, fPhuCap)
	VALUES (@ten_nv, @dia_chi, @sdt, @ngay_sinh,@gioi_tinh, @ngay_vao_lam, @luong_co_ban, @phu_cap)
	GO

	-- xoa nhan vien
	create procedure xoa_nv @ma_nv int
	as
	delete from tblNhanVien where iMaNV=@ma_nv
	GO

	-- sua nhan vien
	create procedure sua_nv @ma_nv int, @ten_nv nvarchar(30), @dia_chi nvarchar(30), 
	@sdt char(10), @ngay_sinh datetime, @gioi_tinh nvarchar(5), @ngay_vao_lam datetime, 
	@luong_co_ban float, @phu_cap float
	as
	UPDATE tblNhanVien SET sTenNV=@ten_nv, sDiaChi=@dia_chi, 
	sDienThoai=@sdt, dNgaySinh=@ngay_sinh, sGioiTinh=@gioi_tinh, dNgayVaoLam=@ngay_vao_lam,
	fLuongCoBan=@luong_co_ban, fPhuCap=@phu_cap
	where iMaNV=@ma_nv
	GO;

	-- kiem tra nhan vien trung lap
	create proc kt_nv @ten_nv nvarchar(30), @dia_chi nvarchar(30), 
	@sdt char(10), @ngay_sinh datetime, @gioi_tinh nvarchar(5), 
	@ngay_vao_lam datetime, @luong_co_ban float, @phu_cap float
	as
	select * from tblNhanVien
	where sTenNV = @ten_nv and sDiaChi = @dia_chi and sDienThoai = @sdt 
	and dNgaySinh = @ngay_sinh and sGioiTinh = @gioi_tinh
	and dNgayVaoLam = @ngay_vao_lam and fLuongCoBan = @luong_co_ban and fPhuCap = @phu_cap
	GO;

	-- tim dia chi nhan vien
	alter proc tim_dia_chi_nv
	as
	select iMaNV as [Mã nhân viên], sTenNV as [Họ và tên], sDiaChi as [Địa chỉ], 
	dNgaySinh as [Ngày sinh], sGioiTinh as [Giới tính], fLuongCoBan as [Lương cơ bản]
	from tblNhanVien where sDiaChi like N'%Hà Nội%'
	exec tim_dia_chi_nv @diachi = N'Hà Nội'
	GO;

	--Số tiền mà nhân viên bán được và số hóa đơn đã xử lý 
	ALTER PROC spthongkebanhang_nhanvien (@many int) 
	AS BEGIN 
	SELECT tblDonDatHang.iMaNV,sTenNV,COUNT(tblDonDatHang.iSoHD) AS [So Hoa Don], 
	SUM(iSoLuongMua*fGiaHang-iSoLuongMua*fGiaHang*fMucGiamGia) AS [Tong tien] 
	FROM dbo.tblNhanVien,dbo.tblDonDatHang,dbo.tblChiTietDatHang, tblMatHang 
	WHERE dbo.tblNhanVien.iMaNV = dbo.tblDonDatHang.iMaNV 
	AND tblDonDatHang.iSoHD = tblChiTietDatHang.iSoHD 
	AND tblMatHang.sMaHang = tblChiTietDatHang.sMaHang
	AND tblNhanVien.iMaNV = @many 
	GROUP BY tblNhanVien.sTenNV, tblDonDatHang.iMaNV
	END
	EXEC spthongkebanhang_nhanvien 1

	create procedure thongkedoanhsobanhang_thang (@thang int, @nam int)
	as begin
	select tblDonDatHang.iMaNV, tblNhanVien.sTenNV, count(tblDonDatHang.iMaNV) as [So hoa don]
	from tblDonDatHang inner join tblNhanVien on tblDonDatHang.iMaNV=tblNhanVien.iMaNV
	where tblDonDatHang.iMaNV=1
	group by tblDonDatHang.iMaNV, tblNhanVien.sTenNV

	 --Tăng lương cơ bản cho nhân viên (x %) có lượng bán ra lớn hơn chỉ tiêu của một năm 
	CREATE PROC sptangluongcoban_nhanvien (@chitieu int, @nam int, @phantram float) 
	AS 
	BEGIN UPDATE dbo.tblNhanVien 
	SET fLuongCoBan = fLuongCoBan + fLuongCoBan * @phantram 
	WHERE iMaNV IN (SELECT dbo.tblNhanVien.iMaNV 
	FROM dbo.tblNhanVien, dbo.tblDonDatHang, dbo.tblChiTietDatHang 
	WHERE tblDonDatHang.iMaNV = tblNhanVien.iMaNV 
	AND tblDonDatHang.iSoHD = tblChiTietDatHang.iSoHD 
	AND YEAR(dNgayDatHang) = @nam 
	GROUP BY tblNhanVien.iMaNV 
	HAVING SUM (iSoLuongMua) > @chitieu)
	EXEC sptangluongcoban_nhanvien 11,2020,0.1

	 -- Tong tien ban dc trong 1 thang
	CREATE PROC sptongtienhangban_thang (@thang int, @nam int) AS BEGIN 
	SELECT @thang AS[Thang], SUM (fGiaBan*iSoLuongMua - fGiaBan*iSoLuongMua*fMucGiamGia) AS [Tong tien] 
	FROM dbo.tblDonDatHang, dbo.tblChiTietDatHang WHERE tblDonDatHang.iSoHD = tblDonDatHang.iSoHD 
	AND MONTH(dNgayGiao Hang) = @thang 
	AND YEAR(dNgayGiao Hang) = @nam 
	GROUP BY MONTH(dNgayGiao Hang), YEAR(dNgayGiao Hang) 
	END EXEC sptongtienhangban_thang 3,2020



	-- NHA CUNG CAP ---
	-- xem nha cung cap
	create procedure xem_ncc as
	select iMaNCC as [Mã NCC], sTenNhaCC as [Tên nhà cung cấp], sTenGiaoDich as [Tên giao dịch], 
	sDiaChi as [Địa chỉ], sDienThoai as [Số điện thoại]
	from tblNhaCungCap
	exec xem_ncc
	GO;

	-- kiem tra nha cung cap trung lap
	create proc kt_ncc @ma_ncc int ,@ten_ncc nvarchar(30), @ten_giao_dich nvarchar(50), 
	@dia_chi nvarchar(50), @sdt char(10)
	as
	select * from tblNhaCungCap
	where iMaNCC=@ma_ncc and sTenNhaCC=@ten_ncc and sTenGiaoDich=@ten_giao_dich and sDiaChi=@dia_chi and sDienThoai=@sdt
	GO;

	--them nha cung cap
	create procedure them_ncc @ma_ncc int, @ten_ncc nvarchar(30), 
	@ten_giao_dich nvarchar(50), @dia_chi nvarchar(50), @sdt char(10)
	as
	INSERT INTO tblNhaCungCap(iMaNCC, sTenNhaCC, sTenGiaoDich, sDiaChi, sDienThoai)
	VALUES (@ma_ncc, @ten_ncc, @ten_giao_dich, @dia_chi, @sdt)
	GO;

	-- sua nha cung cap
	create procedure sua_ncc @ma_ncc int, @ten_ncc nvarchar(30), 
	@ten_giao_dich nvarchar(50), @dia_chi nvarchar(50), @sdt char(10)
	as
	UPDATE tblNhaCungCap SET sTenNhaCC=@ten_ncc, sTenGiaoDich=@ten_giao_dich, sDiaChi=@dia_chi, 
	sDienThoai=@sdt
	where iMaNCC=@ma_ncc
	GO;

	-- xoa nha cung cap
	create procedure xoa_ncc @ma_ncc int
	as
	delete from tblNhaCungCap where iMaNCC=@ma_ncc
	GO;

	--- KHACH HANG ---
	-- xem khach hang
	create procedure xemKH as
	select iMaKH, sTenKH, sDienThoai, sDiaChi 
	from tblKhachHang
	exec xemKH
	GO;

	--them khach hang
	create procedure ThemKhachhang (@ma_kh int, @ten_kh nvarchar(30), @dia_chi nvarchar(50), @sdt char(10))
	as
	INSERT INTO tblKhachHang (iMaKH, sTenKH, sDiaChi, sDienThoai)
	VALUES (@ma_kh, @ten_kh,@dia_chi,@sdt)
	exec ThemKhachhang '120', 'do thi hue', 'hung yen', '0969972712'
	GO

	-- xoa khach hang
	create procedure xoa_kh @ma_kh int
	as
	delete from tblKhachHang where iMaKH=@ma_kh
	exec xoa_kh '120'
	GO

	-- sua khach hang
	create procedure sua_kh (@ma_kh int, @ten_kh nvarchar(30), @dia_chi nvarchar(50), @sdt char(10))
	as
	UPDATE tblKhachHang SET sTenKH=@ten_kh, sDiaChi=@dia_chi, sDienThoai=@sdt
	where iMaKH=@ma_kh
	GO;

	-- kiem tra khach hang trung lap
	create proc kiemtra_kh (@ma_kh int, @ten_kh nvarchar(30), @dia_chi nvarchar(50), @sdt char(10))
	as
	select * from tblKhachHang
	where iMaKH=@ma_kh and sTenKH = @ten_kh and sDiaChi = @dia_chi and sDienThoai = @sdt 

	-- tim dia chi khach hang
	create proc tim_dia_chi_kh
	as
	select iMaKH, sTenKH, sDiaChi
	from tblKhachHang where sDiaChi like N'%Hà Nội%'
	exec tim_dia_chi_kh @diachi = N'Hà Nội'
	GO;

	--- MAT HANG ---
	-- xem mat hang
	alter procedure xem_mh 
	as
	select * from tblMatHang where fSoLuong>0
	exec xemKH
	GO;

	-- kiem tra mat hang trung lap
	create proc kt_mh @ma_mh nvarchar(20), @ten_mh nvarchar(30), @ma_ncc int, @ma_loaihang nvarchar(20)
	as
	select * from tblMatHang
	where sMaHang=@ma_mh and sTenHang=@ten_mh and iMaNCC=@ma_ncc and sMaLoaiHang=@ma_loaihang
	GO;

	-- them mat hang
	create procedure them_mh @ma_mh nvarchar(20), @ten_mh nvarchar(30), @ma_ncc int, @ma_loaihang nvarchar(20),
					@so_luong float, @gia_hang float		
	as
	INSERT INTO tblMatHang (sMaHang, sTenHang, iMaNCC, sMaLoaiHang, fSoLuong, fGiaHang)
	VALUES (@ma_mh, @ten_mh, @ma_ncc, @ma_loaihang, @so_luong, @gia_hang)
	GO;

	-- sua mat hang
	create procedure sua_mh @ma_mh nvarchar(20), @ten_mh nvarchar(30), @ma_ncc int, @ma_loaihang nvarchar(20),
					@so_luong float, @gia_hang float	
	as
	UPDATE tblMatHang SET sTenHang=@ten_mh, iMaNCC=@ma_ncc, sMaLoaiHang=@ma_loaihang, fSoLuong=@so_luong, fGiaHang=@gia_hang 
	WHERE sMaHang=@ma_mh
	GO;

	-- xoa mat hang
	create procedure xoa_mh @ma_mh nvarchar(20)
	as
	delete from tblMatHang where sMaHang=@ma_mh
	GO;

	-- cap nhat so luong mat hang
	create procedure capnhat_sl_mh @ma_mh nvarchar(20), @so_luong_mua float
	as
	UPDATE tblMatHang SET fSoLuong= fSoLuong-@so_luong_mua 
	WHERE sMaHang=@ma_mh
	GO;

	--- DON DAT HANG ---
	-- xem don dat hang
	create procedure xem_ddh as
	select * from tblDonDatHang
	exec xem_ddh
	GO;

	-- them don dat hang
	create procedure them_ddh @so_hd int, @ma_nv int, @ma_kh int, @ngay_dat_hang datetime, 
							@ngay_giao_hang datetime
	as
	BEGIN
	INSERT INTO tblDonDatHang
	VALUES (@so_hd, @ma_nv, @ma_kh, @ngay_dat_hang, @ngay_giao_hang, 1);
	END
	exec them_ddh @so_hd=560, @ma_nv=1, @ma_kh=111, @ngay_dat_hang = '2021-12-18', 
							@ngay_giao_hang = '2022-01-01'
	GO;

	-- them tong tien cho don dat hang
	alter proc them_tongtienddh @so_hd int, @tong_tien float
	as
	BEGIN
	set @tong_tien = 
	(select sum(tblChiTietDatHang.iSoLuongMua*tblMatHang.fGiaHang) as [Thành tiền]
	from tblChiTietDatHang inner join tblMatHang on tblChiTietDatHang.sMaHang = tblMatHang.sMaHang
	inner join tblDonDatHang on tblChiTietDatHang.iSoHD=tblDonDatHang.iSoHD
	where tblDonDatHang.iSoHD = @so_hd);

	UPDATE tblDonDatHang SET fTongTienHD=@tong_tien where iSoHD=@so_hd
	SELECT fTongTienHD from tblDonDatHang where iSoHD=@so_hd
	END
	exec them_tongtienddh @so_hd=560, @tong_tien=1
	select * from tblDonDatHang
	select * from tblChiTietDatHang

	--- CHI TIET DAT HANG ---
	-- xem chi tiet dat hang bang ma hoa don
	create procedure xem_ctddh @ma_ddh int
	as
	select tblChiTietDatHang.sMaHang, tblMatHang.sTenHang, tblMatHang.fGiaHang, 
			tblChiTietDatHang.iSoLuongMua, tblChiTietDatHang.fMucGiamGia
	from  tblChiTietDatHang 
	inner join tblDonDatHang on  tblChiTietDatHang.iSoHD = tblDonDatHang.iSoHD
	inner join tblMatHang on tblChiTietDatHang.sMaHang = tblMatHang.sMaHang
	where tblDonDatHang.iSoHD = @ma_ddh
	exec xem_ctddh
	GO;

	-- them chi tiet dat hang
	create procedure them_ctddh @so_hd int, @ma_mh nvarchar(15), @so_luong_mua int	
	as
	INSERT INTO tblChiTietDatHang VALUES (@so_hd, @ma_mh, @so_luong_mua, 0);

	exec them_ctddh @so_hd=560, @ma_mh=N'MH01', @so_luong_mua=5
	GO;


	--- DON NHAP KHO ---
	--xem donnk
	create procedure xem_donnk as
	select *
	from tblDonNhapKho
	exec xem_donnk
	
	--them don nk
	create procedure them_dnk @snk int, @ma_nv int, 
	@ngaynhaphang date, @soluongnhap float, @gianhap float
	as
	INSERT INTO tblDonNhapKho(iSoNK, iMaNV, dNgayNhapHang, fSoLuongNhap, fGiaNhap)
	VALUES (@snk,@ma_nv,@ngaynhaphang,@soluongnhap, @gianhap)
	GO
	select * from tblDonNhapKho
	-- xoa donnk
	create procedure xoa_donnk @ma_dnk int
	as
	delete from tblDonNhapKho where iSoNK=@ma_dnk

	--sua donnk
	create procedure sua_donnk @snk int, @ma_nv int, 
	@ngaynhaphang date, @soluongnhap float, @gianhap float
	as 
	UPDATE tblDonNhapKho SET iMaNV=@ma_nv, dNgayNhapHang=@ngaynhaphang, fSoLuongNhap=@soluongnhap, fGiaNhap= @gianhap
	where iSoNK=@snk