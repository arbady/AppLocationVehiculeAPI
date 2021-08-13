using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelGlobal.Data
{
    public class BillGlobal
    {       
        public int Id { get; set; }
        public int BillNum { get; set; }
        public string Wording { get; set; }
        public DateTime BillDate { get; set; }
        public float AmountTotHTVA { get; set; }
        public float AmountTotTVA { get; set; }
        public bool Paid { get; set; }
        public int ContractId { get; set; }
        public int PaymentMethodId { get; set; }
    }
}
