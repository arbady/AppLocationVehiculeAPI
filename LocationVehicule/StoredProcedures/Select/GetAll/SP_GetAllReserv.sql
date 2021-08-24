﻿CREATE PROCEDURE [dbo].[SP_GetAllReserv]
	
AS
	select	r.Id, u.FirstName, u.LastName, u.Email, r.ReservationDate, r.StartDateLocation, r.EndDateLocation,  
			a.Airport as DepartureAgency, r.ReturnAgency, a.Country, r.DamageCover, r.RobberyCover, c.TypeCat, 
			r.AmountTotTVA, r.Deposit, r.PaidAll
	from [dbo].[Reservation] r
	join [dbo].[Category] c on r.CategoryId = c.Id
	join [dbo].[User] u on r.UserId = u.Id
	join [dbo].[Agency] a on r.AgencyId = a.Id
RETURN 0