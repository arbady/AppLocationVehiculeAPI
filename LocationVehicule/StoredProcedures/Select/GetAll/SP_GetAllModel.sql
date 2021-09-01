CREATE PROCEDURE [dbo].[SP_GetAllModel]
	
AS
	SELECT md.*, m.* 
	FROM Model md
	JOIN Mark m ON md.MarkId=m.Id
RETURN 0
