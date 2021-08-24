CREATE PROCEDURE [dbo].[SP_GetByIdCategory]
	@id int
AS
	SELECT c.* 
	FROM Category c
	WHERE c.Id=@id
RETURN 0
