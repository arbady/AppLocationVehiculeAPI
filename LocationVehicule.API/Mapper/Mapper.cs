using LocationVehicule.API.Models;
using ModelClient.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocationVehicule.API.Mapper
{
    public static class Mapper
    {
        #region Agency
        public static AgencyApi ToAgencyApi(this AgencyClient agency)
        {
            return new AgencyApi(agency.Id, agency.Code, agency.Airport, agency.Address, agency.ZipCode, agency.City,
                agency.Country, agency.IsClosed);
        }

        public static AgencyClient ToAgencyClient(this AgencyApi agency)
        {
            return new AgencyClient(agency.Id, agency.Code, agency.Airport, agency.Address, agency.ZipCode, agency.City,
                agency.Country, agency.IsClosed);
        }
        #endregion
    }
}
