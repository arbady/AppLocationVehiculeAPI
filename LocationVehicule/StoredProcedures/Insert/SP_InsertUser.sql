CREATE PROCEDURE [dbo].[SP_InsertUser]
	@firstName nvarchar(50),
	@lastName nvarchar(50),
	@sex int,
	@birthDate Datetime2,
	@email varchar(255),
	@registrationDate Datetime2,
	@address nvarchar(75),
	@phone char(13) null,
	@role int,
	@password varchar(20)
	
AS
Declare @salt uniqueidentifier
Set @salt = newID()

INSERT INTO [User] 
(FirstName, LastName, Sex, BirthDate, Email, RegistrationDate, [Address], Phone, [Role], Salt, [Password]) 
output inserted.Id
VALUES
(@firstName, @lastName, @sex, @birthDate, @email, @registrationDate, @address, @phone, @role, @salt, dbo.SF_HashingPassword(@password, @salt))

