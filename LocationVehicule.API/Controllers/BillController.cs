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
    public class BillController : ControllerBase
    {
        private BillClientService _billService = new BillClientService();

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
        [HttpPut]
        public bool Put(int id, [FromBody] BillApi bill)
        {
            return _billService.Put(id, bill.ToBillClient());
        }

        // DELETE: api/Bill/3
        [HttpDelete]
        public bool Delete(int id)
        {
            return _billService.Delete(id);
        }
    }
}
