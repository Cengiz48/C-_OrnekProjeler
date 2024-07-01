using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek3_ComboBox
{
    public static class SanalDatabase
    {
        public static List<Urun> urunListe = new List<Urun>()
        {
            new Urun()
            {
                id = 1,
                pctUrunResim=Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "KitapResimleri", "sefiller.jpg"),
                kitapAdi="Sefiller",
                tur="Roman,Trajedi",
                stokAdet=23,
                yazar="Victor Hugo",
                aciklama="Sefiller, Victor Hugo tarafından yazılan tarihi romandır. İlk olarak 1862'de yayınlandı. 19. yüzyılın en büyük eserlerinden biri olarak kabul gördü. İngilizce konuşulan ülkelerde başarısız çeviriler nedeniyle genellikle orijinal Fransız ismiyle anılır.",

            },

            new Urun()
            {
                id = 2,
                pctUrunResim = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "KitapResimleri", "romeovejuliet.jfif"),
                kitapAdi = "Romeo ve Juliet",
                tur = "Trajedi",
                stokAdet = 12,
                yazar = "William Shakespeare",
                aciklama = "Romeo ve Juliet, İngiliz oyun yazarı William Shakespeare tarafından yazılmış bir oyundur. İngiliz edebiyatının klasiklerinden biri olan eser, yazarın en iyi bilinen oyunlarından birisidir. 1591-1596 arasında yazıldığı düşünülür.",

            },
              new Urun()
            {
                id = 3,
                pctUrunResim = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "KitapResimleri", "vadidekizambak.jpg"),
                kitapAdi = "Vadideki Zambak",
                tur = "Kurgu",
                stokAdet = 5,
                yazar = "Balzac",
                aciklama = "Vadideki Zambak, Fransız yazar Honoré de Balzac'ın romanıdır. 1835'te yayımlanan ve yazarın en bilinen kitaplarından biri olan roman, Balzac'ın İnsanlık Komedyası'nın Taşra Yaşamından Sahneler bölümünde yer almaktadır.",

            },
             new Urun()
             { 
                id = 4,
                pctUrunResim = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "KitapResimleri", "sucveceza.jfif"),
                kitapAdi = "Suç ve Ceza",
                tur = "Polisiye,Psikolojik",
                stokAdet = 9,
                yazar = "Dostoyevski",
                aciklama="Suç ve Ceza, Rus yazar Fyodor Dostoyevski tarafından yazılan psikolojik ve dram türündeki romandır. İlk olarak 1866 yılı boyunca Rus Habercisi adlı edebiyat dergisinde on iki ayda yayımlandı. Daha sonra ise tek cilt olarak yayımlandı.",
            }



        };

    }    
}


