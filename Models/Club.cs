using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMM.Models
{
    public class Club
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string GreekLetters { get; set; }
        public string PrimaryColor { get; set; }
        public string SecondaryColor { get; set; }
        public string Mascot { get; set; }
        public string HeaderImgURL { get; set; }
        public DateTime DateEstablished { get; set; }
        public DateTime DateRetired { get; set; }
    }
}
