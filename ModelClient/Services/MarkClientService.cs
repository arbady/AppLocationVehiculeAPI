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
    public class MarkClientService : IRepoMark<MarkClient>
    {
        private IRepoMark<MarkGlobal> _markGlobalService;

        public MarkClientService()
        {
            _markGlobalService = new MarkGlobalService();
        }

        public bool Delete(int id)
        {
            return _markGlobalService.Delete(id);
        }

        public IEnumerable<MarkClient> Get()
        {
            return _markGlobalService.Get().Select(m => m.ToMarkClient());
        }

        public MarkClient Get(int id)
        {
            return _markGlobalService.Get(id)?.ToMarkClient();
        }

        public int Post(MarkClient mark)
        {
            return _markGlobalService.Post(mark.ToMarkGlobal());
        }

        public bool Put(int id, MarkClient mark)
        {
            return _markGlobalService.Put(id, mark.ToMarkGlobal());
        }
    }
}
