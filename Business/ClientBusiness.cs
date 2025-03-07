using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Data.Model;
using Data;

namespace Business
{
    public class ClientBusiness
    {
        public Context context;
        public List<Client> GetAllClients()
        {
            using (context = new Context())
            {
                return context.Clients.ToList();
            }
        }
        public Client GetClientById(int id)
        {
            using (context = new Context())
            {
                return context.Clients.Find(id);
            }
        }
        public void AddClient(Client client)
        {
            using (context = new Context())
            {
                context.Clients.Add(client);
                context.SaveChanges();
            }
        }
        public void UpdateClient(Client client)
        {
            using (context = new Context())
            {
                var item = context.Clients.Find(client.ClientId);
                if (item != null)
                {
                    context.Entry(item).CurrentValues.SetValues(client);
                    context.SaveChanges();
                }
            }
        }
        public void DeleteClientById(int id)
        {
            using (context = new Context())
            {
                var client = context.Clients.Find(id);
                if (client != null)
                {
                    context.Clients.Remove(client);
                    context.SaveChanges();
                }
            }
        }
    }
}
