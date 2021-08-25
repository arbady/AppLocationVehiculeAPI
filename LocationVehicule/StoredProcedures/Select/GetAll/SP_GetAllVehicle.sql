CREATE PROCEDURE [dbo].[SP_GetAllVehicle]
	
AS
	SELECT v.* 
	FROM Vehicle v
	JOIN [State] s ON v.StateId=s.Id
	JOIN Model m ON v.ModelId=m.Id
	JOIN Category c ON v.CategoryId=c.Id
RETURN 0
