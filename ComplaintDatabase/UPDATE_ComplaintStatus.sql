CREATE PROCEDURE [dbo].[UPDATE_ComplaintStatus]
	@Id uniqueidentifier,
	@status int
AS
BEGIN
	UPDATE Complaints
	SET status = @status, LastUpdated = SYSUTCDATETIME()
	WHERE Id = @Id;
END