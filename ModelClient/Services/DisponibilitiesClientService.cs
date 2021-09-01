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
    public class DisponibilitiesClientService : IRepoDisponibilities<DisponibilitiesClient>
    {
        private IRepoDisponibilities<DisponibilitiesGlobal> _dispoGlobalService;
        public DisponibilitiesClientService()
        {
            _dispoGlobalService = new DisponibilitiesGlobalService();
        }

        public bool Delete(int id)
        {
            return _dispoGlobalService.Delete(id);
        }

        public IEnumerable<DisponibilitiesClient> Get()
        {
            return _dispoGlobalService.Get().Select(d => d.ToDisponibilitiesClient());
        }

        public DisponibilitiesClient Get(int id)
        {
            return _dispoGlobalService.Get(id)?.ToDisponibilitiesClient();
        }

        

        public int Post(DisponibilitiesClient disponibilities)
        {
            return _dispoGlobalService.Post(disponibilities.ToDisponibilitiesGlobal());
        }

        public bool Put(int id, DisponibilitiesClient disponibilities)
        {
            return _dispoGlobalService.Put(id, disponibilities.ToDisponibilitiesGlobal());
        }
    }
}
