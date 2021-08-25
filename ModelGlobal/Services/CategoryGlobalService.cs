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
    public class CategoryGlobalService : BaseService, IRepoCategory<CategoryGlobal>
    {
        public bool Delete(int id)
        {
            Command command = new Command("SP_DeleteCategory", true);
            command.AddParameter("id", id);
            return _connection.ExecuteNonQuery(command) == 1;
        }

        public IEnumerable<CategoryGlobal> Get()
        {
            Command command = new Command("SP_GetAllCategory", true);
            //chaque ligne du reader est convertie au format Category
            return _connection.ExecuteReader(command, c => c.ToCategory());
        }

        public CategoryGlobal Get(int id)
        {
            Command command = new Command("SP_GetByIdCategory", true);
            command.AddParameter("id", id);
            //le reader me renvoi un tableau même pour une seul valeur, je lui précise qu'il ne me faut que le premier résultat
            return _connection.ExecuteReader(command, c => c.ToCategory()).SingleOrDefault();
        }

        public int Post(CategoryGlobal category)
        {
            Command command = new Command("SP_InsertCategory", true);

            command.AddParameter("TypeCat", category.TypeCat);
            command.AddParameter("CostPerDay", category.CostPerDay);
            //le output inserted.id me permet de récupérer la valeur de l'id autoincrémenter et de le renvoyer.
            return (int)_connection.ExecuteScalar(command);
        }

        public bool Put(int id, CategoryGlobal category)
        {
            Command command = new Command("SP_UpdateCategory", true);

            command.AddParameter("TypeCat", category.TypeCat);
            command.AddParameter("CostPerDay", category.CostPerDay);
            command.AddParameter("id", id);
            //quoi qu'il arrive le resultat sera le nbr de ligne modifié
            //pour renvoyer un boolean, je fais un test == 1
            //bool result = _connection.ExecuteNonQuery(command) == 1;
            //return result;

            return _connection.ExecuteNonQuery(command) == 1;
        }
    }
}
