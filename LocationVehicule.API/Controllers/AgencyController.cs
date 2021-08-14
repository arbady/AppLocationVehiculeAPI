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
    public class AgencyController : ControllerBase
    {
        private AgencyClientService _agencyService = new AgencyClientService();

        // GET: api/Agency
        [HttpGet]
        public IEnumerable<AgencyApi> Get()
        {
            return _agencyService.Get().Select(a => a.ToAgencyApi());
        }

        // GET: api/Agency/3
        [HttpGet("{id:int}")]
        public AgencyApi Get(int id)
        {
            return _agencyService.Get(id).ToAgencyApi();
        }

        // POST: api/Agency
        [HttpPost]
        public int Post([FromBody] AgencyApi agency)
        {
            return _agencyService.Post(agency.ToAgencyClient());
        }

        // PUT: api/Agency/5
        [HttpPut]
        public bool Put(int id, [FromBody] AgencyApi agency)
        {
            return _agencyService.Put(id, agency.ToAgencyClient());
        }

        // DELETE: api/Agency/3
        [HttpDelete]
        public bool Delete(int id)
        {
            return _agencyService.Delete(id);
        }
    }
}
