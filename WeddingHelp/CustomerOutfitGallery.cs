USE [WeddingHelp]
GO

/****** Object:  Table [dbo].[CustOutFitGallery]    Script Date: 8/4/2019 4:38:18 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CustOutFitGallery](
	[CustomerID] [int] NOT NULL,
	[OutFitID] [int] NOT NULL,
	[BidCounter] [int] NOT NULL,
	[Status] [int] NOT NULL
) ON [PRIMARY]
GO

