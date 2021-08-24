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
    public class VehicleController : ControllerBase
    {
        //private VehicleClientService _vehicleService = new VehicleClientService();
        private readonly IRepoVehicle<VehicleClient> _vehicleService;
        public VehicleController(IRepoVehicle<VehicleClient> vehicleService)
        {
            _vehicleService = vehicleService;
        }

        // GET: api/Vehicle
        [HttpGet]
        public IEnumerable<VehicleClient> Get()
        {
            return _vehicleService.Get();
        }

        // GET: api/Vehicle/3
        [HttpGet("{id:int}")]
        public VehicleClient Get(int id)
        {
            return _vehicleService.Get(id);
        }

        // POST: api/Vehicle
        [HttpPost]
        public int Post([FromBody] VehicleClient vehicle)
        {
            return _vehicleService.Post(vehicle);
        }

        // PUT: api/Vehicle/5
        [HttpPut("{id:int}")]
        public bool Put(int id, [FromBody] VehicleClient vehicle)
        {
            return _vehicleService.Put(id, vehicle);
        }

        // DELETE: api/Vehicle/3
        [HttpDelete("{id:int}")]
        public bool Delete(int id)
        {
            return _vehicleService.Delete(id);
        }
    }
}
