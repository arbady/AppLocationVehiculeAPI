CREATE PROCEDURE [dbo].[SP_DeleteAgency]
	@Id INT
AS
	BEGIN
		DELETE FROM Agency WHERE Id = @Id
	END
	