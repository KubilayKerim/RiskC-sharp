using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace riskcsharp
{
    public class ulke
    {
        public string ismi { get; set; }
        public int  asker_Adedi { get; set; }      
        public String sahip_Ismi{ get; set; }
        public oyuncu sahip{ get; set; }
        public Color Renk{ get; set; }
        public Label asker_Label{ get; set; }
        public List<ulke[]> komsular = new List<ulke[]>();
        public System.Drawing.PointF[] ulke_Koordinat { get; set; }

        public ulke(string ismi, System.Drawing.PointF[] koordinat)
        {
            this.ismi = ismi;
            ulke_Koordinat = koordinat;
        } 
        public ulke(string ulke_ismi, int[] koordinat,Label labeli,Point lkoordinat)
        {
            this.ismi = ulke_ismi;
            int i = 0;
            List<PointF> pp = new List<PointF>();
            while (i < koordinat.Length)
            {
                PointF p = new PointF(koordinat[i++], koordinat[i++]);
                pp.Add(p);
            }
            ulke_Koordinat = pp.ToArray();

            i = i + 1;
            label_ekle(labeli, lkoordinat);
        }

        public ulke()
        {


        }


        //Ulke ismi donuren metod 
        string ismi_Dondur() { return this.ismi; }

        //Ulkelerin sürekli değişim halinde olucak sahiplerini belirleyen metodumuz.
        void sahibi_belirle(oyuncu oyuncu_ismi) { 
            this.sahip_Ismi = oyuncu_ismi.ismioku();
        }

        //Ulkenin sahip ismini okuyan metodumuz.
        string sahibi_Dondur() { 
            return this.sahip_Ismi; 
        }

        void asker_Adetiyenile()
        {
            //Savas durumuna gore kaybedilen askerler hesaplanıp yazılacak ..
        }

        //Ulkenin Asker adeti. 
        int asker_Adetidondur() 
        { 
            return this.asker_Adedi;
        }

        //Ulkelerin rengi oyuncunun kazanma yada kaybetme durumuna bağlı olarak sürekli değişecek 
        public void renk_Belirle(oyuncu isim)
        { 
            this.Renk = isim.renkoku(); 
        }

        //Ulkeler arası asker tasıma islemleri buna komus ulkelerden ekleme sartı da eklenecek.
       
            void label_ekle(Label text,Point koor){
                this.asker_Label = text;
                this.asker_Label.Size = new Size(22, 15);
                this.asker_Label.Text = asker_Adedi.ToString();
                this.asker_Label.Location = koor;
                this.asker_Label.Enabled = false;
                Harita.labeller.Add(this.asker_Label);
            }
    }
}
