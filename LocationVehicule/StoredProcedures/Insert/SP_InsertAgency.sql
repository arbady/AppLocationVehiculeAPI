CREATE PROCEDURE [dbo].[SP_InsertAgency]
	@Code nvarchar(50),
	@Airport nvarchar(50),
	@Address nvarchar(255),
	@ZipCode int,
	@City nvarchar(50),
	@Country nvarchar(50),
    @IsClosed bit
AS
	BEGIN
		INSERT INTO Agency (Code, Airport, [Address], ZipCode, City, Country, IsClosed)
		OUTPUT inserted.Id 
		VALUES (@Code, @Airport, @Address, @ZipCode, @City, @Country, @IsClosed) 
	END

