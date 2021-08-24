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
    public class StateController : ControllerBase
    {
        //private StateClientService _stateService = new StateClientService();
        private readonly IRepoState<StateClient> _stateService;
        public StateController(IRepoState<StateClient> stateService)
        {
            _stateService = stateService;
        }

        // GET: api/State
        [HttpGet]
        public IEnumerable<StateClient> Get()
        {
            return _stateService.Get();
        }

        // GET: api/State/3
        [HttpGet("{id:int}")]
        public StateClient Get(int id)
        {
            return _stateService.Get(id);
        }

        // POST: api/State
        [HttpPost]
        public int Post([FromBody] StateClient state)
        {
            return _stateService.Post(state);
        }

        // PUT: api/State/5
        [HttpPut("{id:int}")]
        public bool Put(int id, [FromBody] StateClient state)
        {
            return _stateService.Put(id, state);
        }

        // DELETE: api/State/3
        [HttpDelete("{id:int}")]
        public bool Delete(int id)
        {
            return _stateService.Delete(id);
        }
    }
}
