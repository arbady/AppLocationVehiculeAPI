CREATE TABLE [dbo].[Bill]
(
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BillNum] NVARCHAR(50) NOT NULL,
	[Wording] nvarchar(50) NOT NULL,
	[BillDate] datetime2(7) NOT NULL,
	[AmountTotHTVA] float NOT NULL,
	[AmountTotTVA] float NOT NULL,
	[Paid] bit NOT NULL Default 0,
	[ContractId] int NOT NULL,
	[PaymentMethodId] int NOT NULL,
    CONSTRAINT [PK_Bill] PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_Bill_Contract] FOREIGN KEY ([ContractId]) REFERENCES [Contract](Id), 
    CONSTRAINT [FK_Bill_PaymentMethod] FOREIGN KEY ([PaymentMethodId]) REFERENCES PaymentMethod(Id) 
)
