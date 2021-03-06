USE [master]
GO
/****** Object:  Database [QLVLXD]    Script Date: 1/4/2021 11:48:43 PM ******/
CREATE DATABASE [QLVLXD]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLVLXD', FILENAME = N'/var/opt/mssql/data/QLVLXD.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLVLXD_log', FILENAME = N'/var/opt/mssql/data/QLVLXD_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QLVLXD] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLVLXD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLVLXD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLVLXD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLVLXD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLVLXD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLVLXD] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLVLXD] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLVLXD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLVLXD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLVLXD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLVLXD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLVLXD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLVLXD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLVLXD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLVLXD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLVLXD] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLVLXD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLVLXD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLVLXD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLVLXD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLVLXD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLVLXD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLVLXD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLVLXD] SET RECOVERY FULL 
GO
ALTER DATABASE [QLVLXD] SET  MULTI_USER 
GO
ALTER DATABASE [QLVLXD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLVLXD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLVLXD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLVLXD] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLVLXD] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLVLXD] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLVLXD', N'ON'
GO
ALTER DATABASE [QLVLXD] SET QUERY_STORE = OFF
GO
USE [QLVLXD]
GO
/****** Object:  Table [dbo].[tblChiTietHoaDonNhap]    Script Date: 1/4/2021 11:48:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChiTietHoaDonNhap](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDHDNhap] [int] NULL,
	[IDHH] [int] NULL,
	[IDNCC] [int] NULL,
	[IDGiamGia] [int] NULL,
	[SoLuongNhap] [int] NULL,
	[DonGiaNhap] [float] NULL,
	[TongGia] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblChiTietHoaDonXuat]    Script Date: 1/4/2021 11:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChiTietHoaDonXuat](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDHoaDonXuat] [int] NULL,
	[IDKho] [int] NULL,
	[IDHH] [int] NULL,
	[IDGiamGia] [int] NULL,
	[SoLuongXuat] [int] NULL,
	[DonGiaXuat] [int] NULL,
	[IDKhoHangHoa] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDVT]    Script Date: 1/4/2021 11:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDVT](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenDVT] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblGiamGia]    Script Date: 1/4/2021 11:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblGiamGia](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PhanTram] [float] NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHangHoa]    Script Date: 1/4/2021 11:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHangHoa](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDMaLoai] [int] NULL,
	[TenHH] [nvarchar](50) NULL,
	[URLHinh] [nvarchar](max) NULL,
	[IDDVT] [int] NULL,
	[XuatXu] [nvarchar](50) NULL,
	[TrangThai] [int] NULL,
	[Gia] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHoaDonNhap]    Script Date: 1/4/2021 11:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHoaDonNhap](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDNV] [int] NULL,
	[IDNguoiDuyet] [int] NULL,
	[NgayLapNhap] [datetime] NULL,
	[TrangThai] [int] NULL,
	[VAT] [float] NULL,
	[TongGia] [float] NULL,
	[TenHD] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHoaDonXuat]    Script Date: 1/4/2021 11:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHoaDonXuat](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDKH] [int] NULL,
	[IDNV] [int] NULL,
	[IDNguoiDuyet] [int] NULL,
	[NgayLapXuat] [datetime] NULL,
	[TrangThaiXuat] [int] NULL,
	[TenHD] [nvarchar](max) NULL,
	[TongGia] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKhachHang]    Script Date: 1/4/2021 11:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKhachHang](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenKhachHang] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [nvarchar](10) NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKho]    Script Date: 1/4/2021 11:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKho](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenKho] [nvarchar](50) NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKho_HangHoa]    Script Date: 1/4/2021 11:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKho_HangHoa](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDKho] [int] NULL,
	[IDHH] [int] NULL,
	[SoLo] [int] NULL,
	[HanSuDung] [datetime] NULL,
	[SoLuongTon] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLoaiVatLieu]    Script Date: 1/4/2021 11:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLoaiVatLieu](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
	[TrangThai] [int] NULL,
	[MoTa] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNCC]    Script Date: 1/4/2021 11:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNCC](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNhanVien]    Script Date: 1/4/2021 11:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhanVien](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDPhanQuyen] [int] NULL,
	[TenNV] [nvarchar](50) NULL,
	[URLHinh] [nvarchar](max) NULL,
	[GioiTinh] [int] NULL,
	[NgaySinh] [datetime] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [nvarchar](10) NULL,
	[TrangThai] [int] NULL,
	[MoTa] [nvarchar](50) NULL,
	[PASSWORD] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPhanQuyen]    Script Date: 1/4/2021 11:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhanQuyen](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[MoTa] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPhieuGiaoNhap]    Script Date: 1/4/2021 11:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhieuGiaoNhap](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDChiTietHoaDonNhap] [int] NULL,
	[SoLuong] [int] NULL,
	[LanNhap] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPhieuGiaoXuat]    Script Date: 1/4/2021 11:48:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhieuGiaoXuat](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDChiTietHoaDonXuat] [int] NULL,
	[SoLuong] [int] NULL,
	[LanXuat] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tblChiTietHoaDonNhap] ON 

INSERT [dbo].[tblChiTietHoaDonNhap] ([ID], [IDHDNhap], [IDHH], [IDNCC], [IDGiamGia], [SoLuongNhap], [DonGiaNhap], [TongGia]) VALUES (5, 14, 4, 1, 1, 5, 300000, 1500000)
INSERT [dbo].[tblChiTietHoaDonNhap] ([ID], [IDHDNhap], [IDHH], [IDNCC], [IDGiamGia], [SoLuongNhap], [DonGiaNhap], [TongGia]) VALUES (6, 15, 9, 3, 2, 4, 200000, 800000)
INSERT [dbo].[tblChiTietHoaDonNhap] ([ID], [IDHDNhap], [IDHH], [IDNCC], [IDGiamGia], [SoLuongNhap], [DonGiaNhap], [TongGia]) VALUES (7, 16, 9, 5, 1, 5, 200000, 1000000)
INSERT [dbo].[tblChiTietHoaDonNhap] ([ID], [IDHDNhap], [IDHH], [IDNCC], [IDGiamGia], [SoLuongNhap], [DonGiaNhap], [TongGia]) VALUES (8, 17, 3, 1, 4, 12, 25000, 30000)
INSERT [dbo].[tblChiTietHoaDonNhap] ([ID], [IDHDNhap], [IDHH], [IDNCC], [IDGiamGia], [SoLuongNhap], [DonGiaNhap], [TongGia]) VALUES (9, 17, 6, 2, 4, 100000, 100000, 1000000000)
INSERT [dbo].[tblChiTietHoaDonNhap] ([ID], [IDHDNhap], [IDHH], [IDNCC], [IDGiamGia], [SoLuongNhap], [DonGiaNhap], [TongGia]) VALUES (10, 17, 3, 1, 4, 56000, 56000, 313600000)
INSERT [dbo].[tblChiTietHoaDonNhap] ([ID], [IDHDNhap], [IDHH], [IDNCC], [IDGiamGia], [SoLuongNhap], [DonGiaNhap], [TongGia]) VALUES (1008, 17, 7, 3, 5, 3, 30000000, 4500000)
INSERT [dbo].[tblChiTietHoaDonNhap] ([ID], [IDHDNhap], [IDHH], [IDNCC], [IDGiamGia], [SoLuongNhap], [DonGiaNhap], [TongGia]) VALUES (1009, 18, 4, 4, 1004, 3, 500000, 45000)
INSERT [dbo].[tblChiTietHoaDonNhap] ([ID], [IDHDNhap], [IDHH], [IDNCC], [IDGiamGia], [SoLuongNhap], [DonGiaNhap], [TongGia]) VALUES (1010, 18, 6, 4, 5, 10, 200000, 100000)
INSERT [dbo].[tblChiTietHoaDonNhap] ([ID], [IDHDNhap], [IDHH], [IDNCC], [IDGiamGia], [SoLuongNhap], [DonGiaNhap], [TongGia]) VALUES (1011, 19, 8, 5, 4, 2, 500000, 100000)
INSERT [dbo].[tblChiTietHoaDonNhap] ([ID], [IDHDNhap], [IDHH], [IDNCC], [IDGiamGia], [SoLuongNhap], [DonGiaNhap], [TongGia]) VALUES (1012, 19, 13, 4, 4, 2, 500000, 100000)
INSERT [dbo].[tblChiTietHoaDonNhap] ([ID], [IDHDNhap], [IDHH], [IDNCC], [IDGiamGia], [SoLuongNhap], [DonGiaNhap], [TongGia]) VALUES (2009, 1018, 6, 3, 5, 3, 4000000, 600000)
INSERT [dbo].[tblChiTietHoaDonNhap] ([ID], [IDHDNhap], [IDHH], [IDNCC], [IDGiamGia], [SoLuongNhap], [DonGiaNhap], [TongGia]) VALUES (2010, 1018, 5, 1, 5, 5, 6000000, 1500000)
INSERT [dbo].[tblChiTietHoaDonNhap] ([ID], [IDHDNhap], [IDHH], [IDNCC], [IDGiamGia], [SoLuongNhap], [DonGiaNhap], [TongGia]) VALUES (2011, 1019, 14, 5, 5, 4, 7000000, 1400000)
INSERT [dbo].[tblChiTietHoaDonNhap] ([ID], [IDHDNhap], [IDHH], [IDNCC], [IDGiamGia], [SoLuongNhap], [DonGiaNhap], [TongGia]) VALUES (2012, 1019, 16, 4, 5, 2, 3000000, 300000)
INSERT [dbo].[tblChiTietHoaDonNhap] ([ID], [IDHDNhap], [IDHH], [IDNCC], [IDGiamGia], [SoLuongNhap], [DonGiaNhap], [TongGia]) VALUES (2013, 1020, 6, 2, 1004, 150, 15000, 67500)
INSERT [dbo].[tblChiTietHoaDonNhap] ([ID], [IDHDNhap], [IDHH], [IDNCC], [IDGiamGia], [SoLuongNhap], [DonGiaNhap], [TongGia]) VALUES (2014, 1020, 7, 2, 1004, 4, 15000, 1800)
INSERT [dbo].[tblChiTietHoaDonNhap] ([ID], [IDHDNhap], [IDHH], [IDNCC], [IDGiamGia], [SoLuongNhap], [DonGiaNhap], [TongGia]) VALUES (2015, 1021, 4, 2, 1004, 5, 400000, 60000)
INSERT [dbo].[tblChiTietHoaDonNhap] ([ID], [IDHDNhap], [IDHH], [IDNCC], [IDGiamGia], [SoLuongNhap], [DonGiaNhap], [TongGia]) VALUES (2016, 1021, 16, 4, 1004, 4, 600000, 72000)
INSERT [dbo].[tblChiTietHoaDonNhap] ([ID], [IDHDNhap], [IDHH], [IDNCC], [IDGiamGia], [SoLuongNhap], [DonGiaNhap], [TongGia]) VALUES (2017, 1022, 6, 2, 5, 4, 500000, 100000)
INSERT [dbo].[tblChiTietHoaDonNhap] ([ID], [IDHDNhap], [IDHH], [IDNCC], [IDGiamGia], [SoLuongNhap], [DonGiaNhap], [TongGia]) VALUES (2018, 1022, 8, 4, 1004, 5, 50000, 7500)
INSERT [dbo].[tblChiTietHoaDonNhap] ([ID], [IDHDNhap], [IDHH], [IDNCC], [IDGiamGia], [SoLuongNhap], [DonGiaNhap], [TongGia]) VALUES (3008, 2018, 4, 1, 4, 5, 100, 50)
INSERT [dbo].[tblChiTietHoaDonNhap] ([ID], [IDHDNhap], [IDHH], [IDNCC], [IDGiamGia], [SoLuongNhap], [DonGiaNhap], [TongGia]) VALUES (3009, 2018, 6, 4, 4, 2, 100, 20)
SET IDENTITY_INSERT [dbo].[tblChiTietHoaDonNhap] OFF
GO
SET IDENTITY_INSERT [dbo].[tblChiTietHoaDonXuat] ON 

INSERT [dbo].[tblChiTietHoaDonXuat] ([ID], [IDHoaDonXuat], [IDKho], [IDHH], [IDGiamGia], [SoLuongXuat], [DonGiaXuat], [IDKhoHangHoa]) VALUES (2, 1, 1, 4, 1, 3, 3000000, NULL)
INSERT [dbo].[tblChiTietHoaDonXuat] ([ID], [IDHoaDonXuat], [IDKho], [IDHH], [IDGiamGia], [SoLuongXuat], [DonGiaXuat], [IDKhoHangHoa]) VALUES (3, 2, 2, 9, 2, 2, 400000, NULL)
INSERT [dbo].[tblChiTietHoaDonXuat] ([ID], [IDHoaDonXuat], [IDKho], [IDHH], [IDGiamGia], [SoLuongXuat], [DonGiaXuat], [IDKhoHangHoa]) VALUES (5, 4, 1, 5, 1, 2, 1440000, 1005)
INSERT [dbo].[tblChiTietHoaDonXuat] ([ID], [IDHoaDonXuat], [IDKho], [IDHH], [IDGiamGia], [SoLuongXuat], [DonGiaXuat], [IDKhoHangHoa]) VALUES (1004, 1004, 1, 4, 1, 1, 2703600, 4)
INSERT [dbo].[tblChiTietHoaDonXuat] ([ID], [IDHoaDonXuat], [IDKho], [IDHH], [IDGiamGia], [SoLuongXuat], [DonGiaXuat], [IDKhoHangHoa]) VALUES (1005, 1004, 1, 6, 2, 4, 1600000, 1003)
INSERT [dbo].[tblChiTietHoaDonXuat] ([ID], [IDHoaDonXuat], [IDKho], [IDHH], [IDGiamGia], [SoLuongXuat], [DonGiaXuat], [IDKhoHangHoa]) VALUES (1006, 1004, 1, 6, 1, 4, 1800000, 1007)
SET IDENTITY_INSERT [dbo].[tblChiTietHoaDonXuat] OFF
GO
SET IDENTITY_INSERT [dbo].[tblDVT] ON 

INSERT [dbo].[tblDVT] ([ID], [TenDVT]) VALUES (1, N'Viên')
INSERT [dbo].[tblDVT] ([ID], [TenDVT]) VALUES (2, N'Bao')
INSERT [dbo].[tblDVT] ([ID], [TenDVT]) VALUES (3, N'Kg')
INSERT [dbo].[tblDVT] ([ID], [TenDVT]) VALUES (4, N'Mét Khối')
INSERT [dbo].[tblDVT] ([ID], [TenDVT]) VALUES (5, N'Cái')
INSERT [dbo].[tblDVT] ([ID], [TenDVT]) VALUES (6, N'Bộ')
INSERT [dbo].[tblDVT] ([ID], [TenDVT]) VALUES (7, N'Thùng')
INSERT [dbo].[tblDVT] ([ID], [TenDVT]) VALUES (8, N'Líts')
SET IDENTITY_INSERT [dbo].[tblDVT] OFF
GO
SET IDENTITY_INSERT [dbo].[tblGiamGia] ON 

INSERT [dbo].[tblGiamGia] ([ID], [PhanTram], [TrangThai]) VALUES (1, 10, 1)
INSERT [dbo].[tblGiamGia] ([ID], [PhanTram], [TrangThai]) VALUES (2, 20, 1)
INSERT [dbo].[tblGiamGia] ([ID], [PhanTram], [TrangThai]) VALUES (4, 10, 0)
INSERT [dbo].[tblGiamGia] ([ID], [PhanTram], [TrangThai]) VALUES (5, 5, 0)
INSERT [dbo].[tblGiamGia] ([ID], [PhanTram], [TrangThai]) VALUES (1004, 3, 0)
SET IDENTITY_INSERT [dbo].[tblGiamGia] OFF
GO
SET IDENTITY_INSERT [dbo].[tblHangHoa] ON 

INSERT [dbo].[tblHangHoa] ([ID], [IDMaLoai], [TenHH], [URLHinh], [IDDVT], [XuatXu], [TrangThai], [Gia]) VALUES (2, 1, N'Cát', N'', 4, N'Việt Nam', 1, 300000.0000)
INSERT [dbo].[tblHangHoa] ([ID], [IDMaLoai], [TenHH], [URLHinh], [IDDVT], [XuatXu], [TrangThai], [Gia]) VALUES (3, 1, N'Gạch', N'', 1, N'Nhật bản', 1, 4000000.0000)
INSERT [dbo].[tblHangHoa] ([ID], [IDMaLoai], [TenHH], [URLHinh], [IDDVT], [XuatXu], [TrangThai], [Gia]) VALUES (4, 1, N'Đá', N'', 4, N'Việt Nam', 1, 3004000.0000)
INSERT [dbo].[tblHangHoa] ([ID], [IDMaLoai], [TenHH], [URLHinh], [IDDVT], [XuatXu], [TrangThai], [Gia]) VALUES (5, 1, N'Xi Măng', N'', 2, N'Hà Tiên', 1, 800000.0000)
INSERT [dbo].[tblHangHoa] ([ID], [IDMaLoai], [TenHH], [URLHinh], [IDDVT], [XuatXu], [TrangThai], [Gia]) VALUES (6, 1, N'Sắt Thép', N'', 3, N'Đồng Nai', 1, 1000000.0000)
INSERT [dbo].[tblHangHoa] ([ID], [IDMaLoai], [TenHH], [URLHinh], [IDDVT], [XuatXu], [TrangThai], [Gia]) VALUES (7, 2, N'Cửa Kính', N'', 6, N'Ý', 1, 5666666.0000)
INSERT [dbo].[tblHangHoa] ([ID], [IDMaLoai], [TenHH], [URLHinh], [IDDVT], [XuatXu], [TrangThai], [Gia]) VALUES (8, 2, N'Vòi Sen', N'', 5, N'Việt Nam', 1, 1900000.0000)
INSERT [dbo].[tblHangHoa] ([ID], [IDMaLoai], [TenHH], [URLHinh], [IDDVT], [XuatXu], [TrangThai], [Gia]) VALUES (9, 2, N'Cửa Ban Công', N'', 6, N'Ý', 1, 900000.0000)
INSERT [dbo].[tblHangHoa] ([ID], [IDMaLoai], [TenHH], [URLHinh], [IDDVT], [XuatXu], [TrangThai], [Gia]) VALUES (10, 2, N'Cửa Sổ', N'', 6, N'Ý', 1, 200000.0000)
INSERT [dbo].[tblHangHoa] ([ID], [IDMaLoai], [TenHH], [URLHinh], [IDDVT], [XuatXu], [TrangThai], [Gia]) VALUES (11, 2, N'Gương Nhà tắm', N'', 5, N'Việt Nam', 1, 50000000.0000)
INSERT [dbo].[tblHangHoa] ([ID], [IDMaLoai], [TenHH], [URLHinh], [IDDVT], [XuatXu], [TrangThai], [Gia]) VALUES (12, 2, N'Bình Nóng Lạnh', N'C:\Users\China\Pictures\Saved Pictures\Hinh-nen-anime-nam (15).jpg', 5, N'Nhật Bản', 1, 500000.0000)
INSERT [dbo].[tblHangHoa] ([ID], [IDMaLoai], [TenHH], [URLHinh], [IDDVT], [XuatXu], [TrangThai], [Gia]) VALUES (13, 2, N'Đèn Sưởi Ấm', N'', 5, N'Nhật Bản', 1, 7000000.0000)
INSERT [dbo].[tblHangHoa] ([ID], [IDMaLoai], [TenHH], [URLHinh], [IDDVT], [XuatXu], [TrangThai], [Gia]) VALUES (14, 2, N'Vòi Xịt', N'', 5, N'Nhật Bản', 1, 4000000.0000)
INSERT [dbo].[tblHangHoa] ([ID], [IDMaLoai], [TenHH], [URLHinh], [IDDVT], [XuatXu], [TrangThai], [Gia]) VALUES (15, 2, N'Đá Hoa Cương', N'', 4, N'Đồng Nai', 1, 20000000.0000)
INSERT [dbo].[tblHangHoa] ([ID], [IDMaLoai], [TenHH], [URLHinh], [IDDVT], [XuatXu], [TrangThai], [Gia]) VALUES (16, 2, N'Sơn Chóng Thấm', N'', 7, N'Bến Tre', 1, 30000.0000)
SET IDENTITY_INSERT [dbo].[tblHangHoa] OFF
GO
SET IDENTITY_INSERT [dbo].[tblHoaDonNhap] ON 

INSERT [dbo].[tblHoaDonNhap] ([ID], [IDNV], [IDNguoiDuyet], [NgayLapNhap], [TrangThai], [VAT], [TongGia], [TenHD]) VALUES (14, 7, 5, CAST(N'2020-12-14T00:00:00.000' AS DateTime), 1, 10, 1500000, NULL)
INSERT [dbo].[tblHoaDonNhap] ([ID], [IDNV], [IDNguoiDuyet], [NgayLapNhap], [TrangThai], [VAT], [TongGia], [TenHD]) VALUES (15, 6, 7, CAST(N'2020-12-25T00:00:00.000' AS DateTime), 1, 10, 800000, NULL)
INSERT [dbo].[tblHoaDonNhap] ([ID], [IDNV], [IDNguoiDuyet], [NgayLapNhap], [TrangThai], [VAT], [TongGia], [TenHD]) VALUES (16, 5, 5, CAST(N'2020-12-30T00:00:00.000' AS DateTime), 1, 10, 1000000, NULL)
INSERT [dbo].[tblHoaDonNhap] ([ID], [IDNV], [IDNguoiDuyet], [NgayLapNhap], [TrangThai], [VAT], [TongGia], [TenHD]) VALUES (17, 1005, 1005, CAST(N'2020-12-21T19:06:26.787' AS DateTime), 1, 10, 1318130000, N'Hóa Đơn Test')
INSERT [dbo].[tblHoaDonNhap] ([ID], [IDNV], [IDNguoiDuyet], [NgayLapNhap], [TrangThai], [VAT], [TongGia], [TenHD]) VALUES (18, 1005, NULL, CAST(N'2020-12-25T11:57:52.933' AS DateTime), 2, 5, 145000, N'Hóa Đơn 1')
INSERT [dbo].[tblHoaDonNhap] ([ID], [IDNV], [IDNguoiDuyet], [NgayLapNhap], [TrangThai], [VAT], [TongGia], [TenHD]) VALUES (19, 1005, NULL, CAST(N'2020-12-25T13:03:42.223' AS DateTime), 2, 10, 200000, N'HD NHAP')
INSERT [dbo].[tblHoaDonNhap] ([ID], [IDNV], [IDNguoiDuyet], [NgayLapNhap], [TrangThai], [VAT], [TongGia], [TenHD]) VALUES (1018, 1005, NULL, CAST(N'2020-12-25T13:20:52.303' AS DateTime), 2, 5, 2100000, N'HD1')
INSERT [dbo].[tblHoaDonNhap] ([ID], [IDNV], [IDNguoiDuyet], [NgayLapNhap], [TrangThai], [VAT], [TongGia], [TenHD]) VALUES (1019, 1005, NULL, CAST(N'2020-12-25T14:17:55.523' AS DateTime), 1, 5, 1700000, N'HD2')
INSERT [dbo].[tblHoaDonNhap] ([ID], [IDNV], [IDNguoiDuyet], [NgayLapNhap], [TrangThai], [VAT], [TongGia], [TenHD]) VALUES (1020, 1005, NULL, CAST(N'2020-12-25T14:29:02.597' AS DateTime), 1, 5, 69300, N'HD3')
INSERT [dbo].[tblHoaDonNhap] ([ID], [IDNV], [IDNguoiDuyet], [NgayLapNhap], [TrangThai], [VAT], [TongGia], [TenHD]) VALUES (1021, 1005, NULL, CAST(N'2020-12-25T14:42:36.263' AS DateTime), 2, 10, 132000, N'HD4')
INSERT [dbo].[tblHoaDonNhap] ([ID], [IDNV], [IDNguoiDuyet], [NgayLapNhap], [TrangThai], [VAT], [TongGia], [TenHD]) VALUES (1022, 1005, NULL, CAST(N'2020-12-25T14:50:24.360' AS DateTime), 1, 5, 107500, N'HD5')
INSERT [dbo].[tblHoaDonNhap] ([ID], [IDNV], [IDNguoiDuyet], [NgayLapNhap], [TrangThai], [VAT], [TongGia], [TenHD]) VALUES (2018, 1005, 1005, CAST(N'2020-12-27T11:52:24.177' AS DateTime), 1, 1, 70, N'Hóa đơn 2')
INSERT [dbo].[tblHoaDonNhap] ([ID], [IDNV], [IDNguoiDuyet], [NgayLapNhap], [TrangThai], [VAT], [TongGia], [TenHD]) VALUES (2019, 1005, 1005, CAST(N'2021-01-02T15:27:13.203' AS DateTime), 1, 1, NULL, N'Hóa Đơn 2021')
SET IDENTITY_INSERT [dbo].[tblHoaDonNhap] OFF
GO
SET IDENTITY_INSERT [dbo].[tblHoaDonXuat] ON 

INSERT [dbo].[tblHoaDonXuat] ([ID], [IDKH], [IDNV], [IDNguoiDuyet], [NgayLapXuat], [TrangThaiXuat], [TenHD], [TongGia]) VALUES (1, 1, 5, 5, CAST(N'2021-01-12T00:00:00.000' AS DateTime), 1, NULL, 3000000.0000)
INSERT [dbo].[tblHoaDonXuat] ([ID], [IDKH], [IDNV], [IDNguoiDuyet], [NgayLapXuat], [TrangThaiXuat], [TenHD], [TongGia]) VALUES (2, 2, 6, 7, CAST(N'2021-02-15T00:00:00.000' AS DateTime), 1, NULL, NULL)
INSERT [dbo].[tblHoaDonXuat] ([ID], [IDKH], [IDNV], [IDNguoiDuyet], [NgayLapXuat], [TrangThaiXuat], [TenHD], [TongGia]) VALUES (3, 1, 1005, NULL, CAST(N'2020-12-29T10:47:41.000' AS DateTime), 0, NULL, NULL)
INSERT [dbo].[tblHoaDonXuat] ([ID], [IDKH], [IDNV], [IDNguoiDuyet], [NgayLapXuat], [TrangThaiXuat], [TenHD], [TongGia]) VALUES (4, 3, 1005, NULL, CAST(N'2020-12-28T17:00:23.790' AS DateTime), 0, N'Hóa Đơn Xuât 1', NULL)
INSERT [dbo].[tblHoaDonXuat] ([ID], [IDKH], [IDNV], [IDNguoiDuyet], [NgayLapXuat], [TrangThaiXuat], [TenHD], [TongGia]) VALUES (1004, 2, 1005, NULL, CAST(N'2020-12-30T14:20:44.773' AS DateTime), 1, N'sdfg', 6103600.0000)
SET IDENTITY_INSERT [dbo].[tblHoaDonXuat] OFF
GO
SET IDENTITY_INSERT [dbo].[tblKhachHang] ON 

INSERT [dbo].[tblKhachHang] ([ID], [TenKhachHang], [DiaChi], [SDT], [TrangThai]) VALUES (1, N'Nguyễn Thị Tuyết', N'123 Nguyễn Đỗ Cung', N'0123456789', 0)
INSERT [dbo].[tblKhachHang] ([ID], [TenKhachHang], [DiaChi], [SDT], [TrangThai]) VALUES (2, N'Lê Dương Bảo Lâm', N'Nam Kỳ Khởi Nghĩa', N'0243567879', 1)
INSERT [dbo].[tblKhachHang] ([ID], [TenKhachHang], [DiaChi], [SDT], [TrangThai]) VALUES (3, N'Trần Thị Thùy Trang', N'Lý Chính Thắng', N'0164585558', 0)
INSERT [dbo].[tblKhachHang] ([ID], [TenKhachHang], [DiaChi], [SDT], [TrangThai]) VALUES (4, N'Ngô Thị Thùy Dương', N'12/3 Chợ Mới, An Giang', N'2345654366', 0)
INSERT [dbo].[tblKhachHang] ([ID], [TenKhachHang], [DiaChi], [SDT], [TrangThai]) VALUES (5, N'Nguyễn Văn Minh', N'Đường Hai Bà Trưng, TPHCM', N'0256789975', 1)
INSERT [dbo].[tblKhachHang] ([ID], [TenKhachHang], [DiaChi], [SDT], [TrangThai]) VALUES (6, N'Lý Nguyễn Quế Linh', N'14/7 Sư Vạn Hạnh', N'0123456688', 0)
SET IDENTITY_INSERT [dbo].[tblKhachHang] OFF
GO
SET IDENTITY_INSERT [dbo].[tblKho] ON 

INSERT [dbo].[tblKho] ([ID], [TenKho], [TrangThai]) VALUES (1, N'Kho A', 1)
INSERT [dbo].[tblKho] ([ID], [TenKho], [TrangThai]) VALUES (2, N'Kho B', 1)
INSERT [dbo].[tblKho] ([ID], [TenKho], [TrangThai]) VALUES (3, N'Kho 3', 0)
INSERT [dbo].[tblKho] ([ID], [TenKho], [TrangThai]) VALUES (4, N'Kho 4', 0)
SET IDENTITY_INSERT [dbo].[tblKho] OFF
GO
SET IDENTITY_INSERT [dbo].[tblKho_HangHoa] ON 

INSERT [dbo].[tblKho_HangHoa] ([ID], [IDKho], [IDHH], [SoLo], [HanSuDung], [SoLuongTon]) VALUES (1, 1, 9, 1, CAST(N'2025-01-01T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[tblKho_HangHoa] ([ID], [IDKho], [IDHH], [SoLo], [HanSuDung], [SoLuongTon]) VALUES (2, 1, 4, 2, CAST(N'2026-01-01T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[tblKho_HangHoa] ([ID], [IDKho], [IDHH], [SoLo], [HanSuDung], [SoLuongTon]) VALUES (4, 1, 4, 1, CAST(N'2020-12-25T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[tblKho_HangHoa] ([ID], [IDKho], [IDHH], [SoLo], [HanSuDung], [SoLuongTon]) VALUES (5, 1, 4, 1, CAST(N'2020-12-25T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[tblKho_HangHoa] ([ID], [IDKho], [IDHH], [SoLo], [HanSuDung], [SoLuongTon]) VALUES (6, 1, 6, 1, CAST(N'2020-12-26T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[tblKho_HangHoa] ([ID], [IDKho], [IDHH], [SoLo], [HanSuDung], [SoLuongTon]) VALUES (7, 1, 6, 2, CAST(N'2020-12-25T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[tblKho_HangHoa] ([ID], [IDKho], [IDHH], [SoLo], [HanSuDung], [SoLuongTon]) VALUES (8, 2, 8, 1, CAST(N'2020-12-28T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[tblKho_HangHoa] ([ID], [IDKho], [IDHH], [SoLo], [HanSuDung], [SoLuongTon]) VALUES (9, 1, 13, 1, CAST(N'2020-12-30T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[tblKho_HangHoa] ([ID], [IDKho], [IDHH], [SoLo], [HanSuDung], [SoLuongTon]) VALUES (1003, 1, 6, 2, CAST(N'2020-12-29T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[tblKho_HangHoa] ([ID], [IDKho], [IDHH], [SoLo], [HanSuDung], [SoLuongTon]) VALUES (1004, 1, 5, 2, CAST(N'2020-12-28T00:00:00.000' AS DateTime), 3)
INSERT [dbo].[tblKho_HangHoa] ([ID], [IDKho], [IDHH], [SoLo], [HanSuDung], [SoLuongTon]) VALUES (1005, 1, 5, 2, CAST(N'2020-12-28T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[tblKho_HangHoa] ([ID], [IDKho], [IDHH], [SoLo], [HanSuDung], [SoLuongTon]) VALUES (1006, 1, 14, 1, CAST(N'2020-12-29T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[tblKho_HangHoa] ([ID], [IDKho], [IDHH], [SoLo], [HanSuDung], [SoLuongTon]) VALUES (1007, 1, 6, 2, CAST(N'2020-12-28T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[tblKho_HangHoa] ([ID], [IDKho], [IDHH], [SoLo], [HanSuDung], [SoLuongTon]) VALUES (1008, 1, 6, 2, CAST(N'2020-12-28T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[tblKho_HangHoa] ([ID], [IDKho], [IDHH], [SoLo], [HanSuDung], [SoLuongTon]) VALUES (1009, 2, 8, 2, CAST(N'2020-12-29T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[tblKho_HangHoa] ([ID], [IDKho], [IDHH], [SoLo], [HanSuDung], [SoLuongTon]) VALUES (1010, 2, 8, 3, CAST(N'2020-12-29T00:00:00.000' AS DateTime), 6)
INSERT [dbo].[tblKho_HangHoa] ([ID], [IDKho], [IDHH], [SoLo], [HanSuDung], [SoLuongTon]) VALUES (2004, 1, 16, 1, CAST(N'2020-12-26T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[tblKho_HangHoa] ([ID], [IDKho], [IDHH], [SoLo], [HanSuDung], [SoLuongTon]) VALUES (2005, 1, 16, 2, CAST(N'2020-12-24T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[tblKho_HangHoa] ([ID], [IDKho], [IDHH], [SoLo], [HanSuDung], [SoLuongTon]) VALUES (2006, 1, 4, 1, CAST(N'2020-12-27T00:00:00.000' AS DateTime), 5)
SET IDENTITY_INSERT [dbo].[tblKho_HangHoa] OFF
GO
SET IDENTITY_INSERT [dbo].[tblLoaiVatLieu] ON 

INSERT [dbo].[tblLoaiVatLieu] ([ID], [TenLoai], [TrangThai], [MoTa]) VALUES (1, N'Vật liệu xây dựng thô', 1, NULL)
INSERT [dbo].[tblLoaiVatLieu] ([ID], [TenLoai], [TrangThai], [MoTa]) VALUES (2, N'Vật liệu xây dựng hoàn thiện', 1, NULL)
INSERT [dbo].[tblLoaiVatLieu] ([ID], [TenLoai], [TrangThai], [MoTa]) VALUES (3, N'Vật liệu tái sử dụng', 0, N'OK Test')
SET IDENTITY_INSERT [dbo].[tblLoaiVatLieu] OFF
GO
SET IDENTITY_INSERT [dbo].[tblNCC] ON 

INSERT [dbo].[tblNCC] ([ID], [TenNCC], [DiaChi], [SDT]) VALUES (1, N'Công Ty TNHH HaLo Group', N'Bến Tre', N'0423458484')
INSERT [dbo].[tblNCC] ([ID], [TenNCC], [DiaChi], [SDT]) VALUES (2, N'Công Ty Cổ Phần Đầu tư Nhà Xanh', N'Long An', N'0456787556')
INSERT [dbo].[tblNCC] ([ID], [TenNCC], [DiaChi], [SDT]) VALUES (3, N'Công Ty TNHH Vật Liệu Và Thiết Bị Vĩnh Phú', N'Bến Nghé', N'0234567436')
INSERT [dbo].[tblNCC] ([ID], [TenNCC], [DiaChi], [SDT]) VALUES (4, N'Công Ty TNHH Đầu Tư Và Vận Tải Châu Long', N'Cần Thơ', N'0166767896')
INSERT [dbo].[tblNCC] ([ID], [TenNCC], [DiaChi], [SDT]) VALUES (5, N'Công Ty Cổ Phần Xây Dựng Và Vận Tải Sông Thao', N'An Giang', N'02357i8878')
SET IDENTITY_INSERT [dbo].[tblNCC] OFF
GO
SET IDENTITY_INSERT [dbo].[tblNhanVien] ON 

INSERT [dbo].[tblNhanVien] ([ID], [IDPhanQuyen], [TenNV], [URLHinh], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [TrangThai], [MoTa], [PASSWORD]) VALUES (5, 1, N'ADMIN', NULL, 1, CAST(N'1997-12-04T00:00:00.000' AS DateTime), N'Quận 1, TPHCM', N'0909235674', 1, N'Quyền admin ko dc xem', N'123456789')
INSERT [dbo].[tblNhanVien] ([ID], [IDPhanQuyen], [TenNV], [URLHinh], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [TrangThai], [MoTa], [PASSWORD]) VALUES (6, 2, N'Nguyễn Thị Bé Hai', NULL, 0, CAST(N'1996-12-12T00:00:00.000' AS DateTime), N'Nam Kỳ Khởi Nghĩa', N'0134567987', 1, NULL, N'123123123')
INSERT [dbo].[tblNhanVien] ([ID], [IDPhanQuyen], [TenNV], [URLHinh], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [TrangThai], [MoTa], [PASSWORD]) VALUES (7, 3, N'Lê Văn Tám', NULL, 1, CAST(N'1989-04-15T00:00:00.000' AS DateTime), N'Đường 3/2, TPHCM', N'0123456778', 1, NULL, N'789789789')
INSERT [dbo].[tblNhanVien] ([ID], [IDPhanQuyen], [TenNV], [URLHinh], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [TrangThai], [MoTa], [PASSWORD]) VALUES (1003, 4, N'Lê Minh Anh', NULL, 1, CAST(N'1990-06-22T00:00:00.000' AS DateTime), N'Đường Kênh Tân Hóa, TPHCM', N'0123887467', 1, NULL, N'987654321')
INSERT [dbo].[tblNhanVien] ([ID], [IDPhanQuyen], [TenNV], [URLHinh], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [TrangThai], [MoTa], [PASSWORD]) VALUES (1004, 3, N'NGười qua đường', N'', 0, CAST(N'2020-12-21T00:00:00.000' AS DateTime), N'asdf', N'016995544', 0, N'asdf', N'1234567890')
INSERT [dbo].[tblNhanVien] ([ID], [IDPhanQuyen], [TenNV], [URLHinh], [GioiTinh], [NgaySinh], [DiaChi], [SDT], [TrangThai], [MoTa], [PASSWORD]) VALUES (1005, 3, N'Khang China', N'C:\Users\China\Pictures\Saved Pictures\Hinh-nen-anime-nam (17).jpg', 0, CAST(N'2020-12-21T00:00:00.000' AS DateTime), N'asdf', N'0964440775', 0, N'admin', N'1')
SET IDENTITY_INSERT [dbo].[tblNhanVien] OFF
GO
SET IDENTITY_INSERT [dbo].[tblPhanQuyen] ON 

INSERT [dbo].[tblPhanQuyen] ([ID], [Ten], [MoTa]) VALUES (1, N'Quản Trị Viên', NULL)
INSERT [dbo].[tblPhanQuyen] ([ID], [Ten], [MoTa]) VALUES (2, N'Gíam Đốc', N'')
INSERT [dbo].[tblPhanQuyen] ([ID], [Ten], [MoTa]) VALUES (3, N'Nhân Viên', NULL)
INSERT [dbo].[tblPhanQuyen] ([ID], [Ten], [MoTa]) VALUES (4, N'Kế Toán', NULL)
SET IDENTITY_INSERT [dbo].[tblPhanQuyen] OFF
GO
SET IDENTITY_INSERT [dbo].[tblPhieuGiaoNhap] ON 

INSERT [dbo].[tblPhieuGiaoNhap] ([ID], [IDChiTietHoaDonNhap], [SoLuong], [LanNhap]) VALUES (1, 5, 4, NULL)
INSERT [dbo].[tblPhieuGiaoNhap] ([ID], [IDChiTietHoaDonNhap], [SoLuong], [LanNhap]) VALUES (2, 6, 4, NULL)
INSERT [dbo].[tblPhieuGiaoNhap] ([ID], [IDChiTietHoaDonNhap], [SoLuong], [LanNhap]) VALUES (3, 7, 5, NULL)
INSERT [dbo].[tblPhieuGiaoNhap] ([ID], [IDChiTietHoaDonNhap], [SoLuong], [LanNhap]) VALUES (5, 1009, 2, 1)
INSERT [dbo].[tblPhieuGiaoNhap] ([ID], [IDChiTietHoaDonNhap], [SoLuong], [LanNhap]) VALUES (6, 1009, 1, 2)
INSERT [dbo].[tblPhieuGiaoNhap] ([ID], [IDChiTietHoaDonNhap], [SoLuong], [LanNhap]) VALUES (7, 1010, 5, 1)
INSERT [dbo].[tblPhieuGiaoNhap] ([ID], [IDChiTietHoaDonNhap], [SoLuong], [LanNhap]) VALUES (8, 1010, 5, 1)
INSERT [dbo].[tblPhieuGiaoNhap] ([ID], [IDChiTietHoaDonNhap], [SoLuong], [LanNhap]) VALUES (9, 1011, 2, 1)
INSERT [dbo].[tblPhieuGiaoNhap] ([ID], [IDChiTietHoaDonNhap], [SoLuong], [LanNhap]) VALUES (10, 1012, 2, 1)
INSERT [dbo].[tblPhieuGiaoNhap] ([ID], [IDChiTietHoaDonNhap], [SoLuong], [LanNhap]) VALUES (1004, 2009, 2, 1)
INSERT [dbo].[tblPhieuGiaoNhap] ([ID], [IDChiTietHoaDonNhap], [SoLuong], [LanNhap]) VALUES (1005, 2010, 3, 1)
INSERT [dbo].[tblPhieuGiaoNhap] ([ID], [IDChiTietHoaDonNhap], [SoLuong], [LanNhap]) VALUES (1006, 2010, 2, 2)
INSERT [dbo].[tblPhieuGiaoNhap] ([ID], [IDChiTietHoaDonNhap], [SoLuong], [LanNhap]) VALUES (1007, 2011, 2, 1)
INSERT [dbo].[tblPhieuGiaoNhap] ([ID], [IDChiTietHoaDonNhap], [SoLuong], [LanNhap]) VALUES (1008, 2015, 5, 1)
INSERT [dbo].[tblPhieuGiaoNhap] ([ID], [IDChiTietHoaDonNhap], [SoLuong], [LanNhap]) VALUES (1009, 2017, 2, 1)
INSERT [dbo].[tblPhieuGiaoNhap] ([ID], [IDChiTietHoaDonNhap], [SoLuong], [LanNhap]) VALUES (1010, 2017, 2, 2)
INSERT [dbo].[tblPhieuGiaoNhap] ([ID], [IDChiTietHoaDonNhap], [SoLuong], [LanNhap]) VALUES (1011, 2018, 1, 1)
INSERT [dbo].[tblPhieuGiaoNhap] ([ID], [IDChiTietHoaDonNhap], [SoLuong], [LanNhap]) VALUES (1012, 2018, 6, 2)
INSERT [dbo].[tblPhieuGiaoNhap] ([ID], [IDChiTietHoaDonNhap], [SoLuong], [LanNhap]) VALUES (2004, 2016, 2, 1)
INSERT [dbo].[tblPhieuGiaoNhap] ([ID], [IDChiTietHoaDonNhap], [SoLuong], [LanNhap]) VALUES (2005, 2016, 2, 2)
INSERT [dbo].[tblPhieuGiaoNhap] ([ID], [IDChiTietHoaDonNhap], [SoLuong], [LanNhap]) VALUES (2006, 3008, 5, 1)
SET IDENTITY_INSERT [dbo].[tblPhieuGiaoNhap] OFF
GO
SET IDENTITY_INSERT [dbo].[tblPhieuGiaoXuat] ON 

INSERT [dbo].[tblPhieuGiaoXuat] ([ID], [IDChiTietHoaDonXuat], [SoLuong], [LanXuat]) VALUES (1, 2, 3, NULL)
INSERT [dbo].[tblPhieuGiaoXuat] ([ID], [IDChiTietHoaDonXuat], [SoLuong], [LanXuat]) VALUES (2, 3, 2, NULL)
INSERT [dbo].[tblPhieuGiaoXuat] ([ID], [IDChiTietHoaDonXuat], [SoLuong], [LanXuat]) VALUES (3, 1004, 1, 1)
INSERT [dbo].[tblPhieuGiaoXuat] ([ID], [IDChiTietHoaDonXuat], [SoLuong], [LanXuat]) VALUES (7, 1006, 2, 1)
INSERT [dbo].[tblPhieuGiaoXuat] ([ID], [IDChiTietHoaDonXuat], [SoLuong], [LanXuat]) VALUES (8, 1005, 4, 1)
INSERT [dbo].[tblPhieuGiaoXuat] ([ID], [IDChiTietHoaDonXuat], [SoLuong], [LanXuat]) VALUES (9, 1006, 2, 3)
SET IDENTITY_INSERT [dbo].[tblPhieuGiaoXuat] OFF
GO
ALTER TABLE [dbo].[tblChiTietHoaDonNhap]  WITH CHECK ADD FOREIGN KEY([IDGiamGia])
REFERENCES [dbo].[tblGiamGia] ([ID])
GO
ALTER TABLE [dbo].[tblChiTietHoaDonNhap]  WITH CHECK ADD FOREIGN KEY([IDHDNhap])
REFERENCES [dbo].[tblHoaDonNhap] ([ID])
GO
ALTER TABLE [dbo].[tblChiTietHoaDonNhap]  WITH CHECK ADD FOREIGN KEY([IDNCC])
REFERENCES [dbo].[tblNCC] ([ID])
GO
ALTER TABLE [dbo].[tblChiTietHoaDonNhap]  WITH CHECK ADD FOREIGN KEY([IDHH])
REFERENCES [dbo].[tblHangHoa] ([ID])
GO
ALTER TABLE [dbo].[tblChiTietHoaDonXuat]  WITH CHECK ADD FOREIGN KEY([IDGiamGia])
REFERENCES [dbo].[tblGiamGia] ([ID])
GO
ALTER TABLE [dbo].[tblChiTietHoaDonXuat]  WITH CHECK ADD FOREIGN KEY([IDHoaDonXuat])
REFERENCES [dbo].[tblHoaDonXuat] ([ID])
GO
ALTER TABLE [dbo].[tblChiTietHoaDonXuat]  WITH CHECK ADD FOREIGN KEY([IDKho])
REFERENCES [dbo].[tblKho] ([ID])
GO
ALTER TABLE [dbo].[tblChiTietHoaDonXuat]  WITH CHECK ADD FOREIGN KEY([IDKhoHangHoa])
REFERENCES [dbo].[tblKho_HangHoa] ([ID])
GO
ALTER TABLE [dbo].[tblChiTietHoaDonXuat]  WITH CHECK ADD FOREIGN KEY([IDHH])
REFERENCES [dbo].[tblHangHoa] ([ID])
GO
ALTER TABLE [dbo].[tblHangHoa]  WITH CHECK ADD FOREIGN KEY([IDDVT])
REFERENCES [dbo].[tblDVT] ([ID])
GO
ALTER TABLE [dbo].[tblHangHoa]  WITH CHECK ADD FOREIGN KEY([IDMaLoai])
REFERENCES [dbo].[tblLoaiVatLieu] ([ID])
GO
ALTER TABLE [dbo].[tblHoaDonNhap]  WITH CHECK ADD FOREIGN KEY([IDNguoiDuyet])
REFERENCES [dbo].[tblNhanVien] ([ID])
GO
ALTER TABLE [dbo].[tblHoaDonNhap]  WITH CHECK ADD FOREIGN KEY([IDNV])
REFERENCES [dbo].[tblNhanVien] ([ID])
GO
ALTER TABLE [dbo].[tblHoaDonXuat]  WITH CHECK ADD FOREIGN KEY([IDNguoiDuyet])
REFERENCES [dbo].[tblNhanVien] ([ID])
GO
ALTER TABLE [dbo].[tblHoaDonXuat]  WITH CHECK ADD FOREIGN KEY([IDKH])
REFERENCES [dbo].[tblKhachHang] ([ID])
GO
ALTER TABLE [dbo].[tblHoaDonXuat]  WITH CHECK ADD FOREIGN KEY([IDNV])
REFERENCES [dbo].[tblNhanVien] ([ID])
GO
ALTER TABLE [dbo].[tblKho_HangHoa]  WITH CHECK ADD FOREIGN KEY([IDKho])
REFERENCES [dbo].[tblKho] ([ID])
GO
ALTER TABLE [dbo].[tblKho_HangHoa]  WITH CHECK ADD FOREIGN KEY([IDHH])
REFERENCES [dbo].[tblHangHoa] ([ID])
GO
ALTER TABLE [dbo].[tblNhanVien]  WITH CHECK ADD FOREIGN KEY([IDPhanQuyen])
REFERENCES [dbo].[tblPhanQuyen] ([ID])
GO
ALTER TABLE [dbo].[tblPhieuGiaoNhap]  WITH CHECK ADD FOREIGN KEY([IDChiTietHoaDonNhap])
REFERENCES [dbo].[tblChiTietHoaDonNhap] ([ID])
GO
ALTER TABLE [dbo].[tblPhieuGiaoXuat]  WITH CHECK ADD FOREIGN KEY([IDChiTietHoaDonXuat])
REFERENCES [dbo].[tblChiTietHoaDonXuat] ([ID])
GO
USE [master]
GO
ALTER DATABASE [QLVLXD] SET  READ_WRITE 
GO
