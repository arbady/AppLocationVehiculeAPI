CREATE PROCEDURE [dbo].[SP_InsertMark]
	@Name nvarchar(50)
AS
	BEGIN
		INSERT INTO Mark([Name])
		OUTPUT inserted.Id 
		VALUES (@Name) 
	END