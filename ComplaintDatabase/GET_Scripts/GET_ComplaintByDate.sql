CREATE PROCEDURE [dbo].[GET_ComplaintByDate]
	@created datetime
AS
BEGIN
	SELECT *
	FROM Complaints
	WHERE created = @created
END