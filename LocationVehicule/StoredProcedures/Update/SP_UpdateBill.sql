CREATE PROCEDURE [dbo].[SP_UpdateBill]
	@Id int,
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
		UPDATE Bill
		SET BillNum=@BillNum, Wording=@Wording, BillDate=@BillDate, AmountTotHTVA=@AmountTotHTVA, 
		AmountTotTVA=@AmountTotTVA, Paid=@Paid, ContractId=@ContractId, PaymentMethodId=@PaymentMethodId
		WHERE Id=@Id
	END
