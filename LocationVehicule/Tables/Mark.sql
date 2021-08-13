CREATE TABLE [dbo].[Mark]
(
	[Id] int IDENTITY(1,1) NOT NULL,
	[Name] nvarchar(50) NOT NULL,
    CONSTRAINT [PK_Mark] PRIMARY KEY ([Id]) 
)
