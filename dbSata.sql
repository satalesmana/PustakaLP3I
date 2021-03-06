USE [master]
GO
/****** Object:  Database [dbSata]    Script Date: 9/28/2018 7:26:35 PM ******/
CREATE DATABASE [dbSata] ON  PRIMARY 
( NAME = N'dbSata', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\dbSata.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'dbSata_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\dbSata_log.LDF' , SIZE = 504KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [dbSata] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbSata].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbSata] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbSata] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbSata] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbSata] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbSata] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbSata] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [dbSata] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbSata] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbSata] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbSata] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbSata] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbSata] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbSata] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbSata] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbSata] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dbSata] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbSata] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbSata] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbSata] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbSata] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbSata] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbSata] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbSata] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [dbSata] SET  MULTI_USER 
GO
ALTER DATABASE [dbSata] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbSata] SET DB_CHAINING OFF 
GO
USE [dbSata]
GO
/****** Object:  Table [dbo].[buku]    Script Date: 9/28/2018 7:26:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[buku](
	[BukuId] [int] NOT NULL,
	[pengarangId] [int] NULL,
	[penerbit] [char](50) NULL,
	[judul] [char](50) NULL,
	[sinopsis] [text] NULL,
	[stok] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[BukuId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[penerbit]    Script Date: 9/28/2018 7:26:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[penerbit](
	[penerbitId] [int] NOT NULL,
	[NamaPenerbit] [varchar](50) NULL,
	[email] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[penerbitId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pengarang]    Script Date: 9/28/2018 7:26:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pengarang](
	[pengarangId] [int] NOT NULL,
	[NamaPengarang] [char](50) NULL,
	[telpon] [char](50) NULL,
	[email] [char](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[pengarangId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'buku', @level2type=N'COLUMN',@level2name=N'sinopsis'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'buku', @level2type=N'COLUMN',@level2name=N'stok'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'penerbit', @level2type=N'COLUMN',@level2name=N'penerbitId'
GO
USE [master]
GO
ALTER DATABASE [dbSata] SET  READ_WRITE 
GO
