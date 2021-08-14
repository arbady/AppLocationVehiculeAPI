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
    public class PenalizationController : ControllerBase
    {
        private PenalizationClientService _penalService = new PenalizationClientService();

        // GET: api/Penalization
        [HttpGet]
        public IEnumerable<PenalizationApi> Get()
        {
            return _penalService.Get().Select(p => p.ToPenalizationApi());
        }

        // GET: api/Penalization/3
        [HttpGet("{id:int}")]
        public PenalizationApi Get(int id)
        {
            return _penalService.Get(id).ToPenalizationApi();
        }

        // POST: api/Penalization
        [HttpPost]
        public int Post([FromBody] PenalizationApi penal)
        {
            return _penalService.Post(penal.ToPenalizationClient());
        }

        // PUT: api/Penalization/5
        [HttpPut]
        public bool Put(int id, [FromBody] PenalizationApi penal)
        {
            return _penalService.Put(id, penal.ToPenalizationClient());
        }

        // DELETE: api/Penalization/3
        [HttpDelete]
        public bool Delete(int id)
        {
            return _penalService.Delete(id);
        }
    }
}
