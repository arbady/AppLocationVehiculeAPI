CREATE PROCEDURE [dbo].[SP_UpdateModel]
	@Id int, 
	@Name nvarchar(50),
	@MarkId int
AS
	BEGIN
		UPDATE Model
		SET [Name]=@Name, MarkId=@MarkId
		WHERE Id=@Id
	END
