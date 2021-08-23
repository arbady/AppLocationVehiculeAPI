/*
Modèle de script de post-déploiement							
--------------------------------------------------------------------------------------
 Ce fichier contient des instructions SQL qui seront ajoutées au script de compilation.		
 Utilisez la syntaxe SQLCMD pour inclure un fichier dans le script de post-déploiement.			
 Exemple :      :r .\monfichier.sql								
 Utilisez la syntaxe SQLCMD pour référencer une variable dans le script de post-déploiement.		
 Exemple :      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

--Data User--

/*Set Identity_insert [User] on;*/

EXEC SP_InsertUser 'Mpoyi', 'Arnold', 1, '1986-04-30 00:00:00', 'arnoldmpoyi@yahoo.fr', '2020-09-09 00:00:00', '2/3 Clos des Ormes 7080 Frameries', '+32466423930', 1, 'test1234='
EXEC SP_InsertUser 'Buanga', 'Steve', 1, '1980-08-10 00:00:00', 'badispace@gmail.com', '2021-10-19 00:00:00', '54 Cités des petites préelles 7330 Saint-Ghislain', '+32489425753', 2, 'test1234='
EXEC SP_InsertUser 'Luyi', 'Stephanie', 2, '1995-12-01 00:00:00', 'stephanieluyi@gmail.com', '2019-02-08 00:00:00', '2 Docteur Colson 1430 Rebecq', '+32466103965', 2, 'test1234='
EXEC SP_InsertUser 'Skou', 'Isabelle', 2, '1980-08-12 00:00:00', 'isaskou@yahoo.fr', '2021-05-08 00:00:00', '23 Rue des Oliviers 1000 Bruxelles', '+32492423441', 2, 'test1234='
EXEC SP_InsertUser 'Ntumba', 'Vanessa', 2, '1992-06-18 00:00:00', 'vanebad@gmail.com', '2018-03-02 00:00:00', '14 Cité de l''Abbaye 7340 Colfontaine', '+32475428967', 2, 'test1234='
/*Set Identity_insert [User] off;*/

--Data Agency--

Set Identity_insert [Agency] on;
INSERT INTO [Agency] (Id, Code, Airport, [Address], ZipCode, City, Country, IsClosed) VALUES
(1, 'ZVT6690', 'Brussels Airport Zaventem', '1 LeopoldLaan', 1930, 'Zaventem', 'Belgique', 0),
(2, 'CHR0012', 'Aeroport de Charleroi', '8 rue des Frères Wright', 6000, 'Charleroi', 'Belgique', 1),
(3, 'LG4267', 'Aeroport de Liege', '3 Rue de l’Aéroport', 4460, 'Grâce-Hollogne', 'Belgique', 0),
(4, 'CHG9021', 'Aeroport de Roissy-Charles de Gaulle', '1 Rue de Paris', 95700, 'Roissy-en-France', 'France', 0),
(5, 'LYN7722', 'Aeroport de Lyon-Saint Exupery', '1 Colombier-Saugnieu', 69125, 'Lyon', 'France', 0)
Set Identity_insert [Agency] off;

--Data Category--

Set Identity_insert [Category] on;
INSERT INTO [Category] (Id, TypeCat, CostPerDay) VALUES
(1, 1, 30.59),
(2, 2, 50.99),
(3, 3, 20.99),
(4, 4, 70.99),
(5, 5, 45.59)
Set Identity_insert [Category] off;

--Data State--

Set Identity_insert [State] on;
INSERT INTO [State] (Id, StateType) VALUES
(1, 1),
(2, 2),
(3, 3)
Set Identity_insert [State] off;

--Data PaymentMethod--

Set Identity_insert [PaymentMethod] on;
INSERT INTO PaymentMethod (Id, Method) VALUES
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5)
Set Identity_insert PaymentMethod off;

--Data Mark--

Set Identity_insert [Mark] on;
INSERT INTO Mark (Id, [Name]) VALUES
(1, 'VOLKSWAGEN'),
(2, 'AUDI'),
(3, 'FORD'),
(4, 'PEUGEOT'),
(5, 'BMW')
Set Identity_insert Mark off;

--Data Model--

Set Identity_insert [Model] on;
INSERT INTO Model (Id, [Name], MarkId) VALUES
(1, 'GOLF 6', 1),
(2, 'A3', 2),
(3, '307', 4),
(4, 'FIESTA', 3),
(5, 'SERIE 1', 5)
Set Identity_insert Model off;

--Data Penalization--

Set Identity_insert [Penalization] on;
INSERT INTO [Penalization] (Id, PenalDate, AmountOwed, AmountPaid) VALUES
(1, '2021-12-11 00:00:00', 50, 50),
(2, '2021-12-15 00:00:00', 70, 70),
(3, '2021-12-09 00:00:00', 40, 40),
(4, '2021-12-20 00:00:00', 80, 80),
(5, '2021-12-16 00:00:00', 50, 50)
Set Identity_insert [Penalization] off;

--Data Licence--

Set Identity_insert [Licence] on;
INSERT INTO [Licence] (Id, LicenceCat, [Description]) VALUES
(1, 1, 'Permis cyclomoteur. Il est appelé aussi Brevet de Sécurité Routière (BSR)'),
(2, 2, 'permis moto, vous permettent de conduire des motos ou des trois roues (A, A1,A2))'),
(3, 3, 'Permis auto (B, B1, B2, BE). Permet de conduire des voitures, camionnettes et camping-cars avec 9 places assises maximum (conducteur inclus) et dont le PTAC (poids total autorisé en charge) ne dépasse pas 3,5 T.'),
(4, 4, 'Permis professionnels. catégorie C (C, C1, CE) et D (D, D1, D2). Les permis de catégorie C permettent de conduire des camions affectés au transport de marchandises équipés d’une remorque.')
Set Identity_insert [Licence] off;

