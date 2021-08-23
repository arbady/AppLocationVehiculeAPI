using ModelGlobal.Data;
using ModelGlobal.Enum;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.MapperTools;

namespace ModelGlobal.Mapper
{
    internal static class Mapper
    {
        //protected static bool CheckIfNull(object entity)
        //{
        //    return entity is null;
        //}

        #region Agency
        internal static AgencyGlobal ToAgency(this IDataRecord reader)
        {
            return new AgencyGlobal()
            {
                Id = (int)reader[nameof(AgencyGlobal.Id)],
                Code = (string)reader[nameof(AgencyGlobal.Code)],
                Airport = (string)reader[nameof(AgencyGlobal.Airport)],
                Address = (string)reader[nameof(AgencyGlobal.Address)],
                ZipCode = (int)reader[nameof(AgencyGlobal.ZipCode)],
                City = (string)reader[nameof(AgencyGlobal.City)],
                Country = (string)reader[nameof(AgencyGlobal.Country)],
                IsClosed = (bool)reader[nameof(AgencyGlobal.IsClosed)]
            };
        }
        #endregion

        #region Bill
        internal static BillGlobal ToBill(this IDataRecord reader)
        {
            return new BillGlobal()
            {
                Id = (int)reader[nameof(BillGlobal.Id)],
                BillNum = (string)reader[nameof(BillGlobal.BillNum)],
                Wording = (string)reader[nameof(BillGlobal.Wording)],
                BillDate = (DateTime)reader[nameof(BillGlobal.BillDate)],
                AmountTotHTVA = (double)reader[nameof(BillGlobal.AmountTotHTVA)],
                AmountTotTVA = (double)reader[nameof(BillGlobal.AmountTotTVA)],
                Paid = (bool)reader[nameof(BillGlobal.Paid)],
                ContractId = (int)reader[nameof(BillGlobal.ContractId)],
                PaymentMethodId = (int)reader[nameof(BillGlobal.PaymentMethodId)]
            };
        }
        #endregion

        #region Category
        internal static CategoryGlobal ToCategory(this IDataRecord reader)
        {
            return new CategoryGlobal()
            {
                Id = (int)reader[nameof(CategoryGlobal.Id)],
                TypeCat = (TypeCat)reader[nameof(CategoryGlobal.TypeCat)],
                CostPerDay = (double)reader[nameof(CategoryGlobal.CostPerDay)]
            };
        }
        #endregion

        #region Contract
        internal static ContractGlobal ToContract(this IDataRecord reader)
        {
            return new ContractGlobal()
            {
                Id = (int)reader[nameof(ContractGlobal.Id)],
                ContractNum = (int)reader[nameof(ContractGlobal.ContractNum)],
                RealReturnDate = (DateTime)reader[nameof(ContractGlobal.RealReturnDate)],
                DepartKm = (string)(reader[nameof(ContractGlobal.DepartKm)] is DBNull?  null : reader[nameof(ContractGlobal.DepartKm)]),
                BackKm = (string)(reader[nameof(ContractGlobal.BackKm)] is DBNull? null : reader[nameof(ContractGlobal.BackKm)]),
                ContractDate = (DateTime)reader[nameof(ContractGlobal.ContractDate)],
                AmountTotHTVA = (double)reader[nameof(ContractGlobal.AmountTotHTVA)],
                AmountTotTVA = (double)reader[nameof(ContractGlobal.AmountTotTVA)],
                Signed = (bool)reader[nameof(ContractGlobal.Signed)],
                ReservationId = (int)reader[nameof(ContractGlobal.ReservationId)],
                PenalizationId = (int)reader[nameof(ContractGlobal.PenalizationId)],
                VehicleId = (int)reader[nameof(ContractGlobal.VehicleId)]
            };
        }
        #endregion

        #region Disponibilities
        internal static DisponibilitiesGlobal ToDisponibilities(this IDataRecord reader)
        {
            return new DisponibilitiesGlobal()
            {
                Id = (int)reader[nameof(DisponibilitiesGlobal.Id)],
                AvailDateDepart = (DateTime)reader[nameof(DisponibilitiesGlobal.AvailDateDepart)],
                AvailDateReturn = (DateTime)reader[nameof(DisponibilitiesGlobal.AvailDateReturn)],
                AgencyId = (int)reader[nameof(DisponibilitiesGlobal.AgencyId)],
                VehicleId = (int)reader[nameof(DisponibilitiesGlobal.VehicleId)]
            };
        }
        #endregion

        #region Licence
        internal static LicenceGlobal ToLicence(this IDataRecord reader)
        {
            return new LicenceGlobal()
            {
                Id = (int)reader[nameof(LicenceGlobal.Id)],
                LicenceCat = (LicenceCat)reader[nameof(LicenceGlobal.LicenceCat)],
                Description = (string)reader[nameof(LicenceGlobal.Description)]
            };
        }
        #endregion

        #region Mark
        internal static MarkGlobal ToMark(this IDataRecord reader)
        {
            return new MarkGlobal()
            {
                Id = (int)reader[nameof(MarkGlobal.Id)],
                Name = (string)reader[nameof(MarkGlobal.Name)]
            };
        }
        #endregion

        #region Model
        internal static ModelGlobale ToModel(this IDataRecord reader)
        {
            return new ModelGlobale()
            {
                Id = (int)reader[nameof(ModelGlobale.Id)],
                Name = (string)reader[nameof(ModelGlobale.Name)],
                MarkId = (int)reader[nameof(ModelGlobale.MarkId)]
            };
        }
        #endregion

