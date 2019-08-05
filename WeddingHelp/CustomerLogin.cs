USE [WeddingHelp]
GO

/****** Object:  Table [dbo].[CustomerLogin]    Script Date: 8/4/2019 4:36:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CustomerLogin](
	[CustomerUserID] [varchar](50) NOT NULL,
	[CustPassword] [varchar](50) NOT NULL,
	[CustomerID] [int] NOT NULL
) ON [PRIMARY]
GO

