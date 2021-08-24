CREATE PROCEDURE [dbo].[SP_UpdateLicence]
	@Id int, 
	@LicenceCat INT,
	@Description nvarchar(255)
AS
	BEGIN
		UPDATE Licence
		SET LicenceCat=@LicenceCat, [Description]=@Description
		WHERE Id=@Id
	END
