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
    public class LicenceGlobalService : BaseService, IRepoLicence<LicenceGlobal>
    {
        public bool Delete(int id)
        {
            Command command = new Command("Delete FROM Licence WHERE Id=@Id");
            command.AddParameter("id", id);
            return _connection.ExecuteNonQuery(command) == 1;
        }

        public IEnumerable<LicenceGlobal> Get()
        {
            Command command = new Command("Select * FROM Licence");
            //chaque ligne du reader est convertie au format Licence
            return _connection.ExecuteReader(command, l => l.ToLicence());
        }

        public LicenceGlobal Get(int id)
        {
            Command command = new Command("Select * FROM Licence WHERE id=@id");
            command.AddParameter("id", id);
            //le reader me renvoi un tableau même pour une seul valeur, je lui précise qu'il ne me faut que le premier résultat
            return _connection.ExecuteReader(command, l => l.ToLicence()).SingleOrDefault();
        }

        public int Post(LicenceGlobal licence)
        {
            Command command = new Command
                ("INSERT INTO Licence (LicenceCat, [Description]) " +
                "output inserted.id VALUES (@LicenceCat, @Description);");

            command.AddParameter("LicenceCat", licence.LicenceCat);
            command.AddParameter("Description", licence.Description);
            //le output inserted.id me permet de récupérer la valeur de l'id autoincrémenter et de le renvoyer.
            return (int)_connection.ExecuteScalar(command);
        }

        public bool Put(int id, LicenceGlobal licence)
        {
            Command command = new Command
                ("UPDATE Licence Set LicenceCat=@LicenceCat, [Description]=@Description WHERE id=@id");

            command.AddParameter("LicenceCat", licence.LicenceCat);
            command.AddParameter("Description", licence.Description);
            command.AddParameter("id", id);
            //quoi qu'il arrive le resultat sera le nbr de ligne modifié
            //pour renvoyer un boolean, je fais un test == 1
            //bool result = _connection.ExecuteNonQuery(command) == 1;
            //return result;

            return _connection.ExecuteNonQuery(command) == 1;
        }
    }
}
