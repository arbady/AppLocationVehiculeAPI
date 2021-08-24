CREATE PROCEDURE [dbo].[SP_DeleteReserv]
	@Id INT
AS
	BEGIN
		DELETE FROM Reservation WHERE Id = @Id
	END
