CREATE PROCEDURE [dbo].[SP_UpdateMark]
	@Id int, 
	@Name nvarchar(50)
AS
	BEGIN
		UPDATE Mark
		SET [Name]=@Name
		WHERE Id=@Id
	END
