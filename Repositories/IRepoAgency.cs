using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IRepoAgency<TAgency>
    {
        IEnumerable<TAgency> Get();
        TAgency Get(int id);
        int Post(TAgency agency);
        bool Put(int id, TAgency agency);
        bool Delete(int id);
    }
}
