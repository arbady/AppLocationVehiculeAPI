CREATE PROCEDURE [dbo].[SP_GetByIdUser]
	@id int
AS
	SELECT u.* 
	FROM [User] u
	WHERE u.Id=@id
RETURN 0
