CREATE PROCEDURE [dbo].[SP_DeleteLicence]
	@Id INT
AS
	BEGIN
		DELETE FROM Licence WHERE Id = @Id
	END
