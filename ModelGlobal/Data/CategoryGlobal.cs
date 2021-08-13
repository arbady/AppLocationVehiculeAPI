using ModelGlobal.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelGlobal.Data
{
    public class CategoryGlobal
    {
        public int Id { get; set; }
        public TypeCat TypeCat { get; set; }
        public float CostPerDay { get; set; }
    }
}
