using ModelClient.Data;
using ModelGlobal.Data;
using ModelGlobal.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationVehicule.API.Models
{
    public class CategoryApi : CategoryClient
    {      
        public CategoryApi(int id, TypeCat typeCat, float costPerDay)
        {
            Id = id;
            TypeCat = typeCat;
            CostPerDay = costPerDay;
        }
    }
}
