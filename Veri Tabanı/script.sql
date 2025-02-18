USE [master]
GO
/****** Object:  Database [GrandUludag]    Script Date: 13.02.2025 15:20:29 ******/
CREATE DATABASE [GrandUludag]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GrandUludag', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\GrandUludag.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GrandUludag_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\GrandUludag_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [GrandUludag] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GrandUludag].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GrandUludag] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GrandUludag] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GrandUludag] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GrandUludag] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GrandUludag] SET ARITHABORT OFF 
GO
ALTER DATABASE [GrandUludag] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GrandUludag] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GrandUludag] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GrandUludag] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GrandUludag] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GrandUludag] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GrandUludag] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GrandUludag] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GrandUludag] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GrandUludag] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GrandUludag] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GrandUludag] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GrandUludag] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GrandUludag] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GrandUludag] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GrandUludag] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GrandUludag] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GrandUludag] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GrandUludag] SET  MULTI_USER 
GO
ALTER DATABASE [GrandUludag] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GrandUludag] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GrandUludag] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GrandUludag] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GrandUludag] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GrandUludag] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [GrandUludag] SET QUERY_STORE = ON
GO
ALTER DATABASE [GrandUludag] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [GrandUludag]
GO
/****** Object:  Table [dbo].[AdminGiris]    Script Date: 13.02.2025 15:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminGiris](
	[Kullanici] [varchar](20) NULL,
	[Sifre] [varchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Faturalar]    Script Date: 13.02.2025 15:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Faturalar](
	[Elektrik] [int] NULL,
	[Su] [int] NULL,
	[İnternet] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mesajlar]    Script Date: 13.02.2025 15:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mesajlar](
	[Mesajid] [int] IDENTITY(1,1) NOT NULL,
	[Adsoyad] [varchar](50) NULL,
	[Mesaj] [varchar](500) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MusteriEkle]    Script Date: 13.02.2025 15:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MusteriEkle](
	[Musteriid] [int] IDENTITY(1,1) NOT NULL,
	[Adi] [varchar](30) NULL,
	[Soyadi] [varchar](30) NULL,
	[Cinsiyet] [varchar](5) NULL,
	[Telefon] [varchar](15) NULL,
	[Mail] [varchar](50) NULL,
	[TC] [varchar](12) NULL,
	[OdaNo] [varchar](5) NULL,
	[Ucret] [int] NULL,
	[GirisTarihi] [date] NULL,
	[CikisTarihi] [date] NULL,
 CONSTRAINT [PK_MusteriEkle] PRIMARY KEY CLUSTERED 
(
	[Musteriid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda301]    Script Date: 13.02.2025 15:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda301](
	[Adi] [nvarchar](50) NULL,
	[Soyadi] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda302]    Script Date: 13.02.2025 15:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda302](
	[Adi] [nvarchar](50) NULL,
	[Soyadi] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda303]    Script Date: 13.02.2025 15:20:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda303](
	[Adi] [nvarchar](50) NULL,
	[Soyadi] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda304]    Script Date: 13.02.2025 15:20:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda304](
	[Adi] [nvarchar](50) NULL,
	[Soyadi] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda305]    Script Date: 13.02.2025 15:20:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda305](
	[Adi] [nvarchar](50) NULL,
	[Soyadi] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda306]    Script Date: 13.02.2025 15:20:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda306](
	[Adi] [nvarchar](50) NULL,
	[Soyadi] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda307]    Script Date: 13.02.2025 15:20:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda307](
	[Adi] [nvarchar](50) NULL,
	[Soyadi] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda308]    Script Date: 13.02.2025 15:20:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda308](
	[Adi] [nvarchar](50) NULL,
	[Soyadi] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oda309]    Script Date: 13.02.2025 15:20:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oda309](
	[Adi] [nvarchar](50) NULL,
	[Soyadi] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stoklar]    Script Date: 13.02.2025 15:20:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stoklar](
	[Gida] [int] NULL,
	[İcecek] [int] NULL,
	[Cerezler] [int] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[AdminGiris] ([Kullanici], [Sifre]) VALUES (N'celal', N'123')
GO
INSERT [dbo].[Faturalar] ([Elektrik], [Su], [İnternet]) VALUES (1000, 2000, 1200)
INSERT [dbo].[Faturalar] ([Elektrik], [Su], [İnternet]) VALUES (4520, 1235, 4575)
INSERT [dbo].[Faturalar] ([Elektrik], [Su], [İnternet]) VALUES (2000, 2000, 2000)
GO
SET IDENTITY_INSERT [dbo].[Mesajlar] ON 

INSERT [dbo].[Mesajlar] ([Mesajid], [Adsoyad], [Mesaj]) VALUES (1, N'Celal Yilmaz', N'Oda servisiniz çok yavas.')
SET IDENTITY_INSERT [dbo].[Mesajlar] OFF
GO
SET IDENTITY_INSERT [dbo].[MusteriEkle] ON 

INSERT [dbo].[MusteriEkle] ([Musteriid], [Adi], [Soyadi], [Cinsiyet], [Telefon], [Mail], [TC], [OdaNo], [Ucret], [GirisTarihi], [CikisTarihi]) VALUES (1, N'Celal', N'Yilmaz', N'Bay', N'(555) 555-5656', N'kartal@gmail.com', N'11111111111', N'307', 8000, CAST(N'2025-01-18' AS Date), CAST(N'2025-01-26' AS Date))
INSERT [dbo].[MusteriEkle] ([Musteriid], [Adi], [Soyadi], [Cinsiyet], [Telefon], [Mail], [TC], [OdaNo], [Ucret], [GirisTarihi], [CikisTarihi]) VALUES (2, N'Davut ', N'Yilmaz', N'Bay', N'(125) 415-1511', N'dfsfsad@gmail.com', N'22323222222', N'304', 2000, CAST(N'2025-01-27' AS Date), CAST(N'2025-01-29' AS Date))
INSERT [dbo].[MusteriEkle] ([Musteriid], [Adi], [Soyadi], [Cinsiyet], [Telefon], [Mail], [TC], [OdaNo], [Ucret], [GirisTarihi], [CikisTarihi]) VALUES (3, N'Ayse', N'Demir', N'Bayan', N'(115) 165-6151', N'asda@gmail.com', N'21231315165', N'301', 4000, CAST(N'2025-01-27' AS Date), CAST(N'2025-01-31' AS Date))
INSERT [dbo].[MusteriEkle] ([Musteriid], [Adi], [Soyadi], [Cinsiyet], [Telefon], [Mail], [TC], [OdaNo], [Ucret], [GirisTarihi], [CikisTarihi]) VALUES (4, N'Büsra', N'Özçelik', N'Bayan', N'(156) 165-1115', N'sade@gmail.com', N'51651515615', N'302', 4000, CAST(N'2025-01-27' AS Date), CAST(N'2025-01-31' AS Date))
INSERT [dbo].[MusteriEkle] ([Musteriid], [Adi], [Soyadi], [Cinsiyet], [Telefon], [Mail], [TC], [OdaNo], [Ucret], [GirisTarihi], [CikisTarihi]) VALUES (5, N'Serenay', N'Yildiz', N'Bayan', N'(121) 351-4651', N'iue@gmail.com', N'41849846546', N'303', 4000, CAST(N'2025-01-27' AS Date), CAST(N'2025-01-31' AS Date))
INSERT [dbo].[MusteriEkle] ([Musteriid], [Adi], [Soyadi], [Cinsiyet], [Telefon], [Mail], [TC], [OdaNo], [Ucret], [GirisTarihi], [CikisTarihi]) VALUES (7, N'Rüya', N'Demir', N'Bayan', N'(121) 351-6848', N'poewq@gmail.com', N'48456464654', N'305', 4000, CAST(N'2025-01-27' AS Date), CAST(N'2025-01-31' AS Date))
INSERT [dbo].[MusteriEkle] ([Musteriid], [Adi], [Soyadi], [Cinsiyet], [Telefon], [Mail], [TC], [OdaNo], [Ucret], [GirisTarihi], [CikisTarihi]) VALUES (8, N'Ferhat', N'Çevik', N'Bay', N'(421) 111-1511', N'sadw@gmail.com', N'32432432433', N'306', 2000, CAST(N'2025-01-27' AS Date), CAST(N'2025-01-29' AS Date))
INSERT [dbo].[MusteriEkle] ([Musteriid], [Adi], [Soyadi], [Cinsiyet], [Telefon], [Mail], [TC], [OdaNo], [Ucret], [GirisTarihi], [CikisTarihi]) VALUES (9, N'Thomas', N'Anderson', N'Bay', N'(548) 232-1565', N'Neo@gmail.com', N'54564564655', N'308', 1700000, CAST(N'2025-02-11' AS Date), CAST(N'2025-02-28' AS Date))
SET IDENTITY_INSERT [dbo].[MusteriEkle] OFF
GO
INSERT [dbo].[Oda301] ([Adi], [Soyadi]) VALUES (N'Ayse', N'Demir')
GO
INSERT [dbo].[Oda302] ([Adi], [Soyadi]) VALUES (N'Büsra', N'Özçelik')
GO
INSERT [dbo].[Oda303] ([Adi], [Soyadi]) VALUES (N'Serenay', N'Çelik')
INSERT [dbo].[Oda303] ([Adi], [Soyadi]) VALUES (N'Serenay', N'Yildiz')
GO
INSERT [dbo].[Oda304] ([Adi], [Soyadi]) VALUES (N'Davut ', N'Yilmaz')
GO
INSERT [dbo].[Oda305] ([Adi], [Soyadi]) VALUES (N'Rüya', N'Demir')
GO
INSERT [dbo].[Oda306] ([Adi], [Soyadi]) VALUES (N'Ferhat', N'Çevik')
GO
INSERT [dbo].[Oda307] ([Adi], [Soyadi]) VALUES (N'Celal', N'Yilmaz')
GO
INSERT [dbo].[Oda308] ([Adi], [Soyadi]) VALUES (N'Thomas', N'Anderson')
GO
INSERT [dbo].[Stoklar] ([Gida], [İcecek], [Cerezler]) VALUES (100, 200, 300)
INSERT [dbo].[Stoklar] ([Gida], [İcecek], [Cerezler]) VALUES (1200, 450, 4552)
INSERT [dbo].[Stoklar] ([Gida], [İcecek], [Cerezler]) VALUES (5000, 4000, 3000)
GO
ALTER TABLE [dbo].[MusteriEkle] ADD  CONSTRAINT [DF_MusteriEkle_GirisTarihi]  DEFAULT (getdate()) FOR [GirisTarihi]
GO
ALTER TABLE [dbo].[MusteriEkle] ADD  CONSTRAINT [DF_MusteriEkle_CikisTarihi]  DEFAULT (getdate()) FOR [CikisTarihi]
GO
USE [master]
GO
ALTER DATABASE [GrandUludag] SET  READ_WRITE 
GO
