using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace riskcsharp
{
    public class oyuncu
    {
        private string ismi;
        private Color renk;
        private int Asker_Sayisi;

        public bool Kazandı_Mı;
        public bool Savas_Durum { get; set; }
        public int bonus_asker = 21;
        public int Ulke_sayisi { get; set; }
        public  List<int> zarlar=new List<int>(2);

        //Yapıcı fonksiyonlar
        public oyuncu() { }
        public oyuncu(String İsim, Color renk)
        {
            this.ismi = İsim;
            this.renk = renk;
        }

        //Oyuncu isim yazma ve okuma işlemi için...
        public void isimver(string isim)
        {

            this.ismi = isim;
        }
        public string ismioku()
        {

            return this.ismi;
        }

        //Oyuncu Renk yazma ve okuma işlemi için... 
        public void renkal(Color renk)
        {
            this.renk = renk;
        }
        public Color renkoku() { return this.renk; }
        //Asker sayısı okuma
        public int askrsayı_oku() {
            return this.Asker_Sayisi; 
        }
        public void askrsayı_al(int askr_sayı) {
            this.Asker_Sayisi = askr_sayı;
        }
        //Oyuncunun savaş kazanma yada kaybetme durumu ve oyunu bitirme durumu
        public bool savas_Durum() { return false;
        
        }
        public bool oyun_Durum() { return false; 
        
        }

 
        //Kazanılan veya Kaybedilen topraklar için yapılacak işlemler
    }
}
