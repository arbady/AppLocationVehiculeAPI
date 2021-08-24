CREATE PROCEDURE [dbo].[SP_InsertModel]
	@Name nvarchar(50),
	@MarkId int
AS
	BEGIN
		INSERT INTO Model([Name], MarkId)
		OUTPUT inserted.Id 
		VALUES (@Name, @MarkId) 
	END
