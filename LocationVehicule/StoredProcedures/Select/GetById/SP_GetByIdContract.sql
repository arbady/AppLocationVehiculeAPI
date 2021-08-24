CREATE PROCEDURE [dbo].[SP_GetByIdContract]
	@id int
AS
	SELECT c.* 
	FROM [Contract] c
	WHERE c.Id=@id
RETURN 0
