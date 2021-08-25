using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools;

namespace ModelGlobal.Services.Bases
{
    public abstract class BaseService
    {
        protected Connection _connection;
        protected string _conStr = @"Data Source=LAPTOP-VIA3UD35;Initial Catalog=AppLocationVehicule;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public BaseService()
        {
            _connection = new Connection(_conStr);
        }
    }
}
