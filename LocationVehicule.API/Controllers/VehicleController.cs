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
        private readonly IRepoVehicle<VehicleClient> _vehicleService;
        private readonly IRepoAgency<AgencyClient> _agencyService;
        private readonly IRepoDisponibilities<DisponibilitiesClient> _dispoService;
        public VehicleController(IRepoVehicle<VehicleClient> vehicleService,
            IRepoAgency<AgencyClient> agencyService, IRepoDisponibilities<DisponibilitiesClient> dispoService)
        {
            _vehicleService = vehicleService;
            _agencyService = agencyService;
            _dispoService = dispoService;
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
        
        // GET: api/Vehicle/3/Agency
        [HttpGet("{id:int}/Agency")]
        public AgencyClient GetAgency(int id)
        {
            return _agencyService.GetForVehicle(id);
        }               
        
        // GET: api/Vehicle/Disponibilities
        [HttpGet("/Disponibilities")]
        public IEnumerable<VehicleClient> GetDisponibilities(DateTime tdate, int idAgency, int idCategory)
        {
            return _vehicleService.GetDispoForVehicle(tdate, idAgency, idCategory);
        }

        // Get: api/Vehicle/Category/2/
        [HttpGet("Category/{id:int}")]
        public IEnumerable<VehicleClient> GetCatForVehicle(int id) 
        {
            return _vehicleService.GetCatForVehicle(id);
        }

        // GET: api/Vehicle/Agency/3/
        [HttpGet("Agency/{id:int}")]
        public IEnumerable<VehicleClient> VehiclesByAgency(int id)
        {
            return _vehicleService.GetVehiclesByAgency(id);
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
