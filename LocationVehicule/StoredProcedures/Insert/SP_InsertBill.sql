CREATE PROCEDURE [dbo].[SP_InsertBill]
	@BillNum NVARCHAR(50),
	@Wording nvarchar(50),
	@BillDate datetime2(7),
	@AmountTotHTVA float,
	@AmountTotTVA float,
	@Paid bit,
	@ContractId int,
	@PaymentMethodId int
AS
	BEGIN
		INSERT INTO Bill (BillNum, Wording, BillDate, AmountTotHTVA, AmountTotTVA, Paid, ContractId, PaymentMethodId)
		OUTPUT inserted.Id 
		VALUES (@BillNum, @Wording, @BillDate, @AmountTotHTVA, @AmountTotTVA, @Paid, @ContractId, @PaymentMethodId) 
	END
