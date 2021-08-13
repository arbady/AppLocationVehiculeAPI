using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IRepoMark<TMark>
    {
        IEnumerable<TMark> Get();
        TMark Get(int id);
        int Post(TMark mark);
        bool Put(int id, TMark mark);
        bool Delete(int id);
    }
}
