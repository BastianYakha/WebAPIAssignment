CREATE PROCEDURE [dbo].[UPDATE_Complaint]
	@Id uniqueidentifier,
	@Description varchar(50),
	@status varchar(50)
AS
BEGIN
	UPDATE Complaints
	SET Description = @Description, status = @status, LastUpdated = SYSUTCDATETIME()
	WHERE Id = @Id;
END
