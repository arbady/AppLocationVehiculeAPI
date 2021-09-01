CREATE VIEW [dbo].[V_Dispo]
	AS  SELECT  dbo.Disponibilities.Id, dbo.Disponibilities.EntryDate, dbo.Disponibilities.IsInput, 
                dbo.Disponibilities.VehicleId, dbo.Disponibilities.AgencyId, dbo.Agency.Id AS [Agency.Id], 
                dbo.Agency.Code AS [Agency.Code], dbo.Agency.Airport AS [Agency.Airport], 
                dbo.Agency.[Address] AS [Agency.Address], dbo.Agency.ZipCode AS [Agency.ZipCode], 
                dbo.Agency.City AS [Agency.City], dbo.Agency.Country AS [Agency.Country], 
                dbo.Agency.IsClosed AS [Agency.IsClosed], dbo.Vehicle.Id AS [Vehicle.Id], 
                dbo.Vehicle.RegistrationNum AS [Vehicle.RegNum], dbo.Vehicle.Characteristic AS [Vehicle.Charac], 
                dbo.Vehicle.NbPlace AS [Vehicle.NbP], dbo.Vehicle.NbDoor AS [Vehicle.NbD], 
                dbo.Vehicle.Fuel AS [Vehicle.Fuel], dbo.Vehicle.AirCo AS [Vehicle.AirCo], 
                dbo.Vehicle.Gps AS [Vehicle.Gps], dbo.Vehicle.Transmission AS [Vehicle.Trans], 
                dbo.Vehicle.StateId AS [Vehicle.StateId], dbo.Vehicle.ModelId AS [Vehicle.ModelId], 
                dbo.Vehicle.CategoryId AS [Vehicle.CatId] 
         FROM   dbo.Agency INNER JOIN
                dbo.Disponibilities ON dbo.Agency.Id = dbo.Disponibilities.AgencyId INNER JOIN
                dbo.Vehicle ON dbo.Disponibilities.VehicleId = dbo.Vehicle.Id
         WHERE  Disponibilities.IsInput = 1
         AND    Disponibilities.EntryDate > (SELECT MAX(EntryDate) FROM Disponibilities WHERE IsInput = 0 )
