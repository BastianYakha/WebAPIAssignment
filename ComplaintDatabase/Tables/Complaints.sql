CREATE TABLE [dbo].[Complaints]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
	[Complainer] UNIQUEIDENTIFIER NOT NULL,
    [Description] VARCHAR(MAX) NOT NULL,
	[Category] INT NOT NULL, 
    [status] INT NOT NULL, 
    [created] DATETIME NOT NULL, 
    [Name] VARCHAR(50) NOT NULL
)
