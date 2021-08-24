CREATE PROCEDURE [dbo].[SP_InsertPayment]
	@Method int
AS
	BEGIN
		INSERT INTO PaymentMethod(Method)
		OUTPUT inserted.Id 
		VALUES (@Method) 
	END
