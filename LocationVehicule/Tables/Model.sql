CREATE TABLE [dbo].[Model]
(
	[Id] int IDENTITY(1,1) NOT NULL,
	[Name] nvarchar(50) NOT NULL,
	[MarkId] int NOT NULL,
    CONSTRAINT [PK_Model] PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_Model_Mark] FOREIGN KEY ([MarkId]) REFERENCES [dbo].[Mark] ([Id]) 
)
