﻿CREATE TABLE [dbo].[Complaints]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
	[ComplainerLocation] UNIQUEIDENTIFIER NOT NULL, 
    [Location] UNIQUEIDENTIFIER NOT NULL, 
    [Description] VARCHAR(50) NOT NULL,
	[Category] VARCHAR(50) NOT NULL, 
    [status] VARCHAR(50) NOT NULL, 
    [lastUpdated] DATETIME NOT NULL
)
