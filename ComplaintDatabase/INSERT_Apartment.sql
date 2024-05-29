CREATE PROCEDURE [dbo].[INSERT_Apartment]
	@ApartmentName varchar(50),
	@tenant uniqueidentifier = NULL
AS
INSERT INTO Apartments
(Id,ApartmentName, tenant)
values
(NEWID(),@ApartmentName,@tenant)
