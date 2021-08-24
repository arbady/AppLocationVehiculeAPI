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
    public class AgencyClientService : IRepoAgency<AgencyClient>
    {
        private readonly IRepoAgency<AgencyGlobal> _agencyGlobalService;
        public AgencyClientService()
        {
            _agencyGlobalService = new AgencyGlobalService();
        }
        public bool Delete(int id)
        {
            return _agencyGlobalService.Delete(id);
        }

        public IEnumerable<AgencyClient> Get()
        {
            return _agencyGlobalService.Get().Select(a => a.ToAgencyClient());
        }

        public AgencyClient Get(int id)
        {
            return _agencyGlobalService.Get(id)?.ToAgencyClient();
        }

        public int Post(AgencyClient agency)
        {
            return _agencyGlobalService.Post(agency.ToAgencyGlobal());
        }

        public bool Put(int id, AgencyClient agency)
        {
            return _agencyGlobalService.Put(id, agency.ToAgencyGlobal());
        }
    }
}
