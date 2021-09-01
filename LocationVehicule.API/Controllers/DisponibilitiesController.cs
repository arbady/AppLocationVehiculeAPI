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
    public class DisponibilitiesController : ControllerBase
    {
        private readonly IRepoDisponibilities<DisponibilitiesClient> _disponibilitiesService;
        public DisponibilitiesController(IRepoDisponibilities<DisponibilitiesClient> disponibilitiesService)
        {
            _disponibilitiesService = disponibilitiesService;
        }

        // GET: api/Disponibilities
        [HttpGet]
        public IEnumerable<DisponibilitiesClient> Get()
        {
            return _disponibilitiesService.Get();
        }

        // GET: api/Disponibilities/3
        [HttpGet("{id:int}")]
        public DisponibilitiesClient Get(int id)
        {
            return _disponibilitiesService.Get(id);
        }

        // POST: api/Disponibilities
        [HttpPost]
        public int Post([FromBody] DisponibilitiesClient disponibilities)
        {
            return _disponibilitiesService.Post(disponibilities);
        }

        // PUT: api/Disponibilities/5
        [HttpPut("{id:int}")]
        public bool Put(int id, [FromBody] DisponibilitiesClient disponibilities)
        {
            return _disponibilitiesService.Put(id, disponibilities);
        }

        // DELETE: api/Disponibilities/3
        [HttpDelete("{id:int}")]
        public bool Delete(int id)
        {
            return _disponibilitiesService.Delete(id);
        }
    }
}
