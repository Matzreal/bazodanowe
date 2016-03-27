using Store.Common;
using Store.Domain.Model.Client;
using Store.Domain.Repositories;

namespace Store.Infrastructure.Repositories
{
    public class ClientRepository : GenericRepository<Client>, IClientRepository
    {
    }
}
