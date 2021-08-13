CREATE TABLE [dbo].[Licence]
(
	[Id] int IDENTITY(1,1) NOT NULL,
	[LicenceCat] INT NOT NULL,
	[Description] nvarchar(255) NOT NULL, 
    CONSTRAINT [PK_Licence] PRIMARY KEY ([Id]) 
)
