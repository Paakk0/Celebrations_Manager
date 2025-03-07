using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Data.Model;

namespace Data
{
    public class Context : DbContext
    {
        public Context() : base("name=Context") { }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<CelebrationType> CelebrationTypes { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}
