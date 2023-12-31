USE [master]
GO
/****** Object:  Database [Nhatki2023]    Script Date: 11/11/2023 1:30:11 PM ******/
CREATE DATABASE [Nhatki2023]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Nhatki2023', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Nhatki2023.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Nhatki2023_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Nhatki2023_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Nhatki2023] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Nhatki2023].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Nhatki2023] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Nhatki2023] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Nhatki2023] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Nhatki2023] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Nhatki2023] SET ARITHABORT OFF 
GO
ALTER DATABASE [Nhatki2023] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Nhatki2023] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Nhatki2023] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Nhatki2023] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Nhatki2023] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Nhatki2023] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Nhatki2023] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Nhatki2023] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Nhatki2023] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Nhatki2023] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Nhatki2023] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Nhatki2023] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Nhatki2023] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Nhatki2023] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Nhatki2023] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Nhatki2023] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Nhatki2023] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Nhatki2023] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Nhatki2023] SET  MULTI_USER 
GO
ALTER DATABASE [Nhatki2023] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Nhatki2023] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Nhatki2023] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Nhatki2023] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Nhatki2023] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Nhatki2023] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Nhatki2023] SET QUERY_STORE = OFF
GO
USE [Nhatki2023]
GO
/****** Object:  Table [dbo].[Entries]    Script Date: 11/11/2023 1:30:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entries](
	[EntryID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NULL,
	[TagID] [int] NULL,
	[EntryDate] [datetime] NULL,
	[Title] [varchar](255) NULL,
	[Content] [text] NULL,
	[Status] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[EntryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tags]    Script Date: 11/11/2023 1:30:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tags](
	[TagID] [int] IDENTITY(1,1) NOT NULL,
	[TagName] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[TagID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 11/11/2023 1:30:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](100) NULL,
	[Password] [varchar](100) NULL,
	[conPassword] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Entries] ON 

INSERT [dbo].[Entries] ([EntryID], [UserID], [TagID], [EntryDate], [Title], [Content], [Status]) VALUES (5, NULL, 7, CAST(N'2023-11-09T00:00:00.000' AS DateTime), N'HELLO WORLD', N'abc', 0)
INSERT [dbo].[Entries] ([EntryID], [UserID], [TagID], [EntryDate], [Title], [Content], [Status]) VALUES (7, NULL, 8, CAST(N'2023-11-09T00:00:00.000' AS DateTime), N'Spring day is comming !!!', N'Spring day is the best season', 0)
INSERT [dbo].[Entries] ([EntryID], [UserID], [TagID], [EntryDate], [Title], [Content], [Status]) VALUES (13, NULL, 16, CAST(N'2023-11-09T00:00:00.000' AS DateTime), N'Spring day is comming !!!', N'Spring day is the best season', 1)
INSERT [dbo].[Entries] ([EntryID], [UserID], [TagID], [EntryDate], [Title], [Content], [Status]) VALUES (14, NULL, 17, CAST(N'2020-11-10T00:00:00.000' AS DateTime), N'A Day in the Park', N'Today was a beautiful day. The sun was shining, and there was a gentle breeze in the air. I decided to spend the day at the park, surrounded by nature and tranquility. I brought a book with me and found a cozy spot under a tree.

As I sat there, I lost track of time, engrossed in the world of the book. The chirping of birds and the rustling of leaves in the wind created the perfect background soundtrack. I couldn''t help but smile as I turned the pages and got lost in the story.', 1)
INSERT [dbo].[Entries] ([EntryID], [UserID], [TagID], [EntryDate], [Title], [Content], [Status]) VALUES (15, NULL, 18, CAST(N'2023-11-09T00:00:00.000' AS DateTime), N'A Culinary Adventure', N'Today, I embarked on a culinary adventure. I decided to try my hand at cooking a new recipe I found online. The dish was a complex and exotic Indian curry that required a variety of spices and intricate cooking techniques.

I started by gathering all the necessary ingredients, from garam masala to fresh cilantro. The kitchen was filled with a delightful aroma as I toasted the spices and simmered the sauce. It was a labor of love that took a few hours, but the end result was worth it.

When I finally sat down to savor my creation, the flavors exploded in my mouth. The rich and aromatic curry was a symphony of tastes, and the heat from the spices warmed my soul. It was a truly satisfying culinary journey, and I couldn''t help but feel a sense of accomplishment.', 0)
INSERT [dbo].[Entries] ([EntryID], [UserID], [TagID], [EntryDate], [Title], [Content], [Status]) VALUES (16, NULL, 19, CAST(N'2023-11-09T00:00:00.000' AS DateTime), N'Bad Day !', N'Today Im really sad that I got a bad mark of PRN211 practical exam. I really really want to try my best to pass this subject. And my teacher Ta Dinh Tien is the most handsome man in my class.', 1)
INSERT [dbo].[Entries] ([EntryID], [UserID], [TagID], [EntryDate], [Title], [Content], [Status]) VALUES (17, NULL, 20, CAST(N'2020-01-29T00:00:00.000' AS DateTime), N'A Mysterious Encounter', N'Curiosity got the better of me, and I decided to follow the coordinates. As I reached the secluded spot, I noticed an old, abandoned cabin. The atmosphere was eerie, with an unsettling silence hanging in the air. Inside the cabin, I discovered a hidden compartment in the floorboards, containing a journal filled with cryptic entries. The journal hinted at a hidden treasure and a long-forgotten secret.

As I delved deeper into the mystery, I couldn''t help but feel a growing sense of unease. The more I uncovered, the more dangerous the situation seemed. Who had left the letter, and what were they trying to reveal or hide?', 1)
SET IDENTITY_INSERT [dbo].[Entries] OFF
GO
SET IDENTITY_INSERT [dbo].[Tags] ON 

INSERT [dbo].[Tags] ([TagID], [TagName]) VALUES (1, N'#tamsu')
INSERT [dbo].[Tags] ([TagID], [TagName]) VALUES (2, N'#tuoi20')
INSERT [dbo].[Tags] ([TagID], [TagName]) VALUES (3, N'#summer')
INSERT [dbo].[Tags] ([TagID], [TagName]) VALUES (5, N'#rainyday')
INSERT [dbo].[Tags] ([TagID], [TagName]) VALUES (7, N'#status')
INSERT [dbo].[Tags] ([TagID], [TagName]) VALUES (8, N'#springday')
INSERT [dbo].[Tags] ([TagID], [TagName]) VALUES (10, N'#tamsu2')
INSERT [dbo].[Tags] ([TagID], [TagName]) VALUES (11, N'#tamsu3')
INSERT [dbo].[Tags] ([TagID], [TagName]) VALUES (12, N'#tamsu34')
INSERT [dbo].[Tags] ([TagID], [TagName]) VALUES (13, N'#tamsu345')
INSERT [dbo].[Tags] ([TagID], [TagName]) VALUES (15, N'#spring')
INSERT [dbo].[Tags] ([TagID], [TagName]) VALUES (16, N'#springhello')
INSERT [dbo].[Tags] ([TagID], [TagName]) VALUES (17, N'#Nature')
INSERT [dbo].[Tags] ([TagID], [TagName]) VALUES (18, N'#CookingAdventure')
INSERT [dbo].[Tags] ([TagID], [TagName]) VALUES (19, N'#saddestday')
INSERT [dbo].[Tags] ([TagID], [TagName]) VALUES (20, N'#Mystery')
SET IDENTITY_INSERT [dbo].[Tags] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserID], [Username], [Password], [conPassword]) VALUES (1, N'admin', N'123123', N'123123')
INSERT [dbo].[Users] ([UserID], [Username], [Password], [conPassword]) VALUES (2, N'admin2', N'1234', N'1234')
INSERT [dbo].[Users] ([UserID], [Username], [Password], [conPassword]) VALUES (3, N'admin3', N'daodz', N'daodz')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Users__536C85E4A158B179]    Script Date: 11/11/2023 1:30:11 PM ******/
ALTER TABLE [dbo].[Users] ADD UNIQUE NONCLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Entries]  WITH CHECK ADD FOREIGN KEY([TagID])
REFERENCES [dbo].[Tags] ([TagID])
GO
ALTER TABLE [dbo].[Entries]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
USE [master]
GO
ALTER DATABASE [Nhatki2023] SET  READ_WRITE 
GO
