USE [Jat]
GO
ALTER TABLE [dbo].[Avion] DROP CONSTRAINT [FK_Avion_Radnik]
GO
ALTER TABLE [dbo].[Avion] DROP CONSTRAINT [FK_Avion_Odrzavanje]
GO
ALTER TABLE [dbo].[Avion] DROP CONSTRAINT [FK_Avion_Nabavka]
GO
ALTER TABLE [dbo].[Avion] DROP CONSTRAINT [FK_Avion_Hangar]
GO
/****** Object:  Table [dbo].[Radnik]    Script Date: 6/21/2018 2:41:24 PM ******/
DROP TABLE [dbo].[Radnik]
GO
/****** Object:  Table [dbo].[Odrzavanje]    Script Date: 6/21/2018 2:41:24 PM ******/
DROP TABLE [dbo].[Odrzavanje]
GO
/****** Object:  Table [dbo].[Nabavka]    Script Date: 6/21/2018 2:41:24 PM ******/
DROP TABLE [dbo].[Nabavka]
GO
/****** Object:  Table [dbo].[Hangar]    Script Date: 6/21/2018 2:41:24 PM ******/
DROP TABLE [dbo].[Hangar]
GO
/****** Object:  Table [dbo].[Avion]    Script Date: 6/21/2018 2:41:24 PM ******/
DROP TABLE [dbo].[Avion]
GO
USE [master]
GO
/****** Object:  Database [Jat]    Script Date: 6/21/2018 2:41:24 PM ******/
DROP DATABASE [Jat]
GO
/****** Object:  Database [Jat]    Script Date: 6/21/2018 2:41:24 PM ******/
CREATE DATABASE [Jat]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Jat', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Jat.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Jat_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Jat_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Jat] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Jat].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Jat] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Jat] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Jat] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Jat] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Jat] SET ARITHABORT OFF 
GO
ALTER DATABASE [Jat] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Jat] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Jat] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Jat] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Jat] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Jat] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Jat] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Jat] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Jat] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Jat] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Jat] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Jat] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Jat] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Jat] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Jat] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Jat] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Jat] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Jat] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Jat] SET  MULTI_USER 
GO
ALTER DATABASE [Jat] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Jat] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Jat] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Jat] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Jat] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Jat] SET QUERY_STORE = OFF
GO
USE [Jat]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Jat]
GO
/****** Object:  Table [dbo].[Avion]    Script Date: 6/21/2018 2:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Avion](
	[AvionID] [int] NOT NULL,
	[Ime Aviona] [nvarchar](50) NULL,
	[Drzava] [nvarchar](50) NULL,
	[Broj popravki] [int] NULL,
	[RadnikID] [int] NULL,
	[HangarID] [int] NULL,
	[NabavkaID] [int] NULL,
	[OdrzavanjeID] [int] NULL,
 CONSTRAINT [PK_Avion] PRIMARY KEY CLUSTERED 
(
	[AvionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hangar]    Script Date: 6/21/2018 2:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hangar](
	[HangarID] [int] NOT NULL,
	[Broj mesta u hangaru] [int] NULL,
 CONSTRAINT [PK_Hangar] PRIMARY KEY CLUSTERED 
(
	[HangarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nabavka]    Script Date: 6/21/2018 2:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nabavka](
	[NabavkaID] [int] NOT NULL,
	[Naziv dela] [nvarchar](50) NULL,
	[Naziv dela seta] [nvarchar](50) NULL,
 CONSTRAINT [PK_Nabavka] PRIMARY KEY CLUSTERED 
(
	[NabavkaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Odrzavanje]    Script Date: 6/21/2018 2:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Odrzavanje](
	[OdrzavanjeID] [int] NOT NULL,
	[Naziv odrzavanja] [nvarchar](50) NULL,
 CONSTRAINT [PK_Odrzavanje] PRIMARY KEY CLUSTERED 
(
	[OdrzavanjeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Radnik]    Script Date: 6/21/2018 2:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Radnik](
	[RadnikID] [int] NOT NULL,
	[Ime] [nvarchar](50) NULL,
	[Prezime] [nvarchar](50) NULL,
	[Mesto] [nvarchar](50) NULL,
 CONSTRAINT [PK_Radnik] PRIMARY KEY CLUSTERED 
(
	[RadnikID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Avion] ([AvionID], [Ime Aviona], [Drzava], [Broj popravki], [RadnikID], [HangarID], [NabavkaID], [OdrzavanjeID]) VALUES (1, N'Boeing 707', N'Srbija', 4, 1, 3, 4, NULL)
INSERT [dbo].[Avion] ([AvionID], [Ime Aviona], [Drzava], [Broj popravki], [RadnikID], [HangarID], [NabavkaID], [OdrzavanjeID]) VALUES (2, N'Boeing 777', N'Svajcarska', 2, 3, 1, NULL, NULL)
INSERT [dbo].[Avion] ([AvionID], [Ime Aviona], [Drzava], [Broj popravki], [RadnikID], [HangarID], [NabavkaID], [OdrzavanjeID]) VALUES (3, N'Cesna 351', N'Crna Gora', 5, 2, 4, 2, 1)
INSERT [dbo].[Avion] ([AvionID], [Ime Aviona], [Drzava], [Broj popravki], [RadnikID], [HangarID], [NabavkaID], [OdrzavanjeID]) VALUES (4, N'Antonov A3', N'Rusija', 1, 2, 3, 1, NULL)
INSERT [dbo].[Hangar] ([HangarID], [Broj mesta u hangaru]) VALUES (1, 2)
INSERT [dbo].[Hangar] ([HangarID], [Broj mesta u hangaru]) VALUES (2, 1)
INSERT [dbo].[Hangar] ([HangarID], [Broj mesta u hangaru]) VALUES (3, 4)
INSERT [dbo].[Hangar] ([HangarID], [Broj mesta u hangaru]) VALUES (4, 2)
INSERT [dbo].[Nabavka] ([NabavkaID], [Naziv dela], [Naziv dela seta]) VALUES (1, N'Turbina', N'Motor')
INSERT [dbo].[Nabavka] ([NabavkaID], [Naziv dela], [Naziv dela seta]) VALUES (2, N'Zice', N'Elektricna instalacija')
INSERT [dbo].[Nabavka] ([NabavkaID], [Naziv dela], [Naziv dela seta]) VALUES (3, N'Radar', N'Navigacija')
INSERT [dbo].[Nabavka] ([NabavkaID], [Naziv dela], [Naziv dela seta]) VALUES (4, N'Podsklop', N'Krilo')
INSERT [dbo].[Odrzavanje] ([OdrzavanjeID], [Naziv odrzavanja]) VALUES (1, N'Bazno odrzavanje aviona')
INSERT [dbo].[Odrzavanje] ([OdrzavanjeID], [Naziv odrzavanja]) VALUES (2, N'Linijsko odrzavanje aviona')
INSERT [dbo].[Odrzavanje] ([OdrzavanjeID], [Naziv odrzavanja]) VALUES (3, N'Odrzavanje komponenti')
INSERT [dbo].[Odrzavanje] ([OdrzavanjeID], [Naziv odrzavanja]) VALUES (4, N'Kalibracija')
INSERT [dbo].[Odrzavanje] ([OdrzavanjeID], [Naziv odrzavanja]) VALUES (5, N'Ispitivanje materijala')
INSERT [dbo].[Radnik] ([RadnikID], [Ime], [Prezime], [Mesto]) VALUES (1, N'Petar ', N'Petrovic', N'Beograd')
INSERT [dbo].[Radnik] ([RadnikID], [Ime], [Prezime], [Mesto]) VALUES (2, N'Nikola', N'Dragojevic', N'Novi Sad')
INSERT [dbo].[Radnik] ([RadnikID], [Ime], [Prezime], [Mesto]) VALUES (3, N'Milos', N'Djordjevic', N'Sombor')
INSERT [dbo].[Radnik] ([RadnikID], [Ime], [Prezime], [Mesto]) VALUES (4, N'Nemanja', N'Jakovljevic', N'Beograd')
ALTER TABLE [dbo].[Avion]  WITH CHECK ADD  CONSTRAINT [FK_Avion_Hangar] FOREIGN KEY([HangarID])
REFERENCES [dbo].[Hangar] ([HangarID])
GO
ALTER TABLE [dbo].[Avion] CHECK CONSTRAINT [FK_Avion_Hangar]
GO
ALTER TABLE [dbo].[Avion]  WITH CHECK ADD  CONSTRAINT [FK_Avion_Nabavka] FOREIGN KEY([NabavkaID])
REFERENCES [dbo].[Nabavka] ([NabavkaID])
GO
ALTER TABLE [dbo].[Avion] CHECK CONSTRAINT [FK_Avion_Nabavka]
GO
ALTER TABLE [dbo].[Avion]  WITH CHECK ADD  CONSTRAINT [FK_Avion_Odrzavanje] FOREIGN KEY([OdrzavanjeID])
REFERENCES [dbo].[Odrzavanje] ([OdrzavanjeID])
GO
ALTER TABLE [dbo].[Avion] CHECK CONSTRAINT [FK_Avion_Odrzavanje]
GO
ALTER TABLE [dbo].[Avion]  WITH CHECK ADD  CONSTRAINT [FK_Avion_Radnik] FOREIGN KEY([RadnikID])
REFERENCES [dbo].[Radnik] ([RadnikID])
GO
ALTER TABLE [dbo].[Avion] CHECK CONSTRAINT [FK_Avion_Radnik]
GO
USE [master]
GO
ALTER DATABASE [Jat] SET  READ_WRITE 
GO
