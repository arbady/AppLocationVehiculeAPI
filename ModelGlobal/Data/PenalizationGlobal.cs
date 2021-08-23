using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelGlobal.Data
{
    public class PenalizationGlobal
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime PenalDate { get; set; }
        public double AmountOwed { get; set; }
        public double AmountPaid { get; set; }
    }
}
