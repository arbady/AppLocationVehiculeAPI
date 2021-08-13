using ModelGlobal.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelGlobal.Data
{
    public class LicenceGlobal
    {
        public int Id { get; set; }
        public LicenceCat LicenceCat { get; set; }
        public string Description { get; set; }
    }
}
