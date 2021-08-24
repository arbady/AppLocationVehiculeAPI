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
    public class BillController : ControllerBase
    {
        //private BillClientService _billService = new BillClientService();
        private readonly IRepoBill<BillClient> _billService;
        public BillController(IRepoBill<BillClient> billService)
        {
            _billService = billService;
        }


        // GET: api/Bill
        [HttpGet]
        public IEnumerable<BillClient> Get()
        {
            return _billService.Get();
        }

        // GET: api/Bill/3
        [HttpGet("{id:int}")]
        public BillClient Get(int id)
        {
            return _billService.Get(id);
        }

        // POST: api/Bill
        [HttpPost]
        public int Post([FromBody] BillClient bill)
        {
            return _billService.Post(bill);
        }

        // PUT: api/Agency/5
        [HttpPut("{id:int}")]
        public bool Put(int id, [FromBody] BillClient bill)
        {
            return _billService.Put(id, bill);
        }

        // DELETE: api/Bill/3
        [HttpDelete("{id:int}")]
        public bool Delete(int id)
        {
            return _billService.Delete(id);
        }
    }
}
