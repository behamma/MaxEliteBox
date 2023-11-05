using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxEliteBoxApplication.Models
{
    public class MeetingResult
    {
        public int Id { get; set; }
        public int MeetingId { get; set; }
        public Meeting Meeting { get; set; }
        public DateTime MeetingTime { get; set; }
    }
}
