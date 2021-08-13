CREATE TABLE [dbo].[Vehicle]
(
	[Id] INT IDENTITY(1,1) NOT NULL, 
	[RegistrationNum] char(7) NOT NULL,
	[Characteristic] nvarchar(255) NULL,
	[NbPlace] int NOT NULL,
	[NbDoor] int NOT NULL,
	[Fuel] int NOT NULL,
	[AirCo] bit NOT NULL default 0,
	[Gps] bit NOT NULL default 0,
	[Transmission] INT NULL,
	[StateId] int NOT NULL,
	[ModelId] int NOT NULL,
	[CategoryId] int NOT NULL,
    CONSTRAINT [PK_Vehicule] PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_Vehicule_Etat] FOREIGN KEY (StateId) REFERENCES State(Id), 
    CONSTRAINT [FK_Vehicule_ModeleId] FOREIGN KEY (ModelId) REFERENCES Model(Id), 
    CONSTRAINT [FK_Vehicule_Categorie] FOREIGN KEY (CategoryId) REFERENCES Category(Id) 
)
