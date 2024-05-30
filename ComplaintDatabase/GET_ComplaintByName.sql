CREATE PROCEDURE [dbo].[GET_ComplaintByName]
	@Name varchar(50)
AS
BEGIN
	SELECT *
	FROM Complaints
	WHERE Name = @Name
END