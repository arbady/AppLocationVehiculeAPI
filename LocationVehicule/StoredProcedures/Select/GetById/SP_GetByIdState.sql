CREATE PROCEDURE [dbo].[SP_GetByIdState]
	@id int
AS
	SELECT s.* 
	FROM [State] s
	WHERE s.Id=@id
RETURN 0
