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
    public class PaymentMethodGlobalService : BaseService, IRepoPaymentMethod<PaymentMethodGlobal>
    {
        public bool Delete(int id)
        {
            Command command = new Command("SP_DeletePayment", true);
            command.AddParameter("id", id);
            return _connection.ExecuteNonQuery(command) == 1;
        }

        public IEnumerable<PaymentMethodGlobal> Get()
        {
            Command command = new Command("SP_GetAllPayment", true);
            //chaque ligne du reader est convertie au format PaymentMethodGlobal
            return _connection.ExecuteReader(command, p => p.ToPaymentMethod());
        }

        public PaymentMethodGlobal Get(int id)
        {
            Command command = new Command("SP_GetByIdPayment", true);
            command.AddParameter("id", id);
            //le reader me renvoi un tableau même pour une seul valeur, je lui précise qu'il ne me faut que le premier résultat
            return _connection.ExecuteReader(command, p => p.ToPaymentMethod()).SingleOrDefault();
        }

        public int Post(PaymentMethodGlobal paymentMethod)
        {
            Command command = new Command("SP_InsertPayment", true);

            command.AddParameter("Method", paymentMethod.Method);
            //le output inserted.id me permet de récupérer la valeur de l'id autoincrémenter et de le renvoyer.
            return (int)_connection.ExecuteScalar(command);
        }

        public bool Put(int id, PaymentMethodGlobal paymentMethod)
        {
            Command command = new Command("SP_UpdatePayment", true);

            command.AddParameter("Method", paymentMethod.Method);
            command.AddParameter("id", id);
            //quoi qu'il arrive le resultat sera le nbr de ligne modifié
            //pour renvoyer un boolean, je fais un test == 1
            //bool result = _connection.ExecuteNonQuery(command) == 1;
            //return result;

            return _connection.ExecuteNonQuery(command) == 1;
        }
    }
}
