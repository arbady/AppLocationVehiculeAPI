CREATE PROCEDURE [dbo].[SP_UpdateReserv]
	@Id int, 
	@ReservationDate datetime2(7),
	@StartDateLocation datetime2(7),
	@EndDateLocation datetime2(7),
	@AmountTotTVA float,
	@Deposit float,
	@DepositPaid bit,
	@ReservationStatus bit,
	@ReturnAgency nvarchar(50),
	@DamageCover bit,
	@RobberyCover bit,
	@AgeRange bit,
	@PaidAll bit,
	@IsCancelled bit,
	@UserId int,
	@AgencyId int,
	@CategoryId int
AS
	BEGIN
		UPDATE Reservation
		SET ReservationDate=@ReservationDate, StartDateLocation=@StartDateLocation, 
		EndDateLocation=@EndDateLocation, AmountTotTVA=@AmountTotTVA, Deposit=@Deposit, DepositPaid=@DepositPaid, 
		ReservationStatus=@ReservationStatus, ReturnAgency=@ReservationDate, DamageCover=@DamageCover, 
		RobberyCover=@RobberyCover, AgeRange=@AgeRange, PaidAll=@PaidAll, IsCancelled=@IsCancelled, UserId=@UserId,
		AgencyId=@AgencyId, CategoryId=@CategoryId
		WHERE Id=@Id
	END