--Data Reservation--

Set Identity_insert [Reservation] on;
INSERT INTO [Reservation] 
(Id, ReservationDate, StartDateLocation, EndDateLocation, AmountTotTVA, Deposit, DepositPaid, ReservationStatus, 
ReturnAgency, DamageCover, RobberyCover, AgeRange, PaidAll, IsCancelled, UserId, AgencyId, CategoryId) VALUES
(1, '2021-08-11 00:00:00', '2021-08-11 00:00:00', '2021-08-30 00:00:00', 400, 200.59, 1, 1, 'Aeroport de Liège', 1, 1, 1, 1, 0, 1, 1, 1),
(2, '2021-09-01 00:00:00', '2021-09-01 00:00:00', '2021-09-21 00:00:00', 500, 250, 1, 1, 'Brussels Airport Zaventem', 1, 0, 1, 1, 0, 2, 2, 2),
(3, '2021-08-21 00:00:00', '2021-08-21 00:00:00', '2021-08-30 00:00:00', 200, 100, 0, 0, 'Brussels Airport Zaventem', 0, 1, 1, 0, 1, 3, 3, 3),
(4, '2021-09-22 00:00:00', '2021-09-22 00:00:00', '2021-09-30 00:00:00', 200, 100, 0, 0, 'Aeroport de Charleroi', 0, 1, 1, 0, 1, 3, 3, 3),
(5, '2021-09-23 00:00:00', '2021-09-23 00:00:00', '2021-09-30 00:00:00', 200, 100, 0, 0, 'Brussels Airport Zaventem', 0, 1, 1, 0, 1, 3, 3, 3)
Set Identity_insert [Reservation] off;

--Data Vehicle--

Set Identity_insert [Vehicle] on;
INSERT INTO [Vehicle] 
(Id, RegistrationNum, NbPlace, NbDoor, Fuel, AirCo, Gps, StateId, ModelId, CategoryId) VALUES
(1, '1TWJ785', 5, 1, 1, 1, 1, 1, 1, 1),
(2, '1TWJ785', 3, 3, 1, 0, 1, 1, 2, 2),
(3, '1TWJ785', 4, 2, 0, 1, 1, 1, 3, 3),
(4, '1TWJ785', 2, 4, 1, 1, 2, 1, 4, 4),
(5, '1TWJ785', 1, 5, 1, 1, 3, 1, 5, 5)
Set Identity_insert [Vehicle] off;

--Data Disponibilities--

Set Identity_insert [Disponibilities] on;
INSERT INTO Disponibilities (Id, AvailDateDepart, AvailDateReturn, AgencyId, VehicleId) VALUES
(1, '2020-10-19 00:00:00', '2020-11-19 00:00:00', 1, 1),
(2, '2020-11-20 00:00:00', '2020-12-20 00:00:00', 2, 2),
(3, '2020-05-11 00:00:00', '2020-06-11 00:00:00', 3, 3),
(4, '2020-09-06 00:00:00', '2020-10-06 00:00:00', 4, 4),
(5, '2020-05-12 00:00:00', '2020-06-12 00:00:00', 5, 5)
Set Identity_insert Disponibilities off;

--Data Contract--

Set Identity_insert [Contract] on;
INSERT INTO [Contract] (Id, ContractNum, RealReturnDate, ContractDate, AmountTotHTVA, AmountTotTVA, Signed, ReservationId, VehicleId, PenalizationId) VALUES
(1, 2020010101, '2020-09-09 00:00:00', '2020-10-09 00:00:00', 1000, 1100.29, 1, 1, 1, 1),
(2, 2021041202, '2021-10-19 00:00:00', '2021-11-19 00:00:00', 2000, 2200, 1, 2, 2, 2),
(3, 2020061003, '2019-02-08 00:00:00', '2019-03-08 00:00:00', 500.68, 590.89, 0, 3, 3, 3),
(4, 2020040804, '2021-05-08 00:00:00', '2021-06-08 00:00:00', 300.70, 400.99, 1, 4, 4, 4),
(5, 2020050905, '2018-03-02 00:00:00', '2018-04-02 00:00:00', 1500.99, 2200, 0, 5, 5, 5)
Set Identity_insert [Contract] off;
--la valeur max qu'on peut attribuer à un entier est 2147483647 passe ton contract id en double

--Data Bill--

Set Identity_insert [Bill] on;
INSERT INTO [Bill] 
(Id, BillNum, Wording, BillDate, AmountTotHTVA, AmountTotTVA, Paid, ContractId, PaymentMethodId) VALUES
(1, 'FAC0001', 'Facture d''achat', '2021-11-19 00:00:00', 500.59, 650, 1, 1, 1),
(2, 'FAC0002', 'Facture d''achat', '2021-10-09 00:00:00', 350, 450.82, 1, 1, 1),
(3, 'FAC0003', 'Facture d''achat', '2021-08-29 00:00:00', 760, 850, 1, 1, 2),
(4, 'FAC0004', 'Facture d''achat', '2021-09-10 00:00:00', 255.67, 350, 1, 1, 5),
(5, 'FAC0005', 'Facture d''achat', '2021-09-02 00:00:00', 500.45, 650.45, 1, 1, 2)
Set Identity_insert [Bill] off;

--Data LicenceUser--

Set Identity_insert [LicenceUser] on;
INSERT INTO [LicenceUser] (Id, LicenceId, UserId) VALUES
(1, 1, 1),
(2, 2, 2),
(3, 3, 3),
(4, 4, 4)
Set Identity_insert [LicenceUser] off;