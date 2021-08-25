CREATE PROCEDURE [dbo].[SP_GetAllContract]
	
AS
	SELECT c.* 
	FROM [Contract] c
	JOIN Reservation r ON c.ReservationId=r.Id
	JOIN Penalization p ON c.PenalizationId=r.Id
	JOIN Vehicle v ON c.VehicleId=r.Id
RETURN 0
