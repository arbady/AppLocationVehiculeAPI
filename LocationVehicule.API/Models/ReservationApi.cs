using ModelClient.Data;
using ModelGlobal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationVehicule.API.Models
{
    public class ReservationApi : ReservationClient
    {
        public ReservationApi(int id, DateTime reservationDate, DateTime startDateLocation, DateTime endDateLocation, double amountTotTVA, double deposit, bool depositPaid, bool reservationStatus, string returnAgency, bool damageCover, bool robberyCover, bool ageRange, bool paidAll, bool isCancelled, int userId, int agencyId, int categoryId)
        {
            Id = id;
            ReservationDate = reservationDate;
            StartDateLocation = startDateLocation;
            EndDateLocation = endDateLocation;
            AmountTotTVA = amountTotTVA;
            Deposit = deposit;
            DepositPaid = depositPaid;
            ReservationStatus = reservationStatus;
            ReturnAgency = returnAgency;
            DamageCover = damageCover;
            RobberyCover = robberyCover;
            AgeRange = ageRange;
            PaidAll = paidAll;
            IsCancelled = isCancelled;
            UserId = userId;
            AgencyId = agencyId;
            CategoryId = categoryId;
        }     
    }
}
