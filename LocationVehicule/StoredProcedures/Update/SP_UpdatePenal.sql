CREATE PROCEDURE [dbo].[SP_UpdatePenal]
	@Id int, 
	@Description nvarchar(1000) null,
	@PenalDate datetime2(7), 
	@AmountOwed float, 
	@AmountPaid float
AS
	BEGIN
		UPDATE Penalization
		SET [Description]=@Description, PenalDate=@PenalDate, AmountOwed=@AmountOwed, AmountPaid=@AmountPaid
		WHERE Id=@Id
	END
