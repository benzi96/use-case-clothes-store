create database cuahang
create table dondathang
(
madondathang int primary key IDENTITY(1,1),
ngaydathang datetime,
nhacungcap nvarchar(50)
)

create table chitietdondathang
(
stt int,
madondathang int not null,
id int not null,
soluongdat int,
soluongnhan int,
gianhap decimal (10),
trangthai nvarchar(50),
lido nvarchar(500),
tinhtrang nvarchar(50)

primary key(madondathang,stt),
foreign key(madondathang) references dondathang(madondathang),
foreign key(id) references sanpham(id)
)

create table sanpham
(
id int primary key IDENTITY(1,1),
masp nvarchar(50) unique not null,
tensp nvarchar(100) unique not null,
size nvarchar(10),
hang nvarchar(50),
giamgia float,
soluongtonkho int,
giaban decimal(10),
ngaynhap datetime
)
create table hoadon
(
mahoadon int primary key IDENTITY(1,1),
ngayban datetime
)

create table chitiethoadon
(
stt int,
mahoadon int not null,
id int not null,
giaban decimal(10),
soluongmua int,
primary key(mahoadon,stt),
foreign key(mahoadon) references hoadon(mahoadon),
foreign key(id) references sanpham(id)
)

Alter table hoadon
add tienkhachdua decimal(10);