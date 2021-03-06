USE [CHUOICUAHANGDOAN-new]
GO
/****** Object:  Table [dbo].[BAI_DANH_GIA]    Script Date: 09/06/2020 11:59:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BAI_DANH_GIA](
	[MÃ BÀI ĐÁNH GIÁ] [nvarchar](50) NOT NULL,
	[MÃ CỬA HÀNG] [nvarchar](10) NOT NULL,
	[MÃ KHÁCH HÀNG] [nvarchar](10) NOT NULL,
	[CHI TIẾT ĐÁNH GIÁ] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_BAI_DANH_GIA] PRIMARY KEY CLUSTERED 
(
	[MÃ BÀI ĐÁNH GIÁ] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHI_TIET_DON_DAT_HANG]    Script Date: 09/06/2020 11:59:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHI_TIET_DON_DAT_HANG](
	[MÃ ĐƠN HÀNG] [nvarchar](10) NOT NULL,
	[MÃ MÓN ĂN] [nvarchar](10) NOT NULL,
	[TÊN MÓN ĂN] [nvarchar](50) NOT NULL,
	[SỐ LƯỢNG] [int] NOT NULL,
 CONSTRAINT [PK_CHI_TIET_DON_DAT_HANG] PRIMARY KEY CLUSTERED 
(
	[MÃ ĐƠN HÀNG] ASC,
	[TÊN MÓN ĂN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CUA_HANG]    Script Date: 09/06/2020 11:59:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CUA_HANG](
	[MÃ CỬA HÀNG] [nvarchar](10) NOT NULL,
	[ĐỊA CHỈ] [nvarchar](50) NOT NULL,
	[TRẠNG THÁI HOẠT ĐỘNG] [int] NOT NULL,
 CONSTRAINT [PK_CUAHANG] PRIMARY KEY CLUSTERED 
(
	[MÃ CỬA HÀNG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DON_DAT_HANG]    Script Date: 09/06/2020 11:59:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DON_DAT_HANG](
	[MÃ ĐƠN HÀNG] [nvarchar](10) NOT NULL,
	[MÃ CỬA HÀNG] [nvarchar](10) NOT NULL,
	[MÃ NHÂN VIÊN] [nvarchar](50) NULL,
	[MÃ KHÁCH HÀNG(SĐT)] [nvarchar](10) NOT NULL,
	[TỔNG TIỀN] [float] NOT NULL,
	[NGÀY] [date] NOT NULL,
	[ĐỊA CHỈ] [nvarchar](100) NOT NULL,
	[TRẠNG THÁI ĐƠN HÀNG] [int] NOT NULL,
 CONSTRAINT [PK_HOADON] PRIMARY KEY CLUSTERED 
(
	[MÃ ĐƠN HÀNG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACH_HANG]    Script Date: 09/06/2020 11:59:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACH_HANG](
	[TÊN TÀI KHOẢN(SĐT)] [nvarchar](10) NOT NULL,
	[HỌ TÊN] [nvarchar](50) NOT NULL,
	[MÃ TÀI KHOẢN] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_TK_KHACH_HANG_1] PRIMARY KEY CLUSTERED 
(
	[TÊN TÀI KHOẢN(SĐT)] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MON_AN]    Script Date: 09/06/2020 11:59:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MON_AN](
	[MÃ MÓN ĂN] [nvarchar](10) NOT NULL,
	[TÊN MÓN ĂN] [nvarchar](50) NOT NULL,
	[GIÁ TIỀN] [float] NOT NULL,
	[HÌNH ẢNH] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_MONAN] PRIMARY KEY CLUSTERED 
(
	[MÃ MÓN ĂN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MON_AN_CUA_HANG]    Script Date: 09/06/2020 11:59:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MON_AN_CUA_HANG](
	[MÃ CỬA HÀNG] [nvarchar](10) NOT NULL,
	[MÃ MÓN ĂN] [nvarchar](10) NOT NULL,
	[SỐ LƯỢNG] [int] NOT NULL,
 CONSTRAINT [PK_MENU_MON_AN] PRIMARY KEY CLUSTERED 
(
	[MÃ CỬA HÀNG] ASC,
	[MÃ MÓN ĂN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHAN_VIEN]    Script Date: 09/06/2020 11:59:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHAN_VIEN](
	[MÃ NHÂN VIÊN] [nvarchar](10) NOT NULL,
	[MÃ CỬA HÀNG] [nvarchar](10) NOT NULL,
	[HỌ TÊN NHÂN VIÊN] [nvarchar](50) NOT NULL,
	[NĂM SINH] [int] NOT NULL,
	[GIỚI TÍNH] [nvarchar](3) NOT NULL,
	[ĐỊA CHỈ] [nvarchar](50) NOT NULL,
	[SỐ ĐIỆN THOẠI] [nvarchar](10) NOT NULL,
	[MÃ TÀI KHOẢN] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_NHAN_VIEN] PRIMARY KEY CLUSTERED 
(
	[MÃ NHÂN VIÊN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAI_KHOAN]    Script Date: 09/06/2020 11:59:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAI_KHOAN](
	[TÊN TÀI KHOẢN] [nvarchar](10) NOT NULL,
	[MẬT KHẨU] [nvarchar](50) NOT NULL,
	[LOẠI TRUY CẬP] [int] NOT NULL,
 CONSTRAINT [PK_TAI_KHOAN] PRIMARY KEY CLUSTERED 
(
	[TÊN TÀI KHOẢN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BAI_DANH_GIA] ([MÃ BÀI ĐÁNH GIÁ], [MÃ CỬA HÀNG], [MÃ KHÁCH HÀNG], [CHI TIẾT ĐÁNH GIÁ]) VALUES (N'CH1DG1', N'CH1', N'0363320012', N'ok')
INSERT [dbo].[BAI_DANH_GIA] ([MÃ BÀI ĐÁNH GIÁ], [MÃ CỬA HÀNG], [MÃ KHÁCH HÀNG], [CHI TIẾT ĐÁNH GIÁ]) VALUES (N'CH1DG2', N'CH1', N'0962440227', N'tàm tạm')
INSERT [dbo].[BAI_DANH_GIA] ([MÃ BÀI ĐÁNH GIÁ], [MÃ CỬA HÀNG], [MÃ KHÁCH HÀNG], [CHI TIẾT ĐÁNH GIÁ]) VALUES (N'CH2DG1', N'CH2', N'0965046890', N'rất tốt')
INSERT [dbo].[BAI_DANH_GIA] ([MÃ BÀI ĐÁNH GIÁ], [MÃ CỬA HÀNG], [MÃ KHÁCH HÀNG], [CHI TIẾT ĐÁNH GIÁ]) VALUES (N'CH3DG1', N'CH3', N'0965046890', N'tệ')
INSERT [dbo].[BAI_DANH_GIA] ([MÃ BÀI ĐÁNH GIÁ], [MÃ CỬA HÀNG], [MÃ KHÁCH HÀNG], [CHI TIẾT ĐÁNH GIÁ]) VALUES (N'CH3DG2', N'CH3', N'0363320012', N' Chất lượng tuyệt vời!')
GO
INSERT [dbo].[CHI_TIET_DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ MÓN ĂN], [TÊN MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH1DH1', N'MC1', N'Bún thịt nướng', 1)
INSERT [dbo].[CHI_TIET_DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ MÓN ĂN], [TÊN MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH1DH1', N'DU1', N'Pepsi', 2)
INSERT [dbo].[CHI_TIET_DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ MÓN ĂN], [TÊN MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH1DH10', N'MC1', N'Bún thịt nướng', 1)
INSERT [dbo].[CHI_TIET_DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ MÓN ĂN], [TÊN MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH1DH10', N'MC6', N'Gà sốt me', 1)
INSERT [dbo].[CHI_TIET_DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ MÓN ĂN], [TÊN MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH1DH10', N'DU1', N'Pepsi', 1)
INSERT [dbo].[CHI_TIET_DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ MÓN ĂN], [TÊN MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH1DH10', N'DU6', N'Sevenup', 1)
INSERT [dbo].[CHI_TIET_DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ MÓN ĂN], [TÊN MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH1DH11', N'MC2', N'Cơm tấm', 1)
INSERT [dbo].[CHI_TIET_DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ MÓN ĂN], [TÊN MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH1DH11', N'MC6', N'Gà sốt me', 1)
INSERT [dbo].[CHI_TIET_DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ MÓN ĂN], [TÊN MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH1DH2', N'AV1', N'Khoai tây chiên bơ', 2)
INSERT [dbo].[CHI_TIET_DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ MÓN ĂN], [TÊN MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH1DH2', N'DU1', N'Pepsi', 1)
INSERT [dbo].[CHI_TIET_DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ MÓN ĂN], [TÊN MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH1DH3', N'MC1', N'Bún thịt nướng', 1)
INSERT [dbo].[CHI_TIET_DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ MÓN ĂN], [TÊN MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH1DH3', N'DU1', N'Pepsi', 2)
INSERT [dbo].[CHI_TIET_DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ MÓN ĂN], [TÊN MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH1DH4', N'MC1', N'Bún thịt nướng', 1)
INSERT [dbo].[CHI_TIET_DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ MÓN ĂN], [TÊN MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH1DH4', N'DU1', N'Pepsi', 2)
INSERT [dbo].[CHI_TIET_DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ MÓN ĂN], [TÊN MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH1DH5', N'MC1', N'Bún thịt nướng', 1)
INSERT [dbo].[CHI_TIET_DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ MÓN ĂN], [TÊN MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH1DH5', N'DU1', N'Pepsi', 2)
INSERT [dbo].[CHI_TIET_DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ MÓN ĂN], [TÊN MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH1DH6', N'MC1', N'Bún thịt nướng', 1)
INSERT [dbo].[CHI_TIET_DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ MÓN ĂN], [TÊN MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH1DH6', N'MC2', N'Cơm tấm', 1)
INSERT [dbo].[CHI_TIET_DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ MÓN ĂN], [TÊN MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'ch1DH7', N'AV1', N'Khoai tây chiên bo', 1)
INSERT [dbo].[CHI_TIET_DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ MÓN ĂN], [TÊN MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'ch1DH7', N'AV2', N'Pizza', 1)
INSERT [dbo].[CHI_TIET_DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ MÓN ĂN], [TÊN MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'ch1DH8', N'AV1', N'Khoai tây chiên bo', 1)
INSERT [dbo].[CHI_TIET_DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ MÓN ĂN], [TÊN MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'ch1DH8', N'AV2', N'Pizza', 1)
INSERT [dbo].[CHI_TIET_DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ MÓN ĂN], [TÊN MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH1DH9', N'MC1', N'Bún thịt nướng', 1)
INSERT [dbo].[CHI_TIET_DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ MÓN ĂN], [TÊN MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH1DH9', N'MC6', N'Gà sốt me', 1)
INSERT [dbo].[CHI_TIET_DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ MÓN ĂN], [TÊN MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH1DH9', N'DU1', N'Pepsi', 1)
INSERT [dbo].[CHI_TIET_DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ MÓN ĂN], [TÊN MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH2DH1', N'MC1', N'Bún thịt nướng', 1)
INSERT [dbo].[CHI_TIET_DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ MÓN ĂN], [TÊN MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH2DH1', N'DU1', N'Pepsi', 2)
INSERT [dbo].[CHI_TIET_DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ MÓN ĂN], [TÊN MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH2DH2', N'MC2', N'Cơm tấm', 1)
INSERT [dbo].[CHI_TIET_DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ MÓN ĂN], [TÊN MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH2DH2', N'DU1', N'Pepsi', 1)
INSERT [dbo].[CHI_TIET_DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ MÓN ĂN], [TÊN MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH2DH2', N'DU6', N'Sevenup', 1)
INSERT [dbo].[CHI_TIET_DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ MÓN ĂN], [TÊN MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH3DH1', N'MC5', N'Cơm Gà', 2)
INSERT [dbo].[CHI_TIET_DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ MÓN ĂN], [TÊN MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH3DH2', N'MC5', N'Cơm Gà', 2)
INSERT [dbo].[CHI_TIET_DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ MÓN ĂN], [TÊN MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH3DH3', N'DU1', N'Pepsi', 1)
INSERT [dbo].[CHI_TIET_DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ MÓN ĂN], [TÊN MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH3DH3', N'AV2', N'Pizza', 1)
INSERT [dbo].[CHI_TIET_DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ MÓN ĂN], [TÊN MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH3DH3', N'DU6', N'Sevenup', 1)
INSERT [dbo].[CHI_TIET_DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ MÓN ĂN], [TÊN MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH4DH1', N'MC1', N'Bún thịt nướng', 1)
INSERT [dbo].[CHI_TIET_DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ MÓN ĂN], [TÊN MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH4DH1', N'AV2', N'Pizza', 1)
GO
INSERT [dbo].[CUA_HANG] ([MÃ CỬA HÀNG], [ĐỊA CHỈ], [TRẠNG THÁI HOẠT ĐỘNG]) VALUES (N'CH1', N'Quận Bình Thạnh', 1)
INSERT [dbo].[CUA_HANG] ([MÃ CỬA HÀNG], [ĐỊA CHỈ], [TRẠNG THÁI HOẠT ĐỘNG]) VALUES (N'CH2', N'Quận 3', 1)
INSERT [dbo].[CUA_HANG] ([MÃ CỬA HÀNG], [ĐỊA CHỈ], [TRẠNG THÁI HOẠT ĐỘNG]) VALUES (N'CH3', N'Quận 1', 1)
INSERT [dbo].[CUA_HANG] ([MÃ CỬA HÀNG], [ĐỊA CHỈ], [TRẠNG THÁI HOẠT ĐỘNG]) VALUES (N'CH4', N'Quận 2', 1)
INSERT [dbo].[CUA_HANG] ([MÃ CỬA HÀNG], [ĐỊA CHỈ], [TRẠNG THÁI HOẠT ĐỘNG]) VALUES (N'CH5', N'Quận Phú Nhuận', 0)
GO
INSERT [dbo].[DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ CỬA HÀNG], [MÃ NHÂN VIÊN], [MÃ KHÁCH HÀNG(SĐT)], [TỔNG TIỀN], [NGÀY], [ĐỊA CHỈ], [TRẠNG THÁI ĐƠN HÀNG]) VALUES (N'CH1DH1', N'CH1', NULL, N'0363320012', 60000, CAST(N'2020-04-30' AS Date), N'Quận Bình Thạnh', 3)
INSERT [dbo].[DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ CỬA HÀNG], [MÃ NHÂN VIÊN], [MÃ KHÁCH HÀNG(SĐT)], [TỔNG TIỀN], [NGÀY], [ĐỊA CHỈ], [TRẠNG THÁI ĐƠN HÀNG]) VALUES (N'CH1DH10', N'CH1', N'ch1nv1', N'0363320012', 105000, CAST(N'2020-06-09' AS Date), N'dsfsdg', 3)
INSERT [dbo].[DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ CỬA HÀNG], [MÃ NHÂN VIÊN], [MÃ KHÁCH HÀNG(SĐT)], [TỔNG TIỀN], [NGÀY], [ĐỊA CHỈ], [TRẠNG THÁI ĐƠN HÀNG]) VALUES (N'CH1DH11', N'CH1', NULL, N'0363320012', 100000, CAST(N'2020-06-09' AS Date), N'56456', 3)
INSERT [dbo].[DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ CỬA HÀNG], [MÃ NHÂN VIÊN], [MÃ KHÁCH HÀNG(SĐT)], [TỔNG TIỀN], [NGÀY], [ĐỊA CHỈ], [TRẠNG THÁI ĐƠN HÀNG]) VALUES (N'CH1DH2', N'CH1', NULL, N'0965046890', 55000, CAST(N'2020-05-10' AS Date), N'Quận 3', 3)
INSERT [dbo].[DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ CỬA HÀNG], [MÃ NHÂN VIÊN], [MÃ KHÁCH HÀNG(SĐT)], [TỔNG TIỀN], [NGÀY], [ĐỊA CHỈ], [TRẠNG THÁI ĐƠN HÀNG]) VALUES (N'CH1DH3', N'CH1', NULL, N'0363320012', 60000, CAST(N'2020-04-30' AS Date), N'Quận Bình Thạnh', 3)
INSERT [dbo].[DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ CỬA HÀNG], [MÃ NHÂN VIÊN], [MÃ KHÁCH HÀNG(SĐT)], [TỔNG TIỀN], [NGÀY], [ĐỊA CHỈ], [TRẠNG THÁI ĐƠN HÀNG]) VALUES (N'CH1DH4', N'CH1', NULL, N'0363320012', 60000, CAST(N'2020-04-30' AS Date), N'Quận Bình Thạnh', 3)
INSERT [dbo].[DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ CỬA HÀNG], [MÃ NHÂN VIÊN], [MÃ KHÁCH HÀNG(SĐT)], [TỔNG TIỀN], [NGÀY], [ĐỊA CHỈ], [TRẠNG THÁI ĐƠN HÀNG]) VALUES (N'CH1DH5', N'CH1', NULL, N'0363320012', 60000, CAST(N'2020-04-30' AS Date), N'29 quận bình thạnh', 3)
INSERT [dbo].[DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ CỬA HÀNG], [MÃ NHÂN VIÊN], [MÃ KHÁCH HÀNG(SĐT)], [TỔNG TIỀN], [NGÀY], [ĐỊA CHỈ], [TRẠNG THÁI ĐƠN HÀNG]) VALUES (N'CH1DH6', N'CH1', N'', N'0962440227', 65000, CAST(N'2020-06-09' AS Date), N'FDSFDS', 3)
INSERT [dbo].[DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ CỬA HÀNG], [MÃ NHÂN VIÊN], [MÃ KHÁCH HÀNG(SĐT)], [TỔNG TIỀN], [NGÀY], [ĐỊA CHỈ], [TRẠNG THÁI ĐƠN HÀNG]) VALUES (N'ch1DH7', N'ch1', N'ch1nv1', N'0000000000', 35000, CAST(N'2020-06-09' AS Date), N'', 3)
INSERT [dbo].[DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ CỬA HÀNG], [MÃ NHÂN VIÊN], [MÃ KHÁCH HÀNG(SĐT)], [TỔNG TIỀN], [NGÀY], [ĐỊA CHỈ], [TRẠNG THÁI ĐƠN HÀNG]) VALUES (N'ch1DH8', N'ch1', N'ch1nv1', N'0000000000', 35000, CAST(N'2020-06-09' AS Date), N'', 3)
INSERT [dbo].[DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ CỬA HÀNG], [MÃ NHÂN VIÊN], [MÃ KHÁCH HÀNG(SĐT)], [TỔNG TIỀN], [NGÀY], [ĐỊA CHỈ], [TRẠNG THÁI ĐƠN HÀNG]) VALUES (N'CH1DH9', N'CH1', N'', N'0363320012', 75000, CAST(N'2020-06-09' AS Date), N'fdfsd', 3)
INSERT [dbo].[DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ CỬA HÀNG], [MÃ NHÂN VIÊN], [MÃ KHÁCH HÀNG(SĐT)], [TỔNG TIỀN], [NGÀY], [ĐỊA CHỈ], [TRẠNG THÁI ĐƠN HÀNG]) VALUES (N'CH2DH1', N'CH2', NULL, N'0962440227', 60000, CAST(N'2020-04-30' AS Date), N'Quận 2', 3)
INSERT [dbo].[DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ CỬA HÀNG], [MÃ NHÂN VIÊN], [MÃ KHÁCH HÀNG(SĐT)], [TỔNG TIỀN], [NGÀY], [ĐỊA CHỈ], [TRẠNG THÁI ĐƠN HÀNG]) VALUES (N'CH2DH2', N'CH2', N'ch2nv1', N'0363320012', 125000, CAST(N'2020-06-09' AS Date), N'fdsfsdf', 3)
INSERT [dbo].[DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ CỬA HÀNG], [MÃ NHÂN VIÊN], [MÃ KHÁCH HÀNG(SĐT)], [TỔNG TIỀN], [NGÀY], [ĐỊA CHỈ], [TRẠNG THÁI ĐƠN HÀNG]) VALUES (N'CH3DH1', N'CH3', NULL, N'0965046890', 65000, CAST(N'2020-05-12' AS Date), N'Quận 1', 3)
INSERT [dbo].[DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ CỬA HÀNG], [MÃ NHÂN VIÊN], [MÃ KHÁCH HÀNG(SĐT)], [TỔNG TIỀN], [NGÀY], [ĐỊA CHỈ], [TRẠNG THÁI ĐƠN HÀNG]) VALUES (N'CH3DH2 ', N'CH3', NULL, N'0965046890', 65000, CAST(N'2020-05-12' AS Date), N'Quận 1', 3)
INSERT [dbo].[DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ CỬA HÀNG], [MÃ NHÂN VIÊN], [MÃ KHÁCH HÀNG(SĐT)], [TỔNG TIỀN], [NGÀY], [ĐỊA CHỈ], [TRẠNG THÁI ĐƠN HÀNG]) VALUES (N'CH3DH3', N'CH3', N'ch3nv1', N'0363320012', 55000, CAST(N'2020-06-09' AS Date), N'123432', 3)
INSERT [dbo].[DON_DAT_HANG] ([MÃ ĐƠN HÀNG], [MÃ CỬA HÀNG], [MÃ NHÂN VIÊN], [MÃ KHÁCH HÀNG(SĐT)], [TỔNG TIỀN], [NGÀY], [ĐỊA CHỈ], [TRẠNG THÁI ĐƠN HÀNG]) VALUES (N'CH4DH1', N'CH4', N'ch4nv1', N'0363320012', 45000, CAST(N'2020-06-09' AS Date), N'fdsfsd', 3)
GO
INSERT [dbo].[KHACH_HANG] ([TÊN TÀI KHOẢN(SĐT)], [HỌ TÊN], [MÃ TÀI KHOẢN]) VALUES (N'0000000000', N'offline', N'0000000000')
INSERT [dbo].[KHACH_HANG] ([TÊN TÀI KHOẢN(SĐT)], [HỌ TÊN], [MÃ TÀI KHOẢN]) VALUES (N'0363320012', N'Hòa', N'0363320012')
INSERT [dbo].[KHACH_HANG] ([TÊN TÀI KHOẢN(SĐT)], [HỌ TÊN], [MÃ TÀI KHOẢN]) VALUES (N'0828528882', N'va', N'0828528882')
INSERT [dbo].[KHACH_HANG] ([TÊN TÀI KHOẢN(SĐT)], [HỌ TÊN], [MÃ TÀI KHOẢN]) VALUES (N'0962440227', N'Hải', N'0962440227')
INSERT [dbo].[KHACH_HANG] ([TÊN TÀI KHOẢN(SĐT)], [HỌ TÊN], [MÃ TÀI KHOẢN]) VALUES (N'0965046890', N'VA', N'0965046890')
GO
INSERT [dbo].[MON_AN] ([MÃ MÓN ĂN], [TÊN MÓN ĂN], [GIÁ TIỀN], [HÌNH ẢNH]) VALUES (N'AV1', N'Khoai tây chiên bơ', 15000, N'khoai-tay-chien.jpg')
INSERT [dbo].[MON_AN] ([MÃ MÓN ĂN], [TÊN MÓN ĂN], [GIÁ TIỀN], [HÌNH ẢNH]) VALUES (N'AV2', N'Pizza', 20000, N'pizza.jpg')
INSERT [dbo].[MON_AN] ([MÃ MÓN ĂN], [TÊN MÓN ĂN], [GIÁ TIỀN], [HÌNH ẢNH]) VALUES (N'AV3', N'Sandwich', 20000, N'sandwich.jpg')
INSERT [dbo].[MON_AN] ([MÃ MÓN ĂN], [TÊN MÓN ĂN], [GIÁ TIỀN], [HÌNH ẢNH]) VALUES (N'AV4', N'Hamburger', 20000, N'hamburger.jpg')
INSERT [dbo].[MON_AN] ([MÃ MÓN ĂN], [TÊN MÓN ĂN], [GIÁ TIỀN], [HÌNH ẢNH]) VALUES (N'AV5', N'Cá viên chiên', 10000, N'ca-vien-chien.jpg')
INSERT [dbo].[MON_AN] ([MÃ MÓN ĂN], [TÊN MÓN ĂN], [GIÁ TIỀN], [HÌNH ẢNH]) VALUES (N'AV6', N'Gà rán', 10000, N'ga-ran.jpg')
INSERT [dbo].[MON_AN] ([MÃ MÓN ĂN], [TÊN MÓN ĂN], [GIÁ TIỀN], [HÌNH ẢNH]) VALUES (N'AV7', N'Khoai lang lắc', 15000, N'khoai-lang-lac.jpg')
INSERT [dbo].[MON_AN] ([MÃ MÓN ĂN], [TÊN MÓN ĂN], [GIÁ TIỀN], [HÌNH ẢNH]) VALUES (N'CF1', N'Cà phê Mako', 20000, N'ca-phe-mako.png')
INSERT [dbo].[MON_AN] ([MÃ MÓN ĂN], [TÊN MÓN ĂN], [GIÁ TIỀN], [HÌNH ẢNH]) VALUES (N'CF2', N'Đá xay', 15000, N'da-xay.jpg')
INSERT [dbo].[MON_AN] ([MÃ MÓN ĂN], [TÊN MÓN ĂN], [GIÁ TIỀN], [HÌNH ẢNH]) VALUES (N'CF3', N'Cà phê Cabuchino', 20000, N'ca-phe-cabuchino.jpg')
INSERT [dbo].[MON_AN] ([MÃ MÓN ĂN], [TÊN MÓN ĂN], [GIÁ TIỀN], [HÌNH ẢNH]) VALUES (N'CF4', N'Cà phê Espresso', 20000, N'ca-phe-espresso.jpg')
INSERT [dbo].[MON_AN] ([MÃ MÓN ĂN], [TÊN MÓN ĂN], [GIÁ TIỀN], [HÌNH ẢNH]) VALUES (N'CF5', N'Latte machiato', 20000, N'latte-machiato.jpg')
INSERT [dbo].[MON_AN] ([MÃ MÓN ĂN], [TÊN MÓN ĂN], [GIÁ TIỀN], [HÌNH ẢNH]) VALUES (N'DU1', N'Pepsi', 10000, N'pepsi.jpg')
INSERT [dbo].[MON_AN] ([MÃ MÓN ĂN], [TÊN MÓN ĂN], [GIÁ TIỀN], [HÌNH ẢNH]) VALUES (N'DU2', N'Cocacola', 10000, N'cocacola.png')
INSERT [dbo].[MON_AN] ([MÃ MÓN ĂN], [TÊN MÓN ĂN], [GIÁ TIỀN], [HÌNH ẢNH]) VALUES (N'DU3', N'Sprite', 10000, N'sprite.jpg')
INSERT [dbo].[MON_AN] ([MÃ MÓN ĂN], [TÊN MÓN ĂN], [GIÁ TIỀN], [HÌNH ẢNH]) VALUES (N'DU4', N'Sting', 10000, N'string.jpg')
INSERT [dbo].[MON_AN] ([MÃ MÓN ĂN], [TÊN MÓN ĂN], [GIÁ TIỀN], [HÌNH ẢNH]) VALUES (N'DU5', N'Fanta', 10000, N'fanta.jpg')
INSERT [dbo].[MON_AN] ([MÃ MÓN ĂN], [TÊN MÓN ĂN], [GIÁ TIỀN], [HÌNH ẢNH]) VALUES (N'DU6', N'Sevenup', 10000, N'sevenup.jpg')
INSERT [dbo].[MON_AN] ([MÃ MÓN ĂN], [TÊN MÓN ĂN], [GIÁ TIỀN], [HÌNH ẢNH]) VALUES (N'MC1', N'Bún thịt nướng', 25000, N'bun-thit-nuong.jpg')
INSERT [dbo].[MON_AN] ([MÃ MÓN ĂN], [TÊN MÓN ĂN], [GIÁ TIỀN], [HÌNH ẢNH]) VALUES (N'MC2', N'Cơm tấm', 25000, N'com-tam.jpg')
INSERT [dbo].[MON_AN] ([MÃ MÓN ĂN], [TÊN MÓN ĂN], [GIÁ TIỀN], [HÌNH ẢNH]) VALUES (N'MC3', N'Bún riêu', 25000, N'bunrieu.jpg')
INSERT [dbo].[MON_AN] ([MÃ MÓN ĂN], [TÊN MÓN ĂN], [GIÁ TIỀN], [HÌNH ẢNH]) VALUES (N'MC4', N'Bún Bò Huế', 25000, N'bun-bo-hue.jpg')
INSERT [dbo].[MON_AN] ([MÃ MÓN ĂN], [TÊN MÓN ĂN], [GIÁ TIỀN], [HÌNH ẢNH]) VALUES (N'MC5', N'Cơm Gà', 25000, N'com-ga.jpg')
INSERT [dbo].[MON_AN] ([MÃ MÓN ĂN], [TÊN MÓN ĂN], [GIÁ TIỀN], [HÌNH ẢNH]) VALUES (N'MC6', N'Gà sốt me', 25000, N'ga-sot-me.jpg')
GO
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH1', N'AV1', 1)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH1', N'AV2', 98)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH1', N'AV3', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH1', N'AV4', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH1', N'AV5', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH1', N'AV6', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH1', N'AV7', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH1', N'CF1', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH1', N'CF2', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH1', N'CF3', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH1', N'CF4', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH1', N'CF5', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH1', N'DU1', 97)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH1', N'DU2', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH1', N'DU3', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH1', N'DU4', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH1', N'DU5', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH1', N'DU6', 98)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH1', N'MC1', 94)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH1', N'MC2', 97)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH1', N'MC3', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH1', N'MC4', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH1', N'MC5', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH1', N'MC6', 96)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH2', N'AV1', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH2', N'AV2', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH2', N'AV3', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH2', N'AV4', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH2', N'AV5', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH2', N'AV6', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH2', N'AV7', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH2', N'CF1', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH2', N'CF2', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH2', N'CF3', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH2', N'CF4', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH2', N'CF5', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH2', N'DU1', 99)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH2', N'DU2', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH2', N'DU3', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH2', N'DU4', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH2', N'DU5', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH2', N'DU6', 99)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH2', N'MC1', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH2', N'MC2', 99)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH2', N'MC3', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH2', N'MC4', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH2', N'MC5', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH2', N'MC6', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH3', N'AV1', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH3', N'AV2', 99)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH3', N'AV3', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH3', N'AV4', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH3', N'AV5', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH3', N'AV6', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH3', N'AV7', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH3', N'CF1', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH3', N'CF2', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH3', N'CF3', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH3', N'CF4', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH3', N'CF5', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH3', N'DU1', 99)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH3', N'DU2', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH3', N'DU3', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH3', N'DU4', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH3', N'DU5', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH3', N'DU6', 99)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH3', N'MC1', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH3', N'MC2', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH3', N'MC3', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH3', N'MC4', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH3', N'MC5', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH3', N'MC6', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH4', N'AV1', 98)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH4', N'AV2', 97)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH4', N'AV3', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH4', N'AV4', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH4', N'AV5', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH4', N'AV6', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH4', N'AV7', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH4', N'CF1', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH4', N'CF2', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH4', N'CF3', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH4', N'CF4', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH4', N'CF5', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH4', N'DU1', 97)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH4', N'DU2', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH4', N'DU3', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH4', N'DU4', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH4', N'DU5', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH4', N'DU6', 98)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH4', N'MC1', 93)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH4', N'MC2', 98)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH4', N'MC3', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH4', N'MC4', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH4', N'MC5', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH4', N'MC6', 97)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH5', N'AV1', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH5', N'AV2', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH5', N'AV3', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH5', N'AV4', 100)
GO
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH5', N'AV5', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH5', N'AV6', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH5', N'AV7', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH5', N'CF1', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH5', N'CF2', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH5', N'CF3', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH5', N'CF4', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH5', N'CF5', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH5', N'DU1', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH5', N'DU2', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH5', N'DU3', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH5', N'DU4', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH5', N'DU5', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH5', N'DU6', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH5', N'MC1', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH5', N'MC2', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH5', N'MC3', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH5', N'MC4', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH5', N'MC5', 100)
INSERT [dbo].[MON_AN_CUA_HANG] ([MÃ CỬA HÀNG], [MÃ MÓN ĂN], [SỐ LƯỢNG]) VALUES (N'CH5', N'MC6', 100)
GO
INSERT [dbo].[NHAN_VIEN] ([MÃ NHÂN VIÊN], [MÃ CỬA HÀNG], [HỌ TÊN NHÂN VIÊN], [NĂM SINH], [GIỚI TÍNH], [ĐỊA CHỈ], [SỐ ĐIỆN THOẠI], [MÃ TÀI KHOẢN]) VALUES (N'CH1NV1', N'CH1', N'Đỗ Duy Mạnh', 1996, N'Nam', N'Hà Nội', N'123456789', N'CH1NV1')
INSERT [dbo].[NHAN_VIEN] ([MÃ NHÂN VIÊN], [MÃ CỬA HÀNG], [HỌ TÊN NHÂN VIÊN], [NĂM SINH], [GIỚI TÍNH], [ĐỊA CHỈ], [SỐ ĐIỆN THOẠI], [MÃ TÀI KHOẢN]) VALUES (N'CH1NV2', N'CH1', N'Nguyễn Quang Hải', 1990, N'Nam', N'Hà Nội', N'123456789', N'CH1NV2')
INSERT [dbo].[NHAN_VIEN] ([MÃ NHÂN VIÊN], [MÃ CỬA HÀNG], [HỌ TÊN NHÂN VIÊN], [NĂM SINH], [GIỚI TÍNH], [ĐỊA CHỈ], [SỐ ĐIỆN THOẠI], [MÃ TÀI KHOẢN]) VALUES (N'CH1NV3', N'CH1', N'Bùi Tiến Dũng', 1997, N'Nữ', N'Gia Lai', N'123456789', N'CH1NV3')
INSERT [dbo].[NHAN_VIEN] ([MÃ NHÂN VIÊN], [MÃ CỬA HÀNG], [HỌ TÊN NHÂN VIÊN], [NĂM SINH], [GIỚI TÍNH], [ĐỊA CHỈ], [SỐ ĐIỆN THOẠI], [MÃ TÀI KHOẢN]) VALUES (N'CH1NV4', N'CH1', N'Nguyễn Vân Anh', 1999, N'Nữ', N'Hà Nội', N'123456789', N'CH1NV4')
INSERT [dbo].[NHAN_VIEN] ([MÃ NHÂN VIÊN], [MÃ CỬA HÀNG], [HỌ TÊN NHÂN VIÊN], [NĂM SINH], [GIỚI TÍNH], [ĐỊA CHỈ], [SỐ ĐIỆN THOẠI], [MÃ TÀI KHOẢN]) VALUES (N'CH1NV5', N'CH1', N'Đỗ Văn Thảo Duy', 1996, N'Nam', N'Hà Nội', N'123456789', N'CH1NV5')
INSERT [dbo].[NHAN_VIEN] ([MÃ NHÂN VIÊN], [MÃ CỬA HÀNG], [HỌ TÊN NHÂN VIÊN], [NĂM SINH], [GIỚI TÍNH], [ĐỊA CHỈ], [SỐ ĐIỆN THOẠI], [MÃ TÀI KHOẢN]) VALUES (N'CH2NV1', N'CH2', N'Trần Đình Trọng', 1997, N'Nam', N'Hà Nội', N'123456789', N'CH2NV1')
INSERT [dbo].[NHAN_VIEN] ([MÃ NHÂN VIÊN], [MÃ CỬA HÀNG], [HỌ TÊN NHÂN VIÊN], [NĂM SINH], [GIỚI TÍNH], [ĐỊA CHỈ], [SỐ ĐIỆN THOẠI], [MÃ TÀI KHOẢN]) VALUES (N'CH2NV2', N'CH2  ', N'Nguyễn Công Phượng', 1995, N'Nam', N'Gia Lai', N'123456789', N'CH2NV2')
INSERT [dbo].[NHAN_VIEN] ([MÃ NHÂN VIÊN], [MÃ CỬA HÀNG], [HỌ TÊN NHÂN VIÊN], [NĂM SINH], [GIỚI TÍNH], [ĐỊA CHỈ], [SỐ ĐIỆN THOẠI], [MÃ TÀI KHOẢN]) VALUES (N'CH2NV3', N'CH2', N'Đặng Văn Lâm', 1994, N'Nữ', N'Hải Phòng', N'123456789', N'CH2NV3')
INSERT [dbo].[NHAN_VIEN] ([MÃ NHÂN VIÊN], [MÃ CỬA HÀNG], [HỌ TÊN NHÂN VIÊN], [NĂM SINH], [GIỚI TÍNH], [ĐỊA CHỈ], [SỐ ĐIỆN THOẠI], [MÃ TÀI KHOẢN]) VALUES (N'CH3NV1', N'CH3', N'Quế Ngọc Hải', 1993, N'Nam', N'Nghệ An', N'123456789', N'CH3NV1')
INSERT [dbo].[NHAN_VIEN] ([MÃ NHÂN VIÊN], [MÃ CỬA HÀNG], [HỌ TÊN NHÂN VIÊN], [NĂM SINH], [GIỚI TÍNH], [ĐỊA CHỈ], [SỐ ĐIỆN THOẠI], [MÃ TÀI KHOẢN]) VALUES (N'CH3NV2', N'CH3  ', N'Đoàn Văn Hậu', 1999, N'Nam', N'Hà Nội', N'123456789', N'CH3NV2')
INSERT [dbo].[NHAN_VIEN] ([MÃ NHÂN VIÊN], [MÃ CỬA HÀNG], [HỌ TÊN NHÂN VIÊN], [NĂM SINH], [GIỚI TÍNH], [ĐỊA CHỈ], [SỐ ĐIỆN THOẠI], [MÃ TÀI KHOẢN]) VALUES (N'CH4NV1', N'CH4', N'Đỗ Duy Mạnh', 1996, N'Nam', N'Hà Nội', N'123456789', N'CH4NV1')
INSERT [dbo].[NHAN_VIEN] ([MÃ NHÂN VIÊN], [MÃ CỬA HÀNG], [HỌ TÊN NHÂN VIÊN], [NĂM SINH], [GIỚI TÍNH], [ĐỊA CHỈ], [SỐ ĐIỆN THOẠI], [MÃ TÀI KHOẢN]) VALUES (N'CH5NV1', N'CH5', N'Đỗ Duy Mạnh', 1996, N'Nam', N'Hà Nội', N'123456789', N'CH5NV1')
GO
INSERT [dbo].[TAI_KHOAN] ([TÊN TÀI KHOẢN], [MẬT KHẨU], [LOẠI TRUY CẬP]) VALUES (N'0000000000', N'abc', 0)
INSERT [dbo].[TAI_KHOAN] ([TÊN TÀI KHOẢN], [MẬT KHẨU], [LOẠI TRUY CẬP]) VALUES (N'0363320012', N'abc', 3)
INSERT [dbo].[TAI_KHOAN] ([TÊN TÀI KHOẢN], [MẬT KHẨU], [LOẠI TRUY CẬP]) VALUES (N'0828528882', N'abc', 3)
INSERT [dbo].[TAI_KHOAN] ([TÊN TÀI KHOẢN], [MẬT KHẨU], [LOẠI TRUY CẬP]) VALUES (N'0962440227', N'abc', 3)
INSERT [dbo].[TAI_KHOAN] ([TÊN TÀI KHOẢN], [MẬT KHẨU], [LOẠI TRUY CẬP]) VALUES (N'0965046890', N'abc', 3)
INSERT [dbo].[TAI_KHOAN] ([TÊN TÀI KHOẢN], [MẬT KHẨU], [LOẠI TRUY CẬP]) VALUES (N'Admin', N'abc', 1)
INSERT [dbo].[TAI_KHOAN] ([TÊN TÀI KHOẢN], [MẬT KHẨU], [LOẠI TRUY CẬP]) VALUES (N'CH1NV1', N'abc', 2)
INSERT [dbo].[TAI_KHOAN] ([TÊN TÀI KHOẢN], [MẬT KHẨU], [LOẠI TRUY CẬP]) VALUES (N'CH1NV2', N'abc', 2)
INSERT [dbo].[TAI_KHOAN] ([TÊN TÀI KHOẢN], [MẬT KHẨU], [LOẠI TRUY CẬP]) VALUES (N'CH1NV3', N'abc', 2)
INSERT [dbo].[TAI_KHOAN] ([TÊN TÀI KHOẢN], [MẬT KHẨU], [LOẠI TRUY CẬP]) VALUES (N'CH1NV4', N'abc', 2)
INSERT [dbo].[TAI_KHOAN] ([TÊN TÀI KHOẢN], [MẬT KHẨU], [LOẠI TRUY CẬP]) VALUES (N'CH1NV5', N'abc', 2)
INSERT [dbo].[TAI_KHOAN] ([TÊN TÀI KHOẢN], [MẬT KHẨU], [LOẠI TRUY CẬP]) VALUES (N'CH2NV1', N'abc', 2)
INSERT [dbo].[TAI_KHOAN] ([TÊN TÀI KHOẢN], [MẬT KHẨU], [LOẠI TRUY CẬP]) VALUES (N'CH2NV2', N'abc', 2)
INSERT [dbo].[TAI_KHOAN] ([TÊN TÀI KHOẢN], [MẬT KHẨU], [LOẠI TRUY CẬP]) VALUES (N'CH2NV3', N'abc', 2)
INSERT [dbo].[TAI_KHOAN] ([TÊN TÀI KHOẢN], [MẬT KHẨU], [LOẠI TRUY CẬP]) VALUES (N'CH3NV1', N'abc', 2)
INSERT [dbo].[TAI_KHOAN] ([TÊN TÀI KHOẢN], [MẬT KHẨU], [LOẠI TRUY CẬP]) VALUES (N'CH3NV2', N'abc', 2)
INSERT [dbo].[TAI_KHOAN] ([TÊN TÀI KHOẢN], [MẬT KHẨU], [LOẠI TRUY CẬP]) VALUES (N'CH3NV4', N'abc', 2)
INSERT [dbo].[TAI_KHOAN] ([TÊN TÀI KHOẢN], [MẬT KHẨU], [LOẠI TRUY CẬP]) VALUES (N'CH4NV1', N'abc', 2)
INSERT [dbo].[TAI_KHOAN] ([TÊN TÀI KHOẢN], [MẬT KHẨU], [LOẠI TRUY CẬP]) VALUES (N'CH5NV1', N'abc', 2)
GO
ALTER TABLE [dbo].[BAI_DANH_GIA]  WITH CHECK ADD  CONSTRAINT [FK_BAI_DANH_GIA_CUA_HANG] FOREIGN KEY([MÃ CỬA HÀNG])
REFERENCES [dbo].[CUA_HANG] ([MÃ CỬA HÀNG])
GO
ALTER TABLE [dbo].[BAI_DANH_GIA] CHECK CONSTRAINT [FK_BAI_DANH_GIA_CUA_HANG]
GO
ALTER TABLE [dbo].[BAI_DANH_GIA]  WITH NOCHECK ADD  CONSTRAINT [FK_BAI_DANH_GIA_TAI_KHOAN] FOREIGN KEY([MÃ KHÁCH HÀNG])
REFERENCES [dbo].[TAI_KHOAN] ([TÊN TÀI KHOẢN])
GO
ALTER TABLE [dbo].[BAI_DANH_GIA] CHECK CONSTRAINT [FK_BAI_DANH_GIA_TAI_KHOAN]
GO
ALTER TABLE [dbo].[CHI_TIET_DON_DAT_HANG]  WITH CHECK ADD  CONSTRAINT [FK_CHI_TIET_DON_DAT_HANG_DON_DAT_HANG] FOREIGN KEY([MÃ ĐƠN HÀNG])
REFERENCES [dbo].[DON_DAT_HANG] ([MÃ ĐƠN HÀNG])
GO
ALTER TABLE [dbo].[CHI_TIET_DON_DAT_HANG] CHECK CONSTRAINT [FK_CHI_TIET_DON_DAT_HANG_DON_DAT_HANG]
GO
ALTER TABLE [dbo].[DON_DAT_HANG]  WITH CHECK ADD  CONSTRAINT [FK_DON_DAT_HANG_CUA_HANG] FOREIGN KEY([MÃ CỬA HÀNG])
REFERENCES [dbo].[CUA_HANG] ([MÃ CỬA HÀNG])
GO
ALTER TABLE [dbo].[DON_DAT_HANG] CHECK CONSTRAINT [FK_DON_DAT_HANG_CUA_HANG]
GO
ALTER TABLE [dbo].[DON_DAT_HANG]  WITH NOCHECK ADD  CONSTRAINT [FK_DON_DAT_HANG_KHACH_HANG] FOREIGN KEY([MÃ KHÁCH HÀNG(SĐT)])
REFERENCES [dbo].[KHACH_HANG] ([TÊN TÀI KHOẢN(SĐT)])
GO
ALTER TABLE [dbo].[DON_DAT_HANG] CHECK CONSTRAINT [FK_DON_DAT_HANG_KHACH_HANG]
GO
ALTER TABLE [dbo].[DON_DAT_HANG]  WITH CHECK ADD  CONSTRAINT [FK_DON_DAT_HANG_TAI_KHOAN] FOREIGN KEY([MÃ KHÁCH HÀNG(SĐT)])
REFERENCES [dbo].[TAI_KHOAN] ([TÊN TÀI KHOẢN])
GO
ALTER TABLE [dbo].[DON_DAT_HANG] CHECK CONSTRAINT [FK_DON_DAT_HANG_TAI_KHOAN]
GO
ALTER TABLE [dbo].[KHACH_HANG]  WITH CHECK ADD  CONSTRAINT [FK_KHACH_HANG_TAI_KHOAN] FOREIGN KEY([MÃ TÀI KHOẢN])
REFERENCES [dbo].[TAI_KHOAN] ([TÊN TÀI KHOẢN])
GO
ALTER TABLE [dbo].[KHACH_HANG] CHECK CONSTRAINT [FK_KHACH_HANG_TAI_KHOAN]
GO
ALTER TABLE [dbo].[MON_AN_CUA_HANG]  WITH CHECK ADD  CONSTRAINT [FK_MON_AN_CUA_HANG_CUA_HANG] FOREIGN KEY([MÃ CỬA HÀNG])
REFERENCES [dbo].[CUA_HANG] ([MÃ CỬA HÀNG])
GO
ALTER TABLE [dbo].[MON_AN_CUA_HANG] CHECK CONSTRAINT [FK_MON_AN_CUA_HANG_CUA_HANG]
GO
ALTER TABLE [dbo].[MON_AN_CUA_HANG]  WITH CHECK ADD  CONSTRAINT [FK_MON_AN_CUA_HANG_MON_AN] FOREIGN KEY([MÃ MÓN ĂN])
REFERENCES [dbo].[MON_AN] ([MÃ MÓN ĂN])
GO
ALTER TABLE [dbo].[MON_AN_CUA_HANG] CHECK CONSTRAINT [FK_MON_AN_CUA_HANG_MON_AN]
GO
ALTER TABLE [dbo].[NHAN_VIEN]  WITH NOCHECK ADD  CONSTRAINT [FK_NHAN_VIEN_CUA_HANG] FOREIGN KEY([MÃ CỬA HÀNG])
REFERENCES [dbo].[CUA_HANG] ([MÃ CỬA HÀNG])
GO
ALTER TABLE [dbo].[NHAN_VIEN] CHECK CONSTRAINT [FK_NHAN_VIEN_CUA_HANG]
GO
ALTER TABLE [dbo].[NHAN_VIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHAN_VIEN_TAI_KHOAN] FOREIGN KEY([MÃ TÀI KHOẢN])
REFERENCES [dbo].[TAI_KHOAN] ([TÊN TÀI KHOẢN])
GO
ALTER TABLE [dbo].[NHAN_VIEN] CHECK CONSTRAINT [FK_NHAN_VIEN_TAI_KHOAN]
GO
/****** Object:  StoredProcedure [dbo].[USP_CheckDuplicateAcount]    Script Date: 09/06/2020 11:59:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[USP_CheckDuplicateAcount]
@accountNumber nvarchar(10)
as
begin
select [TÊN TÀI KHOẢN] from TAI_KHOAN
where [TÊN TÀI KHOẢN] = @accountNumber
end
GO
/****** Object:  StoredProcedure [dbo].[USP_CheckLoginStopStore]    Script Date: 09/06/2020 11:59:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_CheckLoginStopStore]
@manhanvien nvarchar(10)
as
begin
		select * from 
		(select n.[MÃ NHÂN VIÊN], c.[TRẠNG THÁI HOẠT ĐỘNG] from NHAN_VIEN as n, CUA_HANG as c
		where n.[MÃ CỬA HÀNG]=c.[MÃ CỬA HÀNG] and c.[TRẠNG THÁI HOẠT ĐỘNG]=0) as nt where nt.[MÃ NHÂN VIÊN] = @manhanvien
		

end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetAccountByAccountName]    Script Date: 09/06/2020 11:59:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[USP_GetAccountByAccountName]
@tenTaiKhoan nvarchar(10)
as
begin
	select * From dbo.TAI_KHOAN where [TÊN TÀI KHOẢN]=@tenTaiKhoan
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetAccountByUserName]    Script Date: 09/06/2020 11:59:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[USP_GetAccountByUserName]
@tenTaiKhoan nvarchar(10)
as
begin
	select * From dbo.TAI_KHOAN where [TÊN TÀI KHOẢN]=@tenTaiKhoan
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetFoodList]    Script Date: 09/06/2020 11:59:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	create Proc [dbo].[USP_GetFoodList]
	@type nvarchar(10)
as
begin
	select * from dbo.MON_AN where [MÃ MÓN ĂN] LIKE @type+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetTotalMoneyBill]    Script Date: 09/06/2020 11:59:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_GetTotalMoneyBill]
@ngaybatdau date,
@ngayketthuc date
as
begin
select count([MÃ ĐƠN HÀNG]) as [SỐ LƯỢNG ĐƠN HÀNG], SUM([TỔNG TIỀN]) as [TỔNG DOANH THU] from DON_DAT_HANG
where NGÀY >=  @ngaybatdau and NGÀY <= @ngayketthuc
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetTotalMoneyOfflineBill]    Script Date: 09/06/2020 11:59:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_GetTotalMoneyOfflineBill]
@ngaybatdau date,
@ngayketthuc date
as
begin
select d1.[MÃ CỬA HÀNG], count (d1.[MÃ ĐƠN HÀNG]) as [SỐ LƯỢNG ĐƠN HÀNG], SUM(d1.[TỔNG TIỀN]) as [TỔNG DOANH THU]
from DON_DAT_HANG as d1 where d1.NGÀY >= @ngaybatdau and d1.NGÀY <= @ngayketthuc and [ĐỊA CHỈ]=''
group by [MÃ CỬA HÀNG]
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetTotalMoneyOnlineBill]    Script Date: 09/06/2020 11:59:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_GetTotalMoneyOnlineBill]
@ngaybatdau date,
@ngayketthuc date
as
begin
select d1.[MÃ CỬA HÀNG], count (d1.[MÃ ĐƠN HÀNG]) as [SỐ LƯỢNG ĐƠN HÀNG], SUM(d1.[TỔNG TIỀN]) as [TỔNG DOANH THU]
from DON_DAT_HANG as d1 where d1.NGÀY >= @ngaybatdau and d1.NGÀY <= @ngayketthuc and d1.[ĐỊA CHỈ]!=''
group by [MÃ CỬA HÀNG]
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetTotalMoneyStoreBill]    Script Date: 09/06/2020 11:59:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_GetTotalMoneyStoreBill]
@ngaybatdau date,
@ngayketthuc date
as
begin
select  d1.[MÃ CỬA HÀNG],count (d1.[MÃ ĐƠN HÀNG]) as [SỐ LƯỢNG ĐƠN HÀNG], SUM(d1.[TỔNG TIỀN]) as [TỔNG DOANH THU]
from DON_DAT_HANG as d1 where d1.NGÀY >= @ngaybatdau and d1.NGÀY <= @ngayketthuc
group by [MÃ CỬA HÀNG]
end
GO
/****** Object:  StoredProcedure [dbo].[USP_Login]    Script Date: 09/06/2020 11:59:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[USP_Login]
@tentaikhoan nvarchar(10),
@matkhau nvarchar(50)
as
begin
	select * from dbo.TAI_KHOAN where [TÊN TÀI KHOẢN] = @tentaikhoan and [MẬT KHẨU]=@matkhau
end
GO
/****** Object:  StoredProcedure [dbo].[USP_LoginAccountCustomer]    Script Date: 09/06/2020 11:59:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[USP_LoginAccountCustomer]
@tentaikhoan nvarchar(10),
@matkhau nvarchar(50),
@loaitruycap int
as
begin
	select * from dbo.TAI_KHOAN where [TÊN TÀI KHOẢN] = @tentaikhoan and [MẬT KHẨU]=@matkhau and [LOẠI TRUY CẬP]=@loaitruycap
end
GO
/****** Object:  StoredProcedure [dbo].[USP_LoginAdmin]    Script Date: 09/06/2020 11:59:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[USP_LoginAdmin]
@tentaikhoan nvarchar(10),
@matkhau nvarchar(50)
as
begin
	select * from dbo.TAI_KHOAN where [TÊN TÀI KHOẢN] = @tentaikhoan and [MẬT KHẨU]=@matkhau and [LOẠI TRUY CẬP]=1
end
GO
/****** Object:  StoredProcedure [dbo].[USP_LoginCustomer]    Script Date: 09/06/2020 11:59:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[USP_LoginCustomer]
@tentaikhoan nvarchar(10),
@matkhau nvarchar(50),
@loaitruycap int
as
begin
	select * from dbo.TAI_KHOAN where [TÊN TÀI KHOẢN] = @tentaikhoan and [MẬT KHẨU]=@matkhau and [LOẠI TRUY CẬP]=@loaitruycap
end
GO
/****** Object:  StoredProcedure [dbo].[USP_LoginEmployee]    Script Date: 09/06/2020 11:59:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[USP_LoginEmployee]
@tentaikhoan nvarchar(10),
@matkhau nvarchar(50),
@loaitruycap int
as
begin
	select * from dbo.TAI_KHOAN where [TÊN TÀI KHOẢN] = @tentaikhoan and [MẬT KHẨU]=@matkhau and [LOẠI TRUY CẬP]= @loaitruycap
end
GO
/****** Object:  StoredProcedure [dbo].[USP_LoginManager]    Script Date: 09/06/2020 11:59:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[USP_LoginManager]
@tentaikhoan nvarchar(10),
@matkhau nvarchar(50),
@loaitruycap int
as
begin
	select * from dbo.TAI_KHOAN where [TÊN TÀI KHOẢN] = @tentaikhoan and [MẬT KHẨU]=@matkhau and [LOẠI TRUY CẬP]=@loaitruycap
end
GO
/****** Object:  StoredProcedure [dbo].[USP_LoginStopStore]    Script Date: 09/06/2020 11:59:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_LoginStopStore]
@manhanvien nvarchar(10)
as
begin
		select * from TAI_KHOAN 
		where (Select [MÃ NHÂN VIÊN] From dbo.NHAN_VIEN
		where [MÃ CỬA HÀNG] = (select [MÃ CỬA HÀNG] from CUA_HANG where [TRẠNG THÁI HOẠT ĐỘNG]=0))= @manhanvien

end
GO
/****** Object:  StoredProcedure [dbo].[USP_SelectBill]    Script Date: 09/06/2020 11:59:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_SelectBill]
@madonhang nvarchar(10)
as
begin
		select ch.[TÊN MÓN ĂN], [SỐ LƯỢNG], [SỐ LƯỢNG]*[GIÁ TIỀN] as [THÀNH TIỀN] from CHI_TIET_DON_DAT_HANG as ch, MON_AN as m
		where ch.[TÊN MÓN ĂN] =m.[TÊN MÓN ĂN] 	
		and ch.[MÃ ĐƠN HÀNG]=@madonhang
end
GO
/****** Object:  StoredProcedure [dbo].[USP_SignUpAccountCustomer]    Script Date: 09/06/2020 11:59:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[USP_SignUpAccountCustomer]
@tentaikhoan nvarchar(10),
@matkhau nvarchar(50),
@loaitruycap int
as
begin
	insert dbo.TAI_KHOAN 
		([TÊN TÀI KHOẢN],[MẬT KHẨU],[LOẠI TRUY CẬP])
	values (@tentaikhoan,
			@matkhau,
			@loaitruycap);
end
GO
/****** Object:  StoredProcedure [dbo].[USP_SignUpCustomer]    Script Date: 09/06/2020 11:59:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[USP_SignUpCustomer]
@tentaikhoan nvarchar(10),
@matkhau nvarchar(50),
@loaitruycap int
as
begin
	insert dbo.TAI_KHOAN 
		([TÊN TÀI KHOẢN],[MẬT KHẨU],[LOẠI TRUY CẬP])
	values (@tentaikhoan,
			@matkhau,
			@loaitruycap);
end
GO
/****** Object:  StoredProcedure [dbo].[USP_SignUptoCustomer]    Script Date: 09/06/2020 11:59:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[USP_SignUptoCustomer]
@tentaikhoan nvarchar(10),
@hoten nvarchar(50),
@mataikhoan nvarchar(10)
as
begin
	insert dbo.KHACH_HANG
		([TÊN TÀI KHOẢN(SĐT)],[HỌ TÊN],[MÃ TÀI KHOẢN])
	values (@tentaikhoan,
			@hoten,
			@mataikhoan);
end
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdatePass]    Script Date: 09/06/2020 11:59:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_UpdatePass]
@userName nvarchar(10),
@password nvarchar(50), 
@newPass nvarchar(50)
as 
begin
	declare @isRightPass int = 0
	select @isRightPass = COUNT(*) from dbo.TAI_KHOAN where [TÊN TÀI KHOẢN]= @userName and [MẬt KHẨU]= @password
	if(@isRightPass=1)
	begin
		update dbo.TAI_KHOAN set [MẬT KHẨU] =@newPass where [TÊN TÀI KHOẢN]=@userName
	end
end
GO
