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
    public class ContractClientService : IRepoContract<ContractClient>
    {
        private IRepoContract<ContractGlobal> _contractGlobalService;

        public ContractClientService()
        {
            _contractGlobalService = new ContractGlobalService();
        }

        public bool Delete(int id)
        {
            return _contractGlobalService.Delete(id);
        }

        public IEnumerable<ContractClient> Get()
        {
            return _contractGlobalService.Get().Select(c => c.ToContractClient());
        }

        public ContractClient Get(int id)
        {
            return _contractGlobalService.Get(id)?.ToContractClient();
        }

        public int Post(ContractClient contract)
        {
            return _contractGlobalService.Post(contract.ToContractGlobal());
        }

        public bool Put(int id, ContractClient contract)
        {
            return _contractGlobalService.Put(id, contract.ToContractGlobal());
        }
    }
}
