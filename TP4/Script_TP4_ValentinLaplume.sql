USE [master]
GO
/****** Object:  Database [TP4_VALENTIN_LAPLUME]    Script Date: 22/11/2021 02:36:16 ******/
CREATE DATABASE [TP4_VALENTIN_LAPLUME]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TP4_VALENTIN_LAPLUME', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TP4_VALENTIN_LAPLUME.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TP4_VALENTIN_LAPLUME_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TP4_VALENTIN_LAPLUME_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TP4_VALENTIN_LAPLUME] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TP4_VALENTIN_LAPLUME].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TP4_VALENTIN_LAPLUME] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TP4_VALENTIN_LAPLUME] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TP4_VALENTIN_LAPLUME] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TP4_VALENTIN_LAPLUME] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TP4_VALENTIN_LAPLUME] SET ARITHABORT OFF 
GO
ALTER DATABASE [TP4_VALENTIN_LAPLUME] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TP4_VALENTIN_LAPLUME] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TP4_VALENTIN_LAPLUME] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TP4_VALENTIN_LAPLUME] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TP4_VALENTIN_LAPLUME] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TP4_VALENTIN_LAPLUME] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TP4_VALENTIN_LAPLUME] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TP4_VALENTIN_LAPLUME] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TP4_VALENTIN_LAPLUME] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TP4_VALENTIN_LAPLUME] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TP4_VALENTIN_LAPLUME] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TP4_VALENTIN_LAPLUME] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TP4_VALENTIN_LAPLUME] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TP4_VALENTIN_LAPLUME] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TP4_VALENTIN_LAPLUME] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TP4_VALENTIN_LAPLUME] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TP4_VALENTIN_LAPLUME] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TP4_VALENTIN_LAPLUME] SET RECOVERY FULL 
GO
ALTER DATABASE [TP4_VALENTIN_LAPLUME] SET  MULTI_USER 
GO
ALTER DATABASE [TP4_VALENTIN_LAPLUME] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TP4_VALENTIN_LAPLUME] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TP4_VALENTIN_LAPLUME] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TP4_VALENTIN_LAPLUME] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TP4_VALENTIN_LAPLUME] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TP4_VALENTIN_LAPLUME] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TP4_VALENTIN_LAPLUME', N'ON'
GO
ALTER DATABASE [TP4_VALENTIN_LAPLUME] SET QUERY_STORE = OFF
GO
USE [TP4_VALENTIN_LAPLUME]
GO
/****** Object:  Table [dbo].[Autos]    Script Date: 22/11/2021 02:36:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Autos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[marca] [int] NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[año] [int] NOT NULL,
	[km] [int] NOT NULL,
	[tipoCombustible] [int] NOT NULL,
	[tipoTransmision] [int] NOT NULL,
	[color] [int] NOT NULL,
	[precio] [float] NOT NULL,
	[cantidadPuertas] [int] NOT NULL,
	[estado] [int] NOT NULL,
 CONSTRAINT [PK_Autos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Camionetas]    Script Date: 22/11/2021 02:36:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Camionetas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[marca] [int] NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[año] [int] NOT NULL,
	[km] [int] NOT NULL,
	[tipoCombustible] [int] NOT NULL,
	[tipoTransmision] [int] NOT NULL,
	[color] [int] NOT NULL,
	[precio] [float] NOT NULL,
	[cantidadPuertas] [int] NOT NULL,
	[estado] [int] NOT NULL,
 CONSTRAINT [PK_Camionetas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Motocicletas]    Script Date: 22/11/2021 02:36:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Motocicletas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[marca] [int] NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[año] [int] NOT NULL,
	[km] [int] NOT NULL,
	[tipoCombustible] [int] NOT NULL,
	[tipoTransmision] [int] NOT NULL,
	[color] [int] NOT NULL,
	[precio] [float] NOT NULL,
	[estado] [int] NOT NULL,
 CONSTRAINT [PK_Motocicletas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Autos] ON 

INSERT [dbo].[Autos] ([id], [marca], [nombre], [año], [km], [tipoCombustible], [tipoTransmision], [color], [precio], [cantidadPuertas], [estado]) VALUES (1, 8, N'A3', 2010, 50000, 0, 0, 0, 2000000, 3, 1)
INSERT [dbo].[Autos] ([id], [marca], [nombre], [año], [km], [tipoCombustible], [tipoTransmision], [color], [precio], [cantidadPuertas], [estado]) VALUES (2, 1, N'500', 2013, 50000, 0, 0, 1, 1500000, 3, 1)
INSERT [dbo].[Autos] ([id], [marca], [nombre], [año], [km], [tipoCombustible], [tipoTransmision], [color], [precio], [cantidadPuertas], [estado]) VALUES (3, 0, N'Fox Msi', 2015, 30000, 0, 0, 4, 1400000, 5, 1)
INSERT [dbo].[Autos] ([id], [marca], [nombre], [año], [km], [tipoCombustible], [tipoTransmision], [color], [precio], [cantidadPuertas], [estado]) VALUES (4, 0, N'Fox', 2010, 127000, 0, 0, 2, 900000, 3, 1)
INSERT [dbo].[Autos] ([id], [marca], [nombre], [año], [km], [tipoCombustible], [tipoTransmision], [color], [precio], [cantidadPuertas], [estado]) VALUES (5, 9, N'Smart', 2011, 56000, 3, 1, 8, 1650000, 3, 1)
INSERT [dbo].[Autos] ([id], [marca], [nombre], [año], [km], [tipoCombustible], [tipoTransmision], [color], [precio], [cantidadPuertas], [estado]) VALUES (6, 9, N'Smart', 2015, 26000, 3, 0, 5, 1950000, 3, 1)
INSERT [dbo].[Autos] ([id], [marca], [nombre], [año], [km], [tipoCombustible], [tipoTransmision], [color], [precio], [cantidadPuertas], [estado]) VALUES (7, 1, N'Palio', 2011, 126000, 2, 0, 3, 850000, 5, 1)
INSERT [dbo].[Autos] ([id], [marca], [nombre], [año], [km], [tipoCombustible], [tipoTransmision], [color], [precio], [cantidadPuertas], [estado]) VALUES (8, 1, N'147', 1990, 150000, 2, 0, 1, 150000, 3, 1)
INSERT [dbo].[Autos] ([id], [marca], [nombre], [año], [km], [tipoCombustible], [tipoTransmision], [color], [precio], [cantidadPuertas], [estado]) VALUES (9, 1, N'Uno', 2001, 120000, 0, 0, 4, 500000, 3, 1)
INSERT [dbo].[Autos] ([id], [marca], [nombre], [año], [km], [tipoCombustible], [tipoTransmision], [color], [precio], [cantidadPuertas], [estado]) VALUES (10, 1, N'Duna', 2004, 170000, 2, 0, 1, 350000, 5, 1)
INSERT [dbo].[Autos] ([id], [marca], [nombre], [año], [km], [tipoCombustible], [tipoTransmision], [color], [precio], [cantidadPuertas], [estado]) VALUES (11, 1, N'500', 2013, 103000, 0, 0, 0, 1340000, 3, 1)
INSERT [dbo].[Autos] ([id], [marca], [nombre], [año], [km], [tipoCombustible], [tipoTransmision], [color], [precio], [cantidadPuertas], [estado]) VALUES (12, 2, N'Corsa', 2003, 155000, 2, 0, 3, 350000, 3, 1)
INSERT [dbo].[Autos] ([id], [marca], [nombre], [año], [km], [tipoCombustible], [tipoTransmision], [color], [precio], [cantidadPuertas], [estado]) VALUES (13, 4, N'207 GTI', 2011, 75000, 0, 0, 1, 1350000, 3, 1)
INSERT [dbo].[Autos] ([id], [marca], [nombre], [año], [km], [tipoCombustible], [tipoTransmision], [color], [precio], [cantidadPuertas], [estado]) VALUES (14, 3, N'Logan', 2009, 145000, 2, 0, 0, 600000, 5, 1)
INSERT [dbo].[Autos] ([id], [marca], [nombre], [año], [km], [tipoCombustible], [tipoTransmision], [color], [precio], [cantidadPuertas], [estado]) VALUES (15, 3, N'12', 1998, 130000, 0, 0, 8, 200000, 5, 1)
INSERT [dbo].[Autos] ([id], [marca], [nombre], [año], [km], [tipoCombustible], [tipoTransmision], [color], [precio], [cantidadPuertas], [estado]) VALUES (16, 4, N'208 Feline', 2019, 101000, 0, 0, 1, 2300000, 5, 1)
INSERT [dbo].[Autos] ([id], [marca], [nombre], [año], [km], [tipoCombustible], [tipoTransmision], [color], [precio], [cantidadPuertas], [estado]) VALUES (19, 4, N'208 Allure', 2013, 110000, 0, 0, 3, 1350000, 5, 1)
INSERT [dbo].[Autos] ([id], [marca], [nombre], [año], [km], [tipoCombustible], [tipoTransmision], [color], [precio], [cantidadPuertas], [estado]) VALUES (20, 5, N'Fiesta Titanium', 2021, 0, 0, 0, 3, 2100000, 3, 1)
INSERT [dbo].[Autos] ([id], [marca], [nombre], [año], [km], [tipoCombustible], [tipoTransmision], [color], [precio], [cantidadPuertas], [estado]) VALUES (21, 6, N'InsertarAuto_Test', 2021, 0, 0, 0, 5, 250000, 3, 1)
SET IDENTITY_INSERT [dbo].[Autos] OFF
GO
SET IDENTITY_INSERT [dbo].[Camionetas] ON 

INSERT [dbo].[Camionetas] ([id], [marca], [nombre], [año], [km], [tipoCombustible], [tipoTransmision], [color], [precio], [cantidadPuertas], [estado]) VALUES (1, 0, N'Amarok', 2014, 50000, 1, 1, 2, 2200000, 5, 1)
INSERT [dbo].[Camionetas] ([id], [marca], [nombre], [año], [km], [tipoCombustible], [tipoTransmision], [color], [precio], [cantidadPuertas], [estado]) VALUES (2, 11, N'X6', 2011, 30000, 0, 0, 3, 3500000, 5, 1)
INSERT [dbo].[Camionetas] ([id], [marca], [nombre], [año], [km], [tipoCombustible], [tipoTransmision], [color], [precio], [cantidadPuertas], [estado]) VALUES (3, 5, N'Ranger', 2014, 80000, 0, 0, 1, 2700000, 5, 1)
INSERT [dbo].[Camionetas] ([id], [marca], [nombre], [año], [km], [tipoCombustible], [tipoTransmision], [color], [precio], [cantidadPuertas], [estado]) VALUES (4, 5, N'Ranger', 2017, 35000, 0, 0, 0, 3000000, 5, 1)
INSERT [dbo].[Camionetas] ([id], [marca], [nombre], [año], [km], [tipoCombustible], [tipoTransmision], [color], [precio], [cantidadPuertas], [estado]) VALUES (5, 10, N'Renegade', 2017, 60000, 0, 0, 2, 2600000, 5, 1)
INSERT [dbo].[Camionetas] ([id], [marca], [nombre], [año], [km], [tipoCombustible], [tipoTransmision], [color], [precio], [cantidadPuertas], [estado]) VALUES (6, 1, N'Toro', 2019, 5000, 2, 1, 6, 2300000, 5, 1)
INSERT [dbo].[Camionetas] ([id], [marca], [nombre], [año], [km], [tipoCombustible], [tipoTransmision], [color], [precio], [cantidadPuertas], [estado]) VALUES (7, 4, N'Partner', 2006, 145000, 0, 0, 2, 600000, 3, 1)
INSERT [dbo].[Camionetas] ([id], [marca], [nombre], [año], [km], [tipoCombustible], [tipoTransmision], [color], [precio], [cantidadPuertas], [estado]) VALUES (8, 3, N'Kangoo', 2004, 156000, 0, 0, 7, 560000, 3, 1)
INSERT [dbo].[Camionetas] ([id], [marca], [nombre], [año], [km], [tipoCombustible], [tipoTransmision], [color], [precio], [cantidadPuertas], [estado]) VALUES (9, 5, N'Ranger', 2005, 135000, 1, 0, 4, 850000, 3, 1)
INSERT [dbo].[Camionetas] ([id], [marca], [nombre], [año], [km], [tipoCombustible], [tipoTransmision], [color], [precio], [cantidadPuertas], [estado]) VALUES (11, 10, N'Renegade', 2021, 0, 0, 1, 8, 2500000, 3, 1)
INSERT [dbo].[Camionetas] ([id], [marca], [nombre], [año], [km], [tipoCombustible], [tipoTransmision], [color], [precio], [cantidadPuertas], [estado]) VALUES (14, 0, N'aasdasda', 2020, 2, 0, 0, 0, 2, 3, 0)
SET IDENTITY_INSERT [dbo].[Camionetas] OFF
GO
SET IDENTITY_INSERT [dbo].[Motocicletas] ON 

INSERT [dbo].[Motocicletas] ([id], [marca], [nombre], [año], [km], [tipoCombustible], [tipoTransmision], [color], [precio], [estado]) VALUES (1, 3, N'Cg Titan', 2019, 10000, 0, 0, 0, 360000, 1)
INSERT [dbo].[Motocicletas] ([id], [marca], [nombre], [año], [km], [tipoCombustible], [tipoTransmision], [color], [precio], [estado]) VALUES (2, 3, N'Cb', 2019, 1300, 0, 0, 4, 350000, 1)
INSERT [dbo].[Motocicletas] ([id], [marca], [nombre], [año], [km], [tipoCombustible], [tipoTransmision], [color], [precio], [estado]) VALUES (3, 6, N'Dominar', 2021, 0, 0, 0, 7, 825000, 1)
INSERT [dbo].[Motocicletas] ([id], [marca], [nombre], [año], [km], [tipoCombustible], [tipoTransmision], [color], [precio], [estado]) VALUES (4, 5, N'Ninja', 2021, 0, 0, 0, 9, 2400000, 1)
INSERT [dbo].[Motocicletas] ([id], [marca], [nombre], [año], [km], [tipoCombustible], [tipoTransmision], [color], [precio], [estado]) VALUES (5, 5, N'Z400', 2021, 0, 0, 0, 2, 2000000, 1)
INSERT [dbo].[Motocicletas] ([id], [marca], [nombre], [año], [km], [tipoCombustible], [tipoTransmision], [color], [precio], [estado]) VALUES (6, 3, N'Biz', 2021, 0, 0, 1, 4, 250000, 1)
INSERT [dbo].[Motocicletas] ([id], [marca], [nombre], [año], [km], [tipoCombustible], [tipoTransmision], [color], [precio], [estado]) VALUES (7, 1, N'AX 100', 2009, 12000, 0, 0, 4, 150000, 1)
INSERT [dbo].[Motocicletas] ([id], [marca], [nombre], [año], [km], [tipoCombustible], [tipoTransmision], [color], [precio], [estado]) VALUES (8, 2, N'RC 200', 2019, 6000, 0, 0, 5, 700000, 1)
INSERT [dbo].[Motocicletas] ([id], [marca], [nombre], [año], [km], [tipoCombustible], [tipoTransmision], [color], [precio], [estado]) VALUES (9, 2, N'DUKE', 2014, 16000, 0, 0, 0, 450000, 1)
INSERT [dbo].[Motocicletas] ([id], [marca], [nombre], [año], [km], [tipoCombustible], [tipoTransmision], [color], [precio], [estado]) VALUES (10, 3, N'Titan', 2010, 12000, 0, 0, 0, 350000, 1)
SET IDENTITY_INSERT [dbo].[Motocicletas] OFF
GO
USE [master]
GO
ALTER DATABASE [TP4_VALENTIN_LAPLUME] SET  READ_WRITE 
GO
