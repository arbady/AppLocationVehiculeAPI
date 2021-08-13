using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IRepoDisponibilities<TDisponibilities>
    {
        IEnumerable<TDisponibilities> Get();
        TDisponibilities Get(int id);
        int Post(TDisponibilities disponibilities);
        bool Put(int id, TDisponibilities disponibilities);
        bool Delete(int id);
    }
}
