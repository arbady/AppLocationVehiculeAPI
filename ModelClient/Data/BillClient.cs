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
            float amountTotTVA, bool paid, int contractId, int paymentMethodId)
        {
            BillNum = billNum;
            Wording = wording;
            BillDate = billDate;
            AmountTotHTVA = amountTotHTVA;
            AmountTotTVA = amountTotTVA;
            Paid = paid;
            ContractId = contractId;
            PaymentMethodId = paymentMethodId;
        }
        public BillClient(int id, int billNum, string wording, DateTime billDate, float amountTotHTVA,
            float amountTotTVA, bool paid, int contractId, int paymentMethodId)
        {
            Id = id;
            BillNum = billNum;
            Wording = wording;
            BillDate = billDate;
            AmountTotHTVA = amountTotHTVA;
            AmountTotTVA = amountTotTVA;
            Paid = paid;
            ContractId = contractId;
            PaymentMethodId = paymentMethodId;
        }

    }
}
