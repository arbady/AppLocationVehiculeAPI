using ModelGlobal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClient.Data
{
    public class DisponibilitiesClient : DisponibilitiesGlobal
    {
        public DisponibilitiesClient(){}
        public DisponibilitiesClient(int id, DateTime availDateDepart, DateTime availDateReturn, int agencyId, int vehicleId)
        {
            Id = id;
            AvailDateDepart = availDateDepart;
            AvailDateReturn = availDateReturn;
            AgencyId = agencyId;
            VehicleId = vehicleId;
        }
        public DisponibilitiesClient(DateTime availDateDepart, DateTime availDateReturn, int agencyId, int vehicleId)
        {
            AvailDateDepart = availDateDepart;
            AvailDateReturn = availDateReturn;
            AgencyId = agencyId;
            VehicleId = vehicleId;
        }
    }
}
