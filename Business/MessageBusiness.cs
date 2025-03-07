using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Model;
using Data;

namespace Business
{
    public class MessageBusiness
    {
        public Context context;
        public List<Message> GetAllMessages()
        {
            using (context = new Context())
            {
                return context.Messages.ToList();
            }
        }
        public Message GetMessageById(int id)
        {
            using (context = new Context())
            {
                return context.Messages.Find(id);
            }
        }
        public void AddMessage(Message message)
        {
            using (context = new Context())
            {
                context.Messages.Add(message);
                context.SaveChanges();
            }
        }
        public void UpdateMessage(Message message)
        {
            using (context = new Context())
            {
                var item = context.Messages.Find(message.mId);
                if (item != null)
                {
                    context.Entry(item).CurrentValues.SetValues(message);
                    context.SaveChanges();
                }
            }
        }
        public void DeleteMessage(int id)
        {
            using (context = new Context())
            {
                var message = context.Messages.Find(id);
                if (message != null)
                {
                    context.Messages.Remove(message);
                    context.SaveChanges();
                }
            }
        }
    }
}
