USE [Mini_Project_DbFirst]
GO
/****** Object:  Table [dbo].[CategoryTbl]    Script Date: 5/25/2024 9:21:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoryTbl](
	[CategoryID] [bigint] IDENTITY(1,1) NOT NULL,
	[CategoryName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_CategoryTbl] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ColorTbl]    Script Date: 5/25/2024 9:21:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ColorTbl](
	[ColorID] [bigint] IDENTITY(1,1) NOT NULL,
	[ColorName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ColorTbl] PRIMARY KEY CLUSTERED 
(
	[ColorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MfgTbl]    Script Date: 5/25/2024 9:21:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MfgTbl](
	[MfgID] [bigint] IDENTITY(1,1) NOT NULL,
	[MfgName] [varchar](50) NOT NULL,
	[Address] [varchar](50) NOT NULL,
	[EmailID] [varchar](50) NOT NULL,
	[WebsiteUrl] [varchar](50) NOT NULL,
	[ContactPersonName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_MfgTbl] PRIMARY KEY CLUSTERED 
(
	[MfgID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductColorTbl]    Script Date: 5/25/2024 9:21:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductColorTbl](
	[ProductColorID] [bigint] NOT NULL,
	[ProductID] [bigint] NOT NULL,
	[ColorID] [bigint] NOT NULL,
 CONSTRAINT [PK_ProductColorTbl] PRIMARY KEY CLUSTERED 
(
	[ProductColorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductTbl]    Script Date: 5/25/2024 9:21:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductTbl](
	[ProductID] [bigint] IDENTITY(1,1) NOT NULL,
	[ProductName] [varchar](50) NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
	[MfgID] [bigint] NOT NULL,
	[ProductDescription] [varchar](50) NOT NULL,
	[CategoryID] [bigint] NOT NULL,
 CONSTRAINT [PK_ProductTbl] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserTbl]    Script Date: 5/25/2024 9:21:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserTbl](
	[UserID] [bigint] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Address] [varchar](50) NOT NULL,
	[EmailID] [varchar](50) NOT NULL,
	[MobileNo] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_UserTbl] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CategoryTbl] ON 

INSERT [dbo].[CategoryTbl] ([CategoryID], [CategoryName]) VALUES (4, N'Cloth')
INSERT [dbo].[CategoryTbl] ([CategoryID], [CategoryName]) VALUES (5, N'Computer')
INSERT [dbo].[CategoryTbl] ([CategoryID], [CategoryName]) VALUES (6, N'Electronics')
INSERT [dbo].[CategoryTbl] ([CategoryID], [CategoryName]) VALUES (7, N'Vehicle')
SET IDENTITY_INSERT [dbo].[CategoryTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[ColorTbl] ON 

INSERT [dbo].[ColorTbl] ([ColorID], [ColorName]) VALUES (5, N'Red')
INSERT [dbo].[ColorTbl] ([ColorID], [ColorName]) VALUES (6, N'Green')
INSERT [dbo].[ColorTbl] ([ColorID], [ColorName]) VALUES (7, N'Orange')
INSERT [dbo].[ColorTbl] ([ColorID], [ColorName]) VALUES (8, N'Yellow')
INSERT [dbo].[ColorTbl] ([ColorID], [ColorName]) VALUES (9, N'Blue')
SET IDENTITY_INSERT [dbo].[ColorTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[MfgTbl] ON 

INSERT [dbo].[MfgTbl] ([MfgID], [MfgName], [Address], [EmailID], [WebsiteUrl], [ContactPersonName]) VALUES (2, N'Dell', N'Akurdi', N'dell@outlook.com', N'www.dell.com', N'Raju')
INSERT [dbo].[MfgTbl] ([MfgID], [MfgName], [Address], [EmailID], [WebsiteUrl], [ContactPersonName]) VALUES (3, N'Tata', N'Pimpri', N'tata@gmail.com', N'www.tata.com', N'Rajshri')
INSERT [dbo].[MfgTbl] ([MfgID], [MfgName], [Address], [EmailID], [WebsiteUrl], [ContactPersonName]) VALUES (4, N'Samsung', N'Ranjangaon', N'samsung@hotmail.com', N'www.samsung.com', N'Suresh')
INSERT [dbo].[MfgTbl] ([MfgID], [MfgName], [Address], [EmailID], [WebsiteUrl], [ContactPersonName]) VALUES (5, N'Zudio', N'Kalyan', N'zudio@hotmail.com', N'www.zudio.com', N'Namita')
INSERT [dbo].[MfgTbl] ([MfgID], [MfgName], [Address], [EmailID], [WebsiteUrl], [ContactPersonName]) VALUES (6, N'Haier', N'Koregaon', N'haier@outlook.com', N'www.haier.com', N'Shravan')
SET IDENTITY_INSERT [dbo].[MfgTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductTbl] ON 

INSERT [dbo].[ProductTbl] ([ProductID], [ProductName], [Price], [MfgID], [ProductDescription], [CategoryID]) VALUES (1, N'HardDisk', CAST(4500 AS Decimal(18, 0)), 2, N'HardDisk for PC', 5)
INSERT [dbo].[ProductTbl] ([ProductID], [ProductName], [Price], [MfgID], [ProductDescription], [CategoryID]) VALUES (2, N'Fender', CAST(3000 AS Decimal(18, 0)), 3, N'Fender for Car', 7)
INSERT [dbo].[ProductTbl] ([ProductID], [ProductName], [Price], [MfgID], [ProductDescription], [CategoryID]) VALUES (3, N'Washing Machine', CAST(35000 AS Decimal(18, 0)), 4, N'Electronics Machine', 6)
INSERT [dbo].[ProductTbl] ([ProductID], [ProductName], [Price], [MfgID], [ProductDescription], [CategoryID]) VALUES (4, N'T-shirt', CAST(1200 AS Decimal(18, 0)), 5, N'Mens T-Shirt', 4)
SET IDENTITY_INSERT [dbo].[ProductTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[UserTbl] ON 

INSERT [dbo].[UserTbl] ([UserID], [FirstName], [LastName], [Address], [EmailID], [MobileNo], [Password]) VALUES (6, N'Suresh', N'Raina', N'Akurdi', N'suresh@gmail.com', N'7896541230', N'abc')
INSERT [dbo].[UserTbl] ([UserID], [FirstName], [LastName], [Address], [EmailID], [MobileNo], [Password]) VALUES (7, N'Rohit', N'Sharma', N'Nigdi', N'rohit@outlook.com', N'8796541203', N'ABC')
INSERT [dbo].[UserTbl] ([UserID], [FirstName], [LastName], [Address], [EmailID], [MobileNo], [Password]) VALUES (8, N'Ambati', N'Raydu', N'Pimpri', N'ambati@hotmail.Com', N'9865741203', N'pqr')
INSERT [dbo].[UserTbl] ([UserID], [FirstName], [LastName], [Address], [EmailID], [MobileNo], [Password]) VALUES (9, N'Yuvraj', N'Singh', N'Chinchwad', N'yuvraj@gmail.com', N'9856410237', N'PQR')
INSERT [dbo].[UserTbl] ([UserID], [FirstName], [LastName], [Address], [EmailID], [MobileNo], [Password]) VALUES (10, N'Sachin', N'Tendulkar', N'Mumbai', N'sachin@hotmail.com', N'9632014587', N'zxc')
SET IDENTITY_INSERT [dbo].[UserTbl] OFF
GO
ALTER TABLE [dbo].[ProductColorTbl]  WITH CHECK ADD  CONSTRAINT [FK_ProductColorTbl_ColorTbl] FOREIGN KEY([ColorID])
REFERENCES [dbo].[ColorTbl] ([ColorID])
GO
ALTER TABLE [dbo].[ProductColorTbl] CHECK CONSTRAINT [FK_ProductColorTbl_ColorTbl]
GO
ALTER TABLE [dbo].[ProductColorTbl]  WITH CHECK ADD  CONSTRAINT [FK_ProductColorTbl_ProductTbl] FOREIGN KEY([ProductID])
REFERENCES [dbo].[ProductTbl] ([ProductID])
GO
ALTER TABLE [dbo].[ProductColorTbl] CHECK CONSTRAINT [FK_ProductColorTbl_ProductTbl]
GO
ALTER TABLE [dbo].[ProductTbl]  WITH CHECK ADD  CONSTRAINT [FK_ProductTbl_CategoryTbl] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[CategoryTbl] ([CategoryID])
GO
ALTER TABLE [dbo].[ProductTbl] CHECK CONSTRAINT [FK_ProductTbl_CategoryTbl]
GO
ALTER TABLE [dbo].[ProductTbl]  WITH CHECK ADD  CONSTRAINT [FK_ProductTbl_MfgTbl] FOREIGN KEY([MfgID])
REFERENCES [dbo].[MfgTbl] ([MfgID])
GO
ALTER TABLE [dbo].[ProductTbl] CHECK CONSTRAINT [FK_ProductTbl_MfgTbl]
GO
