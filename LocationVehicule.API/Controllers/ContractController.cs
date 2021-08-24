using LocationVehicule.API.Mapper;
using LocationVehicule.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelClient.Data;
using ModelClient.Services;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocationVehicule.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContractController : ControllerBase
    {
        //private ContractClientService _contractService = new ContractClientService();
        private readonly IRepoContract<ContractClient> _contractService;
        public ContractController(IRepoContract<ContractClient> contractClient)
        {
            _contractService = contractClient;
        }

        // GET: api/Contract
        [HttpGet]
        public IEnumerable<ContractApi> Get()
        {
            return _contractService.Get().Select(c => c.ToContractApi());
        }

        // GET: api/Contract/3
        [HttpGet("{id:int}")]
        public ContractApi Get(int id)
        {
            return _contractService.Get(id).ToContractApi();
        }

        // POST: api/Contract
        [HttpPost]
        public int Post([FromBody] ContractApi contract)
        {
            return _contractService.Post(contract.ToContractClient());
        }

        // PUT: api/Contract/5
        [HttpPut("{id:int}")]
        public bool Put(int id, [FromBody] ContractApi contract)
        {
            return _contractService.Put(id, contract.ToContractClient());
        }

        // DELETE: api/Contract/3
        [HttpDelete("{id:int}")]
        public bool Delete(int id)
        {
            return _contractService.Delete(id);
        }
    }
}
