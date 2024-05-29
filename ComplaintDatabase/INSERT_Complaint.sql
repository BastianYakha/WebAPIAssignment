CREATE PROCEDURE [dbo].[INSERT_Complaint]
	@ComplainerLocation uniqueidentifier,
	@Location uniqueidentifier,
	@Description varchar(50),
	@Category varchar(50),
	@status varchar(50)
AS
INSERT INTO Complaints
(Id,ComplainerLocation,Location,Description,Category,status,LastUpdated)
values
(NEWID(),@ComplainerLocation,@Location,@Description,@Category,@status,SYSUTCDATETIME())
