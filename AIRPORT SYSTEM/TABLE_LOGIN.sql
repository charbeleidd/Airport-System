USE [Flightservice]
GO

/****** Object:  Table [dbo].[login]    Script Date: 7/27/2020 12:27:54 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[login](
	[username] [nvarchar](max) NOT NULL,
	[password] [nvarchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


