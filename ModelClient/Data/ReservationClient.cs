using ModelGlobal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClient.Data
{
    public class ReservationClient : ReservationGlobal
    {
        public ReservationClient(){}
        public ReservationClient(int id, DateTime reservationDate, DateTime startDateLocation, DateTime endDateLocation, double amountTotTVA, double deposit, bool depositPaid, bool reservationStatus, string returnAgency, bool damageCover, bool robberyCover, bool ageRange, bool paidAll, bool isCancelled, int userId, int agencyId, int categoryId)
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
        public ReservationClient(DateTime reservationDate, DateTime startDateLocation, DateTime endDateLocation, double amountTotTVA, double deposit, bool depositPaid, bool reservationStatus, string returnAgency, bool damageCover, bool robberyCover, bool ageRange, bool paidAll, bool isCancelled, int userId, int agencyId, int categoryId)
        {
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
