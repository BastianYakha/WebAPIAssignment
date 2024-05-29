CREATE TABLE [dbo].[Buildings]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Street] VARCHAR(50) NOT NULL, 
    [StreetNumber] INT NOT NULL, 
    [buildingApartments] VARCHAR(MAX) NULL
)
