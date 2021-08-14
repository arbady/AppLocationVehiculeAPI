using ModelClient.Data;
using ModelGlobal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationVehicule.API.Models
{
    public class MarkApi : MarkClient
    {
        public MarkApi(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
