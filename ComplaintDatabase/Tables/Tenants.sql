﻿CREATE TABLE [dbo].[Tenants]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(50) NOT NULL, 
    [Surname] VARCHAR(50) NOT NULL,
    [Apartment] UNIQUEIDENTIFIER
)
