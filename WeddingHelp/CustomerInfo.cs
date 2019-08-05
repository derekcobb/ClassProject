USE [WeddingHelp]
GO

/****** Object:  Table [dbo].[CustomerInfo]    Script Date: 8/4/2019 4:35:12 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CustomerInfo](
	[CustomerID] [int] NOT NULL,
	[CustomerFName] [text] NOT NULL,
	[CustomerLName] [text] NOT NULL,
	[ContactNum] [int] NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Age] [int] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

