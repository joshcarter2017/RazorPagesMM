using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMM.Models
{
    public class Placement
    {
        public int ID { get; set; }
        public ClubShow ClubShow { get; set; }
        public int Place { get; set; }
        public string Category { get; set; }
    }
}
