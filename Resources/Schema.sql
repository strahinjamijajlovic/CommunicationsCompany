USE [CommunicationsCompany]
GO
/****** Object:  Table [dbo].[Address]    Script Date: 25.11.2021. 11:23:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Address](
	[Id] [bigint] NOT NULL,
	[Street] [nvarchar](100) NULL,
	[ApartmentNumber] [int] NULL,
	[City] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CommNodes]    Script Date: 25.11.2021. 11:23:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CommNodes](
	[Id] [bigint] NOT NULL,
	[Description] [nvarchar](200) NULL,
	[DeviceId] [bigint] NULL,
	[AddressId] [bigint] NULL,
	[MainHubId] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Devices]    Script Date: 25.11.2021. 11:23:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Devices](
	[Id] [bigint] NOT NULL,
	[SerialNumber] [nvarchar](50) NOT NULL,
	[ManufacturerName] [nvarchar](100) NOT NULL,
	[InstallationDate] [datetime2](7) NOT NULL,
	[LastServiceDate] [datetime2](7) NULL,
	[LastServiceReason] [nvarchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExtraProgrammes]    Script Date: 25.11.2021. 11:23:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExtraProgrammes](
	[Id] [bigint] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[ServiceId] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InternetServices]    Script Date: 25.11.2021. 11:23:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InternetServices](
	[Id] [bigint] NOT NULL,
	[Prepaid] [bit] NOT NULL,
	[LastPaymentDate] [datetime2](7) NULL,
	[AccountBalance] [real] NULL,
	[FlatRate] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LegalEntities]    Script Date: 25.11.2021. 11:23:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LegalEntities](
	[Id] [bigint] NOT NULL,
	[FaxNumber] [nvarchar](20) NOT NULL,
	[PIB] [nvarchar](20) NOT NULL,
	[ContactPersonId] [bigint] NULL,
	[ServicesId] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MainHubs]    Script Date: 25.11.2021. 11:23:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MainHubs](
	[Id] [bigint] NOT NULL,
	[DeviceId] [bigint] NULL,
	[RegionalHubId] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NaturalPersons]    Script Date: 25.11.2021. 11:23:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NaturalPersons](
	[Id] [bigint] NOT NULL,
	[JMBG] [nvarchar](13) NOT NULL,
	[ContactNumber] [nvarchar](20) NOT NULL,
	[UserId] [bigint] NULL,
	[AddressId] [bigint] NULL,
	[ServicesId] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhoneNumbers]    Script Date: 25.11.2021. 11:23:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhoneNumbers](
	[Id] [bigint] NOT NULL,
	[Number] [nvarchar](20) NOT NULL,
	[MinutesCount] [int] NOT NULL,
	[ServiceId] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RegionalHubs]    Script Date: 25.11.2021. 11:23:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RegionalHubs](
	[Id] [bigint] NOT NULL,
	[RegionName] [nvarchar](50) NOT NULL,
	[DeviceId] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Services]    Script Date: 25.11.2021. 11:23:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Services](
	[Id] [bigint] NOT NULL,
	[InternetServiceId] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StaticIps]    Script Date: 25.11.2021. 11:23:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StaticIps](
	[Id] [bigint] NOT NULL,
	[IpAddress] [nvarchar](20) NOT NULL,
	[InternetServiceId] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 25.11.2021. 11:23:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [bigint] NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[CommNodeId] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CommNodes]  WITH CHECK ADD  CONSTRAINT [FK_1593A2F2] FOREIGN KEY([DeviceId])
REFERENCES [dbo].[Devices] ([Id])
GO
ALTER TABLE [dbo].[CommNodes] CHECK CONSTRAINT [FK_1593A2F2]
GO
ALTER TABLE [dbo].[CommNodes]  WITH CHECK ADD  CONSTRAINT [FK_5AD4704A] FOREIGN KEY([AddressId])
REFERENCES [dbo].[Address] ([Id])
GO
ALTER TABLE [dbo].[CommNodes] CHECK CONSTRAINT [FK_5AD4704A]
GO
ALTER TABLE [dbo].[CommNodes]  WITH CHECK ADD  CONSTRAINT [FK_DC5FC36] FOREIGN KEY([MainHubId])
REFERENCES [dbo].[MainHubs] ([Id])
GO
ALTER TABLE [dbo].[CommNodes] CHECK CONSTRAINT [FK_DC5FC36]
GO
ALTER TABLE [dbo].[ExtraProgrammes]  WITH CHECK ADD  CONSTRAINT [FK_628A968] FOREIGN KEY([ServiceId])
REFERENCES [dbo].[Services] ([Id])
GO
ALTER TABLE [dbo].[ExtraProgrammes] CHECK CONSTRAINT [FK_628A968]
GO
ALTER TABLE [dbo].[LegalEntities]  WITH CHECK ADD  CONSTRAINT [FK_4AAD77A9] FOREIGN KEY([ContactPersonId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[LegalEntities] CHECK CONSTRAINT [FK_4AAD77A9]
GO
ALTER TABLE [dbo].[LegalEntities]  WITH CHECK ADD  CONSTRAINT [FK_D1B05FE8] FOREIGN KEY([ServicesId])
REFERENCES [dbo].[Services] ([Id])
GO
ALTER TABLE [dbo].[LegalEntities] CHECK CONSTRAINT [FK_D1B05FE8]
GO
ALTER TABLE [dbo].[MainHubs]  WITH CHECK ADD  CONSTRAINT [FK_50185930] FOREIGN KEY([DeviceId])
REFERENCES [dbo].[Devices] ([Id])
GO
ALTER TABLE [dbo].[MainHubs] CHECK CONSTRAINT [FK_50185930]
GO
ALTER TABLE [dbo].[MainHubs]  WITH CHECK ADD  CONSTRAINT [FK_C065C98A] FOREIGN KEY([RegionalHubId])
REFERENCES [dbo].[RegionalHubs] ([Id])
GO
ALTER TABLE [dbo].[MainHubs] CHECK CONSTRAINT [FK_C065C98A]
GO
ALTER TABLE [dbo].[NaturalPersons]  WITH CHECK ADD  CONSTRAINT [FK_3EF8EB01] FOREIGN KEY([ServicesId])
REFERENCES [dbo].[Services] ([Id])
GO
ALTER TABLE [dbo].[NaturalPersons] CHECK CONSTRAINT [FK_3EF8EB01]
GO
ALTER TABLE [dbo].[NaturalPersons]  WITH CHECK ADD  CONSTRAINT [FK_AE40D87] FOREIGN KEY([AddressId])
REFERENCES [dbo].[Address] ([Id])
GO
ALTER TABLE [dbo].[NaturalPersons] CHECK CONSTRAINT [FK_AE40D87]
GO
ALTER TABLE [dbo].[NaturalPersons]  WITH CHECK ADD  CONSTRAINT [FK_B9954A5A] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[NaturalPersons] CHECK CONSTRAINT [FK_B9954A5A]
GO
ALTER TABLE [dbo].[PhoneNumbers]  WITH CHECK ADD  CONSTRAINT [FK_957E51E0] FOREIGN KEY([ServiceId])
REFERENCES [dbo].[Services] ([Id])
GO
ALTER TABLE [dbo].[PhoneNumbers] CHECK CONSTRAINT [FK_957E51E0]
GO
ALTER TABLE [dbo].[RegionalHubs]  WITH CHECK ADD  CONSTRAINT [FK_36B54762] FOREIGN KEY([DeviceId])
REFERENCES [dbo].[Devices] ([Id])
GO
ALTER TABLE [dbo].[RegionalHubs] CHECK CONSTRAINT [FK_36B54762]
GO
ALTER TABLE [dbo].[Services]  WITH CHECK ADD  CONSTRAINT [FK_D09CBE9E] FOREIGN KEY([InternetServiceId])
REFERENCES [dbo].[InternetServices] ([Id])
GO
ALTER TABLE [dbo].[Services] CHECK CONSTRAINT [FK_D09CBE9E]
GO
ALTER TABLE [dbo].[StaticIps]  WITH CHECK ADD  CONSTRAINT [FK_E47DA679] FOREIGN KEY([InternetServiceId])
REFERENCES [dbo].[InternetServices] ([Id])
GO
ALTER TABLE [dbo].[StaticIps] CHECK CONSTRAINT [FK_E47DA679]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_604B8561] FOREIGN KEY([CommNodeId])
REFERENCES [dbo].[CommNodes] ([Id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_604B8561]
GO
