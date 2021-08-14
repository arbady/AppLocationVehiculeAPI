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
    public class LicenceApi : LicenceClient
    {
        public LicenceApi(int id, LicenceCat licenceCat, string description)
        {
            Id = id;
            LicenceCat = licenceCat;
            Description = description;
        }
    }
}
