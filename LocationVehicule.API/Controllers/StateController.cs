using LocationVehicule.API.Mapper;
using LocationVehicule.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelClient.Services;
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
        private StateClientService _stateService = new StateClientService();

        // GET: api/State
        [HttpGet]
        public IEnumerable<StateApi> Get()
        {
            return _stateService.Get().Select(s => s.ToStateApi());
        }

        // GET: api/State/3
        [HttpGet("{id:int}")]
        public StateApi Get(int id)
        {
            return _stateService.Get(id).ToStateApi();
        }

        // POST: api/State
        [HttpPost]
        public int Post([FromBody] StateApi state)
        {
            return _stateService.Post(state.ToStateClient());
        }

        // PUT: api/State/5
        [HttpPut]
        public bool Put(int id, [FromBody] StateApi state)
        {
            return _stateService.Put(id, state.ToStateClient());
        }

        // DELETE: api/State/3
        [HttpDelete]
        public bool Delete(int id)
        {
            return _stateService.Delete(id);
        }
    }
}
