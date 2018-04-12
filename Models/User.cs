using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMM.Models
{
    public class User
    {
        public int ID { get; set; }
        public Person Person { get; set; }
        public string Name { get; set; }
    }
}
