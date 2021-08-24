CREATE PROCEDURE [dbo].[SP_GetByIdModel]
	@id int
AS
	SELECT m.* 
	FROM Model m
	WHERE m.Id=@id
RETURN 0
