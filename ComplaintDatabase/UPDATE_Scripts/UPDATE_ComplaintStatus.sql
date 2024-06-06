CREATE PROCEDURE [dbo].[UPDATE_ComplaintStatus]
	@Id uniqueidentifier,
	@status int
AS
BEGIN
	UPDATE Complaints
	SET status = @status
	WHERE Id = @Id;
END