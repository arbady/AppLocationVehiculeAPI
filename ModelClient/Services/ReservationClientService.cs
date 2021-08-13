using ModelClient.Data;
using ModelClient.Mapper;
using ModelGlobal.Data;
using ModelGlobal.Services;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClient.Services
{
    public class ReservationClientService : IRepoReservation<ReservationClient>
    {
        private IRepoReservation<ReservationGlobal> _reservGlobalService;

        public ReservationClientService()
        {
            _reservGlobalService = new ReservationGlobalService();
        }

        public bool Delete(int id)
        {
            return _reservGlobalService.Delete(id);
        }

        public IEnumerable<ReservationClient> Get()
        {
            return _reservGlobalService.Get().Select(r => r.ToReservationClient());
        }

        public ReservationClient Get(int id)
        {
            return _reservGlobalService.Get(id)?.ToReservationClient();
        }

        public int Post(ReservationClient reservation)
        {
            return _reservGlobalService.Post(reservation.ToReservationGlobal());
        }

        public bool Put(int id, ReservationClient reservation)
        {
            return _reservGlobalService.Put(id, reservation.ToReservationGlobal());
        }
    }
}
