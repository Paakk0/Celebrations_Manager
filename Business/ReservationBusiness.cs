using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Model;
using Data;
using System.Data.Entity;

namespace Business
{
    public class ReservationBusiness
    {
        public Context context;
        public List<Reservation> GetAllReservations()
        {
            using (context = new Context())
            {
                return context.Reservations.ToList();
            }
        }
        public Reservation GetReservationById(int id)
        {
            using (context = new Context())
            {
                return context.Reservations.Find(id);
            }
        }
        public void AddReservation(Reservation reservation)
        {
            using (context = new Context())
            {
                context.Reservations.Add(reservation);
                context.SaveChanges();
            }
        }
        public void UpdateReservation(Reservation reservation)
        {
            using (context = new Context())
            {
                var item = context.Reservations.Find(reservation.ReservationId);
                if (item != null)
                {
                    context.Entry(item).CurrentValues.SetValues(reservation);
                    context.SaveChanges();
                }
            }
        }
        public void DeleteReservationById(int id)
        {
            using (context = new Context())
            {
                var reservation = context.Reservations.Find(id);
                if (reservation != null)
                {
                    context.Reservations.Remove(reservation);
                    context.SaveChanges();
                }
            }
        }
    }
}
