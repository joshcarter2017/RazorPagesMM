using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMM.Models
{
    public class Rating
    {
        public int ID { get; set; }
        public ClubShow ClubShow { get; set; }
        public int StarRating { get; set; }
        public User User { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
