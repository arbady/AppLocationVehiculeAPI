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
    public class StateGlobalService : BaseService, IRepoState<StateGlobal>
    {
        public bool Delete(int id)
        {
            Command command = new Command("SP_DeleteState", true);
            command.AddParameter("id", id);
            return _connection.ExecuteNonQuery(command) == 1;
        }

        public IEnumerable<StateGlobal> Get()
        {
            Command command = new Command("SP_GetAllState", true);
            //chaque ligne du reader est convertie au format state
            return _connection.ExecuteReader(command, s => s.ToState());
        }

        public StateGlobal Get(int id)
        {
            Command command = new Command("SP_GetByIdState", true);
            command.AddParameter("id", id);
            //le reader me renvoi un tableau même pour une seul valeur, je lui précise qu'il ne me faut que le premier résultat
            return _connection.ExecuteReader(command, s => s.ToState()).SingleOrDefault();
        }

        public int Post(StateGlobal state)
        {
            Command command = new Command("SP_InsertState", true);
            command.AddParameter("StateType", state.StateType);
            //le output inserted.id me permet de récupérer la valeur de l'id autoincrémenter et de le renvoyer.
            return (int)_connection.ExecuteScalar(command);
        }

        public bool Put(int id, StateGlobal state)
        {
            Command command = new Command("SP_UpdateState", true);

            command.AddParameter("StateType", state.StateType);
            command.AddParameter("id", id);
            //quoi qu'il arrive le resultat sera le nbr de ligne modifié
            //pour renvoyer un boolean, je fais un test == 1
            //bool result = _connection.ExecuteNonQuery(command) == 1;
            //return result;

            return _connection.ExecuteNonQuery(command) == 1;
        }
    }
}
