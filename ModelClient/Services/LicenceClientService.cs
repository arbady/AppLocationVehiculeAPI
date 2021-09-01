using ModelClient.Data;
using ModelClient.Mapper;
using ModelGlobal.Data;
using ModelGlobal.Services;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClient.Services
{
    public class LicenceClientService : IRepoLicence<LicenceClient>
    {
        private IRepoLicence<LicenceGlobal> _licenceGlobalService;

        public LicenceClientService()
        {
            _licenceGlobalService = new LicenceGlobalService();
        }

        public bool Delete(int id)
        {
            return _licenceGlobalService.Delete(id);
        }

        public IEnumerable<LicenceClient> Get()
        {
            return _licenceGlobalService.Get().Select(l => l.ToLicenceClient());
        }

        public IEnumerable<LicenceClient> GetForUser(int idUser)
        {
            return _licenceGlobalService.GetForUser(idUser).Select(l => l.ToLicenceClient());
        }

        public LicenceClient Get(int id)
        {
            return _licenceGlobalService.Get(id)?.ToLicenceClient();
        }

        public int Post(LicenceClient licence)
        {
            return _licenceGlobalService.Post(licence.ToLicenceGlobal());
        }

        public bool Put(int id, LicenceClient licence)
        {
            return _licenceGlobalService.Put(id, licence.ToLicenceGlobal());
        }
    }
}
