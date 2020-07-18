create database hihi
go
use hihi
go
create table NhaCungCap (
Ma int primary key,
Ten  nvarchar (1000) not null,
DiaChi nvarchar (1000) not null,
SoDienThoai nchar (1000) not null
)
go
create table ChucVu(
Ma int primary key,
Ten nvarchar (1000)
)
go
create table NhanVien(
Ma int primary key,
Ten nvarchar (1000),
GioiTinh nvarchar (1000),
DiaChi nvarchar (1000),
Email nchar (1000),
NgaySinh date,
NgayVaoLam date,
Ma_CV int,
taikhoan nchar (1000),
matkhau nchar (1000),
Hinhanh image, 
HoatDong bit
)
go	
create table HDNhap (
Ma int primary key,
Ma_NCC int not null,
Ma_NV int,
NgayNhap date,
TongTien int
)
go
create table LoaiSP(
Ma int primary key,
Ten nvarchar (1000)
)
go
create table SanPham(
Ma int primary key,
Ma_LoaiSP int,
Ten nvarchar (1000) not null,
DonGia int not null, 
HinhAnh image
)

go
create table Size (
Ma int primary key,
TenSize nvarchar (1000) not null,
Ma_LoaiSP int,
)
go
create table MauSac(
Ma int primary key,
TenMau nvarchar (1000) not null
)
go
create table CTSanPham(
Ma_SP int,
Ma_Size int,
Ma_MauSac int,
Soluong int,
primary key (Ma_SP, Ma_Size, Ma_MauSac)
)
go
create table CTHDNhap(
Ma_HDN int ,
Ma_SP int not null,
Ma_Size int,
Ma_MauSac int,
Soluong int,
DonGia int,
ThanhTien int,
primary key (Ma_HDN, Ma_SP, Ma_Size, Ma_Mausac)
)

go
create table KhachHang(
Ma int primary key,
Ten nvarchar (1000),
Email nvarchar (1000),
DiaChi nvarchar (1000),
SoDienThoai nvarchar (1000),
DiemTichLuy int,
Ma_LoaiKH int
)
go
create table LoaiKH(
Ma int primary key,
Ten nvarchar (1000),
TiLeGiamGia float
)
go
create table HDXuat(
Ma int primary key,
Ma_KH int,
Ma_NV int,
NgayXuat date,
TongTien int,
TrangThai bit,
GhiChu nvarchar (1000),
MaQR image
)


go
create table CTHDXuat(
Ma_HDX int ,
Ma_SP int,
Ma_Size int,
Ma_MauSac int,
SoLuong int,
ThanhTien int
primary key (Ma_HDX, Ma_SP, Ma_Size, Ma_MauSac)
)
go

create table ad(
Ma int identity (1,1) primary key,
TaiKhoan nchar(1000),
MatKhau nchar (1000)
)
go
create table Email (
Ma int  primary key,
TaiKhoan nvarchar (1000),
MatKhau nvarchar (1000))
go

alter table HDNhap add foreign key (Ma_NCC) references NhaCungCap (Ma)
alter table HDNhap add foreign key (Ma_NV) references NhanVien(Ma)


alter table CTHDNhap add foreign key (Ma_HDN) references HDNhap (Ma)
alter table CTHDNhap add foreign key (Ma_SP) references SanPham (Ma)
alter table CTHDNhap add foreign key (Ma_Size) references Size (Ma)
alter table CTHDNhap add foreign key (Ma_MauSac) references MauSac (Ma)


alter table SanPham add foreign key (Ma_LoaiSP) references LoaiSP (Ma)

alter table NhanVien add foreign key (Ma_CV) references ChucVu (Ma)
alter table CTSanPham add foreign key (Ma_SP) references SanPham (Ma)
alter table CTSanPham add foreign key (Ma_Size) references Size (Ma)
alter table CTSanPham add foreign key (Ma_Mausac) references MauSac (Ma)
alter table KhachHang add foreign key (Ma_LoaiKH) references LoaiKH (Ma)
alter table HDXuat add foreign key (Ma_KH) references KhachHang (Ma)
alter table HDXuat add foreign key (Ma_NV) references NhanVien (Ma)
alter table CTHDXuat add foreign key (Ma_HDX) references HDXuat (Ma)
alter table CTHDXuat add foreign key (Ma_SP) references SanPham (Ma)
alter table CTHDXuat add foreign key (Ma_Size) references Size (Ma)
alter table CTHDXuat add foreign key (Ma_MauSac) references MauSac (Ma)

alter table Size add foreign key (Ma_LoaiSP) references LoaiSP(Ma)
go
delete from CTSanPham where Ma_SP >=7

insert into LoaiSP values (1, N'Áo thể thao')
insert into LoaiSP values (2, N'Quần thể thao')
insert into LoaiSP values (3, N'Giày thể thao')
insert into LoaiSP values (4, N'Đồ bộ')
go

insert into NhaCungCap  values (1,N'Nike', N'Quận 3', N'01252655')
insert into NhaCungCap  values (2,N'Convert', N'Lào', N'0841256')
insert into NhaCungCap  values (3,N'Gucci', N'CamPuChia', N'01235411')
insert into NhaCungCap  values (4,N'Chanel', N'Vũ Hán', N'098765432')
insert into NhaCungCap  values (5,N'Balenciaga', N'Long An', N'012857451')
insert into NhaCungCap  values (6,N'Bitis', N'Quận 9', N'01456789')
insert into NhaCungCap  values (7,N'Hehe', N'Quận 8', N'08100555')
insert into NhaCungCap  values (8,N'Hihi', N'Đông Ti mo', N'0951065')
insert into NhaCungCap  values (9,N'Huhu', N'Mỹ', N'0869125')
insert into NhaCungCap  values (10,N'Hoho', N'Úc', N'012510054')
go

insert into Size values (1,N'S', 1)
insert into Size values (2,N'M', 1)
insert into Size values (3,N'L', 1)
insert into Size values (4,N'XL', 1)
insert into Size values (5,N'XXL', 1)
insert into Size values (6,N'XXXL', 1)

insert into Size values (7,N'27', 2)
insert into Size values (8,N'28', 2)
insert into Size values (9,N'29', 2)
insert into Size values (10,N'30', 2)
insert into Size values (11,N'31', 2)
insert into Size values (12,N'32', 2)
insert into Size values (13,N'33', 2)

insert into Size values (14,N'36', 3)
insert into Size values (15,N'37', 3)
insert into Size values (16,N'38', 3)
insert into Size values (17,N'39', 3)
insert into Size values (18,N'40', 3)
insert into Size values (19,N'41', 3)
insert into Size values (20,N'42', 3)
insert into Size values (21,N'43', 3)

insert into Size values (22,N'36', 4)
insert into Size values (23,N'37', 4)
insert into Size values (24,N'38', 4)
insert into Size values (25,N'39', 4)
insert into Size values (26,N'40', 4)
insert into Size values (27,N'41', 4)
insert into Size values (28,N'42', 4)
insert into Size values (29,N'43', 4)
go

insert into MauSac values (1, N'Đen')
insert into MauSac values (2, N'Trắng')
insert into MauSac values (3, N'Vàng')
insert into MauSac values (4, N'Đỏ')
insert into MauSac values (5, N'Xanh')
insert into MauSac values (6, N'Hồng')
go

insert into ChucVu values (1,N'Quản Lý')
insert into ChucVu values (2,N'Nhân viên bán hàng')
insert into ChucVu values (3,N'Kế toán')
go

insert into LoaiKH values (1, N'Bạc', 0)
insert into LoaiKH values (2, N'Vàng', 3)
insert into LoaiKH values (3, N'Bạch Kim', 5)
go

insert into NhanVien values (1, N'Nam', N'Nam', N'Quận 9',N'dhv0612@gmail.com', '1990-02-02', '2019-02-10', 1,  N'admin', N'202cb962ac59075b964b07152d234b70', Null, 1)
insert into NhanVien values (2, N'Linh', N'Nữ', N'Quận 8',N'dhv0612@gmail.com', '1990-02-02', '2019-02-10', 2,  N'admin1', N'202cb962ac59075b964b07152d234b70', NULL,1)
insert into NhanVien values (3, N'Bi', N'Nữ', N'Quận 7',N'dhv0612@gmail.com', '1990-02-02', '2019-02-10', 2,  N'admin2', N'202cb962ac59075b964b07152d234b70', NULL,1)
insert into NhanVien values (4, N'Tèo', N'Nam', N'Quận 6',N'dhv0612@gmail.com', '1990-02-02', '2019-02-10', 2,  N'admin3', N'202cb962ac59075b964b07152d234b70',NULL,1)
insert into NhanVien values (5, N'Tòe', N'Nam', N'Quận 5',N'dhv0612@gmail.com', '1990-02-02', '2019-02-10', 3,  N'admin4', N'202cb962ac59075b964b07152d234b70', NULL,1)
insert into NhanVien values (6, N'Trang', N'Nữ', N'Quận 4',N'dhv0612@gmail.com', '1990-02-02', '2019-02-10', 3,  N'admin5', N'202cb962ac59075b964b07152d234b70', NULL,1)
insert into NhanVien values (7, N'Nhung', N'Nữ', N'Quận 3',N'dhv0612@gmail.com', '1990-02-02', '2019-02-10', 2,  N'admin6', N'202cb962ac59075b964b07152d234b70', NULL,1)
insert into NhanVien values (8, N'Quang', N'Nam', N'Quận 2',N'dhv0612@gmail.com', '1990-02-02', '2019-02-10', 3,  N'admin7', N'202cb962ac59075b964b07152d234b70', NULL,1)
insert into NhanVien values (9, N'Như', N'Nữ', N'Quận 1',N'dhv0612@gmail.com', '1990-02-02', '2019-02-10', 1,  N'admin8', N'202cb962ac59075b964b07152d234b70', NULL,1)
insert into NhanVien values (10 , N'Nữ', N'Nữ', N'Quận 0',N'dhv0612@gmail.com', '1990-02-02', '2019-02-10', 1,  N'admin9', N'202cb962ac59075b964b07152d234b70', NULL,1)
go

insert into SanPham values (1, 1, N'Áo thể thao trơn', 57000, NULL)
insert into SanPham values (2, 1, N'Áo thể thao adidas', 72000,  NULL)
insert into SanPham values (3, 1, N'Áo thể thao ba lá', 44000,  NULL)
insert into SanPham values (4, 1, N'Áo thể thao tập gym', 60000,  NULL)
insert into SanPham values (5, 1, N'Áo thể thao dhv', 120000,  NULL)
insert into SanPham values (6, 1, N'Áo thể thao Vshop', 113000,  NULL) 
insert into SanPham values (7, 1, N'Áo thể thao Yonex chấm bi', 120000, NULL)
insert into SanPham values (8, 1, N'Áo thể thao cầu lông có cổ', 73000,  NULL)
insert into SanPham values (9, 1, N'Áo thể thao dập vân chìm', 390000,  NULL)
insert into SanPham values (10, 1, N'Áo thể thao xách nách', 450000,  NULL)

insert into SanPham values (11, 2, N'Quần thể thao 3 sọc', 750000,  NULL)
insert into SanPham values (12, 2, N'Quần thể thao phản quang', 640000,  NULL)
insert into SanPham values (13, 2, N'Quần thể thao adidas', 930000, NULL)
insert into SanPham values (14, 2, N'Quần đùi adidas', 450000,  NULL)
insert into SanPham values (15, 2, N'Quần dệt tập gym', 840000, NULL)
insert into SanPham values (16, 2, N'Quần đùi thể thao gió', 950000,  NULL)
insert into SanPham values (17, 2, N'Quần thể thao Jogger', 1250000,  NULL)
insert into SanPham values (18, 2, N'Quần short thể thao rút dây', 990000, NULL)
insert into SanPham values (19, 2, N'Quần thể thao bom chun', 125000, NULL)
insert into SanPham values (20, 2, N'Quần Baggy cạp cúc', 1050000, NULL)

insert into SanPham values (21, 3, N'Giày Sneaker Nite Jogger', 5850000, NULL)
insert into SanPham values (22, 3, N'Giày thể thao dây buộc đinh 3 màu', 2510000, NULL)
insert into SanPham values (23, 3, N'Giày thể thao SSIL có lưới', 2190000, NULL)
insert into SanPham values (24, 3, N'Giày thể thao ulzzang', 3550000, NULL)
insert into SanPham values (25, 3, N'Giày thể thao sneaker', 3150000, NULL)
insert into SanPham values (26, 3, N'Giày thể thao Trường Sơn', 650000, NULL)
insert into SanPham values (27, 3, N'Giày thể thao Bitis', 1050000,  NULL)
insert into SanPham values (28, 3, N'Giày thể thao Camo', 250000, NULL)
insert into SanPham values (29, 3, N'Giầy thể thao kẻ đen Uzulang', 3750000, NULL)
insert into SanPham values (30, 3, N'Giày thể thao nam MRENG MS21', 155000, NULL)

insert into SanPham values (31, 4, N'Bộ quần áo thể thao dập vân logo PM', 155000, NULL)
insert into SanPham values (32, 4, N'Bộ quần áo thể thao chạy viền', 355000, NULL)
insert into SanPham values (33, 4, N'Bộ thun đồ bộ thể thao 3 sọc', 95000, NULL)
insert into SanPham values (34, 4, N'Bộ quần áo thể thao cộc tay, cổ bẻ', 195000, NULL)
insert into SanPham values (35, 4, N'Bộ đồ thể thao cộc tay againt', 132000, NULL)
insert into SanPham values (36, 4, N'Bộ thể thao cộc tay Trend Up', 92000, NULL)
insert into SanPham values (37, 4, N'Đồ bộ thun da cá đẹp', 205000, NULL)
insert into SanPham values (38, 4, N'Đồ bộ thể thao trắng', 132000, NULL)
insert into SanPham values (39, 4, N'Đồ bộ puma', 92000, NULL)
insert into SanPham values (40, 4, N'Đồ bộ thể thao chấm bi', 95000, NULL)
go

insert into CTSanPham values (1, 1, 1, 1)
insert into CTSanPham values (1, 1, 2, 2)
insert into CTSanPham values (1, 1, 3, 3)
insert into CTSanPham values (1, 1, 4, 4)
insert into CTSanPham values (1, 1, 5, 1)
insert into CTSanPham values (1, 1, 6, 2)

insert into CTSanPham values (1, 2, 1, 3)
insert into CTSanPham values (1, 2, 2, 4)
insert into CTSanPham values (1, 2, 3, 1)
insert into CTSanPham values (1, 2, 4, 2)
insert into CTSanPham values (1, 2, 5, 3)
insert into CTSanPham values (1, 2, 6, 3)

insert into CTSanPham values (1, 3, 1, 4)
insert into CTSanPham values (1, 3, 2, 1)
insert into CTSanPham values (1, 3, 3, 2)
insert into CTSanPham values (1, 3, 4, 3)
insert into CTSanPham values (1, 3, 5, 4)
insert into CTSanPham values (1, 3, 6, 1)

insert into CTSanPham values (1, 4, 1, 2)
insert into CTSanPham values (1, 4, 2, 3)
insert into CTSanPham values (1, 4, 3, 4)
insert into CTSanPham values (1, 4, 4, 1)
insert into CTSanPham values (1, 4, 5, 2)
insert into CTSanPham values (1, 4, 6, 3)

insert into CTSanPham values (1, 5, 1, 4)
insert into CTSanPham values (1, 5, 2, 1)
insert into CTSanPham values (1, 5, 3, 2)
insert into CTSanPham values (1, 5, 4, 3)
insert into CTSanPham values (1, 5, 5, 4)
insert into CTSanPham values (1, 5, 6, 1)

insert into CTSanPham values (1, 6, 1, 1)
insert into CTSanPham values (1, 6, 2, 2)
insert into CTSanPham values (1, 6, 3, 3)
insert into CTSanPham values (1, 6, 4, 4)
insert into CTSanPham values (1, 6, 5, 1)
insert into CTSanPham values (1, 6, 6, 2)

insert into CTSanPham values (2, 1, 1, 3)
insert into CTSanPham values (2, 1, 2, 4)
insert into CTSanPham values (2, 1, 3, 1)
insert into CTSanPham values (2, 1, 4, 2)
insert into CTSanPham values (2, 1, 5, 3)
insert into CTSanPham values (2, 1, 6, 4)

insert into CTSanPham values (2, 2, 1, 1)
insert into CTSanPham values (2, 2, 2, 2)
insert into CTSanPham values (2, 2, 3, 3)
insert into CTSanPham values (2, 2, 4, 4)
insert into CTSanPham values (2, 2, 5, 1)
insert into CTSanPham values (2, 2, 6, 2)

