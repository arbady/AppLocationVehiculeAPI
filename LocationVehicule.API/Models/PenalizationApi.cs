using ModelClient.Data;
using ModelGlobal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationVehicule.API.Models
{
    public class PenalizationApi : PenalizationClient
    {
        public PenalizationApi(int id, string description, DateTime penalDate, float amountOwed, float amountPaid)
        {
            Id = id;
            Description = description;
            PenalDate = penalDate;
            AmountOwed = amountOwed;
            AmountPaid = amountPaid;
        }
    }
}
