CREATE PROCEDURE [dbo].[SP_UpdateReserv]
	@Id int, 
	@ReservationDate datetime2(7),
	@StartDateLocation datetime2(7),
	@EndDateLocation datetime2(7),
	@ReturnAgency int,
	@DamageCover bit,
	@RobberyCover bit,
	@AgeRange bit,
	@IsCancelled bit,
	@UserId int,
	@AgencyId int,
	@CategoryId int
AS
	BEGIN
		UPDATE Reservation
		SET ReservationDate=@ReservationDate, StartDateLocation=@StartDateLocation, 
		EndDateLocation=@EndDateLocation, ReturnAgency=@ReturnAgency, DamageCover=@DamageCover, 
		RobberyCover=@RobberyCover, AgeRange=@AgeRange, IsCancelled=@IsCancelled, UserId=@UserId,
		AgencyId=@AgencyId, CategoryId=@CategoryId
		WHERE Id=@Id
	END