insert into CTSanPham values (2, 3, 1, 3)
insert into CTSanPham values (2, 3, 2, 4)
insert into CTSanPham values (2, 3, 3, 1)
insert into CTSanPham values (2, 3, 4, 2)
insert into CTSanPham values (2, 3, 5, 3)
insert into CTSanPham values (2, 3, 6, 4)

insert into CTSanPham values (2, 4, 1, 1)
insert into CTSanPham values (2, 4, 2, 2)
insert into CTSanPham values (2, 4, 3, 3)
insert into CTSanPham values (2, 4, 4, 4)
insert into CTSanPham values (2, 4, 5, 1)
insert into CTSanPham values (2, 4, 6, 2)

insert into CTSanPham values (2, 5, 1, 3)
insert into CTSanPham values (2, 5, 2, 4)
insert into CTSanPham values (2, 5, 3, 1)
insert into CTSanPham values (2, 5, 4, 2)
insert into CTSanPham values (2, 5, 5, 3)
insert into CTSanPham values (2, 5, 6, 4)

insert into CTSanPham values (2, 6, 1, 1)
insert into CTSanPham values (2, 6, 2, 2)
insert into CTSanPham values (2, 6, 3, 3)
insert into CTSanPham values (2, 6, 4, 4)
insert into CTSanPham values (2, 6, 5, 1)
insert into CTSanPham values (2, 6, 6, 2)

insert into CTSanPham values (3, 1, 1, 3)
insert into CTSanPham values (3, 1, 2, 4)
insert into CTSanPham values (3, 1, 3, 1)
insert into CTSanPham values (3, 1, 4, 2)
insert into CTSanPham values (3, 1, 5, 3)
insert into CTSanPham values (3, 1, 6, 4)

insert into CTSanPham values (3, 2, 1, 1)
insert into CTSanPham values (3, 2, 2, 2)
insert into CTSanPham values (3, 2, 3, 3)
insert into CTSanPham values (3, 2, 4, 4)
insert into CTSanPham values (3, 2, 5, 1)
insert into CTSanPham values (3, 2, 6, 2)

insert into CTSanPham values (3, 3, 1, 3)
insert into CTSanPham values (3, 3, 2, 4)
insert into CTSanPham values (3, 3, 3, 1)
insert into CTSanPham values (3, 3, 4, 2)
insert into CTSanPham values (3, 3, 5, 3)
insert into CTSanPham values (3, 3, 6, 4)

insert into CTSanPham values (3, 4, 1, 1)
insert into CTSanPham values (3, 4, 2, 2)
insert into CTSanPham values (3, 4, 3, 3)
insert into CTSanPham values (3, 4, 4, 4)
insert into CTSanPham values (3, 4, 5, 1)
insert into CTSanPham values (3, 4, 6, 2)

insert into CTSanPham values (3, 5, 1, 3)
insert into CTSanPham values (3, 5, 2, 4)
insert into CTSanPham values (3, 5, 3, 1)
insert into CTSanPham values (3, 5, 4, 2)
insert into CTSanPham values (3, 5, 5, 3)
insert into CTSanPham values (3, 5, 6, 4)

insert into CTSanPham values (3, 6, 1, 1)
insert into CTSanPham values (3, 6, 2, 2)
insert into CTSanPham values (3, 6, 3, 3)
insert into CTSanPham values (3, 6, 4, 1)
insert into CTSanPham values (3, 6, 5, 2)
insert into CTSanPham values (3, 6, 6, 3)

insert into CTSanPham values (4, 1, 1, 4)
insert into CTSanPham values (4, 1, 2, 1)
insert into CTSanPham values (4, 1, 3, 2)
insert into CTSanPham values (4, 1, 4, 3)
insert into CTSanPham values (4, 1, 5, 4)
insert into CTSanPham values (4, 1, 6, 1)

insert into CTSanPham values (4, 2, 1, 2)
insert into CTSanPham values (4, 2, 2, 3)
insert into CTSanPham values (4, 2, 3, 4)
insert into CTSanPham values (4, 2, 4, 1)
insert into CTSanPham values (4, 2, 5, 2)
insert into CTSanPham values (4, 2, 6, 3)

insert into CTSanPham values (4, 3, 1, 4)
insert into CTSanPham values (4, 3, 2, 1)
insert into CTSanPham values (4, 3, 3, 2)
insert into CTSanPham values (4, 3, 4, 3)
insert into CTSanPham values (4, 3, 5, 4)
insert into CTSanPham values (4, 3, 6, 1)

insert into CTSanPham values (4, 4, 1, 2)
insert into CTSanPham values (4, 4, 2, 3)
insert into CTSanPham values (4, 4, 3, 4)
insert into CTSanPham values (4, 4, 4, 1)
insert into CTSanPham values (4, 4, 5, 2)
insert into CTSanPham values (4, 4, 6, 3)

insert into CTSanPham values (4, 5, 1, 4)
insert into CTSanPham values (4, 5, 2, 1)
insert into CTSanPham values (4, 5, 3, 2)
insert into CTSanPham values (4, 5, 4, 3)
insert into CTSanPham values (4, 5, 5, 4)
insert into CTSanPham values (4, 5, 6, 1)

insert into CTSanPham values (4, 6, 1, 2)
insert into CTSanPham values (4, 6, 2, 3)
insert into CTSanPham values (4, 6, 3, 4)
insert into CTSanPham values (4, 6, 4, 1)
insert into CTSanPham values (4, 6, 5, 2)
insert into CTSanPham values (4, 6, 6, 3)

insert into CTSanPham values (5, 1, 1, 4)
insert into CTSanPham values (5, 1, 2, 1)
insert into CTSanPham values (5, 1, 3, 2)
insert into CTSanPham values (5, 1, 4, 3)
insert into CTSanPham values (5, 1, 5, 4)
insert into CTSanPham values (5, 1, 6, 1)

insert into CTSanPham values (5, 2, 1, 2)
insert into CTSanPham values (5, 2, 2, 3)
insert into CTSanPham values (5, 2, 3, 4)
insert into CTSanPham values (5, 2, 4, 1)
insert into CTSanPham values (5, 2, 5, 2)
insert into CTSanPham values (5, 2, 6, 3)

insert into CTSanPham values (5, 3, 1, 4)
insert into CTSanPham values (5, 3, 2, 1)
insert into CTSanPham values (5, 3, 3, 2)
insert into CTSanPham values (5, 3, 4, 3)
insert into CTSanPham values (5, 3, 5, 4)
insert into CTSanPham values (5, 3, 6, 1)

insert into CTSanPham values (5, 4, 1, 2)
insert into CTSanPham values (5, 4, 2, 3)
insert into CTSanPham values (5, 4, 3, 4)
insert into CTSanPham values (5, 4, 4, 1)
insert into CTSanPham values (5, 4, 5, 2)
insert into CTSanPham values (5, 4, 6, 3)

insert into CTSanPham values (5, 5, 1, 4)
insert into CTSanPham values (5, 5, 2, 1)
insert into CTSanPham values (5, 5, 3, 2)
insert into CTSanPham values (5, 5, 4, 3)
insert into CTSanPham values (5, 5, 5, 4)
insert into CTSanPham values (5, 5, 6, 1)

insert into CTSanPham values (5, 6, 1, 2)
insert into CTSanPham values (5, 6, 2, 3)
insert into CTSanPham values (5, 6, 3, 4)
insert into CTSanPham values (5, 6, 4, 1)
insert into CTSanPham values (5, 6, 5, 2)
insert into CTSanPham values (5, 6, 6, 3)

insert into CTSanPham values (6, 1, 1, 4)
insert into CTSanPham values (6, 1, 2, 1)
insert into CTSanPham values (6, 1, 3, 2)
insert into CTSanPham values (6, 1, 4, 3)
insert into CTSanPham values (6, 1, 5, 4)
insert into CTSanPham values (6, 1, 6, 1)

insert into CTSanPham values (6, 2, 1, 2)
insert into CTSanPham values (6, 2, 2, 3)
insert into CTSanPham values (6, 2, 3, 4)
insert into CTSanPham values (6, 2, 4, 1)
insert into CTSanPham values (6, 2, 5, 2)
insert into CTSanPham values (6, 2, 6, 3)

insert into CTSanPham values (6, 3, 1, 4)
insert into CTSanPham values (6, 3, 2, 1)
insert into CTSanPham values (6, 3, 3, 2)
insert into CTSanPham values (6, 3, 4, 3)
insert into CTSanPham values (6, 3, 5, 4)
insert into CTSanPham values (6, 3, 6, 1)

insert into CTSanPham values (6, 4, 1, 2)
insert into CTSanPham values (6, 4, 2, 3)
insert into CTSanPham values (6, 4, 3, 4)
insert into CTSanPham values (6, 4, 4, 1)
insert into CTSanPham values (6, 4, 5, 2)
insert into CTSanPham values (6, 4, 6, 3)

insert into CTSanPham values (6, 5, 1, 1)
insert into CTSanPham values (6, 5, 2, 2)
insert into CTSanPham values (6, 5, 3, 3)
insert into CTSanPham values (6, 5, 4, 1)
insert into CTSanPham values (6, 5, 5, 2)
insert into CTSanPham values (6, 5, 6, 3)

insert into CTSanPham values (6, 6, 1, 4)
insert into CTSanPham values (6, 6, 2, 1)
insert into CTSanPham values (6, 6, 3, 2)
insert into CTSanPham values (6, 6, 4, 3)
insert into CTSanPham values (6, 6, 5, 4)
insert into CTSanPham values (6, 6, 6, 1)

insert into CTSanPham values (7, 1, 1, 12)
insert into CTSanPham values (7, 1, 2, 32)
insert into CTSanPham values (7, 1, 3, 41)
insert into CTSanPham values (7, 1, 4, 12)
insert into CTSanPham values (7, 1, 5, 25)
insert into CTSanPham values (7, 1, 6, 38)

insert into CTSanPham values (7, 2, 1, 48)
insert into CTSanPham values (7, 2, 2, 11)
insert into CTSanPham values (7, 2, 3, 25)
insert into CTSanPham values (7, 2, 4, 34)
insert into CTSanPham values (7, 2, 5, 47)
insert into CTSanPham values (7, 2, 6, 15)

insert into CTSanPham values (7, 3, 1, 22)
insert into CTSanPham values (7, 3, 2, 34)
insert into CTSanPham values (7, 3, 3, 40)
insert into CTSanPham values (7, 3, 4, 14)
insert into CTSanPham values (7, 3, 5, 25)
insert into CTSanPham values (7, 3, 6, 38)

insert into CTSanPham values (7, 4, 1, 45)
insert into CTSanPham values (7, 4, 2, 15)
insert into CTSanPham values (7, 4, 3, 22)
insert into CTSanPham values (7, 4, 4, 33)
insert into CTSanPham values (7, 4, 5, 44)
insert into CTSanPham values (7, 4, 6, 10)

insert into CTSanPham values (7, 5, 1, 31)
insert into CTSanPham values (7, 5, 2, 66)
insert into CTSanPham values (7, 5, 3, 44)
insert into CTSanPham values (7, 5, 4, 10)
insert into CTSanPham values (7, 5, 5, 24)
insert into CTSanPham values (7, 5, 6, 3)

insert into CTSanPham values (7, 6, 1, 23)
insert into CTSanPham values (7, 6, 2, 34)
insert into CTSanPham values (7, 6, 3, 47)
insert into CTSanPham values (7, 6, 4, 12)
insert into CTSanPham values (7, 6, 5, 20)
insert into CTSanPham values (7, 6, 6, 33)

insert into CTSanPham values (8, 1, 1, 42)
insert into CTSanPham values (8, 1, 2, 14)
insert into CTSanPham values (8, 1, 3, 26)
insert into CTSanPham values (8, 1, 4, 30)
insert into CTSanPham values (8, 1, 5, 44)
insert into CTSanPham values (8, 1, 6, 11)

insert into CTSanPham values (8, 2, 1, 22)
insert into CTSanPham values (8, 2, 2, 35)
insert into CTSanPham values (8, 2, 3, 49)
insert into CTSanPham values (8, 2, 4, 12)
insert into CTSanPham values (8, 2, 5, 20)
insert into CTSanPham values (8, 2, 6, 36)

insert into CTSanPham values (8, 3, 1, 43)
insert into CTSanPham values (8, 3, 2, 15)
insert into CTSanPham values (8, 3, 3, 21)
insert into CTSanPham values (8, 3, 4, 32)
insert into CTSanPham values (8, 3, 5, 45)
insert into CTSanPham values (8, 3, 6, 16)

insert into CTSanPham values (8, 4, 1, 26)
insert into CTSanPham values (8, 4, 2, 39)
insert into CTSanPham values (8, 4, 3, 44)
insert into CTSanPham values (8, 4, 4, 13)
insert into CTSanPham values (8, 4, 5, 23)
insert into CTSanPham values (8, 4, 6, 32)

insert into CTSanPham values (8, 5, 1, 46)
insert into CTSanPham values (8, 5, 2, 13)
insert into CTSanPham values (8, 5, 3, 20)
insert into CTSanPham values (8, 5, 4, 34)
insert into CTSanPham values (8, 5, 5, 45)
insert into CTSanPham values (8, 5, 6, 12)

insert into CTSanPham values (8, 6, 1, 23)
insert into CTSanPham values (8, 6, 2, 35)
insert into CTSanPham values (8, 6, 3, 44)
insert into CTSanPham values (8, 6, 4, 12)
insert into CTSanPham values (8, 6, 5, 20)
insert into CTSanPham values (8, 6, 6, 31)

insert into CTSanPham values (9, 1, 1, 43)
insert into CTSanPham values (9, 1, 2, 14)
insert into CTSanPham values (9, 1, 3, 28)
insert into CTSanPham values (9, 1, 4, 36)
insert into CTSanPham values (9, 1, 5, 43)
insert into CTSanPham values (9, 1, 6, 11)

insert into CTSanPham values (9, 2, 1, 23)
insert into CTSanPham values (9, 2, 2, 35)
insert into CTSanPham values (9, 2, 3, 46)
insert into CTSanPham values (9, 2, 4, 14)
insert into CTSanPham values (9, 2, 5, 22)
insert into CTSanPham values (9, 2, 6, 32)

insert into CTSanPham values (9, 3, 1, 12)
insert into CTSanPham values (9, 3, 2, 21)
insert into CTSanPham values (9, 3, 3, 35)
insert into CTSanPham values (9, 3, 4, 15)
insert into CTSanPham values (9, 3, 5, 20)
insert into CTSanPham values (9, 3, 6, 32)

insert into CTSanPham values (9, 4, 1, 44)
insert into CTSanPham values (9, 4, 2, 18)
insert into CTSanPham values (9, 4, 3, 26)
insert into CTSanPham values (9, 4, 4, 30)
insert into CTSanPham values (9, 4, 5, 41)
insert into CTSanPham values (9, 4, 6, 12)

insert into CTSanPham values (9, 5, 1, 23)
insert into CTSanPham values (9, 5, 2, 35)
insert into CTSanPham values (9, 5, 3, 48)
insert into CTSanPham values (9, 5, 4, 11)
insert into CTSanPham values (9, 5, 5, 24)
insert into CTSanPham values (9, 5, 6, 33)

insert into CTSanPham values (9, 6, 1, 43)
insert into CTSanPham values (9, 6, 2, 15)
insert into CTSanPham values (9, 6, 3, 28)
insert into CTSanPham values (9, 6, 4, 39)
insert into CTSanPham values (9, 6, 5, 46)
insert into CTSanPham values (9, 6, 6, 13)

insert into CTSanPham values (10, 1, 1, 23)
insert into CTSanPham values (10, 1, 2, 32)
insert into CTSanPham values (10, 1, 3, 45)
insert into CTSanPham values (10, 1, 4, 14)
insert into CTSanPham values (10, 1, 5, 21)
insert into CTSanPham values (10, 1, 6, 30)

insert into CTSanPham values (10, 2, 1, 43)
insert into CTSanPham values (10, 2, 2, 14)
insert into CTSanPham values (10, 2, 3, 28)
insert into CTSanPham values (10, 2, 4, 36)
insert into CTSanPham values (10, 2, 5, 42)
insert into CTSanPham values (10, 2, 6, 10)

insert into CTSanPham values (10, 3, 1, 23)
insert into CTSanPham values (10, 3, 2, 35)
insert into CTSanPham values (10, 3, 3, 47)
insert into CTSanPham values (10, 3, 4, 11)
insert into CTSanPham values (10, 3, 5, 22)
insert into CTSanPham values (10, 3, 6, 35)

