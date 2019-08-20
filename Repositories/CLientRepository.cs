using System;
using System.Collections.Generic;
using System.Linq;
using DotNetLearning.Models;

namespace DotNetLearning.Repositories
{
    public class ClientRepository : IClientRepository
    {
        public readonly List<Client> _storage;

        public ClientRepository()
        {
            _storage = new List<Client>();
        }

        public void AddClient(Client client)
        {
            _storage.Add(client);
        }

        public void EditCLient(Client client)
        {
            var index = _storage.FindIndex(0,1, x => x.userId == client.userId);
            _storage[index] = client;
        }

        public Client GetClient(Guid id)
        {
            return _storage.FirstOrDefault(x => x.userId == id);
        }

        public IEnumerable<Client> GetClients()
        {
            return _storage;
        }

        public void RemoveClient(Guid id)
        {
             var index = _storage.FindIndex(0,1, x => x.userId == id);
            _storage.Remove(_storage[index]);
        }
    }
}