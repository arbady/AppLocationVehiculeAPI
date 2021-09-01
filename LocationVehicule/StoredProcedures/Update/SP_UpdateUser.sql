CREATE PROCEDURE [dbo].[SP_UpdateUser]
	@Id int, 
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
	BEGIN
		UPDATE [User]
		SET FirstName=@firstName, LastName=@lastName, Sex=@sex, BirthDate=@birthDate, Email=@email, 
		[Password]=dbo.SF_HashingPassword(@password, Salt), RegistrationDate=@registrationDate, 
		[Address]=@address, Phone=@phone, [Role]=@role 
		WHERE Id=@Id
	END
