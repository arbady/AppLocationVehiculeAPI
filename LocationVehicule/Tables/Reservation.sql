CREATE TABLE [dbo].[Reservation]
(
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ReservationDate] datetime2(7) NOT NULL,
	[StartDateLocation] datetime2(7) NOT NULL,
	[EndDateLocation] datetime2(7) NOT NULL,
	[ReturnAgency] int NOT NULL,
	[DamageCover] bit NOT NULL default 0,
	[RobberyCover] bit NOT NULL default 0,
	[AgeRange] bit NOT NULL default 0,
	[IsCancelled] bit NOT NULL default 0,
	[UserId] int NOT NULL,
	[AgencyId] int NOT NULL,
	[CategoryId] int NOT NULL, 
    CONSTRAINT [PK_Reservation] PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_Reservation_User] FOREIGN KEY (UserId) REFERENCES [User](Id), 
    CONSTRAINT [FK_Reservation_Agency] FOREIGN KEY ([AgencyId]) REFERENCES Agency(Id), 
	CONSTRAINT [FK_Reservation_ReturnAgency] FOREIGN KEY ([ReturnAgency]) REFERENCES Agency(Id),
    CONSTRAINT [FK_Reservation_Category] FOREIGN KEY ([CategoryId]) REFERENCES Category(Id),
)

GO

CREATE TRIGGER [dbo].[TriggerOnDeleteReservation]
    ON [dbo].[Reservation]
    INSTEAD OF DELETE
    AS
    BEGIN
        SET NoCount ON
		UPDATE Reservation SET IsCancelled = 1 WHERE Id in(SELECT Id FROM deleted WHERE IsCancelled = 0)
    END