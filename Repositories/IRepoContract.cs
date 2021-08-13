using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IRepoContract<TContract>
    {
        IEnumerable<TContract> Get();
        TContract Get(int id);
        int Post(TContract contract);
        bool Put(int id, TContract contract);
        bool Delete(int id);
    }
}
