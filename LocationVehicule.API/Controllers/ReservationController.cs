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
            //Si un utilisateur est connecté, il peut reserver un vehicule. Pour cela il faut :
                    //Claim tokenClaim = User.Claims.First(c => c.Type == "Id");
                    //if (tokenClaim == null)
                    //{
                    //    return StatusCode(StatusCodes.Status401Unauthorized, "");
                    //}
                    //string Id = tokenClaim.Value;
            // - Enregistrer une agence => car l'on veut savoir à quelle agence on loue le vehicule
            //   et les infos liées à cette agence
                    //foreach (var item in collection)
                    //{
                    //    foreach (var item in collection)
                    //    {
                    //        //Details Category
                    //        //Details Disponibilities
                    //        //Details Vehicle
                    //        //Details State
                    //    }

                    //}
            // - Enregistrer une categorie => car l'utilisateur reserve une catégorie de véhicule
            // - Enregisrter une disponibilité => car l'on veut savoir les disponibilités des véhicule en
            //   fonctions des dates (depart et retour) des véhicules
            // - Enregistrer un vehicule => car l'on veut savoir le model(y compris la marque) du véhicule
            //   et aussi si le véhicule appartient à quelle agence
            // - Enregistrer un état => lorsque l'on reserve un véhicule, son état doit
            //   changer(de "en agence" à "en location")

            //Une fois que la reservation est effectuée, un contrat est établit(seulement si le client a
            //"tout payé") => ensuite une facture est générée par la suite
            return _reservationService.Post(reserv.ToReservationClient());
        }

        // PUT: api/Reservation/5
        [HttpPut("{id:int}")]
        public bool Put(int id, [FromBody] ReservationApi reserv)
        {
            return _reservationService.Put(id, reserv.ToReservationClient());
        }

        // DELETE: api/Reservation/3
        [HttpDelete("{id:int}")]
        public bool Delete(int id)
        {
            return _reservationService.Delete(id);
        }
    }
}
