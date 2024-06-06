CREATE PROCEDURE [dbo].[INSERT_Building]
	@Street varchar(50),
	@StreetNumber int
AS
INSERT INTO Buildings
(Id,Street,StreetNumber)
values
(NEWID(),@Street,@StreetNumber)
