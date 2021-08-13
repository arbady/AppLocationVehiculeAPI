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
    public class ModelClientService : IRepoModel<ModeleClient>
    {
        private IRepoModel<ModelGlobale> _modelGlobalService;

        public ModelClientService()
        {
            _modelGlobalService = new ModelGlobalService();
        }

        public bool Delete(int id)
        {
            return _modelGlobalService.Delete(id);
        }

        public IEnumerable<ModeleClient> Get()
        {
            return _modelGlobalService.Get().Select(m => m.ToModelClient());
        }

        public ModeleClient Get(int id)
        {
            return _modelGlobalService.Get(id)?.ToModelClient();
        }

        public int Post(ModeleClient model)
        {
            return _modelGlobalService.Post(model.ToModelGlobal());
        }

        public bool Put(int id, ModeleClient model)
        {
            return _modelGlobalService.Put(id, model.ToModelGlobal());
        }
    }
}
