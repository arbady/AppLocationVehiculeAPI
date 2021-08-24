CREATE PROCEDURE [dbo].[SP_UpdateContract]
	@Id int,
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
		UPDATE [Contract]
		SET ContractNum=@ContractNum, RealReturnDate=@RealReturnDate, DepartKm=@DepartKm, BackKm=@BackKm, 
		ContractDate=@ContractDate, AmountTotHTVA=@AmountTotHTVA, AmountTotTVA=@AmountTotTVA, Signed=@Signed, 
		ReservationId=@ReservationId, VehicleId=@VehicleId, PenalizationId=@PenalizationId
		WHERE Id=@Id
	END
