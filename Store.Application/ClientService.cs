using System;
using System.Collections.Generic;
using System.Linq;
using Store.Domain.Model.Client;
using Store.Domain.Repositories;

namespace Store.Application
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public void Delete(Guid id)
        {
            _clientRepository.Delete(id);
        }

        public IList<Client> GetAll()
        {
            return _clientRepository.GetAll().ToList();
        }

        public Client GetById(Guid id)
        {
            return _clientRepository.GetById(id);
        }

        public void Insert(Client obj)
        {
            _clientRepository.Insert(obj);
        }
    }
}
