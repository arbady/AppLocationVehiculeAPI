CREATE PROCEDURE [dbo].[SP_DeleteVehicle]
	@Id INT
AS
	BEGIN
		DELETE FROM Vehicle WHERE Id = @Id
	END