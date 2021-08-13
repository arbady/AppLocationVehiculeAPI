CREATE TABLE [dbo].[State]
(
	[Id] int IDENTITY(1,1) NOT NULL,
	[Description] nvarchar(50) NULL,
	[StateType] int NOT NULL, 
    CONSTRAINT [PK_State] PRIMARY KEY ([Id]) 
)
