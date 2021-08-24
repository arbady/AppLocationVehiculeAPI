CREATE PROCEDURE [dbo].[SP_GetByIdReserv]
	@id int
AS
	SELECT r.* 
	FROM Reservation r
	WHERE r.Id=@id
RETURN 0
