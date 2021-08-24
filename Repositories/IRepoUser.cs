using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IRepoUser<TUser> : ISecurity<TUser>
    {
        IEnumerable<TUser> Get();
        TUser Get(int id);
        int Post(TUser user);
        bool Put(int id, TUser user);
        bool Delete(int id);
    }
}
