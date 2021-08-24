CREATE PROCEDURE [dbo].[SP_UpdateState]
	@Id int, 
	@Description nvarchar(50) NULL,
	@StateType int
AS
	BEGIN
		UPDATE [State]
		SET [Description]=@Description, StateType=@StateType
		WHERE Id=@Id
	END
