CREATE PROCEDURE [dbo].[GET_AllBuildings]

AS
SELECT Id,Street,StreetNumber,buildingApartments FROM Buildings
