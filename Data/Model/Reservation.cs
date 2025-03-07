using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int cId { get; set; }
        public string CelebrationType { get; set; }
        public string CelebrationDate { get; set; }
        public string TimeOfStart { get; set; }
        public string TimeOfEnd { get; set; }
        public string details { get; set; }
    }
}
