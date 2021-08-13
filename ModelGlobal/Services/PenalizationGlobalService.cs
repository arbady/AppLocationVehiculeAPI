using ModelGlobal.Data;
using ModelGlobal.Mapper;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools;

namespace ModelGlobal.Services
{
    public class PenalizationGlobalService : BaseService, IRepoPenalization<PenalizationGlobal>
    {
        public bool Delete(int id)
        {
            Command command = new Command("Delete FROM Penalization WHERE Id=@Id");
            command.AddParameter("id", id);
            return _connection.ExecuteNonQuery(command) == 1;
        }

        public IEnumerable<PenalizationGlobal> Get()
        {
            Command command = new Command("Select * FROM Penalization");
            //chaque ligne du reader est convertie au format PenalizationGlobal
            return _connection.ExecuteReader(command, p => p.ToPenalization());
        }

        public PenalizationGlobal Get(int id)
        {
            Command command = new Command("Select * FROM Penalization WHERE id=@id");
            command.AddParameter("id", id);
            //le reader me renvoi un tableau même pour une seul valeur, je lui précise qu'il ne me faut que le premier résultat
            return _connection.ExecuteReader(command, p => p.ToPenalization()).SingleOrDefault();
        }

        public int Post(PenalizationGlobal penalization)
        {
            Command command = new Command
                ("INSERT INTO Penalization (PenalDate, AmountOwed, AmountPaid) output inserted.id VALUES " +
                "(@PenalDate, @AmountOwed, @AmountPaid);");

            command.AddParameter("PenalDate", penalization.PenalDate);
            command.AddParameter("AmountOwed", penalization.AmountOwed);
            command.AddParameter("AmountPaid", penalization.AmountPaid);
            //le output inserted.id me permet de récupérer la valeur de l'id autoincrémenter et de le renvoyer.
            return (int)_connection.ExecuteScalar(command);
        }

        public bool Put(int id, PenalizationGlobal penalization)
        {
            Command command = new Command
                ("UPDATE Penalization Set PenalDate=@PenalDate, AmountOwed=@AmountOwed, " +
                "AmountPaid=@AmountPaid WHERE id=@id");

            command.AddParameter("PenalDate", penalization.PenalDate);
            command.AddParameter("AmountOwed", penalization.AmountOwed);
            command.AddParameter("AmountPaid", penalization.AmountPaid);
            command.AddParameter("id", id);
            //quoi qu'il arrive le resultat sera le nbr de ligne modifié
            //pour renvoyer un boolean, je fais un test == 1
            //bool result = _connection.ExecuteNonQuery(command) == 1;
            //return result;

            return _connection.ExecuteNonQuery(command) == 1;
        }
    }
}
