USE [master]
GO

/****** Object:  Database [GestorDePacientes]    Script Date: 14/08/2021 21:50:55 ******/
CREATE DATABASE [GestorDePacientes]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GestorDePacientes', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\GestorDePacientes.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GestorDePacientes_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\GestorDePacientes_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GestorDePacientes].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [GestorDePacientes] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [GestorDePacientes] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [GestorDePacientes] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [GestorDePacientes] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [GestorDePacientes] SET ARITHABORT OFF 
GO

ALTER DATABASE [GestorDePacientes] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [GestorDePacientes] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [GestorDePacientes] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [GestorDePacientes] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [GestorDePacientes] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [GestorDePacientes] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [GestorDePacientes] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [GestorDePacientes] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [GestorDePacientes] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [GestorDePacientes] SET  DISABLE_BROKER 
GO

ALTER DATABASE [GestorDePacientes] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [GestorDePacientes] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [GestorDePacientes] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [GestorDePacientes] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [GestorDePacientes] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [GestorDePacientes] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [GestorDePacientes] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [GestorDePacientes] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [GestorDePacientes] SET  MULTI_USER 
GO

ALTER DATABASE [GestorDePacientes] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [GestorDePacientes] SET DB_CHAINING OFF 
GO

ALTER DATABASE [GestorDePacientes] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [GestorDePacientes] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [GestorDePacientes] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [GestorDePacientes] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [GestorDePacientes] SET QUERY_STORE = OFF
GO

ALTER DATABASE [GestorDePacientes] SET  READ_WRITE 
GO

