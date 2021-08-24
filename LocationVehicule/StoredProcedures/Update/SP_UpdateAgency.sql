CREATE PROCEDURE [dbo].[SP_UpdateAgency]
	@Id int,
	@Code nvarchar(50),
	@Airport nvarchar(50),
	@Address nvarchar(255),
	@ZipCode int,
	@City nvarchar(50),
	@Country nvarchar(50),
    @IsClosed bit
AS
	BEGIN
		UPDATE Agency
		SET Code=@Code, Airport=@Airport, [Address]=@Address, ZipCode=@ZipCode, City=@City, Country=@Country, 
		IsClosed=@IsClosed
		WHERE Id=@Id
	END
