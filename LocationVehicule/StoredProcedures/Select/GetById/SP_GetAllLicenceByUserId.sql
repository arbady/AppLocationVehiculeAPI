CREATE PROCEDURE [dbo].[SP_GetAllLicenceByUserId]
	@userid INT
AS
	SELECT Licence.* FROM Licence
	JOIN LicenceUser ON Licence.Id = LicenceUser.LicenceId
	WHERE LicenceUser.UserId = @userid
RETURN 0
