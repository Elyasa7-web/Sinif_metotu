using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinif_metotu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Araba cr = new Araba();
            cr.renk = "Siyah";
            cr.hiz = 180;
            cr.motor = 1100.340;
            cr.durum = 'İ';
            cr.fiyat = 35000;
            cr.YIL = 2016;
            cr.MARKASI = "Golf 5";
            cr.muayene = 2018;
            cr.plaka = "34 EUR 4857";
            cr.sahip = "Elyasa Kapucu";

            label1.Text = cr.renk;
            label2.Text = cr.hiz.ToString();
            label3.Text = cr.motor.ToString();
            label4.Text = cr.durum.ToString();
            label5.Text = cr.fiyat.ToString();
            label6.Text = cr.YIL.ToString();
            label7.Text = cr.MARKASI;
            label8.Text = cr.muayene.ToString();
            label9.Text = cr.plaka;
            label10.Text = cr.sahip;
            
            pictureBox1.BackColor = Color.Black;        
        }
    }
}
