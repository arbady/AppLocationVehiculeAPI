CREATE TABLE [dbo].[LicenceUser]
(
    [Id] int Identity(1,1) NOT NULL, 
	[LicenceId] int NOT NULL,
	[UserId] int NOT NULL, 
    CONSTRAINT [PK_LicenceUser] PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_UserLicence] FOREIGN KEY (UserId) REFERENCES [User](Id), 
    CONSTRAINT [FK_LicenceUser] FOREIGN KEY (LicenceId) REFERENCES [Licence](Id) 
)
