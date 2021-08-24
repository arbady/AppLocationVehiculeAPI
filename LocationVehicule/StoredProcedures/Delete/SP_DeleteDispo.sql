CREATE PROCEDURE [dbo].[SP_DeleteDispo]
	@Id INT
AS
	BEGIN
		DELETE FROM Disponibilities WHERE Id = @Id
	END
