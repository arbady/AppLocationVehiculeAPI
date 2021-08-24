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
        public IEnumerable<VehicleApi> Get()
        {
            return _vehicleService.Get().Select(v => v.ToVehicleApi());
        }

        // GET: api/Vehicle/3
        [HttpGet("{id:int}")]
        public VehicleApi Get(int id)
        {
            return _vehicleService.Get(id).ToVehicleApi();
        }

        // POST: api/Vehicle
        [HttpPost]
        public int Post([FromBody] VehicleApi vehicle)
        {
            return _vehicleService.Post(vehicle.ToVehicleClient());
        }

        // PUT: api/Vehicle/5
        [HttpPut("{id:int}")]
        public bool Put(int id, [FromBody] VehicleApi vehicle)
        {
            return _vehicleService.Put(id, vehicle.ToVehicleClient());
        }

        // DELETE: api/Vehicle/3
        [HttpDelete("{id:int}")]
        public bool Delete(int id)
        {
            return _vehicleService.Delete(id);
        }
    }
}
