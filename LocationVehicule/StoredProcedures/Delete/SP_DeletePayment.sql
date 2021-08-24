CREATE PROCEDURE [dbo].[SP_DeletePayment]
	@Id INT
AS
	BEGIN
		DELETE FROM PaymentMethod WHERE Id = @Id
	END
