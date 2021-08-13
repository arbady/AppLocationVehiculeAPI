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
    public class PenalizationClientService : IRepoPenalization<PenalizationClient>
    {
        private IRepoPenalization<PenalizationGlobal> _penalGlobalService;

        public PenalizationClientService()
        {
            _penalGlobalService = new PenalizationGlobalService();
        }

        public bool Delete(int id)
        {
            return _penalGlobalService.Delete(id);
        }

        public IEnumerable<PenalizationClient> Get()
        {
            return _penalGlobalService.Get().Select(p => p.ToPenalizationClient()); 
        }

        public PenalizationClient Get(int id)
        {
            return _penalGlobalService.Get(id)?.ToPenalizationClient();
        }

        public int Post(PenalizationClient penalization)
        {
            return _penalGlobalService.Post(penalization.ToPenalizationGlobal());
        }

        public bool Put(int id, PenalizationClient penalization)
        {
            return _penalGlobalService.Put(id, penalization.ToPenalizationGlobal());
        }
    }
}
