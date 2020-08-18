create database lopthaychi
go 
use lopthaychi
go

create table TaiKhoan(
	MaTK int primary key Identity(1,1),
	Hoten nvarchar(100),
	Email varchar(50),
	SDT int,
	Fb varchar(50),
	DiaChi varchar(50),
	Quyen nvarchar(50),
	Username varchar(50),
	Password varchar(50)
)
create table MonHoc(
	MaMH int primary key Identity(1,1),
	TenMH nvarchar(50)
)

create table Teacher(
	MaGV int primary key Identity(1,1),
	TenGV nvarchar(100),
	Fb varchar(50)
)

create table  HocPhi(
	MaHP int primary key Identity(1,1),
	MaMH int,
	HocPhi int
)

create table TaiLieuHocTap(
	MaTL int primary key Identity(1,1),
	MonHoc int FOREIGN KEY REFERENCES MonHoc(MaMH),
	TaiLieu nvarchar(max)
)
create table ThongBao(
	MaTB int primary key Identity(1,1),
	BaiViet nvarchar(max)
)
alter table ThongBao
add Image varchar(100),
chitietthongbao int foreign key references Detail_Thongbao(MaDTB)

create table Detail_Thongbao(
	MaDTB int primary key Identity(1,1),
	Baiviet nvarchar(max),
	Image varchar(100)
)

create table Detail_BLog(
	MaDBL int primary key Identity(1,1),
	Baiviet nvarchar(max),
	Image nvarchar(100),
)

create table Blog(
	MaBL int primary key Identity(1,1),
	Baiviet nvarchar(1000),
	Image nvarchar(100),
	ChiTietBlog int Foreign key references Detail_BLog(MaDBL),
)


create table TinhTrangHocPhi(
	MaTTHP int primary key IdentiTy (1,1),
	Tinhtranghp nvarchar(50),
	Status varchar(50)
)

create table TinhTrangHocTap(
	MaTTHT int primary key Identity(1,1),
	TinhTrangHT nvarchar(50),
	LoiNhac nvarchar(50)
)
create table Student(
	MaHS int primary key Identity(1,1),
	HoTenHS nvarchar(100),
	HoTenPH nvarchar(100),
	MonHoc int FOREIGN KEY REFERENCES MonHoc(MaMH),
	Lop int,
	HocPhi int FOREIGN KEY REFERENCES HocPhi(MaHP),
	NgayDangKi date,
	NgayBatDauHoc date,
	TinhTrangHT int FOREIGN KEY REFERENCES TinhTrangHocTap(MaTTHT),
	TinhTrangHP int FOREIGN KEY REFERENCES TinhTrangHocPhi(MaTTHP),
	LoiNhac nvarchar(max),
	NgayDongHocPhi date
)
create table Teacher_Student(
	MaHS int FOREIGN KEY REFERENCES Student(MaHS),
	MaGV int FOREIGN KEY REFERENCES Teacher(MaGV)
)
---------proc thêm dữ liệu-------------
--Hoc Phi--
create proc HocPhi_Them(
	@MaMH int,
	@HocPhi int
)
as 
	insert into HocPhi(MaMH,HocPhi)
	values (@MaMH,@HocPhi)
go

--Mon Hoc--
create proc MonHoc_Them(
	@TenMH nvarchar(50)
)
as 
	insert into MonHoc(TenMH)
	values (@TenMH)
go

--Tai Khoan--
create proc TaiKhoan_Them(
	@Hoten nvarchar(100),
	@Email varchar(50),
	@SDT int,
	@Fb varchar(50),
	@DiaChi nvarchar(50),
	@Quyen varchar(50),
	@Username varchar(50),
	@Password varchar(50)

)
as
	insert into TaiKhoan(Hoten,Email,SDT,Fb,DiaChi,Quyen,Username,Password)
	values (@Hoten,@Email,@SDT,@Fb,@DiaChi,@Quyen,@Username,@Password)
go

