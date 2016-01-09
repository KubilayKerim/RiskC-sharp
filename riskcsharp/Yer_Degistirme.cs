using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;
namespace riskcsharp
{
    public partial class Yer_Degistirme : Form
    {
        public Yer_Degistirme()
        {
            InitializeComponent();
        }
        public static bool tamam_btn { get; set; }

        private void  Yer_Degistirme_Load(object sender, EventArgs e)
        {
            control_renklendir(ulkerec1, ulkerec2, Atak_Ulkeisim, Atak_AskerSayisi, Def_Ulkeisim, Def_AskerSayisi);
        }
        private void control_renklendir(RectangleShape atak_Rec, RectangleShape def_rec, Label atak_Ismi, Label atak_Asker, Label Def_Ismi, Label Def_Asker)
        {

            atak_Rec.FillColor = drm_atak.tutulanulke[0].sahip.renkoku();
            atak_Ismi.Text = drm_atak.tutulanulke[0].ismi;
            atak_Asker.Text = drm_atak.tutulanulke[0].asker_Adedi.ToString();
            // 
            def_rec.FillColor = drm_atak.tutulanulke[1].sahip.renkoku();
            Def_Ismi.Text = drm_atak.tutulanulke[1].ismi;
            Def_Asker.Text = drm_atak.tutulanulke[1].asker_Adedi.ToString();

        }


        private void asker_TasimaIs(ulke[] tutulanulke, int adet,bool i)
        {

            if ( i==true && tutulanulke[0].asker_Adedi > adet  )
            {
                tutulanulke[0].asker_Adedi -= adet;
                tutulanulke[1].asker_Adedi += adet;
                //Ulkemizden tsınacak asker adeti çıkarılıp trasfer yapılacak ulkeye eklendi...
            }
            else if (i==false && tutulanulke[1].asker_Adedi >adet  )
            {
                tutulanulke[1].asker_Adedi -= adet;
                tutulanulke[0].asker_Adedi += adet;
                //**Hatalı islem uyarı mesajı verilecek

            }
        }

        private void ulke2_1_Click(object sender, EventArgs e)
        {
            asker_TasimaIs(drm_atak.tutulanulke, 1,true);
            label_yenile(drm_atak.tutulanulke, Atak_AskerSayisi, Def_AskerSayisi);
        }

        private void ulke2_10_Click(object sender, EventArgs e)
        {
            asker_TasimaIs(drm_atak.tutulanulke, 10, true);
            label_yenile(drm_atak.tutulanulke, Atak_AskerSayisi, Def_AskerSayisi);

        }

        private void ulke2_25_Click(object sender, EventArgs e)
        {
            asker_TasimaIs(drm_atak.tutulanulke, 25, true);
            label_yenile(drm_atak.tutulanulke, Atak_AskerSayisi, Def_AskerSayisi);

        }

        private void ulke1_1_Click(object sender, EventArgs e)
        {
            asker_TasimaIs(drm_atak.tutulanulke, 1, false);
            label_yenile(drm_atak.tutulanulke, Atak_AskerSayisi, Def_AskerSayisi);

        }

        private void ulke1_10_Click(object sender, EventArgs e)
        {
            asker_TasimaIs(drm_atak.tutulanulke, 10, false);
            label_yenile(drm_atak.tutulanulke, Atak_AskerSayisi, Def_AskerSayisi);

        }

        private void ulke1_25_Click(object sender, EventArgs e)
        {
            asker_TasimaIs(drm_atak.tutulanulke, 25, false);
            label_yenile(drm_atak.tutulanulke, Atak_AskerSayisi, Def_AskerSayisi);


        }

        private void label_yenile(ulke[] tutulan, Label label1, Label label2)
        {
            tutulan[0].asker_Label.Text = tutulan[0].asker_Adedi.ToString();
            label1.Text = tutulan[0].asker_Adedi.ToString();

            tutulan[1].asker_Label.Text = tutulan[1].asker_Adedi.ToString();
            label2.Text = tutulan[1].asker_Adedi.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tamam_btn = true;
            this.Close();
        }
    }

}
