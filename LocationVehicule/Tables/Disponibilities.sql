CREATE TABLE [dbo].[Disponibilities]
(
	[Id] int IDENTITY(1,1) NOT NULL,
	[EntryDate] datetime2(7) NOT NULL,
	[IsInput] BIT NOT NULL,
	[AgencyId] int NOT NULL,
	[VehicleId] int NOT NULL, 
    CONSTRAINT [PK_Disponibilities] PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_Disponibilities_Vehicle] FOREIGN KEY ([VehicleId]) REFERENCES Vehicle(Id), 
    CONSTRAINT [FK_Disponibilites_Agency] FOREIGN KEY ([AgencyId]) REFERENCES Agency(Id) 
)
