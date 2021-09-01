using Microsoft.AspNetCore.Authorization;
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
        //private readonly IRepoUser<UserClient> _userService;
        //private readonly IRepoAgency<AgencyClient> _agencyService;
        //private readonly IRepoCategory<CategoryClient> _categoryService;
        //private readonly IRepoVehicle<VehicleClient> _vehicleService;
        //private readonly IRepoContract<ContractClient> _contractService;
        //private readonly IRepoBill<BillClient> _billService;

        public ReservationController(IRepoReservation<ReservationClient> reservationService 
            //IRepoUser<UserClient> userService, IRepoAgency<AgencyClient> agencyService, 
            //IRepoCategory<CategoryClient> categoryService, IRepoVehicle<VehicleClient> vehicleService, 
            //IRepoContract<ContractClient> contractService, IRepoBill<BillClient> billService
            )
        {
            _reservationService = reservationService;
            //_userService = userService;
            //_agencyService = agencyService;
            //_categoryService = categoryService;
            //_vehicleService = vehicleService;
            //_contractService = contractService;
            //_billService = billService;
        }


        // GET: api/Reservation
        [HttpGet]
        public IEnumerable<ReservationClient> Get()
        {
            return _reservationService.Get();
        }

        // GET: api/Reservation/3
        [HttpGet("{id:int}")]
        public ReservationClient Get(int id, bool user, bool agency, bool cat)
        {
            ReservationClient result = null;
            result = _reservationService.Get(id);
            //if (user) result.User = _userService.Get(result.UserId);
            return result;
        }

        // POST: api/Reservation
        //[Authorize]
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

        //public ReservationClient GetContract() { }
        //public ReservationClient GetBill() { }
    }
}
