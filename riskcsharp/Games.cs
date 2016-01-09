using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace riskcsharp
{
    public partial class Games : Form
    {
        public Games()
        {
            InitializeComponent();
        }

        public static riskcsharp.Harita haritaolustur = null;
        riskcsharp.ulke lastcity = null;
        riskcsharp.ulke secilenSehir = null;
        public static Graphics g;
        #region durumlar
        UlkeSec drm_UlkeSec = new UlkeSec(profil.oyuncular, "Ulke Sec");
        asker_dagit drm_askerDagit = new asker_dagit("Asker dagit");
        asker_dagit drm_askerDagit2 = new asker_dagit("Bonus Asker");
        drm_atak drm_atakk = new drm_atak("Atak");
        #endregion

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            System.Drawing.Point p = new Point(e.X, e.Y);

            g = pictureBox1.CreateGraphics();

            secilenSehir = haritaolustur.getCityAtPoint(p);

            if (secilenSehir == null)
            {
                return;
            }
            else if (Durum.dr_index == 0)//Durum:UlkeSec
            {

                drm_UlkeSec.renk_fill(g, p, secilenSehir, Sıradakioyuncu, panel1, Bonus_Asker, Secilen_Ulke, Harita.Ulkeler, İlerle, 21);
                //label'a yazdırma 
                haritaolustur.tablo_yenile(label7, label8, label9, label10);
            }
            else if (Durum.dr_index == 1) //Durum:ilk bonusAsker 
            {
                drm_askerDagit.askerdagitim_islem(secilenSehir, Durum.sırakimde, Secilen_Ulke, Sıradakioyuncu, panel1,label1,Bonus_Asker);
                haritaolustur.tablo_yenile(label7, label8, label9, label10);
                haritaolustur.tablo_yenile(label7, label8, label9, label10);

            }
            else if (Durum.dr_index == 2)
            {
                btngec.Visible = false;
                drm_askerDagit2.askerdagitim_2(secilenSehir, Durum.sırakimde, label1,Bonus_Asker);
                haritaolustur.tablo_yenile(label7, label8, label9, label10);

        	}
            else if (Durum.dr_index == 3)
            {
                btngec.Visible = true;
                drm_atakk.push(secilenSehir);
                drm_atakk.atak_(drm_atak.tutulanulke, Sıradakioyuncu, Secilen_Ulke, panel1,label1);
                haritaolustur.tablo_yenile(label7, label8, label9, label10);
                if (profil.oyuncular[0].Ulke_sayisi==0 || profil.oyuncular[1].Ulke_sayisi==0)
                {
                    MessageBox.Show(profil.oyuncular[1].ismioku());
                }
                else if(profil.oyuncular[1].Ulke_sayisi==0){
                
                 MessageBox.Show(profil.oyuncular[0].ismioku()+" kazandı..");
                }
            }

            Secilen_Ulke.Text = "Sectiginiz ulke " + secilenSehir.ismi;

        }

        private void Games_Load(object sender, EventArgs e)
        {

            //Ulkeler yukleniyor ve komsuları belirleniyor..
            haritaolustur = new riskcsharp.Harita();
            //ulke labelleri olusturuluyor..
            label_olustur();
            btngec.Visible = false;
            tooltip.Parent = pictureBox1;
            drm_UlkeSec.ortam_Controldegistir(Durum.sırakimde, Sıradakioyuncu, Secilen_Ulke, panel1);

            #region tablo
            haritaolustur.tablo_olustur(tableLayoutPanel1);
            #endregion //tablo olusturuluyor

            drm_askerDagit.durum_yaz(label1);

            #region picturebox parent
            kapapctr.Parent = pictureBox1;
            kapatimgbx.Parent = pictureBox1;
            Secilen_Ulke.Parent = pictureBox1;
            #endregion
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;

            System.Drawing.Point p = new Point(x, y);
            riskcsharp.ulke c = haritaolustur.getCityAtPoint(p);

            if (c == lastcity) return;

            if (c != null)
            {
                tooltip.Visible = true;
                Secilen_Ulke.Text = c.ismi;
                pictureBox1.Cursor = Cursors.Hand;
            }
            else
            {
                pictureBox1.Cursor = Cursors.Default;
            }
            lastcity = c;
        }

        private void kapatimgbx_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Çıkmak İstediğinizden emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (DialogResult.Yes == dr)
            {
                Application.Exit();
            }
        }

        private void kapapctr_MouseMove(object sender, MouseEventArgs e)
        {
            kapapctr.Visible = false;
            kapatimgbx.Visible = true;
        }

        private void kapatimgbx_MouseLeave(object sender, EventArgs e)
        {
            kapapctr.Visible = true;
            kapatimgbx.Visible = false;
        }

        void label_olustur()
        {
            for (int i = 0; i < Harita.labeller.Count; i++)
            {
                Harita.labeller[i].Parent = pictureBox1;
                Harita.labeller[i].BackColor = Color.Transparent;
                this.pictureBox1.Controls.Add(Harita.labeller[i]);
            }
        }

        private void İlerle_Click(object sender, EventArgs e)
        {
            if (Durum.dr_index == 0)
            {
                drm_askerDagit.durum_degistir(Durum.durumlar, label1);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btngec_Click(object sender, EventArgs e)
        {
           
            drm_atakk.oyuncu_Degistir(profil.oyuncular); 
            drm_atakk.durum_degistir(Durum.durumlar, label1);
            drm_UlkeSec.ortam_Controldegistir(Durum.sırakimde, Sıradakioyuncu, Secilen_Ulke, panel1);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
