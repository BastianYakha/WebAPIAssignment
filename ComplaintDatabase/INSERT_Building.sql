CREATE PROCEDURE [dbo].[INSERT_Building]
	@Street varchar(50),
	@StreetNumber int,
	@buildingApartments varchar(MAX) = NULL
AS
INSERT INTO Building
(Id,Street,StreetNumber,buildingApartments)
values
(NEWID(),@Street,@StreetNumber,@buildingApartments)
