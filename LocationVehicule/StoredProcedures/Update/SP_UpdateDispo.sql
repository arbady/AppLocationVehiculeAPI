CREATE PROCEDURE [dbo].[SP_UpdateDispo]
	@Id int, 
	@AvailDateDepart datetime2(7),
	@AvailDateReturn datetime2(7),
	@AgencyId int,
	@VehicleId int
AS
	BEGIN
		UPDATE Disponibilities
		SET AvailDateDepart=@AvailDateDepart, AvailDateReturn=@AvailDateReturn, AgencyId=@AgencyId, 
			VehicleId=@VehicleId
		WHERE Id=@Id
	END
