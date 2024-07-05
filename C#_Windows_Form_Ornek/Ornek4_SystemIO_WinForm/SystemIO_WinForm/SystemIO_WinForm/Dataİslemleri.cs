using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemIO_WinForm
{
    public class Dataİslemleri
    {

        public Dataİslemleri()
        {
            
        }


        
        public List<Personel> personelGetir(int adet)
        {
            List<Personel> personelListe = new List<Personel>();
            int id = 0;
            for (int i = 0; i < adet; i++)
            {
                Personel personel = new Personel();
                personel.id = id++;
                personel.isim=FakeData.NameData.GetFirstName();
                personel.soyisim=FakeData.NameData.GetSurname();
                personel.firmaAdi = FakeData.NetworkData.GetDomain();
                personel.emailAdres = personel.isim + "." + personel.soyisim+"@"+personel.firmaAdi;
                personel.ulke = FakeData.PlaceData.GetCounty();
                personelListe.Add(personel);

            }
            return personelListe;

        }
        
        

    
    }
}
