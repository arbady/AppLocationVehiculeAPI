CREATE PROCEDURE [dbo].[SP_InsertState]
	@Description nvarchar(50) NULL,
	@StateType int
AS
	BEGIN
		INSERT INTO [State]([Description], StateType)
		OUTPUT inserted.Id 
		VALUES (@Description, @StateType) 
	END
