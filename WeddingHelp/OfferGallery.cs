USE [WeddingHelp]
GO

/****** Object:  Table [dbo].[OfferGallery]    Script Date: 8/4/2019 4:39:12 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OfferGallery](
	[VendorID] [int] NOT NULL,
	[AcceptOrDecline] [text] NOT NULL,
	[CustomerID] [int] NOT NULL,
	[OfferID] [int] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

