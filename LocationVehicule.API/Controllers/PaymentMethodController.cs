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
    public class PaymentMethodController : ControllerBase
    {
        //private PaymentMethodClientService _paymentService = new PaymentMethodClientService();
        private readonly IRepoPaymentMethod<PaymentMethodClient> _paymentService;
        public PaymentMethodController(IRepoPaymentMethod<PaymentMethodClient> paymentService)
        {
            _paymentService = paymentService;
        }

        // GET: api/PaymentMethod
        [HttpGet]
        public IEnumerable<PaymentMethodClient> Get()
        {
            return _paymentService.Get();
        }

        // GET: api/PaymentMethod/3
        [HttpGet("{id:int}")]
        public PaymentMethodClient Get(int id)
        {
            return _paymentService.Get(id);
        }

        // POST: api/PaymentMethod
        [HttpPost]
        public int Post([FromBody] PaymentMethodClient payment)
        {
            return _paymentService.Post(payment);
        }

        // PUT: api/PaymentMethod/5
        [HttpPut("{id:int}")]
        public bool Put(int id, [FromBody] PaymentMethodClient payment)
        {
            return _paymentService.Put(id, payment);
        }

        // DELETE: api/PaymentMethod/3
        [HttpDelete("{id:int}")]
        public bool Delete(int id)
        {
            return _paymentService.Delete(id);
        }
    }
}
