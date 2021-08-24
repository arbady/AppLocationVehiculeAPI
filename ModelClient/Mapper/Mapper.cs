using ModelClient.Data;
using ModelGlobal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.SecurityTools;

namespace ModelClient.Mapper
{
    internal static class Mapper
    {
        #region Agency
        internal static AgencyGlobal ToAgencyGlobal(this AgencyClient agency)
        {
            return new AgencyGlobal
            {
                Id = agency.Id,
                Code = agency.Code,
                Airport = agency.Airport,
                Address = agency.Address,
                ZipCode = agency.ZipCode,
                City = agency.City,
                Country = agency.Country,
                IsClosed = agency.IsClosed
            };
        }

        internal static AgencyClient ToAgencyClient(this AgencyGlobal agency)
        {
            return new AgencyClient(
                agency.Id, agency.Code, agency.Airport, agency.Address, agency.ZipCode, agency.City,
                agency.Country, agency.IsClosed);
        }
        #endregion

        #region Bill
        internal static BillGlobal ToBillGlobal(this BillClient bill)
        {
            return new BillGlobal
            {
                Id = bill.Id,
                BillNum = bill.BillNum,
                Wording = bill.Wording,
                BillDate = bill.BillDate,
                AmountTotHTVA = bill.AmountTotHTVA,
                AmountTotTVA = bill.AmountTotTVA,
                Paid = bill.Paid,
                ContractId = bill.ContractId,
                PaymentMethodId = bill.PaymentMethodId
            };
        }
        internal static BillClient ToBillClient(this BillGlobal bill)
        {
            return new BillClient(
                bill.Id, bill.BillNum, bill.Wording, bill.BillDate, bill.AmountTotHTVA, bill.AmountTotTVA,
                bill.Paid, bill.ContractId, bill.PaymentMethodId);
        }
        #endregion

        #region Category
        internal static CategoryGlobal ToCategoryGlobal(this CategoryClient category)
        {
            return new CategoryGlobal
            {
                Id = category.Id,
                TypeCat = category.TypeCat,
                CostPerDay = category.CostPerDay
            };
        }
        internal static CategoryClient ToCategoryClient(this CategoryGlobal category)
        {
            return new CategoryClient(category.Id, category.TypeCat, category.CostPerDay);
        }
        #endregion

        #region Contract
        internal static ContractGlobal ToContractGlobal(this ContractClient contract)
        {
            return new ContractGlobal
            {
                Id = contract.Id,
                ContractNum = contract.ContractNum,
                RealReturnDate = contract.RealReturnDate,
                DepartKm = contract.DepartKm,
                BackKm = contract.BackKm,
                ContractDate = contract.ContractDate,
                AmountTotHTVA = contract.AmountTotHTVA,
                AmountTotTVA = contract.AmountTotTVA,
                Signed = contract.Signed,
                ReservationId = contract.ReservationId,
                PenalizationId = contract.PenalizationId,
                VehicleId = contract.VehicleId
            };
        }
        internal static ContractClient ToContractClient(this ContractGlobal contract)
        {
            return new ContractClient(contract.Id, contract.ContractNum, contract.RealReturnDate,
                contract.DepartKm, contract.BackKm, contract.ContractDate, contract.AmountTotHTVA,
                contract.AmountTotTVA, contract.Signed, contract.ReservationId, contract.PenalizationId,
                contract.VehicleId);
        }
        #endregion

        #region Disponibilities
        internal static DisponibilitiesGlobal ToDisponibilitiesGlobal(this DisponibilitiesClient disponibilities)
        {
            return new DisponibilitiesGlobal
            {
                Id = disponibilities.Id,
                AvailDateDepart = disponibilities.AvailDateDepart,
                AvailDateReturn = disponibilities.AvailDateReturn,
                AgencyId = disponibilities.AgencyId,
                VehicleId = disponibilities.VehicleId
            };
        }
        internal static DisponibilitiesClient ToDisponibilitiesClient(this DisponibilitiesGlobal disponibilities)
        {
            return new DisponibilitiesClient(
                disponibilities.Id, disponibilities.AvailDateDepart, disponibilities.AvailDateReturn,
                disponibilities.AgencyId, disponibilities.VehicleId);
        }
        #endregion

        #region Licence
        internal static LicenceGlobal ToLicenceGlobal(this LicenceClient licence)
        {
            return new LicenceGlobal
            {
                Id = licence.Id,
                LicenceCat = licence.LicenceCat,
                Description = licence.Description
            };
        }
        internal static LicenceClient ToLicenceClient(this LicenceGlobal licence)
        {
            return new LicenceClient(licence.Id, licence.LicenceCat, licence.Description);
        }
        #endregion

        #region Mark
        internal static MarkGlobal ToMarkGlobal(this MarkClient mark)
        {
            return new MarkGlobal
            {
                Id = mark.Id,
                Name = mark.Name
            };
        }
        internal static MarkClient ToMarkClient(this MarkGlobal mark)
        {
            return new MarkClient(mark.Id, mark.Name);
        }
        #endregion

