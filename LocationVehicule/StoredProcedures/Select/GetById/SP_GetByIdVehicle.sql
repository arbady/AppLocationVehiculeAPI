CREATE PROCEDURE [dbo].[SP_GetByIdVehicle]
	@id int
AS
	SELECT v.* 
	FROM Vehicle v
	WHERE v.Id=@id
RETURN 0
