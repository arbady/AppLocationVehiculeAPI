CREATE PROCEDURE [dbo].[SP_GetAllDispo]
	
AS
	SELECT d.* 
	FROM Disponibilities d
	JOIN Agency a ON d.AgencyId = a.Id
	JOIN Vehicle v ON d.VehicleId = v.Id
RETURN 0
