CREATE PROCEDURE [dbo].[INSERT_Complaint]
	@ComplainerLocation uniqueidentifier,
	@Location uniqueidentifier,
	@Description varchar(50),
	@Category int,
	@status int
AS
INSERT INTO Complaints
(Id,ComplainerLocation,Location,Description,Category,status,LastUpdated)
values
(NEWID(),@ComplainerLocation,@Location,@Description,@Category,@status,SYSUTCDATETIME())
