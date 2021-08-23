CREATE FUNCTION [dbo].[SF_HashingPassword]
(
	@password varchar(20),
	@salt UniqueIdentifier
)
RETURNS VARBINARY(32)
AS
BEGIN
	Declare @saltSTR char(36)
	Declare @saltyPassword varchar(56)
	Set @saltSTR = CONVERT(char(36), @salt)
	Set @saltyPassword = SUBSTRING(@saltSTR, 1, 18) + @password + SUBSTRING(@saltSTR, 19, 18)
	Return hashbytes('SHA2_256', @saltyPassword)
END
