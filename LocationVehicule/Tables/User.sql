CREATE TABLE [dbo].[User]
(
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] nvarchar(50) NOT NULL, 
	[LastName] nvarchar(50) NOT NULL,
	[Sex] INT NOT NULL,
	[BirthDate] datetime2(7) NOT NULL,
	[Email] varchar(255) NOT NULL,
	[Password] VARBINARY(32) NOT NULL, 
	[RegistrationDate] datetime2(7) NOT NULL,
	[Address] nvarchar(75) NOT NULL,
	[Phone] char(13) NULL,
	[Role] int NOT NULL, 
	[Salt] UniqueIdentifier NOT NULL DEFAULT(NewID())
    CONSTRAINT [PK_User] PRIMARY KEY ([Id]), 
    CONSTRAINT [CK_User_Email] CHECK  (([Email] like '__%@__%.%')) 
)
