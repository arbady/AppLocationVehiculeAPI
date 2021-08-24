CREATE PROCEDURE [dbo].[SP_UpdatePayment]
	@Id int, 
	@Method int
AS
	BEGIN
		UPDATE PaymentMethod
		SET Method=@Method
		WHERE Id=@Id
	END
