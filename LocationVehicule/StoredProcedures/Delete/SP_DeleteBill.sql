﻿CREATE PROCEDURE [dbo].[SP_DeleteBill]
	@Id INT
AS
	BEGIN
		DELETE FROM Bill WHERE Id = @Id
	END