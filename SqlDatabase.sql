USE [master]
GO
/****** Object:  Database [StockTracking]    Script Date: 13.06.2023 20:28:52 ******/
CREATE DATABASE [StockTracking]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StockTracking', FILENAME = N'C:\Users\HP\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\StockTracking.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'StockTracking_log', FILENAME = N'C:\Users\HP\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\StockTracking.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [StockTracking] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StockTracking].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StockTracking] SET ANSI_NULL_DEFAULT ON 
GO
ALTER DATABASE [StockTracking] SET ANSI_NULLS ON 
GO
ALTER DATABASE [StockTracking] SET ANSI_PADDING ON 
GO
ALTER DATABASE [StockTracking] SET ANSI_WARNINGS ON 
GO
ALTER DATABASE [StockTracking] SET ARITHABORT ON 
GO
ALTER DATABASE [StockTracking] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [StockTracking] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StockTracking] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StockTracking] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StockTracking] SET CURSOR_DEFAULT  LOCAL 
GO
ALTER DATABASE [StockTracking] SET CONCAT_NULL_YIELDS_NULL ON 
GO
ALTER DATABASE [StockTracking] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StockTracking] SET QUOTED_IDENTIFIER ON 
GO
ALTER DATABASE [StockTracking] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StockTracking] SET  DISABLE_BROKER 
GO
ALTER DATABASE [StockTracking] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StockTracking] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StockTracking] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StockTracking] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StockTracking] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StockTracking] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StockTracking] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StockTracking] SET RECOVERY FULL 
GO
ALTER DATABASE [StockTracking] SET  MULTI_USER 
GO
ALTER DATABASE [StockTracking] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StockTracking] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StockTracking] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StockTracking] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [StockTracking] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [StockTracking] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [StockTracking] SET QUERY_STORE = OFF
GO
USE [StockTracking]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 13.06.2023 20:28:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [bigint] NOT NULL,
	[Code] [nvarchar](50) NULL,
	[Name] [nvarchar](150) NULL,
	[Desc] [nvarchar](max) NULL,
	[Amount] [decimal](18, 0) NULL,
	[CreateDate] [datetime2](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SellProduct]    Script Date: 13.06.2023 20:28:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SellProduct](
	[Id] [int] NOT NULL,
	[ProductId] [bigint] NULL,
	[SellDate] [datetime] NULL,
	[SellNumber] [bigint] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UC_SellProduct] UNIQUE NONCLUSTERED 
(
	[SellNumber] ASC,
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StockProduct]    Script Date: 13.06.2023 20:28:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockProduct](
	[Id] [bigint] NOT NULL,
	[ProductId] [bigint] NULL,
	[StockType] [int] NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_StockProduct] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [StockTracking] SET  READ_WRITE 
GO