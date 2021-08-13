using ModelClient.Data;
using ModelGlobal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClient.Mapper
{
    internal static class Mapper
    {
        #region Agency
        internal static AgencyGlobal ToAgencyGlobal(this AgencyClient agency)
        {
            return new AgencyGlobal()
            {
                Id = agency.Id,
                Code = agency.Code,
                Airport = agency.Airport,
                Address = agency.Address,
                ZipCode = agency.ZipCode,
                City = agency.City,
                Country = agency.Country,
                IsClosed = agency.IsClosed
            };
        }

        internal static AgencyClient ToAgencyClient(this AgencyGlobal agency)
        {
            return new AgencyClient(
                agency.Id, agency.Code, agency.Airport, agency.Address, agency.ZipCode, agency.City, 
                agency.Country, agency.IsClosed);
        }
        #endregion
    }
}
