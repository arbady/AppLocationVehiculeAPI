CREATE TABLE [dbo].[PaymentMethod]
(
	[Id] int IDENTITY(1,1) NOT NULL,
	[Method] INT NOT NULL, 
    CONSTRAINT [PK_PaymentMethod] PRIMARY KEY ([Id]) 
)
