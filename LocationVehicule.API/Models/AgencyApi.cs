using ModelClient.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocationVehicule.API.Models
{
    public class AgencyApi /*: AgencyClient*/
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Airport { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public bool IsClosed { get; set; }

        public AgencyApi(int id, string code, string airport, string address, int zipCode, string city, string country, bool isClosed)
        {
            Id = id;
            Code = code;
            Airport = airport;
            Address = address;
            ZipCode = zipCode;
            City = city;
            Country = country;
            IsClosed = isClosed;
        }
    }
}
