using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeProje
{
    public class Musteri
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string age { get; set; }
        public long phoneNumber { get; set; }
        public string emailAddress { get; set; }

        public override string ToString()
        {
            return "("+id+") "+ name+" "+surname; // ListBox'ta sadece adını göstermek için
        }
    }

}
    

    