        #region Model
        internal static ModelGlobale ToModelGlobal(this ModeleClient model)
        {
            return new ModelGlobale
            {
                Id = model.Id,
                Name = model.Name,
                MarkId = model.MarkId
            };
        }
        internal static ModeleClient ToModelClient(this ModelGlobale model)
        {
            return new ModeleClient(model.Id, model.Name, model.MarkId);
        }
        #endregion

        #region PaymentMethode
        internal static PaymentMethodGlobal ToPaymentMethodGlobal(this PaymentMethodClient payment)
        {
            return new PaymentMethodGlobal
            {
                Id = payment.Id,
                Method = payment.Method
            };
        }
        internal static PaymentMethodClient ToPaymentMethodClient(this PaymentMethodGlobal payment)
        {
            return new PaymentMethodClient(payment.Id, payment.Method);
        }
        #endregion

        #region Penalization
        internal static PenalizationGlobal ToPenalizationGlobal(this PenalizationClient penalization)
        {
            return new PenalizationGlobal
            {
                Id = penalization.Id,
                Description = penalization.Description,
                PenalDate = penalization.PenalDate,
                AmountOwed = penalization.AmountOwed,
                AmountPaid = penalization.AmountPaid
            };
        }
        internal static PenalizationClient ToPenalizationClient(this PenalizationGlobal penalization)
        {
            return new PenalizationClient(
                penalization.Id, penalization.Description, penalization.PenalDate, penalization.AmountOwed,
                penalization.AmountPaid);
        }
        #endregion

        #region Reservation
        internal static ReservationGlobal ToReservationGlobal(this ReservationClient reservation)
        {
            return new ReservationGlobal
            {
                Id = reservation.Id,
                ReservationDate = reservation.ReservationDate,
                StartDateLocation = reservation.StartDateLocation,
                EndDateLocation = reservation.EndDateLocation,
                AmountTotTVA = reservation.AmountTotTVA,
                Deposit = reservation.Deposit,
                DepositPaid = reservation.DepositPaid,
                ReturnAgency = reservation.ReturnAgency,
                DamageCover = reservation.DamageCover,
                RobberyCover = reservation.RobberyCover,
                AgeRange = reservation.AgeRange,
                PaidAll = reservation.PaidAll,
                IsCancelled = reservation.IsCancelled,
                UserId = reservation.UserId,
                AgencyId = reservation.AgencyId,
                CategoryId = reservation.CategoryId
            };
        }
        internal static ReservationClient ToReservationClient(this ReservationGlobal reservation)
        {
            return new ReservationClient(
                reservation.Id, reservation.ReservationDate, reservation.StartDateLocation,
                reservation.EndDateLocation, reservation.AmountTotTVA, reservation.Deposit,
                reservation.DepositPaid, reservation.ReservationStatus, reservation.ReturnAgency,
                reservation.DamageCover, reservation.RobberyCover, reservation.AgeRange, reservation.PaidAll,
                reservation.IsCancelled, reservation.UserId, reservation.AgencyId, reservation.CategoryId);
        }
        #endregion

        #region State
        internal static StateGlobal ToStateGlobal(this StateClient state)
        {
            return new StateGlobal
            {
                Id = state.Id,
                StateType = state.StateType,
                Description = state.Description
            };
        }
        internal static StateClient ToStateClient(this StateGlobal state)
        {
            return new StateClient(state.Id, state.StateType, state.Description);
        }
        #endregion

        #region User
        internal static UserGlobal ToUserGlobal(this UserClient user)
        {
            if (user is null) return null;
            return new UserGlobal
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Sex = user.Sex,
                BirthDate = user.BirthDate,
                Email = user.Email,
                Password = user.Password,
                RegistrationDate = user.RegistrationDate,
                Address = user.Address,
                Phone = user.Phone,
                Role = user.Role
            };
        }
        internal static UserClient ToUserClient(this UserGlobal user)
        {
            return new UserClient(
                user.Id, user.FirstName, user.LastName, user.Sex, user.BirthDate, user.RegistrationDate, 
                user.Address, user.Phone, user.Email, user.Password, /*user.RePassword*/ user.Role);
        }
        #endregion

        #region Vehicle
        internal static VehicleGlobal ToVehicleGlobal(this VehicleClient vehicle)
        {
            return new VehicleGlobal
            {
                Id = vehicle.Id,
                RegistrationNum = vehicle.RegistrationNum,
                Characteristic = vehicle.Characteristic,
                NbPlace = vehicle.NbPlace,
                NbDoor = vehicle.NbDoor,
                Fuel = vehicle.Fuel,
                AirCo = vehicle.AirCo,
                Gps = vehicle.Gps,
                Transmission = vehicle.Transmission,
                StateId = vehicle.StateId,
                ModelId = vehicle.ModelId,
                CategoryId = vehicle.CategoryId
            };
        }
        internal static VehicleClient ToVehicleClient(this VehicleGlobal vehicle)
        {
            return new VehicleClient(
                vehicle.Id, vehicle.RegistrationNum, vehicle.Characteristic, vehicle.NbPlace, vehicle.NbDoor, 
                vehicle.Fuel, vehicle.AirCo, vehicle.Gps, vehicle.Transmission, vehicle.StateId, 
                vehicle.ModelId, vehicle.CategoryId);
        }
        #endregion
    }
}
