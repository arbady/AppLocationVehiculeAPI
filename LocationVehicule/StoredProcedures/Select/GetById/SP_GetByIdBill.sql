CREATE PROCEDURE [dbo].[SP_GetByIdBill]
	@id int
AS
	SELECT b.* 
	FROM Bill b
	WHERE b.Id=@id
RETURN 0
