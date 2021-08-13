using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IRepoPenalization<TPenalization>
    {
        IEnumerable<TPenalization> Get();
        TPenalization Get(int id);
        int Post(TPenalization penalization);
        bool Put(int id, TPenalization penalization);
        bool Delete(int id);
    }
}
