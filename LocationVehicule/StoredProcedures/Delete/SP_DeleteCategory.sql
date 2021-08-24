CREATE PROCEDURE [dbo].[SP_DeleteCategory]
	@Id INT
AS
	BEGIN
		DELETE FROM Category WHERE Id = @Id
	END
