CREATE PROCEDURE [dbo].[GET_Tenant]
	@Name varchar(50),
	@Surname varchar(50)
AS
BEGIN
	SELECT Id
	FROM Tenants
	WHERE Name = @Name AND Surname = @Surname;
END