using ModelClient.Data;
using ModelGlobal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationVehicule.API.Models
{
    public class ModelApi : ModeleClient
    {
        public ModelApi(int id, string name, int markId)
        {
            Id = id;
            Name = name;
            MarkId = markId;
        }
    }
}
