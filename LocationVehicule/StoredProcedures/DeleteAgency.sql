CREATE PROCEDURE [dbo].[DeleteAgency]
	@AgenceId INT
AS
	BEGIN
		DELETE FROM Agence WHERE Id = @AgenceId
	END
