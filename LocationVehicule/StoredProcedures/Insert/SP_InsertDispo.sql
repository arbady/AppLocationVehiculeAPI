CREATE PROCEDURE [dbo].[SP_InsertDispo]
	@entryDate datetime2(7),
	@isinput bit,
	@AgencyId int,
	@VehicleId int
AS
	BEGIN
		INSERT INTO Disponibilities(EntryDate, IsInput, AgencyId, VehicleId)
		OUTPUT inserted.Id 
		VALUES (@entryDate, @isinput, @AgencyId, @VehicleId) 
	END
