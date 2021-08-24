CREATE PROCEDURE [dbo].[SP_DeleteContract]
	@Id INT
AS
	BEGIN
		DELETE FROM [Contract] WHERE Id = @Id
	END
	