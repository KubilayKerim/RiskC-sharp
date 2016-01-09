using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace riskcsharp
{
    class Durum
    {
        public string durum_ismi { get; set; }
        public static oyuncu sırakimde { get; set; }
        public static Durum anlık_durum { get; set; }
        private System.Drawing.Color Color;
        private string oyuncu_ismi;
        private int index = 0;
        public static int dr_index = 0;

        public static List<Durum> durumlar=new List<Durum>();

        public Durum()
        {
            sırakimde = profil.oyuncular[0];
        }
        public Durum(Durum durum1)
        {
            anlık_durum=durumlar[0];
            durumlar.Add(durum1); 
        } 

        public void durum_degistir(List<Durum> durumlar,Label label1) {
            int k = durumlar.Count -1;

            if (dr_index < k)
            {
                dr_index++;
                anlık_durum = durumlar[dr_index];
            }
            else
            {
                dr_index = 2;
                anlık_durum = durumlar[dr_index];
            }
             label1.Text=durumlar[dr_index].durum_ismi;

        }
        public void oyuncu_Degistir(List<oyuncu> oyuncular)
        {
            int k = oyuncular.Count - 1;

            if (index < k)
            {
                ++index;
                sırakimde = oyuncular[index];
            }
            else
            {
                index = 0;
                sırakimde = oyuncular[index];
            }
        }
        private void durum_renkdegistir(oyuncu sırakimde)
        {
            this.Color = sırakimde.renkoku();
            this.oyuncu_ismi = sırakimde.ismioku();

        }
        public void ortam_Controldegistir(oyuncu sırakimde, Label isimlabel,Label ustundeki_ulke, Panel panelX)
        {
            // this.Color = sırakimde.renk;
            
            this.oyuncu_ismi = sırakimde.ismioku();
            isimlabel.Text = this.oyuncu_ismi;
            panelX.BackColor = sırakimde.renkoku();
            ustundeki_ulke.ForeColor = sırakimde.renkoku();
        }
        protected void toprak_Ekle(oyuncu oyunncu,int adet)
        { 
            oyunncu.Ulke_sayisi=oyunncu.Ulke_sayisi+adet;  
        }
        protected void toprak_Cikar(oyuncu oyunncu,int adet)
        {
          oyunncu.Ulke_sayisi=oyunncu.Ulke_sayisi - adet;
        }
        //Oyuncuya verilecek ekstra askerler için
        public static void asker_Ver(oyuncu oyunncu,int ne_kadar)
        {
            oyunncu.askrsayı_al(oyunncu.askrsayı_oku() + ne_kadar);
        }
        public void durum_yaz(Label lablldurum ) {
  
            lablldurum.Text = anlık_durum.durum_ismi;
        }
        
    }
}
