USE [Flightservice]
GO

/****** Object:  Table [dbo].[plane]    Script Date: 7/27/2020 12:28:22 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[plane](
	[planeId] [int] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[capacity] [int] NOT NULL,
 CONSTRAINT [PK_plane] PRIMARY KEY CLUSTERED 
(
	[planeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


