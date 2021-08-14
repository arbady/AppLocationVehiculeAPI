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
    public class PaymentMethodController : ControllerBase
    {
        private PaymentMethodClientService _paymentService = new PaymentMethodClientService();

        // GET: api/PaymentMethod
        [HttpGet]
        public IEnumerable<PaymentMethodApi> Get()
        {
            return _paymentService.Get().Select(p => p.ToPaymentMethodApi());
        }

        // GET: api/PaymentMethod/3
        [HttpGet("{id:int}")]
        public PaymentMethodApi Get(int id)
        {
            return _paymentService.Get(id).ToPaymentMethodApi();
        }

        // POST: api/PaymentMethod
        [HttpPost]
        public int Post([FromBody] PaymentMethodApi payment)
        {
            return _paymentService.Post(payment.ToPaymentMethodClient());
        }

        // PUT: api/PaymentMethod/5
        [HttpPut]
        public bool Put(int id, [FromBody] PaymentMethodApi payment)
        {
            return _paymentService.Put(id, payment.ToPaymentMethodClient());
        }

        // DELETE: api/PaymentMethod/3
        [HttpDelete]
        public bool Delete(int id)
        {
            return _paymentService.Delete(id);
        }
    }
}
