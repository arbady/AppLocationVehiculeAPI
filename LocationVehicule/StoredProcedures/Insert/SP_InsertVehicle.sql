CREATE PROCEDURE [dbo].[SP_InsertVehicle]
	@RegistrationNum char(7),
	@Characteristic nvarchar(255) null,
	@NbPlace int,
	@NbDoor int,
	@Fuel int,
	@AirCo bit,
	@Gps bit,
	@Transmission int null,
	@StateId int,
	@ModelId int,
	@CategoryId int
AS
	BEGIN
		INSERT INTO Vehicle(RegistrationNum, Characteristic, NbPlace, NbDoor, Fuel, AirCo, Gps, Transmission, 
		StateId, ModelId, CategoryId)
		OUTPUT inserted.Id 
		VALUES (@RegistrationNum, @Characteristic, @NbPlace, @NbDoor, @Fuel, @AirCo, @Gps, @Transmission, @StateId,
		@ModelId, @CategoryId) 
	END
