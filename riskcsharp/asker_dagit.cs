using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace riskcsharp
{
    class asker_dagit : Durum
    {
        public double ne_kadar { get; set; }
        private bool tekrar;
        private bool tekrar2;
        private byte indexx;
        private byte tut = 0;
        public asker_dagit(string ismi)
        {
            Durum.durumlar.Add(this);
            durum_ismi = ismi;

        }

        public double askerdagitim_hesap(oyuncu ulke_sayisi)
        {
            if (ulke_sayisi.Ulke_sayisi > 3)
            {
                return Math.Ceiling(Convert.ToDouble(ulke_sayisi.Ulke_sayisi) / 3);
            }
            else
            {
                return 3;
            }
        }
        public void askerdagitim_islem(ulke secilen_ulke, oyuncu oyunncu, Label label,Label secilen_ulkee, Panel panel,Label label1,Label label2)
        {
            label2.Text = 18 + " adet askeri yerlestir";
            if (tekrar == false)
            {
                
                indexx = 0;
                ne_kadar = 18;
                tekrar = true;
            }

            if (secilen_ulke.sahip == Durum.sırakimde)
            {
                indexx++;
                label2.Text = (19 - indexx).ToString();
                secilen_ulke.asker_Adedi += 1;
                secilen_ulke.asker_Label.Text = (int.Parse(secilen_ulke.asker_Label.Text) + 1).ToString();

               
                if (indexx > (int)ne_kadar)
                {
                    tut++;
                    if (tut == 1 )
                    {
                        tekrar = false;
                    }
                oyuncu_Degistir(profil.oyuncular);
                ortam_Controldegistir(Durum.sırakimde, label,secilen_ulkee, panel);
                    if (tut == 2)
                    {
                        durum_degistir(Durum.durumlar, label1);
                    }
                }
            }
            else
            {

            }
        }
        public void askerdagitim_2(ulke secilen_ulke, oyuncu oyunncu,Label label1,Label label2)
        {
            label2.Text = (int)askerdagitim_hesap(oyunncu) + " adet bonus askeri yerlestir..";
            if (tekrar2 ==false)
            {
                oyunncu.bonus_asker = (int)askerdagitim_hesap(oyunncu);
                tekrar2 = true;
            }
            if (secilen_ulke.sahip == Durum.sırakimde)
            {
                oyunncu.bonus_asker--;
                label2.Text = oyunncu.bonus_asker + " bonus asker kaldı ...";
                secilen_ulke.asker_Adedi += 1;
                secilen_ulke.asker_Label.Text = (int.Parse(secilen_ulke.asker_Label.Text) + 1).ToString();
                if (oyunncu.bonus_asker == 0)
                {

                        tekrar2 = false; 
                        durum_degistir(Durum.durumlar, label1);
                    
                }
            }
        }
    }
}

