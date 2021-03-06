USE [master]
GO
/****** Object:  Database [QLCHTraSuaVaDoAnVat]    Script Date: 11/30/2017 17:34:34 ******/
CREATE DATABASE [QLCHTraSuaVaDoAnVat] ON  PRIMARY 
( NAME = N'QLCHTraSuaVaDoAnVat', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\QLCHTraSuaVaDoAnVat.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLCHTraSuaVaDoAnVat_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\QLCHTraSuaVaDoAnVat_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLCHTraSuaVaDoAnVat] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLCHTraSuaVaDoAnVat].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLCHTraSuaVaDoAnVat] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [QLCHTraSuaVaDoAnVat] SET ANSI_NULLS OFF
GO
ALTER DATABASE [QLCHTraSuaVaDoAnVat] SET ANSI_PADDING OFF
GO
ALTER DATABASE [QLCHTraSuaVaDoAnVat] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [QLCHTraSuaVaDoAnVat] SET ARITHABORT OFF
GO
ALTER DATABASE [QLCHTraSuaVaDoAnVat] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [QLCHTraSuaVaDoAnVat] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [QLCHTraSuaVaDoAnVat] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [QLCHTraSuaVaDoAnVat] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [QLCHTraSuaVaDoAnVat] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [QLCHTraSuaVaDoAnVat] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [QLCHTraSuaVaDoAnVat] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [QLCHTraSuaVaDoAnVat] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [QLCHTraSuaVaDoAnVat] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [QLCHTraSuaVaDoAnVat] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [QLCHTraSuaVaDoAnVat] SET  DISABLE_BROKER
GO
ALTER DATABASE [QLCHTraSuaVaDoAnVat] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [QLCHTraSuaVaDoAnVat] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [QLCHTraSuaVaDoAnVat] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [QLCHTraSuaVaDoAnVat] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [QLCHTraSuaVaDoAnVat] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [QLCHTraSuaVaDoAnVat] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [QLCHTraSuaVaDoAnVat] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [QLCHTraSuaVaDoAnVat] SET  READ_WRITE
GO
ALTER DATABASE [QLCHTraSuaVaDoAnVat] SET RECOVERY SIMPLE
GO
ALTER DATABASE [QLCHTraSuaVaDoAnVat] SET  MULTI_USER
GO
ALTER DATABASE [QLCHTraSuaVaDoAnVat] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [QLCHTraSuaVaDoAnVat] SET DB_CHAINING OFF
GO
USE [QLCHTraSuaVaDoAnVat]
GO
/****** Object:  Table [dbo].[LoaiLuong]    Script Date: 11/30/2017 17:34:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoaiLuong](
	[ma_loai_luong] [char](5) NOT NULL,
	[ten_loai_luong] [nvarchar](50) NOT NULL,
	[luong_co_ban] [float] NOT NULL,
	[don_vi_tien] [nchar](10) NOT NULL,
	[don_vi_tinh] [nchar](15) NOT NULL,
 CONSTRAINT [PK_LoaiLuong] PRIMARY KEY CLUSTERED 
(
	[ma_loai_luong] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[LoaiLuong] ([ma_loai_luong], [ten_loai_luong], [luong_co_ban], [don_vi_tien], [don_vi_tinh]) VALUES (N'LL001', N'Lương quản lý', 6000000, N'VNĐ       ', N'Tháng          ')
INSERT [dbo].[LoaiLuong] ([ma_loai_luong], [ten_loai_luong], [luong_co_ban], [don_vi_tien], [don_vi_tinh]) VALUES (N'LL002', N'Lương nhân viên', 15000, N'VNĐ       ', N'Ca             ')
/****** Object:  Table [dbo].[KhachHang]    Script Date: 11/30/2017 17:34:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[ma_khach_hang] [char](6) NOT NULL,
	[ten_khach_hang] [nvarchar](50) NOT NULL,
	[gioi_tinh] [bit] NULL,
	[ngay_sinh] [datetime] NULL,
	[email] [char](25) NULL,
	[so_dien_thoai] [char](15) NULL,
	[dia_chi] [nvarchar](250) NULL,
	[trang_thai] [bit] NOT NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[ma_khach_hang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[KhachHang] ([ma_khach_hang], [ten_khach_hang], [gioi_tinh], [ngay_sinh], [email], [so_dien_thoai], [dia_chi], [trang_thai]) VALUES (N'KH0001', N'Nguyễn Kim Liên', 1, CAST(0x00007EFB00000000 AS DateTime), N'kimlien@gmail.com        ', N'01227873412    ', N'Hồ Chí Minh cityyyy', 1)
INSERT [dbo].[KhachHang] ([ma_khach_hang], [ten_khach_hang], [gioi_tinh], [ngay_sinh], [email], [so_dien_thoai], [dia_chi], [trang_thai]) VALUES (N'KH0002', N'Phạm Đức Trung', 1, CAST(0x0000852600000000 AS DateTime), N'ductrung@gmail.com       ', N'0909234567     ', N'Quận 7, Hồ Chí Minh', 1)
INSERT [dbo].[KhachHang] ([ma_khach_hang], [ten_khach_hang], [gioi_tinh], [ngay_sinh], [email], [so_dien_thoai], [dia_chi], [trang_thai]) VALUES (N'KH0003', N'Võ Anh Minh', 1, CAST(0x0000732100000000 AS DateTime), N'anhminh@gmail.com        ', N'0981448726     ', N'Quận 5, Hồ Chí Minh', 1)
INSERT [dbo].[KhachHang] ([ma_khach_hang], [ten_khach_hang], [gioi_tinh], [ngay_sinh], [email], [so_dien_thoai], [dia_chi], [trang_thai]) VALUES (N'KH0004', N'Vương Vũ Bảo', 1, CAST(0x000088F500000000 AS DateTime), N'vubao@gmail.com          ', N'0932456987     ', N'Quận 3, Hồ Chí Minh', 1)
INSERT [dbo].[KhachHang] ([ma_khach_hang], [ten_khach_hang], [gioi_tinh], [ngay_sinh], [email], [so_dien_thoai], [dia_chi], [trang_thai]) VALUES (N'KH0005', N'Đỗ Văn Thắng', 1, CAST(0x000080E800000000 AS DateTime), N'vanthang@gmail.com       ', N'01234656768    ', N'Quận Tân Phú, Hồ Chí Minh', 1)
INSERT [dbo].[KhachHang] ([ma_khach_hang], [ten_khach_hang], [gioi_tinh], [ngay_sinh], [email], [so_dien_thoai], [dia_chi], [trang_thai]) VALUES (N'KH0006', N'Lê Kim Khánh', 0, CAST(0x00008B8D00000000 AS DateTime), N'kimkhanh@gmail.com       ', N'0817166144     ', N'Quận 4, Hồ Chí Minh', 1)
INSERT [dbo].[KhachHang] ([ma_khach_hang], [ten_khach_hang], [gioi_tinh], [ngay_sinh], [email], [so_dien_thoai], [dia_chi], [trang_thai]) VALUES (N'KH0007', N'Phạm Văn Ba', 1, CAST(0x00006B4F00000000 AS DateTime), NULL, N'0981236776     ', N'Quận Gò Gấp, Hồ Chí Minh', 1)
INSERT [dbo].[KhachHang] ([ma_khach_hang], [ten_khach_hang], [gioi_tinh], [ngay_sinh], [email], [so_dien_thoai], [dia_chi], [trang_thai]) VALUES (N'KH0008', N'Test Khách Hàng', 0, CAST(0x00008EBF00000000 AS DateTime), NULL, N'               ', N'', 1)
/****** Object:  Table [dbo].[KichThuocMonAn]    Script Date: 11/30/2017 17:34:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KichThuocMonAn](
	[ma_kich_thuoc] [char](5) NOT NULL,
	[ten_kich_thuoc] [nvarchar](20) NOT NULL,
	[trang_thai] [bit] NOT NULL,
 CONSTRAINT [PK_SizeMonAn] PRIMARY KEY CLUSTERED 
(
	[ma_kich_thuoc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[KichThuocMonAn] ([ma_kich_thuoc], [ten_kich_thuoc], [trang_thai]) VALUES (N'KTAN ', N'Nhỏ', 1)
INSERT [dbo].[KichThuocMonAn] ([ma_kich_thuoc], [ten_kich_thuoc], [trang_thai]) VALUES (N'KTUL ', N'Lớn', 1)
INSERT [dbo].[KichThuocMonAn] ([ma_kich_thuoc], [ten_kich_thuoc], [trang_thai]) VALUES (N'KTUM ', N'Vừa', 1)
INSERT [dbo].[KichThuocMonAn] ([ma_kich_thuoc], [ten_kich_thuoc], [trang_thai]) VALUES (N'KTUS ', N'Cực đại', 1)
/****** Object:  Table [dbo].[LoiViPham]    Script Date: 11/30/2017 17:34:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoiViPham](
	[ma_loi_vi_pham] [char](10) NOT NULL,
	[ten_loi_vi_pham] [nvarchar](70) NOT NULL,
	[so_tien_tru] [float] NOT NULL,
	[ghi_chu] [nvarchar](200) NULL,
	[trang_thai] [bit] NOT NULL,
 CONSTRAINT [PK_LoiViPham] PRIMARY KEY CLUSTERED 
(
	[ma_loi_vi_pham] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'lý do gì đó / lý do khác' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LoiViPham', @level2type=N'COLUMN',@level2name=N'ten_loi_vi_pham'
GO
/****** Object:  Table [dbo].[LoaiTheKhachHang]    Script Date: 11/30/2017 17:34:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoaiTheKhachHang](
	[ma_loai_the] [char](10) NOT NULL,
	[ten_loai_the_khach_hang] [nvarchar](30) NOT NULL,
	[giam_gia] [float] NOT NULL,
	[don_vi_giam_gia] [nvarchar](20) NULL,
	[trang_thai] [bit] NULL,
 CONSTRAINT [PK_LoaiKhachHang] PRIMARY KEY CLUSTERED 
(
	[ma_loai_the] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[LoaiTheKhachHang] ([ma_loai_the], [ten_loai_the_khach_hang], [giam_gia], [don_vi_giam_gia], [trang_thai]) VALUES (N'1234567890', N'Thẻ thành viên', 10, N'Phần trăm (%)', 1)
/****** Object:  Table [dbo].[LoaiNguyenLieu]    Script Date: 11/30/2017 17:34:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoaiNguyenLieu](
	[ma_loai_nguyen_lieu] [char](6) NOT NULL,
	[ten_loai_nguyen_lieu] [nvarchar](150) NOT NULL,
	[trang_thai] [bit] NOT NULL,
 CONSTRAINT [PK_LoaiNguyenLieu] PRIMARY KEY CLUSTERED 
(
	[ma_loai_nguyen_lieu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[LoaiNguyenLieu] ([ma_loai_nguyen_lieu], [ten_loai_nguyen_lieu], [trang_thai]) VALUES (N'LNL001', N'Thạch', 1)
INSERT [dbo].[LoaiNguyenLieu] ([ma_loai_nguyen_lieu], [ten_loai_nguyen_lieu], [trang_thai]) VALUES (N'LNL002', N'Bột', 1)
INSERT [dbo].[LoaiNguyenLieu] ([ma_loai_nguyen_lieu], [ten_loai_nguyen_lieu], [trang_thai]) VALUES (N'LNL003', N'Sữa', 1)
/****** Object:  Table [dbo].[DonViTinh]    Script Date: 11/30/2017 17:34:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DonViTinh](
	[ma_don_vi_tinh] [char](5) NOT NULL,
	[ten_don_vi_tinh] [nvarchar](20) NOT NULL,
	[trang_thai] [bit] NULL,
 CONSTRAINT [PK_DonViTinh] PRIMARY KEY CLUSTERED 
(
	[ma_don_vi_tinh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[DonViTinh] ([ma_don_vi_tinh], [ten_don_vi_tinh], [trang_thai]) VALUES (N'DVT01', N'Ly', NULL)
INSERT [dbo].[DonViTinh] ([ma_don_vi_tinh], [ten_don_vi_tinh], [trang_thai]) VALUES (N'DVT02', N'Phần', NULL)
INSERT [dbo].[DonViTinh] ([ma_don_vi_tinh], [ten_don_vi_tinh], [trang_thai]) VALUES (N'DVT03', N'Kilogram', NULL)
INSERT [dbo].[DonViTinh] ([ma_don_vi_tinh], [ten_don_vi_tinh], [trang_thai]) VALUES (N'DVT04', N'Gram', NULL)
INSERT [dbo].[DonViTinh] ([ma_don_vi_tinh], [ten_don_vi_tinh], [trang_thai]) VALUES (N'DVT05', N'Lít', NULL)
INSERT [dbo].[DonViTinh] ([ma_don_vi_tinh], [ten_don_vi_tinh], [trang_thai]) VALUES (N'DVT06', N'Mililit', NULL)
INSERT [dbo].[DonViTinh] ([ma_don_vi_tinh], [ten_don_vi_tinh], [trang_thai]) VALUES (N'DVT07', N'Chai', NULL)
INSERT [dbo].[DonViTinh] ([ma_don_vi_tinh], [ten_don_vi_tinh], [trang_thai]) VALUES (N'DVT08', N'Cái', NULL)
INSERT [dbo].[DonViTinh] ([ma_don_vi_tinh], [ten_don_vi_tinh], [trang_thai]) VALUES (N'DVT09', N'Túi', NULL)
INSERT [dbo].[DonViTinh] ([ma_don_vi_tinh], [ten_don_vi_tinh], [trang_thai]) VALUES (N'DVT10', N'Thìa', 1)
INSERT [dbo].[DonViTinh] ([ma_don_vi_tinh], [ten_don_vi_tinh], [trang_thai]) VALUES (N'DVT11', N'Cục', 1)
/****** Object:  Table [dbo].[ChucVu]    Script Date: 11/30/2017 17:34:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChucVu](
	[ma_chuc_vu] [char](5) NOT NULL,
	[ten_chuc_vu] [nvarchar](20) NOT NULL,
	[trang_thai] [bit] NOT NULL,
 CONSTRAINT [PK_LoaiNhanVien] PRIMARY KEY CLUSTERED 
(
	[ma_chuc_vu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'nv bán hàng, nv quản lý, nv phục vụ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ChucVu', @level2type=N'COLUMN',@level2name=N'ten_chuc_vu'
GO
INSERT [dbo].[ChucVu] ([ma_chuc_vu], [ten_chuc_vu], [trang_thai]) VALUES (N'CV001', N'Quản lý', 1)
INSERT [dbo].[ChucVu] ([ma_chuc_vu], [ten_chuc_vu], [trang_thai]) VALUES (N'CV002', N'Nhân viên', 1)
INSERT [dbo].[ChucVu] ([ma_chuc_vu], [ten_chuc_vu], [trang_thai]) VALUES (N'CV003', N'Giám đốc', 1)
/****** Object:  Table [dbo].[ChucNang]    Script Date: 11/30/2017 17:34:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChucNang](
	[ma_chuc_nang] [char](6) NOT NULL,
	[ten_chuc_nang] [nvarchar](100) NOT NULL,
	[ghi_chu] [ntext] NULL,
	[trang_thai] [bit] NOT NULL,
 CONSTRAINT [PK_ChucNang] PRIMARY KEY CLUSTERED 
(
	[ma_chuc_nang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ChucNang] ([ma_chuc_nang], [ten_chuc_nang], [ghi_chu], [trang_thai]) VALUES (N'CN0001', N'Chấm công', NULL, 0)
INSERT [dbo].[ChucNang] ([ma_chuc_nang], [ten_chuc_nang], [ghi_chu], [trang_thai]) VALUES (N'CN0002', N'Quản lý lỗi nhân viên', NULL, 0)
INSERT [dbo].[ChucNang] ([ma_chuc_nang], [ten_chuc_nang], [ghi_chu], [trang_thai]) VALUES (N'CN0003', N'Phân công', N'Phân công công việc cho nhân viên', 1)
INSERT [dbo].[ChucNang] ([ma_chuc_nang], [ten_chuc_nang], [ghi_chu], [trang_thai]) VALUES (N'CN0004', N'Quản lý nhân viên', N'Xem, thêm, chỉnh sửa thông tin nhân viên, chỉnh sửa tài khoản nhân viên', 1)
INSERT [dbo].[ChucNang] ([ma_chuc_nang], [ten_chuc_nang], [ghi_chu], [trang_thai]) VALUES (N'CN0006', N'Quản lý nguyên liệu', N'Nhập(thêm), Xem, chỉnh sửa, thống kê nguyên liệu, nhà cung cấp', 1)
INSERT [dbo].[ChucNang] ([ma_chuc_nang], [ten_chuc_nang], [ghi_chu], [trang_thai]) VALUES (N'CN0007', N'Quản lý doanh thu', N'Xem. thêm, sửa, xóa', 0)
INSERT [dbo].[ChucNang] ([ma_chuc_nang], [ten_chuc_nang], [ghi_chu], [trang_thai]) VALUES (N'CN0008', N'Quản lý khách hàng', N'Xem, thêm, chỉnh sửa, xóa khách hàng', 1)
INSERT [dbo].[ChucNang] ([ma_chuc_nang], [ten_chuc_nang], [ghi_chu], [trang_thai]) VALUES (N'CN0009', N'Bán hàng', N'Bán hàng, ghi hóa đơn bán hàng', 1)
INSERT [dbo].[ChucNang] ([ma_chuc_nang], [ten_chuc_nang], [ghi_chu], [trang_thai]) VALUES (N'CN0010', N'Quản lý lịch làm việc', N'Xem, xếp  lịch làm việc ngày, tuần, tháng, năm', 0)
INSERT [dbo].[ChucNang] ([ma_chuc_nang], [ten_chuc_nang], [ghi_chu], [trang_thai]) VALUES (N'CN0011', N'Quản lý lịch sử bán', N'Xem hóa đơn bán đẫ xuất và phiếu giao hàng', 0)
INSERT [dbo].[ChucNang] ([ma_chuc_nang], [ten_chuc_nang], [ghi_chu], [trang_thai]) VALUES (N'CN0012', N'Quản lý thông tin CH', N'Xóa, sửa, Wifi, địa chỉ, tên cửa hàng, sđt,....', 0)
INSERT [dbo].[ChucNang] ([ma_chuc_nang], [ten_chuc_nang], [ghi_chu], [trang_thai]) VALUES (N'CN0013', N'Quản lý sản phẩm', NULL, 1)
INSERT [dbo].[ChucNang] ([ma_chuc_nang], [ten_chuc_nang], [ghi_chu], [trang_thai]) VALUES (N'CN0014', N'Quản lý cửa hàng', N'Thêm, sửa, xóa thông tin cửa hàng', 1)
INSERT [dbo].[ChucNang] ([ma_chuc_nang], [ten_chuc_nang], [ghi_chu], [trang_thai]) VALUES (N'CN0015', N'Bán dâm', NULL, 0)
/****** Object:  Table [dbo].[CuaHang]    Script Date: 11/30/2017 17:34:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CuaHang](
	[ma_cua_hang] [char](10) NOT NULL,
	[ten_cua_hang] [nvarchar](50) NULL,
	[logo] [nvarchar](250) NULL,
	[dia_chi] [nvarchar](200) NULL,
	[so_dien_thoai] [char](15) NULL,
	[passwifi] [nchar](100) NULL,
	[giay_phep_kinh_doanh] [nvarchar](20) NULL,
	[trang_thai] [bit] NULL,
 CONSTRAINT [PK_CuaHang] PRIMARY KEY CLUSTERED 
(
	[ma_cua_hang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CuaHang] ([ma_cua_hang], [ten_cua_hang], [logo], [dia_chi], [so_dien_thoai], [passwifi], [giay_phep_kinh_doanh], [trang_thai]) VALUES (N'CH00000001', N'CBVN', N'HinhAnh\Logo\logo-comebuy.png', N'200, Huỳnh Thúc Kháng, P.Bến Nghe, Q.1, TP.Hồ Chí Minh', N'1234567891     ', N'69696969                                                                                            ', N'GPKDS00012', 1)
/****** Object:  Table [dbo].[CaLamViec]    Script Date: 11/30/2017 17:34:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CaLamViec](
	[ma_ca_lam] [char](5) NOT NULL,
	[ten_ca] [nvarchar](20) NULL,
	[thoi_gian_bat_dau] [time](7) NULL,
	[thoi_gian_ket_thuc] [time](7) NULL,
	[trang_thai] [bit] NULL,
 CONSTRAINT [PK_CaLamViec] PRIMARY KEY CLUSTERED 
(
	[ma_ca_lam] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CaLamViec] ([ma_ca_lam], [ten_ca], [thoi_gian_bat_dau], [thoi_gian_ket_thuc], [trang_thai]) VALUES (N'Ca001', N'Ca sáng', CAST(0x0700B893419F0000 AS Time), CAST(0x07001882BA7D0000 AS Time), 1)
INSERT [dbo].[CaLamViec] ([ma_ca_lam], [ten_ca], [thoi_gian_bat_dau], [thoi_gian_ket_thuc], [trang_thai]) VALUES (N'Ca002', N'Ca chiều', CAST(0x07001882BA7D0000 AS Time), CAST(0x0700F0E066B80000 AS Time), 1)
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 11/30/2017 17:34:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[ma_nha_cung_cap] [char](6) NOT NULL,
	[ten_nha_cung_cap] [nvarchar](30) NOT NULL,
	[dia_chi] [nvarchar](30) NOT NULL,
	[so_dien_thoai] [varchar](15) NOT NULL,
	[trang_thai] [bit] NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[ma_nha_cung_cap] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[NhaCungCap] ([ma_nha_cung_cap], [ten_nha_cung_cap], [dia_chi], [so_dien_thoai], [trang_thai]) VALUES (N'NCC001', N'Microsoft', N'Nhà bill', N'1111999', 1)
/****** Object:  Table [dbo].[NhomMonAn]    Script Date: 11/30/2017 17:34:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhomMonAn](
	[ma_nhom_mon_an] [char](5) NOT NULL,
	[ten_nhom] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_NhomMonAn] PRIMARY KEY CLUSTERED 
(
	[ma_nhom_mon_an] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Thức ăn và đồ uống' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'NhomMonAn', @level2type=N'COLUMN',@level2name=N'ten_nhom'
GO
INSERT [dbo].[NhomMonAn] ([ma_nhom_mon_an], [ten_nhom]) VALUES (N'NMA01', N'Đồ ăn')
INSERT [dbo].[NhomMonAn] ([ma_nhom_mon_an], [ten_nhom]) VALUES (N'NMA02', N'Thức uống')
INSERT [dbo].[NhomMonAn] ([ma_nhom_mon_an], [ten_nhom]) VALUES (N'NMA03', N'Topping')
/****** Object:  Table [dbo].[QuyenDangNhap]    Script Date: 11/30/2017 17:34:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[QuyenDangNhap](
	[ma_quyen_dang_nhap] [char](6) NOT NULL,
	[ten_quyen_dang_nhap] [nvarchar](30) NOT NULL,
	[trang_thai] [bit] NOT NULL,
 CONSTRAINT [PK_LoaiTaiKhoan] PRIMARY KEY CLUSTERED 
(
	[ma_quyen_dang_nhap] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'admin, quản lý, bán hàng,...' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'QuyenDangNhap', @level2type=N'COLUMN',@level2name=N'ten_quyen_dang_nhap'
GO
INSERT [dbo].[QuyenDangNhap] ([ma_quyen_dang_nhap], [ten_quyen_dang_nhap], [trang_thai]) VALUES (N'QDN001', N'Quản lý', 1)
INSERT [dbo].[QuyenDangNhap] ([ma_quyen_dang_nhap], [ten_quyen_dang_nhap], [trang_thai]) VALUES (N'QDN002', N'Nhân viên', 1)
INSERT [dbo].[QuyenDangNhap] ([ma_quyen_dang_nhap], [ten_quyen_dang_nhap], [trang_thai]) VALUES (N'QDN003', N'Khách hàng', 0)
INSERT [dbo].[QuyenDangNhap] ([ma_quyen_dang_nhap], [ten_quyen_dang_nhap], [trang_thai]) VALUES (N'QDN004', N'Giám đốc', 1)
/****** Object:  Table [dbo].[TrangThaiNhanVien]    Script Date: 11/30/2017 17:34:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrangThaiNhanVien](
	[ma_trang_thai_nhan_vien] [int] NOT NULL,
	[ten_trang_thai] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_TrangThaiNhanVien] PRIMARY KEY CLUSTERED 
(
	[ma_trang_thai_nhan_vien] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[TrangThaiNhanVien] ([ma_trang_thai_nhan_vien], [ten_trang_thai]) VALUES (1, N'Đang làm việc')
INSERT [dbo].[TrangThaiNhanVien] ([ma_trang_thai_nhan_vien], [ten_trang_thai]) VALUES (2, N'Đã nghỉ việc')
INSERT [dbo].[TrangThaiNhanVien] ([ma_trang_thai_nhan_vien], [ten_trang_thai]) VALUES (3, N'Chờ vào làm')
INSERT [dbo].[TrangThaiNhanVien] ([ma_trang_thai_nhan_vien], [ten_trang_thai]) VALUES (4, N'Đã xóa')
/****** Object:  Table [dbo].[TrangThaiBanPhanCong]    Script Date: 11/30/2017 17:34:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrangThaiBanPhanCong](
	[ma_trang_thai_bpc] [int] NOT NULL,
	[ten_trang_thai_bpc] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TrangThaiBanPhanCong] PRIMARY KEY CLUSTERED 
(
	[ma_trang_thai_bpc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[TrangThaiBanPhanCong] ([ma_trang_thai_bpc], [ten_trang_thai_bpc]) VALUES (1, N'Đi làm')
INSERT [dbo].[TrangThaiBanPhanCong] ([ma_trang_thai_bpc], [ten_trang_thai_bpc]) VALUES (2, N'Đi trễ')
INSERT [dbo].[TrangThaiBanPhanCong] ([ma_trang_thai_bpc], [ten_trang_thai_bpc]) VALUES (3, N'Nghỉ có phép')
INSERT [dbo].[TrangThaiBanPhanCong] ([ma_trang_thai_bpc], [ten_trang_thai_bpc]) VALUES (4, N'Nghỉ không  phép')
INSERT [dbo].[TrangThaiBanPhanCong] ([ma_trang_thai_bpc], [ten_trang_thai_bpc]) VALUES (5, N'Chưa chấm công')
INSERT [dbo].[TrangThaiBanPhanCong] ([ma_trang_thai_bpc], [ten_trang_thai_bpc]) VALUES (6, N'Đã xóa')
/****** Object:  Table [dbo].[TheKhachHang]    Script Date: 11/30/2017 17:34:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TheKhachHang](
	[ma_the] [char](10) NOT NULL,
	[ma_khach_hang] [char](6) NOT NULL,
	[ma_loai_the] [char](10) NOT NULL,
	[ngay_dang_ky] [datetime] NULL,
	[trang_thai] [bit] NULL,
 CONSTRAINT [PK_ChiTietTheKhachHang] PRIMARY KEY CLUSTERED 
(
	[ma_the] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[TheKhachHang] ([ma_the], [ma_khach_hang], [ma_loai_the], [ngay_dang_ky], [trang_thai]) VALUES (N'0000000001', N'KH0001', N'1234567890', CAST(0x0000A81000000000 AS DateTime), 1)
INSERT [dbo].[TheKhachHang] ([ma_the], [ma_khach_hang], [ma_loai_the], [ngay_dang_ky], [trang_thai]) VALUES (N'0000000002', N'KH0002', N'1234567890', CAST(0x0000A5FD00000000 AS DateTime), 1)
INSERT [dbo].[TheKhachHang] ([ma_the], [ma_khach_hang], [ma_loai_the], [ngay_dang_ky], [trang_thai]) VALUES (N'0000000003', N'KH0003', N'1234567890', CAST(0x0000A69B00000000 AS DateTime), 1)
INSERT [dbo].[TheKhachHang] ([ma_the], [ma_khach_hang], [ma_loai_the], [ngay_dang_ky], [trang_thai]) VALUES (N'0000000004', N'KH0004', N'1234567890', CAST(0x0000A6EC00000000 AS DateTime), 1)
INSERT [dbo].[TheKhachHang] ([ma_the], [ma_khach_hang], [ma_loai_the], [ngay_dang_ky], [trang_thai]) VALUES (N'0000000005', N'KH0005', N'1234567890', CAST(0x0000A7E800000000 AS DateTime), 1)
INSERT [dbo].[TheKhachHang] ([ma_the], [ma_khach_hang], [ma_loai_the], [ngay_dang_ky], [trang_thai]) VALUES (N'0000000006', N'KH0006', N'1234567890', CAST(0x0000A58000000000 AS DateTime), 1)
INSERT [dbo].[TheKhachHang] ([ma_the], [ma_khach_hang], [ma_loai_the], [ngay_dang_ky], [trang_thai]) VALUES (N'0000000007', N'KH0007', N'1234567890', CAST(0x0000A6EE00000000 AS DateTime), 1)
INSERT [dbo].[TheKhachHang] ([ma_the], [ma_khach_hang], [ma_loai_the], [ngay_dang_ky], [trang_thai]) VALUES (N'0000000008', N'KH0008', N'1234567890', CAST(0x0000A831004470B4 AS DateTime), 1)
/****** Object:  Table [dbo].[Luong]    Script Date: 11/30/2017 17:34:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Luong](
	[ma_chuc_vu] [char](5) NOT NULL,
	[ma_loai_luong] [char](5) NOT NULL,
	[he_so_tang_luong] [float] NOT NULL,
	[thoi_gian_tang_luong] [int] NULL,
	[don_vi_thoi_gian] [nvarchar](10) NULL,
 CONSTRAINT [PK_Luong] PRIMARY KEY CLUSTERED 
(
	[ma_chuc_vu] ASC,
	[ma_loai_luong] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Luong] ([ma_chuc_vu], [ma_loai_luong], [he_so_tang_luong], [thoi_gian_tang_luong], [don_vi_thoi_gian]) VALUES (N'CV001', N'LL001', 0.1, 1, N'năm')
INSERT [dbo].[Luong] ([ma_chuc_vu], [ma_loai_luong], [he_so_tang_luong], [thoi_gian_tang_luong], [don_vi_thoi_gian]) VALUES (N'CV002', N'LL002', 0.1, 2, N'tháng')
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/30/2017 17:34:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[ma_nhan_vien] [char](6) NOT NULL,
	[ho_ten] [nvarchar](50) NOT NULL,
	[anh_nhan_vien] [varchar](150) NULL,
	[ngay_sinh] [datetime] NULL,
	[gioi_tinh] [bit] NULL,
	[dia_chi] [nvarchar](250) NULL,
	[so_dien_thoai] [char](13) NULL,
	[ngay_bat_dau_lam] [datetime] NULL,
	[ngay_thoi_viec] [datetime] NULL,
	[ma_chuc_vu] [char](5) NULL,
	[ma_nguoi_quan_ly] [char](6) NULL,
	[ma_trang_thai_nhan_vien] [int] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[ma_nhan_vien] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[NhanVien] ([ma_nhan_vien], [ho_ten], [anh_nhan_vien], [ngay_sinh], [gioi_tinh], [dia_chi], [so_dien_thoai], [ngay_bat_dau_lam], [ngay_thoi_viec], [ma_chuc_vu], [ma_nguoi_quan_ly], [ma_trang_thai_nhan_vien]) VALUES (N'N00001', N'Võ Giám Đốc', N'HinhAnh\AnhDaiDien\20171111071820superman2.gif', CAST(0x00007EFB00000000 AS DateTime), 1, N'TP. Hồ Chí Minh', N'01265365544  ', CAST(0x0000A82900000000 AS DateTime), NULL, N'CV003', NULL, 1)
INSERT [dbo].[NhanVien] ([ma_nhan_vien], [ho_ten], [anh_nhan_vien], [ngay_sinh], [gioi_tinh], [dia_chi], [so_dien_thoai], [ngay_bat_dau_lam], [ngay_thoi_viec], [ma_chuc_vu], [ma_nguoi_quan_ly], [ma_trang_thai_nhan_vien]) VALUES (N'N00002', N'Tiêm Xong Chích', N'HinhAnh\AnhDaiDien\AnhDaiDienNamMacDinh.png', CAST(0x0000880000000000 AS DateTime), 1, N'Hồ Chí Minh City', N'0981234568   ', CAST(0x0000A82A00000000 AS DateTime), NULL, N'CV002', N'QL0001', 1)
INSERT [dbo].[NhanVien] ([ma_nhan_vien], [ho_ten], [anh_nhan_vien], [ngay_sinh], [gioi_tinh], [dia_chi], [so_dien_thoai], [ngay_bat_dau_lam], [ngay_thoi_viec], [ma_chuc_vu], [ma_nguoi_quan_ly], [ma_trang_thai_nhan_vien]) VALUES (N'N00003', N'Lê Quang Hải', N'HinhAnh\AnhDaiDien\AnhDaiDienNamMacDinh.png', CAST(0x00008A5900000000 AS DateTime), 1, N'Quận 7, TP.Hồ Chí Minh', N'0126223456   ', CAST(0x0000A78200000000 AS DateTime), CAST(0x0000A80800000000 AS DateTime), N'CV002', N'QL0001', 2)
INSERT [dbo].[NhanVien] ([ma_nhan_vien], [ho_ten], [anh_nhan_vien], [ngay_sinh], [gioi_tinh], [dia_chi], [so_dien_thoai], [ngay_bat_dau_lam], [ngay_thoi_viec], [ma_chuc_vu], [ma_nguoi_quan_ly], [ma_trang_thai_nhan_vien]) VALUES (N'N00004', N'Lê Đức Huy', N'HinhAnh\AnhDaiDien\636443030802733273-loading-sheep.gif', CAST(0x00008B5900000000 AS DateTime), 1, N'Gò Vấp, TP. Hồ Chí Minh', N'01634688175  ', CAST(0x0000A7DF00000000 AS DateTime), NULL, N'CV002', N'QL0001', 1)
INSERT [dbo].[NhanVien] ([ma_nhan_vien], [ho_ten], [anh_nhan_vien], [ngay_sinh], [gioi_tinh], [dia_chi], [so_dien_thoai], [ngay_bat_dau_lam], [ngay_thoi_viec], [ma_chuc_vu], [ma_nguoi_quan_ly], [ma_trang_thai_nhan_vien]) VALUES (N'N00005', N'Vũ Minh Luân', N'HinhAnh\AnhDaiDien\636443029195726951-2017-09-24-15-53-34.jpg', CAST(0x00008B2700000000 AS DateTime), 1, N'Tân Phú , TP.Hồ Chí Minh', N'01227978173  ', CAST(0x0000A7E500000000 AS DateTime), NULL, N'CV002', N'QL0001', 1)
INSERT [dbo].[NhanVien] ([ma_nhan_vien], [ho_ten], [anh_nhan_vien], [ngay_sinh], [gioi_tinh], [dia_chi], [so_dien_thoai], [ngay_bat_dau_lam], [ngay_thoi_viec], [ma_chuc_vu], [ma_nguoi_quan_ly], [ma_trang_thai_nhan_vien]) VALUES (N'N00006', N'Mai Thanh Quý', N'HinhAnh\AnhDaiDien\AnhDaiDienNamMacDinh.png', NULL, 1, N'Quận 4, TP.Hồ Chí Minh', N'01           ', NULL, NULL, N'CV002', N'QL0001', 1)
INSERT [dbo].[NhanVien] ([ma_nhan_vien], [ho_ten], [anh_nhan_vien], [ngay_sinh], [gioi_tinh], [dia_chi], [so_dien_thoai], [ngay_bat_dau_lam], [ngay_thoi_viec], [ma_chuc_vu], [ma_nguoi_quan_ly], [ma_trang_thai_nhan_vien]) VALUES (N'N00007', N'Bùi Thị Thanh Mai', N'HinhAnh\AnhDaiDien\AnhDaiDienNuMacDinh.png', CAST(0x00008B4400000000 AS DateTime), 0, N'Một Nơi Nào Đó Trên Trái Đất', N'0903457121   ', CAST(0x0000A6EE00000000 AS DateTime), CAST(0x0000A829002E467C AS DateTime), N'CV002', N'QL0001', 2)
INSERT [dbo].[NhanVien] ([ma_nhan_vien], [ho_ten], [anh_nhan_vien], [ngay_sinh], [gioi_tinh], [dia_chi], [so_dien_thoai], [ngay_bat_dau_lam], [ngay_thoi_viec], [ma_chuc_vu], [ma_nguoi_quan_ly], [ma_trang_thai_nhan_vien]) VALUES (N'N00008', N'Lý Nhã Kỳ', N'HinhAnh\AnhDaiDien\AnhDaiDienNuMacDinh.png', CAST(0x00008BA601714854 AS DateTime), 0, N'', N'             ', CAST(0x0000A6FF01714854 AS DateTime), NULL, N'CV002', N'QL0001', 1)
INSERT [dbo].[NhanVien] ([ma_nhan_vien], [ho_ten], [anh_nhan_vien], [ngay_sinh], [gioi_tinh], [dia_chi], [so_dien_thoai], [ngay_bat_dau_lam], [ngay_thoi_viec], [ma_chuc_vu], [ma_nguoi_quan_ly], [ma_trang_thai_nhan_vien]) VALUES (N'N00009', N'Phạm Quang Phú', N'HinhAnh\AnhDaiDien\AnhDaiDienNamMacDinh.png', CAST(0x00008A4700000000 AS DateTime), 1, N'abcasdasdwasdasd', N'123123123123 ', CAST(0x0000A77400000000 AS DateTime), CAST(0x0000A8250021546C AS DateTime), N'CV002', N'QL0001', 2)
INSERT [dbo].[NhanVien] ([ma_nhan_vien], [ho_ten], [anh_nhan_vien], [ngay_sinh], [gioi_tinh], [dia_chi], [so_dien_thoai], [ngay_bat_dau_lam], [ngay_thoi_viec], [ma_chuc_vu], [ma_nguoi_quan_ly], [ma_trang_thai_nhan_vien]) VALUES (N'N00010', N'Trương Thế Bảo', N'HinhAnh\AnhDaiDien\AnhDaiDienNamMacDinh.png', NULL, 1, N'Một Nơi Nào Đó', N'04           ', NULL, NULL, N'CV002', N'QL0001', 1)
INSERT [dbo].[NhanVien] ([ma_nhan_vien], [ho_ten], [anh_nhan_vien], [ngay_sinh], [gioi_tinh], [dia_chi], [so_dien_thoai], [ngay_bat_dau_lam], [ngay_thoi_viec], [ma_chuc_vu], [ma_nguoi_quan_ly], [ma_trang_thai_nhan_vien]) VALUES (N'N00011', N'Lương Mạnh Hải', N'HinhAnh\AnhDaiDien\AnhDaiDienNamMacDinh.png', NULL, 1, N'Một Nơi Nào Đó', N'05           ', NULL, NULL, N'CV002', N'QL0001', 1)
INSERT [dbo].[NhanVien] ([ma_nhan_vien], [ho_ten], [anh_nhan_vien], [ngay_sinh], [gioi_tinh], [dia_chi], [so_dien_thoai], [ngay_bat_dau_lam], [ngay_thoi_viec], [ma_chuc_vu], [ma_nguoi_quan_ly], [ma_trang_thai_nhan_vien]) VALUES (N'N00012', N'Phạm Hoàng Nam', N'HinhAnh\AnhDaiDien\AnhDaiDienNamMacDinh.png', NULL, 1, N'Một Nơi Nào Đó', N'06           ', NULL, NULL, N'CV002', N'QL0001', 1)
INSERT [dbo].[NhanVien] ([ma_nhan_vien], [ho_ten], [anh_nhan_vien], [ngay_sinh], [gioi_tinh], [dia_chi], [so_dien_thoai], [ngay_bat_dau_lam], [ngay_thoi_viec], [ma_chuc_vu], [ma_nguoi_quan_ly], [ma_trang_thai_nhan_vien]) VALUES (N'N00013', N'Tăng Thanh Hà', N'HinhAnh\AnhDaiDien\AnhDaiDienNuMacDinh.png', CAST(0x0000A82500000000 AS DateTime), 0, N'Một Nơi Nào Đó sad', N'1111111111   ', CAST(0x0000A82500000000 AS DateTime), NULL, N'CV002', N'QL0001', 1)
INSERT [dbo].[NhanVien] ([ma_nhan_vien], [ho_ten], [anh_nhan_vien], [ngay_sinh], [gioi_tinh], [dia_chi], [so_dien_thoai], [ngay_bat_dau_lam], [ngay_thoi_viec], [ma_chuc_vu], [ma_nguoi_quan_ly], [ma_trang_thai_nhan_vien]) VALUES (N'N00014', N'Nguyễn Thùy Chi', N'HinhAnh\AnhDaiDien\no-image.jpg', NULL, 0, N'Một Nơi Nào Đó', N'08           ', NULL, NULL, N'CV002', N'QL0001', 1)
INSERT [dbo].[NhanVien] ([ma_nhan_vien], [ho_ten], [anh_nhan_vien], [ngay_sinh], [gioi_tinh], [dia_chi], [so_dien_thoai], [ngay_bat_dau_lam], [ngay_thoi_viec], [ma_chuc_vu], [ma_nguoi_quan_ly], [ma_trang_thai_nhan_vien]) VALUES (N'N00015', N'Mai Phương Thúy', N'HinhAnh\AnhDaiDien\AnhDaiDienNuMacDinh.png', NULL, 0, N'Một Nơi Nào Đó', N'09           ', NULL, NULL, N'CV002', N'QL0001', 1)
INSERT [dbo].[NhanVien] ([ma_nhan_vien], [ho_ten], [anh_nhan_vien], [ngay_sinh], [gioi_tinh], [dia_chi], [so_dien_thoai], [ngay_bat_dau_lam], [ngay_thoi_viec], [ma_chuc_vu], [ma_nguoi_quan_ly], [ma_trang_thai_nhan_vien]) VALUES (N'N00016', N'Võ Ngọc Trai', N'HinhAnh\AnhDaiDien\20171119073042g9.gif', CAST(0x00008BA700000000 AS DateTime), 1, N'', N'             ', CAST(0x0000A83000000000 AS DateTime), NULL, N'CV002', N'QL0001', 1)
INSERT [dbo].[NhanVien] ([ma_nhan_vien], [ho_ten], [anh_nhan_vien], [ngay_sinh], [gioi_tinh], [dia_chi], [so_dien_thoai], [ngay_bat_dau_lam], [ngay_thoi_viec], [ma_chuc_vu], [ma_nguoi_quan_ly], [ma_trang_thai_nhan_vien]) VALUES (N'N00017', N'Lê Văn Khôi', N'HinhAnh\AnhDaiDien\no-image.jpg', NULL, 1, N'Một Nơi Nào Đó', N'11           ', NULL, NULL, N'CV002', N'QL0001', 1)
INSERT [dbo].[NhanVien] ([ma_nhan_vien], [ho_ten], [anh_nhan_vien], [ngay_sinh], [gioi_tinh], [dia_chi], [so_dien_thoai], [ngay_bat_dau_lam], [ngay_thoi_viec], [ma_chuc_vu], [ma_nguoi_quan_ly], [ma_trang_thai_nhan_vien]) VALUES (N'N00018', N'Bùi Quang Dũng', N'HinhAnh\AnhDaiDien\AnhDaiDienNamMacDinh.png', CAST(0x0000819F00000000 AS DateTime), 1, N'Một Nơi Nào Đó Ở Trái Đất (ABC)', N'123123123123 ', CAST(0x0000A82500000000 AS DateTime), NULL, N'CV002', N'QL0001', 1)
INSERT [dbo].[NhanVien] ([ma_nhan_vien], [ho_ten], [anh_nhan_vien], [ngay_sinh], [gioi_tinh], [dia_chi], [so_dien_thoai], [ngay_bat_dau_lam], [ngay_thoi_viec], [ma_chuc_vu], [ma_nguoi_quan_ly], [ma_trang_thai_nhan_vien]) VALUES (N'N00019', N'Ngô Tiến Đoàn', N'HinhAnh\AnhDaiDien\AnhDaiDienNamMacDinh.png', NULL, 1, N'Một Nơi Nào Đó', N'13           ', NULL, NULL, N'CV002', N'QL0001', 1)
INSERT [dbo].[NhanVien] ([ma_nhan_vien], [ho_ten], [anh_nhan_vien], [ngay_sinh], [gioi_tinh], [dia_chi], [so_dien_thoai], [ngay_bat_dau_lam], [ngay_thoi_viec], [ma_chuc_vu], [ma_nguoi_quan_ly], [ma_trang_thai_nhan_vien]) VALUES (N'N00020', N'Hoàng Anh Tuấn', N'HinhAnh\AnhDaiDien\AnhDaiDienNamMacDinh.png', NULL, 1, N'Một Nơi Nào Đó', N'14           ', NULL, NULL, N'CV002', N'QL0001', 1)
INSERT [dbo].[NhanVien] ([ma_nhan_vien], [ho_ten], [anh_nhan_vien], [ngay_sinh], [gioi_tinh], [dia_chi], [so_dien_thoai], [ngay_bat_dau_lam], [ngay_thoi_viec], [ma_chuc_vu], [ma_nguoi_quan_ly], [ma_trang_thai_nhan_vien]) VALUES (N'N00021', N'Đặng Thu Thảo', N'HinhAnh\AnhDaiDien\no-image.jpg', NULL, 0, N'Một Nơi Nào Đó', N'15           ', NULL, NULL, N'CV002', N'QL0001', 1)
INSERT [dbo].[NhanVien] ([ma_nhan_vien], [ho_ten], [anh_nhan_vien], [ngay_sinh], [gioi_tinh], [dia_chi], [so_dien_thoai], [ngay_bat_dau_lam], [ngay_thoi_viec], [ma_chuc_vu], [ma_nguoi_quan_ly], [ma_trang_thai_nhan_vien]) VALUES (N'N00022', N'Đỗ Thị Quản Lý', N'HinhAnh\AnhDaiDien\636443036231416773-flying-superman.gif', CAST(0x000085D400000000 AS DateTime), 0, N'Hồ Chí Minh', N'0909082716   ', CAST(0x0000A6EC00000000 AS DateTime), NULL, N'CV001', N'QL0001', 1)
INSERT [dbo].[NhanVien] ([ma_nhan_vien], [ho_ten], [anh_nhan_vien], [ngay_sinh], [gioi_tinh], [dia_chi], [so_dien_thoai], [ngay_bat_dau_lam], [ngay_thoi_viec], [ma_chuc_vu], [ma_nguoi_quan_ly], [ma_trang_thai_nhan_vien]) VALUES (N'N00023', N'Giant Hulk', N'HinhAnh\AnhDaiDien\20171112023033hulk1.gif', CAST(0x0000904600000000 AS DateTime), 0, N'hahahahahahahaha', N'1111111111   ', CAST(0x0000A82A00000000 AS DateTime), NULL, N'CV001', NULL, 3)
INSERT [dbo].[NhanVien] ([ma_nhan_vien], [ho_ten], [anh_nhan_vien], [ngay_sinh], [gioi_tinh], [dia_chi], [so_dien_thoai], [ngay_bat_dau_lam], [ngay_thoi_viec], [ma_chuc_vu], [ma_nguoi_quan_ly], [ma_trang_thai_nhan_vien]) VALUES (N'N00024', N'Flash', N'HinhAnh\AnhDaiDien\20171111092138flash.gif', CAST(0x000090400099E670 AS DateTime), 1, N'I live in START LAB', N'123123123123 ', CAST(0x0000A8290099E670 AS DateTime), NULL, N'CV002', NULL, 1)
INSERT [dbo].[NhanVien] ([ma_nhan_vien], [ho_ten], [anh_nhan_vien], [ngay_sinh], [gioi_tinh], [dia_chi], [so_dien_thoai], [ngay_bat_dau_lam], [ngay_thoi_viec], [ma_chuc_vu], [ma_nguoi_quan_ly], [ma_trang_thai_nhan_vien]) VALUES (N'N00025', N'BatMan NV', N'HinhAnh\AnhDaiDien\20171112033942bat.gif', CAST(0x0000825400000000 AS DateTime), 1, N'I live in Gotham', N'123123123123 ', CAST(0x0000A82E00000000 AS DateTime), CAST(0x0000A83600000000 AS DateTime), N'CV002', NULL, 3)
INSERT [dbo].[NhanVien] ([ma_nhan_vien], [ho_ten], [anh_nhan_vien], [ngay_sinh], [gioi_tinh], [dia_chi], [so_dien_thoai], [ngay_bat_dau_lam], [ngay_thoi_viec], [ma_chuc_vu], [ma_nguoi_quan_ly], [ma_trang_thai_nhan_vien]) VALUES (N'N00026', N'Captain', N'HinhAnh\AnhDaiDien\20171112104309caption-america-1.gif', CAST(0x00008BA000000000 AS DateTime), 1, N'I live in The US', N'123123123123 ', CAST(0x0000A82900000000 AS DateTime), NULL, N'CV002', NULL, 1)
INSERT [dbo].[NhanVien] ([ma_nhan_vien], [ho_ten], [anh_nhan_vien], [ngay_sinh], [gioi_tinh], [dia_chi], [so_dien_thoai], [ngay_bat_dau_lam], [ngay_thoi_viec], [ma_chuc_vu], [ma_nguoi_quan_ly], [ma_trang_thai_nhan_vien]) VALUES (N'N00027', N'Thor Odinsonnn', N'HinhAnh\AnhDaiDien\20171118211222thor1.gif', CAST(0x000092C8015CB13C AS DateTime), 1, N'I live on Asgard', N'1231231234   ', CAST(0x0000A82F015CB21E AS DateTime), NULL, N'CV001', NULL, 4)
INSERT [dbo].[NhanVien] ([ma_nhan_vien], [ho_ten], [anh_nhan_vien], [ngay_sinh], [gioi_tinh], [dia_chi], [so_dien_thoai], [ngay_bat_dau_lam], [ngay_thoi_viec], [ma_chuc_vu], [ma_nguoi_quan_ly], [ma_trang_thai_nhan_vien]) VALUES (N'N00028', N'Nô name Nô name', N'HinhAnh\AnhDaiDien\20171119165337john_walk_cycle.gif', CAST(0x000092C900000000 AS DateTime), 1, N'', N'             ', CAST(0x0000A83000000000 AS DateTime), NULL, N'CV002', NULL, 4)
INSERT [dbo].[NhanVien] ([ma_nhan_vien], [ho_ten], [anh_nhan_vien], [ngay_sinh], [gioi_tinh], [dia_chi], [so_dien_thoai], [ngay_bat_dau_lam], [ngay_thoi_viec], [ma_chuc_vu], [ma_nguoi_quan_ly], [ma_trang_thai_nhan_vien]) VALUES (N'N00029', N'Nô name', N'HinhAnh\AnhDaiDien\no-image.jpg', CAST(0x00008BA7011761E0 AS DateTime), 1, N'', N'             ', CAST(0x0000A8300117621C AS DateTime), NULL, N'CV002', NULL, 4)
INSERT [dbo].[NhanVien] ([ma_nhan_vien], [ho_ten], [anh_nhan_vien], [ngay_sinh], [gioi_tinh], [dia_chi], [so_dien_thoai], [ngay_bat_dau_lam], [ngay_thoi_viec], [ma_chuc_vu], [ma_nguoi_quan_ly], [ma_trang_thai_nhan_vien]) VALUES (N'N00030', N'Nô name nô', N'HinhAnh\AnhDaiDien\no-image.jpg', CAST(0x00008BA701196580 AS DateTime), 1, N'', N'             ', CAST(0x0000A830011965EA AS DateTime), NULL, N'CV002', NULL, 4)
INSERT [dbo].[NhanVien] ([ma_nhan_vien], [ho_ten], [anh_nhan_vien], [ngay_sinh], [gioi_tinh], [dia_chi], [so_dien_thoai], [ngay_bat_dau_lam], [ngay_thoi_viec], [ma_chuc_vu], [ma_nguoi_quan_ly], [ma_trang_thai_nhan_vien]) VALUES (N'N00031', N'Hahaha', N'HinhAnh\AnhDaiDien\no-image.jpg', CAST(0xFFFFFCFB01196580 AS DateTime), 1, N'', N'             ', CAST(0x0000A830011965EA AS DateTime), NULL, N'CV002', NULL, 4)
/****** Object:  Table [dbo].[NguyenLieu]    Script Date: 11/30/2017 17:34:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NguyenLieu](
	[ma_nguyen_lieu] [char](10) NOT NULL,
	[anh_nguyen_lieu] [varchar](150) NULL,
	[ten_nguyen_lieu] [nvarchar](50) NOT NULL,
	[tong_so_luong] [float] NOT NULL,
	[don_vi_tinh] [nvarchar](10) NULL,
	[don_gia] [float] NULL,
	[ma_loai_nguyen_lieu] [char](6) NOT NULL,
	[trang_thai] [bit] NOT NULL,
 CONSTRAINT [PK_NguyenLieu] PRIMARY KEY CLUSTERED 
(
	[ma_nguyen_lieu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[NguyenLieu] ([ma_nguyen_lieu], [anh_nguyen_lieu], [ten_nguyen_lieu], [tong_so_luong], [don_vi_tinh], [don_gia], [ma_loai_nguyen_lieu], [trang_thai]) VALUES (N'NL0001    ', N'', N'Thạch trân châu', 60, N'DVT10', 3000, N'LNL001', 1)
INSERT [dbo].[NguyenLieu] ([ma_nguyen_lieu], [anh_nguyen_lieu], [ten_nguyen_lieu], [tong_so_luong], [don_vi_tinh], [don_gia], [ma_loai_nguyen_lieu], [trang_thai]) VALUES (N'NL0002    ', N'', N'Thạch Sanh', 115, N'DVT10', 15000, N'LNL003', 1)
INSERT [dbo].[NguyenLieu] ([ma_nguyen_lieu], [anh_nguyen_lieu], [ten_nguyen_lieu], [tong_so_luong], [don_vi_tinh], [don_gia], [ma_loai_nguyen_lieu], [trang_thai]) VALUES (N'NL0003    ', N'', N'Thach Pho Mai', 28, N'DVT05', 15000, N'LNL001', 1)
INSERT [dbo].[NguyenLieu] ([ma_nguyen_lieu], [anh_nguyen_lieu], [ten_nguyen_lieu], [tong_so_luong], [don_vi_tinh], [don_gia], [ma_loai_nguyen_lieu], [trang_thai]) VALUES (N'NL0004    ', N'', N'Lý thông', 14, N'DVT01', 15000, N'LNL001', 1)
/****** Object:  Table [dbo].[ChiTietChucNang]    Script Date: 11/30/2017 17:34:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietChucNang](
	[ma_chuc_nang] [char](6) NOT NULL,
	[ma_chuc_vu] [char](5) NOT NULL,
	[trang_thai] [bit] NOT NULL,
 CONSTRAINT [PK_ChiTietChucNang] PRIMARY KEY CLUSTERED 
(
	[ma_chuc_nang] ASC,
	[ma_chuc_vu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ChiTietChucNang] ([ma_chuc_nang], [ma_chuc_vu], [trang_thai]) VALUES (N'CN0001', N'CV001', 1)
INSERT [dbo].[ChiTietChucNang] ([ma_chuc_nang], [ma_chuc_vu], [trang_thai]) VALUES (N'CN0001', N'CV003', 1)
INSERT [dbo].[ChiTietChucNang] ([ma_chuc_nang], [ma_chuc_vu], [trang_thai]) VALUES (N'CN0002', N'CV001', 1)
INSERT [dbo].[ChiTietChucNang] ([ma_chuc_nang], [ma_chuc_vu], [trang_thai]) VALUES (N'CN0002', N'CV003', 1)
INSERT [dbo].[ChiTietChucNang] ([ma_chuc_nang], [ma_chuc_vu], [trang_thai]) VALUES (N'CN0003', N'CV001', 1)
INSERT [dbo].[ChiTietChucNang] ([ma_chuc_nang], [ma_chuc_vu], [trang_thai]) VALUES (N'CN0003', N'CV003', 1)
INSERT [dbo].[ChiTietChucNang] ([ma_chuc_nang], [ma_chuc_vu], [trang_thai]) VALUES (N'CN0004', N'CV001', 0)
INSERT [dbo].[ChiTietChucNang] ([ma_chuc_nang], [ma_chuc_vu], [trang_thai]) VALUES (N'CN0004', N'CV003', 1)
INSERT [dbo].[ChiTietChucNang] ([ma_chuc_nang], [ma_chuc_vu], [trang_thai]) VALUES (N'CN0006', N'CV001', 1)
INSERT [dbo].[ChiTietChucNang] ([ma_chuc_nang], [ma_chuc_vu], [trang_thai]) VALUES (N'CN0006', N'CV003', 1)
INSERT [dbo].[ChiTietChucNang] ([ma_chuc_nang], [ma_chuc_vu], [trang_thai]) VALUES (N'CN0007', N'CV001', 1)
INSERT [dbo].[ChiTietChucNang] ([ma_chuc_nang], [ma_chuc_vu], [trang_thai]) VALUES (N'CN0007', N'CV003', 1)
INSERT [dbo].[ChiTietChucNang] ([ma_chuc_nang], [ma_chuc_vu], [trang_thai]) VALUES (N'CN0008', N'CV001', 1)
INSERT [dbo].[ChiTietChucNang] ([ma_chuc_nang], [ma_chuc_vu], [trang_thai]) VALUES (N'CN0008', N'CV002', 1)
INSERT [dbo].[ChiTietChucNang] ([ma_chuc_nang], [ma_chuc_vu], [trang_thai]) VALUES (N'CN0008', N'CV003', 1)
INSERT [dbo].[ChiTietChucNang] ([ma_chuc_nang], [ma_chuc_vu], [trang_thai]) VALUES (N'CN0009', N'CV002', 1)
INSERT [dbo].[ChiTietChucNang] ([ma_chuc_nang], [ma_chuc_vu], [trang_thai]) VALUES (N'CN0010', N'CV001', 1)
INSERT [dbo].[ChiTietChucNang] ([ma_chuc_nang], [ma_chuc_vu], [trang_thai]) VALUES (N'CN0010', N'CV002', 1)
INSERT [dbo].[ChiTietChucNang] ([ma_chuc_nang], [ma_chuc_vu], [trang_thai]) VALUES (N'CN0010', N'CV003', 1)
INSERT [dbo].[ChiTietChucNang] ([ma_chuc_nang], [ma_chuc_vu], [trang_thai]) VALUES (N'CN0011', N'CV001', 1)
INSERT [dbo].[ChiTietChucNang] ([ma_chuc_nang], [ma_chuc_vu], [trang_thai]) VALUES (N'CN0011', N'CV003', 1)
INSERT [dbo].[ChiTietChucNang] ([ma_chuc_nang], [ma_chuc_vu], [trang_thai]) VALUES (N'CN0012', N'CV001', 1)
INSERT [dbo].[ChiTietChucNang] ([ma_chuc_nang], [ma_chuc_vu], [trang_thai]) VALUES (N'CN0012', N'CV003', 1)
INSERT [dbo].[ChiTietChucNang] ([ma_chuc_nang], [ma_chuc_vu], [trang_thai]) VALUES (N'CN0013', N'CV001', 1)
INSERT [dbo].[ChiTietChucNang] ([ma_chuc_nang], [ma_chuc_vu], [trang_thai]) VALUES (N'CN0013', N'CV003', 1)
INSERT [dbo].[ChiTietChucNang] ([ma_chuc_nang], [ma_chuc_vu], [trang_thai]) VALUES (N'CN0014', N'CV003', 1)
/****** Object:  Table [dbo].[LoaiMonAn]    Script Date: 11/30/2017 17:34:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoaiMonAn](
	[ma_loai_mon_an] [char](6) NOT NULL,
	[ma_nhom_mon_an] [char](5) NOT NULL,
	[ten_loai_mon_an] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_LoaiMonAn] PRIMARY KEY CLUSTERED 
(
	[ma_loai_mon_an] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ca fe, nươc suối, nước ngọt' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LoaiMonAn', @level2type=N'COLUMN',@level2name=N'ten_loai_mon_an'
GO
INSERT [dbo].[LoaiMonAn] ([ma_loai_mon_an], [ma_nhom_mon_an], [ten_loai_mon_an]) VALUES (N'LMA001', N'NMA02', N'Trà')
INSERT [dbo].[LoaiMonAn] ([ma_loai_mon_an], [ma_nhom_mon_an], [ten_loai_mon_an]) VALUES (N'LMA002', N'NMA02', N'Trà sữa')
INSERT [dbo].[LoaiMonAn] ([ma_loai_mon_an], [ma_nhom_mon_an], [ten_loai_mon_an]) VALUES (N'LMA003', N'NMA02', N'Trà trái cây')
INSERT [dbo].[LoaiMonAn] ([ma_loai_mon_an], [ma_nhom_mon_an], [ten_loai_mon_an]) VALUES (N'LMA004', N'NMA01', N'Xiên que')
INSERT [dbo].[LoaiMonAn] ([ma_loai_mon_an], [ma_nhom_mon_an], [ten_loai_mon_an]) VALUES (N'LMA005', N'NMA01', N'Khoai tây chiên')
INSERT [dbo].[LoaiMonAn] ([ma_loai_mon_an], [ma_nhom_mon_an], [ten_loai_mon_an]) VALUES (N'LMA006', N'NMA02', N'Nước ngọt')
INSERT [dbo].[LoaiMonAn] ([ma_loai_mon_an], [ma_nhom_mon_an], [ten_loai_mon_an]) VALUES (N'LMA007', N'NMA03', N'Topping')
INSERT [dbo].[LoaiMonAn] ([ma_loai_mon_an], [ma_nhom_mon_an], [ten_loai_mon_an]) VALUES (N'LMA008', N'NMA02', N'Kem')
/****** Object:  Table [dbo].[HoaDonNhap]    Script Date: 11/30/2017 17:34:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDonNhap](
	[ma_hoa_don_nhap] [char](10) NOT NULL,
	[ma_nhan_vien] [char](6) NOT NULL,
	[ngay_tao_hoa_don] [datetime] NULL,
	[tong_tien_phai_tra] [float] NOT NULL,
	[trang_thai] [bit] NOT NULL,
 CONSTRAINT [PK_HoaDonNhap] PRIMARY KEY CLUSTERED 
(
	[ma_hoa_don_nhap] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HoaDonBan]    Script Date: 11/30/2017 17:34:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDonBan](
	[ma_hoa_don_ban] [char](10) NOT NULL,
	[ma_nhan_vien] [char](6) NOT NULL,
	[ngay_lap_hoa_don] [datetime] NOT NULL,
	[tong_tien] [float] NOT NULL,
	[tien_dua] [float] NOT NULL,
	[tien_thoi] [float] NOT NULL,
	[VAT] [float] NULL,
	[giao_hang] [bit] NOT NULL,
	[ma_khach_hang] [char](6) NULL,
	[trang_thai] [bit] NOT NULL,
 CONSTRAINT [PK_HoaDonBanHang] PRIMARY KEY CLUSTERED 
(
	[ma_hoa_don_ban] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000001', N'N00009', CAST(0x0000A83100A3479C AS DateTime), 25000, 144000, 119000, NULL, 1, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000002', N'N00009', CAST(0x0000A83100A688D0 AS DateTime), 150000, 5000000, 4850000, NULL, 0, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000003', N'N00009', CAST(0x0000A83100AB435C AS DateTime), 100000, 3000000, 2900000, NULL, 0, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000004', N'N00009', CAST(0x0000A83100AD8194 AS DateTime), 100000, 2222000, 2122000, NULL, 0, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000005', N'N00009', CAST(0x0000A83100AE1D70 AS DateTime), 50000, 123000, 73000, NULL, 0, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000006', N'N00009', CAST(0x0000A83100AE5100 AS DateTime), 75000, 2222000, 2147000, NULL, 0, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000007', N'N00009', CAST(0x0000A83100AEDB48 AS DateTime), 25000, 222000, 197000, NULL, 1, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000008', N'N00009', CAST(0x0000A83100B0C9D0 AS DateTime), 25000, 111000, 86000, NULL, 0, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000009', N'N00009', CAST(0x0000A83100B15D78 AS DateTime), 25000, 1111000, 1086000, NULL, 0, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000010', N'N00009', CAST(0x0000A83100B2005C AS DateTime), 84000, 2313000, 2229000, NULL, 1, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000011', N'N00009', CAST(0x0000A83100B5FD10 AS DateTime), 75000, 100000, 25000, 7500, 1, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000012', N'N00009', CAST(0x0000A83100B62D1C AS DateTime), 50000, 322000, 272000, 5000, 1, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000013', N'N00009', CAST(0x0000A83100B6AE04 AS DateTime), 118000, 150000, 32000, 11800, 1, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000014', N'N00009', CAST(0x0000A83100BA219C AS DateTime), 125000, 1231000, 1106000, 12500, 1, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000015', N'N00009', CAST(0x0000A83100BA52D4 AS DateTime), 25000, 111000, 86000, 2500, 1, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000016', N'N00009', CAST(0x0000A83100C38E80 AS DateTime), 25000, 111000, 86000, 2500, 1, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000017', N'N00009', CAST(0x0000A83100C4386C AS DateTime), 25000, 1111000, 1086000, 2500, 1, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000018', N'N00009', CAST(0x0000A83100C4B828 AS DateTime), 50000, 111000, 61000, 5000, 1, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000019', N'N00009', CAST(0x0000A83100C4EF3C AS DateTime), 100000, 4234000, 4134000, 10000, 1, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000020', N'N00009', CAST(0x0000A83100C51CF0 AS DateTime), 25000, 111000, 86000, 2500, 1, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000021', N'N00009', CAST(0x0000A83100C5C100 AS DateTime), 75000, 1111000, 1036000, 7500, 1, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000022', N'N00009', CAST(0x0000A83100C611DC AS DateTime), 50000, 222000, 172000, 5000, 1, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000023', N'N00009', CAST(0x0000A83100C63888 AS DateTime), 25000, 111000, 86000, 2500, 1, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000024', N'N00009', CAST(0x0000A83100C6F408 AS DateTime), 100000, 3123000, 3023000, 10000, 1, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000025', N'N00009', CAST(0x0000A83100C7680C AS DateTime), 50000, 34234000, 34184000, 5000, 1, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000026', N'N00009', CAST(0x0000A83100C7B1E0 AS DateTime), 75000, 77000, 2000, 7500, 1, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000027', N'N00009', CAST(0x0000A83100C7CF2C AS DateTime), 50000, 88000, 38000, 5000, 1, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000028', N'N00009', CAST(0x0000A83100C7EDA4 AS DateTime), 25000, 99000, 74000, 2500, 1, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000029', N'N00009', CAST(0x0000A83100C8A474 AS DateTime), 2250000, 9999000, 7749000, 225000, 1, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000030', N'N00009', CAST(0x0000A83100CA16C4 AS DateTime), 75000, 999000, 924000, 7500, 1, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000031', N'N00009', CAST(0x0000A83100CED150 AS DateTime), 115000, 555000, 440000, 11500, 1, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000032', N'N00009', CAST(0x0000A83100CF9054 AS DateTime), 60000, 111000, 51000, 6000, 1, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000033', N'N00009', CAST(0x0000A83100D28FE8 AS DateTime), 80000, 100000, 20000, 8000, 1, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000034', N'N00009', CAST(0x0000A83100D31B5C AS DateTime), 151000, 200000, 49000, 15100, 1, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000035', N'N00009', CAST(0x0000A8310016D8D4 AS DateTime), 271000, 1500000, 1229000, 27100, 1, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000036', N'N00009', CAST(0x0000A83100199B78 AS DateTime), 95000, 100000, 5000, 9500, 1, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000037', N'N00009', CAST(0x0000A831001C9C38 AS DateTime), 45000, 111000, 66000, 4500, 1, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000038', N'N00009', CAST(0x0000A831002576A0 AS DateTime), 164000, 1232000, 1068000, 16400, 1, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000039', N'N00009', CAST(0x0000A832001D4E58 AS DateTime), 134000, 155000, 21000, 13400, 1, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000040', N'N00009', CAST(0x0000A832001F971C AS DateTime), 15000, 111000, 96000, 1500, 1, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000041', N'N00009', CAST(0x0000A83200201CB4 AS DateTime), 45000, 100000, 55000, 4500, 1, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000042', N'N00009', CAST(0x0000A8320020DF3C AS DateTime), 45000, 100000, 55000, 4500, 1, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000043', N'N00009', CAST(0x0000A83500CD50F0 AS DateTime), 60000, 150000, 90000, 6000, 1, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000044', N'N00009', CAST(0x0000A83500276B04 AS DateTime), 60000, 222000, 162000, 6000, 1, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000045', N'N00009', CAST(0x0000A8350028116C AS DateTime), 30000, 123000, 93000, 3000, 1, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000046', N'N00009', CAST(0x0000A8350032F1CC AS DateTime), 101000, 111000, 10000, 10100, 1, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000047', N'N00009', CAST(0x0000A83B00D0A28C AS DateTime), 60000, 111000, 51000, 6000, 1, N'!!!!! ', 1)
INSERT [dbo].[HoaDonBan] ([ma_hoa_don_ban], [ma_nhan_vien], [ngay_lap_hoa_don], [tong_tien], [tien_dua], [tien_thoi], [VAT], [giao_hang], [ma_khach_hang], [trang_thai]) VALUES (N'HDB0000048', N'N00009', CAST(0x0000A83B00D27044 AS DateTime), 15000, 20000, 5000, 1500, 1, N'!!!!! ', 1)
/****** Object:  Table [dbo].[BanPhanCong]    Script Date: 11/30/2017 17:34:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BanPhanCong](
	[ma_ban_phan_cong] [char](10) NOT NULL,
	[thoi_gian_bat_dau] [datetime] NULL,
	[thoi_gian_ket_thuc] [datetime] NULL,
	[ma_nhan_vien_tao] [char](6) NULL,
	[trang_thai] [bit] NULL,
 CONSTRAINT [PK_BangPhanCongCongViec] PRIMARY KEY CLUSTERED 
(
	[ma_ban_phan_cong] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ng quản lý cho cả tuần' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BanPhanCong', @level2type=N'COLUMN',@level2name=N'ma_nhan_vien_tao'
GO
INSERT [dbo].[BanPhanCong] ([ma_ban_phan_cong], [thoi_gian_bat_dau], [thoi_gian_ket_thuc], [ma_nhan_vien_tao], [trang_thai]) VALUES (N'BPC0000001', CAST(0x0000A82D00FF4AF9 AS DateTime), CAST(0x0000A83400FF4AF9 AS DateTime), N'N00022', 1)
INSERT [dbo].[BanPhanCong] ([ma_ban_phan_cong], [thoi_gian_bat_dau], [thoi_gian_ket_thuc], [ma_nhan_vien_tao], [trang_thai]) VALUES (N'BPC0000002', CAST(0x0000A82D010871C3 AS DateTime), CAST(0x0000A834010871C3 AS DateTime), N'N00022', 1)
/****** Object:  Table [dbo].[BanGhiLuongNhanVien]    Script Date: 11/30/2017 17:34:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BanGhiLuongNhanVien](
	[ma_ban_ghi] [char](6) NOT NULL,
	[ma_nhan_vien] [char](6) NOT NULL,
	[so_ca_lam] [int] NULL,
	[tong_tien_luong] [float] NOT NULL,
	[thoi_gian_nhan_luong] [datetime] NOT NULL,
	[ghi_chu] [nvarchar](250) NULL,
	[trang_thai] [nchar](10) NULL,
 CONSTRAINT [PK_LuongNhanVienTheoCa] PRIMARY KEY CLUSTERED 
(
	[ma_ban_ghi] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietBanPhanCong]    Script Date: 11/30/2017 17:34:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietBanPhanCong](
	[ma_ban_ghi] [char](10) NOT NULL,
	[ma_nhan_vien] [char](6) NULL,
	[ma_ca_lam_viec] [char](5) NULL,
	[ngay_lam_viec] [datetime] NULL,
	[nhan_vien_tao] [char](6) NULL,
	[ngay_them] [datetime] NULL,
	[co_mat] [bit] NULL,
	[nghi_co_phep] [bit] NULL,
	[trang_thai] [int] NULL,
 CONSTRAINT [PK_ChiTietBanPhanCong] PRIMARY KEY CLUSTERED 
(
	[ma_ban_ghi] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'true-false' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ChiTietBanPhanCong', @level2type=N'COLUMN',@level2name=N'co_mat'
GO
INSERT [dbo].[ChiTietBanPhanCong] ([ma_ban_ghi], [ma_nhan_vien], [ma_ca_lam_viec], [ngay_lam_viec], [nhan_vien_tao], [ngay_them], [co_mat], [nghi_co_phep], [trang_thai]) VALUES (N'CTBPC00001', N'N00004', N'Ca001', CAST(0x0000A82F00000000 AS DateTime), N'N00022', CAST(0x0000A82F00000000 AS DateTime), 0, 0, 3)
INSERT [dbo].[ChiTietBanPhanCong] ([ma_ban_ghi], [ma_nhan_vien], [ma_ca_lam_viec], [ngay_lam_viec], [nhan_vien_tao], [ngay_them], [co_mat], [nghi_co_phep], [trang_thai]) VALUES (N'CTBPC00002', N'N00004', N'Ca001', CAST(0x0000A83100000000 AS DateTime), N'N00022', CAST(0x0000A82F00000000 AS DateTime), 0, 0, 5)
INSERT [dbo].[ChiTietBanPhanCong] ([ma_ban_ghi], [ma_nhan_vien], [ma_ca_lam_viec], [ngay_lam_viec], [nhan_vien_tao], [ngay_them], [co_mat], [nghi_co_phep], [trang_thai]) VALUES (N'CTBPC00003', N'N00004', N'Ca002', CAST(0x0000A83000000000 AS DateTime), N'N00022', CAST(0x0000A82F00000000 AS DateTime), 0, 0, 5)
INSERT [dbo].[ChiTietBanPhanCong] ([ma_ban_ghi], [ma_nhan_vien], [ma_ca_lam_viec], [ngay_lam_viec], [nhan_vien_tao], [ngay_them], [co_mat], [nghi_co_phep], [trang_thai]) VALUES (N'CTBPC00004', N'N00004', N'Ca002', CAST(0x0000A83100000000 AS DateTime), N'N00022', CAST(0x0000A82F00000000 AS DateTime), 0, 0, 5)
INSERT [dbo].[ChiTietBanPhanCong] ([ma_ban_ghi], [ma_nhan_vien], [ma_ca_lam_viec], [ngay_lam_viec], [nhan_vien_tao], [ngay_them], [co_mat], [nghi_co_phep], [trang_thai]) VALUES (N'CTBPC00005', N'N00002', N'Ca001', CAST(0x0000A82F00000000 AS DateTime), N'N00022', CAST(0x0000A82F00000000 AS DateTime), 0, 0, 5)
INSERT [dbo].[ChiTietBanPhanCong] ([ma_ban_ghi], [ma_nhan_vien], [ma_ca_lam_viec], [ngay_lam_viec], [nhan_vien_tao], [ngay_them], [co_mat], [nghi_co_phep], [trang_thai]) VALUES (N'CTBPC00006', N'N00002', N'Ca001', CAST(0x0000A83100000000 AS DateTime), N'N00022', CAST(0x0000A82F00000000 AS DateTime), 0, 0, 1)
INSERT [dbo].[ChiTietBanPhanCong] ([ma_ban_ghi], [ma_nhan_vien], [ma_ca_lam_viec], [ngay_lam_viec], [nhan_vien_tao], [ngay_them], [co_mat], [nghi_co_phep], [trang_thai]) VALUES (N'CTBPC00007', N'N00002', N'Ca002', CAST(0x0000A83000000000 AS DateTime), N'N00022', CAST(0x0000A82F00000000 AS DateTime), 0, 0, 1)
INSERT [dbo].[ChiTietBanPhanCong] ([ma_ban_ghi], [ma_nhan_vien], [ma_ca_lam_viec], [ngay_lam_viec], [nhan_vien_tao], [ngay_them], [co_mat], [nghi_co_phep], [trang_thai]) VALUES (N'CTBPC00008', N'N00002', N'Ca002', CAST(0x0000A83100000000 AS DateTime), N'N00022', CAST(0x0000A82F00000000 AS DateTime), 0, 0, 4)
INSERT [dbo].[ChiTietBanPhanCong] ([ma_ban_ghi], [ma_nhan_vien], [ma_ca_lam_viec], [ngay_lam_viec], [nhan_vien_tao], [ngay_them], [co_mat], [nghi_co_phep], [trang_thai]) VALUES (N'CTBPC00009', N'N00005', N'Ca001', CAST(0x0000A82F00000000 AS DateTime), N'N00022', CAST(0x0000A82F00000000 AS DateTime), 0, 0, 2)
INSERT [dbo].[ChiTietBanPhanCong] ([ma_ban_ghi], [ma_nhan_vien], [ma_ca_lam_viec], [ngay_lam_viec], [nhan_vien_tao], [ngay_them], [co_mat], [nghi_co_phep], [trang_thai]) VALUES (N'CTBPC00010', N'N00005', N'Ca001', CAST(0x0000A83100000000 AS DateTime), N'N00022', CAST(0x0000A82F00000000 AS DateTime), 0, 0, 5)
INSERT [dbo].[ChiTietBanPhanCong] ([ma_ban_ghi], [ma_nhan_vien], [ma_ca_lam_viec], [ngay_lam_viec], [nhan_vien_tao], [ngay_them], [co_mat], [nghi_co_phep], [trang_thai]) VALUES (N'CTBPC00011', N'N00005', N'Ca002', CAST(0x0000A83000000000 AS DateTime), N'N00022', CAST(0x0000A82F00000000 AS DateTime), 0, 0, 5)
INSERT [dbo].[ChiTietBanPhanCong] ([ma_ban_ghi], [ma_nhan_vien], [ma_ca_lam_viec], [ngay_lam_viec], [nhan_vien_tao], [ngay_them], [co_mat], [nghi_co_phep], [trang_thai]) VALUES (N'CTBPC00012', N'N00005', N'Ca002', CAST(0x0000A83100000000 AS DateTime), N'N00022', CAST(0x0000A82F00000000 AS DateTime), 0, 0, 5)
INSERT [dbo].[ChiTietBanPhanCong] ([ma_ban_ghi], [ma_nhan_vien], [ma_ca_lam_viec], [ngay_lam_viec], [nhan_vien_tao], [ngay_them], [co_mat], [nghi_co_phep], [trang_thai]) VALUES (N'CTBPC00013', N'N00012', N'Ca001', CAST(0x0000A84000000000 AS DateTime), N'N00022', CAST(0x0000A82F00000000 AS DateTime), 0, 0, 5)
INSERT [dbo].[ChiTietBanPhanCong] ([ma_ban_ghi], [ma_nhan_vien], [ma_ca_lam_viec], [ngay_lam_viec], [nhan_vien_tao], [ngay_them], [co_mat], [nghi_co_phep], [trang_thai]) VALUES (N'CTBPC00014', N'N00012', N'Ca002', CAST(0x0000A84100000000 AS DateTime), N'N00022', CAST(0x0000A82F00000000 AS DateTime), 0, 0, 5)
INSERT [dbo].[ChiTietBanPhanCong] ([ma_ban_ghi], [ma_nhan_vien], [ma_ca_lam_viec], [ngay_lam_viec], [nhan_vien_tao], [ngay_them], [co_mat], [nghi_co_phep], [trang_thai]) VALUES (N'CTBPC00015', N'N00006', N'Ca001', CAST(0x0000A84000000000 AS DateTime), N'N00022', CAST(0x0000A82F00000000 AS DateTime), 0, 0, 5)
INSERT [dbo].[ChiTietBanPhanCong] ([ma_ban_ghi], [ma_nhan_vien], [ma_ca_lam_viec], [ngay_lam_viec], [nhan_vien_tao], [ngay_them], [co_mat], [nghi_co_phep], [trang_thai]) VALUES (N'CTBPC00016', N'N00006', N'Ca002', CAST(0x0000A84100000000 AS DateTime), N'N00022', CAST(0x0000A82F00000000 AS DateTime), 0, 0, 5)
INSERT [dbo].[ChiTietBanPhanCong] ([ma_ban_ghi], [ma_nhan_vien], [ma_ca_lam_viec], [ngay_lam_viec], [nhan_vien_tao], [ngay_them], [co_mat], [nghi_co_phep], [trang_thai]) VALUES (N'CTBPC00017', N'N00008', N'Ca001', CAST(0x0000A83B00000000 AS DateTime), N'N00022', CAST(0x0000A83B00000000 AS DateTime), 0, 0, 5)
INSERT [dbo].[ChiTietBanPhanCong] ([ma_ban_ghi], [ma_nhan_vien], [ma_ca_lam_viec], [ngay_lam_viec], [nhan_vien_tao], [ngay_them], [co_mat], [nghi_co_phep], [trang_thai]) VALUES (N'CTBPC00018', N'N00008', N'Ca001', CAST(0x0000A83C00000000 AS DateTime), N'N00022', CAST(0x0000A83B00000000 AS DateTime), 0, 0, 5)
INSERT [dbo].[ChiTietBanPhanCong] ([ma_ban_ghi], [ma_nhan_vien], [ma_ca_lam_viec], [ngay_lam_viec], [nhan_vien_tao], [ngay_them], [co_mat], [nghi_co_phep], [trang_thai]) VALUES (N'CTBPC00019', N'N00008', N'Ca002', CAST(0x0000A83D00000000 AS DateTime), N'N00022', CAST(0x0000A83B00000000 AS DateTime), 0, 0, 1)
INSERT [dbo].[ChiTietBanPhanCong] ([ma_ban_ghi], [ma_nhan_vien], [ma_ca_lam_viec], [ngay_lam_viec], [nhan_vien_tao], [ngay_them], [co_mat], [nghi_co_phep], [trang_thai]) VALUES (N'CTBPC00020', N'N00008', N'Ca002', CAST(0x0000A83E00000000 AS DateTime), N'N00022', CAST(0x0000A83B00000000 AS DateTime), 0, 0, 5)
INSERT [dbo].[ChiTietBanPhanCong] ([ma_ban_ghi], [ma_nhan_vien], [ma_ca_lam_viec], [ngay_lam_viec], [nhan_vien_tao], [ngay_them], [co_mat], [nghi_co_phep], [trang_thai]) VALUES (N'CTBPC00021', N'N00006', N'Ca001', CAST(0x0000A83B00000000 AS DateTime), N'N00022', CAST(0x0000A83B00000000 AS DateTime), 0, 0, 5)
INSERT [dbo].[ChiTietBanPhanCong] ([ma_ban_ghi], [ma_nhan_vien], [ma_ca_lam_viec], [ngay_lam_viec], [nhan_vien_tao], [ngay_them], [co_mat], [nghi_co_phep], [trang_thai]) VALUES (N'CTBPC00022', N'N00006', N'Ca001', CAST(0x0000A83C00000000 AS DateTime), N'N00022', CAST(0x0000A83B00000000 AS DateTime), 0, 0, 5)
INSERT [dbo].[ChiTietBanPhanCong] ([ma_ban_ghi], [ma_nhan_vien], [ma_ca_lam_viec], [ngay_lam_viec], [nhan_vien_tao], [ngay_them], [co_mat], [nghi_co_phep], [trang_thai]) VALUES (N'CTBPC00023', N'N00006', N'Ca002', CAST(0x0000A83D00000000 AS DateTime), N'N00022', CAST(0x0000A83B00000000 AS DateTime), 0, 0, 5)
INSERT [dbo].[ChiTietBanPhanCong] ([ma_ban_ghi], [ma_nhan_vien], [ma_ca_lam_viec], [ngay_lam_viec], [nhan_vien_tao], [ngay_them], [co_mat], [nghi_co_phep], [trang_thai]) VALUES (N'CTBPC00024', N'N00006', N'Ca002', CAST(0x0000A83E00000000 AS DateTime), N'N00022', CAST(0x0000A83B00000000 AS DateTime), 0, 0, 5)
INSERT [dbo].[ChiTietBanPhanCong] ([ma_ban_ghi], [ma_nhan_vien], [ma_ca_lam_viec], [ngay_lam_viec], [nhan_vien_tao], [ngay_them], [co_mat], [nghi_co_phep], [trang_thai]) VALUES (N'CTBPC00025', N'N00008', N'Ca001', CAST(0x0000A83D00000000 AS DateTime), N'N00001', CAST(0x0000A83B00000000 AS DateTime), 0, 0, 5)
INSERT [dbo].[ChiTietBanPhanCong] ([ma_ban_ghi], [ma_nhan_vien], [ma_ca_lam_viec], [ngay_lam_viec], [nhan_vien_tao], [ngay_them], [co_mat], [nghi_co_phep], [trang_thai]) VALUES (N'CTBPC00026', N'N00008', N'Ca002', CAST(0x0000A83E00000000 AS DateTime), N'N00001', CAST(0x0000A83B00000000 AS DateTime), 0, 0, 5)
INSERT [dbo].[ChiTietBanPhanCong] ([ma_ban_ghi], [ma_nhan_vien], [ma_ca_lam_viec], [ngay_lam_viec], [nhan_vien_tao], [ngay_them], [co_mat], [nghi_co_phep], [trang_thai]) VALUES (N'CTBPC00027', N'N00004', N'Ca001', CAST(0x0000A83700000000 AS DateTime), N'N00022', CAST(0x0000A83B00000000 AS DateTime), 0, 0, 5)
INSERT [dbo].[ChiTietBanPhanCong] ([ma_ban_ghi], [ma_nhan_vien], [ma_ca_lam_viec], [ngay_lam_viec], [nhan_vien_tao], [ngay_them], [co_mat], [nghi_co_phep], [trang_thai]) VALUES (N'CTBPC00028', N'N00002', N'Ca001', CAST(0x0000A83700000000 AS DateTime), N'N00022', CAST(0x0000A83B00000000 AS DateTime), 0, 0, 5)
INSERT [dbo].[ChiTietBanPhanCong] ([ma_ban_ghi], [ma_nhan_vien], [ma_ca_lam_viec], [ngay_lam_viec], [nhan_vien_tao], [ngay_them], [co_mat], [nghi_co_phep], [trang_thai]) VALUES (N'CTBPC00029', N'N00006', N'Ca001', CAST(0x0000A83700000000 AS DateTime), N'N00022', CAST(0x0000A83B00000000 AS DateTime), 0, 0, 5)
INSERT [dbo].[ChiTietBanPhanCong] ([ma_ban_ghi], [ma_nhan_vien], [ma_ca_lam_viec], [ngay_lam_viec], [nhan_vien_tao], [ngay_them], [co_mat], [nghi_co_phep], [trang_thai]) VALUES (N'CTBPC00030', N'N00004', N'Ca001', CAST(0x0000A83700000000 AS DateTime), N'N00022', CAST(0x0000A83B00000000 AS DateTime), 0, 0, 5)
INSERT [dbo].[ChiTietBanPhanCong] ([ma_ban_ghi], [ma_nhan_vien], [ma_ca_lam_viec], [ngay_lam_viec], [nhan_vien_tao], [ngay_them], [co_mat], [nghi_co_phep], [trang_thai]) VALUES (N'CTBPC00031', N'N00002', N'Ca001', CAST(0x0000A83700000000 AS DateTime), N'N00022', CAST(0x0000A83B00000000 AS DateTime), 0, 0, 5)
INSERT [dbo].[ChiTietBanPhanCong] ([ma_ban_ghi], [ma_nhan_vien], [ma_ca_lam_viec], [ngay_lam_viec], [nhan_vien_tao], [ngay_them], [co_mat], [nghi_co_phep], [trang_thai]) VALUES (N'CTBPC00032', N'N00006', N'Ca001', CAST(0x0000A83700000000 AS DateTime), N'N00022', CAST(0x0000A83B00000000 AS DateTime), 0, 0, 5)
INSERT [dbo].[ChiTietBanPhanCong] ([ma_ban_ghi], [ma_nhan_vien], [ma_ca_lam_viec], [ngay_lam_viec], [nhan_vien_tao], [ngay_them], [co_mat], [nghi_co_phep], [trang_thai]) VALUES (N'CTBPC00033', N'N00004', N'Ca001', CAST(0x0000A83700000000 AS DateTime), N'N00022', CAST(0x0000A83B00000000 AS DateTime), 0, 0, 5)
INSERT [dbo].[ChiTietBanPhanCong] ([ma_ban_ghi], [ma_nhan_vien], [ma_ca_lam_viec], [ngay_lam_viec], [nhan_vien_tao], [ngay_them], [co_mat], [nghi_co_phep], [trang_thai]) VALUES (N'CTBPC00034', N'N00002', N'Ca001', CAST(0x0000A83700000000 AS DateTime), N'N00022', CAST(0x0000A83B00000000 AS DateTime), 0, 0, 5)
INSERT [dbo].[ChiTietBanPhanCong] ([ma_ban_ghi], [ma_nhan_vien], [ma_ca_lam_viec], [ngay_lam_viec], [nhan_vien_tao], [ngay_them], [co_mat], [nghi_co_phep], [trang_thai]) VALUES (N'CTBPC00035', N'N00006', N'Ca001', CAST(0x0000A83700000000 AS DateTime), N'N00022', CAST(0x0000A83B00000000 AS DateTime), 0, 0, 5)
INSERT [dbo].[ChiTietBanPhanCong] ([ma_ban_ghi], [ma_nhan_vien], [ma_ca_lam_viec], [ngay_lam_viec], [nhan_vien_tao], [ngay_them], [co_mat], [nghi_co_phep], [trang_thai]) VALUES (N'CTBPC00036', N'N00004', N'Ca001', CAST(0x0000A83700000000 AS DateTime), N'N00022', CAST(0x0000A83B00000000 AS DateTime), 0, 0, 5)
INSERT [dbo].[ChiTietBanPhanCong] ([ma_ban_ghi], [ma_nhan_vien], [ma_ca_lam_viec], [ngay_lam_viec], [nhan_vien_tao], [ngay_them], [co_mat], [nghi_co_phep], [trang_thai]) VALUES (N'CTBPC00037', N'N00002', N'Ca001', CAST(0x0000A83700000000 AS DateTime), N'N00022', CAST(0x0000A83B00000000 AS DateTime), 0, 0, 5)
INSERT [dbo].[ChiTietBanPhanCong] ([ma_ban_ghi], [ma_nhan_vien], [ma_ca_lam_viec], [ngay_lam_viec], [nhan_vien_tao], [ngay_them], [co_mat], [nghi_co_phep], [trang_thai]) VALUES (N'CTBPC00038', N'N00006', N'Ca001', CAST(0x0000A83700000000 AS DateTime), N'N00022', CAST(0x0000A83B00000000 AS DateTime), 0, 0, 5)
/****** Object:  Table [dbo].[ChiTietLoiViPham]    Script Date: 11/30/2017 17:34:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietLoiViPham](
	[ma_nhan_vien_vi_pham] [char](6) NOT NULL,
	[ma_loi_vi_pham] [char](10) NOT NULL,
	[thoi_gian] [datetime] NOT NULL,
	[ghi_chu] [nvarchar](200) NULL,
	[trang_thai] [bit] NOT NULL,
 CONSTRAINT [PK_ChiTietLoiViPham] PRIMARY KEY CLUSTERED 
(
	[ma_nhan_vien_vi_pham] ASC,
	[ma_loi_vi_pham] ASC,
	[thoi_gian] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MonAn]    Script Date: 11/30/2017 17:34:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MonAn](
	[ma_mon_an] [char](5) NOT NULL,
	[ten_mon_an] [nvarchar](50) NOT NULL,
	[anh_mon_an] [nvarchar](250) NULL,
	[ghi_chu] [nvarchar](300) NULL,
	[ma_loai_mon_an] [char](6) NOT NULL,
	[ma_don_vi_tinh] [char](5) NULL,
	[trang_thai] [bit] NOT NULL,
 CONSTRAINT [PK_MonAn] PRIMARY KEY CLUSTERED 
(
	[ma_mon_an] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[MonAn] ([ma_mon_an], [ten_mon_an], [anh_mon_an], [ghi_chu], [ma_loai_mon_an], [ma_don_vi_tinh], [trang_thai]) VALUES (N'M0001', N'Trà sữa thạch gì đó', N'HinhAnh\AnhMonAn\2017112013211020171112001954Trà-sữa-Trân-châu-Edited.png', N'Đang cập nhật', N'LMA002', N'DVT01', 1)
INSERT [dbo].[MonAn] ([ma_mon_an], [ten_mon_an], [anh_mon_an], [ghi_chu], [ma_loai_mon_an], [ma_don_vi_tinh], [trang_thai]) VALUES (N'M0002', N'Trà sữa sô cô la', N'HinhAnh\AnhMonAn\2017113012294820171111212928Hồng-trà-kem-sữa-奶蓋紅-S-min (2).png', N'Đang cập nhật', N'LMA001', N'DVT01', 1)
INSERT [dbo].[MonAn] ([ma_mon_an], [ten_mon_an], [anh_mon_an], [ghi_chu], [ma_loai_mon_an], [ma_don_vi_tinh], [trang_thai]) VALUES (N'M0003', N'Trà Đào Orion', N'HinhAnh\AnhMonAn\2017113012304720171112155825milk foam Black T..jpg', N'Đang cập nhật', N'LMA001', N'DVT01', 1)
INSERT [dbo].[MonAn] ([ma_mon_an], [ten_mon_an], [anh_mon_an], [ghi_chu], [ma_loai_mon_an], [ma_don_vi_tinh], [trang_thai]) VALUES (N'M0004', N'Trà xanh', N'HinhAnh\AnhMonAn\20171130123228sua-chua-oi-min-275x275.png', N'Đang cập nhật', N'LMA003', N'DVT01', 1)
INSERT [dbo].[MonAn] ([ma_mon_an], [ten_mon_an], [anh_mon_an], [ghi_chu], [ma_loai_mon_an], [ma_don_vi_tinh], [trang_thai]) VALUES (N'M0005', N'Matcha trà xanh', N'HinhAnh\AnhMonAn\20171130123318matcha-smoothie.png', N'Đang cập nhật', N'LMA001', N'DVT01', 1)
INSERT [dbo].[MonAn] ([ma_mon_an], [ten_mon_an], [anh_mon_an], [ghi_chu], [ma_loai_mon_an], [ma_don_vi_tinh], [trang_thai]) VALUES (N'M0006', N'Trà wiki-smoothy', N'HinhAnh\AnhMonAn\2017113012334720171112012031Kiwi-Smoothies (2).png', N'Đang cập nhật', N'LMA001', N'DVT01', 1)
INSERT [dbo].[MonAn] ([ma_mon_an], [ten_mon_an], [anh_mon_an], [ghi_chu], [ma_loai_mon_an], [ma_don_vi_tinh], [trang_thai]) VALUES (N'M0007', N'Kem sôcôla', N'HinhAnh\AnhMonAn\20171130123913201711120302284cc452d1955bd6e2d29c193814735f8c--chocolate-mousse-recipe-chocolate-treats (2).jpg', N'Đang cập nhật', N'LMA008', N'DVT01', 1)
INSERT [dbo].[MonAn] ([ma_mon_an], [ten_mon_an], [anh_mon_an], [ghi_chu], [ma_loai_mon_an], [ma_don_vi_tinh], [trang_thai]) VALUES (N'M0008', N'Khoai Tây', N'HinhAnh\AnhMonAn\2017113012552520171111210932thit-bo-xao (3).jpg', N'Đang cập nhật', N'LMA005', N'DVT01', 1)
INSERT [dbo].[MonAn] ([ma_mon_an], [ten_mon_an], [anh_mon_an], [ghi_chu], [ma_loai_mon_an], [ma_don_vi_tinh], [trang_thai]) VALUES (N'M0009', N'Topping loại 1', N'HinhAnh\AnhMonAn\2017113012570720171119003725Wonderbao-Messina-02.jpeg', N'Đang cập nhật', N'LMA007', N'DVT08', 1)
INSERT [dbo].[MonAn] ([ma_mon_an], [ten_mon_an], [anh_mon_an], [ghi_chu], [ma_loai_mon_an], [ma_don_vi_tinh], [trang_thai]) VALUES (N'M0010', N'Kem bơ xay', N'HinhAnh\AnhMonAn\2017113013044820171112155109ice-blended (3).png', N'Đang cập nhật', N'LMA008', N'DVT01', 1)
INSERT [dbo].[MonAn] ([ma_mon_an], [ten_mon_an], [anh_mon_an], [ghi_chu], [ma_loai_mon_an], [ma_don_vi_tinh], [trang_thai]) VALUES (N'M0011', N'Trà ô long mật ong', N'HinhAnh\AnhMonAn\2017113013054520171112170243olong-dao-mat-ong-min-275x275 (2).png', N'Đang cập nhật', N'LMA001', N'DVT01', 1)
INSERT [dbo].[MonAn] ([ma_mon_an], [ten_mon_an], [anh_mon_an], [ghi_chu], [ma_loai_mon_an], [ma_don_vi_tinh], [trang_thai]) VALUES (N'M0012', N'Kem đậu PHỤNG', N'HinhAnh\AnhMonAn\201711301308002017111201563906402d92e7c2b4a0c018d47a03c34e56--fast-food-icecream (2).jpg', N'Đang cập nhật', N'LMA008', N'DVT01', 1)
INSERT [dbo].[MonAn] ([ma_mon_an], [ten_mon_an], [anh_mon_an], [ghi_chu], [ma_loai_mon_an], [ma_don_vi_tinh], [trang_thai]) VALUES (N'M0013', N'Nước chanh dây', N'HinhAnh\AnhMonAn\20171130130904Chanh-dây-đá-xay百香冰沙無籽-L-min-3.png', N'Đang cập nhật', N'LMA006', N'DVT01', 1)
INSERT [dbo].[MonAn] ([ma_mon_an], [ten_mon_an], [anh_mon_an], [ghi_chu], [ma_loai_mon_an], [ma_don_vi_tinh], [trang_thai]) VALUES (N'M0014', N'Kem dâu đậu phụng', N'HinhAnh\AnhMonAn\2017113013104620171112173709Strawberrny-snowshake-2-logo-22 (3).png', N'Đang cập nhật', N'LMA008', N'DVT01', 1)
INSERT [dbo].[MonAn] ([ma_mon_an], [ten_mon_an], [anh_mon_an], [ghi_chu], [ma_loai_mon_an], [ma_don_vi_tinh], [trang_thai]) VALUES (N'M0015', N'Trà sữa thạch gì đó', N'HinhAnh\AnhMonAn\2017112013211020171112001954Trà-sữa-Trân-châu-Edited.png', N'Đang cập nhật', N'LMA002', N'DVT01', 1)
INSERT [dbo].[MonAn] ([ma_mon_an], [ten_mon_an], [anh_mon_an], [ghi_chu], [ma_loai_mon_an], [ma_don_vi_tinh], [trang_thai]) VALUES (N'M0016', N'Trà sữa thạch gì đó', N'HinhAnh\AnhMonAn\2017112013211020171112001954Trà-sữa-Trân-châu-Edited.png', N'Đang cập nhật', N'LMA002', N'DVT01', 1)
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 11/30/2017 17:34:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[ma_dang_nhap] [char](6) NOT NULL,
	[mat_khau] [char](20) NOT NULL,
	[ngay_tao] [datetime] NULL,
	[ma_quyen_dang_nhap] [char](6) NOT NULL,
	[ma_khan_cap] [char](6) NOT NULL,
	[trang_thai] [bit] NOT NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[ma_dang_nhap] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TaiKhoan', @level2type=N'COLUMN',@level2name=N'ma_quyen_dang_nhap'
GO
INSERT [dbo].[TaiKhoan] ([ma_dang_nhap], [mat_khau], [ngay_tao], [ma_quyen_dang_nhap], [ma_khan_cap], [trang_thai]) VALUES (N'N00001', N'123                 ', NULL, N'QDN004', N'123456', 1)
INSERT [dbo].[TaiKhoan] ([ma_dang_nhap], [mat_khau], [ngay_tao], [ma_quyen_dang_nhap], [ma_khan_cap], [trang_thai]) VALUES (N'N00002', N'nv123               ', NULL, N'QDN002', N'456789', 1)
INSERT [dbo].[TaiKhoan] ([ma_dang_nhap], [mat_khau], [ngay_tao], [ma_quyen_dang_nhap], [ma_khan_cap], [trang_thai]) VALUES (N'N00003', N'nv123               ', CAST(0x0000A78200000000 AS DateTime), N'QDN002', N'456789', 0)
INSERT [dbo].[TaiKhoan] ([ma_dang_nhap], [mat_khau], [ngay_tao], [ma_quyen_dang_nhap], [ma_khan_cap], [trang_thai]) VALUES (N'N00004', N'huy                 ', CAST(0x0000A7DF00000000 AS DateTime), N'QDN002', N'020997', 1)
INSERT [dbo].[TaiKhoan] ([ma_dang_nhap], [mat_khau], [ngay_tao], [ma_quyen_dang_nhap], [ma_khan_cap], [trang_thai]) VALUES (N'N00005', N'@Luan1              ', CAST(0x0000A7E500000000 AS DateTime), N'QDN002', N'140797', 1)
INSERT [dbo].[TaiKhoan] ([ma_dang_nhap], [mat_khau], [ngay_tao], [ma_quyen_dang_nhap], [ma_khan_cap], [trang_thai]) VALUES (N'N00006', N'maithanhquy         ', NULL, N'QDN002', N'696969', 1)
INSERT [dbo].[TaiKhoan] ([ma_dang_nhap], [mat_khau], [ngay_tao], [ma_quyen_dang_nhap], [ma_khan_cap], [trang_thai]) VALUES (N'N00007', N'thanhmai            ', CAST(0x0000A6EE00000000 AS DateTime), N'QDN002', N'198734', 1)
INSERT [dbo].[TaiKhoan] ([ma_dang_nhap], [mat_khau], [ngay_tao], [ma_quyen_dang_nhap], [ma_khan_cap], [trang_thai]) VALUES (N'N00008', N'lynhaky             ', NULL, N'QDN002', N'145234', 1)
INSERT [dbo].[TaiKhoan] ([ma_dang_nhap], [mat_khau], [ngay_tao], [ma_quyen_dang_nhap], [ma_khan_cap], [trang_thai]) VALUES (N'N00009', N'123                 ', NULL, N'QDN002', N'235637', 0)
INSERT [dbo].[TaiKhoan] ([ma_dang_nhap], [mat_khau], [ngay_tao], [ma_quyen_dang_nhap], [ma_khan_cap], [trang_thai]) VALUES (N'N00010', N'thebao              ', NULL, N'QDN002', N'999888', 1)
INSERT [dbo].[TaiKhoan] ([ma_dang_nhap], [mat_khau], [ngay_tao], [ma_quyen_dang_nhap], [ma_khan_cap], [trang_thai]) VALUES (N'N00011', N'lmhai               ', NULL, N'QDN002', N'122765', 1)
INSERT [dbo].[TaiKhoan] ([ma_dang_nhap], [mat_khau], [ngay_tao], [ma_quyen_dang_nhap], [ma_khan_cap], [trang_thai]) VALUES (N'N00012', N'hoangnam            ', NULL, N'QDN002', N'544333', 1)
INSERT [dbo].[TaiKhoan] ([ma_dang_nhap], [mat_khau], [ngay_tao], [ma_quyen_dang_nhap], [ma_khan_cap], [trang_thai]) VALUES (N'N00013', N'ttha                ', NULL, N'QDN002', N'726252', 1)
INSERT [dbo].[TaiKhoan] ([ma_dang_nhap], [mat_khau], [ngay_tao], [ma_quyen_dang_nhap], [ma_khan_cap], [trang_thai]) VALUES (N'N00014', N'chi123              ', NULL, N'QDN002', N'635666', 1)
INSERT [dbo].[TaiKhoan] ([ma_dang_nhap], [mat_khau], [ngay_tao], [ma_quyen_dang_nhap], [ma_khan_cap], [trang_thai]) VALUES (N'N00015', N'thuy69              ', NULL, N'QDN002', N'275536', 1)
INSERT [dbo].[TaiKhoan] ([ma_dang_nhap], [mat_khau], [ngay_tao], [ma_quyen_dang_nhap], [ma_khan_cap], [trang_thai]) VALUES (N'N00016', N'trai94              ', NULL, N'QDN002', N'248769', 1)
INSERT [dbo].[TaiKhoan] ([ma_dang_nhap], [mat_khau], [ngay_tao], [ma_quyen_dang_nhap], [ma_khan_cap], [trang_thai]) VALUES (N'N00017', N'khoi333             ', NULL, N'QDN002', N'746237', 1)
INSERT [dbo].[TaiKhoan] ([ma_dang_nhap], [mat_khau], [ngay_tao], [ma_quyen_dang_nhap], [ma_khan_cap], [trang_thai]) VALUES (N'N00018', N'dung479             ', NULL, N'QDN002', N'823888', 1)
INSERT [dbo].[TaiKhoan] ([ma_dang_nhap], [mat_khau], [ngay_tao], [ma_quyen_dang_nhap], [ma_khan_cap], [trang_thai]) VALUES (N'N00019', N'tiendoan            ', NULL, N'QDN002', N'547737', 1)
INSERT [dbo].[TaiKhoan] ([ma_dang_nhap], [mat_khau], [ngay_tao], [ma_quyen_dang_nhap], [ma_khan_cap], [trang_thai]) VALUES (N'N00020', N'anhtuan1            ', NULL, N'QDN002', N'021034', 1)
INSERT [dbo].[TaiKhoan] ([ma_dang_nhap], [mat_khau], [ngay_tao], [ma_quyen_dang_nhap], [ma_khan_cap], [trang_thai]) VALUES (N'N00021', N'thao                ', NULL, N'QDN002', N'098177', 1)
INSERT [dbo].[TaiKhoan] ([ma_dang_nhap], [mat_khau], [ngay_tao], [ma_quyen_dang_nhap], [ma_khan_cap], [trang_thai]) VALUES (N'N00022', N'ql123               ', CAST(0x0000A6EC00000000 AS DateTime), N'QDN001', N'654321', 1)
INSERT [dbo].[TaiKhoan] ([ma_dang_nhap], [mat_khau], [ngay_tao], [ma_quyen_dang_nhap], [ma_khan_cap], [trang_thai]) VALUES (N'N00023', N'@Hulk1              ', CAST(0x0000A82800733912 AS DateTime), N'QDN002', N'123123', 1)
INSERT [dbo].[TaiKhoan] ([ma_dang_nhap], [mat_khau], [ngay_tao], [ma_quyen_dang_nhap], [ma_khan_cap], [trang_thai]) VALUES (N'N00024', N'@Flash123           ', CAST(0x0000A828009A4268 AS DateTime), N'QDN002', N'123123', 1)
INSERT [dbo].[TaiKhoan] ([ma_dang_nhap], [mat_khau], [ngay_tao], [ma_quyen_dang_nhap], [ma_khan_cap], [trang_thai]) VALUES (N'N00025', N'@Test1              ', CAST(0x0000A829003C57E1 AS DateTime), N'QDN002', N'123123', 1)
INSERT [dbo].[TaiKhoan] ([ma_dang_nhap], [mat_khau], [ngay_tao], [ma_quyen_dang_nhap], [ma_khan_cap], [trang_thai]) VALUES (N'N00026', N'@Captain123         ', CAST(0x0000A82900000000 AS DateTime), N'QDN002', N'198273', 1)
INSERT [dbo].[TaiKhoan] ([ma_dang_nhap], [mat_khau], [ngay_tao], [ma_quyen_dang_nhap], [ma_khan_cap], [trang_thai]) VALUES (N'N00027', N'@Thor123            ', CAST(0x0000A82F00000000 AS DateTime), N'QDN001', N'789234', 0)
INSERT [dbo].[TaiKhoan] ([ma_dang_nhap], [mat_khau], [ngay_tao], [ma_quyen_dang_nhap], [ma_khan_cap], [trang_thai]) VALUES (N'N00028', N'@Noname1            ', CAST(0x0000A8300115F0A9 AS DateTime), N'QDN002', N'123123', 0)
INSERT [dbo].[TaiKhoan] ([ma_dang_nhap], [mat_khau], [ngay_tao], [ma_quyen_dang_nhap], [ma_khan_cap], [trang_thai]) VALUES (N'N00029', N'@NoName1            ', CAST(0x0000A83001178B13 AS DateTime), N'QDN002', N'123123', 0)
INSERT [dbo].[TaiKhoan] ([ma_dang_nhap], [mat_khau], [ngay_tao], [ma_quyen_dang_nhap], [ma_khan_cap], [trang_thai]) VALUES (N'N00030', N'@Noname2            ', CAST(0x0000A83001197E04 AS DateTime), N'QDN002', N'123123', 0)
INSERT [dbo].[TaiKhoan] ([ma_dang_nhap], [mat_khau], [ngay_tao], [ma_quyen_dang_nhap], [ma_khan_cap], [trang_thai]) VALUES (N'N00031', N'@hahaHa1            ', CAST(0x0000A83000000000 AS DateTime), N'QDN002', N'123123', 0)
/****** Object:  Table [dbo].[ThanhPhan]    Script Date: 11/30/2017 17:34:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ThanhPhan](
	[ma_mon_an] [char](5) NOT NULL,
	[ma_nguyen_lieu] [char](10) NOT NULL,
	[so_luong] [float] NOT NULL,
	[don_vi] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_ThanhPhan] PRIMARY KEY CLUSTERED 
(
	[ma_mon_an] ASC,
	[ma_nguyen_lieu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ThanhPhan] ([ma_mon_an], [ma_nguyen_lieu], [so_luong], [don_vi]) VALUES (N'M0006', N'NL0001    ', 1, N'DVT10')
/****** Object:  Table [dbo].[PhieuGiaoHang]    Script Date: 11/30/2017 17:34:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuGiaoHang](
	[ma_phieu_giao_hang] [char](10) NOT NULL,
	[ma_hoa_don_ban] [char](10) NOT NULL,
	[ma_nhan_vien_giao_hang] [char](6) NOT NULL,
	[trang_thai] [int] NULL,
 CONSTRAINT [PK_PhieuGiaoHang] PRIMARY KEY CLUSTERED 
(
	[ma_phieu_giao_hang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietMonAn]    Script Date: 11/30/2017 17:34:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietMonAn](
	[ma_mon_an] [char](5) NOT NULL,
	[ma_kich_thuoc] [char](5) NOT NULL,
	[gia_ban] [float] NOT NULL,
	[trang_thai] [bit] NOT NULL,
 CONSTRAINT [PK_ChiTietMonAn_1] PRIMARY KEY CLUSTERED 
(
	[ma_mon_an] ASC,
	[ma_kich_thuoc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0001', N'KTAN ', 15000, 0)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0001', N'KTUL ', 18000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0001', N'KTUM ', 21000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0001', N'KTUS ', 50000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0002', N'KTAN ', 15000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0002', N'KTUL ', 18000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0002', N'KTUM ', 21000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0002', N'KTUS ', 24000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0003', N'KTAN ', 15000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0003', N'KTUL ', 18000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0003', N'KTUM ', 21000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0003', N'KTUS ', 24001, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0004', N'KTAN ', 15000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0004', N'KTUL ', 18000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0004', N'KTUM ', 21000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0004', N'KTUS ', 24000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0005', N'KTAN ', 15000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0005', N'KTUL ', 18000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0005', N'KTUM ', 21000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0005', N'KTUS ', 24000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0006', N'KTAN ', 15000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0006', N'KTUL ', 18000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0006', N'KTUM ', 21000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0006', N'KTUS ', 24000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0007', N'KTAN ', 15000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0007', N'KTUL ', 18000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0007', N'KTUM ', 21000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0007', N'KTUS ', 24000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0008', N'KTAN ', 16000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0008', N'KTUL ', 19000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0008', N'KTUM ', 22000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0008', N'KTUS ', 25000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0009', N'KTAN ', 15000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0009', N'KTUL ', 18000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0009', N'KTUM ', 21000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0009', N'KTUS ', 24000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0010', N'KTAN ', 15000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0010', N'KTUL ', 18000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0010', N'KTUM ', 21000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0010', N'KTUS ', 24000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0011', N'KTAN ', 15000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0011', N'KTUL ', 18000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0011', N'KTUM ', 21000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0011', N'KTUS ', 24000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0012', N'KTAN ', 15000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0012', N'KTUL ', 18000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0012', N'KTUM ', 21000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0012', N'KTUS ', 24000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0013', N'KTAN ', 15000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0013', N'KTUL ', 18000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0013', N'KTUM ', 21000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0013', N'KTUS ', 24000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0014', N'KTAN ', 15000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0014', N'KTUL ', 18000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0014', N'KTUM ', 21000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0014', N'KTUS ', 24000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0015', N'KTAN ', 15000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0015', N'KTUL ', 18000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0015', N'KTUM ', 21000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0015', N'KTUS ', 24000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0016', N'KTAN ', 18000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0016', N'KTUL ', 21000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0016', N'KTUM ', 24000, 1)
INSERT [dbo].[ChiTietMonAn] ([ma_mon_an], [ma_kich_thuoc], [gia_ban], [trang_thai]) VALUES (N'M0016', N'KTUS ', 27000, 1)
/****** Object:  Table [dbo].[ChiTietHoaDonNhap]    Script Date: 11/30/2017 17:34:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietHoaDonNhap](
	[ma_hoa_don_nhap] [char](10) NOT NULL,
	[ma_nguyen_lieu] [char](10) NOT NULL,
	[ma_nha_cung_cap] [char](6) NOT NULL,
	[nguoi_dai_dien] [nvarchar](150) NULL,
	[so_luong_nhap] [float] NOT NULL,
	[don_vi_nhap] [nvarchar](20) NOT NULL,
	[don_gia] [float] NULL,
	[han_su_dung] [datetime] NOT NULL,
 CONSTRAINT [PK_ChiTietHoaDonNhap] PRIMARY KEY CLUSTERED 
(
	[ma_hoa_don_nhap] ASC,
	[ma_nguyen_lieu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietHoaDonBan]    Script Date: 11/30/2017 17:34:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietHoaDonBan](
	[ma_hoa_don_ban] [char](10) NOT NULL,
	[ma_mon_an] [char](5) NOT NULL,
	[don_gia] [float] NULL,
	[so_luong] [float] NOT NULL,
	[giam_gia] [float] NOT NULL,
	[thanh_tien] [float] NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'123       ', N'1    ', 1, 1, 1, 1)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'123       ', N'2    ', 2, 2, 2, 1)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000001', N'M0001', 25000, 1, 1, 25000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000002', N'M0001', 25000, 6, 1, 150000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000003', N'M0001', 25000, 4, 1, 100000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000004', N'M0001', 25000, 4, 1, 100000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000005', N'M0001', 25000, 2, 1, 50000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000006', N'M0001', 25000, 3, 1, 75000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000007', N'M0001', 25000, 1, 1, 25000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000008', N'M0001', 25000, 1, 1, 25000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000009', N'M0001', 25000, 1, 1, 25000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000010', N'M0001', 25000, 1, 1, 25000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000010', N'M0001', 31000, 1, 1, 31000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000010', N'M0001', 28000, 1, 1, 28000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000011', N'M0001', 25000, 3, 1, 75000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000012', N'M0001', 25000, 2, 1, 50000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000013', N'M0001', 25000, 1, 1, 25000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000013', N'M0001', 28000, 1, 1, 28000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000013', N'M0001', 31000, 1, 1, 31000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000013', N'M0001', 34000, 1, 1, 34000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000014', N'M0001', 25000, 5, 1, 125000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000015', N'M0001', 25000, 1, 1, 25000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000016', N'M0001', 25000, 1, 1, 25000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000017', N'M0001', 25000, 1, 1, 25000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000018', N'M0001', 25000, 2, 1, 50000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000019', N'M0001', 25000, 4, 1, 100000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000020', N'M0001', 25000, 1, 1, 25000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000021', N'M0001', 25000, 3, 1, 75000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000022', N'M0001', 25000, 2, 1, 50000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000023', N'M0001', 25000, 1, 1, 25000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000024', N'M0001', 25000, 4, 1, 100000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000025', N'M0001', 25000, 2, 1, 50000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000026', N'M0001', 25000, 3, 1, 75000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000027', N'M0001', 25000, 2, 1, 50000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000028', N'M0001', 25000, 1, 1, 25000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000029', N'M0001', 25000, 90, 1, 2250000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000030', N'M0002', 15000, 2, 1, 30000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000030', N'M0003', 21000, 1, 1, 21000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000030', N'M0003', 24000, 1, 1, 24000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000031', N'M0002', 15000, 6, 1, 90000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000031', N'M0001', 25000, 1, 1, 25000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000032', N'M0003', 15000, 4, 1, 60000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000033', N'M0001', 25000, 2, 1, 50000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000033', N'M0002', 15000, 2, 1, 30000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000034', N'M0001', 25000, 1, 1, 25000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000034', N'M0002', 21000, 6, 1, 126000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000037', N'M0001', 15000, 3, 1, 45000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000038', N'M0001', 15000, 5, 1, 75000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000038', N'M0001', 18000, 1, 1, 18000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000038', N'M0001', 50000, 1, 1, 50000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000038', N'M0001', 21000, 1, 1, 21000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000035', N'M0001', 21000, 1, 1, 21000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000035', N'M0001', 50000, 5, 1, 250000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000036', N'M0001', 15000, 3, 1, 45000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000036', N'M0001', 50000, 1, 1, 50000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000039', N'M0001', 15000, 3, 1, 45000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000039', N'M0001', 18000, 1, 1, 18000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000039', N'M0001', 21000, 1, 1, 21000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000039', N'M0001', 50000, 1, 1, 50000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000040', N'M0001', 15000, 1, 1, 15000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000041', N'M0001', 15000, 3, 1, 45000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000042', N'M0001', 15000, 3, 1, 45000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000043', N'M0001', 15000, 4, 1, 60000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000044', N'M0001', 15000, 4, 1, 60000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000045', N'M0001', 15000, 2, 1, 30000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000046', N'M0001', 15000, 2, 1, 30000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000046', N'M0001', 21000, 1, 1, 21000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000046', N'M0001', 50000, 1, 1, 50000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000047', N'M0003', 15000, 4, 1, 60000)
INSERT [dbo].[ChiTietHoaDonBan] ([ma_hoa_don_ban], [ma_mon_an], [don_gia], [so_luong], [giam_gia], [thanh_tien]) VALUES (N'HDB0000048', N'M0002', 15000, 1, 1, 15000)
/****** Object:  ForeignKey [FK_TheKhachHang_KhachHang]    Script Date: 11/30/2017 17:34:36 ******/
ALTER TABLE [dbo].[TheKhachHang]  WITH NOCHECK ADD  CONSTRAINT [FK_TheKhachHang_KhachHang] FOREIGN KEY([ma_khach_hang])
REFERENCES [dbo].[KhachHang] ([ma_khach_hang])
GO
ALTER TABLE [dbo].[TheKhachHang] NOCHECK CONSTRAINT [FK_TheKhachHang_KhachHang]
GO
/****** Object:  ForeignKey [FK_TheKhachHang_LoaiTheKhachHang]    Script Date: 11/30/2017 17:34:36 ******/
ALTER TABLE [dbo].[TheKhachHang]  WITH NOCHECK ADD  CONSTRAINT [FK_TheKhachHang_LoaiTheKhachHang] FOREIGN KEY([ma_loai_the])
REFERENCES [dbo].[LoaiTheKhachHang] ([ma_loai_the])
GO
ALTER TABLE [dbo].[TheKhachHang] NOCHECK CONSTRAINT [FK_TheKhachHang_LoaiTheKhachHang]
GO
/****** Object:  ForeignKey [FK_Luong_ChucVu]    Script Date: 11/30/2017 17:34:36 ******/
ALTER TABLE [dbo].[Luong]  WITH CHECK ADD  CONSTRAINT [FK_Luong_ChucVu] FOREIGN KEY([ma_chuc_vu])
REFERENCES [dbo].[ChucVu] ([ma_chuc_vu])
GO
ALTER TABLE [dbo].[Luong] CHECK CONSTRAINT [FK_Luong_ChucVu]
GO
/****** Object:  ForeignKey [FK_Luong_LoaiLuong]    Script Date: 11/30/2017 17:34:36 ******/
ALTER TABLE [dbo].[Luong]  WITH CHECK ADD  CONSTRAINT [FK_Luong_LoaiLuong] FOREIGN KEY([ma_loai_luong])
REFERENCES [dbo].[LoaiLuong] ([ma_loai_luong])
GO
ALTER TABLE [dbo].[Luong] CHECK CONSTRAINT [FK_Luong_LoaiLuong]
GO
/****** Object:  ForeignKey [FK_NhanVien_ChucVu]    Script Date: 11/30/2017 17:34:36 ******/
ALTER TABLE [dbo].[NhanVien]  WITH NOCHECK ADD  CONSTRAINT [FK_NhanVien_ChucVu] FOREIGN KEY([ma_chuc_vu])
REFERENCES [dbo].[ChucVu] ([ma_chuc_vu])
GO
ALTER TABLE [dbo].[NhanVien] NOCHECK CONSTRAINT [FK_NhanVien_ChucVu]
GO
/****** Object:  ForeignKey [FK_NhanVien_NhanVien]    Script Date: 11/30/2017 17:34:36 ******/
ALTER TABLE [dbo].[NhanVien]  WITH NOCHECK ADD  CONSTRAINT [FK_NhanVien_NhanVien] FOREIGN KEY([ma_nguoi_quan_ly])
REFERENCES [dbo].[NhanVien] ([ma_nhan_vien])
GO
ALTER TABLE [dbo].[NhanVien] NOCHECK CONSTRAINT [FK_NhanVien_NhanVien]
GO
/****** Object:  ForeignKey [FK_NhanVien_TrangThaiNhanVien]    Script Date: 11/30/2017 17:34:36 ******/
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_TrangThaiNhanVien] FOREIGN KEY([ma_trang_thai_nhan_vien])
REFERENCES [dbo].[TrangThaiNhanVien] ([ma_trang_thai_nhan_vien])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_TrangThaiNhanVien]
GO
/****** Object:  ForeignKey [FK_NguyenLieu_LoaiNguyenLieu]    Script Date: 11/30/2017 17:34:36 ******/
ALTER TABLE [dbo].[NguyenLieu]  WITH NOCHECK ADD  CONSTRAINT [FK_NguyenLieu_LoaiNguyenLieu] FOREIGN KEY([ma_loai_nguyen_lieu])
REFERENCES [dbo].[LoaiNguyenLieu] ([ma_loai_nguyen_lieu])
GO
ALTER TABLE [dbo].[NguyenLieu] NOCHECK CONSTRAINT [FK_NguyenLieu_LoaiNguyenLieu]
GO
/****** Object:  ForeignKey [FK_ChiTietChucNang_ChucNang]    Script Date: 11/30/2017 17:34:36 ******/
ALTER TABLE [dbo].[ChiTietChucNang]  WITH NOCHECK ADD  CONSTRAINT [FK_ChiTietChucNang_ChucNang] FOREIGN KEY([ma_chuc_nang])
REFERENCES [dbo].[ChucNang] ([ma_chuc_nang])
GO
ALTER TABLE [dbo].[ChiTietChucNang] NOCHECK CONSTRAINT [FK_ChiTietChucNang_ChucNang]
GO
/****** Object:  ForeignKey [FK_ChiTietChucNang_ChucVu]    Script Date: 11/30/2017 17:34:36 ******/
ALTER TABLE [dbo].[ChiTietChucNang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietChucNang_ChucVu] FOREIGN KEY([ma_chuc_vu])
REFERENCES [dbo].[ChucVu] ([ma_chuc_vu])
GO
ALTER TABLE [dbo].[ChiTietChucNang] CHECK CONSTRAINT [FK_ChiTietChucNang_ChucVu]
GO
/****** Object:  ForeignKey [FK_LoaiMonAn_NhomMonAn]    Script Date: 11/30/2017 17:34:36 ******/
ALTER TABLE [dbo].[LoaiMonAn]  WITH NOCHECK ADD  CONSTRAINT [FK_LoaiMonAn_NhomMonAn] FOREIGN KEY([ma_nhom_mon_an])
REFERENCES [dbo].[NhomMonAn] ([ma_nhom_mon_an])
GO
ALTER TABLE [dbo].[LoaiMonAn] NOCHECK CONSTRAINT [FK_LoaiMonAn_NhomMonAn]
GO
/****** Object:  ForeignKey [FK_HoaDonNhap_NhanVien]    Script Date: 11/30/2017 17:34:36 ******/
ALTER TABLE [dbo].[HoaDonNhap]  WITH NOCHECK ADD  CONSTRAINT [FK_HoaDonNhap_NhanVien] FOREIGN KEY([ma_nhan_vien])
REFERENCES [dbo].[NhanVien] ([ma_nhan_vien])
GO
ALTER TABLE [dbo].[HoaDonNhap] NOCHECK CONSTRAINT [FK_HoaDonNhap_NhanVien]
GO
/****** Object:  ForeignKey [FK_HoaDonBanHang_KhachHang]    Script Date: 11/30/2017 17:34:36 ******/
ALTER TABLE [dbo].[HoaDonBan]  WITH NOCHECK ADD  CONSTRAINT [FK_HoaDonBanHang_KhachHang] FOREIGN KEY([ma_khach_hang])
REFERENCES [dbo].[KhachHang] ([ma_khach_hang])
GO
ALTER TABLE [dbo].[HoaDonBan] NOCHECK CONSTRAINT [FK_HoaDonBanHang_KhachHang]
GO
/****** Object:  ForeignKey [FK_HoaDonBanHang_NhanVien]    Script Date: 11/30/2017 17:34:36 ******/
ALTER TABLE [dbo].[HoaDonBan]  WITH NOCHECK ADD  CONSTRAINT [FK_HoaDonBanHang_NhanVien] FOREIGN KEY([ma_nhan_vien])
REFERENCES [dbo].[NhanVien] ([ma_nhan_vien])
GO
ALTER TABLE [dbo].[HoaDonBan] NOCHECK CONSTRAINT [FK_HoaDonBanHang_NhanVien]
GO
/****** Object:  ForeignKey [FK_BanPhanCong_NhanVien]    Script Date: 11/30/2017 17:34:36 ******/
ALTER TABLE [dbo].[BanPhanCong]  WITH NOCHECK ADD  CONSTRAINT [FK_BanPhanCong_NhanVien] FOREIGN KEY([ma_nhan_vien_tao])
REFERENCES [dbo].[NhanVien] ([ma_nhan_vien])
GO
ALTER TABLE [dbo].[BanPhanCong] NOCHECK CONSTRAINT [FK_BanPhanCong_NhanVien]
GO
/****** Object:  ForeignKey [FK_BanGhiLuongNhanVien_NhanVien]    Script Date: 11/30/2017 17:34:36 ******/
ALTER TABLE [dbo].[BanGhiLuongNhanVien]  WITH NOCHECK ADD  CONSTRAINT [FK_BanGhiLuongNhanVien_NhanVien] FOREIGN KEY([ma_nhan_vien])
REFERENCES [dbo].[NhanVien] ([ma_nhan_vien])
GO
ALTER TABLE [dbo].[BanGhiLuongNhanVien] NOCHECK CONSTRAINT [FK_BanGhiLuongNhanVien_NhanVien]
GO
/****** Object:  ForeignKey [FK_ChiTietBanPhanCong_CaLamViec]    Script Date: 11/30/2017 17:34:36 ******/
ALTER TABLE [dbo].[ChiTietBanPhanCong]  WITH NOCHECK ADD  CONSTRAINT [FK_ChiTietBanPhanCong_CaLamViec] FOREIGN KEY([ma_ca_lam_viec])
REFERENCES [dbo].[CaLamViec] ([ma_ca_lam])
GO
ALTER TABLE [dbo].[ChiTietBanPhanCong] NOCHECK CONSTRAINT [FK_ChiTietBanPhanCong_CaLamViec]
GO
/****** Object:  ForeignKey [FK_ChiTietBanPhanCong_NhanVien]    Script Date: 11/30/2017 17:34:36 ******/
ALTER TABLE [dbo].[ChiTietBanPhanCong]  WITH NOCHECK ADD  CONSTRAINT [FK_ChiTietBanPhanCong_NhanVien] FOREIGN KEY([ma_nhan_vien])
REFERENCES [dbo].[NhanVien] ([ma_nhan_vien])
GO
ALTER TABLE [dbo].[ChiTietBanPhanCong] NOCHECK CONSTRAINT [FK_ChiTietBanPhanCong_NhanVien]
GO
/****** Object:  ForeignKey [FK_ChiTietBanPhanCong_TrangThaiBanPhanCong]    Script Date: 11/30/2017 17:34:36 ******/
ALTER TABLE [dbo].[ChiTietBanPhanCong]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietBanPhanCong_TrangThaiBanPhanCong] FOREIGN KEY([trang_thai])
REFERENCES [dbo].[TrangThaiBanPhanCong] ([ma_trang_thai_bpc])
GO
ALTER TABLE [dbo].[ChiTietBanPhanCong] CHECK CONSTRAINT [FK_ChiTietBanPhanCong_TrangThaiBanPhanCong]
GO
/****** Object:  ForeignKey [FK_ChiTietLoiViPham_LoiViPham]    Script Date: 11/30/2017 17:34:36 ******/
ALTER TABLE [dbo].[ChiTietLoiViPham]  WITH NOCHECK ADD  CONSTRAINT [FK_ChiTietLoiViPham_LoiViPham] FOREIGN KEY([ma_loi_vi_pham])
REFERENCES [dbo].[LoiViPham] ([ma_loi_vi_pham])
GO
ALTER TABLE [dbo].[ChiTietLoiViPham] NOCHECK CONSTRAINT [FK_ChiTietLoiViPham_LoiViPham]
GO
/****** Object:  ForeignKey [FK_ChiTietLoiViPham_NhanVien]    Script Date: 11/30/2017 17:34:36 ******/
ALTER TABLE [dbo].[ChiTietLoiViPham]  WITH NOCHECK ADD  CONSTRAINT [FK_ChiTietLoiViPham_NhanVien] FOREIGN KEY([ma_nhan_vien_vi_pham])
REFERENCES [dbo].[NhanVien] ([ma_nhan_vien])
GO
ALTER TABLE [dbo].[ChiTietLoiViPham] NOCHECK CONSTRAINT [FK_ChiTietLoiViPham_NhanVien]
GO
/****** Object:  ForeignKey [FK_MonAn_DonViTinh]    Script Date: 11/30/2017 17:34:36 ******/
ALTER TABLE [dbo].[MonAn]  WITH NOCHECK ADD  CONSTRAINT [FK_MonAn_DonViTinh] FOREIGN KEY([ma_don_vi_tinh])
REFERENCES [dbo].[DonViTinh] ([ma_don_vi_tinh])
GO
ALTER TABLE [dbo].[MonAn] NOCHECK CONSTRAINT [FK_MonAn_DonViTinh]
GO
/****** Object:  ForeignKey [FK_ThucDon_LoaiMonAn]    Script Date: 11/30/2017 17:34:36 ******/
ALTER TABLE [dbo].[MonAn]  WITH NOCHECK ADD  CONSTRAINT [FK_ThucDon_LoaiMonAn] FOREIGN KEY([ma_loai_mon_an])
REFERENCES [dbo].[LoaiMonAn] ([ma_loai_mon_an])
GO
ALTER TABLE [dbo].[MonAn] NOCHECK CONSTRAINT [FK_ThucDon_LoaiMonAn]
GO
/****** Object:  ForeignKey [FK_TaiKhoan_KhachHang]    Script Date: 11/30/2017 17:34:36 ******/
ALTER TABLE [dbo].[TaiKhoan]  WITH NOCHECK ADD  CONSTRAINT [FK_TaiKhoan_KhachHang] FOREIGN KEY([ma_dang_nhap])
REFERENCES [dbo].[KhachHang] ([ma_khach_hang])
GO
ALTER TABLE [dbo].[TaiKhoan] NOCHECK CONSTRAINT [FK_TaiKhoan_KhachHang]
GO
/****** Object:  ForeignKey [FK_TaiKhoan_NhanVien1]    Script Date: 11/30/2017 17:34:36 ******/
ALTER TABLE [dbo].[TaiKhoan]  WITH NOCHECK ADD  CONSTRAINT [FK_TaiKhoan_NhanVien1] FOREIGN KEY([ma_dang_nhap])
REFERENCES [dbo].[NhanVien] ([ma_nhan_vien])
GO
ALTER TABLE [dbo].[TaiKhoan] NOCHECK CONSTRAINT [FK_TaiKhoan_NhanVien1]
GO
/****** Object:  ForeignKey [FK_TaiKhoan_QuyenDangNhap]    Script Date: 11/30/2017 17:34:36 ******/
ALTER TABLE [dbo].[TaiKhoan]  WITH NOCHECK ADD  CONSTRAINT [FK_TaiKhoan_QuyenDangNhap] FOREIGN KEY([ma_quyen_dang_nhap])
REFERENCES [dbo].[QuyenDangNhap] ([ma_quyen_dang_nhap])
GO
ALTER TABLE [dbo].[TaiKhoan] NOCHECK CONSTRAINT [FK_TaiKhoan_QuyenDangNhap]
GO
/****** Object:  ForeignKey [FK_ThanhPhan_MonAn]    Script Date: 11/30/2017 17:34:36 ******/
ALTER TABLE [dbo].[ThanhPhan]  WITH CHECK ADD  CONSTRAINT [FK_ThanhPhan_MonAn] FOREIGN KEY([ma_mon_an])
REFERENCES [dbo].[MonAn] ([ma_mon_an])
GO
ALTER TABLE [dbo].[ThanhPhan] CHECK CONSTRAINT [FK_ThanhPhan_MonAn]
GO
/****** Object:  ForeignKey [FK_ThanhPhan_NguyenLieu]    Script Date: 11/30/2017 17:34:36 ******/
ALTER TABLE [dbo].[ThanhPhan]  WITH CHECK ADD  CONSTRAINT [FK_ThanhPhan_NguyenLieu] FOREIGN KEY([ma_nguyen_lieu])
REFERENCES [dbo].[NguyenLieu] ([ma_nguyen_lieu])
GO
ALTER TABLE [dbo].[ThanhPhan] CHECK CONSTRAINT [FK_ThanhPhan_NguyenLieu]
GO
/****** Object:  ForeignKey [FK_PhieuGiaoHang_HoaDonBanHang]    Script Date: 11/30/2017 17:34:36 ******/
ALTER TABLE [dbo].[PhieuGiaoHang]  WITH NOCHECK ADD  CONSTRAINT [FK_PhieuGiaoHang_HoaDonBanHang] FOREIGN KEY([ma_hoa_don_ban])
REFERENCES [dbo].[HoaDonBan] ([ma_hoa_don_ban])
GO
ALTER TABLE [dbo].[PhieuGiaoHang] NOCHECK CONSTRAINT [FK_PhieuGiaoHang_HoaDonBanHang]
GO
/****** Object:  ForeignKey [FK_ChiTietMonAn_MonAn]    Script Date: 11/30/2017 17:34:36 ******/
ALTER TABLE [dbo].[ChiTietMonAn]  WITH NOCHECK ADD  CONSTRAINT [FK_ChiTietMonAn_MonAn] FOREIGN KEY([ma_mon_an])
REFERENCES [dbo].[MonAn] ([ma_mon_an])
GO
ALTER TABLE [dbo].[ChiTietMonAn] NOCHECK CONSTRAINT [FK_ChiTietMonAn_MonAn]
GO
/****** Object:  ForeignKey [FK_ChiTietMonAn_SizeMonAn]    Script Date: 11/30/2017 17:34:36 ******/
ALTER TABLE [dbo].[ChiTietMonAn]  WITH NOCHECK ADD  CONSTRAINT [FK_ChiTietMonAn_SizeMonAn] FOREIGN KEY([ma_kich_thuoc])
REFERENCES [dbo].[KichThuocMonAn] ([ma_kich_thuoc])
GO
ALTER TABLE [dbo].[ChiTietMonAn] NOCHECK CONSTRAINT [FK_ChiTietMonAn_SizeMonAn]
GO
/****** Object:  ForeignKey [FK_ChiTietHoaDonNhap_HoaDonNhap]    Script Date: 11/30/2017 17:34:36 ******/
ALTER TABLE [dbo].[ChiTietHoaDonNhap]  WITH NOCHECK ADD  CONSTRAINT [FK_ChiTietHoaDonNhap_HoaDonNhap] FOREIGN KEY([ma_hoa_don_nhap])
REFERENCES [dbo].[HoaDonNhap] ([ma_hoa_don_nhap])
GO
ALTER TABLE [dbo].[ChiTietHoaDonNhap] NOCHECK CONSTRAINT [FK_ChiTietHoaDonNhap_HoaDonNhap]
GO
/****** Object:  ForeignKey [FK_ChiTietHoaDonNhap_NguyenLieu]    Script Date: 11/30/2017 17:34:36 ******/
ALTER TABLE [dbo].[ChiTietHoaDonNhap]  WITH NOCHECK ADD  CONSTRAINT [FK_ChiTietHoaDonNhap_NguyenLieu] FOREIGN KEY([ma_nguyen_lieu])
REFERENCES [dbo].[NguyenLieu] ([ma_nguyen_lieu])
GO
ALTER TABLE [dbo].[ChiTietHoaDonNhap] NOCHECK CONSTRAINT [FK_ChiTietHoaDonNhap_NguyenLieu]
GO
/****** Object:  ForeignKey [FK_ChiTietHoaDonNhap_NhaCungCap]    Script Date: 11/30/2017 17:34:36 ******/
ALTER TABLE [dbo].[ChiTietHoaDonNhap]  WITH NOCHECK ADD  CONSTRAINT [FK_ChiTietHoaDonNhap_NhaCungCap] FOREIGN KEY([ma_nha_cung_cap])
REFERENCES [dbo].[NhaCungCap] ([ma_nha_cung_cap])
GO
ALTER TABLE [dbo].[ChiTietHoaDonNhap] NOCHECK CONSTRAINT [FK_ChiTietHoaDonNhap_NhaCungCap]
GO
/****** Object:  ForeignKey [FK_ChiTietHoaDonBan_HoaDonBanHang]    Script Date: 11/30/2017 17:34:36 ******/
ALTER TABLE [dbo].[ChiTietHoaDonBan]  WITH NOCHECK ADD  CONSTRAINT [FK_ChiTietHoaDonBan_HoaDonBanHang] FOREIGN KEY([ma_hoa_don_ban])
REFERENCES [dbo].[HoaDonBan] ([ma_hoa_don_ban])
GO
ALTER TABLE [dbo].[ChiTietHoaDonBan] NOCHECK CONSTRAINT [FK_ChiTietHoaDonBan_HoaDonBanHang]
GO
