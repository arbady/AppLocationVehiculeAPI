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
    public class StateClientService : IRepoState<StateClient>
    {
        private IRepoState<StateGlobal> _stateGlobalService;

        public StateClientService()
        {
            _stateGlobalService = new StateGlobalService();
        }

        public bool Delete(int id)
        {
            return _stateGlobalService.Delete(id);
        }

        public IEnumerable<StateClient> Get()
        {
            return _stateGlobalService.Get().Select(s => s.ToStateClient());
        }

        public StateClient Get(int id)
        {
            return _stateGlobalService.Get(id)?.ToStateClient();
        }

        public int Post(StateClient state)
        {
            return _stateGlobalService.Post(state.ToStateGlobal());
        }

        public bool Put(int id, StateClient state)
        {
            return _stateGlobalService.Put(id, state.ToStateGlobal());
        }
    }
}
