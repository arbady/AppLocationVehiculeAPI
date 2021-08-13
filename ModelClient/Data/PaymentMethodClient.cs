using ModelGlobal.Data;
using ModelGlobal.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClient.Data
{
    public class PaymentMethodClient : PaymentMethodGlobal
    {
        public PaymentMethodClient(){}
        public PaymentMethodClient(int id, Method method)
        {
            Id = id;
            Method = method;
        }
        public PaymentMethodClient(Method method)
        {
            Method = method;
        }
    }
}
