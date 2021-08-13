using ModelGlobal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClient.Data
{
    public class BillClient : BillGlobal
    {
        public BillClient(){}
        public BillClient(int billNum, string wording, DateTime billDate, float amountTotHTVA, 
            float amountTotTVA, bool paid, int contractId, int paymentMethodeId)
        {
            BillNum = billNum;
            Wording = wording;
            BillDate = billDate;
            AmountTotHTVA = amountTotHTVA;
            AmountTotTVA = amountTotTVA;
            Paid = paid;
            ContractId = contractId;
            PaymentMethodeId = paymentMethodeId;
        }
        public BillClient(int id, int billNum, string wording, DateTime billDate, float amountTotHTVA,
            float amountTotTVA, bool paid, int contractId, int paymentMethodeId)
        {
            Id = id;
            BillNum = billNum;
            Wording = wording;
            BillDate = billDate;
            AmountTotHTVA = amountTotHTVA;
            AmountTotTVA = amountTotTVA;
            Paid = paid;
            ContractId = contractId;
            PaymentMethodeId = paymentMethodeId;
        }

    }
}
