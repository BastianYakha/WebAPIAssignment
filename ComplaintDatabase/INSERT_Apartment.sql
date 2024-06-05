CREATE PROCEDURE [dbo].[INSERT_Apartment]
	@ApartmentName varchar(50),
	@Building varchar (50)
AS
INSERT INTO Apartments
(Id,ApartmentName,Building)
values
(NEWID(),@ApartmentName,@Building)
