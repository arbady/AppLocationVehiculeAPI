using ModelGlobal.Data;
using ModelGlobal.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClient.Data
{
    public class LicenceClient : LicenceGlobal
    {
        public LicenceClient(){}
        public LicenceClient(int id, LicenceCat licenceCat, string description)
        {
            Id = id;
            LicenceCat = licenceCat;
            Description = description;
        }
        public LicenceClient(LicenceCat licenceCat, string description)
        {
            LicenceCat = licenceCat;
            Description = description;
        }
    }
}
