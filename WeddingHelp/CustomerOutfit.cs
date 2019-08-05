USE [WeddingHelp]
GO

/****** Object:  Table [dbo].[CustomerOutfit]    Script Date: 8/4/2019 4:37:45 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CustomerOutfit](
	[WaistLine] [int] NOT NULL,
	[BustSize] [int] NOT NULL,
	[Height] [int] NOT NULL,
	[Inseam] [int] NOT NULL,
	[DesiredDate] [varchar](50) NOT NULL,
	[FullBodyPhoto] [varchar](100) NOT NULL,
	[OutfitID] [int] NOT NULL,
	[CustomerID] [int] NOT NULL
) ON [PRIMARY]
GO

