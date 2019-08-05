USE [WeddingHelp]
GO

/****** Object:  Table [dbo].[Vendor]    Script Date: 8/4/2019 4:39:57 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Vendor](
	[VendorName] [varchar](100) NOT NULL,
	[Address] [varchar](100) NOT NULL,
	[ContactNumber] [int] NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[YearsInOperation] [int] NULL,
	[Reviews] [varchar](200) NULL,
	[VendorID] [int] NOT NULL
) ON [PRIMARY]
GO

