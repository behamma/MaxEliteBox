using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxEliteBoxApplication.Models
{
    public class MeetingPerson
    {
        public int Id { get; set; }
        public int MeetingId { get; set; }
        public Meeting Meeting { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

    }
}
