CREATE PROCEDURE [dbo].[INSERT_Complaint]
	@Complainer uniqueidentifier,
	@Description varchar(50),
	@Category int,
	@status int,
	@Name varchar(50)
AS
INSERT INTO Complaints
(Id,Complainer,Description,Category,status,created,Name)
values
(NEWID(),@Complainer,@Description,@Category,@status,SYSUTCDATETIME(),@Name)