insert into CTSanPham values (10, 4, 1, 43)
insert into CTSanPham values (10, 4, 2, 13)
insert into CTSanPham values (10, 4, 3, 24)
insert into CTSanPham values (10, 4, 4, 37)
insert into CTSanPham values (10, 4, 5, 42)
insert into CTSanPham values (10, 4, 6, 10)

insert into CTSanPham values (10, 5, 1, 21)
insert into CTSanPham values (10, 5, 2, 35)
insert into CTSanPham values (10, 5, 3, 49)
insert into CTSanPham values (10, 5, 4, 12)
insert into CTSanPham values (10, 5, 5, 23)
insert into CTSanPham values (10, 5, 6, 34)

insert into CTSanPham values (10, 6, 1, 43)
insert into CTSanPham values (10, 6, 2, 10)
insert into CTSanPham values (10, 6, 3, 25)
insert into CTSanPham values (10, 6, 4, 37)
insert into CTSanPham values (10, 6, 5, 46)
insert into CTSanPham values (10, 6, 6, 19)

insert into CTSanPham values (11, 7, 1, 10)
insert into CTSanPham values (11, 7, 2, 21)
insert into CTSanPham values (11, 7, 3, 35)
insert into CTSanPham values (11, 7, 4, 16)
insert into CTSanPham values (11, 7, 5, 27)
insert into CTSanPham values (11, 7, 6, 38)

insert into CTSanPham values (11, 8, 1, 12)
insert into CTSanPham values (11, 8, 2, 23)
insert into CTSanPham values (11, 8, 3, 35)
insert into CTSanPham values (11, 8, 4, 14)
insert into CTSanPham values (11, 8, 5, 25)
insert into CTSanPham values (11, 8, 6, 36)

insert into CTSanPham values (11, 9, 1, 17)
insert into CTSanPham values (11, 9, 2, 22)
insert into CTSanPham values (11, 9, 3, 33)
insert into CTSanPham values (11, 9, 4, 14)
insert into CTSanPham values (11, 9, 5, 21)
insert into CTSanPham values (11, 9, 6, 32)

insert into CTSanPham values (11, 10, 1, 13)
insert into CTSanPham values (11, 10, 2, 25)
insert into CTSanPham values (11, 10, 3, 37)
insert into CTSanPham values (11, 10, 4, 14)
insert into CTSanPham values (11, 10, 5, 21)
insert into CTSanPham values (11, 10, 6, 30)

insert into CTSanPham values (11, 11, 1, 17)
insert into CTSanPham values (11, 11, 2, 24)
insert into CTSanPham values (11, 11, 3, 32)
insert into CTSanPham values (11, 11, 4, 10)
insert into CTSanPham values (11, 11, 5, 23)
insert into CTSanPham values (11, 11, 6, 34)

insert into CTSanPham values (11, 12, 1, 17)
insert into CTSanPham values (11, 12, 2, 25)
insert into CTSanPham values (11, 12, 3, 30)
insert into CTSanPham values (11, 12, 4, 13)
insert into CTSanPham values (11, 12, 5, 26)
insert into CTSanPham values (11, 12, 6, 35)

insert into CTSanPham values (11, 13, 1, 13)
insert into CTSanPham values (11, 13, 2, 25)
insert into CTSanPham values (11, 13, 3, 34)
insert into CTSanPham values (11, 13, 4, 15)
insert into CTSanPham values (11, 13, 5, 22)
insert into CTSanPham values (11, 13, 6, 33)

insert into CTSanPham values (12, 7, 1, 13)
insert into CTSanPham values (12, 7, 2, 45)
insert into CTSanPham values (12, 7, 3, 37)
insert into CTSanPham values (12, 7, 4, 13)
insert into CTSanPham values (12, 7, 5, 24)
insert into CTSanPham values (12, 7, 6, 23)

insert into CTSanPham values (12, 8, 1, 11)
insert into CTSanPham values (12, 8, 2, 42)
insert into CTSanPham values (12, 8, 3, 43)
insert into CTSanPham values (12, 8, 4, 51)
insert into CTSanPham values (12, 8, 5, 22)
insert into CTSanPham values (12, 8, 6, 33)

insert into CTSanPham values (12, 9, 1, 51)
insert into CTSanPham values (12, 9, 2, 62)
insert into CTSanPham values (12, 9, 3, 73)
insert into CTSanPham values (12, 9, 4, 01)
insert into CTSanPham values (12, 9, 5, 02)
insert into CTSanPham values (12, 9, 6, 23)

insert into CTSanPham values (12, 10, 1, 13)
insert into CTSanPham values (12, 10, 2, 22)
insert into CTSanPham values (12, 10, 3, 35)
insert into CTSanPham values (12, 10, 4, 10)
insert into CTSanPham values (12, 10, 5, 24)
insert into CTSanPham values (12, 10, 6, 30)

insert into CTSanPham values (12, 11, 1, 12)
insert into CTSanPham values (12, 11, 2, 23)
insert into CTSanPham values (12, 11, 3, 36)
insert into CTSanPham values (12, 11, 4, 15)
insert into CTSanPham values (12, 11, 5, 24)
insert into CTSanPham values (12, 11, 6, 37)

insert into CTSanPham values (12, 12, 1, 16)
insert into CTSanPham values (12, 12, 2, 24)
insert into CTSanPham values (12, 12, 3, 32)
insert into CTSanPham values (12, 12, 4, 10)
insert into CTSanPham values (12, 12, 5, 26)
insert into CTSanPham values (12, 12, 6, 30)

insert into CTSanPham values (12, 13, 1, 13)
insert into CTSanPham values (12, 13, 2, 24)
insert into CTSanPham values (12, 13, 3, 37)
insert into CTSanPham values (12, 13, 4, 11)
insert into CTSanPham values (12, 13, 5, 26)
insert into CTSanPham values (12, 13, 6, 33)

insert into CTSanPham values (13, 7, 1, 13)
insert into CTSanPham values (13, 7, 2, 25)
insert into CTSanPham values (13, 7, 3, 31)
insert into CTSanPham values (13, 7, 4, 10)
insert into CTSanPham values (13, 7, 5, 25)
insert into CTSanPham values (13, 7, 6, 39)

insert into CTSanPham values (13, 8, 1, 13)
insert into CTSanPham values (13, 8, 2, 24)
insert into CTSanPham values (13, 8, 3, 38)
insert into CTSanPham values (13, 8, 4, 16)
insert into CTSanPham values (13, 8, 5, 20)
insert into CTSanPham values (13, 8, 6, 31)

insert into CTSanPham values (13, 9, 1, 13)
insert into CTSanPham values (13, 9, 2, 25)
insert into CTSanPham values (13, 9, 3, 31)
insert into CTSanPham values (13, 9, 4, 10)
insert into CTSanPham values (13, 9, 5, 25)
insert into CTSanPham values (13, 9, 6, 30)

insert into CTSanPham values (13, 10, 1, 13)
insert into CTSanPham values (13, 10, 2, 26)
insert into CTSanPham values (13, 10, 3, 34)
insert into CTSanPham values (13, 10, 4, 11)
insert into CTSanPham values (13, 10, 5, 20)
insert into CTSanPham values (13, 10, 6, 33)

insert into CTSanPham values (13, 11, 1, 13)
insert into CTSanPham values (13, 11, 2, 25)
insert into CTSanPham values (13, 11, 3, 34)
insert into CTSanPham values (13, 11, 4, 11)
insert into CTSanPham values (13, 11, 5, 20)
insert into CTSanPham values (13, 11, 6, 33)

insert into CTSanPham values (13, 12, 1, 13)
insert into CTSanPham values (13, 12, 2, 25)
insert into CTSanPham values (13, 12, 3, 31)
insert into CTSanPham values (13, 12, 4, 10)
insert into CTSanPham values (13, 12, 5, 25)
insert into CTSanPham values (13, 12, 6, 30)

insert into CTSanPham values (13, 13, 1, 13)
insert into CTSanPham values (13, 13, 2, 25)
insert into CTSanPham values (13, 13, 3, 37)
insert into CTSanPham values (13, 13, 4, 11)
insert into CTSanPham values (13, 13, 5, 20)
insert into CTSanPham values (13, 13, 6, 33)

insert into CTSanPham values (14, 7, 1, 15)
insert into CTSanPham values (14, 7, 2, 29)
insert into CTSanPham values (14, 7, 3, 31)
insert into CTSanPham values (14, 7, 4, 12)
insert into CTSanPham values (14, 7, 5, 26)
insert into CTSanPham values (14, 7, 6, 33)

insert into CTSanPham values (14, 8, 1, 12)
insert into CTSanPham values (14, 8, 2, 23)
insert into CTSanPham values (14, 8, 3, 34)
insert into CTSanPham values (14, 8, 4, 15)
insert into CTSanPham values (14, 8, 5, 26)
insert into CTSanPham values (14, 8, 6, 37)

insert into CTSanPham values (14, 9, 1, 12)
insert into CTSanPham values (14, 9, 2, 25)
insert into CTSanPham values (14, 9, 3, 36)
insert into CTSanPham values (14, 9, 4, 13)
insert into CTSanPham values (14, 9, 5, 24)
insert into CTSanPham values (14, 9, 6, 31)

insert into CTSanPham values (14, 10, 1, 12)
insert into CTSanPham values (14, 10, 2, 23)
insert into CTSanPham values (14, 10, 3, 36)
insert into CTSanPham values (14, 10, 4, 14)
insert into CTSanPham values (14, 10, 5, 21)
insert into CTSanPham values (14, 10, 6, 37)

insert into CTSanPham values (14, 11, 1, 13)
insert into CTSanPham values (14, 11, 2, 25)
insert into CTSanPham values (14, 11, 3, 39)
insert into CTSanPham values (14, 11, 4, 17)
insert into CTSanPham values (14, 11, 5, 24)
insert into CTSanPham values (14, 11, 6, 32)

insert into CTSanPham values (14, 12, 1, 13)
insert into CTSanPham values (14, 12, 2, 25)
insert into CTSanPham values (14, 12, 3, 32)
insert into CTSanPham values (14, 12, 4, 13)
insert into CTSanPham values (14, 12, 5, 23)
insert into CTSanPham values (14, 12, 6, 35)

insert into CTSanPham values (14, 13, 1, 15)
insert into CTSanPham values (14, 13, 2, 28)
insert into CTSanPham values (14, 13, 3, 39)
insert into CTSanPham values (14, 13, 4, 15)
insert into CTSanPham values (14, 13, 5, 22)
insert into CTSanPham values (14, 13, 6, 34)

insert into CTSanPham values (15, 7, 1, 16)
insert into CTSanPham values (15, 7, 2, 27)
insert into CTSanPham values (15, 7, 3, 39)
insert into CTSanPham values (15, 7, 4, 11)
insert into CTSanPham values (15, 7, 5, 2)
insert into CTSanPham values (15, 7, 6, 3)

insert into CTSanPham values (15, 8, 1, 1)
insert into CTSanPham values (15, 8, 2, 2)
insert into CTSanPham values (15, 8, 3, 3)
insert into CTSanPham values (15, 8, 4, 1)
insert into CTSanPham values (15, 8, 5, 2)
insert into CTSanPham values (15, 8, 6, 3)

insert into CTSanPham values (15, 9, 1, 1)
insert into CTSanPham values (15, 9, 2, 22)
insert into CTSanPham values (15, 9, 3, 33)
insert into CTSanPham values (15, 9, 4, 51)
insert into CTSanPham values (15, 9, 5, 12)
insert into CTSanPham values (15, 9, 6, 3)

insert into CTSanPham values (15, 10, 1, 1)
insert into CTSanPham values (15, 10, 2, 12)
insert into CTSanPham values (15, 10, 3, 34)
insert into CTSanPham values (15, 10, 4, 13)
insert into CTSanPham values (15, 10, 5, 2)
insert into CTSanPham values (15, 10, 6, 3)

insert into CTSanPham values (15, 11, 1, 1)
insert into CTSanPham values (15, 11, 2, 72)
insert into CTSanPham values (15, 11, 3, 33)
insert into CTSanPham values (15, 11, 4, 15)
insert into CTSanPham values (15, 11, 5, 24)
insert into CTSanPham values (15, 11, 6, 3)

insert into CTSanPham values (15, 12, 1, 1)
insert into CTSanPham values (15, 12, 2, 2)
insert into CTSanPham values (15, 12, 3, 3)
insert into CTSanPham values (15, 12, 4, 1)
insert into CTSanPham values (15, 12, 5, 2)
insert into CTSanPham values (15, 12, 6, 3)

insert into CTSanPham values (15, 13, 1, 1)
insert into CTSanPham values (15, 13, 2, 2)
insert into CTSanPham values (15, 13, 3, 3)
insert into CTSanPham values (15, 13, 4, 1)
insert into CTSanPham values (15, 13, 5, 2)
insert into CTSanPham values (15, 13, 6, 3)

insert into CTSanPham values (16, 7, 1, 32)
insert into CTSanPham values (16, 7, 2, 22)
insert into CTSanPham values (16, 7, 3, 31)
insert into CTSanPham values (16, 7, 4, 12)
insert into CTSanPham values (16, 7, 5, 22)
insert into CTSanPham values (16, 7, 6, 32)

insert into CTSanPham values (16, 8, 1, 12)
insert into CTSanPham values (16, 8, 2, 26)
insert into CTSanPham values (16, 8, 3, 31)
insert into CTSanPham values (16, 8, 4, 16)
insert into CTSanPham values (16, 8, 5, 21)
insert into CTSanPham values (16, 8, 6, 36)

insert into CTSanPham values (16, 9, 1, 13)
insert into CTSanPham values (16, 9, 2, 25)
insert into CTSanPham values (16, 9, 3, 31)
insert into CTSanPham values (16, 9, 4, 10)
insert into CTSanPham values (16, 9, 5, 24)
insert into CTSanPham values (16, 9, 6, 30)

insert into CTSanPham values (16, 10, 1, 10)
insert into CTSanPham values (16, 10, 2, 20)
insert into CTSanPham values (16, 10, 3, 30)
insert into CTSanPham values (16, 10, 4, 13)
insert into CTSanPham values (16, 10, 5, 25)
insert into CTSanPham values (16, 10, 6, 30)

insert into CTSanPham values (16, 11, 1, 13)
insert into CTSanPham values (16, 11, 2, 25)
insert into CTSanPham values (16, 11, 3, 31)
insert into CTSanPham values (16, 11, 4, 10)
insert into CTSanPham values (16, 11, 5, 25)
insert into CTSanPham values (16, 11, 6, 32)

insert into CTSanPham values (16, 12, 1, 19)
insert into CTSanPham values (16, 12, 2, 23)
insert into CTSanPham values (16, 12, 3, 36)
insert into CTSanPham values (16, 12, 4, 12)
insert into CTSanPham values (16, 12, 5, 23)
insert into CTSanPham values (16, 12, 6, 33)

insert into CTSanPham values (16, 13, 1, 12)
insert into CTSanPham values (16, 13, 2, 28)
insert into CTSanPham values (16, 13, 3, 31)
insert into CTSanPham values (16, 13, 4, 132)
insert into CTSanPham values (16, 13, 5, 232)
insert into CTSanPham values (16, 13, 6, 32)

insert into CTSanPham values (17, 7, 1, 19)
insert into CTSanPham values (17, 7, 2, 28)
insert into CTSanPham values (17, 7, 3, 32)
insert into CTSanPham values (17, 7, 4, 13)
insert into CTSanPham values (17, 7, 5, 26)
insert into CTSanPham values (17, 7, 6, 34)

insert into CTSanPham values (17, 8, 1, 13)
insert into CTSanPham values (17, 8, 2, 21)
insert into CTSanPham values (17, 8, 3, 35)
insert into CTSanPham values (17, 8, 4, 1)
insert into CTSanPham values (17, 8, 5, 22)
insert into CTSanPham values (17, 8, 6, 35)

insert into CTSanPham values (17, 9, 1, 1)
insert into CTSanPham values (17, 9, 2, 2)
insert into CTSanPham values (17, 9, 3, 3)
insert into CTSanPham values (17, 9, 4, 1)
insert into CTSanPham values (17, 9, 5, 2)
insert into CTSanPham values (17, 9, 6, 3)

insert into CTSanPham values (17, 10, 1, 1)
insert into CTSanPham values (17, 10, 2, 2)
insert into CTSanPham values (17, 10, 3, 3)
insert into CTSanPham values (17, 10, 4, 1)
insert into CTSanPham values (17, 10, 5, 2)
insert into CTSanPham values (17, 10, 6, 3)

