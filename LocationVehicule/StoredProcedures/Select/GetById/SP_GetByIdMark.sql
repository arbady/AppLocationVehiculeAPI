CREATE PROCEDURE [dbo].[SP_GetByIdMark]
	@id int
AS
	SELECT m.* 
	FROM Mark m
	WHERE m.Id=@id
RETURN 0
