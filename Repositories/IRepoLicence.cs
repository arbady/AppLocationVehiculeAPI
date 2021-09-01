using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IRepoLicence<TLicence>
    {
        IEnumerable<TLicence> Get();
        TLicence Get(int id);
        int Post(TLicence licence);
        bool Put(int id, TLicence licence);
        bool Delete(int id);
        IEnumerable<TLicence> GetForUser(int idUser);
    }
}
