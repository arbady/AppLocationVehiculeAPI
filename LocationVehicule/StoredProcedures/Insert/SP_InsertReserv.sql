CREATE PROCEDURE [dbo].[SP_InsertReserv]
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
		INSERT INTO Reservation(ReservationDate, StartDateLocation, EndDateLocation, AmountTotTVA, Deposit, 
		DepositPaid, ReservationStatus, ReturnAgency, DamageCover, RobberyCover, AgeRange, PaidAll, IsCancelled, 
		UserId, AgencyId, CategoryId)
		OUTPUT inserted.Id 
		VALUES (@ReservationDate, @StartDateLocation, @EndDateLocation, @AmountTotTVA, @Deposit, @DepositPaid, 
		@ReservationStatus, @ReturnAgency, @DamageCover, @RobberyCover, @AgeRange, @PaidAll, @IsCancelled, @UserId,
		@AgencyId, @CategoryId) 
	END
