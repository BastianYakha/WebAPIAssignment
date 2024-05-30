CREATE TABLE [dbo].[Complaints]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
	[ComplainerLocation] UNIQUEIDENTIFIER NOT NULL, 
    [Location] UNIQUEIDENTIFIER NOT NULL, 
    [Description] VARCHAR(50) NOT NULL,
	[Category] INT NOT NULL, 
    [status] INT NOT NULL, 
    [lastUpdated] DATETIME NOT NULL
)
