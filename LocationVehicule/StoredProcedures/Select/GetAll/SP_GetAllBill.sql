CREATE PROCEDURE [dbo].[SP_GetAllBill]
	
AS
	SELECT b.* 
	FROM Bill b
	JOIN [Contract] c ON b.ContractId=c.Id
	JOIN PaymentMethod p ON b.PaymentMethodId=p.Id
RETURN 0
