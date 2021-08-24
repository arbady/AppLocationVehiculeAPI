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
        public IEnumerable<ContractClient> Get()
        {
            return _contractService.Get();
        }

        // GET: api/Contract/3
        [HttpGet("{id:int}")]
        public ContractClient Get(int id)
        {
            return _contractService.Get(id);
        }

        // POST: api/Contract
        [HttpPost]
        public int Post([FromBody] ContractClient contract)
        {
            return _contractService.Post(contract);
        }

        // PUT: api/Contract/5
        [HttpPut("{id:int}")]
        public bool Put(int id, [FromBody] ContractClient contract)
        {
            return _contractService.Put(id, contract);
        }

        // DELETE: api/Contract/3
        [HttpDelete("{id:int}")]
        public bool Delete(int id)
        {
            return _contractService.Delete(id);
        }
    }
}