        #region PaymentMethode
        internal static PaymentMethodGlobal ToPaymentMethod(this IDataRecord reader)
        {
            return new PaymentMethodGlobal()
            {
                Id = (int)reader[nameof(PaymentMethodGlobal.Id)],
                Method = (Method)reader[nameof(PaymentMethodGlobal.Method)]
            };
        }
        #endregion

        #region Penalization
        internal static PenalizationGlobal ToPenalization(this IDataRecord reader)
        {
            //if (Description == null) ? string.Empty : Description.ToString()
            return new PenalizationGlobal()
            {
                Id = (int)reader[nameof(PenalizationGlobal.Id)],
                Description = (string)(reader[nameof(PenalizationGlobal.Description)] is DBNull ? null : reader[nameof(PenalizationGlobal.Description)]),
                PenalDate = (DateTime)reader[nameof(PenalizationGlobal.PenalDate)],
                AmountOwed = (double)reader[nameof(PenalizationGlobal.AmountOwed)],
                AmountPaid = (double)reader[nameof(PenalizationGlobal.AmountPaid)]
            };

        }
        #endregion

        #region Reservation
        internal static ReservationGlobal ToReservation(this IDataRecord reader)
        {
            return new ReservationGlobal()
            {
                Id = (int)reader[nameof(ReservationGlobal.Id)],
                ReservationDate = (DateTime)reader[nameof(ReservationGlobal.ReservationDate)],
                StartDateLocation = (DateTime)reader[nameof(ReservationGlobal.StartDateLocation)],
                EndDateLocation = (DateTime)reader[nameof(ReservationGlobal.EndDateLocation)],
                AmountTotTVA = (double)reader[nameof(ReservationGlobal.AmountTotTVA)],
                Deposit = (double)reader[nameof(ReservationGlobal.Deposit)],
                DepositPaid = (bool)reader[nameof(ReservationGlobal.DepositPaid)],
                ReturnAgency = (string)reader[nameof(ReservationGlobal.ReturnAgency)],
                DamageCover = (bool)reader[nameof(ReservationGlobal.DamageCover)],
                RobberyCover = (bool)reader[nameof(ReservationGlobal.RobberyCover)],
                AgeRange = (bool)reader[nameof(ReservationGlobal.AgeRange)],
                PaidAll = (bool)reader[nameof(ReservationGlobal.PaidAll)],
                IsCancelled = (bool)reader[nameof(ReservationGlobal.IsCancelled)],
                UserId = (int)reader[nameof(ReservationGlobal.UserId)],
                AgencyId = (int)reader[nameof(ReservationGlobal.AgencyId)],
                CategoryId = (int)reader[nameof(ReservationGlobal.CategoryId)]
            };
        }
        #endregion

        #region State
        internal static StateGlobal ToState(this IDataRecord reader)
        {
            return new StateGlobal()
            {
                Id = (int)reader[nameof(StateGlobal.Id)],
                StateType = (StateType)reader[nameof(StateGlobal.StateType)],
                Description = (string)(reader[nameof(StateGlobal.Description)] is DBNull ? null : reader[nameof(StateGlobal.Description)])
            };
        }
        #endregion

        #region User
        internal static UserGlobal ToUser(this IDataRecord reader)
        {
            return new UserGlobal()
            {
                Id = (int)reader[nameof(UserGlobal.Id)],
                FirstName = (string)reader[nameof(UserGlobal.FirstName)],
                LastName = (string)reader[nameof(UserGlobal.LastName)],
                Sex = (Sex)reader[nameof(UserGlobal.Sex)],
                BirthDate = (DateTime)reader[nameof(UserGlobal.BirthDate)],
                Email = (string)reader[nameof(UserGlobal.Email)],
                Password = "********",
                RegistrationDate = (DateTime)reader[nameof(UserGlobal.RegistrationDate)],
                Address = (string)reader[nameof(UserGlobal.Address)],
                Phone = (string)reader[nameof(UserGlobal.Phone)],
                Role = (Role)reader[nameof(UserGlobal.Role)],
            };
        }
        #endregion

        #region Vehicle
        internal static VehicleGlobal ToVehicle(this IDataRecord reader)
        {
            return new VehicleGlobal()
            {
                Id = (int)reader[nameof(VehicleGlobal.Id)],
                RegistrationNum = (string)reader[nameof(VehicleGlobal.RegistrationNum)],
                Characteristic = (string)(reader[nameof(VehicleGlobal.Characteristic)] is DBNull? null : reader[nameof(VehicleGlobal.Characteristic)]),
                NbPlace = (NbPlace)reader[nameof(VehicleGlobal.NbPlace)],
                NbDoor = (NbDoor)reader[nameof(VehicleGlobal.NbDoor)],
                Fuel = (Fuel)reader[nameof(VehicleGlobal.Fuel)],
                AirCo = (bool)reader[nameof(VehicleGlobal.AirCo)],
                Gps = (bool)reader[nameof(VehicleGlobal.Gps)],
                Transmission = (Transmission?)(reader[nameof(VehicleGlobal.Transmission)] is DBNull? null : reader[nameof(VehicleGlobal.Transmission)]),
                StateId = (int)reader[nameof(VehicleGlobal.StateId)],
                ModelId = (int)reader[nameof(VehicleGlobal.ModelId)],
                CategoryId = (int)reader[nameof(VehicleGlobal.CategoryId)]
            };
        }
        #endregion
    }
}
