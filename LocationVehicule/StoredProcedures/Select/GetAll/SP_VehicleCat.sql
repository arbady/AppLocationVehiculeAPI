CREATE PROCEDURE [dbo].[SP_VehicleCat]
	@catid int 
AS
	SELECT Vehicle.*
	FROM Vehicle
	WHERE CategoryId = @catid
RETURN 0
