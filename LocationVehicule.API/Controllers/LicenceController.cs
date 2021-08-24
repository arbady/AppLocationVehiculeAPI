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
        public IEnumerable<LicenceClient> Get()
        {
            return _licenceService.Get();
        }

        // GET: api/Licence/3
        [HttpGet("{id:int}")]
        public LicenceClient Get(int id)
        {
            return _licenceService.Get(id);
        }

        // POST: api/Licence
        [HttpPost]
        public int Post([FromBody] LicenceClient licence)
        {
            return _licenceService.Post(licence);
        }

        // PUT: api/Licence/5
        [HttpPut("{id:int}")]
        public bool Put(int id, [FromBody] LicenceClient licence)
        {
            return _licenceService.Put(id, licence);
        }

        // DELETE: api/Licence/3
        [HttpDelete("{id:int}")]
        public bool Delete(int id)
        {
            return _licenceService.Delete(id);
        }
    }
}
