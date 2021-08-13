CREATE TABLE [dbo].[Category]
(
	[Id] int IDENTITY(1,1) NOT NULL,
	[TypeCat] int NOT NULL,
	[CostPerDay] float NOT NULL, 
    CONSTRAINT [PK_Category] PRIMARY KEY ([Id]) 
)
