CREATE PROCEDURE [dbo].[SP_InsertReserv]
	@StartDateLocation datetime2(7),
	@EndDateLocation datetime2(7),
	@ReturnAgency int,
	@DamageCover bit,
	@RobberyCover bit,
	@AgeRange bit,
	@UserId int,
	@AgencyId int,
	@CategoryId int
AS
	BEGIN
		INSERT INTO Reservation(ReservationDate, StartDateLocation, EndDateLocation, ReturnAgency, DamageCover, 
		RobberyCover, AgeRange, UserId, AgencyId, CategoryId)
		OUTPUT inserted.Id 
		VALUES (GetDate(), @StartDateLocation, @EndDateLocation, @ReturnAgency, @DamageCover, @RobberyCover, @AgeRange, @UserId,
		@AgencyId, @CategoryId) 
	END
