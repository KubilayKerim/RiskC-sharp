using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace riskcsharp
{
    class profil
    {

        public static List<oyuncu> oyuncular = new List<oyuncu>(3);
        public static List<TextBox> textbox = new List<TextBox>();
        public static List<ColorDialog> colordialg = new List<ColorDialog>();
        public void  profil_control(TextBox txtbox,ColorDialog renk) {
                textbox.Add(txtbox);
                colordialg.Add(renk);

        }
        public profil() {
        }
        public profil(string isim,System.Drawing.Color renk) { 
        
        
        }
        public void control_Ekle() {
            for (int i = 0; i < textbox.Count ; i++)
            {
                oyuncular.Add(new oyuncu(textbox[i].Text,colordialg[i].Color));
            }
        }
        public void renk_ayarı(ColorDialog color,Microsoft.VisualBasic.PowerPacks.RectangleShape rec,TextBox text,LinkLabel llab,Label lab) {
          DialogResult sa = color.ShowDialog();
          if (sa == DialogResult.OK)
          {
              rec.FillColor  = color.Color;
              text.BackColor = color.Color;
              llab.BackColor = color.Color;
              lab.BackColor  = color.Color;
          }
       }
    }
}
