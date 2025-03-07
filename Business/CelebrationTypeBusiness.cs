using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Model;
using Data;

namespace Business
{
    public class CelebrationTypeBusiness
    {
        public Context context;
        public List<CelebrationType> GetAllTypes()
        {
            using (context = new Context())
            {
                return context.CelebrationTypes.ToList();
            }
        }
        public void AddType(CelebrationType type)
        {
            using (context = new Context())
            {
                context.CelebrationTypes.Add(type);
                context.SaveChanges();
            }
        }
        public void DeleteType(int id)
        {
            using (context = new Context())
            {
                var type = context.CelebrationTypes.Find(id);
                if (type != null)
                {
                    context.CelebrationTypes.Remove(type);
                    context.SaveChanges();
                }
            }
        }
    }
}
