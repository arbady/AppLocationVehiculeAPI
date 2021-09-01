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
    public class MarkGlobalService : BaseService, IRepoMark<MarkGlobal>
    {
        public bool Delete(int id)
        {
            Command command = new Command("SP_DeleteMark", true);
            command.AddParameter("id", id);
            return _connection.ExecuteNonQuery(command) == 1;
        }

        public IEnumerable<MarkGlobal> Get()
        {
            Command command = new Command("SP_GetAllMark", true);
            //chaque ligne du reader est convertie au format MarkGlobal
            return _connection.ExecuteReader(command, m => m.ToMark());
        }

        public MarkGlobal Get(int id)
        {
            Command command = new Command("SP_GetByIdMark", true);
            command.AddParameter("id", id);
            //le reader me renvoi un tableau même pour une seul valeur, je lui précise qu'il ne me faut que le premier résultat
            return _connection.ExecuteReader(command, m => m.ToMark()).SingleOrDefault();
        }

        public int Post(MarkGlobal mark)
        {
            Command command = new Command("SP_InsertMark", true);

            command.AddParameter("Name", mark.Name);
            //le output inserted.id me permet de récupérer la valeur de l'id autoincrémenter et de le renvoyer.
            return (int)_connection.ExecuteScalar(command);
        }

        public bool Put(int id, MarkGlobal mark)
        {
            Command command = new Command("SP_UpdateMark", true);

            command.AddParameter("Name", mark.Name);
            command.AddParameter("id", id);
            //quoi qu'il arrive le resultat sera le nbr de ligne modifié
            //pour renvoyer un boolean, je fais un test == 1
            //bool result = _connection.ExecuteNonQuery(command) == 1;
            //return result;

            return _connection.ExecuteNonQuery(command) == 1;
        }
    }
}
