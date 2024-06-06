CREATE PROCEDURE [dbo].[INSERT_Tenant]
	@Name varchar(50),
	@Surname varchar(50)
AS
BEGIN
	INSERT INTO Tenants
	(Id,Name,Surname)
	values
	(NEWID(),@Name,@Surname)
END
