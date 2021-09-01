CREATE PROCEDURE [dbo].[SP_GetAgencyByIdVehicle]
	@idvehicle int
AS
	SELECT a.*
	FROM Agency a
	JOIN Disponibilities d ON d.AgencyId = a.Id
	WHERE d.VehicleId = @idvehicle
	AND IsInput = 1
	AND EntryDate > (SELECT MAX(EntryDate) FROM Disponibilities WHERE VehicleId = @idvehicle AND IsInput = 0 )
RETURN 0
