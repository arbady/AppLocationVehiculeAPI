CREATE TABLE [dbo].[Penalization]
(
	[Id] int IDENTITY(1,1) NOT NULL,
	[Description] nvarchar(1000) NULL,
	[PenalDate] datetime2(7) NOT NULL, 
	[AmountOwed] float NOT NULL, 
	[AmountPaid] float NOT NULL,
    CONSTRAINT [PK_Penalization] PRIMARY KEY ([Id]) 
)
