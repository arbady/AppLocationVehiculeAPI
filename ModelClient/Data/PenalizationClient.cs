using ModelGlobal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClient.Data
{
    public class PenalizationClient : PenalizationGlobal
    {
        public PenalizationClient(){}
        public PenalizationClient(string description, DateTime penalDate, float amountOwed, float amountPaid)
        {
            Description = description;
            PenalDate = penalDate;
            AmountOwed = amountOwed;
            AmountPaid = amountPaid;
        }
        public PenalizationClient(int id, string description, DateTime penalDate, float amountOwed, float amountPaid)
        {
            Id = id;
            Description = description;
            PenalDate = penalDate;
            AmountOwed = amountOwed;
            AmountPaid = amountPaid;
        }
    }
}
