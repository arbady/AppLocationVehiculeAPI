CREATE PROCEDURE [dbo].[SP_AllVehicleByAgency]
	@agencyid int 
AS
	SELECT Vehicle.*
	FROM Vehicle
	JOIN Disponibilities d ON Vehicle.Id = d.VehicleId 
	WHERE d.AgencyId = @agencyid 
	AND IsInput = 1 
	AND EntryDate = (SELECT MAX(EntryDate) FROM Disponibilities WHERE VehicleId=d.vehicleId)
RETURN 0
