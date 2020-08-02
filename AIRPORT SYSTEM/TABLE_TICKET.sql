USE [Flightservice]
GO

/****** Object:  Table [dbo].[ticket]    Script Date: 7/27/2020 12:28:35 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ticket](
	[ticketid] [int] IDENTITY(1,1) NOT NULL,
	[nameid] [int] NOT NULL,
	[departcountry] [varchar](60) NOT NULL,
	[arrivecountry] [varchar](60) NOT NULL,
	[departtime] [datetime] NOT NULL,
	[price] [varchar](50) NOT NULL,
	[planeid] [int] NULL,
	[gate] [int] NOT NULL,
 CONSTRAINT [PK_ticket] PRIMARY KEY CLUSTERED 
(
	[ticketid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ticket]  WITH CHECK ADD  CONSTRAINT [FK_ticket_countries] FOREIGN KEY([departcountry])
REFERENCES [dbo].[COUNTRIES] ([countryname])
GO

ALTER TABLE [dbo].[ticket] CHECK CONSTRAINT [FK_ticket_countries]
GO

ALTER TABLE [dbo].[ticket]  WITH CHECK ADD  CONSTRAINT [FK_ticket_countries1] FOREIGN KEY([arrivecountry])
REFERENCES [dbo].[COUNTRIES] ([countryname])
GO

ALTER TABLE [dbo].[ticket] CHECK CONSTRAINT [FK_ticket_countries1]
GO

ALTER TABLE [dbo].[ticket]  WITH CHECK ADD  CONSTRAINT [FK_ticket_passenger] FOREIGN KEY([nameid])
REFERENCES [dbo].[passenger] ([passengerid])
GO

ALTER TABLE [dbo].[ticket] CHECK CONSTRAINT [FK_ticket_passenger]
GO

ALTER TABLE [dbo].[ticket]  WITH CHECK ADD  CONSTRAINT [FK_ticket_plane] FOREIGN KEY([planeid])
REFERENCES [dbo].[plane] ([planeId])
GO

ALTER TABLE [dbo].[ticket] CHECK CONSTRAINT [FK_ticket_plane]
GO


