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
    public class MarkController : ControllerBase
    {
        //private MarkClientService _markService = new MarkClientService();
        private readonly IRepoMark<MarkClient> _markService;
        public MarkController(IRepoMark<MarkClient> markService)
        {
            _markService = markService;
        }

        // GET: api/Mark
        [HttpGet]
        public IEnumerable<MarkApi> Get()
        {
            return _markService.Get().Select(m => m.ToMarkApi());
        }

        // GET: api/Mark/3
        [HttpGet("{id:int}")]
        public MarkApi Get(int id)
        {
            return _markService.Get(id).ToMarkApi();
        }

        // POST: api/Mark
        [HttpPost]
        public int Post([FromBody] MarkApi mark)
        {
            return _markService.Post(mark.ToMarkClient());
        }

        // PUT: api/Mark/5
        [HttpPut("{id:int}")]
        public bool Put(int id, [FromBody] MarkApi mark)
        {
            return _markService.Put(id, mark.ToMarkClient());
        }

        // DELETE: api/Mark/3
        [HttpDelete("{id:int}")]
        public bool Delete(int id)
        {
            return _markService.Delete(id);
        }
    }
}
