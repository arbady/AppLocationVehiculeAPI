﻿CREATE PROCEDURE [dbo].[SP_DeleteState]
	@Id INT
AS
	BEGIN
		DELETE FROM [State] WHERE Id = @Id
	END
