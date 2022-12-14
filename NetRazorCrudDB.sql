USE [master]
GO
/****** Object:  Database [NetRazorCrudDB]    Script Date: 5/12/2022 19:23:07 ******/
CREATE DATABASE [NetRazorCrudDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'NetRazorCrudDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\NetRazorCrudDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'NetRazorCrudDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\NetRazorCrudDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [NetRazorCrudDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [NetRazorCrudDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [NetRazorCrudDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [NetRazorCrudDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [NetRazorCrudDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [NetRazorCrudDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [NetRazorCrudDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [NetRazorCrudDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [NetRazorCrudDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [NetRazorCrudDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [NetRazorCrudDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [NetRazorCrudDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [NetRazorCrudDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [NetRazorCrudDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [NetRazorCrudDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [NetRazorCrudDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [NetRazorCrudDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [NetRazorCrudDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [NetRazorCrudDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [NetRazorCrudDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [NetRazorCrudDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [NetRazorCrudDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [NetRazorCrudDB] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [NetRazorCrudDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [NetRazorCrudDB] SET RECOVERY FULL 
GO
ALTER DATABASE [NetRazorCrudDB] SET  MULTI_USER 
GO
ALTER DATABASE [NetRazorCrudDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [NetRazorCrudDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [NetRazorCrudDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [NetRazorCrudDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [NetRazorCrudDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [NetRazorCrudDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'NetRazorCrudDB', N'ON'
GO
ALTER DATABASE [NetRazorCrudDB] SET QUERY_STORE = OFF
GO
USE [NetRazorCrudDB]
GO
/****** Object:  User [GS]    Script Date: 5/12/2022 19:23:08 ******/
CREATE USER [GS] FOR LOGIN [GS] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 5/12/2022 19:23:09 ******/
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
/****** Object:  Table [dbo].[Course]    Script Date: 5/12/2022 19:23:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Course_name] [nvarchar](max) NOT NULL,
	[Number_of_classes] [int] NOT NULL,
	[Price] [float] NOT NULL,
	[Creation_date] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Professor]    Script Date: 5/12/2022 19:23:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Professor](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Date_birth] [datetime2](7) NOT NULL,
	[Specialty] [int] NOT NULL,
	[Admission_date] [datetime2](7) NOT NULL,
	[is_eliminated] [bit] NOT NULL,
 CONSTRAINT [PK_Professor] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 5/12/2022 19:23:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Date_birth] [datetime2](7) NOT NULL,
	[number_of_courses] [int] NOT NULL,
	[Admission_date] [datetime2](7) NOT NULL,
	[Admission_hour] [datetime2](7) NOT NULL,
	[Eggres_date] [datetime2](7) NOT NULL,
	[is_eliminated] [bit] NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220828031913_initialMigration', N'6.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220829003749_StudentAndProfessorTables', N'6.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220831212215_boolean_fields', N'6.0.8')
GO
SET IDENTITY_INSERT [dbo].[Course] ON 

INSERT [dbo].[Course] ([Id], [Course_name], [Number_of_classes], [Price], [Creation_date]) VALUES (2, N'Introduccion a la Programación', 25, 4500, CAST(N'2022-08-18T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Course] ([Id], [Course_name], [Number_of_classes], [Price], [Creation_date]) VALUES (5, N'Consultas SQL', 10, 2600, CAST(N'2022-06-09T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Course] ([Id], [Course_name], [Number_of_classes], [Price], [Creation_date]) VALUES (8, N'Diseño y Administracion de Base de Datos', 10, 2500, CAST(N'2022-10-18T13:18:36.4471219' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Course] OFF
GO
SET IDENTITY_INSERT [dbo].[Professor] ON 

INSERT [dbo].[Professor] ([Id], [Name], [Surname], [Date_birth], [Specialty], [Admission_date], [is_eliminated]) VALUES (1, N'Pedro', N'Pérez', CAST(N'1986-03-27T00:00:00.0000000' AS DateTime2), 1, CAST(N'2022-08-28T00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Professor] ([Id], [Name], [Surname], [Date_birth], [Specialty], [Admission_date], [is_eliminated]) VALUES (9, N'Ana Paula', N'Heredia', CAST(N'1997-06-28T23:27:00.0000000' AS DateTime2), 2, CAST(N'2022-10-19T23:28:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Professor] ([Id], [Name], [Surname], [Date_birth], [Specialty], [Admission_date], [is_eliminated]) VALUES (10, N'Joaquin', N'Maer', CAST(N'1990-12-09T09:20:00.0000000' AS DateTime2), 1, CAST(N'2022-10-19T23:29:00.0000000' AS DateTime2), 0)
SET IDENTITY_INSERT [dbo].[Professor] OFF
GO
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([Id], [Name], [Surname], [Date_birth], [number_of_courses], [Admission_date], [Admission_hour], [Eggres_date], [is_eliminated]) VALUES (2, N'Lorena', N'Rodriguez', CAST(N'1998-05-05T16:42:00.0000000' AS DateTime2), 1, CAST(N'2022-08-31T16:42:00.0000000' AS DateTime2), CAST(N'2022-08-31T16:42:00.0000000' AS DateTime2), CAST(N'2022-08-31T16:42:00.0000000' AS DateTime2), 1)
INSERT [dbo].[Student] ([Id], [Name], [Surname], [Date_birth], [number_of_courses], [Admission_date], [Admission_hour], [Eggres_date], [is_eliminated]) VALUES (5, N'Fernando', N'Ibañez', CAST(N'1995-02-02T12:17:00.0000000' AS DateTime2), 2, CAST(N'2021-12-15T12:18:00.0000000' AS DateTime2), CAST(N'2022-12-15T12:18:00.0000000' AS DateTime2), CAST(N'2023-02-17T12:19:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Student] ([Id], [Name], [Surname], [Date_birth], [number_of_courses], [Admission_date], [Admission_hour], [Eggres_date], [is_eliminated]) VALUES (6, N'Juana', N'Martinez', CAST(N'1998-11-09T10:51:00.0000000' AS DateTime2), 3, CAST(N'2022-09-03T10:51:00.0000000' AS DateTime2), CAST(N'2022-09-03T10:51:00.0000000' AS DateTime2), CAST(N'2023-02-06T10:53:00.0000000' AS DateTime2), 1)
INSERT [dbo].[Student] ([Id], [Name], [Surname], [Date_birth], [number_of_courses], [Admission_date], [Admission_hour], [Eggres_date], [is_eliminated]) VALUES (7, N'Francisca', N'Marquez', CAST(N'1992-07-16T11:20:00.0000000' AS DateTime2), 2, CAST(N'2022-10-18T13:20:00.0000000' AS DateTime2), CAST(N'2022-10-18T13:20:00.0000000' AS DateTime2), CAST(N'2022-11-30T16:00:00.0000000' AS DateTime2), 0)
SET IDENTITY_INSERT [dbo].[Student] OFF
GO
ALTER TABLE [dbo].[Professor] ADD  DEFAULT (CONVERT([bit],(0))) FOR [is_eliminated]
GO
ALTER TABLE [dbo].[Student] ADD  DEFAULT (CONVERT([bit],(0))) FOR [is_eliminated]
GO
USE [master]
GO
ALTER DATABASE [NetRazorCrudDB] SET  READ_WRITE 
GO
