﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemIO_WinForm
{
    public class Personel
    {
        public int id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string emailAdres { get; set; }
        public string firmaAdi { get; set; }
        public string ulke { get; set; }


        public override string ToString()
        {
            return this.isim + this.soyisim;
        }

    }


}
