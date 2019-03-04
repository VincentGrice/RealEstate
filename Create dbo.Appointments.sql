USE [RealEstate]
GO

/****** Object: Table [dbo].[Appointments] Script Date: 2/26/2019 2:48:24 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Appointments] (
    [Id]                  INT            IDENTITY (1, 1) NOT NULL,
    [CustomerName]        NVARCHAR (MAX) NULL,
    [CustomerEmail]       NVARCHAR (MAX) NULL,
    [CustomerPhoneNumber] NVARCHAR (MAX) NULL,
    [AppointmentDate]     DATETIME2 (7)  NOT NULL,
	[Discriminator]		  INT			 NULL
);


