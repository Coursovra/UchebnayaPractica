USE [master]
GO
/****** Object:  Database [MPT_UP_02.01_P50_2_18_26]    Script Date: 26.02.2021 16:25:45 ******/
CREATE DATABASE [MPT_UP_02.01_P50_2_18_26]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MPT_UP_02.01_P50_2_18_26', FILENAME = N'D:\SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\MPT_UP_02.01_P50_2_18_26.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MPT_UP_02.01_P50_2_18_26_log', FILENAME = N'D:\SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\MPT_UP_02.01_P50_2_18_26_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [MPT_UP_02.01_P50_2_18_26] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MPT_UP_02.01_P50_2_18_26].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MPT_UP_02.01_P50_2_18_26] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MPT_UP_02.01_P50_2_18_26] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MPT_UP_02.01_P50_2_18_26] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MPT_UP_02.01_P50_2_18_26] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MPT_UP_02.01_P50_2_18_26] SET ARITHABORT OFF 
GO
ALTER DATABASE [MPT_UP_02.01_P50_2_18_26] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MPT_UP_02.01_P50_2_18_26] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MPT_UP_02.01_P50_2_18_26] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MPT_UP_02.01_P50_2_18_26] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MPT_UP_02.01_P50_2_18_26] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MPT_UP_02.01_P50_2_18_26] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MPT_UP_02.01_P50_2_18_26] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MPT_UP_02.01_P50_2_18_26] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MPT_UP_02.01_P50_2_18_26] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MPT_UP_02.01_P50_2_18_26] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MPT_UP_02.01_P50_2_18_26] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MPT_UP_02.01_P50_2_18_26] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MPT_UP_02.01_P50_2_18_26] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MPT_UP_02.01_P50_2_18_26] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MPT_UP_02.01_P50_2_18_26] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MPT_UP_02.01_P50_2_18_26] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MPT_UP_02.01_P50_2_18_26] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MPT_UP_02.01_P50_2_18_26] SET RECOVERY FULL 
GO
ALTER DATABASE [MPT_UP_02.01_P50_2_18_26] SET  MULTI_USER 
GO
ALTER DATABASE [MPT_UP_02.01_P50_2_18_26] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MPT_UP_02.01_P50_2_18_26] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MPT_UP_02.01_P50_2_18_26] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MPT_UP_02.01_P50_2_18_26] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MPT_UP_02.01_P50_2_18_26] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MPT_UP_02.01_P50_2_18_26] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'MPT_UP_02.01_P50_2_18_26', N'ON'
GO
ALTER DATABASE [MPT_UP_02.01_P50_2_18_26] SET QUERY_STORE = OFF
GO
USE [MPT_UP_02.01_P50_2_18_26]
GO
/****** Object:  Table [dbo].[Budget]    Script Date: 26.02.2021 16:25:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Budget](
	[id] [int] NOT NULL,
	[value] [float] NOT NULL,
 CONSTRAINT [PK_Budget] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ceksii_torgovoy_tochki]    Script Date: 26.02.2021 16:25:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ceksii_torgovoy_tochki](
	[Kod_ Ceksii_torgovoy_tochki] [int] IDENTITY(1,1) NOT NULL,
	[Nazvanie_ceksii] [nvarchar](max) NOT NULL,
	[Id_TorgTochka] [int] NOT NULL,
 CONSTRAINT [PK_Ceksii_torgovoy_tochki] PRIMARY KEY CLUSTERED 
(
	[Kod_ Ceksii_torgovoy_tochki] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ceksiya_torgovoy_tochki_Sotrudnik]    Script Date: 26.02.2021 16:25:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ceksiya_torgovoy_tochki_Sotrudnik](
	[Id_Ceksiya_torgovoy_tochki_Sotrudnik] [int] IDENTITY(1,1) NOT NULL,
	[Id_Ceksii_torgovoy_tochki] [int] NOT NULL,
	[Id_Sotrudnik] [int] NOT NULL,
 CONSTRAINT [PK_Ceksiya_torgovoy_tochki_Sotrudnik] PRIMARY KEY CLUSTERED 
(
	[Id_Ceksiya_torgovoy_tochki_Sotrudnik] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ceksiya_Tovar]    Script Date: 26.02.2021 16:25:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ceksiya_Tovar](
	[Id_Ceksiya_Tovar] [int] IDENTITY(1,1) NOT NULL,
	[Id_Seksiya] [int] NOT NULL,
	[Id_Tovar] [int] NOT NULL,
	[Tovar_Kolichestvo] [int] NOT NULL,
 CONSTRAINT [PK_Id_Ceksiya_Tovar] PRIMARY KEY CLUSTERED 
(
	[Id_Ceksiya_Tovar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Check_Product]    Script Date: 26.02.2021 16:25:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Check_Product](
	[Id_Check_Product] [int] IDENTITY(1,1) NOT NULL,
	[IdCheck] [int] NOT NULL,
	[IdProduct] [int] NOT NULL,
	[Tovar_Kolichestvo] [int] NOT NULL,
 CONSTRAINT [PK_Check_Product] PRIMARY KEY CLUSTERED 
(
	[Id_Check_Product] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Chek]    Script Date: 26.02.2021 16:25:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chek](
	[Kod_cheka] [int] IDENTITY(1,1) NOT NULL,
	[Kod_pokupately] [int] NOT NULL,
	[Kod_sotrudnika] [int] NOT NULL,
	[Date] [datetime] NOT NULL,
 CONSTRAINT [PK_Chek] PRIMARY KEY CLUSTERED 
(
	[Kod_cheka] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 26.02.2021 16:25:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[Id_Customer] [int] IDENTITY(1,1) NOT NULL,
	[Name] [ntext] NOT NULL,
	[Surname] [ntext] NOT NULL,
	[SecondName] [ntext] NULL,
	[PhoneNumber] [nvarchar](max) NOT NULL,
	[BirthDate] [date] NOT NULL,
	[DateOfVisit] [datetime] NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[Id_Customer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dolznosty]    Script Date: 26.02.2021 16:25:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dolznosty](
	[Kod_dolznosty] [int] IDENTITY(1,1) NOT NULL,
	[Nazvanie_dolznosty] [nvarchar](max) NOT NULL,
	[Oklad] [float] NOT NULL,
 CONSTRAINT [PK_Dolznosty] PRIMARY KEY CLUSTERED 
(
	[Kod_dolznosty] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Postavchik]    Script Date: 26.02.2021 16:25:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Postavchik](
	[Kod_postavchika] [int] IDENTITY(1,1) NOT NULL,
	[Imy_postavchika] [nvarchar](200) NOT NULL,
	[Gorod_postavchika] [ntext] NOT NULL,
 CONSTRAINT [PK_Postavchik] PRIMARY KEY CLUSTERED 
(
	[Kod_postavchika] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sklad]    Script Date: 26.02.2021 16:25:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sklad](
	[Kod_sklada] [int] IDENTITY(1,1) NOT NULL,
	[Summa_arendnoy_platy] [float] NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Sklad] PRIMARY KEY CLUSTERED 
(
	[Kod_sklada] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sklad_Tovar]    Script Date: 26.02.2021 16:25:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sklad_Tovar](
	[Id_Sklad_Tovar] [int] IDENTITY(1,1) NOT NULL,
	[Id_Sklad] [int] NOT NULL,
	[Id_Tovar] [int] NOT NULL,
	[Kolichestvo_Tovara] [int] NOT NULL,
 CONSTRAINT [PK_Sklad_Tovar] PRIMARY KEY CLUSTERED 
(
	[Id_Sklad_Tovar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sotrudnik]    Script Date: 26.02.2021 16:25:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sotrudnik](
	[Kod_sotrudnika] [int] IDENTITY(1,1) NOT NULL,
	[Familiya] [ntext] NOT NULL,
	[Imy] [ntext] NOT NULL,
	[Otchestvo] [ntext] NULL,
	[Data_rojdeniya] [date] NOT NULL,
	[Nomer_telefona] [varchar](max) NOT NULL,
	[Kod_dolznosty] [int] NOT NULL,
	[Login] [varchar](8) NOT NULL,
	[Parol] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Sotrudnik] PRIMARY KEY CLUSTERED 
(
	[Kod_sotrudnika] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Torgovaya_tochka]    Script Date: 26.02.2021 16:25:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Torgovaya_tochka](
	[Kod_torgovoy_tochki] [int] IDENTITY(1,1) NOT NULL,
	[Plochady_torgovoy_tochki] [int] NOT NULL,
	[Summa_arendy] [float] NOT NULL,
	[Kommunalynie_uslugi] [float] NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Torgovaya_tochka] PRIMARY KEY CLUSTERED 
(
	[Kod_torgovoy_tochki] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TorgTochka_Tovar]    Script Date: 26.02.2021 16:25:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TorgTochka_Tovar](
	[Id_TorgTochka_Tovar] [int] IDENTITY(1,1) NOT NULL,
	[Id_TorgTochka] [int] NOT NULL,
	[Id_Tovar] [int] NOT NULL,
	[Tovar_Kolichestvo] [int] NOT NULL,
 CONSTRAINT [PK_TorgTochka_Tovar] PRIMARY KEY CLUSTERED 
(
	[Id_TorgTochka_Tovar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tovar]    Script Date: 26.02.2021 16:25:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tovar](
	[Kod_tovara] [int] IDENTITY(1,1) NOT NULL,
	[Nazvanie_producta] [ntext] NOT NULL,
	[Sena] [float] NOT NULL,
	[Kod_postavchika] [int] NOT NULL,
 CONSTRAINT [PK_Tovar] PRIMARY KEY CLUSTERED 
(
	[Kod_tovara] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Budget] ([id], [value]) VALUES (0, 37000)
GO
SET IDENTITY_INSERT [dbo].[Ceksii_torgovoy_tochki] ON 

INSERT [dbo].[Ceksii_torgovoy_tochki] ([Kod_ Ceksii_torgovoy_tochki], [Nazvanie_ceksii], [Id_TorgTochka]) VALUES (1, N'Продукты', 1)
INSERT [dbo].[Ceksii_torgovoy_tochki] ([Kod_ Ceksii_torgovoy_tochki], [Nazvanie_ceksii], [Id_TorgTochka]) VALUES (6, N'Продукты', 2)
SET IDENTITY_INSERT [dbo].[Ceksii_torgovoy_tochki] OFF
GO
SET IDENTITY_INSERT [dbo].[Ceksiya_torgovoy_tochki_Sotrudnik] ON 

INSERT [dbo].[Ceksiya_torgovoy_tochki_Sotrudnik] ([Id_Ceksiya_torgovoy_tochki_Sotrudnik], [Id_Ceksii_torgovoy_tochki], [Id_Sotrudnik]) VALUES (5, 1, 5)
INSERT [dbo].[Ceksiya_torgovoy_tochki_Sotrudnik] ([Id_Ceksiya_torgovoy_tochki_Sotrudnik], [Id_Ceksii_torgovoy_tochki], [Id_Sotrudnik]) VALUES (6, 6, 11)
INSERT [dbo].[Ceksiya_torgovoy_tochki_Sotrudnik] ([Id_Ceksiya_torgovoy_tochki_Sotrudnik], [Id_Ceksii_torgovoy_tochki], [Id_Sotrudnik]) VALUES (7, 6, 12)
SET IDENTITY_INSERT [dbo].[Ceksiya_torgovoy_tochki_Sotrudnik] OFF
GO
SET IDENTITY_INSERT [dbo].[Ceksiya_Tovar] ON 

INSERT [dbo].[Ceksiya_Tovar] ([Id_Ceksiya_Tovar], [Id_Seksiya], [Id_Tovar], [Tovar_Kolichestvo]) VALUES (1, 1, 1, 14)
INSERT [dbo].[Ceksiya_Tovar] ([Id_Ceksiya_Tovar], [Id_Seksiya], [Id_Tovar], [Tovar_Kolichestvo]) VALUES (2, 1, 2, 60)
INSERT [dbo].[Ceksiya_Tovar] ([Id_Ceksiya_Tovar], [Id_Seksiya], [Id_Tovar], [Tovar_Kolichestvo]) VALUES (3, 1, 3, 15)
INSERT [dbo].[Ceksiya_Tovar] ([Id_Ceksiya_Tovar], [Id_Seksiya], [Id_Tovar], [Tovar_Kolichestvo]) VALUES (7, 6, 4, 12)
SET IDENTITY_INSERT [dbo].[Ceksiya_Tovar] OFF
GO
SET IDENTITY_INSERT [dbo].[Check_Product] ON 

INSERT [dbo].[Check_Product] ([Id_Check_Product], [IdCheck], [IdProduct], [Tovar_Kolichestvo]) VALUES (80, 59, 1, 50)
INSERT [dbo].[Check_Product] ([Id_Check_Product], [IdCheck], [IdProduct], [Tovar_Kolichestvo]) VALUES (81, 59, 2, 50)
INSERT [dbo].[Check_Product] ([Id_Check_Product], [IdCheck], [IdProduct], [Tovar_Kolichestvo]) VALUES (82, 59, 3, 50)
INSERT [dbo].[Check_Product] ([Id_Check_Product], [IdCheck], [IdProduct], [Tovar_Kolichestvo]) VALUES (83, 60, 1, 10)
INSERT [dbo].[Check_Product] ([Id_Check_Product], [IdCheck], [IdProduct], [Tovar_Kolichestvo]) VALUES (84, 60, 3, 10)
INSERT [dbo].[Check_Product] ([Id_Check_Product], [IdCheck], [IdProduct], [Tovar_Kolichestvo]) VALUES (85, 61, 1, 10)
INSERT [dbo].[Check_Product] ([Id_Check_Product], [IdCheck], [IdProduct], [Tovar_Kolichestvo]) VALUES (86, 62, 1, 10)
INSERT [dbo].[Check_Product] ([Id_Check_Product], [IdCheck], [IdProduct], [Tovar_Kolichestvo]) VALUES (87, 62, 3, 20)
INSERT [dbo].[Check_Product] ([Id_Check_Product], [IdCheck], [IdProduct], [Tovar_Kolichestvo]) VALUES (88, 62, 2, 15)
INSERT [dbo].[Check_Product] ([Id_Check_Product], [IdCheck], [IdProduct], [Tovar_Kolichestvo]) VALUES (89, 63, 1, 5)
INSERT [dbo].[Check_Product] ([Id_Check_Product], [IdCheck], [IdProduct], [Tovar_Kolichestvo]) VALUES (90, 64, 4, 25)
INSERT [dbo].[Check_Product] ([Id_Check_Product], [IdCheck], [IdProduct], [Tovar_Kolichestvo]) VALUES (1090, 1064, 2, 10)
INSERT [dbo].[Check_Product] ([Id_Check_Product], [IdCheck], [IdProduct], [Tovar_Kolichestvo]) VALUES (1091, 1064, 2, 10)
INSERT [dbo].[Check_Product] ([Id_Check_Product], [IdCheck], [IdProduct], [Tovar_Kolichestvo]) VALUES (1092, 1065, 2, 20)
INSERT [dbo].[Check_Product] ([Id_Check_Product], [IdCheck], [IdProduct], [Tovar_Kolichestvo]) VALUES (1093, 1065, 3, 5)
INSERT [dbo].[Check_Product] ([Id_Check_Product], [IdCheck], [IdProduct], [Tovar_Kolichestvo]) VALUES (1094, 1065, 1, 1)
SET IDENTITY_INSERT [dbo].[Check_Product] OFF
GO
SET IDENTITY_INSERT [dbo].[Chek] ON 

INSERT [dbo].[Chek] ([Kod_cheka], [Kod_pokupately], [Kod_sotrudnika], [Date]) VALUES (59, 1, 4, CAST(N'2021-02-23T11:42:01.000' AS DateTime))
INSERT [dbo].[Chek] ([Kod_cheka], [Kod_pokupately], [Kod_sotrudnika], [Date]) VALUES (60, 1, 1, CAST(N'2021-02-23T12:53:36.000' AS DateTime))
INSERT [dbo].[Chek] ([Kod_cheka], [Kod_pokupately], [Kod_sotrudnika], [Date]) VALUES (61, 4, 1, CAST(N'2021-02-23T12:55:13.000' AS DateTime))
INSERT [dbo].[Chek] ([Kod_cheka], [Kod_pokupately], [Kod_sotrudnika], [Date]) VALUES (62, 1, 1, CAST(N'2021-02-23T12:56:28.000' AS DateTime))
INSERT [dbo].[Chek] ([Kod_cheka], [Kod_pokupately], [Kod_sotrudnika], [Date]) VALUES (63, 4, 1, CAST(N'2021-02-23T12:56:49.000' AS DateTime))
INSERT [dbo].[Chek] ([Kod_cheka], [Kod_pokupately], [Kod_sotrudnika], [Date]) VALUES (64, 1, 10, CAST(N'2021-02-23T02:53:09.000' AS DateTime))
INSERT [dbo].[Chek] ([Kod_cheka], [Kod_pokupately], [Kod_sotrudnika], [Date]) VALUES (1064, 1, 5, CAST(N'2021-02-24T01:06:04.000' AS DateTime))
INSERT [dbo].[Chek] ([Kod_cheka], [Kod_pokupately], [Kod_sotrudnika], [Date]) VALUES (1065, 4, 5, CAST(N'2021-02-24T01:06:42.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Chek] OFF
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([Id_Customer], [Name], [Surname], [SecondName], [PhoneNumber], [BirthDate], [DateOfVisit]) VALUES (1, N'Олег', N'Гоголь', N'Владимирович', N'79160345153', CAST(N'1990-02-22' AS Date), CAST(N'2021-02-22T00:00:00.000' AS DateTime))
INSERT [dbo].[Customer] ([Id_Customer], [Name], [Surname], [SecondName], [PhoneNumber], [BirthDate], [DateOfVisit]) VALUES (4, N'Ерофеева', N'Евдокия', N'Егоровна', N'79282271370', CAST(N'1990-02-22' AS Date), CAST(N'2021-02-22T03:19:28.000' AS DateTime))
INSERT [dbo].[Customer] ([Id_Customer], [Name], [Surname], [SecondName], [PhoneNumber], [BirthDate], [DateOfVisit]) VALUES (5, N'Будимир', N'Николаев', N'Станиславович', N'79730996648', CAST(N'1990-06-14' AS Date), CAST(N'2021-02-24T01:07:37.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Dolznosty] ON 

INSERT [dbo].[Dolznosty] ([Kod_dolznosty], [Nazvanie_dolznosty], [Oklad]) VALUES (1, N'Администратор БД', 5000)
INSERT [dbo].[Dolznosty] ([Kod_dolznosty], [Nazvanie_dolznosty], [Oklad]) VALUES (2, N'Администратор торговой точки', 4000)
INSERT [dbo].[Dolznosty] ([Kod_dolznosty], [Nazvanie_dolznosty], [Oklad]) VALUES (3, N'Кладовщик', 2000)
INSERT [dbo].[Dolznosty] ([Kod_dolznosty], [Nazvanie_dolznosty], [Oklad]) VALUES (4, N'Продавец', 2500)
INSERT [dbo].[Dolznosty] ([Kod_dolznosty], [Nazvanie_dolznosty], [Oklad]) VALUES (5, N'Менеджер секций', 3500)
INSERT [dbo].[Dolznosty] ([Kod_dolznosty], [Nazvanie_dolznosty], [Oklad]) VALUES (6, N'Бухгалтер', 4000)
SET IDENTITY_INSERT [dbo].[Dolznosty] OFF
GO
SET IDENTITY_INSERT [dbo].[Postavchik] ON 

INSERT [dbo].[Postavchik] ([Kod_postavchika], [Imy_postavchika], [Gorod_postavchika]) VALUES (6, N'ООО.Поставщик1', N'Моква')
INSERT [dbo].[Postavchik] ([Kod_postavchika], [Imy_postavchika], [Gorod_postavchika]) VALUES (25, N'ООО.Поставщик4', N'Москва')
SET IDENTITY_INSERT [dbo].[Postavchik] OFF
GO
SET IDENTITY_INSERT [dbo].[Sklad] ON 

INSERT [dbo].[Sklad] ([Kod_sklada], [Summa_arendnoy_platy], [Address]) VALUES (1, 10000, N'г. Уруссу, ул. Тенистый проезд, дом 186')
INSERT [dbo].[Sklad] ([Kod_sklada], [Summa_arendnoy_platy], [Address]) VALUES (2, 20000, N'г. Чумикан, ул. Финляндский пер, дом 160')
SET IDENTITY_INSERT [dbo].[Sklad] OFF
GO
SET IDENTITY_INSERT [dbo].[Sklad_Tovar] ON 

INSERT [dbo].[Sklad_Tovar] ([Id_Sklad_Tovar], [Id_Sklad], [Id_Tovar], [Kolichestvo_Tovara]) VALUES (1, 1, 1, 50)
INSERT [dbo].[Sklad_Tovar] ([Id_Sklad_Tovar], [Id_Sklad], [Id_Tovar], [Kolichestvo_Tovara]) VALUES (2, 1, 2, 50)
INSERT [dbo].[Sklad_Tovar] ([Id_Sklad_Tovar], [Id_Sklad], [Id_Tovar], [Kolichestvo_Tovara]) VALUES (4, 1, 3, 50)
INSERT [dbo].[Sklad_Tovar] ([Id_Sklad_Tovar], [Id_Sklad], [Id_Tovar], [Kolichestvo_Tovara]) VALUES (5, 2, 4, 80)
INSERT [dbo].[Sklad_Tovar] ([Id_Sklad_Tovar], [Id_Sklad], [Id_Tovar], [Kolichestvo_Tovara]) VALUES (6, 2, 2, 90)
INSERT [dbo].[Sklad_Tovar] ([Id_Sklad_Tovar], [Id_Sklad], [Id_Tovar], [Kolichestvo_Tovara]) VALUES (7, 1, 4, 30)
SET IDENTITY_INSERT [dbo].[Sklad_Tovar] OFF
GO
SET IDENTITY_INSERT [dbo].[Sotrudnik] ON 

INSERT [dbo].[Sotrudnik] ([Kod_sotrudnika], [Familiya], [Imy], [Otchestvo], [Data_rojdeniya], [Nomer_telefona], [Kod_dolznosty], [Login], [Parol]) VALUES (1, N'Архипова', N'Лариса', N'Сергеевна', CAST(N'1971-12-30' AS Date), N'79476470670', 1, N'LarisaA', N'BvqirmWY2uWH')
INSERT [dbo].[Sotrudnik] ([Kod_sotrudnika], [Familiya], [Imy], [Otchestvo], [Data_rojdeniya], [Nomer_telefona], [Kod_dolznosty], [Login], [Parol]) VALUES (3, N'Химченко', N'Аникита', N'Валерьевич', CAST(N'1975-10-02' AS Date), N'79936391642', 2, N'Anikita', N'LmsYWvamMEjw')
INSERT [dbo].[Sotrudnik] ([Kod_sotrudnika], [Familiya], [Imy], [Otchestvo], [Data_rojdeniya], [Nomer_telefona], [Kod_dolznosty], [Login], [Parol]) VALUES (4, N'Веселков', N'Еремей', N'Святославович', CAST(N'1992-02-04' AS Date), N'79985811781', 3, N'Eremey', N'5UM7a7KiPDpJ')
INSERT [dbo].[Sotrudnik] ([Kod_sotrudnika], [Familiya], [Imy], [Otchestvo], [Data_rojdeniya], [Nomer_telefona], [Kod_dolznosty], [Login], [Parol]) VALUES (5, N'Третьяков', N'Елисей', N'Валентинович', CAST(N'1988-06-29' AS Date), N'79226620176', 4, N'EliseyTr', N'UrtT9Nj4ah0s')
INSERT [dbo].[Sotrudnik] ([Kod_sotrudnika], [Familiya], [Imy], [Otchestvo], [Data_rojdeniya], [Nomer_telefona], [Kod_dolznosty], [Login], [Parol]) VALUES (6, N'Новиков', N'Евсей', N'Константинович', CAST(N'2001-05-21' AS Date), N'79030660474', 5, N'EvseyN', N'kmmCiZib9876')
INSERT [dbo].[Sotrudnik] ([Kod_sotrudnika], [Familiya], [Imy], [Otchestvo], [Data_rojdeniya], [Nomer_telefona], [Kod_dolznosty], [Login], [Parol]) VALUES (7, N'Афанасьева', N'Роза', N'Семеновна', CAST(N'1993-03-03' AS Date), N'79870989673', 6, N'RozaA', N'EDj4TVcvNDzx')
INSERT [dbo].[Sotrudnik] ([Kod_sotrudnika], [Familiya], [Imy], [Otchestvo], [Data_rojdeniya], [Nomer_telefona], [Kod_dolznosty], [Login], [Parol]) VALUES (11, N'Высоцкая', N'Ганна', N'Олеговна', CAST(N'2021-03-15' AS Date), N'79887664813', 4, N'GannaV', N'60iU9EMNpqiI')
INSERT [dbo].[Sotrudnik] ([Kod_sotrudnika], [Familiya], [Imy], [Otchestvo], [Data_rojdeniya], [Nomer_telefona], [Kod_dolznosty], [Login], [Parol]) VALUES (12, N'Орлова', N'Наталья', N'Леонидовна', CAST(N'1995-06-15' AS Date), N'79036357145', 4, N'NatalyaO', N'AME8uqfDHdds')
SET IDENTITY_INSERT [dbo].[Sotrudnik] OFF
GO
SET IDENTITY_INSERT [dbo].[Torgovaya_tochka] ON 

INSERT [dbo].[Torgovaya_tochka] ([Kod_torgovoy_tochki], [Plochady_torgovoy_tochki], [Summa_arendy], [Kommunalynie_uslugi], [Address]) VALUES (1, 500, 5000, 3000, N'г. Кайбицы, ул. Лабораторное ш, дом 95')
INSERT [dbo].[Torgovaya_tochka] ([Kod_torgovoy_tochki], [Plochady_torgovoy_tochki], [Summa_arendy], [Kommunalynie_uslugi], [Address]) VALUES (2, 3000, 20000, 10000, N'г. Казачинское, ул. Победы Московский парк, дом 129')
SET IDENTITY_INSERT [dbo].[Torgovaya_tochka] OFF
GO
SET IDENTITY_INSERT [dbo].[TorgTochka_Tovar] ON 

INSERT [dbo].[TorgTochka_Tovar] ([Id_TorgTochka_Tovar], [Id_TorgTochka], [Id_Tovar], [Tovar_Kolichestvo]) VALUES (1031, 1, 1, 35)
INSERT [dbo].[TorgTochka_Tovar] ([Id_TorgTochka_Tovar], [Id_TorgTochka], [Id_Tovar], [Tovar_Kolichestvo]) VALUES (1032, 2, 4, 3)
INSERT [dbo].[TorgTochka_Tovar] ([Id_TorgTochka_Tovar], [Id_TorgTochka], [Id_Tovar], [Tovar_Kolichestvo]) VALUES (1033, 2, 2, 10)
SET IDENTITY_INSERT [dbo].[TorgTochka_Tovar] OFF
GO
SET IDENTITY_INSERT [dbo].[Tovar] ON 

INSERT [dbo].[Tovar] ([Kod_tovara], [Nazvanie_producta], [Sena], [Kod_postavchika]) VALUES (1, N'Хлеб', 200, 6)
INSERT [dbo].[Tovar] ([Kod_tovara], [Nazvanie_producta], [Sena], [Kod_postavchika]) VALUES (2, N'Вода', 100, 6)
INSERT [dbo].[Tovar] ([Kod_tovara], [Nazvanie_producta], [Sena], [Kod_postavchika]) VALUES (3, N'Масло', 150, 6)
INSERT [dbo].[Tovar] ([Kod_tovara], [Nazvanie_producta], [Sena], [Kod_postavchika]) VALUES (4, N'Манго', 150, 6)
SET IDENTITY_INSERT [dbo].[Tovar] OFF
GO
ALTER TABLE [dbo].[Ceksii_torgovoy_tochki]  WITH CHECK ADD  CONSTRAINT [FK_Ceksii_torgovoy_tochki_Torgovaya_tochka] FOREIGN KEY([Id_TorgTochka])
REFERENCES [dbo].[Torgovaya_tochka] ([Kod_torgovoy_tochki])
GO
ALTER TABLE [dbo].[Ceksii_torgovoy_tochki] CHECK CONSTRAINT [FK_Ceksii_torgovoy_tochki_Torgovaya_tochka]
GO
ALTER TABLE [dbo].[Ceksiya_torgovoy_tochki_Sotrudnik]  WITH CHECK ADD  CONSTRAINT [FK_Ceksiya_torgovoy_tochki_Sotrudnik_Ceksii_torgovoy_tochki] FOREIGN KEY([Id_Ceksii_torgovoy_tochki])
REFERENCES [dbo].[Ceksii_torgovoy_tochki] ([Kod_ Ceksii_torgovoy_tochki])
GO
ALTER TABLE [dbo].[Ceksiya_torgovoy_tochki_Sotrudnik] CHECK CONSTRAINT [FK_Ceksiya_torgovoy_tochki_Sotrudnik_Ceksii_torgovoy_tochki]
GO
ALTER TABLE [dbo].[Ceksiya_torgovoy_tochki_Sotrudnik]  WITH CHECK ADD  CONSTRAINT [FK_Ceksiya_torgovoy_tochki_Sotrudnik_Sotrudnik] FOREIGN KEY([Id_Sotrudnik])
REFERENCES [dbo].[Sotrudnik] ([Kod_sotrudnika])
GO
ALTER TABLE [dbo].[Ceksiya_torgovoy_tochki_Sotrudnik] CHECK CONSTRAINT [FK_Ceksiya_torgovoy_tochki_Sotrudnik_Sotrudnik]
GO
ALTER TABLE [dbo].[Ceksiya_Tovar]  WITH CHECK ADD  CONSTRAINT [FK_Id_Ceksiya_Tovar_Ceksii_torgovoy_tochki] FOREIGN KEY([Id_Seksiya])
REFERENCES [dbo].[Ceksii_torgovoy_tochki] ([Kod_ Ceksii_torgovoy_tochki])
GO
ALTER TABLE [dbo].[Ceksiya_Tovar] CHECK CONSTRAINT [FK_Id_Ceksiya_Tovar_Ceksii_torgovoy_tochki]
GO
ALTER TABLE [dbo].[Ceksiya_Tovar]  WITH CHECK ADD  CONSTRAINT [FK_Id_Ceksiya_Tovar_Tovar] FOREIGN KEY([Id_Tovar])
REFERENCES [dbo].[Tovar] ([Kod_tovara])
GO
ALTER TABLE [dbo].[Ceksiya_Tovar] CHECK CONSTRAINT [FK_Id_Ceksiya_Tovar_Tovar]
GO
ALTER TABLE [dbo].[Check_Product]  WITH CHECK ADD  CONSTRAINT [FK_Check_Product_Tovar] FOREIGN KEY([IdProduct])
REFERENCES [dbo].[Tovar] ([Kod_tovara])
GO
ALTER TABLE [dbo].[Check_Product] CHECK CONSTRAINT [FK_Check_Product_Tovar]
GO
ALTER TABLE [dbo].[Chek]  WITH CHECK ADD  CONSTRAINT [FK_Chek_Pokupateli] FOREIGN KEY([Kod_pokupately])
REFERENCES [dbo].[Customer] ([Id_Customer])
GO
ALTER TABLE [dbo].[Chek] CHECK CONSTRAINT [FK_Chek_Pokupateli]
GO
ALTER TABLE [dbo].[Chek]  WITH CHECK ADD  CONSTRAINT [FK_Chek_Sotrudnik] FOREIGN KEY([Kod_sotrudnika])
REFERENCES [dbo].[Sotrudnik] ([Kod_sotrudnika])
GO
ALTER TABLE [dbo].[Chek] CHECK CONSTRAINT [FK_Chek_Sotrudnik]
GO
ALTER TABLE [dbo].[Sklad_Tovar]  WITH CHECK ADD  CONSTRAINT [FK_Sklad_Tovar_Sklad] FOREIGN KEY([Id_Sklad])
REFERENCES [dbo].[Sklad] ([Kod_sklada])
GO
ALTER TABLE [dbo].[Sklad_Tovar] CHECK CONSTRAINT [FK_Sklad_Tovar_Sklad]
GO
ALTER TABLE [dbo].[Sklad_Tovar]  WITH CHECK ADD  CONSTRAINT [FK_Sklad_Tovar_Tovar] FOREIGN KEY([Id_Tovar])
REFERENCES [dbo].[Tovar] ([Kod_tovara])
GO
ALTER TABLE [dbo].[Sklad_Tovar] CHECK CONSTRAINT [FK_Sklad_Tovar_Tovar]
GO
ALTER TABLE [dbo].[Sotrudnik]  WITH CHECK ADD  CONSTRAINT [FK_Sotrudnik_Dolznosty] FOREIGN KEY([Kod_dolznosty])
REFERENCES [dbo].[Dolznosty] ([Kod_dolznosty])
GO
ALTER TABLE [dbo].[Sotrudnik] CHECK CONSTRAINT [FK_Sotrudnik_Dolznosty]
GO
ALTER TABLE [dbo].[TorgTochka_Tovar]  WITH CHECK ADD  CONSTRAINT [FK_TorgTochka_Tovar_Torgovaya_tochka] FOREIGN KEY([Id_TorgTochka])
REFERENCES [dbo].[Torgovaya_tochka] ([Kod_torgovoy_tochki])
GO
ALTER TABLE [dbo].[TorgTochka_Tovar] CHECK CONSTRAINT [FK_TorgTochka_Tovar_Torgovaya_tochka]
GO
ALTER TABLE [dbo].[TorgTochka_Tovar]  WITH CHECK ADD  CONSTRAINT [FK_TorgTochka_Tovar_Tovar] FOREIGN KEY([Id_Tovar])
REFERENCES [dbo].[Tovar] ([Kod_tovara])
GO
ALTER TABLE [dbo].[TorgTochka_Tovar] CHECK CONSTRAINT [FK_TorgTochka_Tovar_Tovar]
GO
ALTER TABLE [dbo].[Tovar]  WITH CHECK ADD  CONSTRAINT [FK_Tovar_Postavchik] FOREIGN KEY([Kod_postavchika])
REFERENCES [dbo].[Postavchik] ([Kod_postavchika])
GO
ALTER TABLE [dbo].[Tovar] CHECK CONSTRAINT [FK_Tovar_Postavchik]
GO
USE [master]
GO
ALTER DATABASE [MPT_UP_02.01_P50_2_18_26] SET  READ_WRITE 
GO
