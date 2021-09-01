CREATE TABLE [dbo].[Booking]
(
	[Id] INT  IDENTITY NOT NULL PRIMARY KEY,
	[AmountTotTVA] float NOT NULL,
	[Deposit] float NOT NULL,
	[DepositPaid] bit NOT NULL default 0,
	[ReservationStatus] bit NOT NULL,
	[PaidAll] bit NOT NULL default 0,
	[ReservationId] int NOT NULL unique,
	CONSTRAINT [FK_Booking_Reservation] FOREIGN KEY (ReservationId) REFERENCES [Reservation](Id)

)
