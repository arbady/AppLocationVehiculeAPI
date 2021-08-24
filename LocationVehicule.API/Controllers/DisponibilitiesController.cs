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
    public class DisponibilitiesController : ControllerBase
    {
        //private DisponibilitiesClientService _disponibilitiesService = new DisponibilitiesClientService();
        private readonly IRepoDisponibilities<DisponibilitiesClient> _disponibilitiesService;
        public DisponibilitiesController(IRepoDisponibilities<DisponibilitiesClient> disponibilitiesService)
        {
            _disponibilitiesService = disponibilitiesService;
        }

        // GET: api/Disponibilities
        [HttpGet]
        public IEnumerable<DisponibilitiesApi> Get()
        {
            return _disponibilitiesService.Get().Select(d => d.ToDisponibilitiesApi());
        }

        // GET: api/Disponibilities/3
        [HttpGet("{id:int}")]
        public DisponibilitiesApi Get(int id)
        {
            return _disponibilitiesService.Get(id).ToDisponibilitiesApi();
        }

        // POST: api/Disponibilities
        [HttpPost]
        public int Post([FromBody] DisponibilitiesApi disponibilities)
        {
            return _disponibilitiesService.Post(disponibilities.ToDisponibilitiesClient());
        }

        // PUT: api/Disponibilities/5
        [HttpPut("{id:int}")]
        public bool Put(int id, [FromBody] DisponibilitiesApi disponibilities)
        {
            return _disponibilitiesService.Put(id, disponibilities.ToDisponibilitiesClient());
        }

        // DELETE: api/Disponibilities/3
        [HttpDelete("{id:int}")]
        public bool Delete(int id)
        {
            return _disponibilitiesService.Delete(id);
        }
    }
}
