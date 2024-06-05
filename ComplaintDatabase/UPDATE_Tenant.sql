CREATE PROCEDURE [dbo].[UPDATE_Tenant]
	@Id uniqueidentifier,
	@apartment varchar(50)
AS
BEGIN
	UPDATE Tenants
	SET Apartment = @apartment
	WHERE Id = @Id;
END
