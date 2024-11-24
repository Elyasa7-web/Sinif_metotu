using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinif_metotu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba rb = new Araba();
            rb.renk = "Yeşil";
            rb.hiz = 200;
            rb.motor= 1245.999;
            rb.durum = 'S';
            rb.fiyat = 55000;
            rb.YIL = 2015;
            rb.MARKASI = "Golf";
            rb.muayene = 2017;
            rb.plaka= "34 ELY 2002";
            rb.sahip = "Elyasa Kapucu";

            label1.Text = rb.renk;
            label2.Text = rb.hiz.ToString();
            label3.Text = rb.motor.ToString();
            label4.Text = rb.durum.ToString();
            label5.Text = rb.fiyat.ToString();
            label6.Text = rb.YIL.ToString();
            label7.Text = rb.MARKASI;
            label8.Text = rb.muayene.ToString();
            label9.Text = rb.plaka;
            label10.Text = rb.sahip;

            pictureBox1.BackColor = Color.Green;
        }
    }
}
