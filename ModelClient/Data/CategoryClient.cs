using ModelGlobal.Data;
using ModelGlobal.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClient.Data
{
    public class CategoryClient : CategoryGlobal
    {
        public CategoryClient(){}
        public CategoryClient(int id, TypeCat typeCat, float costPerDay)
        {
            Id = id;
            TypeCat = typeCat;
            CostPerDay = costPerDay;
        }
        public CategoryClient(TypeCat typeCat, float costPerDay)
        {
            TypeCat = typeCat;
            CostPerDay = costPerDay;
        }
    }
}
