USE [INTCOMEX]
GO
/****** Object:  Table [dbo].[tbCategories]    Script Date: 23/09/2022 7:50:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbCategories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [varchar](50) NOT NULL,
	[Description] [varchar](50) NOT NULL,
	[Picture] [varchar](50) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_tbCategories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbCity]    Script Date: 23/09/2022 7:50:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbCity](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[City] [varchar](50) NOT NULL,
	[Active] [bit] NOT NULL,
	[IdRegion] [int] NOT NULL,
 CONSTRAINT [PK_tbCity] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbCountry]    Script Date: 23/09/2022 7:50:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbCountry](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Country] [varchar](50) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_tbCountry] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbCustomers]    Script Date: 23/09/2022 7:50:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbCustomers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [varchar](50) NOT NULL,
	[ContactName] [varchar](50) NOT NULL,
	[ContactTitle] [varchar](50) NOT NULL,
	[Address] [varchar](100) NULL,
	[Phone] [varchar](20) NOT NULL,
	[Fax] [varchar](50) NULL,
	[Active] [bit] NOT NULL,
	[PostalCode] [varchar](20) NOT NULL,
	[IdCity] [int] NOT NULL,
 CONSTRAINT [PK_tbCustomers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbEmployees]    Script Date: 23/09/2022 7:50:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbEmployees](
	[Id] [int] IDENTITY(1,1) NOT NULL,
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
	[IdCity] [int] NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_tbEmployees] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbOrderDetails]    Script Date: 23/09/2022 7:50:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbOrderDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdOrders] [int] NOT NULL,
	[IdProducts] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Discount] [int] NOT NULL,
	[UnitPrice] [money] NOT NULL,
 CONSTRAINT [PK_tbOrderDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbOrders]    Script Date: 23/09/2022 7:50:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbOrders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderDate] [date] NOT NULL,
	[RequiredDate] [bit] NOT NULL,
	[ShippedDate] [date] NOT NULL,
	[ShipVia] [varchar](50) NOT NULL,
	[ShipName] [varchar](50) NOT NULL,
	[ShipAdress] [varchar](100) NOT NULL,
	[ShipPostalCode] [varchar](20) NOT NULL,
	[IdCity] [int] NOT NULL,
	[IdCustomers] [int] NOT NULL,
	[IdEmployees] [int] NOT NULL,
	[IdShippers] [int] NOT NULL,
 CONSTRAINT [PK_tbOrders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbProducts]    Script Date: 23/09/2022 7:50:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbProducts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [varchar](50) NOT NULL,
	[QuantityPerUnit] [int] NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[UnitsInStock] [int] NOT NULL,
	[UnitsOnOrder] [int] NOT NULL,
	[RecorderLevel] [int] NOT NULL,
	[Active] [bit] NOT NULL,
	[IdSuppliers] [int] NOT NULL,
	[IdCategory] [int] NOT NULL,
 CONSTRAINT [PK_tbProducts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbRegion]    Script Date: 23/09/2022 7:50:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbRegion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Region] [varchar](50) NOT NULL,
	[Active] [bit] NOT NULL,
	[IdCountry] [int] NOT NULL,
 CONSTRAINT [PK_tbRegion] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbShippers]    Script Date: 23/09/2022 7:50:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbShippers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [varchar](50) NOT NULL,
	[Phone] [varchar](20) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_tbShippers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbSuppliers]    Script Date: 23/09/2022 7:50:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbSuppliers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [varchar](50) NOT NULL,
	[ContactName] [varchar](50) NOT NULL,
	[ContactTitle] [varchar](50) NOT NULL,
	[Adress] [varchar](100) NOT NULL,
	[Phone] [varchar](50) NOT NULL,
	[Fax] [varchar](50) NOT NULL,
	[HomePage] [varchar](100) NULL,
	[PostalCode] [varchar](20) NOT NULL,
	[Active] [bit] NOT NULL,
	[IdCity] [int] NOT NULL,
 CONSTRAINT [PK_tbSuppliers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbCustomers]  WITH CHECK ADD  CONSTRAINT [FK_tbCustomers_tbCity] FOREIGN KEY([IdCity])
REFERENCES [dbo].[tbCity] ([Id])
GO
ALTER TABLE [dbo].[tbCustomers] CHECK CONSTRAINT [FK_tbCustomers_tbCity]
GO
ALTER TABLE [dbo].[tbEmployees]  WITH CHECK ADD  CONSTRAINT [FK_tbEmployees_tbCity] FOREIGN KEY([IdCity])
REFERENCES [dbo].[tbCity] ([Id])
GO
ALTER TABLE [dbo].[tbEmployees] CHECK CONSTRAINT [FK_tbEmployees_tbCity]
GO
ALTER TABLE [dbo].[tbOrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_tbOrderDetails_tbOrders] FOREIGN KEY([IdOrders])
REFERENCES [dbo].[tbOrders] ([Id])
GO
ALTER TABLE [dbo].[tbOrderDetails] CHECK CONSTRAINT [FK_tbOrderDetails_tbOrders]
GO
ALTER TABLE [dbo].[tbOrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_tbOrderDetails_tbProducts] FOREIGN KEY([IdProducts])
REFERENCES [dbo].[tbProducts] ([Id])
GO
ALTER TABLE [dbo].[tbOrderDetails] CHECK CONSTRAINT [FK_tbOrderDetails_tbProducts]
GO
ALTER TABLE [dbo].[tbOrders]  WITH CHECK ADD  CONSTRAINT [FK_tbOrders_tbCity] FOREIGN KEY([IdCity])
REFERENCES [dbo].[tbCity] ([Id])
GO
ALTER TABLE [dbo].[tbOrders] CHECK CONSTRAINT [FK_tbOrders_tbCity]
GO
ALTER TABLE [dbo].[tbOrders]  WITH CHECK ADD  CONSTRAINT [FK_tbOrders_tbCustomers] FOREIGN KEY([IdCustomers])
REFERENCES [dbo].[tbCustomers] ([Id])
GO
ALTER TABLE [dbo].[tbOrders] CHECK CONSTRAINT [FK_tbOrders_tbCustomers]
GO
ALTER TABLE [dbo].[tbOrders]  WITH CHECK ADD  CONSTRAINT [FK_tbOrders_tbEmployees] FOREIGN KEY([IdEmployees])
REFERENCES [dbo].[tbEmployees] ([Id])
GO
ALTER TABLE [dbo].[tbOrders] CHECK CONSTRAINT [FK_tbOrders_tbEmployees]
GO
ALTER TABLE [dbo].[tbOrders]  WITH CHECK ADD  CONSTRAINT [FK_tbOrders_tbShippers] FOREIGN KEY([IdShippers])
REFERENCES [dbo].[tbShippers] ([Id])
GO
ALTER TABLE [dbo].[tbOrders] CHECK CONSTRAINT [FK_tbOrders_tbShippers]
GO
ALTER TABLE [dbo].[tbProducts]  WITH CHECK ADD  CONSTRAINT [FK_tbProducts_tbCategories] FOREIGN KEY([IdCategory])
REFERENCES [dbo].[tbCategories] ([Id])
GO
ALTER TABLE [dbo].[tbProducts] CHECK CONSTRAINT [FK_tbProducts_tbCategories]
GO
ALTER TABLE [dbo].[tbProducts]  WITH CHECK ADD  CONSTRAINT [FK_tbProducts_tbSuppliers] FOREIGN KEY([IdSuppliers])
REFERENCES [dbo].[tbSuppliers] ([Id])
GO
ALTER TABLE [dbo].[tbProducts] CHECK CONSTRAINT [FK_tbProducts_tbSuppliers]
GO
ALTER TABLE [dbo].[tbSuppliers]  WITH CHECK ADD  CONSTRAINT [FK_tbSuppliers_tbCity] FOREIGN KEY([IdCity])
REFERENCES [dbo].[tbCity] ([Id])
GO
ALTER TABLE [dbo].[tbSuppliers] CHECK CONSTRAINT [FK_tbSuppliers_tbCity]
GO
