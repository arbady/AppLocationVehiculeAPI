using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IRepoBill<TBill>
    {
        IEnumerable<TBill> Get();
        TBill Get(int id);
        int Post(TBill bill);
        bool Put(int id, TBill bill);
        bool Delete(int id);
    }
}
