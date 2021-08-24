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
        public IEnumerable<MarkClient> Get()
        {
            return _markService.Get();
        }

        // GET: api/Mark/3
        [HttpGet("{id:int}")]
        public MarkClient Get(int id)
        {
            return _markService.Get(id);
        }

        // POST: api/Mark
        [HttpPost]
        public int Post([FromBody] MarkClient mark)
        {
            return _markService.Post(mark);
        }

        // PUT: api/Mark/5
        [HttpPut("{id:int}")]
        public bool Put(int id, [FromBody] MarkClient mark)
        {
            return _markService.Put(id, mark);
        }

        // DELETE: api/Mark/3
        [HttpDelete("{id:int}")]
        public bool Delete(int id)
        {
            return _markService.Delete(id);
        }
    }
}
