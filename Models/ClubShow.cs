using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMM.Models
{
    public class ClubShow
    {
        public int ID { get; set; }
        public Club Club { get; set; }
        public DateTime Year { get; set; }
        public string ShowName { get; set; }
        public string Blurb { get; set; }
        public Person[] Directors { get; set; }
        public Person[] Cast { get; set; }
        public Song[] Songs { get; set; }
        public Placement Placement { get; set; }
        public string VideoURL { get; set; }
        public string HeaderImgURL { get; set; }
        public Rating[] Ratings { get; set; }
        public bool IsLocked { get; set; }
    }
}
