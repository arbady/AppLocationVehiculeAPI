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
    public class PenalizationController : ControllerBase
    {
        //private PenalizationClientService _penalService = new PenalizationClientService();
        private readonly IRepoPenalization<PenalizationClient> _penalService;
        public PenalizationController(IRepoPenalization<PenalizationClient> penalService)
        {
            _penalService = penalService;
        }

        // GET: api/Penalization
        [HttpGet]
        public IEnumerable<PenalizationClient> Get()
        {
            return _penalService.Get();
        }

        // GET: api/Penalization/3
        [HttpGet("{id:int}")]
        public PenalizationClient Get(int id)
        {
            return _penalService.Get(id);
        }

        // POST: api/Penalization
        [HttpPost]
        public int Post([FromBody] PenalizationClient penal)
        {
            return _penalService.Post(penal);
        }

        // PUT: api/Penalization/5
        [HttpPut("{id:int}")]
        public bool Put(int id, [FromBody] PenalizationClient penal)
        {
            return _penalService.Put(id, penal);
        }

        // DELETE: api/Penalization/3
        [HttpDelete("{id:int}")]
        public bool Delete(int id)
        {
            return _penalService.Delete(id);
        }
    }
}
