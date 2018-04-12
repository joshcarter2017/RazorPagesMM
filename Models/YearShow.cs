using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMM.Models
{
    public class YearShow
    {
        public int ID { get; set; }
        public ClubShow[] CLubShows { get; set; }
        public string HeaderImgURL { get; set; }
        public DateTime Year { get; set; }
        public string Title { get; set; }
        public Song[] Program { get; set; }
        public Person[] Staff { get; set; }
        public Person[] Hosts { get; set; }
        public Person[] Emcees { get; set; }
        public Person[] Showband { get; set; }
        public Person Voice { get; set; }
        public string Summary { get; set; }
        public string Dedication { get; set; }
        public Person[] Judges { get; set; }
        public bool IsLocked { get; set; }
    }
}
