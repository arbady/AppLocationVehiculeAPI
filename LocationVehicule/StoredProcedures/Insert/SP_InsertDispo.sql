CREATE PROCEDURE [dbo].[SP_InsertDispo]
	@AvailDateDepart datetime2(7),
	@AvailDateReturn datetime2(7),
	@AgencyId int,
	@VehicleId int
AS
	BEGIN
		INSERT INTO Disponibilities(AvailDateDepart, AvailDateReturn, AgencyId, VehicleId)
		OUTPUT inserted.Id 
		VALUES (@AvailDateDepart, @AvailDateReturn, @AgencyId, @VehicleId) 
	END
