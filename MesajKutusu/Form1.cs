using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MesajKutusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int toplam;
            toplam=Convert.ToInt16(BirinciSayi.Text)+Convert.ToInt16(İkinciSayi.Text);

            sonuc.Text = toplam.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cikarma;
            cikarma = Convert.ToInt16(BirinciSayi.Text) - Convert.ToInt16(İkinciSayi.Text);

            
                sonuc.Text = cikarma.ToString();
            


            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double bolme;
            bolme = Convert.ToDouble(BirinciSayi.Text) / Convert.ToDouble(İkinciSayi.Text);

            sonuc.Text = bolme.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int carpma;
            carpma = Convert.ToInt16(BirinciSayi.Text) * Convert.ToInt16(İkinciSayi.Text);

            sonuc.Text = carpma.ToString();
        }
    }
}
