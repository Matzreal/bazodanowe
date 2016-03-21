using Store.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Application
{
    public interface IClientService
    {
        IList<Client> GetAllClients();

        void CreateNewClient(Client client);
        void UpdateClient(Client client);
        void DeleteClient(Guid client);
    }
}
