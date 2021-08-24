using LocationVehicule.API.Models;
using ModelClient.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocationVehicule.API.Mapper
{
    public static class Mapper
    {
        #region Agency
        public static AgencyApi ToAgencyApi(this AgencyClient agency)
        {
            return new AgencyApi(agency.Id, agency.Code, agency.Airport, agency.Address, agency.ZipCode, agency.City,
                agency.Country, agency.IsClosed);
        }

        public static AgencyClient ToAgencyClient(this AgencyApi agency)
        {
            return new AgencyClient(agency.Id, agency.Code, agency.Airport, agency.Address, agency.ZipCode, agency.City,
                agency.Country, agency.IsClosed);
        }
        #endregion

        #region Bill
        public static BillApi ToBillApi(this BillClient bill)
        {
            return new BillApi(
                bill.Id, bill.BillNum, bill.Wording, bill.BillDate, bill.AmountTotHTVA, bill.AmountTotTVA,
                bill.Paid, bill.ContractId, bill.PaymentMethodId);
        }
        public static BillClient ToBillClient(this BillApi bill)
        {
            return new BillClient(
                bill.Id, bill.BillNum, bill.Wording, bill.BillDate, bill.AmountTotHTVA, bill.AmountTotTVA,
                bill.Paid, bill.ContractId, bill.PaymentMethodId);
        }
        #endregion

        #region Category        
        public static CategoryApi ToCategoryApi(this CategoryClient category)
        {
            return new CategoryApi(category.Id, category.TypeCat, category.CostPerDay);
        }
        public static CategoryClient ToCategoryClient(this CategoryApi category)
        {
            return new CategoryClient(category.Id, category.TypeCat, category.CostPerDay);
        }
        #endregion

        #region Contract
        public static ContractApi ToContractApi(this ContractClient contract)
        {
            return new ContractApi(contract.Id, contract.ContractNum, contract.RealReturnDate,
                contract.DepartKm, contract.BackKm, contract.ContractDate, contract.AmountTotHTVA,
                contract.AmountTotTVA, contract.Signed, contract.ReservationId, contract.PenalizationId,
                contract.VehicleId);
        }
        public static ContractClient ToContractClient(this ContractApi contract)
        {
            return new ContractClient(contract.Id, contract.ContractNum, contract.RealReturnDate,
                contract.DepartKm, contract.BackKm, contract.ContractDate, contract.AmountTotHTVA,
                contract.AmountTotTVA, contract.Signed, contract.ReservationId, contract.PenalizationId,
                contract.VehicleId);
        }
        #endregion

        #region Disponibilities       
        public static DisponibilitiesApi ToDisponibilitiesApi(this DisponibilitiesClient disponibilities)
        {
            return new DisponibilitiesApi(
                disponibilities.Id, disponibilities.AvailDateDepart, disponibilities.AvailDateReturn,
                disponibilities.AgencyId, disponibilities.VehicleId);
        }
        public static DisponibilitiesClient ToDisponibilitiesClient(this DisponibilitiesApi disponibilities)
        {
            return new DisponibilitiesClient(
                disponibilities.Id, disponibilities.AvailDateDepart, disponibilities.AvailDateReturn,
                disponibilities.AgencyId, disponibilities.VehicleId);
        }
        #endregion

        #region Licence
        public static LicenceApi ToLicenceApi(this LicenceClient licence)
        {
            return new LicenceApi(licence.Id, licence.LicenceCat, licence.Description);
        }
        public static LicenceClient ToLicenceClient(this LicenceApi licence)
        {
            return new LicenceClient(licence.Id, licence.LicenceCat, licence.Description);
        }
        #endregion

        #region Mark
        public static MarkApi ToMarkApi(this MarkClient mark)
        {
            return new MarkApi(mark.Id, mark.Name);
        }
        public static MarkClient ToMarkClient(this MarkApi mark)
        {
            return new MarkClient(mark.Id, mark.Name);
        }
        #endregion

        #region Model
        public static ModelApi ToModelApi(this ModeleClient model)
        {
            return new ModelApi(model.Id, model.Name, model.MarkId);
        }
        public static ModeleClient ToModelClient(this ModelApi model)
        {
            return new ModeleClient(model.Id, model.Name, model.MarkId);
        }
        #endregion

        #region PaymentMethode
        public static PaymentMethodApi ToPaymentMethodApi(this PaymentMethodClient payment)
        {
            return new PaymentMethodApi(payment.Id, payment.Method);
        }
        public static PaymentMethodClient ToPaymentMethodClient(this PaymentMethodApi payment)
        {
            return new PaymentMethodClient(payment.Id, payment.Method);
        }
        #endregion

        #region Penalization
        public static PenalizationApi ToPenalizationApi(this PenalizationClient penalization)
        {
            return new PenalizationApi(
                penalization.Id, penalization.Description, penalization.PenalDate, penalization.AmountOwed,
                penalization.AmountPaid);
        }
        public static PenalizationClient ToPenalizationClient(this PenalizationApi penalization)
        {
            return new PenalizationClient(
                penalization.Id, penalization.Description, penalization.PenalDate, penalization.AmountOwed,
                penalization.AmountPaid);
        }
        #endregion

        #region Reservation
        public static ReservationApi ToReservationApi(this ReservationClient reservation)
        {
            return new ReservationApi(
                reservation.Id, reservation.ReservationDate, reservation.StartDateLocation,
                reservation.EndDateLocation, reservation.AmountTotTVA, reservation.Deposit,
                reservation.DepositPaid, reservation.ReservationStatus, reservation.ReturnAgency,
                reservation.DamageCover, reservation.RobberyCover, reservation.AgeRange, reservation.PaidAll,
                reservation.IsCancelled, reservation.UserId, reservation.AgencyId, reservation.CategoryId);
        }
        public static ReservationClient ToReservationClient(this ReservationApi reservation)
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
        public static StateApi ToStateApi(this StateClient state)
        {
            return new StateApi(state.Id, state.StateType, state.Description);
        }
        public static StateClient ToStateClient(this StateApi state)
        {
            return new StateClient(state.Id, state.StateType, state.Description);
        }
        #endregion

        //A revoir par rapport au token et salt
        #region User
        public static UserApi ToUserApi(this UserClient user)
        {
            return new UserApi(
                user.Id, user.FirstName, user.LastName, user.Sex, user.BirthDate, user.RegistrationDate,
                user.Address, user.Phone, user.Email, user.Password, user.Role);
        }
        public static UserClient ToUserClient(this UserApi user)
        {
            return new UserClient(
                user.Id, user.FirstName, user.LastName, user.Sex, user.BirthDate, user.RegistrationDate,
                user.Address, user.Phone, user.Email, user.Password, user.Role);
        }
        #endregion

        #region Vehicle
        public static VehicleApi ToVehicleApi(this VehicleClient vehicle)
        {
            return new VehicleApi(
                vehicle.Id, vehicle.RegistrationNum, vehicle.Characteristic, vehicle.NbPlace, vehicle.NbDoor,
                vehicle.Fuel, vehicle.AirCo, vehicle.Gps, vehicle.Transmission, vehicle.StateId,
                vehicle.ModelId, vehicle.CategoryId);
        }
        public static VehicleClient ToVehicleClient(this VehicleApi vehicle)
        {
            return new VehicleClient(
                vehicle.Id, vehicle.RegistrationNum, vehicle.Characteristic, vehicle.NbPlace, vehicle.NbDoor,
                vehicle.Fuel, vehicle.AirCo, vehicle.Gps, vehicle.Transmission, vehicle.StateId,
                vehicle.ModelId, vehicle.CategoryId);
        }
        #endregion
    }
}
