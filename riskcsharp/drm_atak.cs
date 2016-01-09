using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace riskcsharp
{
    class drm_atak : Durum
    {


        public ulke atak { get; set; }
        public ulke def { get; set; }
        public int sayac;
        private drmAtak form=new drmAtak();
        private Yer_Degistirme form_yer = new Yer_Degistirme();
        public static ulke[] tutulanulke = new ulke[2];
        private Brush mybrush;
        public drm_atak(string adi)
        {
            
            Durum.durumlar.Add(this);
            this.durum_ismi = adi;
        }

        public void atak_(ulke[] tutulan, Label isimlabel, Label ustundeki_ulke, Panel panelx, Label label1)
        {
            if (sayac == 2 && Durum.sırakimde == tutulan[0].sahip && tutulan[0].asker_Adedi != 1)
            {
                if (komsu_mu(tutulan))
                {
                    if (tutulan[0].sahip != tutulan[1].sahip)
                    {
                        form.ShowDialog();
                        if (drmAtak.saldırı_kazanıldı == true)
                        {
                            toprak_kat(drm_atak.tutulanulke);
                            form_yer.ShowDialog();
                        }
                        else if (drmAtak.saldırı_kazanıldı == false)
                        {


                        }
                        else if (drmAtak.iptal_btn == true)
                        {



                        }


                    }
                    else if (tutulanulke[0].sahip == tutulanulke[1].sahip)
                    {

                        form_yer.ShowDialog();
                        if (Yer_Degistirme.tamam_btn)
                        {
                            oyuncu_Degistir(profil.oyuncular);
                            ortam_Controldegistir(Durum.sırakimde, isimlabel, ustundeki_ulke, panelx);
                            durum_degistir(Durum.durumlar, label1);
                        }
                    }
                }
            }
        }
        public bool komsu_mu(ulke[] tutulan)
        {

            foreach (ulke k in tutulan[0].komsular[0])
            {
                if (tutulan[1] == k)
                {
                    return true;
                }
            }
            return false;

        }

        public void push(ulke ulke)
        {
            if (sayac >= 2) stack_sıfır();

            tutulanulke[sayac] = ulke;
            sayac++;
        }
        void stack_sıfır()
        {
            sayac = 0;
            for (int i = 0; i < 2; i++)
            {
                tutulanulke[i] = null;
            }
        }

        void toprak_kat(ulke[] tutulan) {
            
            toprak_Ekle(tutulan[0].sahip, 1);
            toprak_Cikar(tutulan[1].sahip, 1);
            tutulan[1].sahip = tutulan[0].sahip;
           
            tutulan[0].asker_Adedi--;
            tutulan[1].asker_Adedi++;
            

            renklendir(mybrush, Games.g, tutulanulke);

        }
        void renklendir(Brush brush, System.Drawing.Graphics grap,ulke[] ulkeler)
        {

            brush = new SolidBrush(Durum.sırakimde.renkoku());
            grap.FillPolygon(brush, ulkeler[1].ulke_Koordinat);

        }
    }
}
