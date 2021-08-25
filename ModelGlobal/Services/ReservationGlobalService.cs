using ModelGlobal.Data;
using ModelGlobal.Mapper;
using ModelGlobal.Services.Bases;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools;

namespace ModelGlobal.Services
{
    public class ReservationGlobalService : BaseService, IRepoReservation<ReservationGlobal>
    {
        public bool Delete(int id)
        {
            Command command = new Command("SP_DeleteReserv", true);
            command.AddParameter("id", id);
            return _connection.ExecuteNonQuery(command) == 1;
        }

        public IEnumerable<ReservationGlobal> Get()
        {
            Command command = new Command("SP_GetAllReserv", true);
            //chaque ligne du reader est convertie au format reservationGlobal
            return _connection.ExecuteReader(command, r => r.ToReservation());
        }

        public ReservationGlobal Get(int id)
        {
            Command command = new Command("SP_GetByIdReserv", true);
            command.AddParameter("id", id);
            //le reader me renvoi un tableau même pour une seul valeur, je lui précise qu'il ne me faut que le premier résultat
            return _connection.ExecuteReader(command, r => r.ToReservation()).SingleOrDefault();
        }

        public int Post(ReservationGlobal reservation)
        {
            Command command = new Command("SP_InsertReserv", true);

            command.AddParameter("ReservationDate", reservation.ReservationDate);
            command.AddParameter("StartDateLocation", reservation.StartDateLocation);
            command.AddParameter("EndDateLocation", reservation.EndDateLocation);
            command.AddParameter("AmountTotTVA", reservation.AmountTotTVA);
            command.AddParameter("Deposit", reservation.Deposit);
            command.AddParameter("DepositPaid", reservation.DepositPaid);
            command.AddParameter("ReservationStatus", reservation.ReservationStatus);
            command.AddParameter("ReturnAgency", reservation.ReturnAgency);
            command.AddParameter("DamageCover", reservation.DamageCover);
            command.AddParameter("RobberyCover", reservation.RobberyCover);
            command.AddParameter("AgeRange", reservation.AgeRange);
            command.AddParameter("PaidAll", reservation.PaidAll);
            command.AddParameter("IsCancelled", reservation.IsCancelled);
            command.AddParameter("UserId", reservation.UserId);
            command.AddParameter("AgencyId", reservation.AgencyId);
            command.AddParameter("CategoryId", reservation.CategoryId);
            //le output inserted.id me permet de récupérer la valeur de l'id autoincrémenter et de le renvoyer.
            return (int)_connection.ExecuteScalar(command);
        }

        public bool Put(int id, ReservationGlobal reservation)
        {
            Command command = new Command("SP_UpdateReserv", true);

            command.AddParameter("ReservationDate", reservation.ReservationDate);
            command.AddParameter("StartDateLocation", reservation.StartDateLocation);
            command.AddParameter("EndDateLocation", reservation.EndDateLocation);
            command.AddParameter("AmountTotTVA", reservation.AmountTotTVA);
            command.AddParameter("Deposit", reservation.Deposit);
            command.AddParameter("DepositPaid", reservation.DepositPaid);
            command.AddParameter("ReservationStatus", reservation.ReservationStatus);
            command.AddParameter("ReturnAgency", reservation.ReturnAgency);
            command.AddParameter("DamageCover", reservation.DamageCover);
            command.AddParameter("RobberyCover", reservation.RobberyCover);
            command.AddParameter("AgeRange", reservation.AgeRange);
            command.AddParameter("PaidAll", reservation.PaidAll);
            command.AddParameter("IsCancelled", reservation.IsCancelled);
            command.AddParameter("UserId", reservation.UserId);
            command.AddParameter("AgencyId", reservation.AgencyId);
            command.AddParameter("CategoryId", reservation.CategoryId);
            command.AddParameter("id", id);
            //quoi qu'il arrive le resultat sera le nbr de ligne modifié
            //pour renvoyer un boolean, je fais un test == 1
            //bool result = _connection.ExecuteNonQuery(command) == 1;
            //return result;

            return _connection.ExecuteNonQuery(command) == 1;
        }
    }
}
