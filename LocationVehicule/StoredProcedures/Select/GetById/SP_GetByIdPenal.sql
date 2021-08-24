CREATE PROCEDURE [dbo].[SP_GetByIdPenal]
	@id int
AS
	SELECT p.* 
	FROM Penalization p
	WHERE p.Id=@id
RETURN 0
