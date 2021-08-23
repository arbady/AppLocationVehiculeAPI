using ModelClient.Data;
using ModelGlobal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClient.Services
{
    public interface ISecurity
    {
        public UserClient Check(string mail, string password);
    }
}
