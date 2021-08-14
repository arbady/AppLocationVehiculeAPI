﻿using ModelClient.Data;
using ModelGlobal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationVehicule.API.Models
{
    public class BillApi : BillClient
    {
        public BillApi(int id, int billNum, string wording, DateTime billDate, float amountTotHTVA,
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