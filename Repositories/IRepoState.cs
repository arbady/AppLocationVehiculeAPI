using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IRepoState<TState>
    {
        IEnumerable<TState> Get();
        TState Get(int id);
        int Post(TState state);
        bool Put(int id, TState state);
        bool Delete(int id);
    }
}
