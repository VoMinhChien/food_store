USE [master]
GO
/****** Object:  Database [Asignment_C5]    Script Date: 04/07/2022 11:40:35 SA ******/
CREATE DATABASE [Asignment_C5]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Asignment_C5', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Asignment_C5.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Asignment_C5_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Asignment_C5_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Asignment_C5] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Asignment_C5].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Asignment_C5] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Asignment_C5] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Asignment_C5] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Asignment_C5] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Asignment_C5] SET ARITHABORT OFF 
GO
ALTER DATABASE [Asignment_C5] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Asignment_C5] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Asignment_C5] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Asignment_C5] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Asignment_C5] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Asignment_C5] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Asignment_C5] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Asignment_C5] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Asignment_C5] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Asignment_C5] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Asignment_C5] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Asignment_C5] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Asignment_C5] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Asignment_C5] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Asignment_C5] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Asignment_C5] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [Asignment_C5] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Asignment_C5] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Asignment_C5] SET  MULTI_USER 
GO
ALTER DATABASE [Asignment_C5] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Asignment_C5] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Asignment_C5] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Asignment_C5] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Asignment_C5] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Asignment_C5] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Asignment_C5] SET QUERY_STORE = OFF
GO
USE [Asignment_C5]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 04/07/2022 11:40:36 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CartDetails]    Script Date: 04/07/2022 11:40:36 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CartDetails](
	[CartdetailId] [int] IDENTITY(1,1) NOT NULL,
	[CartID] [int] NOT NULL,
	[FoodId] [int] NOT NULL,
	[FoodName] [nvarchar](max) NOT NULL,
	[FoodMount] [nvarchar](max) NOT NULL,
	[FoodImage] [nvarchar](max) NOT NULL,
	[FoodType] [nvarchar](max) NULL,
	[VAT] [nvarchar](max) NULL,
	[IsDelete] [nvarchar](max) NULL,
 CONSTRAINT [PK_CartDetails] PRIMARY KEY CLUSTERED 
(
	[CartdetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Carts]    Script Date: 04/07/2022 11:40:36 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carts](
	[CardId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[UserFullName] [nvarchar](250) NULL,
	[UserEmail] [varchar](250) NULL,
	[UserPhone] [varchar](15) NULL,
	[UseAddress] [nvarchar](250) NULL,
	[TotalPrice] [float] NOT NULL,
	[CardTocal] [float] NOT NULL,
	[VAT] [float] NOT NULL,
	[PaymentDate] [datetime2](7) NOT NULL,
	[PaymentTypeId] [int] NOT NULL,
	[IsDelete] [bit] NOT NULL,
 CONSTRAINT [PK_Carts] PRIMARY KEY CLUSTERED 
(
	[CardId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CategoryModels]    Script Date: 04/07/2022 11:40:36 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoryModels](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategorName] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_CategoryModels] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Foods]    Script Date: 04/07/2022 11:40:36 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Foods](
	[FoodID] [int] IDENTITY(1,1) NOT NULL,
	[FoodName] [nvarchar](250) NOT NULL,
	[FoodCategory] [int] NOT NULL,
	[FoodPrice] [float] NOT NULL,
	[FoodImage] [nvarchar](max) NOT NULL,
	[FoodType] [nvarchar](250) NOT NULL,
	[CreatDate] [datetime] NOT NULL,
	[ModifyDate] [nvarchar](250) NULL,
	[ModifyBy] [nvarchar](250) NULL,
	[VAT] [float] NOT NULL,
	[IsDelete] [bit] NOT NULL,
 CONSTRAINT [PK_Foods] PRIMARY KEY CLUSTERED 
(
	[FoodID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaymentType]    Script Date: 04/07/2022 11:40:36 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentType](
	[PaymentTypeId] [int] IDENTITY(1,1) NOT NULL,
	[PaymentTypeName] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_PaymentType] PRIMARY KEY CLUSTERED 
(
	[PaymentTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 04/07/2022 11:40:36 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 04/07/2022 11:40:36 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserFullName] [nvarchar](250) NOT NULL,
	[UserEmail] [nvarchar](250) NOT NULL,
	[UserPassWord] [nvarchar](250) NOT NULL,
	[UserGender] [nvarchar](100) NOT NULL,
	[UserBirtday] [datetime] NOT NULL,
	[UserPhone] [varchar](15) NOT NULL,
	[UserAddress] [nvarchar](250) NOT NULL,
	[RoleID] [int] NOT NULL,
	[UserToken] [nvarchar](250) NULL,
	[UserTokenGG] [nvarchar](250) NULL,
	[IsDelete] [bit] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220616050821_asmc5', N'5.0.17')
GO
SET IDENTITY_INSERT [dbo].[CartDetails] ON 

INSERT [dbo].[CartDetails] ([CartdetailId], [CartID], [FoodId], [FoodName], [FoodMount], [FoodImage], [FoodType], [VAT], [IsDelete]) VALUES (2, 2, 22, N'Shusi Hàn Quốc loại 1', N'1', N'shushi1.jpg', N'50000', N'4000', N'False')
INSERT [dbo].[CartDetails] ([CartdetailId], [CartID], [FoodId], [FoodName], [FoodMount], [FoodImage], [FoodType], [VAT], [IsDelete]) VALUES (3, 3, 24, N'Shusi Hàn Quốc loại 4', N'1', N'shushi4.jpg', N'50000', N'4000', N'False')
INSERT [dbo].[CartDetails] ([CartdetailId], [CartID], [FoodId], [FoodName], [FoodMount], [FoodImage], [FoodType], [VAT], [IsDelete]) VALUES (4, 3, 22, N'Shusi Hàn Quốc loại 1', N'1', N'shushi1.jpg', N'50000', N'4000', N'False')
INSERT [dbo].[CartDetails] ([CartdetailId], [CartID], [FoodId], [FoodName], [FoodMount], [FoodImage], [FoodType], [VAT], [IsDelete]) VALUES (5, 4, 22, N'Shusi Hàn Quốc loại 1', N'1', N'shushi1.jpg', N'50000', N'4000', N'False')
INSERT [dbo].[CartDetails] ([CartdetailId], [CartID], [FoodId], [FoodName], [FoodMount], [FoodImage], [FoodType], [VAT], [IsDelete]) VALUES (6, 5, 23, N'Shusi Hàn Quốc loại 2', N'1', N'shushi2.jpg', N'50000', N'4000', N'False')
INSERT [dbo].[CartDetails] ([CartdetailId], [CartID], [FoodId], [FoodName], [FoodMount], [FoodImage], [FoodType], [VAT], [IsDelete]) VALUES (7, 6, 22, N'Shusi Hàn Quốc loại 1', N'1', N'shushi1.jpg', N'50000', N'4000', N'False')
INSERT [dbo].[CartDetails] ([CartdetailId], [CartID], [FoodId], [FoodName], [FoodMount], [FoodImage], [FoodType], [VAT], [IsDelete]) VALUES (8, 6, 23, N'Shusi Hàn Quốc loại 2', N'1', N'shushi2.jpg', N'50000', N'4000', N'False')
SET IDENTITY_INSERT [dbo].[CartDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[Carts] ON 

INSERT [dbo].[Carts] ([CardId], [UserId], [UserFullName], [UserEmail], [UserPhone], [UseAddress], [TotalPrice], [CardTocal], [VAT], [PaymentDate], [PaymentTypeId], [IsDelete]) VALUES (2, 9, N'Võ Minh Chiến', N'minhchienhk38@gmail.com', N'0347221025', N'Hà Tĩnh', 50000, 54000, 4000, CAST(N'2022-06-16T12:47:34.5760000' AS DateTime2), 1, 1)
INSERT [dbo].[Carts] ([CardId], [UserId], [UserFullName], [UserEmail], [UserPhone], [UseAddress], [TotalPrice], [CardTocal], [VAT], [PaymentDate], [PaymentTypeId], [IsDelete]) VALUES (3, 9, N'Võ Minh Chiến', N'minhchienhk38@gmail.com', N'0347221025', N'Hà Tĩnh', 100000, 108000, 8000, CAST(N'2022-06-16T12:48:22.8100000' AS DateTime2), 1, 1)
INSERT [dbo].[Carts] ([CardId], [UserId], [UserFullName], [UserEmail], [UserPhone], [UseAddress], [TotalPrice], [CardTocal], [VAT], [PaymentDate], [PaymentTypeId], [IsDelete]) VALUES (4, 9, N'Võ Minh Chiến', N'minhchienhk38@gmail.com', N'0347221025', N'Hà Tĩnh', 50000, 54000, 4000, CAST(N'2022-06-16T13:13:51.3344092' AS DateTime2), 1, 0)
INSERT [dbo].[Carts] ([CardId], [UserId], [UserFullName], [UserEmail], [UserPhone], [UseAddress], [TotalPrice], [CardTocal], [VAT], [PaymentDate], [PaymentTypeId], [IsDelete]) VALUES (5, 9, N'Võ Minh Chiến', N'minhchienhk38@gmail.com', N'0347221025', N'Hà Tĩnh', 50000, 54000, 4000, CAST(N'2022-06-16T14:04:07.6858393' AS DateTime2), 1, 0)
INSERT [dbo].[Carts] ([CardId], [UserId], [UserFullName], [UserEmail], [UserPhone], [UseAddress], [TotalPrice], [CardTocal], [VAT], [PaymentDate], [PaymentTypeId], [IsDelete]) VALUES (6, 9, N'Võ Minh Chiến', N'minhchienhk38@gmail.com', N'0347221024', N'Hà Tĩnh', 100000, 108000, 8000, CAST(N'2022-06-18T19:44:30.3779531' AS DateTime2), 1, 0)
SET IDENTITY_INSERT [dbo].[Carts] OFF
GO
SET IDENTITY_INSERT [dbo].[CategoryModels] ON 

INSERT [dbo].[CategoryModels] ([CategoryId], [CategorName]) VALUES (1, N'
Desserts')
INSERT [dbo].[CategoryModels] ([CategoryId], [CategorName]) VALUES (2, N'Main dishes')
INSERT [dbo].[CategoryModels] ([CategoryId], [CategorName]) VALUES (3, N'Drinks')
SET IDENTITY_INSERT [dbo].[CategoryModels] OFF
GO
SET IDENTITY_INSERT [dbo].[Foods] ON 

INSERT [dbo].[Foods] ([FoodID], [FoodName], [FoodCategory], [FoodPrice], [FoodImage], [FoodType], [CreatDate], [ModifyDate], [ModifyBy], [VAT], [IsDelete]) VALUES (20, N'Eel Porridge', 2, 35000, N'anhnen.jpg', N'Made from the freshest eels', CAST(N'2022-06-11T17:06:00.000' AS DateTime), N'12/06/2022 12:45:56 SA', NULL, 0.800000011920929, 1)
INSERT [dbo].[Foods] ([FoodID], [FoodName], [FoodCategory], [FoodPrice], [FoodImage], [FoodType], [CreatDate], [ModifyDate], [ModifyBy], [VAT], [IsDelete]) VALUES (21, N'Eel Porridge', 2, 35000, N'Chaoluon.jpg', N'Made from the freshest eels', CAST(N'2022-06-11T17:06:10.000' AS DateTime), N'16/06/2022 3:17:01 CH', N'Sơn', 0.800000011920929, 0)
INSERT [dbo].[Foods] ([FoodID], [FoodName], [FoodCategory], [FoodPrice], [FoodImage], [FoodType], [CreatDate], [ModifyDate], [ModifyBy], [VAT], [IsDelete]) VALUES (22, N'KOREAN Shusi Grade 1', 2, 50000, N'shushi1.jpg', N'
shusi with flavors from JAPAN', CAST(N'2022-06-14T19:39:54.000' AS DateTime), N'15/06/2022 9:10:42 CH', N'2', 0.800000011920929, 0)
INSERT [dbo].[Foods] ([FoodID], [FoodName], [FoodCategory], [FoodPrice], [FoodImage], [FoodType], [CreatDate], [ModifyDate], [ModifyBy], [VAT], [IsDelete]) VALUES (23, N'KOREAN Shusi Grade 2', 2, 50000, N'shushi2.jpg', N'
shusi with flavors from JAPAN', CAST(N'2022-06-14T19:42:06.000' AS DateTime), N'16/06/2022 3:02:25 CH', N'Sơn', 0.800000011920929, 0)
INSERT [dbo].[Foods] ([FoodID], [FoodName], [FoodCategory], [FoodPrice], [FoodImage], [FoodType], [CreatDate], [ModifyDate], [ModifyBy], [VAT], [IsDelete]) VALUES (24, N'KOREAN Shusi Grade 4', 2, 50000, N'shushi4.jpg', N'
shusi with flavors from JAPAN', CAST(N'2022-06-14T19:44:36.000' AS DateTime), NULL, NULL, 0.800000011920929, 0)
INSERT [dbo].[Foods] ([FoodID], [FoodName], [FoodCategory], [FoodPrice], [FoodImage], [FoodType], [CreatDate], [ModifyDate], [ModifyBy], [VAT], [IsDelete]) VALUES (25, N'Shrimp roll', 2, 50000, N'tomcuon.jpg', N'Crispy ram cake with delicious fresh shrimps', CAST(N'2022-06-14T19:45:48.000' AS DateTime), N'15/06/2022 9:10:53 CH', N'2', 0.800000011920929, 0)
INSERT [dbo].[Foods] ([FoodID], [FoodName], [FoodCategory], [FoodPrice], [FoodImage], [FoodType], [CreatDate], [ModifyDate], [ModifyBy], [VAT], [IsDelete]) VALUES (26, N'Mixed soup', 2, 50000, N'shoupthapcam.jpg', N'Soup has many healthy ingredients', CAST(N'2022-06-14T19:47:26.000' AS DateTime), N'14/06/2022 7:50:31 CH', NULL, 0.800000011920929, 0)
INSERT [dbo].[Foods] ([FoodID], [FoodName], [FoodCategory], [FoodPrice], [FoodImage], [FoodType], [CreatDate], [ModifyDate], [ModifyBy], [VAT], [IsDelete]) VALUES (27, N'
Chicken soup', 2, 40000, N'shoupga.jpg', N'Soup made from fresh chickens, no growth stimulants', CAST(N'2022-06-14T19:49:10.000' AS DateTime), NULL, NULL, 0.800000011920929, 0)
INSERT [dbo].[Foods] ([FoodID], [FoodName], [FoodCategory], [FoodPrice], [FoodImage], [FoodType], [CreatDate], [ModifyDate], [ModifyBy], [VAT], [IsDelete]) VALUES (28, N'Flavored Roast Chicken', 2, 95000, N'gaquay1.png', N'Crispy fried chicken with irresistible delicious taste', CAST(N'2022-06-14T19:50:22.000' AS DateTime), NULL, NULL, 0.800000011920929, 0)
INSERT [dbo].[Foods] ([FoodID], [FoodName], [FoodCategory], [FoodPrice], [FoodImage], [FoodType], [CreatDate], [ModifyDate], [ModifyBy], [VAT], [IsDelete]) VALUES (29, N'Five Flavors Ice Cream', 1, 15000, N'kemnguvi.jpg', N'Fresh cream mixed with fresh milk is delicious', CAST(N'2022-06-15T10:09:48.000' AS DateTime), NULL, NULL, 0.800000011920929, 0)
INSERT [dbo].[Foods] ([FoodID], [FoodName], [FoodCategory], [FoodPrice], [FoodImage], [FoodType], [CreatDate], [ModifyDate], [ModifyBy], [VAT], [IsDelete]) VALUES (30, N'Strawberry Ice Cream', 1, 25000, N'banhbonglanvidau.jpg', N'Made from ripe strawberries from Dalat', CAST(N'2022-06-15T10:11:20.000' AS DateTime), NULL, NULL, 0.800000011920929, 0)
INSERT [dbo].[Foods] ([FoodID], [FoodName], [FoodCategory], [FoodPrice], [FoodImage], [FoodType], [CreatDate], [ModifyDate], [ModifyBy], [VAT], [IsDelete]) VALUES (31, N'Mint Cake', 1, 32000, N'banhbonglanbacha.jpg', N'Delicious fresh sponge cake with mint flavor', CAST(N'2022-06-15T10:12:21.000' AS DateTime), NULL, NULL, 0.800000011920929, 0)
INSERT [dbo].[Foods] ([FoodID], [FoodName], [FoodCategory], [FoodPrice], [FoodImage], [FoodType], [CreatDate], [ModifyDate], [ModifyBy], [VAT], [IsDelete]) VALUES (32, N'Italian sponge cake', 1, 53000, N'banhbonglany.jpg', N'Cake with flavor from Italy', CAST(N'2022-06-15T10:14:24.000' AS DateTime), NULL, NULL, 0.800000011920929, 0)
INSERT [dbo].[Foods] ([FoodID], [FoodName], [FoodCategory], [FoodPrice], [FoodImage], [FoodType], [CreatDate], [ModifyDate], [ModifyBy], [VAT], [IsDelete]) VALUES (33, N'Strawberry ice cream special', 1, 64000, N'kemdaudacbiet.jpg', N'Strawberry ice cream with different flavors', CAST(N'2022-06-15T10:15:49.000' AS DateTime), NULL, NULL, 0.800000011920929, 0)
INSERT [dbo].[Foods] ([FoodID], [FoodName], [FoodCategory], [FoodPrice], [FoodImage], [FoodType], [CreatDate], [ModifyDate], [ModifyBy], [VAT], [IsDelete]) VALUES (34, N'Pearl coconut jelly', 1, 36000, N'thachtranchau.jpg', N'delicious chewy pearls in addition to cool pieces of jelly', CAST(N'2022-06-15T10:17:33.000' AS DateTime), NULL, NULL, 0.800000011920929, 0)
INSERT [dbo].[Foods] ([FoodID], [FoodName], [FoodCategory], [FoodPrice], [FoodImage], [FoodType], [CreatDate], [ModifyDate], [ModifyBy], [VAT], [IsDelete]) VALUES (35, N'Pearl coconut jelly', 1, 74000, N'kemdauitali.jpg', N'Strawberry ice cream with flavors from ytalia', CAST(N'2022-06-15T10:18:32.000' AS DateTime), N'15/06/2022 9:05:34 CH', NULL, 0.800000011920929, 0)
INSERT [dbo].[Foods] ([FoodID], [FoodName], [FoodCategory], [FoodPrice], [FoodImage], [FoodType], [CreatDate], [ModifyDate], [ModifyBy], [VAT], [IsDelete]) VALUES (36, N'hi', 1, 50000, N'anhee.jfif', N'Được chế biến từ những con lươn tươi nhất', CAST(N'2022-06-15T20:19:00.000' AS DateTime), NULL, NULL, 0.800000011920929, 1)
INSERT [dbo].[Foods] ([FoodID], [FoodName], [FoodCategory], [FoodPrice], [FoodImage], [FoodType], [CreatDate], [ModifyDate], [ModifyBy], [VAT], [IsDelete]) VALUES (37, N'hi', 1, 35000, N'anhee.jfif', N'những chiếc shusi với hương vị đến từ nhật bản', CAST(N'2022-06-15T20:23:39.000' AS DateTime), NULL, N'2', 0.800000011920929, 1)
INSERT [dbo].[Foods] ([FoodID], [FoodName], [FoodCategory], [FoodPrice], [FoodImage], [FoodType], [CreatDate], [ModifyDate], [ModifyBy], [VAT], [IsDelete]) VALUES (38, N'hi', 1, 35000, N'anhee.jfif', N'Được chế biến từ những con lươn tươi nhất', CAST(N'2022-06-15T20:40:51.000' AS DateTime), NULL, N'2', 0.800000011920929, 1)
INSERT [dbo].[Foods] ([FoodID], [FoodName], [FoodCategory], [FoodPrice], [FoodImage], [FoodType], [CreatDate], [ModifyDate], [ModifyBy], [VAT], [IsDelete]) VALUES (39, N'Strawberry Lemonade', 3, 18000, N'chanhdau.jpg', N'Strawberry flavored water is hard to resist', CAST(N'2022-06-16T14:26:05.000' AS DateTime), NULL, N'11', 0.800000011920929, 0)
INSERT [dbo].[Foods] ([FoodID], [FoodName], [FoodCategory], [FoodPrice], [FoodImage], [FoodType], [CreatDate], [ModifyDate], [ModifyBy], [VAT], [IsDelete]) VALUES (40, N'Apple juice', 3, 23000, N'nuoctao.jpg', N'Pure, unadulterated apple juice', CAST(N'2022-06-16T14:27:02.000' AS DateTime), NULL, N'11', 0.800000011920929, 0)
INSERT [dbo].[Foods] ([FoodID], [FoodName], [FoodCategory], [FoodPrice], [FoodImage], [FoodType], [CreatDate], [ModifyDate], [ModifyBy], [VAT], [IsDelete]) VALUES (41, N'Strawberry Milk Tea', 3, 45000, N'trasuavidau.jpg', N'Milk tea with delicious strawberry flavor', CAST(N'2022-06-16T14:27:52.000' AS DateTime), NULL, N'11', 0.800000011920929, 0)
INSERT [dbo].[Foods] ([FoodID], [FoodName], [FoodCategory], [FoodPrice], [FoodImage], [FoodType], [CreatDate], [ModifyDate], [ModifyBy], [VAT], [IsDelete]) VALUES (42, N'Chocolate Milk Tea', 3, 52000, N'trasuasocola.jpg', N'Milk tea with delicious chocolate flavor', CAST(N'2022-06-16T14:29:12.000' AS DateTime), NULL, N'11', 0.800000011920929, 0)
INSERT [dbo].[Foods] ([FoodID], [FoodName], [FoodCategory], [FoodPrice], [FoodImage], [FoodType], [CreatDate], [ModifyDate], [ModifyBy], [VAT], [IsDelete]) VALUES (43, N'Soda water', 3, 10000, N'soda.jpg', N'Soda water with many different flavors', CAST(N'2022-06-16T14:30:17.000' AS DateTime), NULL, N'11', 0.800000011920929, 0)
SET IDENTITY_INSERT [dbo].[Foods] OFF
GO
SET IDENTITY_INSERT [dbo].[PaymentType] ON 

INSERT [dbo].[PaymentType] ([PaymentTypeId], [PaymentTypeName]) VALUES (1, N'Nhận hàng mới Thanh Toán')
INSERT [dbo].[PaymentType] ([PaymentTypeId], [PaymentTypeName]) VALUES (2, N'Thanh toán trước')
SET IDENTITY_INSERT [dbo].[PaymentType] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([RoleID], [RoleName]) VALUES (1, N'Admin')
INSERT [dbo].[Roles] ([RoleID], [RoleName]) VALUES (2, N'Client')
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserId], [UserFullName], [UserEmail], [UserPassWord], [UserGender], [UserBirtday], [UserPhone], [UserAddress], [RoleID], [UserToken], [UserTokenGG], [IsDelete]) VALUES (9, N'Võ Minh Chiến', N'minhchienhk38@gmail.com', N'E99A18C428CB38D5F260853678922E03', N'Nam', CAST(N'2002-08-22T00:00:00.000' AS DateTime), N'0347221024', N'Hà Tĩnh', 2, NULL, NULL, 0)
INSERT [dbo].[Users] ([UserId], [UserFullName], [UserEmail], [UserPassWord], [UserGender], [UserBirtday], [UserPhone], [UserAddress], [RoleID], [UserToken], [UserTokenGG], [IsDelete]) VALUES (11, N'Sơn', N'Sonnqps18832@fpt.edu.vn', N'E99A18C428CB38D5F260853678922E03', N'Nam', CAST(N'2022-06-15T13:24:00.000' AS DateTime), N'0985624685', N'hồ chí minh', 1, NULL, NULL, 0)
INSERT [dbo].[Users] ([UserId], [UserFullName], [UserEmail], [UserPassWord], [UserGender], [UserBirtday], [UserPhone], [UserAddress], [RoleID], [UserToken], [UserTokenGG], [IsDelete]) VALUES (12, N'phuc', N'phuc@gmail.com', N'E99A18C428CB38D5F260853678922E03', N'Nam', CAST(N'2022-06-14T14:25:00.000' AS DateTime), N'0347221025', N'hồ chí minh', 1, NULL, NULL, 0)
INSERT [dbo].[Users] ([UserId], [UserFullName], [UserEmail], [UserPassWord], [UserGender], [UserBirtday], [UserPhone], [UserAddress], [RoleID], [UserToken], [UserTokenGG], [IsDelete]) VALUES (13, N'Sơn', N'Sonnqps1ffd8832@fpt.edu.vn', N'E99A18C428CB38D5F260853678922E03', N'Nam', CAST(N'2022-06-14T21:33:00.000' AS DateTime), N'0347221025', N'hồ chí minh', 1, NULL, NULL, 0)
INSERT [dbo].[Users] ([UserId], [UserFullName], [UserEmail], [UserPassWord], [UserGender], [UserBirtday], [UserPhone], [UserAddress], [RoleID], [UserToken], [UserTokenGG], [IsDelete]) VALUES (14, N'chiến', N'minhchienhk@gmail.com', N'E99A18C428CB38D5F260853678922E03', N'Nam', CAST(N'2022-06-15T08:07:00.000' AS DateTime), N'0347221025', N'Dĩ An,Bình Dương', 1, NULL, NULL, 0)
INSERT [dbo].[Users] ([UserId], [UserFullName], [UserEmail], [UserPassWord], [UserGender], [UserBirtday], [UserPhone], [UserAddress], [RoleID], [UserToken], [UserTokenGG], [IsDelete]) VALUES (15, N'phuc', N'phucgg@gmail.com', N'E99A18C428CB38D5F260853678922E03', N'Nam', CAST(N'2022-06-15T08:12:00.000' AS DateTime), N'0347221025', N'ht', 1, NULL, NULL, 0)
INSERT [dbo].[Users] ([UserId], [UserFullName], [UserEmail], [UserPassWord], [UserGender], [UserBirtday], [UserPhone], [UserAddress], [RoleID], [UserToken], [UserTokenGG], [IsDelete]) VALUES (17, N'chienkk', N'minhchienhk22@gmail.com', N'E99A18C428CB38D5F260853678922E03', N'Nam', CAST(N'2022-06-16T17:44:50.000' AS DateTime), N'0347221025', N'hồ chí minhh', 2, NULL, NULL, 1)
INSERT [dbo].[Users] ([UserId], [UserFullName], [UserEmail], [UserPassWord], [UserGender], [UserBirtday], [UserPhone], [UserAddress], [RoleID], [UserToken], [UserTokenGG], [IsDelete]) VALUES (19, N'chiến', N'baonaggm@gmail.com', N'E99A18C428CB38D5F260853678922E03', N'Nam', CAST(N'2022-06-18T19:45:41.000' AS DateTime), N'0985624685', N'hồ chí minh', 2, NULL, NULL, 0)
INSERT [dbo].[Users] ([UserId], [UserFullName], [UserEmail], [UserPassWord], [UserGender], [UserBirtday], [UserPhone], [UserAddress], [RoleID], [UserToken], [UserTokenGG], [IsDelete]) VALUES (20, N'chiến', N'minhchienhk3@gmail.com', N'E99A18C428CB38D5F260853678922E03', N'Nam', CAST(N'2022-06-18T19:46:18.000' AS DateTime), N'0347221025', N'hồ chí minh', 2, NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
/****** Object:  Index [IX_CartDetails_CartID]    Script Date: 04/07/2022 11:40:36 SA ******/
CREATE NONCLUSTERED INDEX [IX_CartDetails_CartID] ON [dbo].[CartDetails]
(
	[CartID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CartDetails_FoodId]    Script Date: 04/07/2022 11:40:36 SA ******/
CREATE NONCLUSTERED INDEX [IX_CartDetails_FoodId] ON [dbo].[CartDetails]
(
	[FoodId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Carts_PaymentTypeId]    Script Date: 04/07/2022 11:40:36 SA ******/
CREATE NONCLUSTERED INDEX [IX_Carts_PaymentTypeId] ON [dbo].[Carts]
(
	[PaymentTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Carts_UserId]    Script Date: 04/07/2022 11:40:36 SA ******/
CREATE NONCLUSTERED INDEX [IX_Carts_UserId] ON [dbo].[Carts]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Foods_FoodCategory]    Script Date: 04/07/2022 11:40:36 SA ******/
CREATE NONCLUSTERED INDEX [IX_Foods_FoodCategory] ON [dbo].[Foods]
(
	[FoodCategory] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Users_RoleID]    Script Date: 04/07/2022 11:40:36 SA ******/
CREATE NONCLUSTERED INDEX [IX_Users_RoleID] ON [dbo].[Users]
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CartDetails]  WITH CHECK ADD  CONSTRAINT [FK_CartDetails_Carts_CartID] FOREIGN KEY([CartID])
REFERENCES [dbo].[Carts] ([CardId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CartDetails] CHECK CONSTRAINT [FK_CartDetails_Carts_CartID]
GO
ALTER TABLE [dbo].[CartDetails]  WITH CHECK ADD  CONSTRAINT [FK_CartDetails_Foods_FoodId] FOREIGN KEY([FoodId])
REFERENCES [dbo].[Foods] ([FoodID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CartDetails] CHECK CONSTRAINT [FK_CartDetails_Foods_FoodId]
GO
ALTER TABLE [dbo].[Carts]  WITH CHECK ADD  CONSTRAINT [FK_Carts_PaymentType_PaymentTypeId] FOREIGN KEY([PaymentTypeId])
REFERENCES [dbo].[PaymentType] ([PaymentTypeId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Carts] CHECK CONSTRAINT [FK_Carts_PaymentType_PaymentTypeId]
GO
ALTER TABLE [dbo].[Carts]  WITH CHECK ADD  CONSTRAINT [FK_Carts_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Carts] CHECK CONSTRAINT [FK_Carts_Users_UserId]
GO
ALTER TABLE [dbo].[Foods]  WITH CHECK ADD  CONSTRAINT [FK_Foods_CategoryModels_FoodCategory] FOREIGN KEY([FoodCategory])
REFERENCES [dbo].[CategoryModels] ([CategoryId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Foods] CHECK CONSTRAINT [FK_Foods_CategoryModels_FoodCategory]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles_RoleID] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Roles] ([RoleID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Roles_RoleID]
GO
USE [master]
GO
ALTER DATABASE [Asignment_C5] SET  READ_WRITE 
GO
