using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IRepoReservation<TReservation>
    {
        IEnumerable<TReservation> Get();
        TReservation Get(int id);
        int Post(TReservation reservation);
        bool Put(int id, TReservation reservation);
        bool Delete(int id);
    }
}
