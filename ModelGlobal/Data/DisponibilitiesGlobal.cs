using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelGlobal.Data
{
    public class DisponibilitiesGlobal
    {
        public int Id { get; set; }
        public DateTime AvailDateDepart { get; set; }
        public DateTime AvailDateReturn { get; set; }
        public int AgencyId { get; set; }
        public int VehicleId { get; set; }
    }
}
