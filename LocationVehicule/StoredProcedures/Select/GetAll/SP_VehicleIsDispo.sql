CREATE PROCEDURE SP_VehicleIsDispo
	--@vehicleId int,
	@date DATETIME2,
	@agencyId int,
	@categoryId int
AS

SELECT Vehicle.*
FROM Vehicle
JOIN Disponibilities d ON Vehicle.Id = d.VehicleId
WHERE d.IsInput = 1
AND d.AgencyId = @agencyId
AND Vehicle.CategoryId = @categoryId
AND d.EntryDate <= @date
AND d.EntryDate > (SELECT MAX(EntryDate) FROM Disponibilities WHERE IsInput = 0 AND d.VehicleId=Disponibilities.VehicleId)
RETURN 0
