CREATE PROCEDURE [dbo].[SP_InsertCategory]
	@TypeCat int,
	@CostPerDay float
AS
	BEGIN
		INSERT INTO Category(TypeCat, CostPerDay)
		OUTPUT inserted.Id 
		VALUES (@TypeCat, @CostPerDay) 
	END
