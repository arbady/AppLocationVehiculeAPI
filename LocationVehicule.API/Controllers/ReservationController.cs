using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelClient.Data;
using ModelClient.Services;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace LocationVehicule.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        //private ReservationClientService _reservationService = new ReservationClientService();
        private readonly IRepoReservation<ReservationClient> _reservationService;
        public ReservationController(IRepoReservation<ReservationClient> reservationService)
        {
            _reservationService = reservationService;
        }

        // GET: api/Reservation
        [HttpGet]
        public IEnumerable<ReservationClient> Get()
        {
            return _reservationService.Get();
        }

        // GET: api/Reservation/3
        [HttpGet("{id:int}")]
        public ReservationClient Get(int id)
        {
            return _reservationService.Get(id);
        }

        // POST: api/Reservation
        [HttpPost]
        public int Post([FromBody] ReservationClient reserv)
        {
            return _reservationService.Post(reserv);
        }

        // PUT: api/Reservation/5
        [HttpPut("{id:int}")]
        public bool Put(int id, [FromBody] ReservationClient reserv)
        {
            return _reservationService.Put(id, reserv);
        }

        // DELETE: api/Reservation/3
        [HttpDelete("{id:int}")]
        public bool Delete(int id)
        {
            return _reservationService.Delete(id);
        }
    }
}
