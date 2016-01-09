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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 

       profil profill = new profil();

        private void Form1_Load(object sender, EventArgs e)
        {
            colorDialog1.Color = Color.Red;
            colorDialog2.Color = Color.Blue;
            profill.profil_control(txtbxp1, colorDialog1);
            profill.profil_control(textBoxp2, colorDialog2);
            
        }
        private void startbtn_Click(object sender, EventArgs e)
        {
            profill.control_Ekle();
            Games formgames = new Games();
            formgames.Show();
            this.Hide();
        }

        private void renk1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            profill.renk_ayarı(colorDialog1, rectangleShape1, txtbxp1, renk1, oyncuismi1);
        }

        private void renk2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            profill.renk_ayarı(colorDialog2, rectangleShape2, textBoxp2, renk2, oyncuismi2);

        }

    }
}
