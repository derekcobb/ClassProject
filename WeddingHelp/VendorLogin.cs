USE [WeddingHelp]
GO

/****** Object:  Table [dbo].[VendorLogin]    Script Date: 8/4/2019 4:40:39 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[VendorLogin](
	[VendorID] [int] NOT NULL,
	[VendorUserID] [int] NOT NULL,
	[VendorPassword] [varchar](50) NOT NULL
) ON [PRIMARY]
GO