insert into CTSanPham values (17, 11, 1, 1)
insert into CTSanPham values (17, 11, 2, 2)
insert into CTSanPham values (17, 11, 3, 3)
insert into CTSanPham values (17, 11, 4, 1)
insert into CTSanPham values (17, 11, 5, 2)
insert into CTSanPham values (17, 11, 6, 3)

insert into CTSanPham values (17, 12, 1, 1)
insert into CTSanPham values (17, 12, 2, 2)
insert into CTSanPham values (17, 12, 3, 3)
insert into CTSanPham values (17, 12, 4, 1)
insert into CTSanPham values (17, 12, 5, 2)
insert into CTSanPham values (17, 12, 6, 3)

insert into CTSanPham values (17, 13, 1, 1)
insert into CTSanPham values (17, 13, 2, 2)
insert into CTSanPham values (17, 13, 3, 3)
insert into CTSanPham values (17, 13, 4, 1)
insert into CTSanPham values (17, 13, 5, 2)
insert into CTSanPham values (17, 13, 6, 3)

insert into CTSanPham values (18, 7, 1, 1)
insert into CTSanPham values (18, 7, 2, 2)
insert into CTSanPham values (18, 7, 3, 3)
insert into CTSanPham values (18, 7, 4, 1)
insert into CTSanPham values (18, 7, 5, 2)
insert into CTSanPham values (18, 7, 6, 3)

insert into CTSanPham values (18, 8, 1, 1)
insert into CTSanPham values (18, 8, 2, 2)
insert into CTSanPham values (18, 8, 3, 3)
insert into CTSanPham values (18, 8, 4, 1)
insert into CTSanPham values (18, 8, 5, 2)
insert into CTSanPham values (18, 8, 6, 3)

insert into CTSanPham values (18, 9, 1, 1)
insert into CTSanPham values (18, 9, 2, 2)
insert into CTSanPham values (18, 9, 3, 3)
insert into CTSanPham values (18, 9, 4, 1)
insert into CTSanPham values (18, 9, 5, 2)
insert into CTSanPham values (18, 9, 6, 3)

insert into CTSanPham values (18, 10, 1, 1)
insert into CTSanPham values (18, 10, 2, 2)
insert into CTSanPham values (18, 10, 3, 3)
insert into CTSanPham values (18, 10, 4, 1)
insert into CTSanPham values (18, 10, 5, 2)
insert into CTSanPham values (18, 10, 6, 3)

insert into CTSanPham values (18, 11, 1, 1)
insert into CTSanPham values (18, 11, 2, 2)
insert into CTSanPham values (18, 11, 3, 3)
insert into CTSanPham values (18, 11, 4, 1)
insert into CTSanPham values (18, 11, 5, 2)
insert into CTSanPham values (18, 11, 6, 3)

insert into CTSanPham values (18, 12, 1, 1)
insert into CTSanPham values (18, 12, 2, 2)
insert into CTSanPham values (18, 12, 3, 3)
insert into CTSanPham values (18, 12, 4, 1)
insert into CTSanPham values (18, 12, 5, 2)
insert into CTSanPham values (18, 12, 6, 3)

insert into CTSanPham values (18, 13, 1, 1)
insert into CTSanPham values (18, 13, 2, 2)
insert into CTSanPham values (18, 13, 3, 3)
insert into CTSanPham values (18, 13, 4, 1)
insert into CTSanPham values (18, 13, 5, 2)
insert into CTSanPham values (18, 13, 6, 3)

insert into CTSanPham values (19, 7, 1, 1)
insert into CTSanPham values (19, 7, 2, 2)
insert into CTSanPham values (19, 7, 3, 3)
insert into CTSanPham values (19, 7, 4, 1)
insert into CTSanPham values (19, 7, 5, 2)
insert into CTSanPham values (19, 7, 6, 3)

insert into CTSanPham values (19, 8, 1, 1)
insert into CTSanPham values (19, 8, 2, 2)
insert into CTSanPham values (19, 8, 3, 3)
insert into CTSanPham values (19, 8, 4, 1)
insert into CTSanPham values (19, 8, 5, 2)
insert into CTSanPham values (19, 8, 6, 3)

insert into CTSanPham values (19, 9, 1, 1)
insert into CTSanPham values (19, 9, 2, 2)
insert into CTSanPham values (19, 9, 3, 3)
insert into CTSanPham values (19, 9, 4, 1)
insert into CTSanPham values (19, 9, 5, 2)
insert into CTSanPham values (19, 9, 6, 3)

insert into CTSanPham values (19, 10, 1, 1)
insert into CTSanPham values (19, 10, 2, 2)
insert into CTSanPham values (19, 10, 3, 3)
insert into CTSanPham values (19, 10, 4, 1)
insert into CTSanPham values (19, 10, 5, 2)
insert into CTSanPham values (19, 10, 6, 3)

insert into CTSanPham values (19, 11, 1, 1)
insert into CTSanPham values (19, 11, 2, 2)
insert into CTSanPham values (19, 11, 3, 3)
insert into CTSanPham values (19, 11, 4, 1)
insert into CTSanPham values (19, 11, 5, 2)
insert into CTSanPham values (19, 11, 6, 3)

insert into CTSanPham values (19, 12, 1, 1)
insert into CTSanPham values (19, 12, 2, 2)
insert into CTSanPham values (19, 12,  3, 3)
insert into CTSanPham values (19, 12, 4, 1)
insert into CTSanPham values (19, 12, 5, 2)
insert into CTSanPham values (19, 12, 6, 3)

insert into CTSanPham values (19, 13, 1, 1)
insert into CTSanPham values (19, 13, 2, 2)
insert into CTSanPham values (19, 13,  3, 3)
insert into CTSanPham values (19, 13, 4, 1)
insert into CTSanPham values (19, 13, 5, 2)
insert into CTSanPham values (19, 13, 6, 3)

insert into CTSanPham values (20, 7, 1, 1)
insert into CTSanPham values (20, 7, 2, 2)
insert into CTSanPham values (20, 7, 3, 3)
insert into CTSanPham values (20, 7, 4, 1)
insert into CTSanPham values (20, 7, 5, 2)
insert into CTSanPham values (20, 7, 6, 3)

insert into CTSanPham values (20, 8, 1, 1)
insert into CTSanPham values (20, 8, 2, 2)
insert into CTSanPham values (20, 8, 3, 3)
insert into CTSanPham values (20, 8, 4, 1)
insert into CTSanPham values (20, 8, 5, 2)
insert into CTSanPham values (20, 8, 6, 3)

insert into CTSanPham values (20, 9, 1, 1)
insert into CTSanPham values (20, 9, 2, 2)
insert into CTSanPham values (20, 9, 3, 3)
insert into CTSanPham values (20, 9, 4, 1)
insert into CTSanPham values (20, 9, 5, 2)
insert into CTSanPham values (20, 9, 6, 3)

insert into CTSanPham values (20, 10, 1, 1)
insert into CTSanPham values (20, 10, 2, 2)
insert into CTSanPham values (20, 10, 3, 3)
insert into CTSanPham values (20, 10, 4, 1)
insert into CTSanPham values (20, 10, 5, 2)
insert into CTSanPham values (20, 10, 6, 3)

insert into CTSanPham values (20, 11, 1, 1)
insert into CTSanPham values (20, 11, 2, 2)
insert into CTSanPham values (20, 11, 3, 3)
insert into CTSanPham values (20, 11, 4, 1)
insert into CTSanPham values (20, 11, 5, 2)
insert into CTSanPham values (20, 11, 6, 3)

insert into CTSanPham values (20, 12, 1, 1)
insert into CTSanPham values (20, 12, 2, 2)
insert into CTSanPham values (20, 12, 3, 3)
insert into CTSanPham values (20, 12, 4, 1)
insert into CTSanPham values (20, 12, 5, 2)
insert into CTSanPham values (20, 12, 6, 3)

insert into CTSanPham values (20, 13, 1, 1)
insert into CTSanPham values (20, 13, 2, 2)
insert into CTSanPham values (20, 13, 3, 3)
insert into CTSanPham values (20, 13, 4, 1)
insert into CTSanPham values (20, 13, 5, 2)
insert into CTSanPham values (20, 13, 6, 3)

insert into CTSanPham values (21, 14, 1, 1)
insert into CTSanPham values (21, 14, 2, 2)
insert into CTSanPham values (21, 14, 3, 3)
insert into CTSanPham values (21, 14, 4, 1)
insert into CTSanPham values (21, 14, 5, 2)
insert into CTSanPham values (21, 14, 6, 3)

insert into CTSanPham values (21, 15, 1, 1)
insert into CTSanPham values (21, 15, 2, 2)
insert into CTSanPham values (21, 15, 3, 3)
insert into CTSanPham values (21, 15, 4, 1)
insert into CTSanPham values (21, 15, 5, 2)
insert into CTSanPham values (21, 15, 6, 3)

insert into CTSanPham values (21, 16, 1, 1)
insert into CTSanPham values (21, 16, 2, 2)
insert into CTSanPham values (21, 16, 3, 3)
insert into CTSanPham values (21, 16, 4, 1)
insert into CTSanPham values (21, 16, 5, 2)
insert into CTSanPham values (21, 16, 6, 3)

insert into CTSanPham values (21, 17, 1, 1)
insert into CTSanPham values (21, 17, 2, 2)
insert into CTSanPham values (21, 17, 3, 3)
insert into CTSanPham values (21, 17, 4, 1)
insert into CTSanPham values (21, 17, 5, 2)
insert into CTSanPham values (21, 17, 6, 3)

insert into CTSanPham values (21, 18, 1, 1)
insert into CTSanPham values (21, 18, 2, 2)
insert into CTSanPham values (21, 18, 3, 3)
insert into CTSanPham values (21, 18, 4, 1)
insert into CTSanPham values (21, 18, 5, 2)
insert into CTSanPham values (21, 18, 6, 3)

insert into CTSanPham values (21, 19, 1, 1)
insert into CTSanPham values (21, 19, 2, 2)
insert into CTSanPham values (21, 19, 3, 3)
insert into CTSanPham values (21, 19, 4, 1)
insert into CTSanPham values (21, 19, 5, 2)
insert into CTSanPham values (21, 19, 6, 3)

insert into CTSanPham values (21, 20, 1, 1)
insert into CTSanPham values (21, 20, 2, 2)
insert into CTSanPham values (21, 20, 3, 3)
insert into CTSanPham values (21, 20, 4, 1)
insert into CTSanPham values (21, 20, 5, 2)
insert into CTSanPham values (21, 20, 6, 3)

insert into CTSanPham values (21, 21, 1, 1)
insert into CTSanPham values (21, 21, 2, 2)
insert into CTSanPham values (21, 21, 3, 3)
insert into CTSanPham values (21, 21, 4, 1)
insert into CTSanPham values (21, 21, 5, 2)
insert into CTSanPham values (21, 21, 6, 3)

insert into CTSanPham values (22, 14, 1, 1)
insert into CTSanPham values (22, 14, 2, 2)
insert into CTSanPham values (22, 14, 3, 3)
insert into CTSanPham values (22, 14, 4, 1)
insert into CTSanPham values (22, 14, 5, 2)
insert into CTSanPham values (22, 14, 6, 3)

insert into CTSanPham values (22, 15, 1, 1)
insert into CTSanPham values (22, 15, 2, 2)
insert into CTSanPham values (22, 15, 3, 3)
insert into CTSanPham values (22, 15, 4, 1)
insert into CTSanPham values (22, 15, 5, 2)
insert into CTSanPham values (22, 15, 6, 3)

insert into CTSanPham values (22, 16, 1, 1)
insert into CTSanPham values (22, 16, 2, 2)
insert into CTSanPham values (22, 16, 3, 3)
insert into CTSanPham values (22, 16, 4, 1)
insert into CTSanPham values (22, 16, 5, 2)
insert into CTSanPham values (22, 16, 6, 3)

insert into CTSanPham values (22, 17, 1, 1)
insert into CTSanPham values (22, 17, 2, 2)
insert into CTSanPham values (22, 17, 3, 3)
insert into CTSanPham values (22, 17, 4, 1)
insert into CTSanPham values (22, 17, 5, 2)
insert into CTSanPham values (22, 17, 6, 3)

insert into CTSanPham values (22, 18, 1, 1)
insert into CTSanPham values (22, 18, 2, 2)
insert into CTSanPham values (22, 18, 3, 3)
insert into CTSanPham values (22, 18, 4, 1)
insert into CTSanPham values (22, 18, 5, 2)
insert into CTSanPham values (22, 18, 6, 3)

insert into CTSanPham values (22, 19, 1, 1)
insert into CTSanPham values (22, 19, 2, 2)
insert into CTSanPham values (22, 19, 3, 3)
insert into CTSanPham values (22, 19, 4, 1)
insert into CTSanPham values (22, 19, 5, 2)
insert into CTSanPham values (22, 19, 6, 3)

insert into CTSanPham values (22, 20, 1, 1)
insert into CTSanPham values (22, 20, 2, 2)
insert into CTSanPham values (22, 20, 3, 3)
insert into CTSanPham values (22, 20, 4, 1)
insert into CTSanPham values (22, 20, 5, 2)
insert into CTSanPham values (22, 20, 6, 3)

insert into CTSanPham values (22, 21, 1, 1)
insert into CTSanPham values (22, 21, 2, 2)
insert into CTSanPham values (22, 21, 3, 3)
insert into CTSanPham values (22, 21, 4, 1)
insert into CTSanPham values (22, 21, 5, 2)
insert into CTSanPham values (22, 21, 6, 3)

insert into CTSanPham values (23, 14, 1, 1)
insert into CTSanPham values (23, 14, 2, 2)
insert into CTSanPham values (23, 14, 3, 3)
insert into CTSanPham values (23, 14, 4, 1)
insert into CTSanPham values (23, 14, 5, 2)
insert into CTSanPham values (23, 14, 6, 3)

insert into CTSanPham values (23, 15, 1, 1)
insert into CTSanPham values (23, 15, 2, 2)
insert into CTSanPham values (23, 15, 3, 3)
insert into CTSanPham values (23, 15, 4, 1)
insert into CTSanPham values (23, 15, 5, 2)
insert into CTSanPham values (23, 15, 6, 3)

insert into CTSanPham values (23, 16, 1, 1)
insert into CTSanPham values (23, 16, 2, 2)
insert into CTSanPham values (23, 16, 3, 3)
insert into CTSanPham values (23, 16, 4, 1)
insert into CTSanPham values (23, 16, 5, 2)
insert into CTSanPham values (23, 16, 6, 3)

insert into CTSanPham values (23, 17, 1, 1)
insert into CTSanPham values (23, 17, 2, 2)
insert into CTSanPham values (23, 17, 3, 3)
insert into CTSanPham values (23, 17, 4, 1)
insert into CTSanPham values (23, 17, 5, 2)
insert into CTSanPham values (23, 17, 6, 3)

insert into CTSanPham values (23, 18, 1, 1)
insert into CTSanPham values (23, 18, 2, 2)
insert into CTSanPham values (23, 18, 3, 3)
insert into CTSanPham values (23, 18, 4, 1)
insert into CTSanPham values (23, 18, 5, 2)
insert into CTSanPham values (23, 18, 6, 3)

insert into CTSanPham values (23, 19, 1, 1)
insert into CTSanPham values (23, 19, 2, 2)
insert into CTSanPham values (23, 19, 3, 3)
insert into CTSanPham values (23, 19, 4, 1)
insert into CTSanPham values (23, 19, 5, 2)
insert into CTSanPham values (23, 19, 6, 3)

insert into CTSanPham values (23, 20, 1, 1)
insert into CTSanPham values (23, 20, 2, 2)
insert into CTSanPham values (23, 20, 3, 3)
insert into CTSanPham values (23, 20, 4, 1)
insert into CTSanPham values (23, 20, 5, 2)
insert into CTSanPham values (23, 20, 6, 3)

insert into CTSanPham values (23, 21, 1, 1)
insert into CTSanPham values (23, 21, 2, 2)
insert into CTSanPham values (23, 21, 3, 3)
insert into CTSanPham values (23, 21, 4, 1)
insert into CTSanPham values (23, 21, 5, 2)
insert into CTSanPham values (23, 21, 6, 3)

insert into CTSanPham values (24, 14, 1, 1)
insert into CTSanPham values (24, 14, 2, 2)
insert into CTSanPham values (24, 14, 3, 3)
insert into CTSanPham values (24, 14, 4, 1)
insert into CTSanPham values (24, 14, 5, 2)
insert into CTSanPham values (24, 14, 6, 3)

insert into CTSanPham values (24, 15, 1, 1)
insert into CTSanPham values (24, 15, 2, 2)
insert into CTSanPham values (24, 15, 3, 3)
insert into CTSanPham values (24, 15, 4, 1)
insert into CTSanPham values (24, 15, 5, 2)
insert into CTSanPham values (24, 15, 6, 3)

