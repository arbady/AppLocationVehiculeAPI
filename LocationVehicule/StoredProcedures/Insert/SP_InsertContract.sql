CREATE PROCEDURE [dbo].[SP_InsertContract]
	@ContractNum int,
	@RealReturnDate datetime2(7),
	@DepartKm nvarchar(max) null,
	@BackKm nvarchar(max) null,
	@ContractDate datetime2(7),
	@AmountTotHTVA float,
	@AmountTotTVA float,
	@Signed bit,
	@ReservationId int,
	@VehicleId int,
	@PenalizationId int
AS
	BEGIN
		INSERT INTO [Contract](ContractNum, RealReturnDate, DepartKm, BackKm, ContractDate, AmountTotHTVA, 
								AmountTotTVA, Signed, ReservationId, VehicleId, PenalizationId)
		OUTPUT inserted.Id 
		VALUES (@ContractNum, @RealReturnDate, @DepartKm, @BackKm, @ContractDate, @AmountTotHTVA, @AmountTotTVA, 
				@Signed, @ReservationId, @VehicleId, @PenalizationId) 
	END
