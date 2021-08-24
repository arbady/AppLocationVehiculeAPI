CREATE PROCEDURE [dbo].[SP_GetByIdAgency]
	@id int
AS
	SELECT a.* 
	FROM Agency a
	WHERE a.Id=@id
RETURN 0