insert into CTSanPham values (24, 16, 1, 1)
insert into CTSanPham values (24, 16, 2, 2)
insert into CTSanPham values (24, 16, 3, 3)
insert into CTSanPham values (24, 16, 4, 1)
insert into CTSanPham values (24, 16, 5, 2)
insert into CTSanPham values (24, 16, 6, 3)

insert into CTSanPham values (24, 17, 1, 1)
insert into CTSanPham values (24, 17, 2, 2)
insert into CTSanPham values (24, 17, 3, 3)
insert into CTSanPham values (24, 17, 4, 1)
insert into CTSanPham values (24, 17, 5, 2)
insert into CTSanPham values (24, 17, 6, 3)

insert into CTSanPham values (24, 18, 1, 1)
insert into CTSanPham values (24, 18, 2, 2)
insert into CTSanPham values (24, 18, 3, 3)
insert into CTSanPham values (24, 18, 4, 1)
insert into CTSanPham values (24, 18, 5, 2)
insert into CTSanPham values (24, 18, 6, 3)

insert into CTSanPham values (24, 19, 1, 1)
insert into CTSanPham values (24, 19, 2, 2)
insert into CTSanPham values (24, 19, 3, 3)
insert into CTSanPham values (24, 19, 4, 1)
insert into CTSanPham values (24, 19, 5, 2)
insert into CTSanPham values (24, 19, 6, 3)

insert into CTSanPham values (24, 20, 1, 1)
insert into CTSanPham values (24, 20, 2, 2)
insert into CTSanPham values (24, 20, 3, 3)
insert into CTSanPham values (24, 20, 4, 1)
insert into CTSanPham values (24, 20, 5, 2)
insert into CTSanPham values (24, 20, 6, 3)

insert into CTSanPham values (24, 21, 1, 1)
insert into CTSanPham values (24, 21, 2, 2)
insert into CTSanPham values (24, 21, 3, 3)
insert into CTSanPham values (24, 21, 4, 1)
insert into CTSanPham values (24, 21, 5, 2)
insert into CTSanPham values (24, 21, 6, 3)

insert into CTSanPham values (25, 14, 1, 1)
insert into CTSanPham values (25, 14, 2, 2)
insert into CTSanPham values (25, 14, 3, 3)
insert into CTSanPham values (25, 14, 4, 1)
insert into CTSanPham values (25, 14, 5, 2)
insert into CTSanPham values (25, 14, 6, 3)

insert into CTSanPham values (25, 15, 1, 1)
insert into CTSanPham values (25, 15, 2, 2)
insert into CTSanPham values (25, 15, 3, 3)
insert into CTSanPham values (25, 15, 4, 1)
insert into CTSanPham values (25, 15, 5, 2)
insert into CTSanPham values (25, 15, 6, 3)

insert into CTSanPham values (25, 16, 1, 1)
insert into CTSanPham values (25, 16, 2, 2)
insert into CTSanPham values (25, 16, 3, 3)
insert into CTSanPham values (25, 16, 4, 1)
insert into CTSanPham values (25, 16, 5, 2)
insert into CTSanPham values (25, 16, 6, 3)

insert into CTSanPham values (25, 17, 1, 1)
insert into CTSanPham values (25, 17, 2, 2)
insert into CTSanPham values (25, 17, 3, 3)
insert into CTSanPham values (25, 17, 4, 1)
insert into CTSanPham values (25, 17, 5, 2)
insert into CTSanPham values (25, 17, 6, 3)

insert into CTSanPham values (25, 18, 1, 1)
insert into CTSanPham values (25, 18, 2, 2)
insert into CTSanPham values (25, 18, 3, 3)
insert into CTSanPham values (25, 18, 4, 1)
insert into CTSanPham values (25, 18, 5, 2)
insert into CTSanPham values (25, 18, 6, 3)

insert into CTSanPham values (25, 19, 1, 1)
insert into CTSanPham values (25, 19, 2, 2)
insert into CTSanPham values (25, 19, 3, 3)
insert into CTSanPham values (25, 19, 4, 1)
insert into CTSanPham values (25, 19, 5, 2)
insert into CTSanPham values (25, 19, 6, 3)

insert into CTSanPham values (25, 20, 1, 1)
insert into CTSanPham values (25, 20, 2, 2)
insert into CTSanPham values (25, 20, 3, 3)
insert into CTSanPham values (25, 20, 4, 1)
insert into CTSanPham values (25, 20, 5, 2)
insert into CTSanPham values (25, 20, 6, 3)

insert into CTSanPham values (25, 21, 1, 1)
insert into CTSanPham values (25, 21, 2, 2)
insert into CTSanPham values (25, 21, 3, 3)
insert into CTSanPham values (25, 21, 4, 1)
insert into CTSanPham values (25, 21, 5, 2)
insert into CTSanPham values (25, 21, 6, 3)

insert into CTSanPham values (26, 14, 1, 1)
insert into CTSanPham values (26, 14, 2, 2)
insert into CTSanPham values (26, 14, 3, 3)
insert into CTSanPham values (26, 14, 4, 1)
insert into CTSanPham values (26, 14, 5, 2)
insert into CTSanPham values (26, 14, 6, 3)

insert into CTSanPham values (26, 15, 1, 1)
insert into CTSanPham values (26, 15, 2, 2)
insert into CTSanPham values (26, 15, 3, 3)
insert into CTSanPham values (26, 15, 4, 1)
insert into CTSanPham values (26, 15, 5, 2)
insert into CTSanPham values (26, 15, 6, 3)

insert into CTSanPham values (26, 16, 1, 1)
insert into CTSanPham values (26, 16, 2, 2)
insert into CTSanPham values (26, 16, 3, 3)
insert into CTSanPham values (26, 16, 4, 1)
insert into CTSanPham values (26, 16, 5, 2)
insert into CTSanPham values (26, 16, 6, 3)

insert into CTSanPham values (26, 17, 1, 1)
insert into CTSanPham values (26, 17, 2, 2)
insert into CTSanPham values (26, 17, 3, 3)
insert into CTSanPham values (26, 17, 4, 1)
insert into CTSanPham values (26, 17, 5, 2)
insert into CTSanPham values (26, 17, 6, 3)

insert into CTSanPham values (26, 18, 1, 1)
insert into CTSanPham values (26, 18, 2, 2)
insert into CTSanPham values (26, 18, 3, 3)
insert into CTSanPham values (26, 18, 4, 1)
insert into CTSanPham values (26, 18, 5, 2)
insert into CTSanPham values (26, 18, 6, 3)

insert into CTSanPham values (26, 19, 1, 1)
insert into CTSanPham values (26, 19, 2, 2)
insert into CTSanPham values (26, 19, 3, 3)
insert into CTSanPham values (26, 19, 4, 1)
insert into CTSanPham values (26, 19, 5, 2)
insert into CTSanPham values (26, 19, 6, 3)

insert into CTSanPham values (26, 20, 1, 1)
insert into CTSanPham values (26, 20, 2, 2)
insert into CTSanPham values (26, 20, 3, 3)
insert into CTSanPham values (26, 20, 4, 1)
insert into CTSanPham values (26, 20, 5, 2)
insert into CTSanPham values (26, 20, 6, 3)

insert into CTSanPham values (26, 21, 1, 1)
insert into CTSanPham values (26, 21, 2, 2)
insert into CTSanPham values (26, 21, 3, 3)
insert into CTSanPham values (26, 21, 4, 1)
insert into CTSanPham values (26, 21, 5, 2)
insert into CTSanPham values (26, 21, 6, 3)

insert into CTSanPham values (27, 14, 1, 1)
insert into CTSanPham values (27, 14, 2, 2)
insert into CTSanPham values (27, 14, 3, 3)
insert into CTSanPham values (27, 14, 4, 1)
insert into CTSanPham values (27, 14, 5, 2)
insert into CTSanPham values (27, 14, 6, 3)

insert into CTSanPham values (27, 15, 1, 1)
insert into CTSanPham values (27, 15, 2, 2)
insert into CTSanPham values (27, 15, 3, 3)
insert into CTSanPham values (27, 15, 4, 1)
insert into CTSanPham values (27, 15, 5, 2)
insert into CTSanPham values (27, 15, 6, 3)

insert into CTSanPham values (27, 16, 1, 1)
insert into CTSanPham values (27, 16, 2, 2)
insert into CTSanPham values (27, 16, 3, 3)
insert into CTSanPham values (27, 16, 4, 1)
insert into CTSanPham values (27, 16, 5, 2)
insert into CTSanPham values (27, 16, 6, 3)

insert into CTSanPham values (27, 17, 1, 1)
insert into CTSanPham values (27, 17, 2, 2)
insert into CTSanPham values (27, 17, 3, 3)
insert into CTSanPham values (27, 17, 4, 1)
insert into CTSanPham values (27, 17, 5, 2)
insert into CTSanPham values (27, 17, 6, 3)

insert into CTSanPham values (27, 18, 1, 1)
insert into CTSanPham values (27, 18, 2, 2)
insert into CTSanPham values (27, 18, 3, 3)
insert into CTSanPham values (27, 18, 4, 1)
insert into CTSanPham values (27, 18, 5, 2)
insert into CTSanPham values (27, 18, 6, 3)

insert into CTSanPham values (27, 19, 1, 1)
insert into CTSanPham values (27, 19, 2, 2)
insert into CTSanPham values (27, 19, 3, 3)
insert into CTSanPham values (27, 19, 4, 1)
insert into CTSanPham values (27, 19, 5, 2)
insert into CTSanPham values (27, 19, 6, 3)

insert into CTSanPham values (27, 20, 1, 1)
insert into CTSanPham values (27, 20, 2, 2)
insert into CTSanPham values (27, 20, 3, 3)
insert into CTSanPham values (27, 20, 4, 1)
insert into CTSanPham values (27, 20, 5, 2)
insert into CTSanPham values (27, 20, 6, 3)

insert into CTSanPham values (27, 21, 1, 1)
insert into CTSanPham values (27, 21, 2, 2)
insert into CTSanPham values (27, 21, 3, 3)
insert into CTSanPham values (27, 21, 4, 1)
insert into CTSanPham values (27, 21, 5, 2)
insert into CTSanPham values (27, 21, 6, 3)

insert into CTSanPham values (28, 14, 1, 1)
insert into CTSanPham values (28, 14, 2, 2)
insert into CTSanPham values (28, 14, 3, 3)
insert into CTSanPham values (28, 14, 4, 1)
insert into CTSanPham values (28, 14, 5, 2)
insert into CTSanPham values (28, 14, 6, 3)

insert into CTSanPham values (28, 15, 1, 1)
insert into CTSanPham values (28, 15, 2, 2)
insert into CTSanPham values (28, 15, 3, 3)
insert into CTSanPham values (28, 15, 4, 1)
insert into CTSanPham values (28, 15, 5, 2)
insert into CTSanPham values (28, 15, 6, 3)

insert into CTSanPham values (28, 16, 1, 1)
insert into CTSanPham values (28, 16, 2, 2)
insert into CTSanPham values (28, 16, 3, 3)
insert into CTSanPham values (28, 16, 4, 1)
insert into CTSanPham values (28, 16, 5, 2)
insert into CTSanPham values (28, 16, 6, 3)

insert into CTSanPham values (28, 17, 1, 1)
insert into CTSanPham values (28, 17, 2, 2)
insert into CTSanPham values (28, 17, 3, 3)
insert into CTSanPham values (28, 17, 4, 1)
insert into CTSanPham values (28, 17, 5, 2)
insert into CTSanPham values (28, 17, 6, 3)

insert into CTSanPham values (28, 18, 1, 1)
insert into CTSanPham values (28, 18, 2, 2)
insert into CTSanPham values (28, 18, 3, 3)
insert into CTSanPham values (28, 18, 4, 1)
insert into CTSanPham values (28, 18, 5, 2)
insert into CTSanPham values (28, 18, 6, 3)

insert into CTSanPham values (28, 19, 1, 1)
insert into CTSanPham values (28, 19, 2, 2)
insert into CTSanPham values (28, 19, 3, 3)
insert into CTSanPham values (28, 19, 4, 1)
insert into CTSanPham values (28, 19, 5, 2)
insert into CTSanPham values (28, 19, 6, 3)

insert into CTSanPham values (28, 20, 1, 1)
insert into CTSanPham values (28, 20, 2, 2)
insert into CTSanPham values (28, 20, 3, 3)
insert into CTSanPham values (28, 20, 4, 1)
insert into CTSanPham values (28, 20, 5, 2)
insert into CTSanPham values (28, 20, 6, 3)

insert into CTSanPham values (28, 21, 1, 1)
insert into CTSanPham values (28, 21, 2, 2)
insert into CTSanPham values (28, 21, 3, 3)
insert into CTSanPham values (28, 21, 4, 1)
insert into CTSanPham values (28, 21, 5, 2)
insert into CTSanPham values (28, 21, 6, 3)

insert into CTSanPham values (29, 14, 1, 1)
insert into CTSanPham values (29, 14, 2, 2)
insert into CTSanPham values (29, 14, 3, 3)
insert into CTSanPham values (29, 14, 4, 1)
insert into CTSanPham values (29, 14, 5, 2)
insert into CTSanPham values (29, 14, 6, 3)

insert into CTSanPham values (29, 15, 1, 1)
insert into CTSanPham values (29, 15, 2, 2)
insert into CTSanPham values (29, 15, 3, 3)
insert into CTSanPham values (29, 15, 4, 1)
insert into CTSanPham values (29, 15, 5, 2)
insert into CTSanPham values (29, 15, 6, 3)

insert into CTSanPham values (29, 16, 1, 1)
insert into CTSanPham values (29, 16, 2, 2)
insert into CTSanPham values (29, 16, 3, 3)
insert into CTSanPham values (29, 16, 4, 1)
insert into CTSanPham values (29, 16, 5, 2)
insert into CTSanPham values (29, 16, 6, 3)

insert into CTSanPham values (29, 17, 1, 1)
insert into CTSanPham values (29, 17, 2, 2)
insert into CTSanPham values (29, 17, 3, 3)
insert into CTSanPham values (29, 17, 4, 1)
insert into CTSanPham values (29, 17, 5, 2)
insert into CTSanPham values (29, 17, 6, 3)

insert into CTSanPham values (29, 18, 1, 1)
insert into CTSanPham values (29, 18, 2, 2)
insert into CTSanPham values (29, 18, 3, 3)
insert into CTSanPham values (29, 18, 4, 1)
insert into CTSanPham values (29, 18, 5, 2)
insert into CTSanPham values (29, 18, 6, 3)

insert into CTSanPham values (29, 19, 1, 1)
insert into CTSanPham values (29, 19, 2, 2)
insert into CTSanPham values (29, 19, 3, 3)
insert into CTSanPham values (29, 19, 4, 1)
insert into CTSanPham values (29, 19, 5, 2)
insert into CTSanPham values (29, 19, 6, 3)

insert into CTSanPham values (29, 20, 1, 1)
insert into CTSanPham values (29, 20, 2, 2)
insert into CTSanPham values (29, 20, 3, 3)
insert into CTSanPham values (29, 20, 4, 1)
insert into CTSanPham values (29, 20, 5, 2)
insert into CTSanPham values (29, 20, 6, 3)

insert into CTSanPham values (30, 14, 1, 1)
insert into CTSanPham values (30, 14, 2, 2)
insert into CTSanPham values (30, 14, 3, 3)
insert into CTSanPham values (30, 14, 4, 1)
insert into CTSanPham values (30, 14, 5, 2)
insert into CTSanPham values (30, 14, 6, 3)

insert into CTSanPham values (30, 15, 1, 1)
insert into CTSanPham values (30, 15, 2, 2)
insert into CTSanPham values (30, 15, 3, 3)
insert into CTSanPham values (30, 15, 4, 1)
insert into CTSanPham values (30, 15, 5, 2)
insert into CTSanPham values (30, 15, 6, 3)

insert into CTSanPham values (30, 16, 1, 1)
insert into CTSanPham values (30, 16, 2, 2)
insert into CTSanPham values (30, 16, 3, 3)
insert into CTSanPham values (30, 16, 4, 1)
insert into CTSanPham values (30, 16, 5, 2)
insert into CTSanPham values (30, 16, 6, 3)

insert into CTSanPham values (30, 17, 1, 1)
insert into CTSanPham values (30, 17, 2, 2)
insert into CTSanPham values (30, 17, 3, 3)
insert into CTSanPham values (30, 17, 4, 1)
insert into CTSanPham values (30, 17, 5, 2)
insert into CTSanPham values (30, 17, 6, 3)

