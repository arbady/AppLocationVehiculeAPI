using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IRepoModel<TModel>
    {
        IEnumerable<TModel> Get();
        TModel Get(int id);
        int Post(TModel model);
        bool Put(int id, TModel model);
        bool Delete(int id);
    }
}
