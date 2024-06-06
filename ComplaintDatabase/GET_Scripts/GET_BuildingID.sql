CREATE PROCEDURE [dbo].[GET_BuildingID]
	@Street varchar(50),
	@StreetNumber int
AS
BEGIN
	SELECT Id
	FROM Buildings
	WHERE Street = @Street AND StreetNumber = @StreetNumber;
END
