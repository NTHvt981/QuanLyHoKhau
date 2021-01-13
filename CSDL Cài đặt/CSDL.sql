create database HoKhau

use master
go
drop database HoKhau
go

use HoKhau
go
create table CMND (
	Ma int primary key identity(1, 1),
	SoCmnd nvarchar(9) not null,
	HoTen nvarchar(50) not null,
	NgaySinh date,
	QueQuan nvarchar(500),
	DiaChiHoKhau nvarchar(500),
	DanToc nvarchar(50),
	TonGiao nvarchar(50),
	DacDiemNhanDang nvarchar(50),
	NgayCap date,
	NoiCap nvarchar(500),
	NguoiCap nvarchar(50)

	--Constraints
	unique(SoCmnd),
);

create table CCCD (
	Ma int primary key identity(1, 1),
	SoCccd nvarchar(13) not null,
	HoTen nvarchar(50) not null,
	NgaySinh date,
	GioiTinh nvarchar(50),
	QueQuan nvarchar(500),
	QuocTich nvarchar(50),
	DiaChiHoKhau nvarchar(500),
	ThoiHan date,
	DacDiemNhanDang nvarchar(50),
	NgayCap date,
	NoiCap nvarchar(500),
	NguoiCap nvarchar(50),

	--Constraints
	unique(SoCccd)
);

create table HO_KHAU (
	Ma int primary key identity(1, 1),
	SoSo nvarchar(50) not null,
	ChuHo nvarchar(50) not null,
	DiaChi nvarchar(500) not null,
	NgayLap date,
	LoaiSo nvarchar(50),
	LyDoLap nvarchar(100),
	NguoiLam nvarchar(50),

	--Constraints
	unique(SoSo)
);

create table CONG_DAN (
	Ma int primary key identity(1, 1),
	SoCmnd nvarchar(9),
	SoCccd nvarchar(13),
	MaHoKhau nvarchar(50),
	HoTen nvarchar(50) not null,
	NgaySinh date,
	GioiTinh nvarchar(50),
	QueQuan nvarchar(500),
	QuocTich nvarchar(50),
	DiaChiThuongTru nvarchar(500),
	HoTenBo nvarchar(50),
	HoTenMe nvarchar(50),

	--Constraints
	foreign key (SoCmnd) references CMND(SoCmnd), 
	foreign key (SoCccd) references CCCD(SoCccd),
	foreign key (MaHoKhau) references HO_KHAU(SoSo),
	constraint CONG_DAN_NOT_BOTH check (not ([SoCmnd]<>N'' and [SoCccd]<>N''))
);

CREATE UNIQUE INDEX cmnd_unique
  ON [CONG_DAN](SoCmnd)
  WHERE SoCmnd IS NOT NULL
CREATE UNIQUE INDEX cccd_unique
  ON [CONG_DAN](SoCccd)
  WHERE SoCccd IS NOT NULL

create table PHIEU_TAM_VANG (
	Ma int primary key identity(1, 1),
	SoCmndCccd nvarchar(50) not null,
	NguoiKhaiBao nvarchar(50) not null,
	NgheNghiep nvarchar(50),
	NoiLamViec nvarchar(500),
	ThoiGianBatDau date not null,
	ThoiGianKetThuc date not null,
	NoiTamTru nvarchar(500),
	LyDo nvarchar(500),
	QuanHeChuHo nvarchar(50),
	SoNha nvarchar(50),
	DanhSachTreEm nvarchar(500),
	NgayKhaiBao date,
	TenCanBo nvarchar(50),

	constraint PTV_TG_1 check (ThoiGianKetThuc >= ThoiGianBatDau),
	constraint PTV_TG_2 check (NgayKhaiBao <= ThoiGianBatDau)
);

create table PHIEU_TAM_TRU (
	Ma int primary key identity(1, 1),
	NguoiKhaiBao nvarchar(50),
	NoiTamTru nvarchar(500),
	LyDo nvarchar(500),
	NgayGhi date,
	NoiGhi nvarchar(500),
	TenCanBo nvarchar(50)
);

create table PHIEU_THAY_DOI_HO_KHAU (
	Ma int primary key identity(1, 1),
	MaHoKhau nvarchar(50) not null,
	SoCmndCccd nvarchar(50) not null,
	HoTen nvarchar(50) not null,
	ChuHo nvarchar(50),
	SoHoSo nvarchar(50),
	TenThuongGoi nvarchar(50),
	NgaySinh date,
	QueQuan nvarchar(500),
	QuocTich nvarchar(50),
	DiaChiHoKhau nvarchar(500),
	DacDiemNhanDang nvarchar(50),
	DanToc nvarchar(50),
	TonGiao nvarchar(50),
	NgheNghiep nvarchar(50),
	NoiOHienNay nvarchar(500),
	NgayCap date,
	NoiCap nvarchar(500),
	NguoiCap nvarchar(50)
);

create table BAN_KHAI_NHAN_KHAU (
	Ma int primary key identity(1, 1),
	SoCmndCccd nvarchar(50) not null,
	HoTen nvarchar(50) not null,
	ChuHo nvarchar(50),
	SoHoSo nvarchar(50),
	TenThuongGoi nvarchar(50),
	NgaySinh date,
	QueQuan nvarchar(500),
	DiaChiHoKhau nvarchar(500),
	DanToc nvarchar(50),
	DacDiemNhanDang nvarchar(50),
	NgheNghiep nvarchar(50),
	ChuyenMon nvarchar(50),
	TrinhDoHocVan nvarchar(50),
	BietTiengDanToc nvarchar(50),
	TrinhDoNgoaiNgu nvarchar(50),
	NoiOHienNay nvarchar(500),
	DanhSachNguoiCungDi nvarchar(500),
	NgayCap date,
	NoiCap nvarchar(500),
	NguoiCap nvarchar(50),
	DanhSachKhenThuong nvarchar(500),
	DanhSachTienAn nvarchar(500),
	DanhSachQuanHeGiaDinh nvarchar(500)
);
go
