using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelGlobal.Data
{
    public /*sealed*/ class AgencyGlobal
    { 
        public int Id { get; set; }
        public string Code { get; set; }
        public string Airport { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public bool IsClosed { get; set; }
    }
}
