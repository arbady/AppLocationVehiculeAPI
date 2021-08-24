CREATE PROCEDURE [dbo].[SP_UpdateVehicle]
	@Id int, 
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
		UPDATE Vehicle
		SET RegistrationNum=@RegistrationNum, Characteristic=@Characteristic, NbPlace=@NbPlace, NbDoor=@NbDoor, 
		Fuel=@Fuel, AirCo=@AirCo, Gps=@Gps, Transmission=@Transmission, StateId=@StateId, ModelId=@ModelId, 
		CategoryId=@CategoryId
		WHERE Id=@Id
	END
