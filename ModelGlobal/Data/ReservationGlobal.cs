using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelGlobal.Data
{
    public class ReservationGlobal
    {
        public int Id { get; set; }
        public DateTime ReservationDate { get; set; }
        public DateTime StartDateLocation { get; set; }
        public DateTime EndDateLocation { get; set; }
        public float AmountTotTVA { get; set; }
        public float Deposit { get; set; }
        public bool DepositPaid { get; set; }
        public bool ReservationStatus { get; set; }
        public string ReturnAgency { get; set; }
        public bool DamageCover { get; set; }
        public bool RobberyCover { get; set; }
        public bool AgeRange { get; set; }
        public bool PaidAll { get; set; }
        public bool IsCancelled { get; set; }
        public int UserId { get; set; }
        public int AgencyId { get; set; }
        public int CategoryId { get; set; }
    }
}
