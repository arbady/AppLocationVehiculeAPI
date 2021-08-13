CREATE TABLE [dbo].[Agency]
(
	[Id] int IDENTITY(1,1) NOT NULL, 
	[Code] nvarchar(50) NOT NULL,
	[Airport] nvarchar(50) NOT NULL,
	[Address] nvarchar(255) NOT NULL,
	[ZipCode] int NOT NULL,
	[City] nvarchar(50) NOT NULL,
	[Country] nvarchar(50) NOT NULL,
    [IsClosed] BIT NOT NULL default 0, 
    CONSTRAINT [PK_Agency] PRIMARY KEY ([Id]) 
)

GO

CREATE TRIGGER [dbo].[TriggerOnDeleteAgency]
    ON [dbo].[Agency]
    INSTEAD OF DELETE
    AS
    BEGIN
        SET NoCount ON
		UPDATE Agency SET IsClosed = 1 Where Id in(SELECT Id FROM deleted WHERE IsClosed = 0)
    END