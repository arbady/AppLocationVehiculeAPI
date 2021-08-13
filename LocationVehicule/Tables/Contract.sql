CREATE TABLE [dbo].[Contract]
(
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ContractNum] int NOT NULL,
	[RealReturnDate] datetime2(7) NOT NULL,
	[DepartKm] nvarchar(max) NULL,
	[BackKm] nvarchar(max) NULL,
	[ContractDate] datetime2(7) NOT NULL,
	[AmountTotHTVA] float NOT NULL,
	[AmountTotTVA] float NOT NULL,
	[Signed] bit NOT NULL DEFAULT 0,
	[ReservationId] int NOT NULL,
	[VehicleId] int NOT NULL,
	[PenalizationId] int NOT NULL,
    CONSTRAINT [PK_Contract] PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_Contract_Reservation] FOREIGN KEY (ReservationId) REFERENCES Reservation(Id), 
    CONSTRAINT [FK_Contract_Vehicle] FOREIGN KEY ([VehicleId]) REFERENCES Vehicle(Id), 
    CONSTRAINT [FK_Contrat_Penalisation] FOREIGN KEY ([PenalizationId]) REFERENCES Penalization(Id) 
)
