using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IRepoCategory<TCategory>
    {
        IEnumerable<TCategory> Get();
        TCategory Get(int id);
        int Post(TCategory category);
        bool Put(int id, TCategory category);
        bool Delete(int id);
    }
}