insert into CTSanPham values (30, 18, 1, 1)
insert into CTSanPham values (30, 18, 2, 2)
insert into CTSanPham values (30, 18, 3, 3)
insert into CTSanPham values (30, 18, 4, 1)
insert into CTSanPham values (30, 18, 5, 2)
insert into CTSanPham values (30, 18, 6, 3)

insert into CTSanPham values (30, 19, 1, 1)
insert into CTSanPham values (30, 19, 2, 2)
insert into CTSanPham values (30, 19, 3, 3)
insert into CTSanPham values (30, 19, 4, 1)
insert into CTSanPham values (30, 19, 5, 2)
insert into CTSanPham values (30, 19, 6, 3)

insert into CTSanPham values (30, 20, 1, 1)
insert into CTSanPham values (30, 20, 2, 2)
insert into CTSanPham values (30, 20, 3, 3)
insert into CTSanPham values (30, 20, 4, 1)
insert into CTSanPham values (30, 20, 5, 2)
insert into CTSanPham values (30, 20, 6, 3)

insert into CTSanPham values (30, 21, 1, 1)
insert into CTSanPham values (30, 21, 2, 2)
insert into CTSanPham values (30, 21, 3, 3)
insert into CTSanPham values (30, 21, 4, 1)
insert into CTSanPham values (30, 21, 5, 2)
insert into CTSanPham values (30, 21, 6, 3)

insert into CTSanPham values (31, 22, 1, 1)
insert into CTSanPham values (31, 22, 2, 2)
insert into CTSanPham values (31, 22, 3, 3)
insert into CTSanPham values (31, 22, 4, 1)
insert into CTSanPham values (31, 22, 5, 2)
insert into CTSanPham values (31, 22, 6, 3)

insert into CTSanPham values (31, 23, 1, 1)
insert into CTSanPham values (31, 23, 2, 2)
insert into CTSanPham values (31, 23, 3, 3)
insert into CTSanPham values (31, 23, 4, 1)
insert into CTSanPham values (31, 23, 5, 2)
insert into CTSanPham values (31, 23, 6, 3)

insert into CTSanPham values (31, 24, 1, 1)
insert into CTSanPham values (31, 24, 2, 2)
insert into CTSanPham values (31, 24, 3, 3)
insert into CTSanPham values (31, 24, 4, 1)
insert into CTSanPham values (31, 24, 5, 2)
insert into CTSanPham values (31, 24, 6, 3)

insert into CTSanPham values (31, 25, 1, 1)
insert into CTSanPham values (31, 25, 2, 2)
insert into CTSanPham values (31, 25, 3, 3)
insert into CTSanPham values (31, 25, 4, 1)
insert into CTSanPham values (31, 25, 5, 2)
insert into CTSanPham values (31, 25, 6, 3)

insert into CTSanPham values (31, 26, 1, 1)
insert into CTSanPham values (31, 26, 2, 2)
insert into CTSanPham values (31, 26, 3, 3)
insert into CTSanPham values (31, 26, 4, 1)
insert into CTSanPham values (31, 26, 5, 2)
insert into CTSanPham values (31, 26, 6, 3)

insert into CTSanPham values (31, 27, 1, 1)
insert into CTSanPham values (31, 27, 2, 2)
insert into CTSanPham values (31, 27, 3, 3)
insert into CTSanPham values (31, 27, 4, 1)
insert into CTSanPham values (31, 27, 5, 2)
insert into CTSanPham values (31, 27, 6, 3)

insert into CTSanPham values (31, 28, 1, 1)
insert into CTSanPham values (31, 28, 2, 2)
insert into CTSanPham values (31, 28, 3, 3)
insert into CTSanPham values (31, 28, 4, 1)
insert into CTSanPham values (31, 28, 5, 2)
insert into CTSanPham values (31, 28, 6, 3)

insert into CTSanPham values (31, 29, 1, 1)
insert into CTSanPham values (31, 29, 2, 2)
insert into CTSanPham values (31, 29, 3, 3)
insert into CTSanPham values (31, 29, 4, 1)
insert into CTSanPham values (31, 29, 5, 2)
insert into CTSanPham values (31, 29, 6, 3)

insert into CTSanPham values (32, 22, 1, 1)
insert into CTSanPham values (32, 22, 2, 2)
insert into CTSanPham values (32, 22, 3, 3)
insert into CTSanPham values (32, 22, 4, 1)
insert into CTSanPham values (32, 22, 5, 2)
insert into CTSanPham values (32, 22, 6, 3)

insert into CTSanPham values (32, 23, 1, 1)
insert into CTSanPham values (32, 23, 2, 2)
insert into CTSanPham values (32, 23, 3, 3)
insert into CTSanPham values (32, 23, 4, 1)
insert into CTSanPham values (32, 23, 5, 2)
insert into CTSanPham values (32, 23, 6, 3)

insert into CTSanPham values (32, 24, 1, 1)
insert into CTSanPham values (32, 24, 2, 2)
insert into CTSanPham values (32, 24, 3, 3)
insert into CTSanPham values (32, 24, 4, 1)
insert into CTSanPham values (32, 24, 5, 2)
insert into CTSanPham values (32, 24, 6, 3)

insert into CTSanPham values (32, 25, 1, 1)
insert into CTSanPham values (32, 25, 2, 2)
insert into CTSanPham values (32, 25, 3, 3)
insert into CTSanPham values (32, 25, 4, 1)
insert into CTSanPham values (32, 25, 5, 2)
insert into CTSanPham values (32, 25, 6, 3)

insert into CTSanPham values (32, 26, 1, 1)
insert into CTSanPham values (32, 26, 2, 2)
insert into CTSanPham values (32, 26, 3, 3)
insert into CTSanPham values (32, 26, 4, 1)
insert into CTSanPham values (32, 26, 5, 2)
insert into CTSanPham values (32, 26, 6, 3)

insert into CTSanPham values (32, 27, 1, 1)
insert into CTSanPham values (32, 27, 2, 2)
insert into CTSanPham values (32, 27, 3, 3)
insert into CTSanPham values (32, 27, 4, 1)
insert into CTSanPham values (32, 27, 5, 2)
insert into CTSanPham values (32, 27, 6, 3)

insert into CTSanPham values (32, 28, 1, 1)
insert into CTSanPham values (32, 28, 2, 2)
insert into CTSanPham values (32, 28, 3, 3)
insert into CTSanPham values (32, 28, 4, 1)
insert into CTSanPham values (32, 28, 5, 2)
insert into CTSanPham values (32, 28, 6, 3)

insert into CTSanPham values (32, 29, 1, 1)
insert into CTSanPham values (32, 29, 2, 2)
insert into CTSanPham values (32, 29, 3, 3)
insert into CTSanPham values (32, 29, 4, 1)
insert into CTSanPham values (32, 29, 5, 2)
insert into CTSanPham values (32, 29, 6, 3)

insert into CTSanPham values (33, 22, 1, 1)
insert into CTSanPham values (33, 22, 2, 2)
insert into CTSanPham values (33, 22, 3, 3)
insert into CTSanPham values (33, 22, 4, 1)
insert into CTSanPham values (33, 22, 5, 2)
insert into CTSanPham values (33, 22, 6, 3)

insert into CTSanPham values (33, 23, 1, 1)
insert into CTSanPham values (33, 23, 2, 2)
insert into CTSanPham values (33, 23, 3, 3)
insert into CTSanPham values (33, 23, 4, 1)
insert into CTSanPham values (33, 23, 5, 2)
insert into CTSanPham values (33, 23, 6, 3)

insert into CTSanPham values (33, 24, 1, 1)
insert into CTSanPham values (33, 24, 2, 2)
insert into CTSanPham values (33, 24, 3, 3)
insert into CTSanPham values (33, 24, 4, 1)
insert into CTSanPham values (33, 24, 5, 2)
insert into CTSanPham values (33, 24, 6, 3)

insert into CTSanPham values (33, 25, 1, 1)
insert into CTSanPham values (33, 25, 2, 2)
insert into CTSanPham values (33, 25, 3, 3)
insert into CTSanPham values (33, 25, 4, 1)
insert into CTSanPham values (33, 25, 5, 2)
insert into CTSanPham values (33, 25, 6, 3)

insert into CTSanPham values (33, 26, 1, 1)
insert into CTSanPham values (33, 26, 2, 2)
insert into CTSanPham values (33, 26, 3, 3)
insert into CTSanPham values (33, 26, 4, 1)
insert into CTSanPham values (33, 26, 5, 2)
insert into CTSanPham values (33, 26, 6, 3)

insert into CTSanPham values (33, 27, 1, 1)
insert into CTSanPham values (33, 27, 2, 2)
insert into CTSanPham values (33, 27, 3, 3)
insert into CTSanPham values (33, 27, 4, 1)
insert into CTSanPham values (33, 27, 5, 2)
insert into CTSanPham values (33, 27, 6, 3)

insert into CTSanPham values (33, 28, 1, 1)
insert into CTSanPham values (33, 28, 2, 2)
insert into CTSanPham values (33, 28, 3, 3)
insert into CTSanPham values (33, 28, 4, 1)
insert into CTSanPham values (33, 28, 5, 2)
insert into CTSanPham values (33, 28, 6, 3)

insert into CTSanPham values (33, 29, 1, 1)
insert into CTSanPham values (33, 29, 2, 2)
insert into CTSanPham values (33, 29, 3, 3)
insert into CTSanPham values (33, 29, 4, 1)
insert into CTSanPham values (33, 29, 5, 2)
insert into CTSanPham values (33, 29, 6, 3)

insert into CTSanPham values (34, 22, 1, 1)
insert into CTSanPham values (34, 22, 2, 2)
insert into CTSanPham values (34, 22, 3, 3)
insert into CTSanPham values (34, 22, 4, 1)
insert into CTSanPham values (34, 22, 5, 2)
insert into CTSanPham values (34, 22, 6, 3)

insert into CTSanPham values (34, 23, 1, 1)
insert into CTSanPham values (34, 23, 2, 2)
insert into CTSanPham values (34, 23, 3, 3)
insert into CTSanPham values (34, 23, 4, 1)
insert into CTSanPham values (34, 23, 5, 2)
insert into CTSanPham values (34, 23, 6, 3)

insert into CTSanPham values (34, 24, 1, 1)
insert into CTSanPham values (34, 24, 2, 2)
insert into CTSanPham values (34, 24, 3, 3)
insert into CTSanPham values (34, 24, 4, 1)
insert into CTSanPham values (34, 24, 5, 2)
insert into CTSanPham values (34, 24, 6, 3)

insert into CTSanPham values (34, 25, 1, 1)
insert into CTSanPham values (34, 25, 2, 2)
insert into CTSanPham values (34, 25, 3, 3)
insert into CTSanPham values (34, 25, 4, 1)
insert into CTSanPham values (34, 25, 5, 2)
insert into CTSanPham values (34, 25, 6, 3)

insert into CTSanPham values (34, 26, 1, 1)
insert into CTSanPham values (34, 26, 2, 2)
insert into CTSanPham values (34, 26, 3, 3)
insert into CTSanPham values (34, 26, 4, 1)
insert into CTSanPham values (34, 26, 5, 2)
insert into CTSanPham values (34, 26, 6, 3)

insert into CTSanPham values (34, 27, 1, 1)
insert into CTSanPham values (34, 27, 2, 2)
insert into CTSanPham values (34, 27, 3, 3)
insert into CTSanPham values (34, 27, 4, 1)
insert into CTSanPham values (34, 27, 5, 2)
insert into CTSanPham values (34, 27, 6, 3)

insert into CTSanPham values (34, 28, 1, 1)
insert into CTSanPham values (34, 28, 2, 2)
insert into CTSanPham values (34, 28, 3, 3)
insert into CTSanPham values (34, 28, 4, 1)
insert into CTSanPham values (34, 28, 5, 2)
insert into CTSanPham values (34, 28, 6, 3)

insert into CTSanPham values (34, 29, 1, 1)
insert into CTSanPham values (34, 29, 2, 2)
insert into CTSanPham values (34, 29, 3, 3)
insert into CTSanPham values (34, 29, 4, 1)
insert into CTSanPham values (34, 29, 5, 2)
insert into CTSanPham values (34, 29, 6, 3)

insert into CTSanPham values (35, 22, 1, 1)
insert into CTSanPham values (35, 22, 2, 2)
insert into CTSanPham values (35, 22, 3, 3)
insert into CTSanPham values (35, 22, 4, 1)
insert into CTSanPham values (35, 22, 5, 2)
insert into CTSanPham values (35, 22, 6, 3)

insert into CTSanPham values (35, 23, 1, 1)
insert into CTSanPham values (35, 23, 2, 2)
insert into CTSanPham values (35, 23, 3, 3)
insert into CTSanPham values (35, 23, 4, 1)
insert into CTSanPham values (35, 23, 5, 2)
insert into CTSanPham values (35, 23, 6, 3)

insert into CTSanPham values (35, 24, 1, 1)
insert into CTSanPham values (35, 24, 2, 2)
insert into CTSanPham values (35, 24, 3, 3)
insert into CTSanPham values (35, 24, 4, 1)
insert into CTSanPham values (35, 24, 5, 2)
insert into CTSanPham values (35, 24, 6, 3)

insert into CTSanPham values (35, 25, 1, 1)
insert into CTSanPham values (35, 25, 2, 2)
insert into CTSanPham values (35, 25, 3, 3)
insert into CTSanPham values (35, 25, 4, 1)
insert into CTSanPham values (35, 25, 5, 2)
insert into CTSanPham values (35, 25, 6, 3)

insert into CTSanPham values (35, 26, 1, 1)
insert into CTSanPham values (35, 26, 2, 2)
insert into CTSanPham values (35, 26, 3, 3)
insert into CTSanPham values (35, 26, 4, 1)
insert into CTSanPham values (35, 26, 5, 2)
insert into CTSanPham values (35, 26, 6, 3)

insert into CTSanPham values (35, 27, 1, 1)
insert into CTSanPham values (35, 27, 2, 2)
insert into CTSanPham values (35, 27, 3, 3)
insert into CTSanPham values (35, 27, 4, 1)
insert into CTSanPham values (35, 27, 5, 2)
insert into CTSanPham values (35, 27, 6, 3)

insert into CTSanPham values (35, 28, 1, 1)
insert into CTSanPham values (35, 28, 2, 2)
insert into CTSanPham values (35, 28, 3, 3)
insert into CTSanPham values (35, 28, 4, 1)
insert into CTSanPham values (35, 28, 5, 2)
insert into CTSanPham values (35, 28, 6, 3)

insert into CTSanPham values (35, 29, 1, 1)
insert into CTSanPham values (35, 29, 2, 2)
insert into CTSanPham values (35, 29, 3, 3)
insert into CTSanPham values (35, 29, 4, 1)
insert into CTSanPham values (35, 29, 5, 2)
insert into CTSanPham values (35, 29, 6, 3)

insert into CTSanPham values (36, 22, 1, 1)
insert into CTSanPham values (36, 22, 2, 2)
insert into CTSanPham values (36, 22, 3, 3)
insert into CTSanPham values (36, 22, 4, 1)
insert into CTSanPham values (36, 22, 5, 2)
insert into CTSanPham values (36, 22, 6, 3)

insert into CTSanPham values (36, 23, 1, 1)
insert into CTSanPham values (36, 23, 2, 2)
insert into CTSanPham values (36, 23, 3, 3)
insert into CTSanPham values (36, 23, 4, 1)
insert into CTSanPham values (36, 23, 5, 2)
insert into CTSanPham values (36, 23, 6, 3)

insert into CTSanPham values (36, 24, 1, 1)
insert into CTSanPham values (36, 24, 2, 2)
insert into CTSanPham values (36, 24, 3, 3)
insert into CTSanPham values (36, 24, 4, 1)
insert into CTSanPham values (36, 24, 5, 2)
insert into CTSanPham values (36, 24, 6, 3)

insert into CTSanPham values (36, 25, 1, 1)
insert into CTSanPham values (36, 25, 2, 2)
insert into CTSanPham values (36, 25, 3, 3)
insert into CTSanPham values (36, 25, 4, 1)
insert into CTSanPham values (36, 25, 5, 2)
insert into CTSanPham values (36, 25, 6, 3)

insert into CTSanPham values (36, 26, 1, 1)
insert into CTSanPham values (36, 26, 2, 2)
insert into CTSanPham values (36, 26, 3, 3)
insert into CTSanPham values (36, 26, 4, 1)
insert into CTSanPham values (36, 26, 5, 2)
insert into CTSanPham values (36, 26, 6, 3)

