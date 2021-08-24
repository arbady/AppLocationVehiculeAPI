CREATE PROCEDURE [dbo].[SP_GetByIdDispo]
	@id int
AS
	SELECT d.* 
	FROM Disponibilities d
	WHERE d.Id=@id
RETURN 0
