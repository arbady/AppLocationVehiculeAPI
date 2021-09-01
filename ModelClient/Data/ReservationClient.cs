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
        public UserClient User { get; set; }
        public AgencyClient Agency { get; set; }
        public CategoryClient Category { get; set; }
        public ReservationClient(){}
        public ReservationClient(int id, DateTime reservationDate, DateTime startDateLocation, 
            DateTime endDateLocation, int returnAgency, bool damageCover, bool robberyCover, 
            bool ageRange, bool isCancelled, int userId, int agencyId, int categoryId)
        {
            Id = id;
            ReservationDate = reservationDate;
            StartDateLocation = startDateLocation;
            EndDateLocation = endDateLocation;
            //AmountTotTVA = amountTotTVA;
            //Deposit = deposit;
            //DepositPaid = depositPaid;
            //ReservationStatus = reservationStatus;
            ReturnAgency = returnAgency;
            DamageCover = damageCover;
            RobberyCover = robberyCover;
            AgeRange = ageRange;
            //PaidAll = paidAll;
            IsCancelled = isCancelled;
            UserId = userId;
            AgencyId = agencyId;
            CategoryId = categoryId;
        }
        public ReservationClient(DateTime reservationDate, DateTime startDateLocation, DateTime endDateLocation, 
            int returnAgency, bool damageCover, bool robberyCover, bool ageRange, bool isCancelled, int userId, 
            int agencyId, int categoryId)
        {
            ReservationDate = reservationDate;
            StartDateLocation = startDateLocation;
            EndDateLocation = endDateLocation;
            //AmountTotTVA = amountTotTVA;
            //Deposit = deposit;
            //DepositPaid = depositPaid;
            //ReservationStatus = reservationStatus;
            ReturnAgency = returnAgency;
            DamageCover = damageCover;
            RobberyCover = robberyCover;
            AgeRange = ageRange;
            //PaidAll = paidAll;
            IsCancelled = isCancelled;
            UserId = userId;
            AgencyId = agencyId;
            CategoryId = categoryId;
        }        
    }
}
