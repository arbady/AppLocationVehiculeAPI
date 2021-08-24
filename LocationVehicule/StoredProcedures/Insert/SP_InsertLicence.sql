CREATE PROCEDURE [dbo].[SP_InsertLicence]
	@LicenceCat INT,
	@Description nvarchar(255)
AS
	BEGIN
		INSERT INTO Licence(LicenceCat, [Description])
		OUTPUT inserted.Id 
		VALUES (@LicenceCat, @Description) 
	END
