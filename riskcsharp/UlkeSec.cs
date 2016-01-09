using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace riskcsharp
{
    class UlkeSec : Durum
    {
        Brush mybrush;
        public UlkeSec(List<oyuncu> oyuncular, string ismi)
        {
            Durum.anlık_durum = this;

            Durum.durumlar.Add(this);
            for (int i = 0; i < oyuncular.Count; i++)
            {
                durum_ismi = ismi;
                oyuncular[i].bonus_asker = Durum.sırakimde.bonus_asker;
            }
        }
        public void kalan_bonus(Label labell)
        {
            labell.Text = Durum.sırakimde.bonus_asker + " adet seçme hakkın kaldı ..  ";
        }
        public void asker_dagit(int adet, ulke ulkelabell)
        {
            if (Durum.sırakimde.bonus_asker > 0 && ulkelabell.sahip == null)
            {
                ulkelabell.sahip = Durum.sırakimde;
                Durum.sırakimde.bonus_asker--;

                ulkelabell.asker_Label.Text = ((int.Parse(ulkelabell.asker_Label.Text) + 1).ToString());
                ulkelabell.asker_Adedi += 1;
                ulkelabell.sahip = Durum.sırakimde;
            }
        }
        public void renk_fill(System.Drawing.Graphics grap, System.Drawing.Point p, ulke ulkelabel, Label label, Panel panel, Label labell,Label secilen_ulke, List<ulke> ulkeler, Button buton1, int adet)
        {
            if (ulkelabel.sahip == null)
            {
                riskcsharp.ulke c = Games.haritaolustur.getCityAtPoint(p);
                if (c == null) return;
                mybrush = new SolidBrush(Durum.sırakimde.renkoku());
                grap.FillPolygon(mybrush, c.ulke_Koordinat);
                kalan_bonus(labell);

                toprak_Ekle(Durum.sırakimde, 1);
                asker_Ver(Durum.sırakimde, 1);

                asker_dagit(adet, ulkelabel);

                oyuncu_Degistir(profil.oyuncular);
                ortam_Controldegistir(Durum.sırakimde, label,secilen_ulke, panel);

            }

            int i = 0;
            foreach (ulke k in ulkeler)
            {
                if (k.sahip != null)
                {
                    i++;
                }
            }
            if (i == ulkeler.Count)
            {
                buton1.Enabled = true;
            }
            else
            {
                buton1.Enabled = false;
            }
        }
    }
}

