using ModelClient.Data;
using ModelGlobal.Data;
using ModelGlobal.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationVehicule.API.Models
{
    public class PaymentMethodApi : PaymentMethodClient
    {
        public PaymentMethodApi(int id, Method method)
        {
            Id = id;
            Method = method;
        }
    }
}
