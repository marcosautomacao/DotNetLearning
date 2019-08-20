using System;
using System.Collections.Generic;
using DotNetLearning.Models;

namespace DotNetLearning.Repositories
{
    public interface IClientRepository
    {
        IEnumerable<Client> GetClients();
        void EditCLient(Client client);
        Client GetClient(Guid id);
        void AddClient(Client client);
        void RemoveClient(Guid id);

    }

}