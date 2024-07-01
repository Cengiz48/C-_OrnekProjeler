using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek3_ComboBox
{
    public class Urun
    {
        //Property tanımları
        public int id { get; set; }
        public string kitapAdi { get; set; }
        public string tur { get; set; }
        public int stokAdet { get; set; }
        public string yazar { get; set; }
        public string aciklama { get; set; }
        public string pctUrunResim { get; set; }

        
        
        public override string ToString()
        {
            return kitapAdi;
        }

    }
}
