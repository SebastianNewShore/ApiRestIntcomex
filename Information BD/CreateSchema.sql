USE [INTCOMEX]
GO
/****** Object:  Table [dbo].[tbCategory]    Script Date: 25/09/2022 11:13:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbCategory](
	[Id] [uniqueidentifier] NOT NULL,
	[categoryname] [varchar](50) NOT NULL,
	[description] [varchar](50) NOT NULL,
	[picture] [varchar](50) NOT NULL,
	[active] [bit] NOT NULL,
 CONSTRAINT [PK_tbCategory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbCity]    Script Date: 25/09/2022 11:13:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbCity](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Active] [bit] NOT NULL,
	[IdRegion] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_tbCity] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbCountry]    Script Date: 25/09/2022 11:13:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbCountry](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_tbCountry] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbCustomer]    Script Date: 25/09/2022 11:13:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbCustomer](
	[Id] [uniqueidentifier] NOT NULL,
	[CompanyName] [varchar](50) NOT NULL,
	[ContactName] [varchar](50) NOT NULL,
	[ContactTitle] [varchar](50) NOT NULL,
	[Address] [varchar](100) NULL,
	[Phone] [varchar](20) NOT NULL,
	[Fax] [varchar](50) NULL,
	[Active] [bit] NOT NULL,
	[PostalCode] [varchar](20) NOT NULL,
	[IdCity] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_tbCustomer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbEmployee]    Script Date: 25/09/2022 11:13:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbEmployee](
	[Id] [uniqueidentifier] NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[Title] [varchar](50) NOT NULL,
	[TitleOfCourtesy] [varchar](50) NOT NULL,
	[BirthDate] [date] NOT NULL,
	[HireDate] [date] NOT NULL,
	[Adress] [varchar](100) NULL,
	[HomePhone] [varchar](20) NULL,
	[Extension] [varchar](20) NULL,
	[Photo] [varbinary](max) NULL,
	[Notes] [varchar](50) NULL,
	[ReportsTo] [varchar](50) NULL,
	[PostalCode] [varchar](20) NOT NULL,
	[IdCity] [uniqueidentifier] NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_tbEmployee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbOrder]    Script Date: 25/09/2022 11:13:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbOrder](
	[Id] [uniqueidentifier] NOT NULL,
	[OrderDate] [date] NOT NULL,
	[RequiredDate] [bit] NOT NULL,
	[ShippedDate] [date] NOT NULL,
	[ShipVia] [varchar](50) NOT NULL,
	[ShipName] [varchar](50) NOT NULL,
	[ShipAdress] [varchar](100) NOT NULL,
	[ShipPostalCode] [varchar](20) NOT NULL,
	[IdCity] [uniqueidentifier] NOT NULL,
	[IdCustomers] [uniqueidentifier] NOT NULL,
	[IdEmployees] [uniqueidentifier] NOT NULL,
	[IdShippers] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_tbOrder] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbOrderDetail]    Script Date: 25/09/2022 11:13:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbOrderDetail](
	[Id] [uniqueidentifier] NOT NULL,
	[IdOrders] [uniqueidentifier] NOT NULL,
	[IdProducts] [uniqueidentifier] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Discount] [int] NOT NULL,
	[UnitPrice] [money] NOT NULL,
 CONSTRAINT [PK_tbOrderDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbProduct]    Script Date: 25/09/2022 11:13:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbProduct](
	[Id] [uniqueidentifier] NOT NULL,
	[productName] [varchar](50) NOT NULL,
	[quantityPerunit] [int] NOT NULL,
	[unitPrice] [money] NOT NULL,
	[unitsinStock] [int] NOT NULL,
	[unitsonOrder] [int] NOT NULL,
	[recorderLevel] [int] NOT NULL,
	[active] [bit] NOT NULL,
	[idSuppliers] [uniqueidentifier] NOT NULL,
	[idCategory] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_tbProduct] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbRegion]    Script Date: 25/09/2022 11:13:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbRegion](
	[Id] [uniqueidentifier] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[Active] [bit] NOT NULL,
	[IdCountry] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_tbRegion] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbShipper]    Script Date: 25/09/2022 11:13:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbShipper](
	[Id] [uniqueidentifier] NOT NULL,
	[CompanyName] [varchar](50) NOT NULL,
	[Phone] [varchar](20) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_tbShipper] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbSupplier]    Script Date: 25/09/2022 11:13:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbSupplier](
	[Id] [uniqueidentifier] NOT NULL,
	[companyName] [varchar](50) NOT NULL,
	[contactName] [varchar](50) NOT NULL,
	[contactTitle] [varchar](50) NOT NULL,
	[adress] [varchar](100) NOT NULL,
	[phone] [varchar](50) NOT NULL,
	[fax] [varchar](50) NOT NULL,
	[homePage] [varchar](100) NULL,
	[postalCode] [varchar](20) NOT NULL,
	[active] [bit] NOT NULL,
	[idCity] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_tbSupplier] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tbCategory] ([Id], [categoryname], [description], [picture], [active]) VALUES (N'027184ac-800a-4ea4-8035-85a1473986ee', N'prueba', N'prueba', N'prueba', 1)
INSERT [dbo].[tbCategory] ([Id], [categoryname], [description], [picture], [active]) VALUES (N'8c24f039-b8fc-4fc9-b8d1-d245fe5a1315', N'SERVIDORES', N'New Category', N'C/Images/Category', 1)
INSERT [dbo].[tbCategory] ([Id], [categoryname], [description], [picture], [active]) VALUES (N'71255970-e3b8-4e71-9ee5-e016bddb8de5', N'prueba', N'prueba', N'prueba', 1)
GO
INSERT [dbo].[tbCity] ([Id], [Name], [Active], [IdRegion]) VALUES (N'c0c68aaa-8468-4b0a-875d-4516a144e157', N'Bogota', 1, N'854285e4-ee07-4ddf-b376-1e9e142b4abe')
GO
INSERT [dbo].[tbCountry] ([Id], [Name], [Active]) VALUES (N'c5b112e5-9060-4367-bf7c-fa06384a6f8c', N'Colombia', 1)
GO
INSERT [dbo].[tbProduct] ([Id], [productName], [quantityPerunit], [unitPrice], [unitsinStock], [unitsonOrder], [recorderLevel], [active], [idSuppliers], [idCategory]) VALUES (N'46f066a9-cddc-4c11-a8c6-642dacb63f83', N'Azure Kubernetes Service (AKS)', 1, 200000.0000, 50, 100, 0, 1, N'6e4b8678-37de-4746-8558-ba91e7531fb5', N'8c24f039-b8fc-4fc9-b8d1-d245fe5a1315')
GO
INSERT [dbo].[tbRegion] ([Id], [name], [Active], [IdCountry]) VALUES (N'854285e4-ee07-4ddf-b376-1e9e142b4abe', N'Cundinamarca', 1, N'c5b112e5-9060-4367-bf7c-fa06384a6f8c')
GO
INSERT [dbo].[tbSupplier] ([Id], [companyName], [contactName], [contactTitle], [adress], [phone], [fax], [homePage], [postalCode], [active], [idCity]) VALUES (N'6e4b8678-37de-4746-8558-ba91e7531fb5', N'AZURE', N'Prueba', N'Prueba', N'Bogota cra 34 A', N'+57 3108238698', N'Prueba', N'Prueba', N'54052', 1, N'c0c68aaa-8468-4b0a-875d-4516a144e157')
GO
ALTER TABLE [dbo].[tbCity]  WITH CHECK ADD  CONSTRAINT [FK_tbCity_tbRegion] FOREIGN KEY([IdRegion])
REFERENCES [dbo].[tbRegion] ([Id])
GO
ALTER TABLE [dbo].[tbCity] CHECK CONSTRAINT [FK_tbCity_tbRegion]
GO
ALTER TABLE [dbo].[tbCustomer]  WITH CHECK ADD  CONSTRAINT [FK_tbCustomers_tbCity] FOREIGN KEY([IdCity])
REFERENCES [dbo].[tbCity] ([Id])
GO
ALTER TABLE [dbo].[tbCustomer] CHECK CONSTRAINT [FK_tbCustomers_tbCity]
GO
ALTER TABLE [dbo].[tbEmployee]  WITH CHECK ADD  CONSTRAINT [FK_tbEmployees_tbCity] FOREIGN KEY([IdCity])
REFERENCES [dbo].[tbCity] ([Id])
GO
ALTER TABLE [dbo].[tbEmployee] CHECK CONSTRAINT [FK_tbEmployees_tbCity]
GO
ALTER TABLE [dbo].[tbOrder]  WITH CHECK ADD  CONSTRAINT [FK_tbOrders_tbCity] FOREIGN KEY([IdCity])
REFERENCES [dbo].[tbCity] ([Id])
GO
ALTER TABLE [dbo].[tbOrder] CHECK CONSTRAINT [FK_tbOrders_tbCity]
GO
ALTER TABLE [dbo].[tbOrder]  WITH CHECK ADD  CONSTRAINT [FK_tbOrders_tbCustomers] FOREIGN KEY([IdCustomers])
REFERENCES [dbo].[tbCustomer] ([Id])
GO
ALTER TABLE [dbo].[tbOrder] CHECK CONSTRAINT [FK_tbOrders_tbCustomers]
GO
ALTER TABLE [dbo].[tbOrder]  WITH CHECK ADD  CONSTRAINT [FK_tbOrders_tbEmployees] FOREIGN KEY([IdEmployees])
REFERENCES [dbo].[tbEmployee] ([Id])
GO
ALTER TABLE [dbo].[tbOrder] CHECK CONSTRAINT [FK_tbOrders_tbEmployees]
GO
ALTER TABLE [dbo].[tbOrder]  WITH CHECK ADD  CONSTRAINT [FK_tbOrders_tbShippers] FOREIGN KEY([IdShippers])
REFERENCES [dbo].[tbShipper] ([Id])
GO
ALTER TABLE [dbo].[tbOrder] CHECK CONSTRAINT [FK_tbOrders_tbShippers]
GO
ALTER TABLE [dbo].[tbOrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_tbOrderDetails_tbOrders] FOREIGN KEY([IdOrders])
REFERENCES [dbo].[tbOrder] ([Id])
GO
ALTER TABLE [dbo].[tbOrderDetail] CHECK CONSTRAINT [FK_tbOrderDetails_tbOrders]
GO
ALTER TABLE [dbo].[tbOrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_tbOrderDetails_tbProducts] FOREIGN KEY([IdProducts])
REFERENCES [dbo].[tbProduct] ([Id])
GO
ALTER TABLE [dbo].[tbOrderDetail] CHECK CONSTRAINT [FK_tbOrderDetails_tbProducts]
GO
ALTER TABLE [dbo].[tbProduct]  WITH CHECK ADD  CONSTRAINT [FK_tbProducts_tbCategories] FOREIGN KEY([idCategory])
REFERENCES [dbo].[tbCategory] ([Id])
GO
ALTER TABLE [dbo].[tbProduct] CHECK CONSTRAINT [FK_tbProducts_tbCategories]
GO
ALTER TABLE [dbo].[tbProduct]  WITH CHECK ADD  CONSTRAINT [FK_tbProducts_tbSuppliers] FOREIGN KEY([idSuppliers])
REFERENCES [dbo].[tbSupplier] ([Id])
GO
ALTER TABLE [dbo].[tbProduct] CHECK CONSTRAINT [FK_tbProducts_tbSuppliers]
GO
ALTER TABLE [dbo].[tbRegion]  WITH CHECK ADD  CONSTRAINT [FK_tbRegion_tbCountry] FOREIGN KEY([IdCountry])
REFERENCES [dbo].[tbCountry] ([Id])
GO
ALTER TABLE [dbo].[tbRegion] CHECK CONSTRAINT [FK_tbRegion_tbCountry]
GO
ALTER TABLE [dbo].[tbSupplier]  WITH CHECK ADD  CONSTRAINT [FK_tbSuppliers_tbCity] FOREIGN KEY([idCity])
REFERENCES [dbo].[tbCity] ([Id])
GO
ALTER TABLE [dbo].[tbSupplier] CHECK CONSTRAINT [FK_tbSuppliers_tbCity]
GO
