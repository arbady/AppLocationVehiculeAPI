using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IRepoVehicle<TVehicle>
    {
        IEnumerable<TVehicle> Get();
        TVehicle Get(int id);
        int Post(TVehicle vehicule);
        bool Put(int id, TVehicle vehicule);
        bool Delete(int id);
    }
}
