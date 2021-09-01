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
    public class ModelGlobalService : BaseService, IRepoModel<ModelGlobale>
    {
        public bool Delete(int id)
        {
            Command command = new Command("SP_DeleteModel", true);
            command.AddParameter("id", id);
            return _connection.ExecuteNonQuery(command) == 1;
        }

        public IEnumerable<ModelGlobale> Get()
        {
            Command command = new Command("SP_GetAllModel", true);
            //chaque ligne du reader est convertie au format model
            return _connection.ExecuteReader(command, m => m.ToModel());
        }

        public ModelGlobale Get(int id)
        {
            Command command = new Command("SP_GetByIdModel", true);
            command.AddParameter("id", id);
            //le reader me renvoi un tableau même pour une seul valeur, je lui précise qu'il ne me faut que le premier résultat
            return _connection.ExecuteReader(command, m => m.ToModel()).SingleOrDefault();
        }

        public int Post(ModelGlobale model)
        {
            Command command = new Command("SP_InsertModel", true);

            command.AddParameter("Name", model.Name);
            command.AddParameter("MarkId", model.MarkId);
            //le output inserted.id me permet de récupérer la valeur de l'id autoincrémenter et de le renvoyer.
            return (int)_connection.ExecuteScalar(command);
        }

        public bool Put(int id, ModelGlobale model)
        {
            Command command = new Command("SP_UpdateModel", true);

            command.AddParameter("Name", model.Name);
            command.AddParameter("MarkId", model.MarkId);
            command.AddParameter("id", id);
            //quoi qu'il arrive le resultat sera le nbr de ligne modifié
            //pour renvoyer un boolean, je fais un test == 1
            //bool result = _connection.ExecuteNonQuery(command) == 1;
            //return result;

            return _connection.ExecuteNonQuery(command) == 1;
        }
    }
}
