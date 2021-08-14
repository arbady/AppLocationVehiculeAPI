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
    public class ReservationController : ControllerBase
    {
        private ReservationClientService _reservationService = new ReservationClientService();

        // GET: api/Reservation
        [HttpGet]
        public IEnumerable<ReservationApi> Get()
        {
            return _reservationService.Get().Select(r => r.ToReservationApi());
        }

        // GET: api/Reservation/3
        [HttpGet("{id:int}")]
        public ReservationApi Get(int id)
        {
            return _reservationService.Get(id).ToReservationApi();
        }

        // POST: api/Reservation
        [HttpPost]
        public int Post([FromBody] ReservationApi reserv)
        {
            return _reservationService.Post(reserv.ToReservationClient());
        }

        // PUT: api/Reservation/5
        [HttpPut]
        public bool Put(int id, [FromBody] ReservationApi reserv)
        {
            return _reservationService.Put(id, reserv.ToReservationClient());
        }

        // DELETE: api/Reservation/3
        [HttpDelete]
        public bool Delete(int id)
        {
            return _reservationService.Delete(id);
        }
    }
}
