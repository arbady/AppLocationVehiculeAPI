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
    public class BillGlobalService : BaseService, IRepoBill<BillGlobal>
    {

        public bool Delete(int id)
        {
            Command command = new Command("Delete FROM Bill WHERE Id=@Id");
            command.AddParameter("id", id);
            return _connection.ExecuteNonQuery(command) == 1;
        }

        public IEnumerable<BillGlobal> Get()
        {
            Command command = new Command("Select * FROM Bill");
            //chaque ligne du reader est convertie au format Bill
            return _connection.ExecuteReader(command, b => b.ToBill());
        }

        public BillGlobal Get(int id)
        {
            Command command = new Command("Select * FROM Bill WHERE id=@id");
            command.AddParameter("id", id);
            //le reader me renvoi un tableau même pour une seul valeur, je lui précise qu'il ne me faut que le premier résultat
            return _connection.ExecuteReader(command, b => b.ToBill()).SingleOrDefault();
        }

        public int Post(BillGlobal bill)
        {
            Command command = new Command
                ("INSERT INTO Bill (BillNum, Wording, BillDate, AmountTotHTVA, AmountTotTVA, Paid, ContractId, PaymentMethodId) " +
                "output inserted.id VALUES " +
                "(@BillNum, @Wording, @BillDate, @AmountTotHTVA, @AmountTotTVA, @Paid, @ContractId, @PaymentMethodId);");
            command.AddParameter("BillNum", bill.BillNum);
            command.AddParameter("Wording", bill.Wording);
            command.AddParameter("BillDate", bill.BillDate);
            command.AddParameter("AmountTotHTVA", bill.AmountTotHTVA);
            command.AddParameter("AmountTotTVA", bill.AmountTotTVA);
            command.AddParameter("Paid", bill.Paid);
            command.AddParameter("ContractId", bill.ContractId);
            command.AddParameter("PaymentMethodId", bill.PaymentMethodId);
            //le output inserted.id me permet de récupérer la valeur de l'id autoincrémenter et de le renvoyer.
            return (int)_connection.ExecuteScalar(command);
        }

        public bool Put(int id, BillGlobal bill)
        {
            Command command = new Command
                ("UPDATE Bill Set BillNum=@BillNum, Wording=@Wording, BillDate=@BillDate, " +
                "AmountTotHTVA=@AmountTotHTVA, AmountTotTVA=@AmountTotTVA, Paid=@Paid, ContractId=@ContractId, " +
                "PaymentMethodId=@PaymentMethodId WHERE id=@id");
            command.AddParameter("BillNum", bill.BillNum);
            command.AddParameter("Wording", bill.Wording);
            command.AddParameter("BillDate", bill.BillDate);
            command.AddParameter("AmountTotHTVA", bill.AmountTotHTVA);
            command.AddParameter("AmountTotTVA", bill.AmountTotTVA);
            command.AddParameter("Paid", bill.Paid);
            command.AddParameter("ContractId", bill.ContractId);
            command.AddParameter("PaymentMethodId", bill.PaymentMethodId);
            command.AddParameter("id", id);
            //quoi qu'il arrive le resultat sera le nbr de ligne modifié
            //pour renvoyer un boolean, je fais un test == 1
            //bool result = _connection.ExecuteNonQuery(command) == 1;
            //return result;

            return _connection.ExecuteNonQuery(command) == 1;
        }
    }
}
