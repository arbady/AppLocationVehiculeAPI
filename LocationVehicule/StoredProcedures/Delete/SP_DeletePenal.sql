CREATE PROCEDURE [dbo].[SP_DeletePenal]
	@Id INT
AS
	BEGIN
		DELETE FROM Penalization WHERE Id = @Id
	END