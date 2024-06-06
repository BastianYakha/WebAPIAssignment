CREATE PROCEDURE [dbo].[UPDATE_Complaint]
	@Id uniqueidentifier,
	@Description varchar(MAX),
	@status int
AS
BEGIN
	UPDATE Complaints
	SET Description = @Description, status = @status
	WHERE Id = @Id;
END
