using ModelGlobal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClient.Data
{
    public class AgencyClient /*: AgencyGlobal*/
    {
        //il est possible de se passer des propriétés suivant en mettant en place un héritage entre global et client
        public AgencyClient(){}

        public AgencyClient(string code, string airport, string address, int zipCode, string city, string country, bool isClosed)
        {
            Code = code;
            Airport = airport;
            Address = address;
            ZipCode = zipCode;
            City = city;
            Country = country;
            IsClosed = isClosed;
        }

        public AgencyClient(int id, string code, string airport, string address, int zipCode, string city, string country, bool isClosed)
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