insert into CTSanPham values (36, 27, 1, 1)
insert into CTSanPham values (36, 27, 2, 2)
insert into CTSanPham values (36, 27, 3, 3)
insert into CTSanPham values (36, 27, 4, 1)
insert into CTSanPham values (36, 27, 5, 2)
insert into CTSanPham values (36, 27, 6, 3)

insert into CTSanPham values (36, 28, 1, 1)
insert into CTSanPham values (36, 28, 2, 2)
insert into CTSanPham values (36, 28, 3, 3)
insert into CTSanPham values (36, 28, 4, 1)
insert into CTSanPham values (36, 28, 5, 2)
insert into CTSanPham values (36, 28, 6, 3)

insert into CTSanPham values (36, 29, 1, 1)
insert into CTSanPham values (36, 29, 2, 2)
insert into CTSanPham values (36, 29, 3, 3)
insert into CTSanPham values (36, 29, 4, 1)
insert into CTSanPham values (36, 29, 5, 2)
insert into CTSanPham values (36, 29, 6, 3)

insert into CTSanPham values (37, 22, 1, 1)
insert into CTSanPham values (37, 22, 2, 2)
insert into CTSanPham values (37, 22, 3, 3)
insert into CTSanPham values (37, 22, 4, 1)
insert into CTSanPham values (37, 22, 5, 2)
insert into CTSanPham values (37, 22, 6, 3)

insert into CTSanPham values (37, 23, 1, 1)
insert into CTSanPham values (37, 23, 2, 2)
insert into CTSanPham values (37, 23, 3, 3)
insert into CTSanPham values (37, 23, 4, 1)
insert into CTSanPham values (37, 23, 5, 2)
insert into CTSanPham values (37, 23, 6, 3)

insert into CTSanPham values (37, 24, 1, 1)
insert into CTSanPham values (37, 24, 2, 2)
insert into CTSanPham values (37, 24, 3, 3)
insert into CTSanPham values (37, 24, 4, 1)
insert into CTSanPham values (37, 24, 5, 2)
insert into CTSanPham values (37, 24, 6, 3)

insert into CTSanPham values (37, 25, 1, 1)
insert into CTSanPham values (37, 25, 2, 2)
insert into CTSanPham values (37, 25, 3, 3)
insert into CTSanPham values (37, 25, 4, 1)
insert into CTSanPham values (37, 25, 5, 2)
insert into CTSanPham values (37, 25, 6, 3)

insert into CTSanPham values (37, 26, 1, 1)
insert into CTSanPham values (37, 26, 2, 2)
insert into CTSanPham values (37, 26, 3, 3)
insert into CTSanPham values (37, 26, 4, 1)
insert into CTSanPham values (37, 26, 5, 2)
insert into CTSanPham values (37, 26, 6, 3)

insert into CTSanPham values (37, 27, 1, 1)
insert into CTSanPham values (37, 27, 2, 2)
insert into CTSanPham values (37, 27, 3, 3)
insert into CTSanPham values (37, 27, 4, 1)
insert into CTSanPham values (37, 27, 5, 2)
insert into CTSanPham values (37, 27, 6, 3)

insert into CTSanPham values (37, 28, 1, 1)
insert into CTSanPham values (37, 28, 2, 2)
insert into CTSanPham values (37, 28, 3, 3)
insert into CTSanPham values (37, 28, 4, 1)
insert into CTSanPham values (37, 28, 5, 2)
insert into CTSanPham values (37, 28, 6, 3)

insert into CTSanPham values (37, 29, 1, 1)
insert into CTSanPham values (37, 29, 2, 2)
insert into CTSanPham values (37, 29, 3, 3)
insert into CTSanPham values (37, 29, 4, 1)
insert into CTSanPham values (37, 29, 5, 2)
insert into CTSanPham values (37, 29, 6, 3)

insert into CTSanPham values (38, 22, 1, 1)
insert into CTSanPham values (38, 22, 2, 2)
insert into CTSanPham values (38, 22, 3, 3)
insert into CTSanPham values (38, 22, 4, 1)
insert into CTSanPham values (38, 22, 5, 2)
insert into CTSanPham values (38, 22, 6, 3)

insert into CTSanPham values (38, 23, 1, 1)
insert into CTSanPham values (38, 23, 2, 2)
insert into CTSanPham values (38, 23, 3, 3)
insert into CTSanPham values (38, 23, 4, 1)
insert into CTSanPham values (38, 23, 5, 2)
insert into CTSanPham values (38, 23, 6, 3)

insert into CTSanPham values (38, 24, 1, 1)
insert into CTSanPham values (38, 24, 2, 2)
insert into CTSanPham values (38, 24, 3, 3)
insert into CTSanPham values (38, 24, 4, 1)
insert into CTSanPham values (38, 24, 5, 2)
insert into CTSanPham values (38, 24, 6, 3)

insert into CTSanPham values (38, 25, 1, 1)
insert into CTSanPham values (38, 25, 2, 2)
insert into CTSanPham values (38, 25, 3, 3)
insert into CTSanPham values (38, 25, 4, 1)
insert into CTSanPham values (38, 25, 5, 2)
insert into CTSanPham values (38, 25, 6, 3)

insert into CTSanPham values (38, 26, 1, 1)
insert into CTSanPham values (38, 26, 2, 2)
insert into CTSanPham values (38, 26, 3, 3)
insert into CTSanPham values (38, 26, 4, 1)
insert into CTSanPham values (38, 26, 5, 2)
insert into CTSanPham values (38, 26, 6, 3)

insert into CTSanPham values (38, 27, 1, 1)
insert into CTSanPham values (38, 27, 2, 2)
insert into CTSanPham values (38, 27, 3, 3)
insert into CTSanPham values (38, 27, 4, 1)
insert into CTSanPham values (38, 27, 5, 2)
insert into CTSanPham values (38, 27, 6, 3)

insert into CTSanPham values (38, 28, 1, 1)
insert into CTSanPham values (38, 28, 2, 2)
insert into CTSanPham values (38, 28, 3, 3)
insert into CTSanPham values (38, 28, 4, 1)
insert into CTSanPham values (38, 28, 5, 2)
insert into CTSanPham values (38, 28, 6, 3)

insert into CTSanPham values (38, 29, 1, 1)
insert into CTSanPham values (38, 29, 2, 2)
insert into CTSanPham values (38, 29, 3, 3)
insert into CTSanPham values (38, 29, 4, 1)
insert into CTSanPham values (38, 29, 5, 2)
insert into CTSanPham values (38, 29, 6, 3)

insert into CTSanPham values (39, 22, 1, 1)
insert into CTSanPham values (39, 22, 2, 2)
insert into CTSanPham values (39, 22, 3, 3)
insert into CTSanPham values (39, 22, 4, 1)
insert into CTSanPham values (39, 22, 5, 2)
insert into CTSanPham values (39, 22, 6, 3)

insert into CTSanPham values (39, 23, 1, 1)
insert into CTSanPham values (39, 23, 2, 2)
insert into CTSanPham values (39, 23, 3, 3)
insert into CTSanPham values (39, 23, 4, 1)
insert into CTSanPham values (39, 23, 5, 2)
insert into CTSanPham values (39, 23, 6, 3)

insert into CTSanPham values (39, 24, 1, 1)
insert into CTSanPham values (39, 24, 2, 2)
insert into CTSanPham values (39, 24, 3, 3)
insert into CTSanPham values (39, 24, 4, 1)
insert into CTSanPham values (39, 24, 5, 2)
insert into CTSanPham values (39, 24, 6, 3)

insert into CTSanPham values (39, 25, 1, 1)
insert into CTSanPham values (39, 25, 2, 2)
insert into CTSanPham values (39, 25, 3, 3)
insert into CTSanPham values (39, 25, 4, 1)
insert into CTSanPham values (39, 25, 5, 2)
insert into CTSanPham values (39, 25, 6, 3)

insert into CTSanPham values (39, 26, 1, 1)
insert into CTSanPham values (39, 26, 2, 2)
insert into CTSanPham values (39, 26, 3, 3)
insert into CTSanPham values (39, 26, 4, 1)
insert into CTSanPham values (39, 26, 5, 2)
insert into CTSanPham values (39, 26, 6, 3)

insert into CTSanPham values (39, 27, 1, 1)
insert into CTSanPham values (39, 27, 2, 2)
insert into CTSanPham values (39, 27, 3, 3)
insert into CTSanPham values (39, 27, 4, 1)
insert into CTSanPham values (39, 27, 5, 2)
insert into CTSanPham values (39, 27, 6, 3)

insert into CTSanPham values (39, 28, 1, 1)
insert into CTSanPham values (39, 28, 2, 2)
insert into CTSanPham values (39, 28, 3, 3)
insert into CTSanPham values (39, 28, 4, 1)
insert into CTSanPham values (39, 28, 5, 2)
insert into CTSanPham values (39, 28, 6, 3)

insert into CTSanPham values (39, 29, 1, 1)
insert into CTSanPham values (39, 29, 2, 2)
insert into CTSanPham values (39, 29, 3, 3)
insert into CTSanPham values (39, 29, 4, 1)
insert into CTSanPham values (39, 29, 5, 2)
insert into CTSanPham values (39, 29, 6, 3)

insert into CTSanPham values (40, 22, 1, 1)
insert into CTSanPham values (40, 22, 2, 2)
insert into CTSanPham values (40, 22, 3, 3)
insert into CTSanPham values (40, 22, 4, 1)
insert into CTSanPham values (40, 22, 5, 2)
insert into CTSanPham values (40, 22, 6, 3)

insert into CTSanPham values (40, 23, 1, 1)
insert into CTSanPham values (40, 23, 2, 2)
insert into CTSanPham values (40, 23, 3, 3)
insert into CTSanPham values (40, 23, 4, 1)
insert into CTSanPham values (40, 23, 5, 2)
insert into CTSanPham values (40, 23, 6, 3)

insert into CTSanPham values (40, 24, 1, 1)
insert into CTSanPham values (40, 24, 2, 2)
insert into CTSanPham values (40, 24, 3, 3)
insert into CTSanPham values (40, 24, 4, 1)
insert into CTSanPham values (40, 24, 5, 2)
insert into CTSanPham values (40, 24, 6, 3)

insert into CTSanPham values (40, 25, 1, 1)
insert into CTSanPham values (40, 25, 2, 2)
insert into CTSanPham values (40, 25, 3, 3)
insert into CTSanPham values (40, 25, 4, 1)
insert into CTSanPham values (40, 25, 5, 2)
insert into CTSanPham values (40, 25, 6, 3)

insert into CTSanPham values (40, 26, 1, 1)
insert into CTSanPham values (40, 26, 2, 2)
insert into CTSanPham values (40, 26, 3, 3)
insert into CTSanPham values (40, 26, 4, 1)
insert into CTSanPham values (40, 26, 5, 2)
insert into CTSanPham values (40, 26, 6, 3)

insert into CTSanPham values (40, 27, 1, 1)
insert into CTSanPham values (40, 27, 2, 2)
insert into CTSanPham values (40, 27, 3, 3)
insert into CTSanPham values (40, 27, 4, 1)
insert into CTSanPham values (40, 27, 5, 2)
insert into CTSanPham values (40, 27, 6, 3)

insert into CTSanPham values (40, 28, 1, 1)
insert into CTSanPham values (40, 28, 2, 2)
insert into CTSanPham values (40, 28, 3, 3)
insert into CTSanPham values (40, 28, 4, 1)
insert into CTSanPham values (40, 28, 5, 2)
insert into CTSanPham values (40, 28, 6, 3)

insert into CTSanPham values (40, 29, 1, 1)
insert into CTSanPham values (40, 29, 2, 2)
insert into CTSanPham values (40, 29, 3, 3)
insert into CTSanPham values (40, 29, 4, 1)
insert into CTSanPham values (40, 29, 5, 2)
insert into CTSanPham values (40, 29, 6, 3)
go

---Hóa Đơn Nhập
insert into HDNhap values (1, 1,1,'05-20-2019', 0)
insert into HDNhap values (2, 1,1,'05-20-2019', 0)
go


--Khach hang
insert into KhachHang values (1, N'Nam', N'hehe', N'hehe', N'0123', 0, 1 )
go
--Hóa đơn xuất
insert into HDXuat values (1, 1, 1, '2020-05-13', 0, 1, N'Khách hàng lấy muộn', null)
go
---CTHDN
insert into CTHDNhap values (1, 1, 1, 1, 10, 50000, 500000)
go

----NCC-----
create proc selectncc 
as
select * from NhaCungCap
go

create proc insertncc (@ma int, @ten nvarchar (1000), @diachi nvarchar (1000), @sdt nchar (1000))
as
insert into NhaCungCap values (@ma, @ten, @diachi, @sdt)
go

create proc updatencc (@ma int, @ten nvarchar (1000), @diachi nvarchar (1000), @sdt nchar (1000))
as
update NhaCungCap set Ten = @ten, DiaChi = @diachi, SoDienThoai = @sdt where Ma = @ma
go

create proc deletencc (@ma int)
as
delete from NhaCungCap where Ma = @ma
go

create proc TKNCC (@tk nvarchar (100))
as
select * from NhaCungCap 
where CONCAT (Ma, Ten, DiaChi, SoDienThoai) like '%'+@tk+'%' 

go

----Chuc Vu
create proc selectchucvu
as
select * from ChucVu
go


----NhanVien
create proc selectnv
as
select Ma, Ten, Ma_CV, GioiTinh, DiaChi, Email, NgaySinh, taikhoan,HoatDong from NhanVien
except select Ma, Ten, Ma_CV, GioiTinh, DiaChi, Email, NgaySinh, taikhoan,HoatDong from NhanVien where ma =1
go

create proc insertnv (@ma int, @ten nvarchar (1000), @chucvu int, @gioitinh nvarchar (100), @diachi nvarchar (1000), @email nvarchar (1000), @ngaysinh date, @ngayvl date, @taikhoan nchar (1000), @matkhau nchar (1000), @hinhanh image)
as
insert into NhanVien (Ma, Ten, Ma_CV, GioiTinh,DiaChi,Email, NgaySinh, NgayVaoLam, taikhoan, matkhau, Hinhanh, HoatDong)
values (@ma, @ten, @chucvu, @gioitinh, @diachi, @email, @ngaysinh, @ngayvl, @taikhoan, @matkhau, @hinhanh, 1)
go

create proc updatenv (@ma int, @ten nvarchar (1000), @chucvu int, @gioitinh nvarchar (1000), @diachi nvarchar (1000), @email nvarchar (1000), @ngaysinh date, @ngayvl date, @hinhanh image)
as
update NhanVien set  Ten = @ten, Ma_CV = @chucvu, GioiTinh = @gioitinh, DiaChi = @diachi, Email = @email, NgaySinh = @ngaysinh, NgayVaoLam= @ngayvl, Hinhanh = @hinhanh where Ma = @ma
go

create proc deletenv (@ma int)
as
delete from NhanVien where Ma = @ma
go

create proc updatemkmahoa (@ma int, @matkhau nchar(50))
as
update NhanVien set matkhau = @matkhau where Ma = @ma
go

create proc TKNV (@a nvarchar (100))
as
select NV.Ma, NV.Ten, nv.Ma_CV, nv.GioiTinh, nv.DiaChi,nv.Email,nv.NgaySinh, nv.taikhoan, nv.HoatDong from NhanVien NV, ChucVu CV
where CONCAT(NV.Ma, nv.Ten, CV.Ten,nv.GioiTinh, nv.DiaChi,nv.Email,nv.NgaySinh, nv.taikhoan, nv.HoatDong) like '%'+@a+'%' and Nv.Ma_CV = CV.Ma
go

create proc updateHoatDongnv (@ma int , @hoatdong bit)
as
update NhanVien set HoatDong = @hoatdong where Ma = @ma
go

---Size
create proc cbbSize (@LoaiSp int)
as
select * from Size where Ma_LoaiSP = @LoaiSp
go

----HDN
create proc insertHDN (@ma int, @mancc int, @manv int, @ngaynhap date, @tongtien int)
as
insert into HDNhap values (@ma, @mancc, @manv, @ngaynhap, @tongtien)
go

create proc updateHDN (@ma int, @mancc int, @tongtien int)
as
update HDNhap set Ma_NCC = @mancc, TongTien = @tongtien where Ma = @ma
go

create proc selectHDN 
as
select * from HDNhap
go

create proc updatetongtienHDN (@mahdn int , @tongtien int)
as
update HDNhap set TongTien = @tongtien where Ma = @mahdn
go

create proc ngaytrongnam_HDN (@maHDN int)
as
select DATEPART(dayofyear, NgayNhap) as 'ngay', DATEPART(year, NgayNhap) as 'nam'  from HDNhap where Ma = @maHDN
go

