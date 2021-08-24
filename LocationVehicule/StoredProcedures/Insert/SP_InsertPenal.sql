CREATE PROCEDURE [dbo].[SP_InsertPenal]
	@Description nvarchar(1000) null,
	@PenalDate datetime2(7), 
	@AmountOwed float, 
	@AmountPaid float
AS
	BEGIN
		INSERT INTO Penalization([Description], PenalDate, AmountOwed, AmountPaid)
		OUTPUT inserted.Id 
		VALUES (@Description, @PenalDate, @AmountOwed, @AmountPaid) 
	END