--Student--
create proc Student_Them(
	@hotenhs nvarchar(100),
	@hotenph nvarchar(100),
	@monhoc int,
	@lop int,
	@hocphi int,
	@ngaydangki date,
	@ngaybatdauhoc date,
	@tinhtranght int,
	@tinhtranghp int,
	@loinhac nvarchar(100),
	@ngaydonghp date
)
as 
	insert into Student(HoTenHS,HoTenPH,MonHoc,Lop,HocPhi,NgayDangKi,NgayBatDauHoc,TinhTrangHT,TinhTrangHP,LoiNhac,NgayDongHocphi)
	values (@hotenhs,@hotenph,@monhoc,@lop,@hocphi,@ngaydangki,@ngaybatdauhoc,@tinhtranght,@tinhtranghp,@loinhac,@ngaydonghp)
go

-----Teacher----

create proc Teacher_Them(
	@TenGV nvarchar(100),
	@Fb varchar(50)
)
as 
	insert into Teacher(TenGV,Fb)
	values (@TenGV,@Fb)
go

-------Teacher_Student---------
create proc Teacher_Student_Them(
	@MaHS int,
	@MaGV int

)

as 
	insert into Teacher_Student(MaHS,MaGV)
	values (@MaHS,@MaGV)
go

------Tinh trang hoc phi--------
create proc TinhTrangHocPhi_Them(
	@Tinhtranghocphi nvarchar(50),
	@Status varchar(50)

)
as 
	insert into TinhTrangHocPhi(Tinhtranghp,Status)
	values (@Tinhtranghocphi,@Status)
go

-------Tinh trang hoc tap------
create proc TinhTrangHocTap_Them(
	@Tinhtranght nvarchar(100),
	@Loinhac nvarchar(50)
)
as 
	insert into TinhTrangHocTap(TinhTrangHT,LoiNhac)
	values (@Tinhtranght,@Loinhac)
go
-----------------------------
-----------Chèn dữ liệu vào db------------

go
MonHoc_Them N'Toán + Tiếng Việt'
go
MonHoc_Them N'Tiếng Anh'
go
MonHoc_Them N'Vẽ'
go
MonHoc_Them N'Kỹ Năng Khác'

select * from MonHoc

go 
HocPhi_Them 1,400000
go
HocPhi_Them 2,350000
go
HocPhi_Them 3,350000

select * from HocPhi

go 
Teacher_Them N'Tuyết Trinh','https://www.facebook.com/profile.php?id=100009005449359'
go
Teacher_Them N'Phạm Diễm','https://www.facebook.com/profile.php?id=100034812823605'
go
Teacher_Them N'Nguyễn Văn Duy','https://www.facebook.com/Rom.2904'
go
Teacher_Them N'Võ Ngọc','https://www.facebook.com/nvothi'
go
Teacher_Them N'Lưu Tấn Chí','https://www.facebook.com/chi190715'

select * from Teacher

go
Tinhtranghocphi_Them N'Đã nộp',''
go
Tinhtranghocphi_Them N'Chưa nộp',''

select * from TinhTrangHocPhi

go
Tinhtranghoctap_Them N'Vượt bậc',N'Tốt'
go
Tinhtranghoctap_Them N'Đạt',N'Tốt'
go
Tinhtranghoctap_Them N'Chưa đạt',N'Cần cố gắng hơn'

select * from TinhTrangHocTap
select * from MonHoc
select * from HocPhi
select * from Student

go
Student_Them N'Anh Tú',N'Tuấn',1,2,1,'2020-08-11','2020-08-12',1,1,N'tiến bộ',''

go
TaiKhoan_Them N'Nguyễn Văn Duy','vanduy290499@gmail.com',0796831837,'https://www.facebook.com/Rom.2904','',1,'duy2904','vanduy2904'
go
TaiKhoan_Them N'Lớp Thầy Chí','lopthaychi@gmail.com','','https://www.facebook.com/chi190715',N'186 Nguyễn Văn Cừ',1,'lopthaychi','lopthaychi!@#'

select * from TaiKhoan