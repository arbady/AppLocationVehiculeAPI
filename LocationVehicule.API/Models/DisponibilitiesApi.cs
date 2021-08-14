using ModelClient.Data;
using ModelGlobal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationVehicule.API.Models
{
    public class DisponibilitiesApi : DisponibilitiesClient
    {
       public DisponibilitiesApi(int id, DateTime availDateDepart, DateTime availDateReturn, int agencyId, int vehicleId)
        {
            Id = id;
            AvailDateDepart = availDateDepart;
            AvailDateReturn = availDateReturn;
            AgencyId = agencyId;
            VehicleId = vehicleId;
        }       
    }
}
