CREATE PROCEDURE [dbo].[SP_UpdateDispo]
	@Id int, 
	@entryDate datetime2(7),
	@isinput bit,
	@AgencyId int,
	@VehicleId int
AS
	BEGIN
		UPDATE Disponibilities
		SET EntryDate=@entryDate, IsInput=@isinput, AgencyId=@AgencyId, 
			VehicleId=@VehicleId
		WHERE Id=@Id
	END
