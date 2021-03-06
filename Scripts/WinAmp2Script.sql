USE [master]
GO
/****** Object:  Database [PlayListsProject]    Script Date: 10/02/2017 8:12:36 a. m. ******/
CREATE DATABASE [PlayListsProject]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PlayListsProject', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\PlayListsProject.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'PlayListsProject_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\PlayListsProject_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [PlayListsProject] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PlayListsProject].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PlayListsProject] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PlayListsProject] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PlayListsProject] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PlayListsProject] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PlayListsProject] SET ARITHABORT OFF 
GO
ALTER DATABASE [PlayListsProject] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PlayListsProject] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PlayListsProject] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PlayListsProject] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PlayListsProject] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PlayListsProject] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PlayListsProject] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PlayListsProject] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PlayListsProject] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PlayListsProject] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PlayListsProject] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PlayListsProject] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PlayListsProject] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PlayListsProject] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PlayListsProject] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PlayListsProject] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PlayListsProject] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PlayListsProject] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PlayListsProject] SET  MULTI_USER 
GO
ALTER DATABASE [PlayListsProject] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PlayListsProject] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PlayListsProject] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PlayListsProject] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [PlayListsProject] SET DELAYED_DURABILITY = DISABLED 
GO
USE [PlayListsProject]
GO
/****** Object:  User [PlayListProjectUser]    Script Date: 10/02/2017 8:12:36 a. m. ******/
CREATE USER [PlayListProjectUser] FOR LOGIN [PlayListProjectUser] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [PlayListProjectUser]
GO
ALTER ROLE [db_datareader] ADD MEMBER [PlayListProjectUser]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [PlayListProjectUser]
GO
/****** Object:  Table [dbo].[Album]    Script Date: 10/02/2017 8:12:36 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Album](
	[IdAlbum] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Album] PRIMARY KEY CLUSTERED 
(
	[IdAlbum] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AlbumSongArtist]    Script Date: 10/02/2017 8:12:36 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AlbumSongArtist](
	[IdAlbumSong] [int] IDENTITY(1,1) NOT NULL,
	[IdAlbum] [int] NOT NULL,
	[IdSong] [int] NOT NULL,
	[IdArtist] [int] NOT NULL,
 CONSTRAINT [PK_AlbumSongArtist] PRIMARY KEY CLUSTERED 
(
	[IdAlbumSong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Artist]    Script Date: 10/02/2017 8:12:36 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Artist](
	[IdArtist] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NULL,
	[Nationality] [nvarchar](50) NULL,
 CONSTRAINT [PK_Artista] PRIMARY KEY CLUSTERED 
(
	[IdArtist] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Genre]    Script Date: 10/02/2017 8:12:36 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genre](
	[IdGenre] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Genero] PRIMARY KEY CLUSTERED 
(
	[IdGenre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PlayList]    Script Date: 10/02/2017 8:12:36 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlayList](
	[IdPlayList] [int] IDENTITY(1,1) NOT NULL,
	[IdPlayListType] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Score] [int] NULL,
	[Visibility] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ListaReproduccion] PRIMARY KEY CLUSTERED 
(
	[IdPlayList] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PlayListDetail]    Script Date: 10/02/2017 8:12:36 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlayListDetail](
	[IdPlayListDetail] [int] IDENTITY(1,1) NOT NULL,
	[IdPlayList] [int] NOT NULL,
	[IdSong] [int] NOT NULL,
 CONSTRAINT [PK_CancionListaReproduccion] PRIMARY KEY CLUSTERED 
(
	[IdPlayListDetail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Role]    Script Date: 10/02/2017 8:12:36 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[IdRole] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED 
(
	[IdRole] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Song]    Script Date: 10/02/2017 8:12:36 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Song](
	[IdSong] [int] IDENTITY(1,1) NOT NULL,
	[IdGenre] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Length] [time](7) NOT NULL,
 CONSTRAINT [PK_Cancion] PRIMARY KEY CLUSTERED 
(
	[IdSong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 10/02/2017 8:12:36 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[IdUser] [int] IDENTITY(1,1) NOT NULL,
	[IdRole] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[IdUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserPlayList]    Script Date: 10/02/2017 8:12:36 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserPlayList](
	[IdUserPlayList] [int] IDENTITY(1,1) NOT NULL,
	[IdUser] [int] NOT NULL,
	[IdPlayList] [int] NOT NULL,
 CONSTRAINT [PK_UsuarioListaReproduccion] PRIMARY KEY CLUSTERED 
(
	[IdUserPlayList] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Artist] ON 

INSERT [dbo].[Artist] ([IdArtist], [Name], [LastName], [Nationality]) VALUES (1, N'Lucky', N'Luck', N'USA')
SET IDENTITY_INSERT [dbo].[Artist] OFF
SET IDENTITY_INSERT [dbo].[Genre] ON 

INSERT [dbo].[Genre] ([IdGenre], [Name]) VALUES (1, N'Rock')
INSERT [dbo].[Genre] ([IdGenre], [Name]) VALUES (2, N'Classic')
INSERT [dbo].[Genre] ([IdGenre], [Name]) VALUES (3, N'Pop')
INSERT [dbo].[Genre] ([IdGenre], [Name]) VALUES (4, N'Vallenato')
SET IDENTITY_INSERT [dbo].[Genre] OFF
SET IDENTITY_INSERT [dbo].[Song] ON 

INSERT [dbo].[Song] ([IdSong], [IdGenre], [Name], [Length]) VALUES (2, 1, N'Uno', CAST(N'02:00:00' AS Time))
SET IDENTITY_INSERT [dbo].[Song] OFF
ALTER TABLE [dbo].[AlbumSongArtist]  WITH CHECK ADD  CONSTRAINT [FK_AlbumSongArtist_Album] FOREIGN KEY([IdAlbum])
REFERENCES [dbo].[Album] ([IdAlbum])
GO
ALTER TABLE [dbo].[AlbumSongArtist] CHECK CONSTRAINT [FK_AlbumSongArtist_Album]
GO
ALTER TABLE [dbo].[AlbumSongArtist]  WITH CHECK ADD  CONSTRAINT [FK_AlbumSongArtist_Artist] FOREIGN KEY([IdArtist])
REFERENCES [dbo].[Artist] ([IdArtist])
GO
ALTER TABLE [dbo].[AlbumSongArtist] CHECK CONSTRAINT [FK_AlbumSongArtist_Artist]
GO
ALTER TABLE [dbo].[AlbumSongArtist]  WITH CHECK ADD  CONSTRAINT [FK_AlbumSongArtist_Song] FOREIGN KEY([IdSong])
REFERENCES [dbo].[Song] ([IdSong])
GO
ALTER TABLE [dbo].[AlbumSongArtist] CHECK CONSTRAINT [FK_AlbumSongArtist_Song]
GO
ALTER TABLE [dbo].[PlayListDetail]  WITH CHECK ADD  CONSTRAINT [FK_PlayListDetail_PlayList] FOREIGN KEY([IdPlayList])
REFERENCES [dbo].[PlayList] ([IdPlayList])
GO
ALTER TABLE [dbo].[PlayListDetail] CHECK CONSTRAINT [FK_PlayListDetail_PlayList]
GO
ALTER TABLE [dbo].[PlayListDetail]  WITH CHECK ADD  CONSTRAINT [FK_PlayListDetail_Song] FOREIGN KEY([IdSong])
REFERENCES [dbo].[Song] ([IdSong])
GO
ALTER TABLE [dbo].[PlayListDetail] CHECK CONSTRAINT [FK_PlayListDetail_Song]
GO
ALTER TABLE [dbo].[Song]  WITH CHECK ADD  CONSTRAINT [FK_Cancion_Genero] FOREIGN KEY([IdGenre])
REFERENCES [dbo].[Genre] ([IdGenre])
GO
ALTER TABLE [dbo].[Song] CHECK CONSTRAINT [FK_Cancion_Genero]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Rol] FOREIGN KEY([IdRole])
REFERENCES [dbo].[Role] ([IdRole])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_Usuario_Rol]
GO
ALTER TABLE [dbo].[UserPlayList]  WITH CHECK ADD  CONSTRAINT [FK_UserPlayList_PlayList1] FOREIGN KEY([IdPlayList])
REFERENCES [dbo].[PlayList] ([IdPlayList])
GO
ALTER TABLE [dbo].[UserPlayList] CHECK CONSTRAINT [FK_UserPlayList_PlayList1]
GO
ALTER TABLE [dbo].[UserPlayList]  WITH CHECK ADD  CONSTRAINT [FK_UserPlayList_User1] FOREIGN KEY([IdUser])
REFERENCES [dbo].[User] ([IdUser])
GO
ALTER TABLE [dbo].[UserPlayList] CHECK CONSTRAINT [FK_UserPlayList_User1]
GO
USE [master]
GO
ALTER DATABASE [PlayListsProject] SET  READ_WRITE 
GO
