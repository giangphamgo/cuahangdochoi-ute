USE [master]
GO
/****** Object:  Database [QuanLyCuaHangDoChoi]    Script Date: 2019-11-05 10:36:34 AM ******/
CREATE DATABASE [QuanLyCuaHangDoChoi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyCuaHangDoChoi', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\QuanLyCuaHangDoChoi.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyCuaHangDoChoi_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\QuanLyCuaHangDoChoi_log.ldf' , SIZE = 6400KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyCuaHangDoChoi] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyCuaHangDoChoi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyCuaHangDoChoi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyCuaHangDoChoi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyCuaHangDoChoi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyCuaHangDoChoi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyCuaHangDoChoi] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyCuaHangDoChoi] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyCuaHangDoChoi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyCuaHangDoChoi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyCuaHangDoChoi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyCuaHangDoChoi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyCuaHangDoChoi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyCuaHangDoChoi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyCuaHangDoChoi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyCuaHangDoChoi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyCuaHangDoChoi] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyCuaHangDoChoi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyCuaHangDoChoi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyCuaHangDoChoi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyCuaHangDoChoi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyCuaHangDoChoi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyCuaHangDoChoi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyCuaHangDoChoi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyCuaHangDoChoi] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLyCuaHangDoChoi] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyCuaHangDoChoi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyCuaHangDoChoi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyCuaHangDoChoi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyCuaHangDoChoi] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QuanLyCuaHangDoChoi] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyCuaHangDoChoi', N'ON'
GO
ALTER DATABASE [QuanLyCuaHangDoChoi] SET QUERY_STORE = OFF
GO
USE [QuanLyCuaHangDoChoi]
GO
/****** Object:  User [root]    Script Date: 2019-11-05 10:36:35 AM ******/
CREATE USER [root] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[root]
GO
/****** Object:  User [QL2]    Script Date: 2019-11-05 10:36:35 AM ******/
CREATE USER [QL2] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[QL2]
GO
/****** Object:  User [QL1]    Script Date: 2019-11-05 10:36:35 AM ******/
CREATE USER [QL1] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[QL1]
GO
/****** Object:  User [NV3]    Script Date: 2019-11-05 10:36:35 AM ******/
CREATE USER [NV3] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[NV3]
GO
/****** Object:  User [NV2]    Script Date: 2019-11-05 10:36:35 AM ******/
CREATE USER [NV2] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[NV2]
GO
/****** Object:  User [NV1]    Script Date: 2019-11-05 10:36:35 AM ******/
CREATE USER [NV1] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[NV1]
GO
/****** Object:  DatabaseRole [Manager]    Script Date: 2019-11-05 10:36:35 AM ******/
CREATE ROLE [Manager]
GO
/****** Object:  DatabaseRole [Employee]    Script Date: 2019-11-05 10:36:35 AM ******/
CREATE ROLE [Employee]
GO
ALTER ROLE [Manager] ADD MEMBER [root]
GO
ALTER ROLE [db_owner] ADD MEMBER [root]
GO
ALTER ROLE [Manager] ADD MEMBER [QL2]
GO
ALTER ROLE [db_owner] ADD MEMBER [QL2]
GO
ALTER ROLE [Manager] ADD MEMBER [QL1]
GO
ALTER ROLE [db_owner] ADD MEMBER [QL1]
GO
ALTER ROLE [Employee] ADD MEMBER [NV3]
GO
ALTER ROLE [Employee] ADD MEMBER [NV2]
GO
ALTER ROLE [Employee] ADD MEMBER [NV1]
GO
ALTER ROLE [db_owner] ADD MEMBER [Manager]
GO
/****** Object:  Schema [NV1]    Script Date: 2019-11-05 10:36:35 AM ******/
CREATE SCHEMA [NV1]
GO
/****** Object:  Schema [NV2]    Script Date: 2019-11-05 10:36:35 AM ******/
CREATE SCHEMA [NV2]
GO
/****** Object:  Schema [NV3]    Script Date: 2019-11-05 10:36:35 AM ******/
CREATE SCHEMA [NV3]
GO
/****** Object:  Schema [QL1]    Script Date: 2019-11-05 10:36:35 AM ******/
CREATE SCHEMA [QL1]
GO
/****** Object:  Schema [QL2]    Script Date: 2019-11-05 10:36:35 AM ******/
CREATE SCHEMA [QL2]
GO
/****** Object:  Schema [root]    Script Date: 2019-11-05 10:36:35 AM ******/
CREATE SCHEMA [root]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 2019-11-05 10:36:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[Ma_KH] [nvarchar](10) NOT NULL,
	[Ten_KH] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Dienthoai] [nvarchar](20) NULL,
	[Email] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma_KH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HD_BanHang]    Script Date: 2019-11-05 10:36:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HD_BanHang](
	[Ma_HDBH] [nvarchar](10) NOT NULL,
	[Ma_NV] [nvarchar](10) NULL,
	[Ma_KH] [nvarchar](10) NULL,
	[TongTien] [float] NULL,
	[NgayXuatHD] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma_HDBH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[KH_ChuaXai]    Script Date: 2019-11-05 10:36:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[KH_ChuaXai]()
returns table
as
return (select * from KhachHang where (KhachHang.Ma_KH not in 
(select HD_BanHang.Ma_KH from HD_BanHang )))
GO
/****** Object:  Table [dbo].[MatHang]    Script Date: 2019-11-05 10:36:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MatHang](
	[Ma_MH] [nvarchar](10) NOT NULL,
	[Ma_loaiMH] [nvarchar](10) NULL,
	[Ten_MH] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[GiaNhap] [float] NULL,
	[GiaBan] [float] NULL,
	[ThoiGianBaoHanh] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma_MH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTiet_NhapHang]    Script Date: 2019-11-05 10:36:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTiet_NhapHang](
	[Ma_HDNH] [nvarchar](10) NOT NULL,
	[Ma_MH] [nvarchar](10) NOT NULL,
	[SoLuong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma_HDNH] ASC,
	[Ma_MH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTiet_BanHang]    Script Date: 2019-11-05 10:36:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTiet_BanHang](
	[Ma_HDBH] [nvarchar](10) NOT NULL,
	[Ma_MH] [nvarchar](10) NOT NULL,
	[SoLuong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma_HDBH] ASC,
	[Ma_MH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[MH_ChuaXai]    Script Date: 2019-11-05 10:36:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[MH_ChuaXai]()
returns table
as
return (select * from MatHang where ((MatHang.Ma_MH not in (select ChiTiet_BanHang.Ma_MH from ChiTiet_BanHang)) and
( MatHang.Ma_MH not in(select ChiTiet_NhapHang.Ma_MH from ChiTiet_NhapHang))))
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 2019-11-05 10:36:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[Ma_NV] [nvarchar](10) NOT NULL,
	[Ten_NV] [nvarchar](50) NULL,
	[Cmnd] [nvarchar](10) NULL,
	[Dienthoai] [nvarchar](20) NULL,
	[Ngay_lamviec] [datetime] NULL,
	[Luong] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma_NV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[LayNV]    Script Date: 2019-11-05 10:36:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[LayNV]()
returns table
as
return (select NhanVien.Ma_NV,NhanVien.Ten_NV from NhanVien)
GO
/****** Object:  UserDefinedFunction [dbo].[TimMHtheoMaMH]    Script Date: 2019-11-05 10:36:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[TimMHtheoMaMH]( @MaMH nvarchar(10))
returns table
as
return(
select * from MatHang where MatHang.Ma_MH like '%' + @MaMH + '%'
)
GO
/****** Object:  UserDefinedFunction [dbo].[TimMHtheoMaloaiMH]    Script Date: 2019-11-05 10:36:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[TimMHtheoMaloaiMH]( @Ma_loaiMH nvarchar(10))
returns table
as
return(
select * from MatHang where MatHang.Ma_loaiMH like '%' + @Ma_loaiMH + '%'
)
GO
/****** Object:  UserDefinedFunction [dbo].[TimMHtheoSoLuong]    Script Date: 2019-11-05 10:36:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[TimMHtheoSoLuong]( @SoLuong nvarchar(10))
returns table
as
return(
select * from MatHang where MatHang.SoLuong like '%' + @SoLuong + '%'
)
GO
/****** Object:  UserDefinedFunction [dbo].[TimMHtheoGiaNhap]    Script Date: 2019-11-05 10:36:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[TimMHtheoGiaNhap]( @GiaNhap nvarchar(10))
returns table
as
return(
select * from MatHang where MatHang.GiaNhap like '%' + @GiaNhap + '%'
)
GO
/****** Object:  UserDefinedFunction [dbo].[TimMHtheoGiaBan]    Script Date: 2019-11-05 10:36:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[TimMHtheoGiaBan]( @GiaBan nvarchar(10))
returns table
as
return(
select * from MatHang where MatHang.GiaBan like '%' + @GiaBan + '%'
)
GO
/****** Object:  UserDefinedFunction [dbo].[TimMHtheoTenMH]    Script Date: 2019-11-05 10:36:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[TimMHtheoTenMH]( @TenMH nvarchar(10))
returns table
as
return(
select * from MatHang where MatHang.Ten_MH like '%' + @TenMH + '%'
)
GO
/****** Object:  UserDefinedFunction [dbo].[KhachHangtheoMaKH]    Script Date: 2019-11-05 10:36:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[KhachHangtheoMaKH](
	@Ma_KH nvarchar(10)
)
returns table
as return
(
	select * from dbo.KhachHang
	where Ma_KH = @Ma_KH
)
GO
/****** Object:  UserDefinedFunction [dbo].[HoaDonTheoMaHD]    Script Date: 2019-11-05 10:36:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[HoaDonTheoMaHD](@Ma_HDBH nvarchar(10))
returns table
return (select * from HD_BanHang where Ma_HDBH=@Ma_HDBH)
GO
/****** Object:  UserDefinedFunction [dbo].[ChitietTheoMaHDvsMaHD]    Script Date: 2019-11-05 10:36:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create function [dbo].[ChitietTheoMaHDvsMaHD](@Ma_HDBH nvarchar(10),@Ma_MH nvarchar(10))
returns table
return (select * from ChiTiet_BanHang where Ma_HDBH=@Ma_HDBH and Ma_MH=@Ma_MH)
GO
/****** Object:  UserDefinedFunction [dbo].[ChitietTheoMaHD]    Script Date: 2019-11-05 10:36:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create function [dbo].[ChitietTheoMaHD](@Ma_HDBH nvarchar(10))
returns table
return (select * from ChiTiet_BanHang where Ma_HDBH=@Ma_HDBH)
GO
/****** Object:  UserDefinedFunction [dbo].[Func_MatHangcuaKhachHang]    Script Date: 2019-11-05 10:36:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[Func_MatHangcuaKhachHang] (@Ma_KH nvarchar(10))
returns table 
as
return(
select mh.Ten_MH,ctbh.SoLuong
from KhachHang kh, HD_BanHang bh, ChiTiet_BanHang ctbh, MatHang mh
where( mh.Ma_MH=ctbh.Ma_MH and ctbh.Ma_HDBH=bh.Ma_HDBH and bh.Ma_KH=@Ma_KH)
group by mh.Ten_MH, ctbh.SoLuong
)
GO
/****** Object:  UserDefinedFunction [dbo].[Func_HoaDoncuaNhanVien]    Script Date: 2019-11-05 10:36:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[Func_HoaDoncuaNhanVien](@Ma_NV nvarchar(10))
returns table
as
return(
select *
from HD_BanHang bh
where (bh.Ma_NV=@Ma_NV )
)
GO
/****** Object:  UserDefinedFunction [dbo].[MatHangtheoMaMH]    Script Date: 2019-11-05 10:36:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[MatHangtheoMaMH](@Ma_MH nvarchar(10))
returns table
as
 return 
 (select *from MatHang where MatHang.Ma_MH=@Ma_MH)
GO
/****** Object:  UserDefinedFunction [dbo].[NhanVientheoMaNV]    Script Date: 2019-11-05 10:36:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create function [dbo].[NhanVientheoMaNV](@Ma_NV nvarchar(10))
returns table
as
 return 
 (select *from NhanVien where NhanVien.Ma_NV=@Ma_NV)
GO
/****** Object:  UserDefinedFunction [dbo].[HD_ChuaXai]    Script Date: 2019-11-05 10:36:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[HD_ChuaXai]()
returns table
as
return (select * from HD_BanHang where (HD_BanHang.Ma_HDBH not in 
(select ChiTiet_BanHang.Ma_HDBH from ChiTiet_BanHang )))
GO
/****** Object:  Table [dbo].[HD_NhapHang]    Script Date: 2019-11-05 10:36:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HD_NhapHang](
	[Ma_HDNH] [nvarchar](10) NOT NULL,
	[Ma_NV] [nvarchar](10) NULL,
	[Ma_NPP] [nvarchar](10) NULL,
	[TongTien] [float] NULL,
	[NgayXuatHD] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma_HDNH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[NV_ChuaXai]    Script Date: 2019-11-05 10:36:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[NV_ChuaXai]()
returns table
as
return (select * from NhanVien where ((NhanVien.Ma_NV not in 
(select HD_BanHang.Ma_NV from HD_BanHang)) and( NhanVien.Ma_NV  not in(select HD_NhapHang.Ma_NV from HD_NhapHang))))
GO
/****** Object:  Table [dbo].[Loai_MatHang]    Script Date: 2019-11-05 10:36:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loai_MatHang](
	[Ma_loaiMH] [nvarchar](10) NOT NULL,
	[Ten_loaiMH] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma_loaiMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaPhanPhoi]    Script Date: 2019-11-05 10:36:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaPhanPhoi](
	[Ma_NPP] [nvarchar](10) NOT NULL,
	[Ten_NPP] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma_NPP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChiTiet_BanHang]  WITH CHECK ADD FOREIGN KEY([Ma_HDBH])
REFERENCES [dbo].[HD_BanHang] ([Ma_HDBH])
GO
ALTER TABLE [dbo].[ChiTiet_BanHang]  WITH CHECK ADD FOREIGN KEY([Ma_MH])
REFERENCES [dbo].[MatHang] ([Ma_MH])
GO
ALTER TABLE [dbo].[ChiTiet_NhapHang]  WITH CHECK ADD FOREIGN KEY([Ma_HDNH])
REFERENCES [dbo].[HD_NhapHang] ([Ma_HDNH])
GO
ALTER TABLE [dbo].[ChiTiet_NhapHang]  WITH CHECK ADD FOREIGN KEY([Ma_MH])
REFERENCES [dbo].[MatHang] ([Ma_MH])
GO
ALTER TABLE [dbo].[HD_BanHang]  WITH CHECK ADD FOREIGN KEY([Ma_KH])
REFERENCES [dbo].[KhachHang] ([Ma_KH])
GO
ALTER TABLE [dbo].[HD_BanHang]  WITH CHECK ADD FOREIGN KEY([Ma_NV])
REFERENCES [dbo].[NhanVien] ([Ma_NV])
GO
ALTER TABLE [dbo].[HD_NhapHang]  WITH CHECK ADD FOREIGN KEY([Ma_NPP])
REFERENCES [dbo].[NhaPhanPhoi] ([Ma_NPP])
GO
ALTER TABLE [dbo].[HD_NhapHang]  WITH CHECK ADD FOREIGN KEY([Ma_NV])
REFERENCES [dbo].[NhanVien] ([Ma_NV])
GO
ALTER TABLE [dbo].[MatHang]  WITH CHECK ADD FOREIGN KEY([Ma_loaiMH])
REFERENCES [dbo].[Loai_MatHang] ([Ma_loaiMH])
GO
/****** Object:  StoredProcedure [dbo].[spCapNhatChiTietBanHang]    Script Date: 2019-11-05 10:36:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spCapNhatChiTietBanHang](@Ma_HDBH nvarchar(10),
		@Ma_MH nvarchar(10),
		@SoLuong int)
as
begin
	update ChiTiet_BanHang
	set SoLuong = @SoLuong
	where ((Ma_HDBH = @Ma_HDBH) and (Ma_MH = @Ma_MH ))
end
GO
/****** Object:  StoredProcedure [dbo].[spCapNhatHoaDonBanHang]    Script Date: 2019-11-05 10:36:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spCapNhatHoaDonBanHang]
		(@Ma_HDBH nvarchar(10),@Ma_NV nvarchar(10),
		@Ma_KH nvarchar(10),
		@TongTien float,
		@NgayXuatHD datetime)
as
begin
	update HD_BanHang
	set Ma_NV = @Ma_NV, Ma_KH = @Ma_KH, TongTien = @TongTien, NgayXuatHD = @NgayXuatHD
	where Ma_HDBH = @Ma_HDBH
end
GO
/****** Object:  StoredProcedure [dbo].[spCapNhatKhachHang]    Script Date: 2019-11-05 10:36:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spCapNhatKhachHang]
		(@Ma_KH nvarchar(10),
		@Ten_KH nvarchar(50),
		@DiaChi nvarchar(50),
		@Dienthoai nvarchar(20),
		@Email nvarchar(50))
as
begin
	update KhachHang
	set Ten_KH = @Ten_KH, DiaChi = @DiaChi, Dienthoai = @Dienthoai, Email = @Email
	where Ma_KH = @Ma_KH
end
GO
/****** Object:  StoredProcedure [dbo].[spCapNhatMatHang]    Script Date: 2019-11-05 10:36:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spCapNhatMatHang]
(@Ma_MH nvarchar(10), 
@Ma_loaiMH nvarchar(10), 
@Ten_MH nvarchar(25),
@SoLuong int, 
@GiaNhap float, 
@GiaBan float,
@ThoiGianBaoHanh Datetime)
as
begin
update MatHang set 
Ma_loaiMH=@Ma_loaiMH,
Ten_MH=@Ten_MH,
SoLuong=@SoLuong,
GiaNhap=@GiaNhap,
GiaBan=@GiaBan,
ThoiGianBaoHanh=@ThoiGianBaoHanh where Ma_MH=@Ma_MH
end;
GO
/****** Object:  StoredProcedure [dbo].[spCapNhatNhanVien]    Script Date: 2019-11-05 10:36:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	create proc [dbo].[spCapNhatNhanVien]
			(@Ma_NV nvarchar(10),
			@Ten_NV nvarchar(50),
			@Cmnd nvarchar(10),
			@Dienthoai nvarchar(20),
			@Ngay_lamviec datetime,
			@Luong float)
	as
	begin
		update NhanVien
		set Ten_NV = @Ten_NV, 
		Cmnd = @Cmnd, 
		Dienthoai = @Dienthoai, 
		Ngay_lamviec=@Ngay_lamviec,
		Luong = @Luong
		where Ma_NV = @Ma_NV
	end
GO
/****** Object:  StoredProcedure [dbo].[spThemChiTietBanHang]    Script Date: 2019-11-05 10:36:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spThemChiTietBanHang]
		(@Ma_HDBH nvarchar(10),
		@Ma_MH nvarchar(10),
		@SoLuong int)
as
begin
	insert into ChiTiet_BanHang( Ma_HDBH,Ma_MH, SoLuong)
	values(@Ma_HDBH, @Ma_MH, @SoLuong)
end

GO
/****** Object:  StoredProcedure [dbo].[spThemHoaDonBanHang]    Script Date: 2019-11-05 10:36:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spThemHoaDonBanHang]
		(@Ma_HDBH nvarchar(10),
		@Ma_NV nvarchar(10),
		@Ma_KH nvarchar(10),
		@TongTien float,
		@NgayXuatHD datetime)
as
begin
	insert into HD_BanHang(Ma_HDBH, Ma_NV, Ma_KH, TongTien, NgayXuatHD)
	values(@Ma_HDBH, @Ma_NV, @Ma_KH, @TongTien, @NgayXuatHD)
end

GO
/****** Object:  StoredProcedure [dbo].[spThemKhachHang]    Script Date: 2019-11-05 10:36:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spThemKhachHang]
		(@Ma_KH nvarchar(10),
		@Ten_KH nvarchar(50),
		@DiaChi nvarchar(50),
		@Dienthoai nvarchar(20),
		@Email nvarchar(50))
as
begin
	insert into KhachHang(Ma_KH, Ten_KH, DiaChi, Dienthoai, Email)
	values(@Ma_KH, @Ten_KH, @DiaChi, @Dienthoai, @Email)
end
GO
/****** Object:  StoredProcedure [dbo].[spThemMatHang]    Script Date: 2019-11-05 10:36:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spThemMatHang]
(@Ma_MH nvarchar(10), @Ma_loaiMH nvarchar(10), @Ten_MH nvarchar(25),@SoLuong int, @GiaNhap float, @GiaBan float,@ThoiGianBaoHanh Datetime)
as
begin 
insert into MatHang(Ma_MH,Ma_loaiMH,Ten_MH,SoLuong,GiaNhap,GiaBan,ThoiGianBaoHanh) values(@Ma_MH,@Ma_loaiMH,@Ten_MH,@SoLuong,@GiaNhap,@GiaBan,@ThoiGianBaoHanh)
end
GO
/****** Object:  StoredProcedure [dbo].[spThemNhanVien]    Script Date: 2019-11-05 10:36:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	-- Tạo procedure Thêm Nhân viên vào bảng NhanVien
	create procedure [dbo].[spThemNhanVien]
			(@Ma_NV nvarchar(10),
			@Ten_NV nvarchar(50),
			@Cmnd nvarchar(10),
			@Dienthoai nvarchar(20),
			@Ngay_lamviec datetime,
			@Luong float)
	as
	begin
		insert into NhanVien(Ma_NV, Ten_NV, Cmnd, Dienthoai, Luong,Ngay_lamviec)
		values(@Ma_NV, @Ten_NV, @Cmnd, @Dienthoai, @Luong,@Ngay_lamviec)
	end
GO
/****** Object:  StoredProcedure [dbo].[spXoaChiTietBanHang]    Script Date: 2019-11-05 10:36:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spXoaChiTietBanHang] (@Ma_HDBH nvarchar(10),
		@Ma_MH nvarchar(10))
as
begin 
delete from ChiTiet_BanHang where Ma_HDBH=@Ma_HDBH and Ma_MH=@Ma_MH
end
GO
/****** Object:  StoredProcedure [dbo].[spXoaHoaDonBanHang]    Script Date: 2019-11-05 10:36:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spXoaHoaDonBanHang]
		(@Ma_HDBH nvarchar(10))
as
begin
	delete from HD_BanHang
	where Ma_HDBH = @Ma_HDBH
end

--  Chi tiết bán hàng
GO
/****** Object:  StoredProcedure [dbo].[spXoaKhachHang]    Script Date: 2019-11-05 10:36:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spXoaKhachHang]
		@Ma_KH nvarchar(10)
as
begin
	delete from KhachHang
	where Ma_KH = @Ma_KH
end

--Hóa Đơn bán Hàng
GO
/****** Object:  StoredProcedure [dbo].[spXoaMatHang]    Script Date: 2019-11-05 10:36:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spXoaMatHang]
(@Ma_MH nvarchar(10))
as
begin
delete MatHang where Ma_MH=@Ma_MH
end
--Khách Hàng
GO
/****** Object:  StoredProcedure [dbo].[spXoaNhanVien]    Script Date: 2019-11-05 10:36:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Tạo procedure Xóa Nhân viên theo Ma_NV
create proc [dbo].[spXoaNhanVien]
		(@Ma_NV nvarchar(10))
as
begin
	delete from NhanVien
	where Ma_NV = @Ma_NV
end
GO
USE [master]
GO
ALTER DATABASE [QuanLyCuaHangDoChoi] SET  READ_WRITE 
GO
