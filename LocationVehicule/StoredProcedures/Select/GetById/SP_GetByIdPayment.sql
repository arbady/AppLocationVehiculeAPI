CREATE PROCEDURE [dbo].[SP_GetByIdPayment]
	@id int
AS
	SELECT pm.* 
	FROM PaymentMethod pm
	WHERE pm.Id=@id
RETURN 0
