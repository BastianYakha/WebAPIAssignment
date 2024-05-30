CREATE PROCEDURE [dbo].[INSERT_Complaint]
	@ComplainerLocation uniqueidentifier,
	@Location uniqueidentifier,
	@Description varchar(50),
	@Category int,
	@status int,
	@Name varchar(50)
AS
INSERT INTO Complaints
(Id,ComplainerLocation,Location,Description,Category,status,created,Name)
values
(NEWID(),@ComplainerLocation,@Location,@Description,@Category,@status,SYSUTCDATETIME(),@Name)
