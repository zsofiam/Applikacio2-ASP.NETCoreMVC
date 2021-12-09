USE [registry]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 2021. 12. 09. 7:22:32 ******/
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
/****** Object:  Table [dbo].[account]    Script Date: 2021. 12. 09. 7:22:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[account](
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_account] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dokumentum]    Script Date: 2021. 12. 09. 7:22:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dokumentum](
	[id] [int] NOT NULL,
	[title] [nvarchar](50) NOT NULL,
	[extension] [nvarchar](50) NOT NULL,
	[main_id] [int] NOT NULL,
	[source] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_dokumentum] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[esemeny]    Script Date: 2021. 12. 09. 7:22:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[esemeny](
	[id] [int] NOT NULL,
	[title] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_esemeny] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[naplo]    Script Date: 2021. 12. 09. 7:22:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[naplo](
	[dokumentum_id] [int] NOT NULL,
	[esemeny_id] [int] NOT NULL,
	[happened_at] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_naplo] PRIMARY KEY CLUSTERED 
(
	[dokumentum_id] ASC,
	[esemeny_id] ASC,
	[happened_at] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211208190653_add_account_entity', N'5.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211208223036_change_account_entity', N'5.0.12')
GO
INSERT [dbo].[account] ([Username], [Password]) VALUES (N'test1', N'test1')
INSERT [dbo].[account] ([Username], [Password]) VALUES (N'test2', N'test2')
INSERT [dbo].[account] ([Username], [Password]) VALUES (N'test3', N'test3')
INSERT [dbo].[account] ([Username], [Password]) VALUES (N'test4', N'test4')
GO
INSERT [dbo].[dokumentum] ([id], [title], [extension], [main_id], [source]) VALUES (1, N'Szamlak_20200112153545', N'pdf', 0, N'scan')
INSERT [dbo].[dokumentum] ([id], [title], [extension], [main_id], [source]) VALUES (2, N'Szamla_20200112153545_1', N'pdf', 1, N'split')
INSERT [dbo].[dokumentum] ([id], [title], [extension], [main_id], [source]) VALUES (3, N'Szamla_20200112153545_2', N'pdf', 1, N'split')
INSERT [dbo].[dokumentum] ([id], [title], [extension], [main_id], [source]) VALUES (4, N'Szamla_20200112153545_3', N'pdf', 1, N'split')
INSERT [dbo].[dokumentum] ([id], [title], [extension], [main_id], [source]) VALUES (5, N'Szamla_20200112153545_4', N'pdf', 1, N'split')
INSERT [dbo].[dokumentum] ([id], [title], [extension], [main_id], [source]) VALUES (6, N'Szamla_20200112153545_5', N'pdf', 1, N'split')
INSERT [dbo].[dokumentum] ([id], [title], [extension], [main_id], [source]) VALUES (7, N'Szamla_20200112153545_6', N'pdf', 1, N'split')
INSERT [dbo].[dokumentum] ([id], [title], [extension], [main_id], [source]) VALUES (8, N'Szamla_20200112153545_7', N'pdf', 1, N'split')
INSERT [dbo].[dokumentum] ([id], [title], [extension], [main_id], [source]) VALUES (9, N'Szamlak_20200115132432', N'pdf', 0, N'mail')
INSERT [dbo].[dokumentum] ([id], [title], [extension], [main_id], [source]) VALUES (10, N'Szamlak_20200116135412', N'pdf', 0, N'scan')
INSERT [dbo].[dokumentum] ([id], [title], [extension], [main_id], [source]) VALUES (11, N'Szamla_20200116135412_1', N'pdf', 10, N'split')
INSERT [dbo].[dokumentum] ([id], [title], [extension], [main_id], [source]) VALUES (12, N'Szamla_20200116135412_2', N'pdf', 10, N'split')
INSERT [dbo].[dokumentum] ([id], [title], [extension], [main_id], [source]) VALUES (13, N'Szamla_20200116135412_3', N'pdf', 10, N'split')
INSERT [dbo].[dokumentum] ([id], [title], [extension], [main_id], [source]) VALUES (14, N'Jovahagyas_TesztElek_EV', N'pdf', 0, N'mail')
INSERT [dbo].[dokumentum] ([id], [title], [extension], [main_id], [source]) VALUES (15, N'Jovahagyott_tetellista', N'xls', 0, N'mail')
INSERT [dbo].[dokumentum] ([id], [title], [extension], [main_id], [source]) VALUES (16, N'Szallito_FuvarBt_20200214', N'pdf', 0, N'scan')
INSERT [dbo].[dokumentum] ([id], [title], [extension], [main_id], [source]) VALUES (17, N'Szallito_FuvarBt_20200216', N'pdf', 0, N'scan')
GO
INSERT [dbo].[esemeny] ([id], [title]) VALUES (1, N'Beerkezes')
INSERT [dbo].[esemeny] ([id], [title]) VALUES (2, N'Letrehozas')
INSERT [dbo].[esemeny] ([id], [title]) VALUES (3, N'Kepjavitas')
INSERT [dbo].[esemeny] ([id], [title]) VALUES (4, N'Szeparalas')
INSERT [dbo].[esemeny] ([id], [title]) VALUES (5, N'OCR')
INSERT [dbo].[esemeny] ([id], [title]) VALUES (6, N'Adatkinyeres')
INSERT [dbo].[esemeny] ([id], [title]) VALUES (7, N'Athelyezes feltoltesre')
INSERT [dbo].[esemeny] ([id], [title]) VALUES (8, N'Adatcsomag keszites')
INSERT [dbo].[esemeny] ([id], [title]) VALUES (9, N'Feltoltes')
INSERT [dbo].[esemeny] ([id], [title]) VALUES (10, N'Muvelet befejezve')
INSERT [dbo].[esemeny] ([id], [title]) VALUES (11, N'Mappa muvelet hiba')
INSERT [dbo].[esemeny] ([id], [title]) VALUES (12, N'Hianyos adatreteg')
INSERT [dbo].[esemeny] ([id], [title]) VALUES (13, N'Sikertelen feltoltes')
INSERT [dbo].[esemeny] ([id], [title]) VALUES (14, N'Athelyezes sikertelen mappaba')
GO
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (1, 1, CAST(N'2020-01-12T15:35:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (1, 4, CAST(N'2020-01-12T15:39:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (1, 10, CAST(N'2020-01-12T15:39:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (2, 2, CAST(N'2020-01-12T15:39:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (2, 3, CAST(N'2020-01-12T15:39:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (2, 5, CAST(N'2020-01-12T15:39:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (2, 6, CAST(N'2020-01-12T15:40:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (2, 7, CAST(N'2020-01-12T15:40:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (2, 8, CAST(N'2020-01-12T15:40:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (2, 9, CAST(N'2020-01-12T15:40:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (2, 10, CAST(N'2020-01-12T15:40:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (3, 2, CAST(N'2020-01-12T15:39:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (3, 3, CAST(N'2020-01-12T15:39:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (3, 5, CAST(N'2020-01-12T15:39:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (3, 6, CAST(N'2020-01-12T15:40:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (3, 7, CAST(N'2020-01-12T15:40:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (3, 8, CAST(N'2020-01-12T15:40:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (3, 9, CAST(N'2020-01-12T15:40:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (3, 10, CAST(N'2020-01-12T15:40:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (4, 2, CAST(N'2020-01-12T15:39:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (4, 3, CAST(N'2020-01-12T15:39:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (4, 5, CAST(N'2020-01-12T15:39:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (4, 6, CAST(N'2020-01-12T15:40:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (4, 7, CAST(N'2020-01-12T15:40:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (4, 8, CAST(N'2020-01-12T15:40:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (4, 9, CAST(N'2020-01-12T15:40:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (4, 10, CAST(N'2020-01-12T15:40:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (5, 2, CAST(N'2020-01-12T15:39:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (5, 3, CAST(N'2020-01-12T15:39:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (5, 5, CAST(N'2020-01-12T15:39:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (5, 6, CAST(N'2020-01-12T15:40:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (5, 7, CAST(N'2020-01-12T15:40:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (5, 8, CAST(N'2020-01-12T15:40:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (5, 9, CAST(N'2020-01-12T15:40:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (5, 10, CAST(N'2020-01-12T15:40:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (6, 2, CAST(N'2020-01-12T15:39:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (6, 3, CAST(N'2020-01-12T15:39:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (6, 5, CAST(N'2020-01-12T15:39:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (6, 6, CAST(N'2020-01-12T15:40:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (6, 7, CAST(N'2020-01-12T15:40:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (6, 8, CAST(N'2020-01-12T15:40:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (6, 9, CAST(N'2020-01-12T15:40:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (6, 10, CAST(N'2020-01-12T15:40:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (7, 2, CAST(N'2020-01-12T15:39:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (7, 3, CAST(N'2020-01-12T15:39:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (7, 5, CAST(N'2020-01-12T15:39:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (7, 6, CAST(N'2020-01-12T15:40:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (7, 12, CAST(N'2020-01-12T15:40:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (7, 14, CAST(N'2020-01-12T15:40:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (8, 2, CAST(N'2020-01-12T15:39:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (8, 3, CAST(N'2020-01-12T15:39:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (8, 5, CAST(N'2020-01-12T15:39:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (8, 6, CAST(N'2020-01-12T15:40:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (8, 12, CAST(N'2020-01-12T15:40:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (8, 14, CAST(N'2020-01-12T15:40:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (9, 1, CAST(N'2020-01-15T13:24:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (9, 3, CAST(N'2020-01-15T13:24:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (9, 5, CAST(N'2020-01-15T13:24:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (9, 6, CAST(N'2020-01-15T13:24:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (9, 7, CAST(N'2020-01-15T13:27:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (9, 8, CAST(N'2020-01-15T13:27:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (9, 9, CAST(N'2020-01-15T13:27:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (9, 13, CAST(N'2020-01-15T13:28:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (9, 14, CAST(N'2020-01-15T13:28:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (10, 1, CAST(N'2020-01-16T13:54:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (10, 4, CAST(N'2020-01-16T13:54:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (10, 10, CAST(N'2020-01-16T13:54:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (11, 2, CAST(N'2020-01-16T13:54:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (11, 3, CAST(N'2020-01-16T13:54:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (11, 5, CAST(N'2020-01-16T13:54:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (11, 6, CAST(N'2020-01-16T13:54:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (11, 7, CAST(N'2020-01-16T13:54:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (11, 8, CAST(N'2020-01-16T13:54:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (11, 9, CAST(N'2020-01-16T13:54:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (11, 10, CAST(N'2020-01-16T13:55:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (12, 2, CAST(N'2020-01-16T13:54:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (12, 3, CAST(N'2020-01-16T13:55:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (12, 5, CAST(N'2020-01-16T13:55:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (12, 6, CAST(N'2020-01-16T13:55:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (12, 7, CAST(N'2020-01-16T13:55:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (12, 8, CAST(N'2020-01-16T13:55:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (12, 9, CAST(N'2020-01-16T13:56:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (12, 10, CAST(N'2020-01-16T13:55:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (13, 2, CAST(N'2020-01-16T13:54:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (13, 3, CAST(N'2020-01-16T13:55:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (13, 5, CAST(N'2020-01-16T13:55:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (13, 6, CAST(N'2020-01-16T13:55:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (13, 7, CAST(N'2020-01-16T13:55:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (13, 8, CAST(N'2020-01-16T13:55:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (13, 9, CAST(N'2020-01-16T13:56:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (13, 10, CAST(N'2020-01-16T13:56:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (14, 1, CAST(N'2020-01-16T16:25:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (14, 3, CAST(N'2020-01-16T16:25:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (14, 5, CAST(N'2020-01-16T16:25:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (14, 6, CAST(N'2020-01-16T16:25:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (14, 7, CAST(N'2020-01-16T16:25:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (14, 8, CAST(N'2020-01-16T16:25:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (14, 9, CAST(N'2020-01-16T16:25:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (14, 10, CAST(N'2020-01-16T16:26:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (15, 1, CAST(N'2020-01-16T16:40:00.0000000' AS DateTime2))
GO
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (15, 7, CAST(N'2020-01-16T16:40:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (15, 9, CAST(N'2020-01-16T16:40:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (15, 10, CAST(N'2020-01-16T16:40:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (16, 1, CAST(N'2020-02-14T11:54:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (16, 3, CAST(N'2020-02-14T11:54:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (16, 5, CAST(N'2020-02-14T11:54:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (16, 6, CAST(N'2020-02-14T11:54:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (16, 7, CAST(N'2020-02-14T11:54:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (16, 8, CAST(N'2020-02-14T11:54:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (16, 9, CAST(N'2020-02-14T11:54:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (16, 10, CAST(N'2020-02-14T11:54:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (17, 1, CAST(N'2020-02-16T14:54:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (17, 3, CAST(N'2020-02-16T14:54:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (17, 5, CAST(N'2020-02-16T14:54:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (17, 6, CAST(N'2020-02-16T14:54:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (17, 7, CAST(N'2020-02-16T14:54:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (17, 8, CAST(N'2020-02-16T14:54:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (17, 9, CAST(N'2020-02-16T14:54:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (17, 13, CAST(N'2020-02-16T14:55:00.0000000' AS DateTime2))
INSERT [dbo].[naplo] ([dokumentum_id], [esemeny_id], [happened_at]) VALUES (17, 14, CAST(N'2020-02-16T14:55:00.0000000' AS DateTime2))
GO
ALTER TABLE [dbo].[naplo]  WITH CHECK ADD  CONSTRAINT [FK_naplo_dokumentum] FOREIGN KEY([dokumentum_id])
REFERENCES [dbo].[dokumentum] ([id])
GO
ALTER TABLE [dbo].[naplo] CHECK CONSTRAINT [FK_naplo_dokumentum]
GO
ALTER TABLE [dbo].[naplo]  WITH CHECK ADD  CONSTRAINT [FK_naplo_esemeny] FOREIGN KEY([esemeny_id])
REFERENCES [dbo].[esemeny] ([id])
GO
ALTER TABLE [dbo].[naplo] CHECK CONSTRAINT [FK_naplo_esemeny]
GO
