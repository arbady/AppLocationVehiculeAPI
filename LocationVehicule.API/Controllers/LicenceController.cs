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
    public class LicenceController : ControllerBase
    {
        //private LicenceClientService _licenceService = new LicenceClientService();
        private readonly IRepoLicence<LicenceClient> _licenceService;
        public LicenceController(IRepoLicence<LicenceClient> licenceService)
        {
            _licenceService = licenceService;
        }

        // GET: api/Licence
        [HttpGet]
        public IEnumerable<LicenceApi> Get()
        {
            return _licenceService.Get().Select(l => l.ToLicenceApi());
        }

        // GET: api/Licence/3
        [HttpGet("{id:int}")]
        public LicenceApi Get(int id)
        {
            return _licenceService.Get(id).ToLicenceApi();
        }

        // POST: api/Licence
        [HttpPost]
        public int Post([FromBody] LicenceApi licence)
        {
            return _licenceService.Post(licence.ToLicenceClient());
        }

        // PUT: api/Licence/5
        [HttpPut("{id:int}")]
        public bool Put(int id, [FromBody] LicenceApi licence)
        {
            return _licenceService.Put(id, licence.ToLicenceClient());
        }

        // DELETE: api/Licence/3
        [HttpDelete("{id:int}")]
        public bool Delete(int id)
        {
            return _licenceService.Delete(id);
        }
    }
}
