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
    public partial class drmAtak : Form
    {
        public drmAtak()
        {
            InitializeComponent();
        }
        public static bool saldırı_kazanıldı;
        public static bool iptal_btn;
        olasılık zar = new olasılık();
        private void drmAtak_Load(object sender, EventArgs e)
        {
            control_renklendir(atak_ulkerec1, ulkerec2, atak_label, Asker_Atak, def_label, Asker_def);
        }

        private void Iptal_btn_Click(object sender, EventArgs e)
        {
            iptal_btn = true;
            saldırı_kazanıldı = false;
            this.Close();
        }
        private void control_renklendir(RectangleShape atak_Rec,RectangleShape def_rec,Label atak_Ismi,Label atak_Asker,Label Def_Ismi,Label Def_Asker)
        {

            atak_Rec.FillColor = drm_atak.tutulanulke[0].sahip.renkoku();
            atak_Ismi.Text = drm_atak.tutulanulke[0].ismi;
            atak_Asker.Text = drm_atak.tutulanulke[0].asker_Adedi.ToString();
            // 
            def_rec.FillColor = drm_atak.tutulanulke[1].sahip.renkoku();
            Def_Ismi.Text = drm_atak.tutulanulke[1].ismi;
            Def_Asker.Text = drm_atak.tutulanulke[1].asker_Adedi.ToString();

        }
        private void Saldır_Btn_Click(object sender, EventArgs e)
        {
            zar.zar(drm_atak.tutulanulke[0], drm_atak.tutulanulke[1]);
                            label_yenile(drm_atak.tutulanulke, Asker_Atak, Asker_def);

            if (drm_atak.tutulanulke[1].asker_Adedi == 0 )
            {
                saldırı_kazanıldı = true;

                iptal_btn = false;
                this.Close();
            }
            else if ( drm_atak.tutulanulke[0].asker_Adedi==1) 
            {
                saldırı_kazanıldı = false;
                this.Close();
            }
        }
        private void label_yenile(ulke[] tutulan,Label label1,Label label2) 
        {  
            tutulan[0].asker_Label.Text = tutulan[0].asker_Adedi.ToString();
            label1.Text = tutulan[0].asker_Adedi.ToString();

            tutulan[1].asker_Label.Text = tutulan[1].asker_Adedi.ToString();
            label2.Text = tutulan[1].asker_Adedi.ToString();
        }
    }
}
