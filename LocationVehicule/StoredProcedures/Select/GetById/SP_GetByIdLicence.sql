CREATE PROCEDURE [dbo].[SP_GetByIdLicence]
	@id int
AS
	SELECT l.* 
	FROM Licence l
	WHERE l.Id=@id
RETURN 0