create proc TKHDN (@tk nvarchar (1000))
as 
select HDN.Ma, HDN.Ma_NCC, HDN.Ma_NV, HDN.NgayNhap, HDN.TongTien from HDNhap HDN, NhanVien NV, NhaCungCap NCC 
where CONCAT(HDN.Ma, NCC.Ten, NV.Ten, HDN.NgayNhap, HDN.TongTien) like '%' +@tk+'%' and
HDN.Ma_NV = NV.Ma and HDN.Ma_NCC = NCC.Ma
go

create proc selectTTHDN (@ma int)
as
select * from HDNhap where Ma = @ma
go
---CTHDN
--create proc CTHDN 
--as 
--select CTHDN.Ma, CTHDN.Ma_SP, (select sum(Soluong) from ThongTinCTHDN where ThongTinCTHDN.Ma_CTHDN = 1)  as N'soluong', CTHDN.DonGia, CTHDN.ThanhTien 
--from CTHDNhap CTHDN, ThongTinCTHDN TTCTHDN , HDNhap HDN
--where CTHDN.Ma = TTCTHDN.Ma_CTHDN and CTHDN.Ma_HDN = HDN.Ma and HDN.Ma = 1
--group by CTHDN.Ma, CTHDN.Ma_SP, CTHDN.DonGia, CTHDN.ThanhTien
--go


create proc insertCTHDN ( @mahdn int, @maSP int, @maSize int, @maMauSac int ,@soluong int, @dongia int, @thanhtien int)
as
insert into CTHDNhap values ( @mahdn, @maSP, @maSize, @maMauSac, @soluong, @dongia, @thanhtien)
go

create proc updateCTHDN (@mahdn int, @maSP int, @maSize int, @maMauSac int, @soluong int, @dongia int, @thanhtien int)
as
update CTHDNhap set SoLuong = @soluong, dongia = @dongia, thanhtien = @thanhtien 
where Ma_HDN = @mahdn and Ma_SP = @maSP and Ma_Size = @maSize and Ma_MauSac = @maMauSac
go

create proc deleteCTHDN (@mahdn int, @maSP int, @maSize int, @maMauSac int)
as
delete from CTHDNhap where Ma_HDN = @mahdn and Ma_SP = @maSP and Ma_Size = @maSize and Ma_MauSac = @maMauSac
go

create proc selectCTHDN (@mahdn int)
as
select * from CTHDNhap where Ma_HDN = @mahdn
go
create proc updatethanhtiensoluongCTHDN (@mahdn int, @maSP int, @ma_Size int, @ma_MauSac int,@soluong int, @thanhtien int)
as
update CTHDNhap set SoLuong = @soluong,  ThanhTien = @thanhtien 
where Ma_HDN = @mahdn and Ma_SP = @maSP and Ma_Size = @ma_Size and Ma_MauSac = @ma_MauSac
go
create proc selectTTCTHDN (@mahdn int, @masp int, @masize int, @mamau int)
as
select * from CTHDNhap where Ma_HDN = @mahdn and Ma_SP = @masp and Ma_Size = @masize and Ma_MauSac = @mamau
go
create proc loadDG (@ma int, @masp int)
as
select * from CTHDNhap where Ma_HDN = @ma and Ma_SP = @masp
go



-----TTCTHDN
--create proc selectTTCTHDN (@maHDN int)
--as
--select CTHDN.Ma_SP, TTCTHDN.Ma_Size, TTCTHDN.Ma_MauSac, TTCTHDN.Soluong
--from ThongTinCTHDN TTCTHDN, CTHDNhap CTHDN, HDNhap HDN
--where CTHDN.Ma_HDN = HDN.Ma and HDN.Ma = @maHDN
--go

--create proc insertTTCTHDN (@ma_CTHCN int, @size int, @mau int, @soluong int)
--as
--insert into ThongTinCTHDN values (@ma_CTHCN, @size, @ma_CTHCN, @soluong)
--go

--create proc updateTTCTHDN (@ma_CTHCN int, @size int, @mau int, @soluong int)
--as
--update ThongTinCTHDN set Soluong = @soluong where Ma_CTHDN = @ma_CTHCN and Ma_Size = @size and Ma_MauSac = @mau
--go

--create proc deleteTTCTHDN (@ma_CTHDN int, @size int, @mau int)
--as
--delete from ThongTinCTHDN where Ma_CTHDN = @ma_CTHDN and Ma_Size = @size and Ma_MauSac = @mau
--go



----SP
create proc selectSP 
as
select * from SanPham
go

create proc insertSP (@ma int, @loai int, @ten nvarchar (1000), @gia int,  @hinhanh image)
as
insert into SanPham values (@ma, @loai, @ten, @gia,  @hinhanh)
go

create proc updateSP (@ma int, @loai int, @ten nvarchar (1000), @gia int,  @hinhanh image)
as
update SanPham set Ten = @ten, DonGia = @gia, HinhAnh = @hinhanh, Ma_LoaiSP = @loai where Ma = @ma
go

create proc TKSP (@text nvarchar (1000))
as 
select SP.Ma, Sp.Ten, SP.DonGia, SP.Ma_LoaiSP from SanPham SP, LoaiSP L where CONCAT(SP.Ma, SP.Ten, SP.DonGia, L.Ten ) like '%' +@text+ '%' and SP.Ma_LoaiSP = L.Ma
go

create proc TKSPTrongHD (@tk nvarchar (1000))
as
select Ma, Ten, HinhAnh from SanPham where CONCAT(Ma, Ten) like '%' + @tk + '%'
go
---CTSP
create proc insertCTSP (@maSP int, @maSize int, @maMau int, @soluong int)
as
insert into CTSanPham values (@maSP, @maSize, @maMau, @soluong)
go

create proc updateSLT (@maSP int, @maSize int, @maMau int, @soluong int)
as
update CTSanPham set Soluong = @soluong where Ma_SP = @maSP and Ma_Size = @maSize and Ma_MauSac = @maMau
go

create proc selectCTSP
as
select * from CTSanPham
go

create proc selectTTCTSP (@maSP int, @ma_Size int, @ma_Mau int)
as
select * from CTSanPham where Ma_SP = @maSP and Ma_Size = @ma_Size and Ma_MauSac = @ma_Mau
go




---KhachHang
create proc insertKH (@ma int, @ten nvarchar(1000), @Email nvarchar (1000), @Diachi nvarchar (1000), @SDT nvarchar (1000))
as
insert into KhachHang values (@ma, @ten, @Email, @Diachi, 0 , 1, @SDT)
go

create proc updateKH (@ma int, @ten nvarchar (1000), @Email nvarchar (1000), @DiaChi nvarchar (1000), @SDT nvarchar (1000))
as
update KhachHang set Ten = @ten, Email = @Email, DiaChi = @DiaChi, SoDienThoai = @SDT where Ma = @ma
go

create proc selectKH
as
select * from KhachHang
go

create proc updateKH_LoaiKH (@ma int, @loaikh int)
as
update KhachHang set Ma_LoaiKH = @loaikh
go

create proc selectTTKH (@ma int)
as
select * from KhachHang where Ma = @ma 
go

create proc updateLKH (@ma int, @loaikh int)
as
update KhachHang set Ma_LoaiKH = @loaikh where Ma = @ma
go

create proc updatediemtichluy (@ma int, @diem int)
as
update KhachHang set DiemTichLuy = @diem where Ma = @ma
go
---LoaiSP
create proc selectLoaiSP 
as
select * from LoaiSP
go

create proc insertLoaiSP (@ma int, @ten nvarchar (1000))
as
insert into LoaiSP values (@ma, @ten)
go



---HDX
create proc insertHDX (@ma int, @ma_KH int, @ma_NV int, @ngayxuat date, @ghichu nvarchar (1000), @QR image)
as
insert into HDXuat values (@ma, @ma_KH, @ma_NV, @ngayxuat, 0, 1, @ghichu, @QR)
go
create proc updateTrangThaiHuy (@ma int, @ghichu nvarchar (1000))
as
update HDXuat set GhiChu = @ghichu, TrangThai = 0 where Ma = @ma
go
create proc TKHDX (@tk nvarchar (1000))
as 
select HDX.Ma, HDX.Ma_KH, HDX.Ma_NV, HDX.NgayXuat, HDX.TongTien,HDX.TrangThai, HDX.GhiChu  from HDXuat HDX, NhanVien NV, KhachHang KH
where CONCAT(HDX.Ma, KH.Ten, NV.Ten, HDX.NgayXuat, HDX.TongTien, HDX.GhiChu) like '%' +@tk+'%' and
HDX.Ma_NV = NV.Ma and HDX.Ma_KH = KH.Ma
go
create proc selectTTHDX (@ma int)
as
select * from HDXuat where Ma = @ma
go
create proc updateTongTienHDX (@ma int, @tongtien int)
as
update HDXuat set TongTien = @tongtien where Ma = @ma
go
create proc updateghichu (@ma int,@ghichu nvarchar (1000))
as
update HDXuat set GhiChu = @ghichu where Ma = @ma
go
create proc selectHDX 
as
select * from HDXuat 
go

	create proc HuyHDX (@ngay date)
	as
	declare @ngaytrongnam int
	set @ngaytrongnam = DATEPART(dy, @ngay)
	select @ngaytrongnam
	go

--CTHDX
create proc insertCTHDX (@mahdx int,@masp int, @masize int, @mamau int, @soluong int, @thanhtien int)
as
insert into CTHDXuat values (@mahdx, @masp, @masize, @mamau, @soluong, @thanhtien)
go

create proc updateCTHDX (@mahdx int, @masp int, @masize int, @mamau int, @soluong int, @thanhtien int)
as
update CTHDXuat set SoLuong =@soluong, ThanhTien = @thanhtien where Ma_HDX = @mahdx and Ma_SP = @masp and Ma_Size = @masize and Ma_MauSac = @mamau
go

create proc deleteCTHDX (@mahdx int, @masp int, @masize int, @mamau int)
as
delete from CTHDXuat where Ma_HDX = @mahdx and Ma_SP = @masp and Ma_Size = @masize and Ma_MauSac = @mamau
go

create proc selectCTHDX (@ma int)
as
select * from CTHDXuat where Ma_HDX = @ma
go

create proc selectTTCTHDX (@mahdx int, @masp int, @masize int, @mamau int)
as
select * from CTHDXuat where Ma_HDX = @mahdx and Ma_SP = @masp and Ma_Size = @masize and Ma_MauSac = @mamau
go

create proc updateSoLuongTTCTHDX (@mahdx int, @masp int, @masize int, @mamau int, @soluong int, @thanhtien int)
as
update CTHDXuat set SoLuong = @soluong , ThanhTien = @thanhtien where Ma_HDX = @mahdx and Ma_SP = @masp and Ma_Size = @masize and Ma_MauSac = @mamau 
go

--LoaiKH


--Email
create proc updateEmail (@tk nvarchar (1000), @mk nvarchar (1000))
as
update Email set TaiKhoan = @tk, MatKhau = @mk where Ma = 1
go
select * from CTHDXuat where Ma_HDX =2
go
---Report
create proc selectRePortHDX(@mahdx int)
as
select *
from SanPham SP, Size SZ, MauSac MS,  CTHDXuat CTHDX, NhanVien NV, KhachHang KH, HDXuat HDX, LoaiKH LKH
where HDX.Ma=@mahdx and HDX.Ma_NV = NV.Ma and HDX.Ma_KH = KH.Ma  and KH.Ma_LoaiKH = LKH.Ma and CTHDX.Ma_HDX = HDX.Ma and CTHDX.Ma_SP = SP.Ma and CTHDX.Ma_Size= SZ.Ma and CTHDX.Ma_MauSac = MS.Ma

go

create proc TTHDXReport (@mahdx int)
as
select * from HDXuat HDX, NhanVien NV, KhachHang KH
where HDX.Ma = @mahdx and HDX.Ma_NV = NV.Ma and HDX.Ma_KH = KH.Ma

--Thống kê

go

--Năm bán hàng
create proc NamBanHang
as
select DATEPART(YY, NgayXuat) as N'Nam' from HDXuat 
group  by  DATEPART(YY, NgayXuat)
go
--Năm nhập hàng
create proc NamNhapHang 
as
select DATEPART(YY, NgayNhap) as N'Nam' from HDNhap
group  by  DATEPART(YY, NgayNhap)
go
--Doanh Thu năm 
create proc DoanhThuNamHienTai 
as
select Sum (TongTien) as N'TongTien' from HDXuat where DATEPART(YY, NgayXuat) = DATEPART(YY, getdate())
go
--SoluongHD đã bán trong năm
create proc SoLuongHDXDaBan
as
select Count (Ma ) as 'SoLuong' From HDXuat where DATEPART(YY, NgayXuat) = DATEPART(YY, getdate()) and TrangThai = 'True'
go

create proc TienNhapTheoThangCuaNam (@nam int)
as
begin
declare @sothang int =0;
declare @tongtien int =0;
Delete from TempChi
--	create table if not exists TempChi ( Thang nvarchar (50), TongTien  int)
	while @sothang <=11
	begin
		set @tongtien = 0
		set @sothang = @sothang +1;
		 select @tongtien =  Sum(TongTien)  From HDNhap
						where DATEPART (YY, NgayNhap) = @nam AND DATEPART(MM, NgayNhap) = @sothang
		 if (@tongtien is null)
		 begin
			set @tongtien = 0;
		 end
		insert into TempChi values (N'Tháng ' + cast( @sothang as nvarchar), @tongtien)
	end
	select * from TempChi 
end
go
create proc TienBanTheoThangCuaNam (@nam int)
as
begin
declare @sothang int =0;
declare @tongtien int =0;
Delete from TempThu
--	create table TempThu ( Thang nvarchar (50), TongTien  int)
	while @sothang <=11
	begin
		set @tongtien = 0
		set @sothang = @sothang +1;
		 select @tongtien =  Sum(TongTien)  From HDXuat
						where DATEPART (YY, NgayXuat) = @nam AND DATEPART(MM, NgayXuat) = @sothang and TrangThai = 'True'
		 if (@tongtien is null)
		 begin
			set @tongtien = 0;
		 end
		insert into TempThu values (N'Tháng ' + cast( @sothang as nvarchar), @tongtien)
	end
	select * from TempThu 
end
go

--Danh sach HDN trong nam
create proc DanhSachHDNTrongNam  (@nam int)
as
select HDN.Ma, NV.Ten, NCC.Ten as N'TenNCC', HDN.NgayNhap, HDN.TongTien from HDNhap HDN, NhanVien NV, NhaCungCap NCC 
where DATEPART (YY, NgayNhap) = @nam and HDN.Ma_NCC = NCC.Ma and HDN.Ma_NV =NV.Ma
go

--Danh Sách HDX trong nam
create proc DanhSachHDXtTrongNam (@nam int)
as
select HDX.Ma , NV.Ten,  KH.Ten as N'TenKH', HDX.NgayXuat, HDX.GhiChu, HDX.TongTien  from HDXuat HDX, KhachHang KH, NhanVien NV 
where DATEPART (YY, NgayXuat ) = @nam and HDX.Ma_KH = KH.Ma and HDX.Ma_NV = NV.Ma and TrangThai = 'True'
go


--Thống kê kh đã mua gì
create proc TKKHmuagi 
as
select HDX.Ma, KH.Ten as N'TKH',  SP.Ten as N'SP' , MS.TenMau, SZ.TenSize, CTHDX.SoLuong
from HDXuat HDX, CTHDXuat CTHDX, KhachHang KH, SanPham SP, MauSac MS, Size SZ
where HDX.Ma = CTHDX.Ma_HDX and HDX.Ma_KH = KH.Ma  and CTHDX.Ma_SP = SP.Ma and CTHDX.Ma_Size = SZ.Ma and CTHDX.Ma_MauSac = MS.Ma and HDX.TrangThai = 'True'
go

-- Thống kê số lương tồn của từng loại sản phẩm
create proc ThongKeSLTLoaiSP (@maloai int)
as
select SP.Ten,LSP.Ten as N'Loai' , SZ.TenSize, MS.TenMau, CTSP.Soluong  from CTSanPham CTSP, SanPham SP, MauSac MS, Size SZ, LoaiSP LSP 
where LSP.Ma = @maloai and SP.Ma_LoaiSP = LSP.Ma and CTSP.Ma_SP = SP.Ma and CTSP.Ma_MauSac = MS.Ma and CTSP.Ma_Size = SZ.Ma
order by CTSP.Soluong, SP.Ten asc 
go
--
--select * from CTHDNhap
--select * from ThongTinCTHDN
--select * from CTSanPham
--select * from MauSac
