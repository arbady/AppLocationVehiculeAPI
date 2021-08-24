CREATE PROCEDURE [dbo].[SP_UpdateCategory]
	@Id int, 
	@TypeCat int,
	@CostPerDay float
AS
	BEGIN
		UPDATE Category
		SET TypeCat=@TypeCat, CostPerDay=@CostPerDay
		WHERE Id=@Id
	END
