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
        public IEnumerable<BillApi> Get()
        {
            return _billService.Get().Select(b => b.ToBillApi());
        }

        // GET: api/Bill/3
        [HttpGet("{id:int}")]
        public BillApi Get(int id)
        {
            return _billService.Get(id).ToBillApi();
        }

        // POST: api/Bill
        [HttpPost]
        public int Post([FromBody] BillApi bill)
        {
            return _billService.Post(bill.ToBillClient());
        }

        // PUT: api/Agency/5
        [HttpPut("{id:int}")]
        public bool Put(int id, [FromBody] BillApi bill)
        {
            return _billService.Put(id, bill.ToBillClient());
        }

        // DELETE: api/Bill/3
        [HttpDelete("{id:int}")]
        public bool Delete(int id)
        {
            return _billService.Delete(id);
        }
    }
}
