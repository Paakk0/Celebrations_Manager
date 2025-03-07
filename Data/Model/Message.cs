using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class Message
    {
        [Key]
        public int mId { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string message { get; set; }
    }
}
